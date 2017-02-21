using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.DotNet.Build.Tasks
{
    class Trimmable
    {
        private static readonly string[] defaultPackages = { "Microsoft.NETCore.App", "NETStandard.Library", "Microsoft.NETCore.UniversalWindowsPlatform"};

        private HashSet<string> _trimmablePackages;
        private HashSet<string> _trimmableFiles;
        public Trimmable(IEnumerable<string> additionalPackages, IEnumerable<string> trimmableFiles)
        {
            _trimmablePackages = new HashSet<string>(defaultPackages, StringComparer.OrdinalIgnoreCase);
            _trimmableFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            if (additionalPackages != null)
            {
                foreach(var additionalPackage in additionalPackages)
                {
                    _trimmablePackages.Add(additionalPackage);
                }
            }

            if (trimmableFiles != null)
            {
                foreach(var trimmableFile in trimmableFiles)
                {
                    _trimmableFiles.Add(trimmableFile);
                }
            }
        }

        public bool IsPackageTrimmable(string packageId)
        {
            return _trimmablePackages.Contains(packageId);
        }

        public bool IsFileTrimmable(string fileName)
        {
            return _trimmableFiles.Contains(fileName);
        }
    }
}
