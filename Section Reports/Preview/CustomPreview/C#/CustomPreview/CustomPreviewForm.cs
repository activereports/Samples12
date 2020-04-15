using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using GrapeCity.ActiveReports.Data;
using GrapeCity.SpreadBuilder;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	/// <summary>
	/// Demonstrates viewer control customization, export filters, 
	/// mail merge and groups.
	/// </summary>
	public partial class CustomPreviewForm : System.Windows.Forms.Form
	{
		// Holds connection string to the sample database.
		private readonly string _connectString; 
		private IContainer components;
		public CustomPreviewForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			_connectString = Properties.Resources.ConnectionString;
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CustomPreviewForm());
		}
		/// <summary>
		/// ShowReport - takes the supplied SectionReport object and loads it into
		/// the PreviewForm for viewing.
		/// </summary>
		/// <param name="rpt">SectionReport object to run and display.</param>
		private void ShowReport(SectionReport rpt)
		{
			// Change the mouse cursor to the wait cursor.
			Cursor tmp = Cursor;
			Cursor = Cursors.WaitCursor;
			try
			{
				// Make the sure the connection string points to the correct file location.
				OleDBDataSource ds = (OleDBDataSource)rpt.DataSource;
				ds.ConnectionString = _connectString;
			   
				// Create a new instance of the preview form.
				PreviewForm viewerForm = new PreviewForm(rpt.Document, this);
				viewerForm.Show();
				rpt.Run();
			}
			catch (ReportException ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				Cursor = tmp;
			}
		}
		/// <summary>
		/// mnuFileOpen_Click - Used to open a generated report file (RDF) and display it.
		/// </summary>
		private void mnuFileOpen_Click(object sender, EventArgs e)
		{
			
			dlgOpenFile.Filter = "ActiveReports Document Files (*.rdf)|*.rdf";
			
			
			dlgOpenFile.FileName = "";
			dlgOpenFile.CheckFileExists = true;
			
			dlgOpenFile.Title = "Open a Report Document File";
			
			
			if (dlgOpenFile.ShowDialog(this) == DialogResult.OK)
			{
				if (File.Exists(dlgOpenFile.FileName))
				{
					// Load the RDF file.
					Document.SectionDocument doc = new Document.SectionDocument();
					doc.Load(dlgOpenFile.FileName);
					// Open a new Preview Form.
					PreviewForm viewerForm = new PreviewForm(doc, this);
					viewerForm.Show();
				}
			}
		}
		/// <summary>
		/// mnuFileExit_Click - exits the application
		/// </summary>
		private void mnuFileExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		/// <summary>
		/// mnuRCatalog_Click - Loads the Catalog report into a new child
		/// preview form
		/// </summary>
		private void mnuRCatalog_Click(object sender, EventArgs e)
		{
			ShowReport(new Catalog());
		}
		/// <summary>
		/// mnuRCustomerLabels_Click - Loads the Customer Labels report into
		/// a new child preview form.
		/// </summary>
		private void mnuRCustomerLabels_Click(object sender, EventArgs e)
		{
			ShowReport(new CustomerLabels());
		}
		/// <summary>
		/// mnuREmployeeProfiles_Click - loads the Employee Profiles report
		/// into a new child preview form.
		/// </summary>
		private void mnuREmployeeProfiles_Click(object sender, EventArgs e)
		{
			ShowReport(new EmployeeProfiles());
		}
		/// <summary>
		/// mnuRInvoice_Click - loads the Invoice report into a new child
		/// preview form.
		/// </summary>
		private void mnuRInvoice_Click(object sender, EventArgs e)
		{
			ShowReport(new Invoice());
		}
		/// <summary>
		/// mnuRLetter_Click - loads the Letter report into a new child
		/// preview form
		/// </summary>
		private void mnuRLetter_Click(object sender, EventArgs e)
		{
			ShowReport(new Letter());
		}
		private void mnuEmployeeSales_Click(object sender, EventArgs e)
		{
			ShowReport(new EmployeeSales());
		}
		private void menuSpreadBuilderitem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();  // Create a new instance of the Save File dialog.
			Cursor tmpCursor = Cursor;
			string strFileName = Application.StartupPath + @"\..\..\Sample.csv"; 
			
			sfd.Title = "Creating an Excel file by SpreadBuilder API"; 
			
				  
			// Title
			sfd.FileName = "SpreadBuilder.xls";// Name of the file for initial display.
			sfd.Filter = "Excel 97-2003|*.xls";// Filter
			if (sfd.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			try
			{
				// Change the cursor.
				tmpCursor = Cursor;
				Cursor = Cursors.WaitCursor;
				Application.DoEvents();
			   // Load the CSV file.
				 
				StreamReader sr = new StreamReader(strFileName); 
				
				
				// Add a sheet in the workbook collection.
				Workbook sb = new Workbook();
				sb.Sheets.AddNew();
				// Set the properties of the sheet name and column
				
				sb.Sheets[0].Name = "CITY List";
				
				
				
				sb.Sheets[0].Columns(0).Width = 1440;
				sb.Sheets[0].Columns(1).Width = 1440 * 2;
				sb.Sheets[0].Columns(2).Width = 1440;
				sb.Sheets[0].Columns(3).Width = 1440 * 4;
				sb.Sheets[0].Rows(0).Height = 1440 / 4;
				// Sets the row header.
				 sb.Sheets[0].Cell(0, 0).SetValue("Code"); 
				
				 sb.Sheets[0].Cell(0, 1).SetValue("Name"); 
				
				 sb.Sheets[0].Cell(0, 2).SetValue("Postal code"); 
				
				 sb.Sheets[0].Cell(0, 3).SetValue("Location"); 
				
			   // Set the format of the header line.
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).FontName = "MS PGothic"; 
				
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).FontSize = 11;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).FontBold = true;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).ForeColor = Color.White;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).FillColor = Color.Navy;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).Alignment = SpreadBuilder.Style.HorzAlignments.Center;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).VertAlignment = SpreadBuilder.Style.VertAlignments.Center;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 0), sb.Sheets[0].Cell(0, 3)).BorderTopStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(0, 1), sb.Sheets[0].Cell(0, 3)).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Thin;
				//Sets the formatting of some of the cells in the header line 
				sb.Sheets[0].Cell(0, 0).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
				sb.Sheets[0].Cell(0, 3).BorderRightStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
				//Read the contents of a CSV file line by line
				Int32 iRec = 1;
				while (sr.Peek() > -1)
				{
					// Split each field into one line.
					string thisLine = sr.ReadLine();
					string[] thisArray = thisLine.Split(',');
					//Set the properties and values ​for column, rows and cells.
					//(Set the height of the line)
					sb.Sheets[0].Rows(0).Height = 1440 / 4;
					// (Set the value)
					sb.Sheets[0].Cell(iRec, 0).SetValue(thisArray[0].Replace(Convert.ToString(Convert.ToChar(34)), ""));
					sb.Sheets[0].Cell(iRec, 1).SetValue(thisArray[1].Replace(Convert.ToString(Convert.ToChar(34)), ""));
					sb.Sheets[0].Cell(iRec, 2).SetValue(thisArray[3].Replace(Convert.ToString(Convert.ToChar(34)), ""));
					sb.Sheets[0].Cell(iRec, 3).SetValue(thisArray[2].Replace(Convert.ToString(Convert.ToChar(34)), ""));
					// (Set a border)
					sb.Sheets[0].Cells(sb.Sheets[0].Cell(iRec, 0), sb.Sheets[0].Cell(iRec, 3)).BorderBottomStyle = SpreadBuilder.Style.BorderLineStyle.Thin;
					sb.Sheets[0].Cells(sb.Sheets[0].Cell(iRec, 1), sb.Sheets[0].Cell(iRec, 3)).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Dotted;
					sb.Sheets[0].Cell(iRec, 0).BorderLeftStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
					sb.Sheets[0].Cell(iRec, 3).BorderRightStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
					// (To change the format, one per line)
					if ((iRec % 2) == 0)
					{
						sb.Sheets[0].Cells(sb.Sheets[0].Cell(iRec, 0), sb.Sheets[0].Cell(iRec, 3)).FillColor = Color.LightCyan;
					}
					else
					{
						sb.Sheets[0].Cells(sb.Sheets[0].Cell(iRec, 0), sb.Sheets[0].Cell(iRec, 3)).FillColor = Color.PaleTurquoise;
					}
					// Increments the counter.
					iRec += 1;
				}
				
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(1, 0), sb.Sheets[0].Cell(iRec - 1, 3)).FontName = "MS PGothic"; 
				
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(1, 0), sb.Sheets[0].Cell(iRec - 1, 3)).FontSize = 10;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(1, 0), sb.Sheets[0].Cell(iRec - 1, 3)).VertAlignment = SpreadBuilder.Style.VertAlignments.Center;
				//(Only the third row and first column)
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(1, 0), sb.Sheets[0].Cell(iRec - 1, 0)).Alignment = SpreadBuilder.Style.HorzAlignments.Center;
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(1, 2), sb.Sheets[0].Cell(iRec - 1, 2)).Alignment = SpreadBuilder.Style.HorzAlignments.Center;
				// (Only the last line)
				sb.Sheets[0].Cells(sb.Sheets[0].Cell(iRec - 1, 0), sb.Sheets[0].Cell(iRec - 1, 3)).BorderBottomStyle = SpreadBuilder.Style.BorderLineStyle.Medium;
				//Save the workbook to an Excel file.
				sb.Save(sfd.FileName);
				sr.Close();
				// Display a notification message.
				MessageBox.Show("File has been saved to::" + sfd.FileName, Text, MessageBoxButtons.OK, MessageBoxIcon.Information); 
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				//Replace the cursor. 
				Cursor = tmpCursor;
				Application.DoEvents();
			}
		}
	}
}
