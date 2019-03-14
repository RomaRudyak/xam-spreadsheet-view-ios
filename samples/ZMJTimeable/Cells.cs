using System;
using Spreadsheet;
using UIKit;
using CoreGraphics;

namespace SpreadsheetView.Sample
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
                TextAlignment = UITextAlignment.Center,
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

    class HourCell : CellBase
    {
        public HourCell(IntPtr handle)
            : base(
                handle,
                new UIColor(0.2f, 0.4f, 0.8f, 1),
                UIColor.White,
                12)
        {
        }
    }

    class ChannelCell : CellBase
    {
        private string _channel;

        public ChannelCell(IntPtr handle)
            : base(
                handle,
                UIColor.DarkGray,
                UIColor.LightTextColor.ColorWithAlpha(.7f),
                15)
        {
        }

        public String Channel
        {
            get => _channel;
            set
            {
                _channel = value;
                Label.Text = _channel;
            }
        }
    }

    class MyBlankCell : BlankCell
    {
        public MyBlankCell(IntPtr handle)
            : base(handle)
        {
            BackgroundColor = new UIColor(0.9f, 1);
        }
    }
}
