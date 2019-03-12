using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Spreadsheet
{
    public partial class SpreadsheetView : UIView
    {
        public void RegisterClassForCellReuse(Type cellType, NSString reuseIdentifier)
        {
            var pointer = (cellType == null) 
                ? IntPtr.Zero 
                : Class.GetHandle(cellType);
            RegisterClass(pointer, reuseIdentifier);
        }

    }
}
