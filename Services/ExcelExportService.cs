using ClosedXML.Excel;

namespace FCR.Services;

public interface IExcelExportService
{
    byte[] Export<T>(IEnumerable<T> data, string sheetName = "Sheet1");
}

public class ExcelExportService : IExcelExportService
{
    public byte[] Export<T>(IEnumerable<T> data, string sheetName = "Sheet1")
    {
        using var workbook = new XLWorkbook();
        var ws = workbook.Worksheets.Add(sheetName);

        var props = typeof(T).GetProperties();
        for (int i = 0; i < props.Length; i++)
        {
            ws.Cell(1, i + 1).Value = props[i].Name;
        }

        int row = 2;
        foreach( var item in data)
        {
            for (int col = 0; col < props.Length; col++)
            {
                ws.Cell(row, col + 1).Value = props[col].GetValue(item)!.ToString();
            }
            row++;
        }

        ws.Columns().AdjustToContents();

        using var stream = new MemoryStream();
        workbook.SaveAs(stream);
        return stream.ToArray();
    }
}
