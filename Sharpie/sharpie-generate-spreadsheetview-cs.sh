sharpie bind \
    SpreadsheetView/Framework/SpreadsheetView.xcodeproj \
    -o SpreadsheetView-binding

cp -R \
    SpreadsheetView/Framework/sharpie-build/Build/Products/Release-iphoneos/SpreadsheetView.framework \
    SpreadsheetView-binding/

rm -rf SpreadsheetView/Framework/sharpie-build/