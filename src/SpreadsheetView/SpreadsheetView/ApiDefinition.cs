using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Collections.Generic;

namespace Spreadsheet
{
    // @interface Address : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface Address : INSCopying
    {
        // @property (assign, nonatomic) NSInteger row;
        [Export("row")]
        nint Row { get; set; }

        // @property (assign, nonatomic) NSInteger column;
        [Export("column")]
        nint Column { get; set; }

        // @property (assign, nonatomic) NSInteger rowIndex;
        [Export("rowIndex")]
        nint RowIndex { get; set; }

        // @property (assign, nonatomic) NSInteger columnIndex;
        [Export("columnIndex")]
        nint ColumnIndex { get; set; }

        // -(instancetype)initWithRow:(NSInteger)row column:(NSInteger)column rowIndex:(NSInteger)rowIndex columnIndex:(NSInteger)columnIndex;
        [Export("initWithRow:column:rowIndex:columnIndex:")]
        IntPtr Constructor(nint row, nint column, nint rowIndex, nint columnIndex);

        // +(instancetype)addressWithRow:(NSInteger)row column:(NSInteger)column rowIndex:(NSInteger)rowIndex columnIndex:(NSInteger)columnIndex;
        [Static]
        [Export("addressWithRow:column:rowIndex:columnIndex:")]
        Address AddressWithRow(nint row, nint column, nint rowIndex, nint columnIndex);
    }

    // typedef void (^TouchHandler)(NSSet<UITouch *> *, UIEvent *);
    delegate void TouchHandler(NSSet<UITouch> arg0, UIEvent arg1);

    // @interface Borders : NSObject
    [BaseType(typeof(NSObject))]
    interface Borders
    {
        // @property (nonatomic, strong) BorderStyle * top;
        [Export("top", ArgumentSemantic.Strong)]
        BorderStyle Top { get; set; }

        // @property (nonatomic, strong) BorderStyle * bottom;
        [Export("bottom", ArgumentSemantic.Strong)]
        BorderStyle Bottom { get; set; }

        // @property (nonatomic, strong) BorderStyle * left;
        [Export("left", ArgumentSemantic.Strong)]
        BorderStyle Left { get; set; }

        // @property (nonatomic, strong) BorderStyle * right;
        [Export("right", ArgumentSemantic.Strong)]
        BorderStyle Right { get; set; }

        // -(instancetype)initWithTop:(BorderStyle *)top bottom:(BorderStyle *)bottom left:(BorderStyle *)left right:(BorderStyle *)right;
        [Export("initWithTop:bottom:left:right:")]
        IntPtr Constructor(BorderStyle top, BorderStyle bottom, BorderStyle left, BorderStyle right);

        // +(instancetype)all:(BorderStyle *)style;
        [Static]
        [Export("all:")]
        Borders All(BorderStyle style);
    }

    // @interface BorderStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface BorderStyle
    {
        // @property (assign, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; set; }

        // @property (nonatomic, strong) UIColor * color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (assign, nonatomic) BorderStyle_Enum border_enum;
        [Export("border_enum", ArgumentSemantic.Assign)]
        BorderStyleType Border_enum { get; set; }

        // -(instancetype)initWithStyle:(BorderStyle_Enum)style_enum width:(CGFloat)widith color:(UIColor *)color;
        [Export("initWithStyle:width:color:")]
        IntPtr Constructor(BorderStyleType style_enum, nfloat widith, UIColor color);

        // +(instancetype)borderStyleNone;
        [Static]
        [Export("borderStyleNone")]
        BorderStyle BorderStyleNone { get; }

        // @property (assign, nonatomic) BOOL hasBorders;
        [Export("hasBorders")]
        bool HasBorders { get; set; }
    }

    // @interface Border : UIView
    [BaseType(typeof(UIView))]
    interface Border : INativeObject
    {
        // @property (nonatomic, strong) Borders * borders;
        [Export("borders", ArgumentSemantic.Strong)]
        Borders Borders { get; set; }
    }

    // @protocol CircularScrollingConfiguration
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface CircularScrollingConfiguration
    {
        // @required -(Options *)options;
        [Abstract]
        [Export("options")]
        Options Options { get; }
    }

    // @interface CircularScrollingConfigurationBuilder : NSObject <CircularScrollingConfiguration>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface CircularScrollingConfigurationBuilder : CircularScrollingConfiguration
    {
        // -(instancetype)initWithCircularScrollingState:(CircularScrollingConfigurationState)state;
        [Export("initWithCircularScrollingState:")]
        IntPtr Constructor(CircularScrollingConfigurationState state);

        // +(instancetype)configurationBuilderWithCircularScrollingState:(CircularScrollingConfigurationState)state;
        [Static]
        [Export("configurationBuilderWithCircularScrollingState:")]
        CircularScrollingConfigurationBuilder ConfigurationBuilderWithCircularScrollingState(CircularScrollingConfigurationState state);

        // @property (assign, nonatomic) CircularScrollingConfigurationState state;
        [Export("state", ArgumentSemantic.Assign)]
        CircularScrollingConfigurationState State { get; set; }
    }

    interface ICircularScrollingConfiguration { }

    // @interface Configuration : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface Configuration
    {
        // +(instancetype)instance;
        [Static]
        [Export("instance")]
        Configuration Instance { get; }

        // @property (nonatomic, strong) CircularScrollingConfigurationBuilder * none;
        [Export("none", ArgumentSemantic.Strong)]
        CircularScrollingConfigurationBuilder None { get; set; }

        // @property (nonatomic, strong) CircularScrollingConfigurationBuilder * horizontally;
        [Export("horizontally", ArgumentSemantic.Strong)]
        CircularScrollingConfigurationBuilder Horizontally { get; set; }

        // @property (nonatomic, strong) CircularScrollingConfigurationBuilder * vertically;
        [Export("vertically", ArgumentSemantic.Strong)]
        CircularScrollingConfigurationBuilder Vertically { get; set; }

        // @property (nonatomic, strong) CircularScrollingConfigurationBuilder * both;
        [Export("both", ArgumentSemantic.Strong)]
        CircularScrollingConfigurationBuilder Both { get; set; }
    }

    // @interface Options : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface Options
    {
        // -(instancetype)initWithDirection:(ZMJDirection)direction headerStyle:(ZMJHeaderStyle)headerStyle tableStyle:(ZMJTableStyle)tableStyle;
        [Export("initWithDirection:headerStyle:tableStyle:")]
        IntPtr Constructor(ZMJDirection direction, ZMJHeaderStyle headerStyle, ZMJTableStyle tableStyle);

        // +(instancetype)optionsWithDirection:(ZMJDirection)direction headerStyle:(ZMJHeaderStyle)headerStyle tableStyle:(ZMJTableStyle)tableStyle;
        [Static]
        [Export("optionsWithDirection:headerStyle:tableStyle:")]
        Options OptionsWithDirection(ZMJDirection direction, ZMJHeaderStyle headerStyle, ZMJTableStyle tableStyle);

        // @property (assign, nonatomic) ZMJDirection direction;
        [Export("direction", ArgumentSemantic.Assign)]
        ZMJDirection Direction { get; set; }

        // @property (assign, nonatomic) ZMJHeaderStyle headerStyle;
        [Export("headerStyle", ArgumentSemantic.Assign)]
        ZMJHeaderStyle HeaderStyle { get; set; }

        // @property (assign, nonatomic) ZMJTableStyle tableStyle;
        [Export("tableStyle", ArgumentSemantic.Assign)]
        ZMJTableStyle TableStyle { get; set; }
    }

    // @interface CircualrScrolling : NSObject
    [BaseType(typeof(NSObject))]
    interface CircualrScrolling
    {
    }

    // @interface Gridlines : NSObject
    [BaseType(typeof(NSObject))]
    interface Gridlines
    {
        // @property (nonatomic, strong) GridStyle * top;
        [Export("top", ArgumentSemantic.Strong)]
        GridStyle Top { get; set; }

        // @property (nonatomic, strong) GridStyle * bottom;
        [Export("bottom", ArgumentSemantic.Strong)]
        GridStyle Bottom { get; set; }

        // @property (nonatomic, strong) GridStyle * left;
        [Export("left", ArgumentSemantic.Strong)]
        GridStyle Left { get; set; }

        // @property (nonatomic, strong) GridStyle * right;
        [Export("right", ArgumentSemantic.Strong)]
        GridStyle Right { get; set; }

        // -(instancetype)initWithTop:(GridStyle *)top bottom:(GridStyle *)bottom left:(GridStyle *)left right:(GridStyle *)right;
        [Export("initWithTop:bottom:left:right:")]
        IntPtr Constructor(GridStyle top, GridStyle bottom, GridStyle left, GridStyle right);

        // +(instancetype)all:(GridStyle *)style;
        [Static]
        [Export("all:")]
        Gridlines All(GridStyle style);
    }

    // @interface GridStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface GridStyle
    {
        // @property (assign, nonatomic) GridStyle_Enum styleEnum;
        [Export("styleEnum", ArgumentSemantic.Assign)]
        GridStyleType StyleEnum { get; set; }

        // @property (assign, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; set; }

        // @property (nonatomic, strong) UIColor * color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // -(instancetype)initWithStyle:(GridStyle_Enum)style_enum width:(CGFloat)widith color:(UIColor *)color;
        [Export("initWithStyle:width:color:")]
        IntPtr Constructor(GridStyleType style_enum, nfloat widith, UIColor color);

        // +(instancetype)borderStyleNone;
        [Static]
        [Export("borderStyleNone")]
        GridStyle BorderStyleNone { get; }

        // +(instancetype)style:(GridStyle_Enum)style_enum width:(CGFloat)widith color:(UIColor *)color;
        [Static]
        [Export("style:width:color:")]
        GridStyle Style(GridStyleType style_enum, nfloat widith, UIColor color);
    }

    // @interface ZMJGridLayout : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface ZMJGridLayout : INSCopying
    {
        // @property (assign, nonatomic) CGFloat gridWidth;
        [Export("gridWidth")]
        nfloat GridWidth { get; set; }

        // @property (copy, nonatomic) UIColor * gridColor;
        [Export("gridColor", ArgumentSemantic.Copy)]
        UIColor GridColor { get; set; }

        // @property (assign, nonatomic) CGPoint origin;
        [Export("origin", ArgumentSemantic.Assign)]
        CGPoint Origin { get; set; }

        // @property (assign, nonatomic) CGFloat length;
        [Export("length")]
        nfloat Length { get; set; }

        // @property (assign, nonatomic) RectEdge edge;
        [Export("edge", ArgumentSemantic.Assign)]
        RectEdge Edge { get; set; }

        // @property (assign, nonatomic) CGFloat priority;
        [Export("priority")]
        nfloat Priority { get; set; }

        // -(instancetype)initWithGridWidth:(CGFloat)gridWidth gridColor:(UIColor *)gridColor origin:(CGPoint)origin length:(CGFloat)length edge:(RectEdge)edge priority:(CGFloat)priority;
        [Export("initWithGridWidth:gridColor:origin:length:edge:priority:")]
        IntPtr Constructor(nfloat gridWidth, UIColor gridColor, CGPoint origin, nfloat length, RectEdge edge, nfloat priority);

        // +(instancetype)gridLayoutWithGridWidth:(CGFloat)gridWidth gridColor:(UIColor *)gridColor origin:(CGPoint)origin length:(CGFloat)length edge:(RectEdge)edge priority:(CGFloat)priority;
        [Static]
        [Export("gridLayoutWithGridWidth:gridColor:origin:length:edge:priority:")]
        ZMJGridLayout GridLayoutWithGridWidth(nfloat gridWidth, UIColor gridColor, CGPoint origin, nfloat length, RectEdge edge, nfloat priority);
    }

    // @interface Gridline : CALayer
    [BaseType(typeof(CALayer))]
    interface Gridline : INativeObject
    {
        // @property (nonatomic, strong) UIColor * color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }
    }

    // @interface Location : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface Location : INSCopying
    {
        // @property (assign, nonatomic) NSInteger row;
        [Export("row")]
        nint Row { get; set; }

        // @property (assign, nonatomic) NSInteger column;
        [Export("column")]
        nint Column { get; set; }

        // -(instancetype)initWithRow:(NSInteger)row column:(NSInteger)column;
        [Export("initWithRow:column:")]
        IntPtr Constructor(nint row, nint column);

        // +(instancetype)locationWithRow:(NSInteger)row column:(NSInteger)column;
        [Static]
        [Export("locationWithRow:column:")]
        Location LocationWithRow(nint row, nint column);

        // +(instancetype)indexPath:(NSIndexPath *)indexPath;
        [Static]
        [Export("indexPath:")]
        Location IndexPath(NSIndexPath indexPath);
    }

    // @interface BinarySearch (NSArray)
    [Category]
    [BaseType(typeof(NSArray))]
    interface NSArray_BinarySearch
    {
        // -(NSInteger)insertionIndexOfObject:(ObjectType)element;
        [Export("insertionIndexOfObject:")]
        nint InsertionIndexOfObject(NSObject element);
    }

    // @interface WBGAddition (NSArray)
    [Category]
    [BaseType(typeof(NSArray))]
    interface NSArray_WBGAddition
    {
        // -(NSArray * _Nonnull)wbg_map:(id  _Nullable (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_map:")]
        NSObject[] Wbg_map(Func<NSObject, NSObject> block);

        // -(NSArray * _Nonnull)wbg_mapWithIndex:(id  _Nullable (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_mapWithIndex:")]
        NSObject[] Wbg_mapWithIndex(Func<NSObject, nuint, NSObject> block);

        // +(NSArray * _Nonnull)wbg_map:(NSArray<ObjectType> * _Nonnull)array inBlock:(id  _Nullable (^ _Nonnull)(ObjectType _Nonnull))block;
        [Static]
        [Export("wbg_map:inBlock:")]
        NSObject[] Wbg_map(NSObject[] array, Func<NSObject, NSObject> block);

        // +(NSArray * _Nonnull)wbg_mapWithIndex:(NSArray<ObjectType> * _Nonnull)array inBlock:(id  _Nullable (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_mapWithIndex:inBlock:")]
        NSObject[] Wbg_mapWithIndex(NSObject[] array, Func<NSObject, nuint, NSObject> block);

        // -(NSArray * _Nonnull)wbg_multiMap:(void (^ _Nonnull)(ObjectType _Nonnull, WBGMultiMapReturn _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_multiMap:")]
        NSObject[] Wbg_multiMap(Action<NSObject, WBGMultiMapReturn> block);

        // -(NSArray * _Nonnull)wbg_multiMapWithIndex:(void (^ _Nonnull)(ObjectType _Nonnull, WBGMultiMapReturn _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_multiMapWithIndex:")]
        NSObject[] Wbg_multiMapWithIndex(Action<NSObject, WBGMultiMapReturn, nuint> block);

        // -(NSArray<ObjectType> * _Nonnull)wbg_filter:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_filter:")]
        NSObject[] Wbg_filter(Func<NSObject, bool> block);

        // -(NSArray<ObjectType> * _Nonnull)wbg_filterWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_filterWithIndex:")]
        NSObject[] Wbg_filterWithIndex(Func<NSObject, nuint, bool> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_filter:(NSArray<ObjectType> * _Nonnull)array inBlock:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_filter:inBlock:")]
        NSObject[] Wbg_filter(NSObject[] array, Func<NSObject, bool> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_filterWithIndex:(NSArray<ObjectType> * _Nonnull)array inBlock:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_filterWithIndex:inBlock:")]
        NSObject[] Wbg_filterWithIndex(NSObject[] array, Func<NSObject, nuint, bool> block);

        // -(NSArray<ObjectType> * _Nonnull)wbg_reject:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_reject:")]
        NSObject[] Wbg_reject(Func<NSObject, bool> block);

        // -(NSArray<ObjectType> * _Nonnull)wbg_rejectWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_rejectWithIndex:")]
        NSObject[] Wbg_rejectWithIndex(Func<NSObject, nuint, bool> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_reject:(NSArray<ObjectType> * _Nonnull)array inBlock:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_reject:inBlock:")]
        NSObject[] Wbg_reject(NSObject[] array, Func<NSObject, bool> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_rejectWithIndex:(NSArray<ObjectType> * _Nonnull)array inBlock:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_rejectWithIndex:inBlock:")]
        NSObject[] Wbg_rejectWithIndex(NSObject[] array, Func<NSObject, nuint, bool> block);

        // -(id _Nullable)wbg_reduce:(id _Nullable)first with:(id  _Nonnull (^ _Nullable)(id _Nullable, ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_reduce:with:")]
        [return: NullAllowed]
        NSObject Wbg_reduce([NullAllowed] NSObject first, [NullAllowed] Func<NSObject, NSObject, NSObject> block);

        // -(id _Nullable)wbg_reduce:(id  _Nonnull (^ _Nullable)(id _Nullable, ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_reduce:")]
        [return: NullAllowed]
        NSObject Wbg_reduce([NullAllowed] Func<NSObject, NSObject, NSObject> block);

        // -(id _Nullable)wbg_reduce:(id _Nullable)first withIndex:(id  _Nonnull (^ _Nullable)(id _Nullable, ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_reduce:withIndex:")]
        [return: NullAllowed]
        NSObject Wbg_reduce([NullAllowed] NSObject first, [NullAllowed] Func<NSObject, NSObject, nuint, NSObject> block);

        // -(id _Nullable)wbg_reduceWithIndex:(id  _Nonnull (^ _Nullable)(id _Nullable, ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_reduceWithIndex:")]
        [return: NullAllowed]
        NSObject Wbg_reduceWithIndex([NullAllowed] Func<NSObject, NSObject, nuint, NSObject> block);

        // -(CGFloat)wbg_reduceCGFloat:(CGFloat)first with:(CGFloat (^ _Nonnull)(CGFloat, ObjectType _Nonnull))block;
        [Export("wbg_reduceCGFloat:with:")]
        nfloat Wbg_reduceCGFloat(nfloat first, Func<nfloat, NSObject, nfloat> block);

        // -(CGFloat)wbg_reduceDouble:(double)first with:(double (^ _Nonnull)(double, ObjectType _Nonnull))block;
        [Export("wbg_reduceDouble:with:")]
        nfloat Wbg_reduceDouble(double first, Func<double, NSObject, double> block);

        // -(CGFloat)wbg_reduceNSInteger:(NSInteger)first with:(NSInteger (^ _Nonnull)(NSInteger, ObjectType _Nonnull))block;
        [Export("wbg_reduceNSInteger:with:")]
        nfloat Wbg_reduceNSInteger(nint first, Func<nint, NSObject, nint> block);

        // -(void)wbg_apply:(void (^ _Nonnull)(ObjectType _Nonnull))block;
        [Export("wbg_apply:")]
        void Wbg_apply(Action<NSObject> block);

        // -(ObjectType _Nonnull)wbg_queryFirst:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_queryFirst:")]
        NSObject Wbg_queryFirst(Func<NSObject, bool> block);

        // -(ObjectType _Nonnull)wbg_queryFirstWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_queryFirstWithIndex:")]
        NSObject Wbg_queryFirstWithIndex(Func<NSObject, nuint, bool> block);

        // -(NSUInteger)wbg_indexOf:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_indexOf:")]
        nuint Wbg_indexOf(Func<NSObject, bool> block);

        // -(ObjectType _Nonnull)wbg_queryLast:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_queryLast:")]
        NSObject Wbg_queryLast(Func<NSObject, bool> block);

        // -(ObjectType _Nonnull)wbg_queryLastWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_queryLastWithIndex:")]
        NSObject Wbg_queryLastWithIndex(Func<NSObject, nuint, bool> block);

        // -(BOOL)wbg_any:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_any:")]
        bool Wbg_any(Func<NSObject, bool> block);

        // -(BOOL)wbg_anyWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_anyWithIndex:")]
        bool Wbg_anyWithIndex(Func<NSObject, nuint, bool> block);

        // -(BOOL)wbg_all:(BOOL (^ _Nonnull)(ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_all:")]
        bool Wbg_all(Func<NSObject, bool> block);

        // -(BOOL)wbg_allWithIndex:(BOOL (^ _Nonnull)(ObjectType _Nonnull, NSUInteger))block __attribute__((warn_unused_result));
        [Export("wbg_allWithIndex:")]
        bool Wbg_allWithIndex(Func<NSObject, nuint, bool> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_forIn:(NSInteger)count block:(ObjectType  _Nullable (^ _Nonnull)(NSUInteger))block;
        [Static]
        [Export("wbg_forIn:block:")]
        NSObject[] Wbg_forIn(nint count, Func<nuint, NSObject> block);

        // +(NSArray<ObjectType> * _Nonnull)wbg_forInRange:(NSRange)range block:(ObjectType  _Nullable (^ _Nonnull)(NSUInteger))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_forInRange:block:")]
        NSObject[] Wbg_forInRange(NSRange range, Func<nuint, NSObject> block);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByRemovingDuplicate __attribute__((warn_unused_result));
        [Export("wbg_arrayByRemovingDuplicate")]
        NSObject[] Wbg_arrayByRemovingDuplicate();

        // -(ObjectType _Nullable)wbg_safeObjectAtIndex:(NSInteger)index __attribute__((warn_unused_result));
        [Export("wbg_safeObjectAtIndex:")]
        [return: NullAllowed]
        NSObject Wbg_safeObjectAtIndex(nint index);

        // -(NSArray<ObjectType> * _Nonnull)wbg_getObjectsWithRange:(NSRange)range __attribute__((warn_unused_result));
        [Export("wbg_getObjectsWithRange:")]
        NSObject[] Wbg_getObjectsWithRange(NSRange range);

        // -(ObjectType _Nullable)wbg_safeObjectAtIndexNumber:(NSNumber * _Nonnull)indexNumber __attribute__((warn_unused_result));
        [Export("wbg_safeObjectAtIndexNumber:")]
        [return: NullAllowed]
        NSObject Wbg_safeObjectAtIndexNumber(NSNumber indexNumber);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByRemovingObject:(ObjectType _Nonnull)object __attribute__((warn_unused_result));
        [Export("wbg_arrayByRemovingObject:")]
        NSObject[] Wbg_arrayByRemovingObject(NSObject @object);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByRemovingObjectsFromArray:(NSArray<ObjectType> * _Nonnull)array __attribute__((warn_unused_result));
        [Export("wbg_arrayByRemovingObjectsFromArray:")]
        NSObject[] Wbg_arrayByRemovingObjectsFromArray(NSObject[] array);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByPopFirst __attribute__((warn_unused_result));
        [Export("wbg_arrayByPopFirst")]
        NSObject[] Wbg_arrayByPopFirst();

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByPopLast __attribute__((warn_unused_result));
        [Export("wbg_arrayByPopLast")]
        NSObject[] Wbg_arrayByPopLast();

        // -(NSArray<ObjectType> * _Nonnull)wbg_safeArrayByRemovingObjectAtIndex:(NSUInteger)index __attribute__((warn_unused_result));
        [Export("wbg_safeArrayByRemovingObjectAtIndex:")]
        NSObject[] Wbg_safeArrayByRemovingObjectAtIndex(nuint index);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByAddingObject:(ObjectType _Nonnull)anObject __attribute__((warn_unused_result));
        [Export("wbg_arrayByAddingObject:")]
        NSObject[] Wbg_arrayByAddingObject(NSObject anObject);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByReplacingObject:(ObjectType _Nonnull)object with:(ObjectType _Nonnull)newObject __attribute__((warn_unused_result));
        [Export("wbg_arrayByReplacingObject:with:")]
        NSObject[] Wbg_arrayByReplacingObject(NSObject @object, NSObject newObject);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByReplacingObjectAtIndex:(NSUInteger)idx with:(ObjectType _Nonnull)newObject __attribute__((warn_unused_result));
        [Export("wbg_arrayByReplacingObjectAtIndex:with:")]
        NSObject[] Wbg_arrayByReplacingObjectAtIndex(nuint idx, NSObject newObject);

        // -(NSArray * _Nonnull)wbg_arrayByJoiningWithObject:(id _Nonnull)object copyObject:(BOOL)copyObject __attribute__((warn_unused_result));
        [Export("wbg_arrayByJoiningWithObject:copyObject:")]
        NSObject[] Wbg_arrayByJoiningWithObject(NSObject @object, bool copyObject);

        // +(NSArray<ObjectType> * _Nonnull)wbg_arrayByMergingArray:(NSArray<ObjectType> * _Nonnull)oneArray withArray:(NSArray<ObjectType> * _Nonnull)anotherArray copyItems:(BOOL)copyItems removeDuplicate:(BOOL)removeDuplicate __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_arrayByMergingArray:withArray:copyItems:removeDuplicate:")]
        NSObject[] Wbg_arrayByMergingArray(NSObject[] oneArray, NSObject[] anotherArray, bool copyItems, bool removeDuplicate);

        // +(NSArray<ObjectType> * _Nonnull)wbg_arrayByMerging:(NSArray<ObjectType> * _Nonnull)oneArray, ... __attribute__((warn_unused_result)) __attribute__((sentinel(0, 1)));
        [Static, Internal]
        [Export("wbg_arrayByMerging:", IsVariadic = true)]
        NSObject[] Wbg_arrayByMergingFor(NSObject[] oneArray, IntPtr varArgs);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByMerging:(NSArray<ObjectType> * _Nonnull)oneArray, ... __attribute__((warn_unused_result)) __attribute__((sentinel(0, 1)));
        [Internal]
        [Export("wbg_arrayByMerging:", IsVariadic = true)]
        NSObject[] Wbg_arrayByMerging(NSObject[] oneArray, IntPtr varArgs);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByIntersectingWithArray:(NSArray<ObjectType> * _Nonnull)otherArray;
        [Export("wbg_arrayByIntersectingWithArray:")]
        NSObject[] Wbg_arrayByIntersectingWithArray(NSObject[] otherArray);

        // -(NSArray * _Nonnull)wbg_arrayByPrependingObject:(id _Nonnull)object __attribute__((warn_unused_result));
        [Export("wbg_arrayByPrependingObject:")]
        NSObject[] Wbg_arrayByPrependingObject(NSObject @object);

        // -(NSArray * _Nonnull)wbg_arrayByPrependingObjectsFromArray:(NSArray<id> * _Nonnull)array __attribute__((warn_unused_result));
        [Export("wbg_arrayByPrependingObjectsFromArray:")]
        NSObject[] Wbg_arrayByPrependingObjectsFromArray(NSObject[] array);

        // -(NSArray<ObjectType> * _Nonnull)wbg_arrayByReverse;
        [Export("wbg_arrayByReverse")]
        NSObject[] Wbg_arrayByReverse();

        // -(NSArray<ObjectType> * _Nonnull)wbg_interSectWithArray:(NSArray<ObjectType> * _Nonnull)otherArray;
        [Export("wbg_interSectWithArray:")]
        NSObject[] Wbg_interSectWithArray(NSObject[] otherArray);

        // -(NSArray<ObjectType> * _Nonnull)wbg_minuWithArray:(NSArray<ObjectType> * _Nonnull)otherArray;
        [Export("wbg_minuWithArray:")]
        NSObject[] Wbg_minuWithArray(NSObject[] otherArray);
    }

    // typedef void (^WBGMultiMapReturn)(id _Nullable);
    delegate void WBGMultiMapReturn([NullAllowed] NSObject arg0);

    // @interface WBGAdd (NSDictionary)
    [Category]
    [BaseType(typeof(NSDictionary))]
    interface NSDictionary_WBGAdd
    {
        // -(NSDictionary * _Nullable)dictionaryValueForKey:(NSString * _Nonnull)key default:(NSDictionary * _Nullable)def;
        [Export("dictionaryValueForKey:default:")]
        [return: NullAllowed]
        NSDictionary DictionaryValueForKey(string key, [NullAllowed] NSDictionary def);

        // -(NSArray * _Nullable)arrayValueForKey:(NSString * _Nonnull)key default:(NSArray * _Nullable)def;
        [Export("arrayValueForKey:default:")]
        [return: NullAllowed]
        NSObject[] ArrayValueForKey(string key, [NullAllowed] NSObject[] def);

        // -(NSDate * _Nullable)dateValueForKey:(NSString * _Nonnull)key default:(NSDate * _Nullable)def;
        [Export("dateValueForKey:default:")]
        [return: NullAllowed]
        NSDate DateValueForKey(string key, [NullAllowed] NSDate def);

        // -(id _Nullable)blockValueForKey:(NSString * _Nonnull)key default:(id _Nullable)def;
        [Export("blockValueForKey:default:")]
        [return: NullAllowed]
        NSObject BlockValueForKey(string key, [NullAllowed] NSObject def);

        // -(ObjectType _Nullable)valueForKey:(NSString * _Nonnull)key ofKind:(Class _Nullable)kind default:(id _Nullable)def;
        [Export("valueForKey:ofKind:default:")]
        [return: NullAllowed]
        NSObject ValueForKey(string key, [NullAllowed] Class kind, [NullAllowed] NSObject def);

        // -(BOOL)boolValueForPath:(NSString * _Nonnull)path default:(BOOL)def;
        [Export("boolValueForPath:default:")]
        bool BoolValueForPath(string path, bool def);

        // -(char)charValueForPath:(NSString * _Nonnull)path default:(char)def;
        [Export("charValueForPath:default:")]
        sbyte CharValueForPath(string path, sbyte def);

        // -(unsigned char)unsignedCharValueForPath:(NSString * _Nonnull)path default:(unsigned char)def;
        [Export("unsignedCharValueForPath:default:")]
        byte UnsignedCharValueForPath(string path, byte def);

        // -(short)shortValueForPath:(NSString * _Nonnull)path default:(short)def;
        [Export("shortValueForPath:default:")]
        short ShortValueForPath(string path, short def);

        // -(unsigned short)unsignedShortValueForPath:(NSString * _Nonnull)path default:(unsigned short)def;
        [Export("unsignedShortValueForPath:default:")]
        ushort UnsignedShortValueForPath(string path, ushort def);

        // -(int)intValueForPath:(NSString * _Nonnull)path default:(int)def;
        [Export("intValueForPath:default:")]
        int IntValueForPath(string path, int def);

        // -(unsigned int)unsignedIntValueForPath:(NSString * _Nonnull)path default:(unsigned int)def;
        [Export("unsignedIntValueForPath:default:")]
        uint UnsignedIntValueForPath(string path, uint def);

        // -(long)longValueForPath:(NSString * _Nonnull)path default:(long)def;
        [Export("longValueForPath:default:")]
        nint LongValueForPath(string path, nint def);

        // -(unsigned long)unsignedLongValueForPath:(NSString * _Nonnull)path default:(unsigned long)def;
        [Export("unsignedLongValueForPath:default:")]
        nuint UnsignedLongValueForPath(string path, nuint def);

        // -(long long)longLongValueForPath:(NSString * _Nonnull)path default:(long long)def;
        [Export("longLongValueForPath:default:")]
        long LongLongValueForPath(string path, long def);

        // -(unsigned long long)unsignedLongLongValueForPath:(NSString * _Nonnull)path default:(unsigned long long)def;
        [Export("unsignedLongLongValueForPath:default:")]
        ulong UnsignedLongLongValueForPath(string path, ulong def);

        // -(float)floatValueForPath:(NSString * _Nonnull)path default:(float)def;
        [Export("floatValueForPath:default:")]
        float FloatValueForPath(string path, float def);

        // -(double)doubleValueForPath:(NSString * _Nonnull)path default:(double)def;
        [Export("doubleValueForPath:default:")]
        double DoubleValueForPath(string path, double def);

        // -(NSInteger)integerValueForPath:(NSString * _Nonnull)path default:(NSInteger)def;
        [Export("integerValueForPath:default:")]
        nint IntegerValueForPath(string path, nint def);

        // -(NSUInteger)unsignedIntegerValueForPath:(NSString * _Nonnull)path default:(NSUInteger)def;
        [Export("unsignedIntegerValueForPath:default:")]
        nuint UnsignedIntegerValueForPath(string path, nuint def);

        // -(NSNumber * _Nullable)numberValueForPath:(NSString * _Nonnull)path default:(NSNumber * _Nullable)def;
        [Export("numberValueForPath:default:")]
        [return: NullAllowed]
        NSNumber NumberValueForPath(string path, [NullAllowed] NSNumber def);

        // -(NSString * _Nullable)stringValueForPath:(NSString * _Nonnull)path default:(NSString * _Nullable)def;
        [Export("stringValueForPath:default:")]
        [return: NullAllowed]
        string StringValueForPath(string path, [NullAllowed] string def);

        // -(NSDictionary * _Nullable)dictionaryValueForPath:(NSString * _Nonnull)path default:(NSDictionary * _Nullable)def;
        [Export("dictionaryValueForPath:default:")]
        [return: NullAllowed]
        NSDictionary DictionaryValueForPath(string path, [NullAllowed] NSDictionary def);

        // -(NSArray * _Nullable)arrayValueForPath:(NSString * _Nonnull)path default:(NSArray * _Nullable)def;
        [Export("arrayValueForPath:default:")]
        [return: NullAllowed]
        NSObject[] ArrayValueForPath(string path, [NullAllowed] NSObject[] def);

        // -(NSDate * _Nullable)dateValueForPath:(NSString * _Nonnull)path default:(NSDate * _Nullable)def;
        [Export("dateValueForPath:default:")]
        [return: NullAllowed]
        NSDate DateValueForPath(string path, [NullAllowed] NSDate def);

        // -(id _Nullable)blockValueForPath:(NSString * _Nonnull)path default:(id _Nullable)def;
        [Export("blockValueForPath:default:")]
        [return: NullAllowed]
        NSObject BlockValueForPath(string path, [NullAllowed] NSObject def);

        // -(NSDictionary * _Nonnull)dictionaryValueForPath:(NSString * _Nonnull)path;
        [Export("dictionaryValueForPath:")]
        NSDictionary DictionaryValueForPath(string path);

        // -(NSArray * _Nonnull)arrayValueForPath:(NSString * _Nonnull)path;
        [Export("arrayValueForPath:")]
        NSObject[] ArrayValueForPath(string path);

        // -(NSString * _Nonnull)stringValueForPath:(NSString * _Nonnull)path;
        [Export("stringValueForPath:")]
        string StringValueForPath(string path);

        // -(NSDictionary * _Nonnull)dictionaryValueForKey:(NSString * _Nonnull)key;
        [Export("dictionaryValueForKey:")]
        NSDictionary DictionaryValueForKey(string key);

        // -(NSArray * _Nonnull)arrayValueForKey:(NSString * _Nonnull)key;
        [Export("arrayValueForKey:")]
        NSObject[] ArrayValueForKey(string key);

        // -(NSString * _Nonnull)stringValueForKey:(NSString * _Nonnull)key;
        [Export("stringValueForKey:")]
        string StringValueForKey(string key);

        // -(NSDictionary * _Nonnull)wbg_map:(void (^ _Nonnull)(KeyType _Nonnull, ObjectType _Nonnull, WBGDictionaryReturnBlock _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_map:")]
        NSDictionary Wbg_map(Action<NSObject, NSObject, WBGDictionaryReturnBlock> block);

        // -(NSDictionary<KeyType,ObjectType> * _Nonnull)wbg_filter:(BOOL (^ _Nonnull)(KeyType _Nonnull, ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_filter:")]
        NSDictionary<NSObject, NSObject> Wbg_filter(Func<NSObject, NSObject, bool> block);

        // +(NSDictionary<KeyType,ObjectType> * _Nonnull)wbg_forIn:(NSInteger)count block:(void (^ _Nonnull)(NSInteger, WBGDictionaryReturnBlock _Nonnull))block __attribute__((warn_unused_result));
        [Static]
        [Export("wbg_forIn:block:")]
        NSDictionary<NSObject, NSObject> Wbg_forIn(nint count, Action<nint, WBGDictionaryReturnBlock> block);

        // -(NSArray<id> * _Nonnull)wbg_toArray:(id  _Nonnull (^ _Nonnull)(KeyType _Nonnull, ObjectType _Nonnull))block __attribute__((warn_unused_result));
        [Export("wbg_toArray:")]
        NSObject[] Wbg_toArray(Func<NSObject, NSObject, NSObject> block);

        // -(NSDictionary<KeyType,ObjectType> * _Nonnull)wbg_dictionaryBySettingObject:(ObjectType _Nonnull)anObject forKey:(KeyType<NSCopying> _Nonnull)aKey __attribute__((warn_unused_result));
        [Export("wbg_dictionaryBySettingObject:forKey:")]
        NSDictionary<NSObject, NSObject> Wbg_dictionaryBySettingObject(NSObject anObject, NSObject aKey);

        // @property (readonly, nonatomic) NSDictionary<KeyType,ObjectType> * _Nonnull wbg_dictionaryByRemovingNSNull;
        [Export("wbg_dictionaryByRemovingNSNull")]
        NSDictionary<NSObject, NSObject> Wbg_dictionaryByRemovingNSNull();
    }

    // typedef void (^WBGDictionaryReturnBlock)(KeyType _Nonnull, ObjectType _Nonnull);
    delegate void WBGDictionaryReturnBlock(NSObject arg0, NSObject arg1);

    // @interface WBGAdd (NSMutableDictionary)
    [Category]
    [BaseType(typeof(NSMutableDictionary))]
    interface NSMutableDictionary_WBGAdd
    {
        // -(void)setSafeObject:(ObjectType _Nonnull)anObject forKey:(KeyType _Nonnull)aKey;
        [Export("setSafeObject:forKey:")]
        void SetSafeObject(NSObject anObject, NSObject aKey);

        // -(void)setSafeInteger:(NSInteger)integer forKey:(KeyType _Nonnull)aKey defaultValue:(NSInteger)defaultValue;
        [Export("setSafeInteger:forKey:defaultValue:")]
        void SetSafeInteger(nint integer, NSObject aKey, nint defaultValue);

        // -(void)setSafeDate:(NSDate * _Nonnull)date forKey:(KeyType _Nonnull)aKey;
        [Export("setSafeDate:forKey:")]
        void SetSafeDate(NSDate date, NSObject aKey);

        // -(void)setDouble:(double)aDouble precision:(NSUInteger)precision forKey:(KeyType _Nonnull)aKey;
        [Export("setDouble:precision:forKey:")]
        void SetDouble(double aDouble, nuint precision, NSObject aKey);
    }

    // @interface column (NSIndexPath)
    [Category]
    [BaseType(typeof(NSIndexPath))]
    interface NSIndexPathExtensions
    {
        // @property (assign, nonatomic) NSInteger column;
        [Export("column")]
        nint GetColumn();

        // +(instancetype)indexPathWithRow:(NSInteger)row column:(NSInteger)column;
        [Static]
        [Export("indexPathWithRow:column:")]
        NSIndexPath IndexPathWithRow(nint row, nint column);
    }

    // audit-objc-generics: @interface ReuseQueue<__covariant Reusable> : NSObject
    [BaseType(typeof(NSObject))]
    [Model]
    interface ReuseQueue<T> : INativeObject where T : class, INativeObject
    {
        // -(void)enqueue:(Reusable)reusableObject;
        [Export("enqueue:")]
        void Enqueue(NSObject reusableObject);

        // -(Reusable)dequeue;
        [Export("dequeue")]
        NSObject Dequeue();

        // -(Reusable)dequeueOrCreate:(Class)clazz;
        [Export("dequeueOrCreate:")]
        NSObject DequeueOrCreate(Class clazz);
    }

    // audit-objc-generics: @interface ReusableCollection<__covariant Reusable> : NSObject <NSFastEnumeration>
    [BaseType(typeof(NSObject))]
    interface ReusableCollection<T> where T : INativeObject
    {
        // @property (readonly, nonatomic, strong) NSArray<Reusable> * array;
        [Export("array", ArgumentSemantic.Strong)]
        NSObject[] Array { get; }

        // @property (readonly, nonatomic, strong) NSMutableDictionary<Address *,Reusable> * pairs;
        [Export("pairs", ArgumentSemantic.Strong)]
        NSMutableDictionary<Address, NSObject> Pairs { get; }

        // @property (nonatomic, strong) NSMutableOrderedSet<Address *> * addresses;
        [Export("addresses", ArgumentSemantic.Strong)]
        NSMutableOrderedSet<Address> Addresses { get; set; }

        // -(BOOL)contains:(Address *)member;
        [Export("contains:")]
        bool Contains(Address member);

        // -(void)insert:(Address *)newMember;
        [Export("insert:")]
        void Insert(Address newMember);

        // -(void)substract:(NSOrderedSet<Address *> *)other;
        [Export("substract:")]
        void Substract(NSOrderedSet<Address> other);

        // -(Reusable)objectForKeyedSubscript:(Address *)key;
        [Export("objectForKeyedSubscript:")]
        NSObject ObjectForKeyedSubscript(Address key);

        // -(void)removeObjectForKey:(Address *)aKey;
        [Export("removeObjectForKey:")]
        void RemoveObjectForKey(Address aKey);

        // -(void)setObject:(Reusable)obj forKeyedSubscript:(Address *)key;
        [Export("setObject:forKeyedSubscript:")]
        void SetObject(NSObject obj, Address key);
    }

    // @protocol SpreadsheetViewDataSource <NSObject>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface SpreadsheetViewDataSource
    {
        // @required -(NSInteger)numberOfColumns:(SpreadsheetView *)spreadsheetView;
        [Abstract]
        [Export("numberOfColumns:")]
        nint NumberOfColumns(SpreadsheetView spreadsheetView);

        // @required -(NSInteger)numberOfRows:(SpreadsheetView *)spreadsheetView;
        [Abstract]
        [Export("numberOfRows:")]
        nint NumberOfRows(SpreadsheetView spreadsheetView);

        // @required -(CGFloat)spreadsheetView:(SpreadsheetView *)spreadsheetView widthForColumn:(NSInteger)column;
        [Abstract]
        [Export("spreadsheetView:widthForColumn:")]
        nfloat WidthForColumn(SpreadsheetView spreadsheetView, nint column);

        // @required -(CGFloat)spreadsheetView:(SpreadsheetView *)spreadsheetView heightForRow:(NSInteger)row;
        [Abstract]
        [Export("spreadsheetView:heightForRow:")]
        nfloat HeightForRow(SpreadsheetView spreadsheetView, nint row);

        // @required -(ZMJCell *)spreadsheetView:(SpreadsheetView *)spreadsheetView cellForItemAt:(NSIndexPath *)indexPath;
        [Abstract]
        [Export("spreadsheetView:cellForItemAt:")]
        ZMJCell CellForItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(NSArray<ZMJCellRange *> *)mergedCells:(SpreadsheetView *)spreadsheetView;
        [Abstract]
        [Export("mergedCells:")]
        ZMJCellRange[] MergedCells(SpreadsheetView spreadsheetView);

        // @optional -(NSInteger)frozenColumns:(SpreadsheetView *)spreadsheetView;
        [Abstract]
        [Export("frozenColumns:")]
        nint FrozenColumns(SpreadsheetView spreadsheetView);

        // @optional -(NSInteger)frozenRows:(SpreadsheetView *)spreadsheetView;
        [Abstract]
        [Export("frozenRows:")]
        nint FrozenRows(SpreadsheetView spreadsheetView);
    }

    interface ISpreadsheetViewDataSource { }

    // @protocol SpreadsheetViewDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SpreadsheetViewDelegate
    {
        // @optional -(BOOL)spreadsheetView:(SpreadsheetView *)spreadsheetView shouldHighlightItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:shouldHighlightItemAt:")]
        bool ShouldHighlightItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(void)spreadsheetView:(SpreadsheetView *)spreadsheetView didHighlightItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:didHighlightItemAt:")]
        void DidHighlightItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(void)spreadsheetView:(SpreadsheetView *)spreadsheetView didUnhighlightItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:didUnhighlightItemAt:")]
        void DidUnhighlightItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(BOOL)spreadsheetView:(SpreadsheetView *)spreadsheetView shouldSelectItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:shouldSelectItemAt:")]
        bool ShouldSelectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(BOOL)spreadsheetView:(SpreadsheetView *)spreadsheetView shouldDeselectItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:shouldDeselectItemAt:")]
        bool ShouldDeselectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(void)spreadsheetView:(SpreadsheetView *)spreadsheetView didSelectItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:didSelectItemAt:")]
        void DidSelectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);

        // @optional -(void)spreadsheetView:(SpreadsheetView *)spreadsheetView didDeselectItemAt:(NSIndexPath *)indexPath;
        [Export("spreadsheetView:didDeselectItemAt:")]
        void DidDeselectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath);
    }

    interface ISpreadsheetViewDelegate { }

    // @interface ZMJCell : UIView
    [BaseType(typeof(UIView))]
    interface ZMJCell : INativeObject
    {
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);

        // @property (readonly, nonatomic, strong) UIView * contentView;
        [Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; }

        // @property (nonatomic, strong) UIView * backgroundView;
        [Export("backgroundView", ArgumentSemantic.Strong)]
        UIView BackgroundView { get; set; }

        // @property (nonatomic, strong) UIView * selectedBackgroundView;
        [Export("selectedBackgroundView", ArgumentSemantic.Strong)]
        UIView SelectedBackgroundView { get; set; }

        // @property (getter = isHighlighted, assign, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { [Bind("isHighlighted")] get; set; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (nonatomic, strong) Gridlines * gridlines;
        [Export("gridlines", ArgumentSemantic.Strong)]
        Gridlines GridLines { get; set; }

        // @property (nonatomic, strong) Gridlines * grids;
        [Export("grids", ArgumentSemantic.Strong)]
        Gridlines Grids { get; set; }

        // @property (nonatomic, strong) Borders * borders;
        [Export("borders", ArgumentSemantic.Strong)]
        Borders Borders { get; set; }

        // @property (assign, nonatomic) BOOL hasBorder;
        [Export("hasBorder")]
        bool HasBorder { get; set; }

        // @property (copy, nonatomic) NSString * reuseIdentifier;
        [Export("reuseIdentifier")]
        string ReuseIdentifier { get; set; }

        // @property (nonatomic, strong) NSIndexPath * indexPath;
        [Export("indexPath", ArgumentSemantic.Strong)]
        NSIndexPath IndexPath { get; set; }

        // -(NSComparisonResult)compare:(ZMJCell *)aValue;
        [Export("compare:")]
        NSComparisonResult Compare(ZMJCell aValue);

        // -(void)preppareForReuse;
        [Export("preppareForReuse")]
        void PreppareForReuse();

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);
    }

    // @interface BlankCell : ZMJCell
    [BaseType(typeof(ZMJCell))]
    interface BlankCell
    {
        [Export("initWithFrame:")]
        IntPtr Constructor(CGRect frame);
    }

    // @interface ZMJScrollView : UIScrollView
    [BaseType(typeof(UIScrollView))]
    interface ZMJScrollView
    {
        // @property (nonatomic, strong) NSMutableArray<NSNumber *> * columnRecords;
        [Export("columnRecords", ArgumentSemantic.Strong)]
        NSMutableArray<NSNumber> ColumnRecords { get; set; }

        // @property (nonatomic, strong) NSMutableArray<NSNumber *> * rowRecords;
        [Export("rowRecords", ArgumentSemantic.Strong)]
        NSMutableArray<NSNumber> RowRecords { get; set; }

        // @property (copy, nonatomic) TouchHandler touchesBegan;
        [Export("touchesBegan", ArgumentSemantic.Copy)]
        TouchHandler TouchesBegan { get; set; }

        // @property (copy, nonatomic) TouchHandler touchesEnded;
        [Export("touchesEnded", ArgumentSemantic.Copy)]
        TouchHandler TouchesEnded { get; set; }

        // @property (copy, nonatomic) TouchHandler touchesCancelled;
        [Export("touchesCancelled", ArgumentSemantic.Copy)]
        TouchHandler TouchesCancelled { get; set; }

        // @property (assign, nonatomic) LayoutAttributes layoutAttributes;
        [Export("layoutAttributes", ArgumentSemantic.Assign)]
        LayoutAttributes LayoutAttributes { get; set; }

        // @property (assign, readwrite, nonatomic) State state;
        [Export("state", ArgumentSemantic.Assign)]
        State State { get; set; }

        // @property (nonatomic, strong) ReusableCollection<ZMJCell *> * visibleCells;
        [Export("visibleCells", ArgumentSemantic.Strong)]
        ZMJCell[] VisibleCells { get; set; }

        //// @property (nonatomic, strong) ReusableCollection<Gridline *> * visibleVerticalGridlines;
        //[Export("visibleVerticalGridlines", ArgumentSemantic.Strong)]
        //ReusableCollection<Gridline> VisibleVerticalGridlines { get; set; }

        //// @property (nonatomic, strong) ReusableCollection<Gridline *> * visibleHorizontalGridlines;
        //[Export("visibleHorizontalGridlines", ArgumentSemantic.Strong)]
        //ReusableCollection<Gridline> VisibleHorizontalGridlines { get; set; }

        // @property (nonatomic, strong) ReusableCollection<Border *> * visibleBorders;
        //[Export("visibleBorders", ArgumentSemantic.Strong)]
        //ReusableCollection<Border> VisibleBorders { get; set; }

        // @property (assign, nonatomic) BOOL hasDisplayedContent;
        [Export("hasDisplayedContent")]
        bool HasDisplayedContent { get; set; }

        // -(void)resetReusableObjects;
        [Export("resetReusableObjects")]
        void ResetReusableObjects();
    }

    // @interface ZMJLayoutProperties : NSObject
    [BaseType(typeof(NSObject))]
    interface ZMJLayoutProperties
    {
        // @property (assign, nonatomic) NSInteger numberOfColumns;
        [Export("numberOfColumns")]
        nint NumberOfColumns { get; set; }

        // @property (assign, nonatomic) NSInteger numberOfRows;
        [Export("numberOfRows")]
        nint NumberOfRows { get; set; }

        // @property (assign, nonatomic) NSInteger frozenColumns;
        [Export("frozenColumns")]
        nint FrozenColumns { get; set; }

        // @property (assign, nonatomic) NSInteger frozenRows;
        [Export("frozenRows")]
        nint FrozenRows { get; set; }

        // @property (assign, nonatomic) CGFloat frozenColumnWidth;
        [Export("frozenColumnWidth")]
        nfloat FrozenColumnWidth { get; set; }

        // @property (assign, nonatomic) CGFloat frozenRowHeight;
        [Export("frozenRowHeight")]
        nfloat FrozenRowHeight { get; set; }

        // @property (assign, nonatomic) CGFloat columnWidth;
        [Export("columnWidth")]
        nfloat ColumnWidth { get; set; }

        // @property (assign, nonatomic) CGFloat rowHeight;
        [Export("rowHeight")]
        nfloat RowHeight { get; set; }

        // @property (nonatomic, strong) NSMutableArray<NSNumber *> * columnWidthCache;
        [Export("columnWidthCache", ArgumentSemantic.Strong)]
        NSMutableArray<NSNumber> ColumnWidthCache { get; set; }

        // @property (nonatomic, strong) NSMutableArray<NSNumber *> * rowHeightCache;
        [Export("rowHeightCache", ArgumentSemantic.Strong)]
        NSMutableArray<NSNumber> RowHeightCache { get; set; }

        // @property (nonatomic, strong) NSMutableArray<ZMJCellRange *> * mergedCells;
        [Export("mergedCells", ArgumentSemantic.Strong)]
        NSMutableArray<ZMJCellRange> MergedCells { get; set; }

        // @property (nonatomic, strong) NSMutableDictionary<Location *,ZMJCellRange *> * mergedCellLayouts;
        [Export("mergedCellLayouts", ArgumentSemantic.Strong)]
        NSMutableDictionary<Location, ZMJCellRange> MergedCellLayouts { get; set; }

        // -(instancetype)initWithNumberOfColumns:(NSInteger)numberOfColumns numberOfRows:(NSInteger)numberOfRows frozenColumns:(NSInteger)frozenColumns frozenRows:(NSInteger)frozenRows frozenColumnWidth:(CGFloat)frozenColumnWidth frozenRowHeight:(CGFloat)frozenRowHeight columnWidth:(CGFloat)columnWidth rowHeight:(CGFloat)rowHeight columnWidthCache:(NSArray<NSNumber *> *)columnWidthCache rowHeightCache:(NSArray<NSNumber *> *)rowHeightCache mergedCells:(NSArray<ZMJCellRange *> *)mergedCells mergedCellLayouts:(NSDictionary<Location *,ZMJCellRange *> *)mergedCellLayouts;
        [Export("initWithNumberOfColumns:numberOfRows:frozenColumns:frozenRows:frozenColumnWidth:frozenRowHeight:columnWidth:rowHeight:columnWidthCache:rowHeightCache:mergedCells:mergedCellLayouts:")]
        IntPtr Constructor(nint numberOfColumns, nint numberOfRows, nint frozenColumns, nint frozenRows, nfloat frozenColumnWidth, nfloat frozenRowHeight, nfloat columnWidth, nfloat rowHeight, NSNumber[] columnWidthCache, NSNumber[] rowHeightCache, ZMJCellRange[] mergedCells, NSDictionary<Location, ZMJCellRange> mergedCellLayouts);
    }

    // @interface ZMJLayoutEngine : NSObject
    [BaseType(typeof(NSObject))]
    interface ZMJLayoutEngine
    {
        // -(instancetype)initWithSpreadsheetView:(SpreadsheetView *)spreadsheetView scrollView:(ZMJScrollView *)scrollView;
        [Export("initWithSpreadsheetView:scrollView:")]
        IntPtr Constructor(SpreadsheetView spreadsheetView, ZMJScrollView scrollView);

        // +(instancetype)spreadsheetView:(SpreadsheetView *)spreadsheetView scrollView:(ZMJScrollView *)scrollView;
        [Static]
        [Export("spreadsheetView:scrollView:")]
        ZMJLayoutEngine SpreadsheetView(SpreadsheetView spreadsheetView, ZMJScrollView scrollView);

        // -(void)layout;
        [Export("layout")]
        void Layout();
    }

    // @interface SpreadsheetView : UIView
    [BaseType(typeof(UIView))]
    interface SpreadsheetView
    {
        // @property (nonatomic, weak) id<SpreadsheetViewDataSource> dataSource;
        [Export("dataSource", ArgumentSemantic.Weak)]
        ISpreadsheetViewDataSource DataSource { get; set; }

        [Wrap("WeakDelegate")]
        ISpreadsheetViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<SpreadsheetViewDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) CGSize intercellSpacing;
        [Export("intercellSpacing", ArgumentSemantic.Assign)]
        CGSize IntercellSpacing { get; set; }

        // @property (nonatomic, strong) GridStyle * gridStyle;
        [Export("gridStyle", ArgumentSemantic.Strong)]
        GridStyle GridStyle { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelection;
        [Export("allowsSelection")]
        bool AllowsSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) BOOL showsVerticalScrollIndicator;
        [Export("showsVerticalScrollIndicator")]
        bool ShowsVerticalScrollIndicator { get; set; }

        // @property (assign, nonatomic) BOOL showsHorizontalScrollIndicator;
        [Export("showsHorizontalScrollIndicator")]
        bool ShowsHorizontalScrollIndicator { get; set; }

        // @property (assign, nonatomic) BOOL scrollsToTop;
        [Export("scrollsToTop")]
        bool ScrollsToTop { get; set; }

        // @property (nonatomic, strong) id<CircularScrollingConfiguration> circularScrolling;
        [Export("circularScrolling", ArgumentSemantic.Strong)]
        ICircularScrollingConfiguration CircularScrolling { get; set; }

        // @property (nonatomic, strong) Options * circularScrollingOptions;
        [Export("circularScrollingOptions", ArgumentSemantic.Strong)]
        Options CircularScrollingOptions { get; set; }

        // @property (assign, nonatomic) CircularScrollScalingFactor circularScrollScalingFactor;
        [Export("circularScrollScalingFactor", ArgumentSemantic.Assign)]
        CircularScrollScalingFactor CircularScrollScalingFactor { get; set; }

        // @property (assign, nonatomic) CGPoint centerOffset;
        [Export("centerOffset", ArgumentSemantic.Assign)]
        CGPoint CenterOffset { get; set; }

        // @property (nonatomic, strong) UIView * backgroundView;
        [Export("backgroundView", ArgumentSemantic.Strong)]
        UIView BackgroundView { get; set; }

        // @property (readonly, nonatomic, strong) NSArray<ZMJCell *> * visibleCells;
        [Export("visibleCells", ArgumentSemantic.Strong)]
        ZMJCell[] VisibleCells { get; }

        // @property (nonatomic, strong) NSArray<NSIndexPath *> * indexPathsForVisibleItems;
        [Export("indexPathsForVisibleItems", ArgumentSemantic.Strong)]
        NSIndexPath[] IndexPathsForVisibleItems { get; set; }

        // @property (nonatomic, strong) NSIndexPath * indexPathForSelectedItem;
        [Export("indexPathForSelectedItem", ArgumentSemantic.Strong)]
        NSIndexPath IndexPathForSelectedItem { get; set; }

        // @property (nonatomic, strong) NSArray<NSIndexPath *> * indexPathsForSelectedItems;
        [Export("indexPathsForSelectedItems", ArgumentSemantic.Strong)]
        NSIndexPath[] IndexPathsForSelectedItems { get; set; }

        // @property (getter = isDirectionalLockEnabled, assign, nonatomic) BOOL directionalLockEnabled;
        [Export("directionalLockEnabled")]
        bool DirectionalLockEnabled { [Bind("isDirectionalLockEnabled")] get; set; }

        // @property (assign, nonatomic) BOOL bounces;
        [Export("bounces")]
        bool Bounces { get; set; }

        // @property (assign, nonatomic) BOOL alwaysBounceVertical;
        [Export("alwaysBounceVertical")]
        bool AlwaysBounceVertical { get; set; }

        // @property (assign, nonatomic) BOOL alwaysBounceHorizontal;
        [Export("alwaysBounceHorizontal")]
        bool AlwaysBounceHorizontal { get; set; }

        // @property (assign, nonatomic) BOOL stickyRowHeader;
        [Export("stickyRowHeader")]
        bool StickyRowHeader { get; set; }

        // @property (assign, nonatomic) BOOL stickyColumnHeader;
        [Export("stickyColumnHeader")]
        bool StickyColumnHeader { get; set; }

        // @property (getter = isPagingEnabled, assign, nonatomic) BOOL pagingEnabled;
        [Export("pagingEnabled")]
        bool PagingEnabled { [Bind("isPagingEnabled")] get; set; }

        // @property (getter = isScrollEnabled, assign, nonatomic) BOOL scrollEnabled;
        [Export("scrollEnabled")]
        bool ScrollEnabled { [Bind("isScrollEnabled")] get; set; }

        // @property (assign, nonatomic) UIScrollViewIndicatorStyle indicatorStyle;
        [Export("indicatorStyle", ArgumentSemantic.Assign)]
        UIScrollViewIndicatorStyle IndicatorStyle { get; set; }

        // @property (assign, nonatomic) CGFloat decelerationRate;
        [Export("decelerationRate")]
        nfloat DecelerationRate { get; set; }

        // @property (readonly, assign, nonatomic) NSInteger numberOfColumns;
        [Export("numberOfColumns")]
        nint NumberOfColumns { get; }

        // @property (readonly, assign, nonatomic) NSInteger numberOfRows;
        [Export("numberOfRows")]
        nint NumberOfRows { get; }

        // @property (readonly, assign, nonatomic) NSInteger frozenColumns;
        [Export("frozenColumns")]
        nint FrozenColumns { get; }

        // @property (readonly, assign, nonatomic) NSInteger frozenRows;
        [Export("frozenRows")]
        nint FrozenRows { get; }

        // @property (readonly, assign, nonatomic) NSArray<ZMJCellRange *> * mergedCells;
        [Export("mergedCells", ArgumentSemantic.Assign)]
        ZMJCellRange[] MergedCells { get; }

        // @property (nonatomic, strong) NSString * blankCellReuseIdentifier;
        [Export("blankCellReuseIdentifier", ArgumentSemantic.Strong)]
        string BlankCellReuseIdentifier { get; set; }

        // @property (readonly, assign, nonatomic) UIScrollView * scrollView;
        [Export("scrollView", ArgumentSemantic.Assign)]
        UIScrollView ScrollView { get; }

        //// @property (nonatomic, strong) ReuseQueue<Gridline *> * horizontalGridlineReuseQueue;
        //[Export("horizontalGridlineReuseQueue", ArgumentSemantic.Strong)]
        //ReuseQueue<Gridline> HorizontalGridlineReuseQueue { get; set; }

        //// @property (nonatomic, strong) ReuseQueue<Gridline *> * verticalGridlineReuseQueue;
        //[Export("verticalGridlineReuseQueue", ArgumentSemantic.Strong)]
        //ReuseQueue<Gridline> VerticalGridlineReuseQueue { get; set; }

        //// @property (nonatomic, strong) ReuseQueue<Border *> * borderReuseQueue;
        //[Export("borderReuseQueue", ArgumentSemantic.Strong)]
        //ReuseQueue<Border> BorderReuseQueue { get; set; }

        //// @property (nonatomic, strong) NSMutableDictionary<NSString *,ReuseQueue<ZMJCell *> *> * cellReuseQueues;
        //[Export("cellReuseQueues", ArgumentSemantic.Strong)]
        //NSMutableDictionary<NSString, ReuseQueue<ZMJCell>> CellReuseQueues { get; set; }

        // -(void)registerClass:(Class)cellClass forCellWithReuseIdentifier:(NSString *)identifier;
        [Export("registerClass:forCellWithReuseIdentifier:")]
        [Internal]
        void RegisterClass(IntPtr cellClass, string identifier);

        // -(void)registerNib:(UINib *)cellNib forCellWithReuseIdentifier:(NSString *)identifier;
        [Export("registerNib:forCellWithReuseIdentifier:")]
        void RegisterNib(UINib cellNib, string identifier);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(ZMJCell *)dequeueReusableCellWithReuseIdentifier:(NSString *)identifier forIndexPath:(NSIndexPath *)indexPath;
        [Export("dequeueReusableCellWithReuseIdentifier:forIndexPath:")]
        ZMJCell DequeueReusableCellWithReuseIdentifier(string identifier, NSIndexPath indexPath);

        // -(void)scrollToItemIndexPath:(NSIndexPath *)indexPath at:(ZMJScrollPosition)scrollPosition animated:(BOOL)animated;
        [Export("scrollToItemIndexPath:at:animated:")]
        void ScrollToItemIndexPath(NSIndexPath indexPath, ZMJScrollPosition scrollPosition, bool animated);

        // -(void)selectItemIndexPath:(NSIndexPath *)indexPath animated:(BOOL)animated scrollPosition:(ZMJScrollPosition)scrollPosition;
        [Export("selectItemIndexPath:animated:scrollPosition:")]
        void SelectItemIndexPath(NSIndexPath indexPath, bool animated, ZMJScrollPosition scrollPosition);

        // -(void)deselectItemIndexPath:(NSIndexPath *)indexPath animated:(BOOL)animated;
        [Export("deselectItemIndexPath:animated:")]
        void DeselectItemIndexPath(NSIndexPath indexPath, bool animated);

        // -(NSIndexPath *)indexPathForItemAt:(CGPoint)point;
        [Export("indexPathForItemAt:")]
        NSIndexPath IndexPathForItemAt(CGPoint point);

        // -(ZMJCell *)cellForItemAt:(NSIndexPath *)indexPath;
        [Export("cellForItemAt:")]
        ZMJCell CellForItemAt(NSIndexPath indexPath);

        // -(NSArray<ZMJCell *> *)cellsForItemAt:(NSIndexPath *)indexPath;
        [Export("cellsForItemAt:")]
        ZMJCell[] CellsForItemAt(NSIndexPath indexPath);

        // -(CGRect)rectForItemAt:(NSIndexPath *)indexPath;
        [Export("rectForItemAt:")]
        CGRect RectForItemAt(NSIndexPath indexPath);

        // -(ZMJCellRange *)mergedCellFor:(Location *)indexPath;
        [Export("mergedCellFor:")]
        ZMJCellRange MergedCellFor(Location indexPath);

        // @property (nonatomic, strong) NSMutableOrderedSet<NSIndexPath *> * highlightedIndexPaths;
        [Export("highlightedIndexPaths", ArgumentSemantic.Strong)]
        NSMutableOrderedSet<NSIndexPath> HighlightedIndexPaths { get; set; }

        // @property (nonatomic, strong) NSMutableOrderedSet<NSIndexPath *> * selectedIndexPaths;
        [Export("selectedIndexPaths", ArgumentSemantic.Strong)]
        NSMutableOrderedSet<NSIndexPath> SelectedIndexPaths { get; set; }

        // @property (nonatomic, strong) UITouch * currentTouch;
        [Export("currentTouch", ArgumentSemantic.Strong)]
        UITouch CurrentTouch { get; set; }

        // @property (nonatomic, strong) ZMJScrollView * columnHeaderView;
        [Export("columnHeaderView", ArgumentSemantic.Strong)]
        ZMJScrollView ColumnHeaderView { get; set; }

        // @property (nonatomic, strong) ZMJScrollView * rowHeaderView;
        [Export("rowHeaderView", ArgumentSemantic.Strong)]
        ZMJScrollView RowHeaderView { get; set; }

        // @property (nonatomic, strong) ZMJScrollView * cornerView;
        [Export("cornerView", ArgumentSemantic.Strong)]
        ZMJScrollView CornerView { get; set; }

        // @property (nonatomic, strong) ZMJScrollView * tableView;
        [Export("tableView", ArgumentSemantic.Strong)]
        ZMJScrollView TableView { get; set; }

        // @property (nonatomic, strong) UIScrollView * overlayView;
        [Export("overlayView", ArgumentSemantic.Strong)]
        UIScrollView OverlayView { get; set; }

        // @property (nonatomic, strong) UIScrollView * rootView;
        [Export("rootView", ArgumentSemantic.Strong)]
        UIScrollView RootView { get; set; }

        // @property (nonatomic, strong) ZMJLayoutProperties * layoutProperties;
        [Export("layoutProperties", ArgumentSemantic.Strong)]
        ZMJLayoutProperties LayoutProperties { get; set; }

        // @property (nonatomic, strong) NSIndexPath * pendingSelectionIndexPath;
        [Export("pendingSelectionIndexPath", ArgumentSemantic.Strong)]
        NSIndexPath PendingSelectionIndexPath { get; set; }
    }

    // @interface ForCategory (SpreadsheetView) <UIScrollViewDelegate>
    [Protocol]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_ForCategory : IUIScrollViewDelegate
    {
        // -(void)reloadDataIfNeeded;
        [Export("reloadDataIfNeeded")]
        void ReloadDataIfNeeded();
    }

    // @interface CirclularScrolling (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_CirclularScrolling
    {
        // -(void)scrollToHorizontalCenter;
        [Export("scrollToHorizontalCenter")]
        void ScrollToHorizontalCenter();

        // -(void)scrollToVerticalCenter;
        [Export("scrollToVerticalCenter")]
        void ScrollToVerticalCenter();

        // -(void)recenterHorizontallyIfNecessary;
        [Export("recenterHorizontallyIfNecessary")]
        void RecenterHorizontallyIfNecessary();

        // -(void)recenterVerticallyIfNecessary;
        [Export("recenterVerticallyIfNecessary")]
        void RecenterVerticallyIfNecessary();

        // -(CircularScrollScalingFactor)determineCircularScrollScalingFactor;
        [Export("determineCircularScrollScalingFactor")]
        CircularScrollScalingFactor DetermineCircularScrollScalingFactor();

        // -(NSInteger)determineHorizontalCircularScrollScalingFactor;
        [Export("determineHorizontalCircularScrollScalingFactor")]
        nint DetermineHorizontalCircularScrollScalingFactor();

        // -(NSInteger)determineVerticalCircularScrollScalingFactor;
        [Export("determineVerticalCircularScrollScalingFactor")]
        nint DetermineVerticalCircularScrollScalingFactor();

        // -(CGPoint)calculateCenterOffset;
        [Export("calculateCenterOffset")]
        CGPoint CalculateCenterOffset();
    }

    // @interface Layout (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_Layout
    {
        // -(LayoutAttributes)layoutAttributeForCornerView;
        [Export("layoutAttributeForCornerView")]
        LayoutAttributes LayoutAttributeForCornerView();

        // -(LayoutAttributes)layoutAttributeForColumnHeaderView;
        [Export("layoutAttributeForColumnHeaderView")]
        LayoutAttributes LayoutAttributeForColumnHeaderView();

        // -(LayoutAttributes)layoutAttributeForRowHeaderView;
        [Export("layoutAttributeForRowHeaderView")]
        LayoutAttributes LayoutAttributeForRowHeaderView();

        // -(LayoutAttributes)layoutAttributeForTableView;
        [Export("layoutAttributeForTableView")]
        LayoutAttributes LayoutAttributeForTableView();

        // -(ZMJLayoutProperties *)resetLayoutProperties;
        [Export("resetLayoutProperties")]
        ZMJLayoutProperties ResetLayoutProperties();

        // -(void)resetContentSize:(ZMJScrollView *)scrollView;
        [Export("resetContentSize:")]
        void ResetContentSize(ZMJScrollView scrollView);

        // -(void)resetScrollViewFrame;
        [Export("resetScrollViewFrame")]
        void ResetScrollViewFrame();

        // -(void)resetOverlayViewContentSize:(UIEdgeInsets)contentInset;
        [Export("resetOverlayViewContentSize:")]
        void ResetOverlayViewContentSize(UIEdgeInsets contentInset);

        // -(void)resetScrollViewArrangement;
        [Export("resetScrollViewArrangement")]
        void ResetScrollViewArrangement();

        // -(NSInteger)findIndex:(NSArray<NSNumber *> *)records offset:(CGFloat)offset;
        [Export("findIndex:offset:")]
        nint FindIndex(NSNumber[] records, nfloat offset);
    }

    // @interface Touches (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_Touches
    {
        // -(void)touchesBegan:(NSSet<UITouch *> *)touches event:(UIEvent *)event;
        [Export("touchesBegan:event:")]
        void TouchesBegan(NSSet<UITouch> touches, UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> *)touches event:(UIEvent *)event;
        [Export("touchesEnded:event:")]
        void TouchesEnded(NSSet<UITouch> touches, UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> *)touches event:(UIEvent *)event;
        [Export("touchesCancelled:event:")]
        void TouchesCancelled(NSSet<UITouch> touches, UIEvent @event);

        // -(void)restorePreviousSelection;
        [Export("restorePreviousSelection")]
        void RestorePreviousSelection();

        // -(void)clearCurrentTouch;
        [Export("clearCurrentTouch")]
        void ClearCurrentTouch();
    }

    // @interface UIScrollView (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_UIScrollView
    {
        // - (void)setContentOffset:(CGPoint)contentOffset
        [Export("setContentOffset:")]
        void SetContentOffset(CGPoint point);

        // - (CGPoint)contentOffset
        [Export("contentOffset")]
        CGPoint GetContentOffset();

        // - (void)setScrollIndicatorInsets:(UIEdgeInsets)scrollIndicatorInsets
        [Export("setScrollIndicatorInsets:")]
        void SetScrollIndicatorInsets(UIEdgeInsets edgeInsets);

        // - (UIEdgeInsets)scrollIndicatorInsets
        [Export("scrollIndicatorInsets")]
        UIEdgeInsets GetScrollIndicatorInsets();

        // - (CGSize)contentSize
        [Export("contentSize")]
        CGSize GetContentSize();

        // - (void)setContentInset:(UIEdgeInsets)contentInset
        [Export("setContentInset:")]
        void SetContentInset(UIEdgeInsets edgeInsets);

        // - (UIEdgeInsets)contentInset
        [Export("contentInset")]
        UIEdgeInsets GetContentInset();

        // - (UIEdgeInsets)adjustedContentInset
        [Introduced(PlatformName.iOS, 11, 0)]
        [Export("adjustedContentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets GetAdjustedContentInset();

        // -(void)flashScrollIndicators;
        [Export("flashScrollIndicators")]
        void FlashScrollIndicators();

        // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated;
        [Export("setContentOffset:animated:")]
        void SetContentOffset(CGPoint contentOffset, bool animated);

        // -(void)scrollRectToVisible:(CGRect)rect animated:(BOOL)animated;
        [Export("scrollRectToVisible:animated:")]
        void ScrollRectToVisible(CGRect rect, bool animated);
    }

    // @interface UIScrollViewDelegate (SpreadsheetView) <UIScrollViewDelegate>
    [Protocol]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_UIScrollViewDelegate : IUIScrollViewDelegate
    {
    }

    // @interface UISnapshotting (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_UISnapshotting
    {
    }

    // @interface UIViewHierarchy (SpreadsheetView)
    [Category]
    [BaseType(typeof(SpreadsheetView))]
    interface SpreadsheetView_UIViewHierarchy
    {
    }

    // @interface ZMJCellRange : NSObject
    [BaseType(typeof(NSObject))]
    interface ZMJCellRange : INativeObject
    {
        // @property (readonly, nonatomic, strong) Location * from;
        [Export("from", ArgumentSemantic.Strong)]
        Location From { get; }

        // @property (readonly, nonatomic, strong) Location * to;
        [Export("to", ArgumentSemantic.Strong)]
        Location To { get; }

        // @property (readonly, assign, nonatomic) NSInteger columnCount;
        [Export("columnCount")]
        nint ColumnCount { get; }

        // @property (readonly, assign, nonatomic) NSInteger rowCount;
        [Export("rowCount")]
        nint RowCount { get; }

        // @property (assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; set; }

        // +(instancetype)cellRangeFrom:(Location *)from to:(Location *)to;
        [Static]
        [Export("cellRangeFrom:to:")]
        ZMJCellRange CellRangeFrom(Location from, Location to);

        // -(instancetype)initFromRow:(NSInteger)fromRow fromColumn:(NSInteger)fromColumn toRow:(NSInteger)toRow toColumn:(NSInteger)toColumn;
        [Export("initFromRow:fromColumn:toRow:toColumn:")]
        IntPtr Constructor(nint fromRow, nint fromColumn, nint toRow, nint toColumn);

        // -(instancetype)initFromIndex:(NSIndexPath *)fromIndexPath toIndexPath:(NSIndexPath *)toIndexPath;
        [Export("initFromIndex:toIndexPath:")]
        IntPtr Constructor(NSIndexPath fromIndexPath, NSIndexPath toIndexPath);

        // -(BOOL)containsIndexPath:(NSIndexPath *)indexPath;
        [Export("containsIndexPath:")]
        bool ContainsIndexPath(NSIndexPath indexPath);

        // -(BOOL)containsCellRange:(ZMJCellRange *)cellRange;
        [Export("containsCellRange:")]
        bool ContainsCellRange(ZMJCellRange cellRange);
    }
}
