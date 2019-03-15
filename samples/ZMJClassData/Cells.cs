using System;
using CoreGraphics;
using Spreadsheet;
using UIKit;

namespace ZMJClassData
{
    public abstract class CellBase : ZMJCell
    {
        private Boolean _disposed;
        private UILabel _label;

        public UILabel Label => _label;

        protected CellBase(
            IntPtr handle,
            UIColor bgColor,
            UIColor textColor,
            nfloat fontSize)
            : base(handle)
        {
            _label = new UILabel
            {
                Frame = Bounds,
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
                BackgroundColor = bgColor,
                Font = UIFont.SystemFontOfSize(fontSize),
                TextColor = textColor,
                TextAlignment = UITextAlignment.Left,
                Lines = 2
            };

            AddSubview(_label);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                _disposed = true;
                _label.RemoveFromSuperview();
                _label.Dispose();
                _label = null;
            }
            base.Dispose(disposing);
        }
    }

    class HeaderCell : CellBase
    {
        private bool _disposed = false;

        public UILabel SortArrow { get; private set; }

        public HeaderCell(IntPtr handle)
            : base(
                handle,
                UIColor.Clear,
                UIColor.Black,
                14)
        {
            SortArrow = new UILabel();
            SortArrow.Font = UIFont.BoldSystemFontOfSize(14);
            SortArrow.TextAlignment = UITextAlignment.Center;

            AddSubview(SortArrow);
        }

        public override CGRect Frame
        {
            set
            {
                base.Frame = value;
                Label.Frame = new CGRect(Bounds.Location, Bounds.Size).Inset(4, 2);
            }
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();

            SortArrow.SizeToFit();
            SortArrow.Frame = new CGRect(
                new CGPoint(
                    Frame.Size.Width - SortArrow.Frame.Size.Width - 8,
                    (Frame.Size.Height / 2) - SortArrow.Frame.Size.Height
                ),
                SortArrow.Frame.Size
            );
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && !_disposed)
            {
                _disposed = true;
                SortArrow.RemoveFromSuperview();
                SortArrow.Dispose();
                SortArrow = null;
            }
            base.Dispose(disposing);
        }
    }

    class TextCell : CellBase
    {
        public UILabel SortArrow { get; private set; }

        public TextCell(IntPtr handle)
            : base(
                handle,
                new UIColor(0.0f, 0.0f, 1.0f, 0.2f),
                UIColor.White,
                14)
        {
            SelectedBackgroundView = ContentView;
        }

        public override CGRect Frame
        {
            set
            {
                base.Frame = value;
                Label.Frame = new CGRect(Bounds.Location, Bounds.Size).Inset(4, 2);
            }
        }
    }
    }
