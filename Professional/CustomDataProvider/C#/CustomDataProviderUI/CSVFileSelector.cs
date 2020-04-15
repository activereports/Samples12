using System;
using System.IO;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.CustomDataProviderUI
{
	public partial class CSVFileSelector : UserControl
	{
		private string _selectedFileName="";
		
		public string CSVFileName
		{
			get { return _selectedFileName; }
		}
		
		public CSVFileSelector()
		{
			InitializeComponent();
		}
		private void btnSelectFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile = new OpenFileDialog();
			
			openFile.Filter = "CSV files(*.csv)|*.csv";
			string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\");
			openFile.InitialDirectory = Path.GetFullPath(CombinedPath);
			openFile.Title = "Select a CSV File";
			
			
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				_selectedFileName = openFile.FileName;
			}
		}
	}
}
