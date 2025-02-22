// This source file is adapted from the Windows Presentation Foundation project. 
// (https://github.com/dotnet/wpf/) 
// 
// Licensed to The Avalonia Project under MIT License, courtesy of The .NET Foundation.

using System.Diagnostics;
using Avalonia.Layout;

namespace VirtualPanelTest.Controls.FortnitePorting;

 /// <summary>
 /// Used to not write sepearate code for horizontal and vertical orientation.
 /// U is direction in line. (x if orientation is horizontal)
 /// V is direction of lines. (y if orientation is horizonral)
 /// </summary>
 [DebuggerDisplay("U = {U} V = {V}")]
internal struct UVSize
{
    internal UVSize(Orientation orientation, double width, double height)
    {
        U = V = 0d;
        Orientation = orientation;
        Width = width;
        Height = height;
    }

    internal UVSize(Orientation orientation)
    {
        U = V = 0d;
        Orientation = orientation;
    }

    internal double U;
    internal double V;
    internal Orientation Orientation;
    internal bool IsNaN => double.IsNaN(U) || double.IsNaN(V);

    internal double Width
    {
        get => Orientation == Orientation.Horizontal ? U : V;
        set
        {
            if (Orientation == Orientation.Horizontal) U = value;
            else V = value;
        }
    }

    internal double Height
    {
        get => Orientation == Orientation.Horizontal ? V : U;
        set
        {
            if (Orientation == Orientation.Horizontal) V = value;
            else U = value;
        }
    }
}