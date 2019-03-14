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

        private readonly int _numberOfRows = 24 * 60 + 1;
        private Dictionary<NSIndexPath, (int minutes, int duration)> _slotInfo = new Dictionary<NSIndexPath, (int minutes, int duration)>();

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
            _spreadsheetView.RegisterNib(SlotCell.Nib, new NSString(SlotCell.Key));
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

        public nint NumberOfRows(SpreadsheetView spreadsheetView) => _numberOfRows;

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
                HourCell cell = (HourCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(HourCell), indexPath);
                cell.Label.Text = (indexPath.Row / 60 % 24).ToString();
                cell.GridLines.Top = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                cell.GridLines.Bottom = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                return cell;
            }

            if (indexPath.GetColumn() > 0 && indexPath.Row == 0)
            {
                ChannelCell cell = (ChannelCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(ChannelCell), indexPath);
                cell.Label.Text = _channels[indexPath.GetColumn() - 1];
                cell.GridLines.Top = GridStyle.Style(GridStyleType.solid, 1, UIColor.Black);
                cell.GridLines.Bottom = GridStyle.Style(GridStyleType.solid, 1, UIColor.White);
                cell.GridLines.Left = GridStyle.Style(GridStyleType.solid, 1 / UIScreen.MainScreen.Scale, new UIColor(.3f, 1));
                cell.GridLines.Right = cell.GridLines.Left;
                return cell;
            }

            if (_slotInfo.ContainsKey(indexPath))
            {
                (int minutes, int duration) = _slotInfo[indexPath];
                SlotCell cell = (SlotCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(SlotCell.Key, indexPath);
                cell.Minutes = (int)minutes % 60;
                cell.Title = "Dummy Text";
                cell.TableHighlight = duration > 20 ? "Lorem ipsum dolor sit amet, consectetur adipiscing elit" : "";
                return cell;
            }


            return spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(MyBlankCell), indexPath);
        }

        public ZMJCellRange[] MergedCells(SpreadsheetView spreadsheetView)
        {
            List<ZMJCellRange> mergedCells = new List<ZMJCellRange>();

            for (int row = 0; row < 24; row++)
            {
                mergedCells.Add(
                    ZMJCellRange.CellRangeFrom(
                    from: new Location(60 * row + 1, 0),
                    to: new Location(60 * (row + 1), 0)));
            }
            var seeds = new int[] { 5, 10, 20, 20, 30, 30, 30, 30, 40, 40, 50, 50, 60, 60, 60, 60, 90, 90, 90, 90, 120, 120, 120 };

            var random = new Random();
            for (var index = 0; index < _channels.Length; index++)
            {
                var channel = _channels[index];
                int minutes = 0;
                while (minutes < 24 * 60)
                {
                    int duration = seeds[random.Next(seeds.Length)];
                    if (minutes + duration + 1 >= _numberOfRows)
                    {
                        mergedCells.Add(
                            ZMJCellRange.CellRangeFrom(
                                from: new Location(minutes + 1, column: index + 1),
                                to: new Location(_numberOfRows - 1, column: index + 1)));
                        break;
                    }
                    ZMJCellRange cellRange = ZMJCellRange.CellRangeFrom(
                        from: new Location(minutes + 1, column: index + 1),
                        to: new Location(minutes + duration + 1, column: index + 1));
                    mergedCells.Add(cellRange);
                    _slotInfo.Add(
                        NSIndexPath.FromRowSection(cellRange.From.Row, cellRange.From.Column),
                        (minutes, duration));
                    minutes += duration + 1;
                }
            }

            return mergedCells.ToArray();
        }
    }
}
