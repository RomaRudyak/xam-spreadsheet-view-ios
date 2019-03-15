using System;
using CoreGraphics;
using Spreadsheet;
using UIKit;

namespace ZMJSchedule
{
    public abstract class CellBase : ZMJCell
    {
        private Boolean _disposed;
        private UILabel _label;

        public UILabel Label => _label;

        protected CellBase(
            IntPtr handle,
            nfloat fontSize)
            : base(handle)
        {
            _label = new UILabel
            {
                Frame = Bounds,
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight,
                Font = UIFont.SystemFontOfSize(fontSize),
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

    public class DateCell : CellBase
    {
        public DateCell(IntPtr handle)
            : base(handle, 10f)
        {
        }
    }

    public class DayTitleCell : CellBase
    {
        public DayTitleCell(IntPtr handle)
            : base(handle, 12f)
        {
        }
    }

    public class TimeTitleCell : CellBase
    {
        public TimeTitleCell(IntPtr handle)
            : base(handle, 12f)
        {
        }
    }

    public class TimeCell : CellBase
    {
        public TimeCell(IntPtr handle)
            : base(handle, 12f)
        {
        }

        public override CGRect Frame
        {
            set
            {
                base.Frame = value;
                Label.Frame = new CGRect(Bounds.Location, Bounds.Size).Inset(6, 0);
            }
        }
    }

    public class ScheduleCell : CellBase
    {
        private UIColor _color;

        public ScheduleCell(IntPtr handle)
            : base(handle, 12f)
        {
        }

        public override CGRect Frame
        {
            set
            {
                base.Frame = value;
                Label.Frame = new CGRect(Bounds.Location, Bounds.Size).Inset(4, 0);
            }
        }

        public UIColor Color
        {
            get => _color;
            set
            {
                _color = value;
                BackgroundColor = _color;
            }
        }
    }
}
