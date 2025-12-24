using ClosedXML.Excel;
using InventoryFlow.Entities.DTOs;

namespace InventoryFlow.UI.Reports
{
    public static class ExcelReporter
    {
        public static void ExportProducts(List<ProductDetailDto> products, string filePath)
        {
            ArgumentNullException.ThrowIfNull(products);

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new ArgumentException("File path is required.", nameof(filePath));
            }

            using var workbook = CreateWorkbook();
            var worksheet = workbook.Worksheets.Add("Products");

            WriteHeader(worksheet);
            WriteRows(worksheet, products);
            FinalizeWorksheet(workbook, worksheet, filePath);
        }

        private static XLWorkbook CreateWorkbook()
        {
            return new XLWorkbook();
        }

        private static void WriteHeader(IXLWorksheet worksheet)
        {
            worksheet.Cell(1, 1).Value = "ID";
            worksheet.Cell(1, 2).Value = "Product Name";
            worksheet.Cell(1, 3).Value = "Category";
            worksheet.Cell(1, 4).Value = "Unit Price";
            worksheet.Cell(1, 5).Value = "Stock Amount";

            var headerRange = worksheet.Range("A1:E1");
            headerRange.Style.Font.Bold = true;
            headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
        }

        private static void WriteRows(IXLWorksheet worksheet, IEnumerable<ProductDetailDto> products)
        {
            var row = 2;

            foreach (var product in products)
            {
                worksheet.Cell(row, 1).Value = product.ProductId;
                worksheet.Cell(row, 2).Value = product.ProductName;
                worksheet.Cell(row, 3).Value = product.CategoryName;
                worksheet.Cell(row, 4).Value = product.UnitPrice;
                worksheet.Cell(row, 5).Value = product.StockAmount;
                row++;
            }
        }

        private static void FinalizeWorksheet(XLWorkbook workbook, IXLWorksheet worksheet, string filePath)
        {
            worksheet.Columns().AdjustToContents();
            workbook.SaveAs(filePath);
        }
    }
}