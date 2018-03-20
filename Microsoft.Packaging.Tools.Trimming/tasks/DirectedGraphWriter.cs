// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Microsoft.DotNet.Build.Tasks
{
    internal class DirectedGraphWriter
    {
        private static XNamespace s_dgmlns = @"http://schemas.microsoft.com/vs/2009/dgml";

        private const string Background = "Background";
        private const string Categories = "Categories";
        private const string Category = "Category";
        private const string Collapsed = "Collapsed";
        private const string Condition = "Condition";
        private const string Contains = "Contains";
        private const string DataType = "DataType";
        private const string DirectedGraph = "DirectedGraph";
        private const string Expanded = "Expanded";
        private const string Expression = "Expression";
        private const string FileCategory = "File";
        private const string FileDependencyCategory = "FileDependency";
        private const string Group = "Group";
        private const string GroupLabel = "GroupLabel";
        private const string Icon = "Icon";
        private const string Id = "Id";
        private const string IncludedProperty = "Included";
        private const string Label = "Label";
        private const string Link = "Link";
        private const string Links = "Links";
        private const string Node = "Node";
        private const string Nodes = "Nodes";
        private const string PackageCategory = "Package";
        private const string PackageDependencyCategory = "PackageDependency";
        private const string Properties = "Properties";
        private const string Property = "Property";
        private const string Root = "Root";
        private const string RootCategory = "Root";
        private const string Setter = "Setter";
        private const string Source = "Source";
        private const string Stroke = "Stroke";
        private const string Style = "Style";
        private const string Styles = "Styles";
        private const string Target = "Target";
        private const string TargetType = "TargetType";
        private const string Value = "Value";
        private const string ValueLabel = "ValueLabel";


        public static void WriteGraph(string graphFilePath, IEnumerable<FileNode> files, IEnumerable<NuGetPackageNode> packages, IEnumerable<FileNode> fileRoots, IEnumerable<NuGetPackageNode> packageRoots)
        {
            var doc = new XDocument(new XElement(s_dgmlns + DirectedGraph));

            doc.Root.Add(new XElement(s_dgmlns + Properties,
                new XElement(s_dgmlns + Property,
                    new XAttribute(Id, IncludedProperty),
                    new XAttribute(DataType, "System.Boolean")
                )));

            doc.Root.Add(new XElement(s_dgmlns + Styles,
                new XElement(s_dgmlns + Style,
                    new XAttribute(TargetType, Node),
                    new XAttribute(GroupLabel, IncludedProperty),
                    new XAttribute(ValueLabel, true),
                    new XElement(s_dgmlns + Condition,
                        new XAttribute(Expression, $"{IncludedProperty}='{true}'")),
                    new XElement(s_dgmlns + Setter,
                        new XAttribute(Property, Background),
                        new XAttribute(Value, "LightBlue"))
                    ),
                new XElement(s_dgmlns + Style,
                    new XAttribute(TargetType, Link),
                    new XAttribute(GroupLabel, IncludedProperty),
                    new XAttribute(ValueLabel, true),
                    new XElement(s_dgmlns + Condition,
                        new XAttribute(Expression, $"{IncludedProperty}='{true}'")),
                    new XElement(s_dgmlns + Setter,
                        new XAttribute(Property, Stroke),
                        new XAttribute(Value, "LightBlue"))
                    )
                ));

            doc.Root.Add(new XElement(s_dgmlns + Categories,
                new XElement(s_dgmlns + Category,
                    new XAttribute(Id, FileCategory),
                    new XAttribute(Icon, FileCategory)),
                new XElement(s_dgmlns + Category,
                    new XAttribute(Id, FileDependencyCategory)),
                new XElement(s_dgmlns + Category,
                    new XAttribute(Id, PackageCategory)),
                new XElement(s_dgmlns + Category,
                    new XAttribute(Id, PackageDependencyCategory)),
                new XElement(s_dgmlns + Category,
                    new XAttribute(Id, RootCategory))));

            var nodesElement = new XElement(s_dgmlns + Nodes);
            var linksElement = new XElement(s_dgmlns + Links);
            doc.Root.Add(nodesElement);
            doc.Root.Add(linksElement);

            nodesElement.Add(new XElement(s_dgmlns + Node,
                    new XAttribute(Id, Root),
                    new XAttribute(Category, RootCategory),
                    new XAttribute(IncludedProperty, true)));

            foreach (var fileRoot in fileRoots)
            {
                linksElement.Add(new XElement(s_dgmlns + Link,
                    new XAttribute(Source, Root),
                    new XAttribute(Target, GetFileId(fileRoot)),
                    new XAttribute(Category, RootCategory),
                    new XAttribute(IncludedProperty, true)));
            }

            foreach (var packageRoot in packageRoots)
            {
                linksElement.Add(new XElement(s_dgmlns + Link,
                    new XAttribute(Source, Root),
                    new XAttribute(Target, GetPackageId(packageRoot)),
                    new XAttribute(Category, RootCategory),
                    new XAttribute(IncludedProperty, true)));
            }

            foreach (var file in files)
            {
                AddFileNode(file, nodesElement, linksElement);
            }

            foreach (var package in packages)
            {
                var packageId = GetPackageId(package);

                nodesElement.Add(new XElement(s_dgmlns + Node,
                        new XAttribute(Id, packageId),
                        new XAttribute(Label, package.Id),
                        new XAttribute(Group, (package.IsIncluded || package.Files.Any(f => f.IsIncluded)) ? Expanded : Collapsed),
                        new XAttribute(Category, PackageCategory),
                        new XAttribute(IncludedProperty, package.IsIncluded)));

                foreach (var dependency in package.Dependencies)
                {
                    bool isIncluded = package.IsIncluded && dependency.IsIncluded;

                    linksElement.Add(new XElement(s_dgmlns + Link,
                        new XAttribute(Source, packageId),
                        new XAttribute(Target, GetPackageId(dependency)),
                        new XAttribute(Category, PackageDependencyCategory),
                        new XAttribute(IncludedProperty, isIncluded)));
                }

                foreach(var file in package.Files)
                {
                    linksElement.Add(new XElement(s_dgmlns + Link,
                        new XAttribute(Source, packageId),
                        new XAttribute(Target, GetFileId(file)),
                        new XAttribute(Category, Contains)));
                }
            }

            var directory = Path.GetDirectoryName(graphFilePath);

            if (!string.IsNullOrEmpty(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (var file = File.Create(graphFilePath))
            {
                doc.Save(file);
            }
        }

        private static void AddFileNode(FileNode file, XElement nodesElement, XElement linksElement)
        {
            var fileId = GetFileId(file);

            nodesElement.Add(new XElement(s_dgmlns + Node,
                    new XAttribute(Id, fileId),
                    new XAttribute(Label, file.Name),
                    new XAttribute(Category, FileCategory),
                    new XAttribute(IncludedProperty, file.IsIncluded)));

            foreach (var dependency in file.Dependencies)
            {
                bool isIncluded = file.IsIncluded && dependency.IsIncluded;

                linksElement.Add(new XElement(s_dgmlns + Link,
                    new XAttribute(Source, fileId),
                    new XAttribute(Target, GetFileId(dependency)),
                    new XAttribute(Category, FileDependencyCategory),
                    new XAttribute(IncludedProperty, isIncluded)));

                if (file.IsAggregate)
                {
                    AddFileNode(dependency, nodesElement, linksElement);
                }
            }

            foreach (var relatedFile in file.RelatedFiles)
            {
                bool isIncluded = file.IsIncluded && relatedFile.IsIncluded;

                linksElement.Add(new XElement(s_dgmlns + Link,
                    new XAttribute(Source, fileId),
                    new XAttribute(Target, GetFileId(relatedFile)),
                    new XAttribute(Category, FileDependencyCategory),
                    new XAttribute(IncludedProperty, isIncluded)));
            }
        }

        private static string GetFileId(FileNode file)
        {
            return "f:" + file.SourceFile ?? file.Name;
        }

        private static string GetPackageId(NuGetPackageNode package)
        {
            return "p:" + package.Id;
        }

    }
}
