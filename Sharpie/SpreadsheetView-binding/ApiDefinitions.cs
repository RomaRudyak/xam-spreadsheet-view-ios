using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SpreadsheetView;
using UIKit;

namespace Spreadsheet
{
	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SpreadsheetViewVersionNumber;
		[Field ("SpreadsheetViewVersionNumber", "__Internal")]
		double SpreadsheetViewVersionNumber { get; }

		// extern const unsigned char [] SpreadsheetViewVersionString;
		[Field ("SpreadsheetViewVersionString", "__Internal")]
		byte[] SpreadsheetViewVersionString { get; }
	}

	// @interface Cell : UIView
	[BaseType (typeof(UIView))]
	interface Cell
	{
		// @property (readonly, nonatomic, strong) UIView * _Nonnull contentView __attribute__((diagnose_if(0x7fd948030440, "Swift property 'Cell.contentView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("contentView", ArgumentSemantic.Strong)]
		UIView ContentView { get; }

		// @property (nonatomic, strong) UIView * _Nullable backgroundView __attribute__((diagnose_if(0x7fd9480306a8, "Swift property 'Cell.backgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("backgroundView", ArgumentSemantic.Strong)]
		UIView BackgroundView { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable selectedBackgroundView __attribute__((diagnose_if(0x7fd948030a50, "Swift property 'Cell.selectedBackgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("selectedBackgroundView", ArgumentSemantic.Strong)]
		UIView SelectedBackgroundView { get; set; }

		// @property (nonatomic) BOOL isHighlighted __attribute__((diagnose_if(0x7fd948030dc8, "Swift property 'Cell.isHighlighted' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("isHighlighted")]
		bool IsHighlighted { get; set; }

		// @property (nonatomic) BOOL isSelected __attribute__((diagnose_if(0x7fd948031118, "Swift property 'Cell.isSelected' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("isSelected")]
		bool IsSelected { get; set; }

		// @property (nonatomic) BOOL hasBorder __attribute__((diagnose_if(0x7fd948031460, "Swift property 'Cell.hasBorder' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("hasBorder")]
		bool HasBorder { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable reuseIdentifier __attribute__((diagnose_if(0x7fd9480317a8, "Swift property 'Cell.reuseIdentifier' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("reuseIdentifier")]
		string ReuseIdentifier { get; set; }

		// @property (copy, nonatomic) NSIndexPath * _Null_unspecified indexPath __attribute__((diagnose_if(0x7fd948031b18, "Swift property 'Cell.indexPath' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("indexPath", ArgumentSemantic.Copy)]
		NSIndexPath IndexPath { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(void)setup __attribute__((diagnose_if(0x7fd948032358, "Swift method 'Cell.setup()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("setup")]
		void Setup ();

		// -(void)prepareForReuse __attribute__((diagnose_if(0x7fd948032528, "Swift method 'Cell.prepareForReuse()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		// -(void)setSelected:(BOOL)selected animated:(BOOL)animated __attribute__((diagnose_if(0x7fd948032700, "Swift method 'Cell.setSelected(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("setSelected:animated:")]
		void SetSelected (bool selected, bool animated);
	}

	// @interface BlankCell : Cell
	[BaseType (typeof(Cell))]
	interface BlankCell
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface Border : UIView
	[BaseType (typeof(UIView))]
	interface Border
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(void)drawRect:(CGRect)rect;
		[Export ("drawRect:")]
		void DrawRect (CGRect rect);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();
	}

	// @interface Gridline : CALayer
	[BaseType (typeof(CALayer))]
	interface Gridline
	{
		// @property (nonatomic, strong) UIColor * _Nonnull color __attribute__((diagnose_if(0x7fd948033348, "Swift property 'Gridline.color' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("color", ArgumentSemantic.Strong)]
		UIColor Color { get; set; }

		// -(instancetype _Nonnull)initWithLayer:(id _Nonnull)layer __attribute__((objc_designated_initializer));
		[Export ("initWithLayer:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSObject layer);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(id<CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event __attribute__((warn_unused_result));
		[Export ("actionForKey:")]
		[return: NullAllowed]
		CAAction ActionForKey (string @event);
	}

	// @interface ScrollView : UIScrollView <UIGestureRecognizerDelegate>
	[BaseType (typeof(UIScrollView))]
	interface ScrollView : IUIGestureRecognizerDelegate
	{
		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull columnRecords __attribute__((diagnose_if(0x7fd948033e90, "Swift property 'ScrollView.columnRecords' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("columnRecords", ArgumentSemantic.Copy)]
		NSNumber[] ColumnRecords { get; set; }

		// @property (copy, nonatomic) NSArray<NSNumber *> * _Nonnull rowRecords __attribute__((diagnose_if(0x7fd948034308, "Swift property 'ScrollView.rowRecords' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("rowRecords", ArgumentSemantic.Copy)]
		NSNumber[] RowRecords { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) touchesBegan __attribute__((diagnose_if(0x7fd9480346b0, "Swift property 'ScrollView.touchesBegan' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("touchesBegan", ArgumentSemantic.Copy)]
		Action<NSSet<UITouch>, UIEvent> TouchesBegan { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) touchesEnded __attribute__((diagnose_if(0x7fd948034e20, "Swift property 'ScrollView.touchesEnded' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("touchesEnded", ArgumentSemantic.Copy)]
		Action<NSSet<UITouch>, UIEvent> TouchesEnded { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) touchesCancelled __attribute__((diagnose_if(0x7fd948035320, "Swift property 'ScrollView.touchesCancelled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("touchesCancelled", ArgumentSemantic.Copy)]
		Action<NSSet<UITouch>, UIEvent> TouchesCancelled { get; set; }

		// @property (readonly, nonatomic) BOOL hasDisplayedContent __attribute__((diagnose_if(0x7fd948035828, "Swift property 'ScrollView.hasDisplayedContent' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("hasDisplayedContent")]
		bool HasDisplayedContent { get; }

		// -(void)resetReusableObjects __attribute__((diagnose_if(0x7fd948035a90, "Swift method 'ScrollView.resetReusableObjects()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("resetReusableObjects")]
		void ResetReusableObjects ();

		// -(BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer __attribute__((warn_unused_result));
		[Export ("gestureRecognizer:shouldRecognizeSimultaneouslyWithGestureRecognizer:")]
		bool GestureRecognizer (UIGestureRecognizer gestureRecognizer, UIGestureRecognizer otherGestureRecognizer);

		// -(BOOL)touchesShouldBegin:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event inContentView:(UIView * _Nonnull)view __attribute__((warn_unused_result));
		[Export ("touchesShouldBegin:withEvent:inContentView:")]
		bool TouchesShouldBegin (NSSet<UITouch> touches, [NullAllowed] UIEvent @event, UIView view);

		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesBegan:withEvent:")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesEnded:withEvent:")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
		[Export ("touchesCancelled:withEvent:")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);
	}

	// @interface SpreadsheetView : UIView
	[BaseType (typeof(UIView))]
	interface SpreadsheetView
	{
		// @property (nonatomic) CGSize intercellSpacing __attribute__((diagnose_if(0x7fd948036d90, "Swift property 'SpreadsheetView.intercellSpacing' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("intercellSpacing", ArgumentSemantic.Assign)]
		CGSize IntercellSpacing { get; set; }

		// @property (nonatomic) BOOL allowsSelection __attribute__((diagnose_if(0x7fd9480370e8, "Swift property 'SpreadsheetView.allowsSelection' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("allowsSelection")]
		bool AllowsSelection { get; set; }

		// @property (nonatomic) BOOL allowsMultipleSelection __attribute__((diagnose_if(0x7fd948037440, "Swift property 'SpreadsheetView.allowsMultipleSelection' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("allowsMultipleSelection")]
		bool AllowsMultipleSelection { get; set; }

		// @property (nonatomic) BOOL showsVerticalScrollIndicator __attribute__((diagnose_if(0x7fd9480377a0, "Swift property 'SpreadsheetView.showsVerticalScrollIndicator' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("showsVerticalScrollIndicator")]
		bool ShowsVerticalScrollIndicator { get; set; }

		// @property (nonatomic) BOOL showsHorizontalScrollIndicator __attribute__((diagnose_if(0x7fd948037b08, "Swift property 'SpreadsheetView.showsHorizontalScrollIndicator' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("showsHorizontalScrollIndicator")]
		bool ShowsHorizontalScrollIndicator { get; set; }

		// @property (nonatomic) BOOL scrollsToTop __attribute__((diagnose_if(0x7fd948037e70, "Swift property 'SpreadsheetView.scrollsToTop' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollsToTop")]
		bool ScrollsToTop { get; set; }

		// @property (nonatomic) CGPoint centerOffset __attribute__((diagnose_if(0x7fd9480381c8, "Swift property 'SpreadsheetView.centerOffset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("centerOffset", ArgumentSemantic.Assign)]
		CGPoint CenterOffset { get; set; }

		// @property (nonatomic, strong) UIView * _Nullable backgroundView __attribute__((diagnose_if(0x7fd948038520, "Swift property 'SpreadsheetView.backgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("backgroundView", ArgumentSemantic.Strong)]
		UIView BackgroundView { get; set; }

		// -(void)safeAreaInsetsDidChange __attribute__((availability(ios, introduced=11.0)));
		[iOS (11,0)]
		[Export ("safeAreaInsetsDidChange")]
		void SafeAreaInsetsDidChange ();

		// @property (readonly, copy, nonatomic) NSArray<Cell *> * _Nonnull visibleCells __attribute__((diagnose_if(0x7fd9480389e0, "Swift property 'SpreadsheetView.visibleCells' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("visibleCells", ArgumentSemantic.Copy)]
		Cell[] VisibleCells { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSIndexPath *> * _Nonnull indexPathsForVisibleItems __attribute__((diagnose_if(0x7fd948038d68, "Swift property 'SpreadsheetView.indexPathsForVisibleItems' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("indexPathsForVisibleItems", ArgumentSemantic.Copy)]
		NSIndexPath[] IndexPathsForVisibleItems { get; }

		// @property (readonly, copy, nonatomic) NSIndexPath * _Nullable indexPathForSelectedItem __attribute__((diagnose_if(0x7fd9480390c8, "Swift property 'SpreadsheetView.indexPathForSelectedItem' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("indexPathForSelectedItem", ArgumentSemantic.Copy)]
		NSIndexPath IndexPathForSelectedItem { get; }

		// @property (readonly, copy, nonatomic) NSArray<NSIndexPath *> * _Nonnull indexPathsForSelectedItems __attribute__((diagnose_if(0x7fd948039380, "Swift property 'SpreadsheetView.indexPathsForSelectedItems' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("indexPathsForSelectedItems", ArgumentSemantic.Copy)]
		NSIndexPath[] IndexPathsForSelectedItems { get; }

		// @property (nonatomic) BOOL isDirectionalLockEnabled __attribute__((diagnose_if(0x7fd948039640, "Swift property 'SpreadsheetView.isDirectionalLockEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("isDirectionalLockEnabled")]
		bool IsDirectionalLockEnabled { get; set; }

		// @property (nonatomic) BOOL bounces __attribute__((diagnose_if(0x7fd9480399a0, "Swift property 'SpreadsheetView.bounces' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("bounces")]
		bool Bounces { get; set; }

		// @property (nonatomic) BOOL alwaysBounceVertical __attribute__((diagnose_if(0x7fd948039cf0, "Swift property 'SpreadsheetView.alwaysBounceVertical' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("alwaysBounceVertical")]
		bool AlwaysBounceVertical { get; set; }

		// @property (nonatomic) BOOL alwaysBounceHorizontal __attribute__((diagnose_if(0x7fd94803a050, "Swift property 'SpreadsheetView.alwaysBounceHorizontal' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("alwaysBounceHorizontal")]
		bool AlwaysBounceHorizontal { get; set; }

		// @property (nonatomic) BOOL stickyRowHeader __attribute__((diagnose_if(0x7fd94803a3b0, "Swift property 'SpreadsheetView.stickyRowHeader' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("stickyRowHeader")]
		bool StickyRowHeader { get; set; }

		// @property (nonatomic) BOOL stickyColumnHeader __attribute__((diagnose_if(0x7fd94803a708, "Swift property 'SpreadsheetView.stickyColumnHeader' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("stickyColumnHeader")]
		bool StickyColumnHeader { get; set; }

		// @property (nonatomic) BOOL isPagingEnabled __attribute__((diagnose_if(0x7fd94803aa68, "Swift property 'SpreadsheetView.isPagingEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("isPagingEnabled")]
		bool IsPagingEnabled { get; set; }

		// @property (nonatomic) BOOL isScrollEnabled __attribute__((diagnose_if(0x7fd94803adc0, "Swift property 'SpreadsheetView.isScrollEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("isScrollEnabled")]
		bool IsScrollEnabled { get; set; }

		// @property (nonatomic) UIScrollViewIndicatorStyle indicatorStyle __attribute__((diagnose_if(0x7fd94803b118, "Swift property 'SpreadsheetView.indicatorStyle' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("indicatorStyle", ArgumentSemantic.Assign)]
		UIScrollViewIndicatorStyle IndicatorStyle { get; set; }

		// @property (nonatomic) CGFloat decelerationRate __attribute__((diagnose_if(0x7fd94803b470, "Swift property 'SpreadsheetView.decelerationRate' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("decelerationRate")]
		nfloat DecelerationRate { get; set; }

		// @property (readonly, nonatomic) NSInteger numberOfColumns __attribute__((diagnose_if(0x7fd94803b7c8, "Swift property 'SpreadsheetView.numberOfColumns' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("numberOfColumns")]
		nint NumberOfColumns { get; }

		// @property (readonly, nonatomic) NSInteger numberOfRows __attribute__((diagnose_if(0x7fd94803ba20, "Swift property 'SpreadsheetView.numberOfRows' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("numberOfRows")]
		nint NumberOfRows { get; }

		// @property (readonly, nonatomic) NSInteger frozenColumns __attribute__((diagnose_if(0x7fd94803bc78, "Swift property 'SpreadsheetView.frozenColumns' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("frozenColumns")]
		nint FrozenColumns { get; }

		// @property (readonly, nonatomic) NSInteger frozenRows __attribute__((diagnose_if(0x7fd94803bed0, "Swift property 'SpreadsheetView.frozenRows' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("frozenRows")]
		nint FrozenRows { get; }

		// @property (readonly, nonatomic, strong) UIScrollView * _Nonnull scrollView __attribute__((diagnose_if(0x7fd94803c128, "Swift property 'SpreadsheetView.scrollView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollView", ArgumentSemantic.Strong)]
		UIScrollView ScrollView { get; }

		// @property (readonly, nonatomic, strong) UIScrollView * _Nonnull rootView __attribute__((diagnose_if(0x7fd94803c400, "Swift property 'SpreadsheetView.rootView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("rootView", ArgumentSemantic.Strong)]
		UIScrollView RootView { get; }

		// @property (readonly, nonatomic, strong) UIScrollView * _Nonnull overlayView __attribute__((diagnose_if(0x7fd94803c670, "Swift property 'SpreadsheetView.overlayView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("overlayView", ArgumentSemantic.Strong)]
		UIScrollView OverlayView { get; }

		// @property (readonly, nonatomic, strong) ScrollView * _Nonnull columnHeaderView __attribute__((diagnose_if(0x7fd94803c8e8, "Swift property 'SpreadsheetView.columnHeaderView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("columnHeaderView", ArgumentSemantic.Strong)]
		ScrollView ColumnHeaderView { get; }

		// @property (readonly, nonatomic, strong) ScrollView * _Nonnull rowHeaderView __attribute__((diagnose_if(0x7fd94803cbc0, "Swift property 'SpreadsheetView.rowHeaderView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("rowHeaderView", ArgumentSemantic.Strong)]
		ScrollView RowHeaderView { get; }

		// @property (readonly, nonatomic, strong) ScrollView * _Nonnull cornerView __attribute__((diagnose_if(0x7fd946a7b2a0, "Swift property 'SpreadsheetView.cornerView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("cornerView", ArgumentSemantic.Strong)]
		ScrollView CornerView { get; }

		// @property (readonly, nonatomic, strong) ScrollView * _Nonnull tableView __attribute__((diagnose_if(0x7fd946a7b518, "Swift property 'SpreadsheetView.tableView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("tableView", ArgumentSemantic.Strong)]
		ScrollView TableView { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull blankCellReuseIdentifier __attribute__((diagnose_if(0x7fd946a7b790, "Swift property 'SpreadsheetView.blankCellReuseIdentifier' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("blankCellReuseIdentifier")]
		string BlankCellReuseIdentifier { get; }

		// @property (copy, nonatomic) NSSet<NSIndexPath *> * _Nonnull highlightedIndexPaths __attribute__((diagnose_if(0x7fd946a7ba10, "Swift property 'SpreadsheetView.highlightedIndexPaths' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("highlightedIndexPaths", ArgumentSemantic.Copy)]
		NSSet<NSIndexPath> HighlightedIndexPaths { get; set; }

		// @property (copy, nonatomic) NSSet<NSIndexPath *> * _Nonnull selectedIndexPaths __attribute__((diagnose_if(0x7fd946a7be68, "Swift property 'SpreadsheetView.selectedIndexPaths' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("selectedIndexPaths", ArgumentSemantic.Copy)]
		NSSet<NSIndexPath> SelectedIndexPaths { get; set; }

		// @property (copy, nonatomic) NSIndexPath * _Nullable pendingSelectionIndexPath __attribute__((diagnose_if(0x7fd946a7c220, "Swift property 'SpreadsheetView.pendingSelectionIndexPath' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("pendingSelectionIndexPath", ArgumentSemantic.Copy)]
		NSIndexPath PendingSelectionIndexPath { get; set; }

		// @property (nonatomic, strong) UITouch * _Nullable currentTouch __attribute__((diagnose_if(0x7fd946a7c5a8, "Swift property 'SpreadsheetView.currentTouch' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[NullAllowed, Export ("currentTouch", ArgumentSemantic.Strong)]
		UITouch CurrentTouch { get; set; }

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);

		// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSCoder aDecoder);

		// -(void)registerClass:(Class _Nonnull)cellClass forCellWithReuseIdentifier:(NSString * _Nonnull)identifier;
		[Export ("registerClass:forCellWithReuseIdentifier:")]
		void RegisterClass (Class cellClass, string identifier);

		// -(void)registerNib:(UINib * _Nonnull)nib forCellWithReuseIdentifier:(NSString * _Nonnull)identifier;
		[Export ("registerNib:forCellWithReuseIdentifier:")]
		void RegisterNib (UINib nib, string identifier);

		// -(void)reloadData __attribute__((diagnose_if(0x7fd946a7d0a8, "Swift method 'SpreadsheetView.reloadData()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("reloadData")]
		void ReloadData ();

		// -(void)reloadDataIfNeeded __attribute__((diagnose_if(0x7fd946a7d288, "Swift method 'SpreadsheetView.reloadDataIfNeeded()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("reloadDataIfNeeded")]
		void ReloadDataIfNeeded ();

		// -(Cell * _Nonnull)dequeueReusableCellWithReuseIdentifier:(NSString * _Nonnull)identifier for:(NSIndexPath * _Nonnull)indexPath __attribute__((diagnose_if(0x7fd946a7d470, "Swift method 'SpreadsheetView.dequeueReusableCell(withReuseIdentifier:for:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("dequeueReusableCellWithReuseIdentifier:for:")]
		Cell DequeueReusableCellWithReuseIdentifier (string identifier, NSIndexPath indexPath);

		// -(void)deselectItemAt:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated __attribute__((diagnose_if(0x7fd946a7d840, "Swift method 'SpreadsheetView.deselectItem(at:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("deselectItemAt:animated:")]
		void DeselectItemAt (NSIndexPath indexPath, bool animated);

		// -(NSIndexPath * _Nullable)indexPathForItemAt:(CGPoint)point __attribute__((diagnose_if(0x7fd946a7db40, "Swift method 'SpreadsheetView.indexPathForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("indexPathForItemAt:")]
		[return: NullAllowed]
		NSIndexPath IndexPathForItemAt (CGPoint point);

		// -(Cell * _Nullable)cellForItemAt:(NSIndexPath * _Nonnull)indexPath __attribute__((diagnose_if(0x7fd946a7ddd0, "Swift method 'SpreadsheetView.cellForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("cellForItemAt:")]
		[return: NullAllowed]
		Cell CellForItemAt (NSIndexPath indexPath);

		// -(NSArray<Cell *> * _Nonnull)cellsForItemAt:(NSIndexPath * _Nonnull)indexPath __attribute__((diagnose_if(0x7fd946a7e0b0, "Swift method 'SpreadsheetView.cellsForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("cellsForItemAt:")]
		Cell[] CellsForItemAt (NSIndexPath indexPath);

		// -(CGRect)rectForItemAt:(NSIndexPath * _Nonnull)indexPath __attribute__((diagnose_if(0x7fd946a7e390, "Swift method 'SpreadsheetView.rectForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("rectForItemAt:")]
		CGRect RectForItemAt (NSIndexPath indexPath);
	}

	// @interface SpreadsheetView_Swift_422 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_422
	{
		// -(UIView * _Nullable)resizableSnapshotViewFromRect:(CGRect)rect afterScreenUpdates:(BOOL)afterUpdates withCapInsets:(UIEdgeInsets)capInsets __attribute__((warn_unused_result));
		[Export ("resizableSnapshotViewFromRect:afterScreenUpdates:withCapInsets:")]
		[return: NullAllowed]
		UIView ResizableSnapshotViewFromRect (CGRect rect, bool afterUpdates, UIEdgeInsets capInsets);
	}

	// @interface SpreadsheetView_Swift_427 (SpreadsheetView) <UIScrollViewDelegate>
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_427 : IUIScrollViewDelegate
	{
		// -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
		[Export ("scrollViewDidScroll:")]
		void ScrollViewDidScroll (UIScrollView scrollView);

		// -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
		[Export ("scrollViewDidEndScrollingAnimation:")]
		void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);

		// -(void)scrollViewDidChangeAdjustedContentInset:(UIScrollView * _Nonnull)scrollView __attribute__((availability(ios, introduced=11.0)));
		[iOS (11,0)]
		[Export ("scrollViewDidChangeAdjustedContentInset:")]
		void ScrollViewDidChangeAdjustedContentInset (UIScrollView scrollView);
	}

	// @interface SpreadsheetView_Swift_434 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_434
	{
		// -(void)insertSubview:(UIView * _Nonnull)view atIndex:(NSInteger)index;
		[Export ("insertSubview:atIndex:")]
		void InsertSubview (UIView view, nint index);

		// -(void)exchangeSubviewAtIndex:(NSInteger)index1 withSubviewAtIndex:(NSInteger)index2;
		[Export ("exchangeSubviewAtIndex:withSubviewAtIndex:")]
		void ExchangeSubviewAtIndex (nint index1, nint index2);

		// -(void)addSubview:(UIView * _Nonnull)view;
		[Export ("addSubview:")]
		void AddSubview (UIView view);

		// -(void)insertSubview:(UIView * _Nonnull)view belowSubview:(UIView * _Nonnull)siblingSubview;
		[Export ("insertSubview:belowSubview:")]
		void InsertSubview (UIView view, UIView siblingSubview);

		// -(void)insertSubview:(UIView * _Nonnull)view aboveSubview:(UIView * _Nonnull)siblingSubview;
		[Export ("insertSubview:aboveSubview:")]
		void InsertSubview (UIView view, UIView siblingSubview);

		// -(void)bringSubviewToFront:(UIView * _Nonnull)view;
		[Export ("bringSubviewToFront:")]
		void BringSubviewToFront (UIView view);

		// -(void)sendSubviewToBack:(UIView * _Nonnull)view;
		[Export ("sendSubviewToBack:")]
		void SendSubviewToBack (UIView view);
	}

	// @interface SpreadsheetView_Swift_445 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_445
	{
		// -(void)scrollToHorizontalCenter __attribute__((diagnose_if(0x7fd946a7fcd8, "Swift method 'SpreadsheetView.scrollToHorizontalCenter()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollToHorizontalCenter")]
		void ScrollToHorizontalCenter ();

		// -(void)scrollToVerticalCenter __attribute__((diagnose_if(0x7fd946a7fec0, "Swift method 'SpreadsheetView.scrollToVerticalCenter()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollToVerticalCenter")]
		void ScrollToVerticalCenter ();

		// -(void)recenterHorizontallyIfNecessary __attribute__((diagnose_if(0x7fd946a800a8, "Swift method 'SpreadsheetView.recenterHorizontallyIfNecessary()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("recenterHorizontallyIfNecessary")]
		void RecenterHorizontallyIfNecessary ();

		// -(void)recenterVerticallyIfNecessary __attribute__((diagnose_if(0x7fd946a80298, "Swift method 'SpreadsheetView.recenterVerticallyIfNecessary()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("recenterVerticallyIfNecessary")]
		void RecenterVerticallyIfNecessary ();

		// -(NSInteger)determineHorizontalCircularScrollScalingFactor __attribute__((diagnose_if(0x7fd946a80488, "Swift method 'SpreadsheetView.determineHorizontalCircularScrollScalingFactor()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("determineHorizontalCircularScrollScalingFactor")]
		[Verify (MethodToProperty)]
		nint DetermineHorizontalCircularScrollScalingFactor { get; }

		// -(NSInteger)determineVerticalCircularScrollScalingFactor __attribute__((diagnose_if(0x7fd946a80698, "Swift method 'SpreadsheetView.determineVerticalCircularScrollScalingFactor()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("determineVerticalCircularScrollScalingFactor")]
		[Verify (MethodToProperty)]
		nint DetermineVerticalCircularScrollScalingFactor { get; }

		// -(CGPoint)calculateCenterOffset __attribute__((diagnose_if(0x7fd946a808a8, "Swift method 'SpreadsheetView.calculateCenterOffset()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("calculateCenterOffset")]
		[Verify (MethodToProperty)]
		CGPoint CalculateCenterOffset { get; }
	}

	// @interface SpreadsheetView_Swift_456 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_456
	{
		// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event __attribute__((diagnose_if(0x7fd946a80aa0, "Swift method 'SpreadsheetView.touchesBegan(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("touchesBegan::")]
		void TouchesBegan (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event __attribute__((diagnose_if(0x7fd946a80df0, "Swift method 'SpreadsheetView.touchesEnded(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("touchesEnded::")]
		void TouchesEnded (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event __attribute__((diagnose_if(0x7fd946a81140, "Swift method 'SpreadsheetView.touchesCancelled(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("touchesCancelled::")]
		void TouchesCancelled (NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

		// -(void)highlightItemsOn:(NSSet<UITouch *> * _Nonnull)touches __attribute__((diagnose_if(0x7fd946a81498, "Swift method 'SpreadsheetView.highlightItems(on:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("highlightItemsOn:")]
		void HighlightItemsOn (NSSet<UITouch> touches);

		// -(void)restorePreviousSelection;
		[Export ("restorePreviousSelection")]
		void RestorePreviousSelection ();

		// -(void)clearCurrentTouch;
		[Export ("clearCurrentTouch")]
		void ClearCurrentTouch ();
	}

	// @interface SpreadsheetView_Swift_466 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_466
	{
		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)resetContentSizeOf:(ScrollView * _Nonnull)scrollView __attribute__((diagnose_if(0x7fd946a819d8, "Swift method 'SpreadsheetView.resetContentSize(of:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("resetContentSizeOf:")]
		void ResetContentSizeOf (ScrollView scrollView);

		// -(void)resetScrollViewFrame __attribute__((diagnose_if(0x7fd946a81c58, "Swift method 'SpreadsheetView.resetScrollViewFrame()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("resetScrollViewFrame")]
		void ResetScrollViewFrame ();

		// -(void)resetOverlayViewContentSize:(UIEdgeInsets)contentInset __attribute__((diagnose_if(0x7fd946a81e40, "Swift method 'SpreadsheetView.resetOverlayViewContentSize(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("resetOverlayViewContentSize:")]
		void ResetOverlayViewContentSize (UIEdgeInsets contentInset);

		// -(void)resetScrollViewArrangement __attribute__((diagnose_if(0x7fd946a820a8, "Swift method 'SpreadsheetView.resetScrollViewArrangement()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("resetScrollViewArrangement")]
		void ResetScrollViewArrangement ();

		// -(NSInteger)findIndexIn:(NSArray<NSNumber *> * _Nonnull)records for:(CGFloat)offset __attribute__((diagnose_if(0x7fd946a82298, "Swift method 'SpreadsheetView.findIndex(in:for:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((warn_unused_result));
		[Export ("findIndexIn:for:")]
		nint FindIndexIn (NSNumber[] records, nfloat offset);
	}

	// @interface SpreadsheetView_Swift_476 (SpreadsheetView)
	[Category]
	[BaseType (typeof(SpreadsheetView))]
	interface SpreadsheetView_SpreadsheetView_Swift_476
	{
		// @property (nonatomic) CGPoint contentOffset __attribute__((diagnose_if(0x7fd946a82628, "Swift property 'SpreadsheetView.contentOffset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("contentOffset", ArgumentSemantic.Assign)]
		CGPoint ContentOffset { get; set; }

		// @property (nonatomic) UIEdgeInsets scrollIndicatorInsets __attribute__((diagnose_if(0x7fd946a82980, "Swift property 'SpreadsheetView.scrollIndicatorInsets' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollIndicatorInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets ScrollIndicatorInsets { get; set; }

		// @property (readonly, nonatomic) CGSize contentSize __attribute__((diagnose_if(0x7fd946a82ce0, "Swift property 'SpreadsheetView.contentSize' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("contentSize")]
		CGSize ContentSize { get; }

		// @property (nonatomic) UIEdgeInsets contentInset __attribute__((diagnose_if(0x7fd946a82f38, "Swift property 'SpreadsheetView.contentInset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("contentInset", ArgumentSemantic.Assign)]
		UIEdgeInsets ContentInset { get; set; }

		// @property (readonly, nonatomic) UIEdgeInsets adjustedContentInset __attribute__((availability(ios, introduced=11.0))) __attribute__((diagnose_if(0x7fd946a832f8, "Swift property 'SpreadsheetView.adjustedContentInset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[iOS (11, 0)]
		[Export ("adjustedContentInset")]
		UIEdgeInsets AdjustedContentInset { get; }

		// -(void)flashScrollIndicators __attribute__((diagnose_if(0x7fd946a83608, "Swift method 'SpreadsheetView.flashScrollIndicators()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((diagnose_if(0x7fd946a83710, "Swift method 'SpreadsheetView.flashScrollIndicators()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("flashScrollIndicators")]
		void FlashScrollIndicators ();

		// -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated __attribute__((diagnose_if(0x7fd946a838f8, "Swift method 'SpreadsheetView.setContentOffset(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((diagnose_if(0x7fd946a83a08, "Swift method 'SpreadsheetView.setContentOffset(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("setContentOffset:animated:")]
		void SetContentOffset (CGPoint contentOffset, bool animated);

		// -(void)scrollRectToVisible:(CGRect)rect animated:(BOOL)animated __attribute__((diagnose_if(0x7fd946a83cf0, "Swift method 'SpreadsheetView.scrollRectToVisible(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning"))) __attribute__((diagnose_if(0x7fd946a83e00, "Swift method 'SpreadsheetView.scrollRectToVisible(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("scrollRectToVisible:animated:")]
		void ScrollRectToVisible (CGRect rect, bool animated);

		// -(void)_notifyDidScroll __attribute__((diagnose_if(0x7fd946a840e8, "Swift method 'SpreadsheetView._notifyDidScroll()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint", "warning")));
		[Export ("_notifyDidScroll")]
		void _notifyDidScroll ();

		// -(BOOL)isKindOfClass:(Class _Nonnull)aClass __attribute__((warn_unused_result));
		[Export ("isKindOfClass:")]
		bool IsKindOfClass (Class aClass);

		// -(id _Nullable)forwardingTargetForSelector:(SEL _Null_unspecified)aSelector __attribute__((warn_unused_result));
		[Export ("forwardingTargetForSelector:")]
		[return: NullAllowed]
		NSObject ForwardingTargetForSelector (Selector aSelector);
	}
}
