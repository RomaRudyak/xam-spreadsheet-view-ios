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
        public CGRect Frame;

        public CGSize ContentSize;

        public CGPoint ContentOffset;
    }

    [Native]
    public enum ZMJScrollPosition : ulong
    {
        Top = 1 << 0,
        CenteredVertiically = 1 << 1,
        Bottom = 1 << 2,
        Left = 1 << 3,
        CenteredHorizontally = 1 << 4,
        Right = 1 << 5
    }

    [Native]
    public enum GridStyleType : ulong
    {
        Default = 0,
        None,
        Solid
    }

    [Native]
    public enum BorderStyleType : ulong
    {
        None,
        Solid
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Direct
    {
        public nfloat Left;

        public nfloat Right;

        public nfloat Top;

        public nfloat Bottom;

        public bool NotNull;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct RectEdge
    {
        public Direct Top;

        public Direct Bottom;

        public Direct Left;

        public Direct Right;

        public bool NotNull;
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
        public nint StartColumn;

        public nint StartRow;

        public nint NumberOfColumns;

        public nint NumberOfRows;

        public nint ColumnCount;

        public nint RowCount;

        public CGPoint Insets;
    }

    [Native]
    public enum ZMJDirection : ulong
    {
        Vertically = 1 << 0,
        Horizontally = 1 << 1,
        Both = Vertically | Horizontally
    }

    [Native]
    public enum ZMJTableStyle : ulong
    {
        ColumnHeaderNotRepeated = 1 << 0,
        RowHeaderNotRepeated = 1 << 1
    }

    [Native]
    public enum ZMJHeaderStyle : ulong
    {
        None,
        ColumnHeaderStartsFirstRow,
        RowHeaderStartsFirstColumn
    }

    [Native]
    public enum CircularScrollingConfigurationState : ulong
    {
        None = 0,
        Horizontally = 1 << 0,
        HorizontallyRowHeaderStartsFirstColumn = 1 << 1,
        HorizontallyColumnHeaderNotRepeated = 1 << 2,
        HorizontallyColumnHeaderNotRepeatedRowHeaderStartsFirstColumn = 1 << 3,
        Vertically = 1 << 4,
        VerticallyColumnHeaderStartsFirstRow = 1 << 5,
        VerticallyRowHeaderNotRepeated = 1 << 6,
        VerticallyRowHeaderNotRepeatedColumnHeaderStartsFirstRow = 1 << 7,
        Both = 1 << 8,
        BothRowHeaderStartsFirstColumn = 1 << 9,
        BothColumnHeaderStartsFirstRow = 1 << 10,
        BothRowHeaderStartsFirstColumn_rowHeaderNotRepeated = 1 << 11,
        BothColumnHeaderStartsFirstRow_columnHeaderNotRepeated = 1 << 12,
        BothColumnHeaderNotRepeated = 1 << 13,
        BothColumnHeaderNotRepeatedRrowHeaderStartsFirstColumn = 1 << 14,
        BothColumnHeaderNotRepeatedColumnHeaderStartsFirstRow = 1 << 15,
        BothColumnHeaderNotRepeatedRowHeaderNotRepeated = 1 << 16,
        BothColumnHeaderNotRepeatedRowHeaderNotRepeatedRowHeaderStartsFirstColumn = 1 << 17,
        BothColumnHeaderNotRepeatedRowHeaderNotRepeatedColumnHeaderStartsFirstRow = 1 << 18,
        BothRowHeaderNotRepeated = 1 << 19,
        BothRowHeaderNotRepeatedRowHeaderStartsFirstColumn = 1 << 20,
        BothRowHeaderNotRepeatedColumnHeaderStartsFirstRow = 1 << 21,
        BothRowHeaderNotRepeatedColumnHeaderNotRepeated = 1 << 22,
        BothRowHeaderNotRepeatedColumnHeaderNotRepeatedRowHeaderStartsFirstColumn = 1 << 23,
        BothRowHeaderNotRepeatedColumnHeaderNotRepeatedColumnHeaderStartsFirstRow = 1 << 24
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct CircularScrollScalingFactor
    {
        public nint Horizontal;

        public nint Vertical;
    }
}
