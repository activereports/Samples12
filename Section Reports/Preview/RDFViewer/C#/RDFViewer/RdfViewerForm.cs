using System;
using System.IO;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.RdfViewer
{
	public partial class RdfViewerForm : Form
	{
		public RdfViewerForm()
		{
			InitializeComponent();
			arvMain.TableOfContents.Width = 200;
		}
		/// <summary>
		/// GetReportDoc - used to get the current loaded document object.
		/// </summary>
		/// <returns>Current Document object loaded into the viewer control.</returns>
		public Document.SectionDocument ReportDoc
		{
			get
			{
				return arvMain.Document;
			}
		}
		/// <summary>
		/// mnuOpen_Click - Used to open an RDF file to load into the viewer control.
  		/// </summary>
		private void mnuOpen_Click(object sender, EventArgs e)
		{
			
			dlgOpenFile.Filter = "ActiveReports Report File(*.rdf)|*.rdf";
			
			
			string CombinedPath = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\..\\RDFs");
			dlgOpenFile.InitialDirectory = Path.GetFullPath(CombinedPath);
			dlgOpenFile.ShowDialog();
		}
		/// <summary>
		/// openFileDialog_FileOk - Loads selected file into the viewer control.
		/// </summary>
		private void dlgOpenFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (dlgOpenFile.FileName.Length != 0)
			{
				arvMain.LoadDocument(dlgOpenFile.FileName);
			}
		}
		/// <summary>
		/// mnuPrint_Click - Sends the current report to the default printer.
		/// </summary>
		private void mnuPrint_Click(object sender, EventArgs e)
		{
			if (arvMain.Document.Pages.Count > 0)
			{
				arvMain.Document.Print();
			}
		}
		/// <summary>
		/// mnuExit_Click - Closes the application.
		/// </summary>
		private void mnuExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		/// <summary>
		/// mnuToolbar_Click - Used to show/hide the toolbar on the viewer control.
		/// </summary>
		private void mnuToolbar_Click(object sender, EventArgs e)
		{
			arvMain.Toolbar.ToolStrip.Visible = mnuToolbar.Checked;
		}
		/// <summary>
		/// mnuExport_Click - Used to open the export form to export the loaded document object.
		/// </summary>
		private void mnuExport_Click(object sender, EventArgs e)
		{
			if (arvMain.Document.Pages.Count == 0)
			{
				
				MessageBox.Show("Please select a Report to Export", "Export Denied");
				
				
			}
			else
			{
				ExportForm _frm = new ExportForm(arvMain.Document);
			  
				_frm.ShowDialog();
			}
		}
		private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
		{
			arvMain.Width = 200;
			if (ViewToolStripMenuItem.Checked == true)
				arvMain.Sidebar.Visible = true;
			else
				arvMain.Sidebar.Visible = false;
		}
	}
}
