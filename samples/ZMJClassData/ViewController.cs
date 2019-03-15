using System;
using System.IO;
using CoreGraphics;
using Foundation;
using Spreadsheet;
using UIKit;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace ZMJClassData
{
    public enum ZMJSorting
    {
        ZMJAscending = 0,
        ZMJDsescending
    }

    public struct SortedColumn
    {
        public SortedColumn(int column, ZMJSorting sorting) : this()
        {
            Column = column;
            Sorting = sorting;
        }

        public Int32 Column { get; set; }
        public ZMJSorting Sorting { get; set; }
    }

    public partial class ViewController : UIViewController
        , ISpreadsheetViewDataSource
        , ISpreadsheetViewDelegate
    {
        private SpreadsheetView _spreadsheetView;
        private SortedColumn _sortedColumn;
        private List<string[]> _data;
        private string[] _header;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupViews();

            _sortedColumn = new SortedColumn(0, ZMJSorting.ZMJAscending);

            _data = File.ReadAllLines("data.tsv", Encoding.UTF8)
                .Select(r => r.Split('\t'))
                .ToList();

            _header = _data.First();
            _data.RemoveAt(0);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            _spreadsheetView.FlashScrollIndicators();
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            _spreadsheetView.Frame = View.SafeAreaLayoutGuide.LayoutFrame;
        }

        static string GetSymbol(ZMJSorting sorting)
        {
            switch (sorting)
            {
                case ZMJSorting.ZMJAscending:
                    return "\u25B2";
                case ZMJSorting.ZMJDsescending:
                    return "\u25BC";
                default:
                    return null;
            }
        }


        private void SetupViews()
        {
            _spreadsheetView = new SpreadsheetView
            {
                AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight
            };

            _spreadsheetView.DataSource = this;
            _spreadsheetView.Delegate = this;


            _spreadsheetView.RegisterClassForCellReuse(typeof(HeaderCell), new NSString(nameof(HeaderCell)));
            _spreadsheetView.RegisterClassForCellReuse(typeof(TextCell), new NSString(nameof(TextCell)));


            Add(_spreadsheetView);
        }

        nint ISpreadsheetViewDataSource.NumberOfColumns(SpreadsheetView spreadsheetView) => _header.Length;

        nint ISpreadsheetViewDataSource.NumberOfRows(SpreadsheetView spreadsheetView) => _data.Count + 1;

        nfloat ISpreadsheetViewDataSource.WidthForColumn(SpreadsheetView spreadsheetView, nint column) => 140f;

        nfloat ISpreadsheetViewDataSource.HeightForRow(SpreadsheetView spreadsheetView, nint row) => row == 0 ? 60f : 40f;

        ZMJCell ISpreadsheetViewDataSource.CellForItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath)
        {
            if (indexPath.Row == 0)
            {
                HeaderCell headeCell = (HeaderCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(HeaderCell), indexPath);
                headeCell.Label.Text = _header[indexPath.GetColumn()];

                if (indexPath.GetColumn() == _sortedColumn.Column)
                {
                    headeCell.SortArrow.Text = GetSymbol(_sortedColumn.Sorting);
                    return headeCell;
                }

                headeCell.SortArrow.Text = "";
                return headeCell;
            }


            TextCell cell = (TextCell)spreadsheetView.DequeueReusableCellWithReuseIdentifier(nameof(TextCell), indexPath);
            cell.Label.Text = _data[indexPath.Row - 1][indexPath.GetColumn()];
            return cell;
        }

        ZMJCellRange[] ISpreadsheetViewDataSource.MergedCells(SpreadsheetView spreadsheetView) => ZMJCellRange.None;

        nint ISpreadsheetViewDataSource.FrozenColumns(SpreadsheetView spreadsheetView) => 0;

        nint ISpreadsheetViewDataSource.FrozenRows(SpreadsheetView spreadsheetView) => 1;

        [Export("spreadsheetView:didSelectItemAt:")]
        public void DidSelectItemAt(SpreadsheetView spreadsheetView, NSIndexPath indexPath)
        {
            if (indexPath.Row != 0)
            {
                return;
            }

            if (_sortedColumn.Column == indexPath.GetColumn())
            {
                SortedColumn sc = _sortedColumn;
                sc.Sorting = _sortedColumn.Sorting == ZMJSorting.ZMJAscending
                    ? ZMJSorting.ZMJDsescending
                    : ZMJSorting.ZMJAscending;

                _sortedColumn = sc;
            }
            else
            {
                _sortedColumn = new SortedColumn((int)indexPath.GetColumn(), ZMJSorting.ZMJAscending);
            }

            if (_sortedColumn.Sorting == ZMJSorting.ZMJAscending)
            {
                _data = _data
                    .OrderBy(r => r[_sortedColumn.Column])
                    .ToList();
            }
            else
            {
                _data = _data
                    .OrderByDescending(r => r[_sortedColumn.Column])
                .ToList();
            }

            spreadsheetView.ReloadData();

        }
    }
}
