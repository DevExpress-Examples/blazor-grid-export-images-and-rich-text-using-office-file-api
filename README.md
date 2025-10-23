<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/1029081391/25.1.0%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1302036)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Blazor Grid - Export Images/Rich Text Using Spreadsheet Document APIs

This example uses Spreadsheet Document APIs to implement an export mechanism for cells that contain images and rich text.

> [!IMPORTANT]
> You need a license for the [DevExpress Office File API Subscription](https://www.devexpress.com/products/net/office-file-api/) or [DevExpress Universal Subscription](https://www.devexpress.com/subscriptions/universal.xml) to use these capabilities in production code.

![DevExpress Blazor - Export Images and Rich Text](blazor-export-images-rich-text.png)

## Implementation Details

### Set Up Grid

Create a DevExpress Blazor Grid and populate it with data. Use [CellDisplayTemplate](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGridDataColumn.CellDisplayTemplate) to display an [image](./CS/ExportImagesAndRichText/Components/Pages/Index.razor#L43) or [rich text](./CS/ExportImagesAndRichText/Components/Pages/Index.razor#L35) within a cell.

### Implement Export Engine

To implement image/rich text export, you must:

1. Create a [Workbook](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook) instance. 
1. Iterate through Grid data columns (using the [GetVisibleColumns](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetVisibleColumns) method) and create corresponding header cells in the Workbook active worksheet. You can call [BeginUpdateFormatting](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.BeginUpdateFormatting?p=netframework) and [EndUpdateFormatting](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.EndUpdateFormatting(DevExpress.Spreadsheet.Formatting)) methods to apply header formatting.
1. Call [DxGrid.GetVisibleRowCount](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetVisibleRowCount) and [DxGrid.GetRowValue](https://docs.devexpress.com/Blazor/DevExpress.Blazor.DxGrid.GetRowValue(System.Int32-System.String)) methods to iterate through visible rows and obtain cell values from each row. 
1. Populate the worksheet with cell values using the [SetValue](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.SetValue(System.Object)?p=netframework) method. 
1. _Optional._ Create a [table](https://docs.devexpress.com/OfficeFileAPI/403308/spreadsheet-document-api/spreadsheet-tables#create-a-table) to enable filter and sorting data in the exported document.
1. Call the [SaveDocument{Async}](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.SaveDocument.overloads?p=netframework)/[ExportToPdf{Async}](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Workbook.ExportToPdf.overloads) method to export the resulting document. 
1. _Optional._ Specify [PrintOptions](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.Worksheet.PrintOptions?p=netframework) to customize document appearance.

## Files to Review

* [Index.razor](https://github.com/DevExpress-Examples/blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api/blob/25.1.0%2B/CS/ExportImagesAndRichText/Components/Pages/Index.razor)
* [CustomDocumentVisitor.cs](https://github.com/DevExpress-Examples/blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api/blob/25.1.0%2B/CS/ExportImagesAndRichText/Models/CustomDocumentVisitor.cs)

## Documentation

- [Spreadsheet Document API Examples](https://docs.devexpress.com/OfficeFileAPI/12074/spreadsheet-document-api/examples)
- [Blazor Grid](https://docs.devexpress.com/Blazor/403143/components/grid)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=blazor-grid-how-to-export-images-and-rich-text-using-spreadsheet-document-api&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
