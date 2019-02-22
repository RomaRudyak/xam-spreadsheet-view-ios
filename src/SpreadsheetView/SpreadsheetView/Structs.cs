using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace Spreadsheet
{
    [StructLayout(LayoutKind.Sequential)]
    public struct State
    {
        public CGRect frame;

        public CGSize contentSize;

        public CGPoint contentOffset;
    }

    [Native]
    public enum ZMJScrollPosition : ulong
    {
        top = 1 << 0,
        centeredVertiically = 1 << 1,
        bottom = 1 << 2,
        left = 1 << 3,
        centeredHorizontally = 1 << 4,
        right = 1 << 5
    }

    [Native]
    public enum GridStyleType : ulong
    {
        @default = 0,
        none,
        solid
    }

    [Native]
    public enum BorderStyleType : ulong
    {
        None,
        solid
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Direct
    {
        public nfloat left;

        public nfloat right;

        public nfloat top;

        public nfloat bottom;

        public bool notNull;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RectEdge
    {
        public Direct top;

        public Direct bottom;

        public Direct left;

        public Direct right;

        public bool notNull;
    }

    [Native]
    public enum RectEdgeDirection : ulong
    {
        Up = 0,
        Down,
        Left,
        Right
    }

    static class CFunctions
    {
        // RectEdge RectEdgeMake (RectEdgeDirection direction, CGFloat top, CGFloat left, CGFloat bottom, CGFloat right);
        [DllImport("__Internal")]
        static extern RectEdge RectEdgeMake(RectEdgeDirection direction, nfloat top, nfloat left, nfloat bottom, nfloat right);

        // BOOL RectEdgeEqualToRectEdge (RectEdge rectEdge1, RectEdge rectEdge2);
        [DllImport("__Internal")]
        static extern bool RectEdgeEqualToRectEdge(RectEdge rectEdge1, RectEdge rectEdge2);

        // NSString * RectEdgeDescription (RectEdge rectEdge);
        [DllImport("__Internal")]
        static extern NSString RectEdgeDescription(RectEdge rectEdge);

        // CircularScrollScalingFactor CircularScrollScalingFactorMake (NSInteger horizontal, NSInteger vertical);
        [DllImport("__Internal")]
        static extern CircularScrollScalingFactor CircularScrollScalingFactorMake(nint horizontal, nint vertical);
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct LayoutAttributes
    {
        public nint startColumn;

        public nint startRow;

        public nint numberOfColumns;

        public nint numberOfRows;

        public nint columnCount;

        public nint rowCount;

        public CGPoint insets;
    }

    [Native]
    public enum ZMJDirection : ulong
    {
        vertically = 1 << 0,
        horizontally = 1 << 1,
        both = vertically | horizontally
    }

    [Native]
    public enum ZMJTableStyle : ulong
    {
        columnHeaderNotRepeated = 1 << 0,
        rowHeaderNotRepeated = 1 << 1
    }

    [Native]
    public enum ZMJHeaderStyle : ulong
    {
        none,
        columnHeaderStartsFirstRow,
        rowHeaderStartsFirstColumn
    }

    [Native]
    public enum CircularScrollingConfigurationState : ulong
    {
        none = 0,
        horizontally = 1 << 0,
        horizontally_rowHeaderStartsFirstColumn = 1 << 1,
        horizontally_columnHeaderNotRepeated = 1 << 2,
        horizontally_columnHeaderNotRepeated_rowHeaderStartsFirstColumn = 1 << 3,
        vertically = 1 << 4,
        vertically_columnHeaderStartsFirstRow = 1 << 5,
        vertically_rowHeaderNotRepeated = 1 << 6,
        vertically_rowHeaderNotRepeated_columnHeaderStartsFirstRow = 1 << 7,
        both = 1 << 8,
        both_rowHeaderStartsFirstColumn = 1 << 9,
        both_columnHeaderStartsFirstRow = 1 << 10,
        both_rowHeaderStartsFirstColumn_rowHeaderNotRepeated = 1 << 11,
        both_columnHeaderStartsFirstRow_columnHeaderNotRepeated = 1 << 12,
        both_columnHeaderNotRepeated = 1 << 13,
        both_columnHeaderNotRepeated_rowHeaderStartsFirstColumn = 1 << 14,
        both_columnHeaderNotRepeated_columnHeaderStartsFirstRow = 1 << 15,
        both_columnHeaderNotRepeated_rowHeaderNotRepeated = 1 << 16,
        both_columnHeaderNotRepeated_rowHeaderNotRepeated_rowHeaderStartsFirstColumn = 1 << 17,
        both_columnHeaderNotRepeated_rowHeaderNotRepeated_columnHeaderStartsFirstRow = 1 << 18,
        both_rowHeaderNotRepeated = 1 << 19,
        both_rowHeaderNotRepeated_rowHeaderStartsFirstColumn = 1 << 20,
        both_rowHeaderNotRepeated_columnHeaderStartsFirstRow = 1 << 21,
        both_rowHeaderNotRepeated_columnHeaderNotRepeated = 1 << 22,
        both_rowHeaderNotRepeated_columnHeaderNotRepeated_rowHeaderStartsFirstColumn = 1 << 23,
        both_rowHeaderNotRepeated_columnHeaderNotRepeated_columnHeaderStartsFirstRow = 1 << 24
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CircularScrollScalingFactor
    {
        public nint horizontal;

        public nint vertical;
    }
}
