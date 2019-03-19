using System;
using CoreGraphics;
using Spreadsheet;
using UIKit;
using Foundation;

namespace ZMJSchedule
{
    public partial class ViewController : UIViewController, ISpreadsheetViewDataSource, ISpreadsheetViewDelegate
    {
        private string[] _dates;
        private string[] _days;
        private UIColor[] _dayColors;
        private string[] _hours;
        private UIColor _evenRowColor;
        private UIColor _oddRowColor;
        private string[][] _data;
        private SpreadsheetView _spreadsheetView;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupMembers();
            SetupViews();
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();

            _spreadsheetView.Frame = View.SafeAreaLayoutGuide.LayoutFrame;
        }

        ZMJCell ISpreadsheetViewDataSource.CellForItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath)
        {
            nint column = indexPath.GetColumn();
            if (column >= 1
                && indexPath.Row <= _dates.Length + 1
                && indexPath.Row == 0)
            {
                DateCell cell = (DateCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(DateCell), indexPath);
                cell.Label.Text = _dates[column - 1];
                return cell;
            }

            if (column >= 1
                && column <= _days.Length + 1
                && indexPath.Row == 1)
            {
                DayTitleCell cell = (DayTitleCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(DayTitleCell), indexPath);
                cell.Label.Text = _days[column - 1];
                cell.Label.TextColor = _dayColors[column - 1];
                return cell;
            }

            if (column == 0
                && indexPath.Row == 1)
            {
                TimeTitleCell cell = (TimeTitleCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(TimeTitleCell), indexPath);
                cell.Label.Text = "TIME";
                return cell;
            }

            if (column == 0
                && indexPath.Row >= 2
                && indexPath.Row <= _hours.Length + 2)
            {
                TimeCell cell = (TimeCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(TimeCell), indexPath);

                cell.Label.Text = _hours[indexPath.Row - 2];
                cell.BackgroundColor = indexPath.Row % 2 == 0
                    ? _evenRowColor
                    : _oddRowColor;
                return cell;
            }

            if (column >= 1
                && column <= _days.Length + 1
                && indexPath.Row >= 2
                && indexPath.Row <= _hours.Length + 2)
            {
                ScheduleCell cell = (ScheduleCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(ScheduleCell), indexPath);

                String text = _data[column - 1][indexPath.Row - 2];
                if (!String.IsNullOrWhiteSpace(text))
                {
                    cell.Label.Text = text;
                    UIColor color = _dayColors[column - 1];
                    cell.Label.TextColor = color;
                    cell.Color = color.ColorWithAlpha(0.2f);
                    cell.Borders.Top = new BorderStyle(BorderStyleType.Solid, 2f, color);
                    cell.Borders.Bottom = new BorderStyle(BorderStyleType.Solid, 2f, color);
                }
                else
                {
                    cell.Label.Text = null;
                    cell.Color = indexPath.Row % 2 == 0 
                        ? _evenRowColor 
                        : _oddRowColor;
                    cell.Borders.Top = BorderStyle.BorderStyleNone;
                    cell.Borders.Bottom = BorderStyle.BorderStyleNone;
                }
                return cell;
            }

            return null;
        }

        nint ISpreadsheetViewDataSource.FrozenColumns(SpreadsheetView spreadsheetView) => 1;

        nint ISpreadsheetViewDataSource.FrozenRows(SpreadsheetView spreadsheetView) => 2;

        nfloat ISpreadsheetViewDataSource.HeightForRow(SpreadsheetView spreadsheetView, nint row)
        {
            if (0 == row)
            {
                return 24f;
            }
            if (1 == row)
            {
                return 32f;
            }
            return 40f;
        }

        nfloat ISpreadsheetViewDataSource.WidthForColumn(SpreadsheetView spreadsheetView, nint column)
        {
            if (0 == column)
            {
                return 70f;
            }
            return 120f;
        }

        ZMJCellRange[] ISpreadsheetViewDataSource.MergedCells(SpreadsheetView spreadsheetView) => ZMJCellRange.None;

        nint ISpreadsheetViewDataSource.NumberOfColumns(SpreadsheetView spreadsheetView)
        {
            return _days.Length + 1;
        }

        nint ISpreadsheetViewDataSource.NumberOfRows(SpreadsheetView spreadsheetView)
        {
            return _hours.Length + 2;
        }

        [Export("spreadsheetView:didSelectItemAt:")]
        public void DidSelectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath)
        {
            Console.WriteLine($"Row: {indexPath.Row}, Column: {indexPath.GetColumn()}");
        }

        private void SetupMembers()
        {
            _dates = new[] { "7/10/2017", "7/11/2017", "7/12/2017", "7/13/2017", "7/14/2017", "7/15/2017", "7/16/2017" };
            _days = new[] { "MONDAY", "TUESDAY", "WEDNSDAY", "THURSDAY", "FRIDAY", "SATURDAY", "SUNDAY" };
            _dayColors = new[]
            {
                new UIColor(0.918f, 0.224f, 0.153f, 1f),
                new UIColor(0.106f, 0.541f, 0.827f, 1f),
                new UIColor(0.200f, 0.620f, 0.565f, 1f),
                new UIColor(0.953f, 0.498f, 0.098f, 1f),
                new UIColor(0.400f, 0.584f, 0.141f, 1f),
                new UIColor(0.835f, 0.655f, 0.051f, 1f),
                new UIColor(0.153f, 0.569f, 0.835f, 1f)
            };
            _hours = new[]
            {
                "6:00 AM", "7:00 AM", "8:00 AM", "9:00 AM", "10:00 AM", "11:00 AM", "12:00 AM", "1:00 PM", "2:00 PM",
                "3:00 PM", "4:00 PM", "5:00 PM", "6:00 PM", "7:00 PM", "8:00 PM", "9:00 PM", "10:00 PM", "11:00 PM"};
            _evenRowColor = new UIColor(0.91f, 0.91f, 0.91f, 1f);
            _oddRowColor = UIColor.White;
            _data = new[]
            {
                new[] { "", "", "Take medicine", "", "", "", "", "", "", "", "", "", "", "Movie with family", "", "", "", "", "", "" },
                new[] { "Leave for cabin", "", "", "", "", "Lunch with Tim", "", "", "", "", "", "", "", "", "", "", "", "", "", "" },
                new[] { "", "", "", "", "Downtown parade", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" },
                new[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "Fireworks show", "", "", "" },
                new[] {"", "", "", "", "", "Family BBQ", "", "", "", "", "", "", "", "", "", "", "", "", "", "" },
                new[] {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""},
                new[] {"", "", "", "", "", "", "", "", "", "", "", "", "", "Return home", "", "", "", "", "", ""}
            };

        }

        private void SetupViews()
        {
            _spreadsheetView = new SpreadsheetView
            {
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight
            };

            _spreadsheetView.DataSource = this;
            _spreadsheetView.Delegate = this;

            _spreadsheetView.SetContentInset(new UIEdgeInsets(4, 0, 4, 0));

            _spreadsheetView.IntercellSpacing = new CGSize(4, 1);
            _spreadsheetView.GridStyle = GridStyle.BorderStyleNone;


            _spreadsheetView.RegisterClassForCellReuse(typeof(DateCell), new NSString(nameof(DateCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(TimeTitleCell), new NSString(nameof(TimeTitleCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(TimeCell), new NSString(nameof(TimeCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(DayTitleCell), new NSString(nameof(DayTitleCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(ScheduleCell), new NSString(nameof(ScheduleCell)));

            Add(_spreadsheetView);
        }

    }
}
