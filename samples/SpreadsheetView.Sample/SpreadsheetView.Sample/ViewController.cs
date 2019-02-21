using System;

using UIKit;

using Spreadsheet;
using Foundation;
using System.Collections.Generic;
using CoreGraphics;

namespace Spreadsheet.Sample
{
    // https://github.com/kishikawakatsumi/SpreadsheetView/blob/72919594953b6daf5d050a342a6101318f78e77d/Examples/Timetable/Sources/ViewController.swift
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
            //_spreadsheetView.GridStyle = .solid(width: hairline, color: .lightGray);
            //_spreadsheetView.CircularScrolling = CircularScrolling.Configuration.horizontally.rowHeaderStartsFirstColumn;


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
            return 2;
        }

        public nint FrozenColumns(SpreadsheetView spreadsheetView) => 1;

        public nint FrozenRows(SpreadsheetView spreadsheetView) => 1;

        public CellRange[] MergedCells(SpreadsheetView spreadsheetView)
        {
            return new CellRange[0];
        }
    }
}
