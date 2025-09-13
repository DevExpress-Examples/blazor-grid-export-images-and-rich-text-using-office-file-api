<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1029081391/25.1.0%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1302036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - How to export images and rich text using Spreadsheet Document API

This example demonstrates how you can use Spreadsheet Document API to create a custom export mechanism to export images and rich text.

## Overview

Create a [Workbook](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook) instance. Iterate through Grid's data columns (you can obtain them through the [GetDataColumns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetRowValue(System.Int32-System.String)) method) and create corresponding header cells in the Workbook's active worksheet. You can use the [BeginUpdateFormatting](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.BeginUpdateFormatting?p=netframework) and [EndUpdateFormatting](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.EndUpdateFormatting(DevExpress.Spreadsheet.Formatting)) methods to format the header as required.

Then, use Grid's [GetVisibleRowCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetVisibleRowCount) and [GetRowValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetRowValue(System.Int32-System.String)) methods to iterate through its visible rows and obtain field values from each row. Use those values to populate the worksheet. To set a Cell's value, you can use the [SetValue](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.SetValue(System.Object)?p=netframework) method. To set cell value to an image, you can pass the image in the form of a stream or a byte array as a parameter to the **SetValue** method. 

To place rich text into a cell, you can use a similar approach to the one demonstrated in our [WinForms Spreadsheet Control - How to Edit Rich Text in SpreadsheetControl](https://github.com/DevExpress-Examples/winforms-spreadsheet-how-to-edit-rich-text/tree/19.1.4%2B) example. 

After populating the worksheet, create a [table](https://docs.devexpress.com/OfficeFileAPI/403308/spreadsheet-document-api/spreadsheet-tables#create-a-table) to enable filtering and sorting of the dataset in the document.

To download the document in Excel format, use the [SaveDocument{Async}](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.SaveDocument.overloads?p=netframework) method to save it to a stream or byte array and use standard Blazor techniques to send the byte array on the client. 

To downlaod the document in PDF format, use the [ExportToPdf{Async}](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.ExportToPdf.overloads) method. You can specify [PrintOptions](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.PrintOptions?p=netframework) to customize the appearance of the document (e.g., the number of pages in the resulting document).

## Files to Review
- [Index.razor](https://github.com/DevExpress-Examples/blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api/blob/25.1.0%2B/CS/ExportImagesAndRichText/Components/Pages/Index.razor)
- [CustomDocumentVisitor.cs](https://github.com/DevExpress-Examples/blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api/blob/25.1.0%2B/CS/ExportImagesAndRichText/Models/CustomDocumentVisitor.cs)

## Documentation
- [Spreadsheet Document API Examples](https://docs.devexpress.com/OfficeFileAPI/12074/spreadsheet-document-api/examples)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
