sharpie bind \
    SpreadsheetView/Framework/SpreadsheetView.xcodeproj \
    -o SpreadsheetView-binding \
    -n Spreadsheet

cp -R \
    SpreadsheetView/Framework/sharpie-build/Build/Products/Release-iphoneos/SpreadsheetView.framework \
    SpreadsheetView-binding/

rm -rf SpreadsheetView/Framework/sharpie-build/