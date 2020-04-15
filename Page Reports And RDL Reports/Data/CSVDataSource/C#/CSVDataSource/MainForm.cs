using System;
using System.IO;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.CSVDataSource
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		// Loads and shows the report.
		private void btnCSV_Click(object sender, EventArgs e)
		{
			const string settingForNoHeaderDelimited = "ProductID,ProductName,SupplierID,CategoryID,QuantityPerUnit,UnitPrice,UnitsInStock,UnitsOnOrder,ReorderLevel,Discontinued";
			
			const string settingForNoHeaderFixed = "ProductID[9],ProductName[32],SupplierID[10],CategoryID[10],QuantityPerUnit[20],UnitPrice[9],UnitsInStock[12],UnitsOnOrder[12],ReorderLevel[12],Discontinued[12]";
			const string settingForHeaderExistsFixed = "[9],[32],[10],[10],[20],[9],[12],[12],[12],[12]";
			
			
			var connectionString = string.Empty;
			if (rbtnNoHeaderComma.Checked)
				connectionString = string.Format(@"Path={0};Encoding={1};TextQualifier="";ColumnsSeparator=,;RowsSeparator=\r\n;Columns={2}",
										Properties.Resources.PathToFileNoHeaderComma, Properties.Resources.CSVEncoding, settingForNoHeaderDelimited);
			else if (rbtnHeaderTab.Checked)
				connectionString = string.Format(@"Path={0};Encoding={1};TextQualifier="";ColumnsSeparator=	;RowsSeparator=\r\n;HasHeaders=True",
					  Properties.Resources.PathToFileHeaderTab, Properties.Resources.CSVEncoding);
			else if (rbtnHeader.Checked)
				connectionString = string.Format(@"Path={0};Encoding={1};Columns={2};HasHeaders=True",
										Properties.Resources.PathToFileHeader, Properties.Resources.CSVEncoding, settingForHeaderExistsFixed);
			else if (rbtnNoHeader.Checked)
				connectionString = string.Format(@"Path={0};Encoding={1};Columns={2}",
										Properties.Resources.PathToFileNoHeader, Properties.Resources.CSVEncoding, settingForNoHeaderFixed);
			var report = new PageReport(new FileInfo(@"..\..\Reports\StockList.rdlx"));
			var connectionProps = report.Report.DataSources[0].ConnectionProperties;
			connectionProps.DataProvider = "CSV";
			connectionProps.ConnectString = connectionString;
			arvMain.ReportViewer.LoadDocument(report.Document);
		}
	}
}
