using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Converter;
using Syncfusion.Windows.Shared;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();        
        }

        private void OnExcelExporting(object sender, RoutedEventArgs e)
        {           
            var options = new ExcelExportingOptions();          
            options.CellsExportingEventHandler = CellExportingHandler;
            options.ExcelVersion = ExcelVersion.Excel2016;
            options.ExportAllPages = true;
            var excelEngine = dataGrid.ExportToExcel(dataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];
            workBook.SaveAs("Export.xlsx");
            Process.Start(new ProcessStartInfo{ FileName = "Export.xlsx"});
        }
        private static void CellExportingHandler(object sender, GridCellExcelExportingEventArgs e)
        {
            if (e.CellType == ExportCellType.RecordCell && e.ColumnName == "OrderDate")
            {               
                if (DateTime.TryParse(e.CellValue.ToString(), out DateTime orderDate)) 
                    // To set the formmatting with culture specific
                    e.Range.Cells[0].Value = orderDate.ToString("MM/dd/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
                else
                    e.Range.Cells[0].Value = e.CellValue.ToString();
                
                e.Handled = true;
            } 
        }
    }
}
