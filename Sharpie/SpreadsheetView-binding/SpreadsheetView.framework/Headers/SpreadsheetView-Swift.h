// Generated by Apple Swift version 4.2.1 effective-4.1.50 (swiftlang-1000.11.42 clang-1000.11.45.1)
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Wgcc-compat"

#if !defined(__has_include)
# define __has_include(x) 0
#endif
#if !defined(__has_attribute)
# define __has_attribute(x) 0
#endif
#if !defined(__has_feature)
# define __has_feature(x) 0
#endif
#if !defined(__has_warning)
# define __has_warning(x) 0
#endif

#if __has_include(<swift/objc-prologue.h>)
# include <swift/objc-prologue.h>
#endif

#pragma clang diagnostic ignored "-Wauto-import"
#include <objc/NSObject.h>
#include <stdint.h>
#include <stddef.h>
#include <stdbool.h>

#if !defined(SWIFT_TYPEDEFS)
# define SWIFT_TYPEDEFS 1
# if __has_include(<uchar.h>)
#  include <uchar.h>
# elif !defined(__cplusplus)
typedef uint_least16_t char16_t;
typedef uint_least32_t char32_t;
# endif
typedef float swift_float2  __attribute__((__ext_vector_type__(2)));
typedef float swift_float3  __attribute__((__ext_vector_type__(3)));
typedef float swift_float4  __attribute__((__ext_vector_type__(4)));
typedef double swift_double2  __attribute__((__ext_vector_type__(2)));
typedef double swift_double3  __attribute__((__ext_vector_type__(3)));
typedef double swift_double4  __attribute__((__ext_vector_type__(4)));
typedef int swift_int2  __attribute__((__ext_vector_type__(2)));
typedef int swift_int3  __attribute__((__ext_vector_type__(3)));
typedef int swift_int4  __attribute__((__ext_vector_type__(4)));
typedef unsigned int swift_uint2  __attribute__((__ext_vector_type__(2)));
typedef unsigned int swift_uint3  __attribute__((__ext_vector_type__(3)));
typedef unsigned int swift_uint4  __attribute__((__ext_vector_type__(4)));
#endif

#if !defined(SWIFT_PASTE)
# define SWIFT_PASTE_HELPER(x, y) x##y
# define SWIFT_PASTE(x, y) SWIFT_PASTE_HELPER(x, y)
#endif
#if !defined(SWIFT_METATYPE)
# define SWIFT_METATYPE(X) Class
#endif
#if !defined(SWIFT_CLASS_PROPERTY)
# if __has_feature(objc_class_property)
#  define SWIFT_CLASS_PROPERTY(...) __VA_ARGS__
# else
#  define SWIFT_CLASS_PROPERTY(...)
# endif
#endif

#if __has_attribute(objc_runtime_name)
# define SWIFT_RUNTIME_NAME(X) __attribute__((objc_runtime_name(X)))
#else
# define SWIFT_RUNTIME_NAME(X)
#endif
#if __has_attribute(swift_name)
# define SWIFT_COMPILE_NAME(X) __attribute__((swift_name(X)))
#else
# define SWIFT_COMPILE_NAME(X)
#endif
#if __has_attribute(objc_method_family)
# define SWIFT_METHOD_FAMILY(X) __attribute__((objc_method_family(X)))
#else
# define SWIFT_METHOD_FAMILY(X)
#endif
#if __has_attribute(noescape)
# define SWIFT_NOESCAPE __attribute__((noescape))
#else
# define SWIFT_NOESCAPE
#endif
#if __has_attribute(warn_unused_result)
# define SWIFT_WARN_UNUSED_RESULT __attribute__((warn_unused_result))
#else
# define SWIFT_WARN_UNUSED_RESULT
#endif
#if __has_attribute(noreturn)
# define SWIFT_NORETURN __attribute__((noreturn))
#else
# define SWIFT_NORETURN
#endif
#if !defined(SWIFT_CLASS_EXTRA)
# define SWIFT_CLASS_EXTRA
#endif
#if !defined(SWIFT_PROTOCOL_EXTRA)
# define SWIFT_PROTOCOL_EXTRA
#endif
#if !defined(SWIFT_ENUM_EXTRA)
# define SWIFT_ENUM_EXTRA
#endif
#if !defined(SWIFT_CLASS)
# if __has_attribute(objc_subclassing_restricted)
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) __attribute__((objc_subclassing_restricted)) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# else
#  define SWIFT_CLASS(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
#  define SWIFT_CLASS_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_CLASS_EXTRA
# endif
#endif

#if !defined(SWIFT_PROTOCOL)
# define SWIFT_PROTOCOL(SWIFT_NAME) SWIFT_RUNTIME_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
# define SWIFT_PROTOCOL_NAMED(SWIFT_NAME) SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_PROTOCOL_EXTRA
#endif

#if !defined(SWIFT_EXTENSION)
# define SWIFT_EXTENSION(M) SWIFT_PASTE(M##_Swift_, __LINE__)
#endif

#if !defined(OBJC_DESIGNATED_INITIALIZER)
# if __has_attribute(objc_designated_initializer)
#  define OBJC_DESIGNATED_INITIALIZER __attribute__((objc_designated_initializer))
# else
#  define OBJC_DESIGNATED_INITIALIZER
# endif
#endif
#if !defined(SWIFT_ENUM_ATTR)
# if defined(__has_attribute) && __has_attribute(enum_extensibility)
#  define SWIFT_ENUM_ATTR(_extensibility) __attribute__((enum_extensibility(_extensibility)))
# else
#  define SWIFT_ENUM_ATTR(_extensibility)
# endif
#endif
#if !defined(SWIFT_ENUM)
# define SWIFT_ENUM(_type, _name, _extensibility) enum _name : _type _name; enum SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# if __has_feature(generalized_swift_name)
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) enum _name : _type _name SWIFT_COMPILE_NAME(SWIFT_NAME); enum SWIFT_COMPILE_NAME(SWIFT_NAME) SWIFT_ENUM_ATTR(_extensibility) SWIFT_ENUM_EXTRA _name : _type
# else
#  define SWIFT_ENUM_NAMED(_type, _name, SWIFT_NAME, _extensibility) SWIFT_ENUM(_type, _name, _extensibility)
# endif
#endif
#if !defined(SWIFT_UNAVAILABLE)
# define SWIFT_UNAVAILABLE __attribute__((unavailable))
#endif
#if !defined(SWIFT_UNAVAILABLE_MSG)
# define SWIFT_UNAVAILABLE_MSG(msg) __attribute__((unavailable(msg)))
#endif
#if !defined(SWIFT_AVAILABILITY)
# define SWIFT_AVAILABILITY(plat, ...) __attribute__((availability(plat, __VA_ARGS__)))
#endif
#if !defined(SWIFT_DEPRECATED)
# define SWIFT_DEPRECATED __attribute__((deprecated))
#endif
#if !defined(SWIFT_DEPRECATED_MSG)
# define SWIFT_DEPRECATED_MSG(...) __attribute__((deprecated(__VA_ARGS__)))
#endif
#if __has_feature(attribute_diagnose_if_objc)
# define SWIFT_DEPRECATED_OBJC(Msg) __attribute__((diagnose_if(1, Msg, "warning")))
#else
# define SWIFT_DEPRECATED_OBJC(Msg) SWIFT_DEPRECATED_MSG(Msg)
#endif
#if __has_feature(modules)
@import CoreGraphics;
@import Foundation;
@import ObjectiveC;
@import QuartzCore;
@import UIKit;
#endif

#pragma clang diagnostic ignored "-Wproperty-attribute-mismatch"
#pragma clang diagnostic ignored "-Wduplicate-method-arg"
#if __has_warning("-Wpragma-clang-attribute")
# pragma clang diagnostic ignored "-Wpragma-clang-attribute"
#endif
#pragma clang diagnostic ignored "-Wunknown-pragmas"
#pragma clang diagnostic ignored "-Wnullability"

#if __has_attribute(external_source_symbol)
# pragma push_macro("any")
# undef any
# pragma clang attribute push(__attribute__((external_source_symbol(language="Swift", defined_in="SpreadsheetView",generated_declaration))), apply_to=any(function,enum,objc_interface,objc_category,objc_protocol))
# pragma pop_macro("any")
#endif

@class NSCoder;

SWIFT_CLASS("_TtC15SpreadsheetView4Cell")
@interface Cell : UIView
@property (nonatomic, readonly, strong) UIView * _Nonnull contentView SWIFT_DEPRECATED_OBJC("Swift property 'Cell.contentView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, strong) UIView * _Nullable backgroundView SWIFT_DEPRECATED_OBJC("Swift property 'Cell.backgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, strong) UIView * _Nullable selectedBackgroundView SWIFT_DEPRECATED_OBJC("Swift property 'Cell.selectedBackgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) BOOL isHighlighted SWIFT_DEPRECATED_OBJC("Swift property 'Cell.isHighlighted' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) BOOL isSelected SWIFT_DEPRECATED_OBJC("Swift property 'Cell.isSelected' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) BOOL hasBorder SWIFT_DEPRECATED_OBJC("Swift property 'Cell.hasBorder' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSString * _Nullable reuseIdentifier SWIFT_DEPRECATED_OBJC("Swift property 'Cell.reuseIdentifier' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSIndexPath * _Null_unspecified indexPath SWIFT_DEPRECATED_OBJC("Swift property 'Cell.indexPath' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)setup SWIFT_DEPRECATED_OBJC("Swift method 'Cell.setup()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)prepareForReuse SWIFT_DEPRECATED_OBJC("Swift method 'Cell.prepareForReuse()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)setSelected:(BOOL)selected animated:(BOOL)animated SWIFT_DEPRECATED_OBJC("Swift method 'Cell.setSelected(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@end


SWIFT_CLASS("_TtC15SpreadsheetView9BlankCell")
@interface BlankCell : Cell
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
@end


SWIFT_CLASS("_TtC15SpreadsheetView6Border")
@interface Border : UIView
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)drawRect:(CGRect)rect;
- (void)layoutSubviews;
@end




@class UIColor;
@protocol CAAction;

SWIFT_CLASS("_TtC15SpreadsheetView8Gridline")
@interface Gridline : CALayer
@property (nonatomic, strong) UIColor * _Nonnull color SWIFT_DEPRECATED_OBJC("Swift property 'Gridline.color' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (nonnull instancetype)init OBJC_DESIGNATED_INITIALIZER;
- (nonnull instancetype)initWithLayer:(id _Nonnull)layer OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (id <CAAction> _Nullable)actionForKey:(NSString * _Nonnull)event SWIFT_WARN_UNUSED_RESULT;
@end

@class UITouch;
@class UIEvent;
@class UIGestureRecognizer;

SWIFT_CLASS("_TtC15SpreadsheetView10ScrollView")
@interface ScrollView : UIScrollView <UIGestureRecognizerDelegate>
@property (nonatomic, copy) NSArray<NSNumber *> * _Nonnull columnRecords SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.columnRecords' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSArray<NSNumber *> * _Nonnull rowRecords SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.rowRecords' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) void (^ _Nullable touchesBegan)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.touchesBegan' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) void (^ _Nullable touchesEnded)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.touchesEnded' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) void (^ _Nullable touchesCancelled)(NSSet<UITouch *> * _Nonnull, UIEvent * _Nullable) SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.touchesCancelled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) BOOL hasDisplayedContent SWIFT_DEPRECATED_OBJC("Swift property 'ScrollView.hasDisplayedContent' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)resetReusableObjects SWIFT_DEPRECATED_OBJC("Swift method 'ScrollView.resetReusableObjects()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (BOOL)gestureRecognizer:(UIGestureRecognizer * _Nonnull)gestureRecognizer shouldRecognizeSimultaneouslyWithGestureRecognizer:(UIGestureRecognizer * _Nonnull)otherGestureRecognizer SWIFT_WARN_UNUSED_RESULT;
- (BOOL)touchesShouldBegin:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event inContentView:(UIView * _Nonnull)view SWIFT_WARN_UNUSED_RESULT;
- (void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
- (void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
- (void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
@end

@class UINib;

SWIFT_CLASS("_TtC15SpreadsheetView15SpreadsheetView")
@interface SpreadsheetView : UIView
/// The horizontal and vertical spacing between cells.
/// note:
/// The default spacing is <code>(1.0, 1.0)</code>. Negative values are not supported.
@property (nonatomic) CGSize intercellSpacing SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.intercellSpacing' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that indicates whether users can select cells in the spreadsheet view.
/// note:
/// If the value of this property is <code>true</code> (the default), users can select cells.
/// If you want more fine-grained control over the selection of cells,
/// you must provide a delegate object and implement the appropriate methods of the <code>SpreadsheetViewDelegate</code> protocol.
/// seealso:
/// <code>allowsMultipleSelection</code>
@property (nonatomic) BOOL allowsSelection SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.allowsSelection' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether users can select more than one cell in the spreadsheet view.
/// note:
/// This property controls whether multiple cells can be selected simultaneously.
/// The default value of this property is <code>false</code>.
/// When the value of this property is true, tapping a cell adds it to the current selection (assuming the delegate permits the cell to be selected).
/// Tapping the cell again removes it from the selection.
/// seealso:
/// <code>allowsSelection</code>
@property (nonatomic) BOOL allowsMultipleSelection SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.allowsMultipleSelection' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that controls whether the vertical scroll indicator is visible.
/// The default value is <code>true</code>. The indicator is visible while tracking is underway and fades out after tracking.
@property (nonatomic) BOOL showsVerticalScrollIndicator SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.showsVerticalScrollIndicator' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that controls whether the horizontal scroll indicator is visible.
/// The default value is <code>true</code>. The indicator is visible while tracking is underway and fades out after tracking.
@property (nonatomic) BOOL showsHorizontalScrollIndicator SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.showsHorizontalScrollIndicator' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that controls whether the scroll-to-top gesture is enabled.
/// note:
/// The scroll-to-top gesture is a tap on the status bar. When a user makes this gesture,
/// the system asks the scroll view closest to the status bar to scroll to the top.
/// If that scroll view has <code>scrollsToTop</code> set to <code>false</code>, its delegate returns false from <code>scrollViewShouldScrollToTop(_:)</code>,
/// or the content is already at the top, nothing happens.
/// After the scroll view scrolls to the top of the content view, it sends the delegate a <code>scrollViewDidScrollToTop(_:)</code> message.
/// The default value of scrollsToTop is <code>true</code>.
/// On iPhone, the scroll-to-top gesture has no effect if there is more than one scroll view on-screen that has <code>scrollsToTop</code> set to <code>true</code>.
@property (nonatomic) BOOL scrollsToTop SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.scrollsToTop' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) CGPoint centerOffset SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.centerOffset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// The view that provides the background appearance.
/// note:
/// The view (if any) in this property is positioned underneath all of the other content and sized automatically to fill the entire bounds of the spreadsheet view.
/// The background view does not scroll with the spreadsheet view’s other content. The spreadsheet view maintains a strong reference to the background view object.
/// This property is nil by default, which displays the background color of the spreadsheet view.
@property (nonatomic, strong) UIView * _Nullable backgroundView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.backgroundView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)safeAreaInsetsDidChange SWIFT_AVAILABILITY(ios,introduced=11.0);
/// Returns an array of visible cells currently displayed by the spreadsheet view.
/// note:
/// This method returns the complete list of visible cells displayed by the collection view.
///
/// returns:
/// An array of <code>Cell</code> objects. If no cells are visible, this method returns an empty array.
@property (nonatomic, readonly, copy) NSArray<Cell *> * _Nonnull visibleCells SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.visibleCells' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// An array of the visible items in the collection view.
/// note:
/// The value of this property is a sorted array of IndexPath objects, each of which corresponds to a visible cell in the spreadsheet view.
/// If there are no visible items, the value of this property is an empty array.
/// seealso:
/// <code>visibleCells</code>
@property (nonatomic, readonly, copy) NSArray<NSIndexPath *> * _Nonnull indexPathsForVisibleItems SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.indexPathsForVisibleItems' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, copy) NSIndexPath * _Nullable indexPathForSelectedItem SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.indexPathForSelectedItem' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// The index paths for the selected items.
/// note:
/// The value of this property is an array of IndexPath objects, each of which corresponds to a single selected item.
/// If there are no selected items, the value of this property is nil.
@property (nonatomic, readonly, copy) NSArray<NSIndexPath *> * _Nonnull indexPathsForSelectedItems SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.indexPathsForSelectedItems' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether scrolling is disabled in a particular direction.
/// note:
/// If this property is <code>false</code>, scrolling is permitted in both horizontal and vertical directions.
/// If this property is <code>true</code> and the user begins dragging in one general direction (horizontally or vertically), the scroll view disables scrolling in the other direction.
/// If the drag direction is diagonal, then scrolling will not be locked and the user can drag in any direction until the drag completes.
/// The default value is <code>false</code>
@property (nonatomic) BOOL isDirectionalLockEnabled SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.isDirectionalLockEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that controls whether the scroll view bounces past the edge of content and back again.
/// note:
/// If the value of this property is <code>true</code>, the scroll view bounces when it encounters a boundary of the content.
/// Bouncing visually indicates that scrolling has reached an edge of the content.
/// If the value is <code>false</code>, scrolling stops immediately at the content boundary without bouncing.
/// The default value is <code>true</code>.
/// seealso:
/// <code>alwaysBounceHorizontal</code>, <code>alwaysBounceVertical</code>
@property (nonatomic) BOOL bounces SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.bounces' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether bouncing always occurs when vertical scrolling reaches the end of the content.
/// note:
/// If this property is set to true and <code>bounces</code> is <code>true</code>, vertical dragging is allowed even if the content is smaller than the bounds of the scroll view.
/// The default value is <code>false</code>.
/// seealso:
/// <code>alwaysBounceHorizontal</code>
@property (nonatomic) BOOL alwaysBounceVertical SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.alwaysBounceVertical' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether bouncing always occurs when horizontal scrolling reaches the end of the content view.
/// note:
/// If this property is set to <code>true</code> and <code>bounces</code> is <code>true</code>, horizontal dragging is allowed even if the content is smaller than the bounds of the scroll view.
/// The default value is <code>false</code>.
/// seealso:
/// <code>alwaysBounceVertical</code>
@property (nonatomic) BOOL alwaysBounceHorizontal SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.alwaysBounceHorizontal' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines wheather the row header always sticks to the top.
/// note:
/// <code>bounces</code> has to be <code>true</code> and there has to be at least one <code>frozenRow</code>.
/// The default value is <code>false</code>.
/// seealso:
/// <code>stickyColumnHeader</code>
@property (nonatomic) BOOL stickyRowHeader SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.stickyRowHeader' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines wheather the column header always sticks to the top.
/// note:
/// <code>bounces</code> has to be <code>true</code> and there has to be at least one <code>frozenColumn</code>.
/// The default value is <code>false</code>.
/// seealso:
/// <code>stickyRowHeader</code>
@property (nonatomic) BOOL stickyColumnHeader SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.stickyColumnHeader' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether paging is enabled for the scroll view.
/// note:
/// If the value of this property is <code>true</code>, the scroll view stops on multiples of the scroll view’s bounds when the user scrolls.
/// The default value is false.
@property (nonatomic) BOOL isPagingEnabled SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.isPagingEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A Boolean value that determines whether scrolling is enabled.
/// note:
/// If the value of this property is <code>true</code>, scrolling is enabled, and if it is <code>false</code>, scrolling is disabled. The default is <code>true</code>.
/// When scrolling is disabled, the scroll view does not accept touch events; it forwards them up the responder chain.
@property (nonatomic) BOOL isScrollEnabled SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.isScrollEnabled' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// The style of the scroll indicators.
/// note:
/// The default style is <code>default</code>. See <code>UIScrollViewIndicatorStyle</code> for descriptions of these constants.
@property (nonatomic) UIScrollViewIndicatorStyle indicatorStyle SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.indicatorStyle' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
/// A floating-point value that determines the rate of deceleration after the user lifts their finger.
/// note:
/// Your application can use the <code>UIScrollViewDecelerationRateNormal</code> and UIScrollViewDecelerationRateFast` constants as reference points for reasonable deceleration rates.
@property (nonatomic) CGFloat decelerationRate SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.decelerationRate' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) NSInteger numberOfColumns SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.numberOfColumns' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) NSInteger numberOfRows SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.numberOfRows' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) NSInteger frozenColumns SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.frozenColumns' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) NSInteger frozenRows SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.frozenRows' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) UIScrollView * _Nonnull scrollView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.scrollView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) UIScrollView * _Nonnull rootView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.rootView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) UIScrollView * _Nonnull overlayView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.overlayView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) ScrollView * _Nonnull columnHeaderView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.columnHeaderView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) ScrollView * _Nonnull rowHeaderView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.rowHeaderView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) ScrollView * _Nonnull cornerView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.cornerView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, strong) ScrollView * _Nonnull tableView SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.tableView' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly, copy) NSString * _Nonnull blankCellReuseIdentifier SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.blankCellReuseIdentifier' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSSet<NSIndexPath *> * _Nonnull highlightedIndexPaths SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.highlightedIndexPaths' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSSet<NSIndexPath *> * _Nonnull selectedIndexPaths SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.selectedIndexPaths' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, copy) NSIndexPath * _Nullable pendingSelectionIndexPath SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.pendingSelectionIndexPath' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, strong) UITouch * _Nullable currentTouch SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.currentTouch' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (nonnull instancetype)initWithFrame:(CGRect)frame OBJC_DESIGNATED_INITIALIZER;
- (nullable instancetype)initWithCoder:(NSCoder * _Nonnull)aDecoder OBJC_DESIGNATED_INITIALIZER;
- (void)registerClass:(SWIFT_METATYPE(Cell) _Nonnull)cellClass forCellWithReuseIdentifier:(NSString * _Nonnull)identifier;
- (void)registerNib:(UINib * _Nonnull)nib forCellWithReuseIdentifier:(NSString * _Nonnull)identifier;
- (void)reloadData SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.reloadData()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)reloadDataIfNeeded SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.reloadDataIfNeeded()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (Cell * _Nonnull)dequeueReusableCellWithReuseIdentifier:(NSString * _Nonnull)identifier for:(NSIndexPath * _Nonnull)indexPath SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.dequeueReusableCell(withReuseIdentifier:for:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)deselectItemAt:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.deselectItem(at:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (NSIndexPath * _Nullable)indexPathForItemAt:(CGPoint)point SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.indexPathForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (Cell * _Nullable)cellForItemAt:(NSIndexPath * _Nonnull)indexPath SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.cellForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (NSArray<Cell *> * _Nonnull)cellsForItemAt:(NSIndexPath * _Nonnull)indexPath SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.cellsForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (CGRect)rectForItemAt:(NSIndexPath * _Nonnull)indexPath SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.rectForItem(at:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
- (UIView * _Nullable)resizableSnapshotViewFromRect:(CGRect)rect afterScreenUpdates:(BOOL)afterUpdates withCapInsets:(UIEdgeInsets)capInsets SWIFT_WARN_UNUSED_RESULT;
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView)) <UIScrollViewDelegate>
- (void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
- (void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
- (void)scrollViewDidChangeAdjustedContentInset:(UIScrollView * _Nonnull)scrollView SWIFT_AVAILABILITY(ios,introduced=11.0);
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
- (void)insertSubview:(UIView * _Nonnull)view atIndex:(NSInteger)index;
- (void)exchangeSubviewAtIndex:(NSInteger)index1 withSubviewAtIndex:(NSInteger)index2;
- (void)addSubview:(UIView * _Nonnull)view;
- (void)insertSubview:(UIView * _Nonnull)view belowSubview:(UIView * _Nonnull)siblingSubview;
- (void)insertSubview:(UIView * _Nonnull)view aboveSubview:(UIView * _Nonnull)siblingSubview;
- (void)bringSubviewToFront:(UIView * _Nonnull)view;
- (void)sendSubviewToBack:(UIView * _Nonnull)view;
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
- (void)scrollToHorizontalCenter SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.scrollToHorizontalCenter()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)scrollToVerticalCenter SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.scrollToVerticalCenter()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)recenterHorizontallyIfNecessary SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.recenterHorizontallyIfNecessary()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)recenterVerticallyIfNecessary SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.recenterVerticallyIfNecessary()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (NSInteger)determineHorizontalCircularScrollScalingFactor SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.determineHorizontalCircularScrollScalingFactor()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (NSInteger)determineVerticalCircularScrollScalingFactor SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.determineVerticalCircularScrollScalingFactor()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (CGPoint)calculateCenterOffset SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.calculateCenterOffset()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
- (void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.touchesBegan(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.touchesEnded(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches :(UIEvent * _Nullable)event SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.touchesCancelled(_:_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)highlightItemsOn:(NSSet<UITouch *> * _Nonnull)touches SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.highlightItems(on:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)restorePreviousSelection;
- (void)clearCurrentTouch;
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
- (void)layoutSubviews;
- (void)resetContentSizeOf:(ScrollView * _Nonnull)scrollView SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.resetContentSize(of:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)resetScrollViewFrame SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.resetScrollViewFrame()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)resetOverlayViewContentSize:(UIEdgeInsets)contentInset SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.resetOverlayViewContentSize(_:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)resetScrollViewArrangement SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.resetScrollViewArrangement()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (NSInteger)findIndexIn:(NSArray<NSNumber *> * _Nonnull)records for:(CGFloat)offset SWIFT_WARN_UNUSED_RESULT SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.findIndex(in:for:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@end


@interface SpreadsheetView (SWIFT_EXTENSION(SpreadsheetView))
@property (nonatomic) CGPoint contentOffset SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.contentOffset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) UIEdgeInsets scrollIndicatorInsets SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.scrollIndicatorInsets' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) CGSize contentSize SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.contentSize' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic) UIEdgeInsets contentInset SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.contentInset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
@property (nonatomic, readonly) UIEdgeInsets adjustedContentInset SWIFT_DEPRECATED_OBJC("Swift property 'SpreadsheetView.adjustedContentInset' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint") SWIFT_AVAILABILITY(ios,introduced=11.0);
- (void)flashScrollIndicators SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.flashScrollIndicators()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.setContentOffset(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)scrollRectToVisible:(CGRect)rect animated:(BOOL)animated SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView.scrollRectToVisible(_:animated:)' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (void)_notifyDidScroll SWIFT_DEPRECATED_OBJC("Swift method 'SpreadsheetView._notifyDidScroll()' uses '@objc' inference deprecated in Swift 4; add '@objc' to provide an Objective-C entrypoint");
- (BOOL)isKindOfClass:(Class _Nonnull)aClass SWIFT_WARN_UNUSED_RESULT;
- (id _Nullable)forwardingTargetForSelector:(SEL _Null_unspecified)aSelector SWIFT_WARN_UNUSED_RESULT;
@end

#if __has_attribute(external_source_symbol)
# pragma clang attribute pop
#endif
#pragma clang diagnostic pop
