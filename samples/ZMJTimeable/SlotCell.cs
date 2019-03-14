using Foundation;
using System;
using UIKit;
using Spreadsheet;

namespace SpreadsheetView.Sample
{
    public partial class SlotCell : ZMJCell
    {
        public static UINib Nib = UINib.FromName(nameof(SlotCell), null);
        public static String Key = nameof(SlotCell);

        private int _minutes;
        private string _title;
        private string _tableHighlight;

        public SlotCell(IntPtr handle)
            : base(handle)
        {
        }

        public int Minutes
        {
            get => _minutes;
            set
            {
                _minutes = value;
                minutesLabel.Text = _minutes.ToString("00");
            }
        }

        public String Title
        {
            get => _title;
            set
            {
                _title = value;
                titleLabel.Text = _title;
            }
        }

        public String TableHighlight
        {
            get => _tableHighlight;
            set
            {
                _tableHighlight = value;
                tableHighlightLabel.Text = _tableHighlight;
            }
        }
    }
}