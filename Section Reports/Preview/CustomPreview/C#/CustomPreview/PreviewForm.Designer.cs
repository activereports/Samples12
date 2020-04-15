using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class PreviewForm
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
private System.Windows.Forms.MainMenu mnuMain;
private System.Windows.Forms.MenuItem mnuFile;
private System.Windows.Forms.MenuItem mnuExport;
private System.Windows.Forms.MenuItem mnuSaveDocument;
private System.Windows.Forms.PrintDialog dlgPrint;
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuExport = new System.Windows.Forms.MenuItem();
			this.mnuSaveDocument = new System.Windows.Forms.MenuItem();
			this.dlgPrint = new System.Windows.Forms.PrintDialog();
			this.SuspendLayout();
			// 
			// arvMain
			// 
			this.arvMain.BackColor = System.Drawing.SystemColors.Control;
			this.arvMain.CurrentPage = 0;
			resources.ApplyResources(this.arvMain, "arvMain");
			this.arvMain.Name = "arvMain";
			this.arvMain.PreviewPages = 0;
			// 
			// 
			// 
			// 
			// 
			// 
			this.arvMain.Sidebar.ParametersPanel.ContextMenu = null;
			this.arvMain.Sidebar.ParametersPanel.Width = 180;
			// 
			// 
			// 
			this.arvMain.Sidebar.SearchPanel.ContextMenu = null;
			this.arvMain.Sidebar.SearchPanel.Width = 180;
			// 
			// 
			// 
			this.arvMain.Sidebar.ThumbnailsPanel.ContextMenu = null;
			this.arvMain.Sidebar.ThumbnailsPanel.Width = 180;
			// 
			// 
			// 
			this.arvMain.Sidebar.TocPanel.ContextMenu = null;
			this.arvMain.Sidebar.TocPanel.Width = 180;
			this.arvMain.Sidebar.Width = 180;
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.mnuFile});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.mnuExport,
			this.mnuSaveDocument});
			this.mnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			resources.ApplyResources(this.mnuFile, "mnuFile");
			// 
			// mnuExport
			// 
			this.mnuExport.Index = 0;
			resources.ApplyResources(this.mnuExport, "mnuExport");
			this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
			// 
			// mnuSaveDocument
			// 
			this.mnuSaveDocument.Index = 1;
			resources.ApplyResources(this.mnuSaveDocument, "mnuSaveDocument");
			this.mnuSaveDocument.Click += new System.EventHandler(this.mnuSaveDocument_Click);
			// 
			// dlgPrint
			// 
			this.dlgPrint.AllowSomePages = true;
			// 
			// PreviewForm
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.arvMain);
			this.Menu = this.mnuMain;
			this.Name = "PreviewForm";
			this.Load += new System.EventHandler(this.PreviewForm_Load);
			this.ResumeLayout(false);
		}
		#endregion
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
	}
}
