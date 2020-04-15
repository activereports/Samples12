using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	/// <summary>
	/// PreviewForm - child MDI form that loads the ActiveReports Viewer to view a report
	/// and provides options to export, save and print the generated report.
	/// </summary>
	public partial class PreviewForm : System.Windows.Forms.Form
	{
		private IContainer components;
		public PreviewForm(Document.SectionDocument doc, Form parentForm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			
			MdiParent = parentForm;
			arvMain.LoadDocument(doc);
			Text = doc.Name;
		}
		private void PreviewForm_Load(object sender, System.EventArgs e)
		{
			// Add custom buttons to the viewer's toolbar.
			Icon ico = new Icon(GetType().Module.Assembly.GetManifestResourceStream("GrapeCity.ActiveReports.Samples.CustomPreview.Resources.Save16x16.ico"));
			arvMain.Toolbar.ToolStrip.ImageList
				= new ImageList();
			arvMain.Toolbar.ToolStrip.ImageList.Images.Add("saveicon", ico);
			ico = new Icon(GetType().Module.Assembly.GetManifestResourceStream("GrapeCity.ActiveReports.Samples.CustomPreview.Resources.Export16x16.ico"));
			arvMain.Toolbar.ToolStrip.ImageList.Images.Add("exporticon", ico);
			ToolStrip ts = arvMain.Toolbar.ToolStrip;
			//Add Save toolstrip button to the toolbar.
			
			ToolStripButton tsbSaveRdf = new ToolStripButton("Save");
			
			
			tsbSaveRdf.Image = arvMain.Toolbar.ToolStrip.ImageList.Images["saveicon"];
			tsbSaveRdf.Click += new EventHandler(tsbSaveRdf_Click);
			//Add Export toolstrip button to the toolbar
			
			ToolStripButton tsbExport = new ToolStripButton("Export");
			
			
			tsbExport.Image = arvMain.Toolbar.ToolStrip.ImageList.Images["exporticon"];
			tsbExport.Click += new EventHandler(tsbExport_Click);
			ts.Items.Add(new ToolStripSeparator());
			ts.Items.Add(tsbSaveRdf);
			ts.Items.Add(new ToolStripSeparator());
			ts.Items.Add(tsbExport);
		}
		void tsbExport_Click(object sender, EventArgs e)
		{
			ExportDocument();
		}
		void tsbSaveRdf_Click(object sender, EventArgs e)
		{
			SaveDocument();
		}
		
		/// <summary>
		/// Saves out an existing report document to the RDF format.
		/// </summary>
		private void SaveDocument()
		{
			SaveFileDialog dlgSave = new SaveFileDialog();
			
			dlgSave.Title = "Save Report Document";
			
			
			
			dlgSave.Filter = "Report Document Files (*.rdf)|*.rdf";
			
			
			dlgSave.DefaultExt = "rdf";
			dlgSave.AddExtension = true;
			if (dlgSave.ShowDialog(this) == DialogResult.OK)
			{
				if (File.Exists(dlgSave.FileName))
				{
					
					if (MessageBox.Show(this, "Overwrite Existing File?", "Overwrite", MessageBoxButtons.YesNo) != DialogResult.Yes)
					
					
					{
						return;
					}
				}
				arvMain.Document.Save(dlgSave.FileName);
			}
		}
		/// <summary>
		/// Opens the export form to export the current report document.
		/// </summary>
		private void ExportDocument()
		{
			ExportForm exportForm = new ExportForm(arvMain.Document);
			exportForm.ShowDialog(this);
		}
		/// <summary>
		/// Call ExportDocument() on mnuExport_Click to to export the
		/// current report document.
		/// </summary>
		private void mnuExport_Click(object sender, EventArgs e)
		{
			ExportDocument();
		}
		/// <summary>
		/// Call SaveDocument() on mnuSaveDocument_Click to save the 
		/// current report document to RDF format.
		/// </summary>
		private void mnuSaveDocument_Click(object sender, EventArgs e)
		{
			SaveDocument();
		}
	}
}
