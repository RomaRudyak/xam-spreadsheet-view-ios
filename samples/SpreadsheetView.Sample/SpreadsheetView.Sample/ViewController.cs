using System;

using UIKit;

using Spreadsheet;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;

namespace Spreadsheet.Sample
{
    // https://github.com/keshiim/ZMJGanttChart/blob/980aa1dd4078f6d44e1444da193ce7a74a7fcd37/Example/ZMJTimeable/ViewController.m
    public partial class ViewController : UIViewController, ISpreadsheetViewDataSource
    {
        private SpreadsheetView _spreadsheetView;
        private readonly string[] channels = new[]
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


            var hairline = 1 / UIScreen.MainScreen.Scale;
            _spreadsheetView.IntercellSpacing = new CGSize(width: hairline, height: hairline);
            _spreadsheetView.GridStyle = GridStyle.Style(GridStyleType.solid, 1f, UIColor.Black);
            ICircularScrollingConfiguration csb = CircularScrollingConfigurationBuilder
                .ConfigurationBuilderWithCircularScrollingState(CircularScrollingConfigurationState.horizontally_rowHeaderStartsFirstColumn);

            _spreadsheetView.CircularScrolling = csb;


            Add(_spreadsheetView);
            _spreadsheetView.FlashScrollIndicators();
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            _spreadsheetView.Frame = this.View.Bounds;
        }

        public nint NumberOfColumns(SpreadsheetView spreadsheetView) => channels.Length + 1;

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

        public ZMJCell CellForItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath) => new ZMJCell();
    }
}
