using System;

using UIKit;

using Spreadsheet;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;
using SpreadsheetView.Sample;

namespace Spreadsheet.Sample
{
    // https://github.com/keshiim/ZMJGanttChart/blob/980aa1dd4078f6d44e1444da193ce7a74a7fcd37/Example/ZMJTimeable/ViewController.m
    public partial class ViewController : UIViewController, ISpreadsheetViewDataSource
    {
        private SpreadsheetView _spreadsheetView;
        private readonly string[] _channels = new[]
        {
            "ABC", "NNN", "BBC", "J-Sports", "OK News", "SSS", "Apple", "CUK", "KKR", "APAR",
            "SU", "CCC", "Game", "Anime", "Tokyo NX", "NYC", "SAN", "Drama", "Hobby", "Music"
        };

        private readonly int numberOfRows = 24 * 60 + 1;
        private List<NSIndexPath> slotInfo = new List<NSIndexPath>();

        //    private DateFormatter hourFormatter = DateFormatter()
        //let twelveHourFormatter = DateFormatter()

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _spreadsheetView = new SpreadsheetView()
            {
                BackgroundColor = UIColor.Black
            };

            _spreadsheetView.DataSource = this;

            //new UITableView().RegisterClassForCellReuse

            _spreadsheetView.RegisterClassForCellReuse(typeof(HourCell), new NSString(nameof(HourCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(ChannelCell), new NSString(nameof(ChannelCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(SlotCell), new NSString(nameof(SlotCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(MyBlankCell), new NSString(nameof(MyBlankCell)));


            var hairline = 1 / UIScreen.MainScreen.Scale;
            _spreadsheetView.IntercellSpacing = new CGSize(width: hairline, height: hairline);
            _spreadsheetView.GridStyle = GridStyle.Style(GridStyleType.solid, 1f, UIColor.Black);
            //ICircularScrollingConfiguration csb = CircularScrollingConfigurationBuilder
            //    .ConfigurationBuilderWithCircularScrollingState(CircularScrollingConfigurationState.horizontally_rowHeaderStartsFirstColumn);

            // _spreadsheetView.CircularScrolling = Configuration.Instance.Horizontally;


            Add(_spreadsheetView);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            _spreadsheetView.Frame = this.View.SafeAreaLayoutGuide.LayoutFrame;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            _spreadsheetView.FlashScrollIndicators();
        }

        public nint NumberOfColumns(SpreadsheetView spreadsheetView) => _channels.Length + 1;

        public nint NumberOfRows(SpreadsheetView spreadsheetView) => numberOfRows;

        public nfloat WidthForColumn(SpreadsheetView spreadsheetView, nint column)
        {
            if (column == 0)
            {
                return 30;
            }
            return 130;
        }

        public nfloat HeightForRow(SpreadsheetView spreadsheetView, nint row)
        {
            if (row == 0)
            {
                return 44;
            }
            return 20;
        }

        public nint FrozenColumns(SpreadsheetView spreadsheetView) => 1;

        public nint FrozenRows(SpreadsheetView spreadsheetView) => 1;

        public ZMJCell CellForItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath)
        {
            if (indexPath.GetColumn() == 0 && indexPath.Row == 0)
            {
                return null;
            }

            if (indexPath.GetColumn() == 0 && indexPath.Row > 0)
            {
                HourCell cell = (HourCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(new NSString(nameof(HourCell)), indexPath);
                cell.Label.Text = (indexPath.Row / 60 % 24).ToString();
                cell.GridLines.Top = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                cell.GridLines.Bottom = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                return cell;
            }

            if (indexPath.GetColumn() > 0 && indexPath.Row == 0)
            {
                ChannelCell cell = (ChannelCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(new NSString(nameof(ChannelCell)), indexPath);
                cell.Label.Text = _channels[indexPath.GetColumn() - 1];
                cell.GridLines.Top = GridStyle.Style(GridStyleType.solid, 1, UIColor.Black);
                cell.GridLines.Bottom = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                cell.GridLines.Left = GridStyle.Style(GridStyleType.solid, 1 / UIScreen.MainScreen.Scale, new UIColor(.3f, 1));
                cell.GridLines.Right = cell.GridLines.Left;
                return cell;
            }


            return spreadsheetView.DequeueReusableCellWithReuseIdentifier(new NSString(nameof(MyBlankCell)), indexPath);
        }

        public ZMJCellRange[] MergedCells(SpreadsheetView spreadsheetView)
        {
            return new ZMJCellRange[0];
        }
    }
}
