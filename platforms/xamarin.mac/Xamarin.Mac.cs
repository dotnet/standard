// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace AppKit
{
}
namespace AudioToolbox
{
}
namespace AudioUnit
{
}
namespace AVFoundation
{
}
namespace AVKit
{
}
namespace CFNetwork
{
}
namespace CloudKit
{
}
namespace Contacts
{
}
namespace ContactsUI
{
}
namespace CoreAnimation
{
}
namespace CoreBluetooth
{
}
namespace CoreData
{
}
namespace CoreFoundation
{
}
namespace CoreGraphics
{
}
namespace CoreImage
{
}
namespace CoreLocation
{
}
namespace CoreMedia
{
}
namespace CoreMidi
{
}
namespace CoreServices
{
}
namespace CoreText
{
}
namespace CoreWlan
{
}
namespace FinderSync
{
}
namespace Foundation
{
}
namespace GameKit
{
}
namespace GameplayKit
{
}
namespace GLKit
{
}
namespace ImageKit
{
}
namespace Intents
{
}
namespace JavaScriptCore
{
}
namespace MapKit
{
}
namespace Metal
{
}
namespace MetalKit
{
}
namespace ModelIO
{
}
namespace MultipeerConnectivity
{
}
namespace NetworkExtension
{
}
namespace NotificationCenter
{
}
namespace ObjCRuntime
{
}
namespace PdfKit
{
}
namespace Photos
{
}
namespace PrintCore
{
}
namespace QTKit
{
}
namespace QuickLookUI
{
}
namespace SafariServices
{
}
namespace SceneKit
{
}
namespace ScriptingBridge
{
}
namespace Security
{
}
namespace SpriteKit
{
}
namespace StoreKit
{
}
namespace System.Drawing
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Point
    {
        public static readonly System.Drawing.Point Empty;
        public Point(System.Drawing.Size sz) { throw null;}
        public Point(int dw) { throw null;}
        public Point(int x, int y) { throw null;}
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        public int X { get { throw null; } set { } }
        public int Y { get { throw null; } set { } }
        public static System.Drawing.Point Add(System.Drawing.Point pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.Point Ceiling(System.Drawing.PointF value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public void Offset(System.Drawing.Point p) { }
        public void Offset(int dx, int dy) { }
        public static System.Drawing.Point operator +(System.Drawing.Point pt, System.Drawing.Size sz) { throw null; }
        public static bool operator ==(System.Drawing.Point left, System.Drawing.Point right) { throw null; }
        public static explicit operator System.Drawing.Size (System.Drawing.Point p) { throw null; }
        public static implicit operator System.Drawing.PointF (System.Drawing.Point p) { throw null; }
        public static bool operator !=(System.Drawing.Point left, System.Drawing.Point right) { throw null; }
        public static System.Drawing.Point operator -(System.Drawing.Point pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.Point Round(System.Drawing.PointF value) { throw null; }
        public static System.Drawing.Point Subtract(System.Drawing.Point pt, System.Drawing.Size sz) { throw null; }
        public override string ToString() { throw null; }
        public static System.Drawing.Point Truncate(System.Drawing.PointF value) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct PointF
    {
        public static readonly System.Drawing.PointF Empty;
        public PointF(float x, float y) { throw null;}
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        public float X { get { throw null; } set { } }
        public float Y { get { throw null; } set { } }
        public static System.Drawing.PointF Add(System.Drawing.PointF pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.PointF Add(System.Drawing.PointF pt, System.Drawing.SizeF sz) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Drawing.PointF operator +(System.Drawing.PointF pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.PointF operator +(System.Drawing.PointF pt, System.Drawing.SizeF sz) { throw null; }
        public static bool operator ==(System.Drawing.PointF left, System.Drawing.PointF right) { throw null; }
        public static bool operator !=(System.Drawing.PointF left, System.Drawing.PointF right) { throw null; }
        public static System.Drawing.PointF operator -(System.Drawing.PointF pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.PointF operator -(System.Drawing.PointF pt, System.Drawing.SizeF sz) { throw null; }
        public static System.Drawing.PointF Subtract(System.Drawing.PointF pt, System.Drawing.Size sz) { throw null; }
        public static System.Drawing.PointF Subtract(System.Drawing.PointF pt, System.Drawing.SizeF sz) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Rectangle
    {
        public static readonly System.Drawing.Rectangle Empty;
        public Rectangle(System.Drawing.Point location, System.Drawing.Size size) { throw null;}
        public Rectangle(int x, int y, int width, int height) { throw null;}
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Bottom { get { throw null; } }
        public int Height { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Left { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Drawing.Point Location { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Right { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Drawing.Size Size { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public int Top { get { throw null; } }
        public int Width { get { throw null; } set { } }
        public int X { get { throw null; } set { } }
        public int Y { get { throw null; } set { } }
        public static System.Drawing.Rectangle Ceiling(System.Drawing.RectangleF value) { throw null; }
        public bool Contains(System.Drawing.Point pt) { throw null; }
        public bool Contains(System.Drawing.Rectangle rect) { throw null; }
        public bool Contains(int x, int y) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static System.Drawing.Rectangle FromLTRB(int left, int top, int right, int bottom) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Drawing.Rectangle Inflate(System.Drawing.Rectangle rect, int x, int y) { throw null; }
        public void Inflate(System.Drawing.Size size) { }
        public void Inflate(int width, int height) { }
        public void Intersect(System.Drawing.Rectangle rect) { }
        public static System.Drawing.Rectangle Intersect(System.Drawing.Rectangle a, System.Drawing.Rectangle b) { throw null; }
        public bool IntersectsWith(System.Drawing.Rectangle rect) { throw null; }
        public void Offset(System.Drawing.Point pos) { }
        public void Offset(int x, int y) { }
        public static bool operator ==(System.Drawing.Rectangle left, System.Drawing.Rectangle right) { throw null; }
        public static bool operator !=(System.Drawing.Rectangle left, System.Drawing.Rectangle right) { throw null; }
        public static System.Drawing.Rectangle Round(System.Drawing.RectangleF value) { throw null; }
        public override string ToString() { throw null; }
        public static System.Drawing.Rectangle Truncate(System.Drawing.RectangleF value) { throw null; }
        public static System.Drawing.Rectangle Union(System.Drawing.Rectangle a, System.Drawing.Rectangle b) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct RectangleF
    {
        public static readonly System.Drawing.RectangleF Empty;
        public RectangleF(System.Drawing.PointF location, System.Drawing.SizeF size) { throw null;}
        public RectangleF(float x, float y, float width, float height) { throw null;}
        [System.ComponentModel.BrowsableAttribute(false)]
        public float Bottom { get { throw null; } }
        public float Height { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public float Left { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Drawing.PointF Location { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public float Right { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Drawing.SizeF Size { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public float Top { get { throw null; } }
        public float Width { get { throw null; } set { } }
        public float X { get { throw null; } set { } }
        public float Y { get { throw null; } set { } }
        public bool Contains(System.Drawing.PointF pt) { throw null; }
        public bool Contains(System.Drawing.RectangleF rect) { throw null; }
        public bool Contains(float x, float y) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public static System.Drawing.RectangleF FromLTRB(float left, float top, float right, float bottom) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Drawing.RectangleF Inflate(System.Drawing.RectangleF rect, float x, float y) { throw null; }
        public void Inflate(System.Drawing.SizeF size) { }
        public void Inflate(float x, float y) { }
        public void Intersect(System.Drawing.RectangleF rect) { }
        public static System.Drawing.RectangleF Intersect(System.Drawing.RectangleF a, System.Drawing.RectangleF b) { throw null; }
        public bool IntersectsWith(System.Drawing.RectangleF rect) { throw null; }
        public void Offset(System.Drawing.PointF pos) { }
        public void Offset(float x, float y) { }
        public static bool operator ==(System.Drawing.RectangleF left, System.Drawing.RectangleF right) { throw null; }
        public static implicit operator System.Drawing.RectangleF (System.Drawing.Rectangle r) { throw null; }
        public static bool operator !=(System.Drawing.RectangleF left, System.Drawing.RectangleF right) { throw null; }
        public override string ToString() { throw null; }
        public static System.Drawing.RectangleF Union(System.Drawing.RectangleF a, System.Drawing.RectangleF b) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Size
    {
        public static readonly System.Drawing.Size Empty;
        public Size(System.Drawing.Point pt) { throw null;}
        public Size(int width, int height) { throw null;}
        public int Height { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        public int Width { get { throw null; } set { } }
        public static System.Drawing.Size Add(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public static System.Drawing.Size Ceiling(System.Drawing.SizeF value) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Drawing.Size operator +(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public static bool operator ==(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public static explicit operator System.Drawing.Point (System.Drawing.Size size) { throw null; }
        public static implicit operator System.Drawing.SizeF (System.Drawing.Size p) { throw null; }
        public static bool operator !=(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public static System.Drawing.Size operator -(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public static System.Drawing.Size Round(System.Drawing.SizeF value) { throw null; }
        public static System.Drawing.Size Subtract(System.Drawing.Size sz1, System.Drawing.Size sz2) { throw null; }
        public override string ToString() { throw null; }
        public static System.Drawing.Size Truncate(System.Drawing.SizeF value) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SizeF
    {
        public static readonly System.Drawing.SizeF Empty;
        public SizeF(System.Drawing.PointF pt) { throw null;}
        public SizeF(System.Drawing.SizeF size) { throw null;}
        public SizeF(float width, float height) { throw null;}
        public float Height { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public bool IsEmpty { get { throw null; } }
        public float Width { get { throw null; } set { } }
        public static System.Drawing.SizeF Add(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Drawing.SizeF operator +(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public static bool operator ==(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public static explicit operator System.Drawing.PointF (System.Drawing.SizeF size) { throw null; }
        public static bool operator !=(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public static System.Drawing.SizeF operator -(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public static System.Drawing.SizeF Subtract(System.Drawing.SizeF sz1, System.Drawing.SizeF sz2) { throw null; }
        public System.Drawing.PointF ToPointF() { throw null; }
        public System.Drawing.Size ToSize() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Net.Http
{
}
namespace VideoToolbox
{
}
namespace WebKit
{
}
