using System.Windows.Forms;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Controls;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Document.Section;
namespace GrapeCity.ActiveReports.Samples.RdfViewer
{
	partial class RdfViewerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		  
		#region Windows Form Designer generated code  
		
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RdfViewerForm));
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.mnuMain = new System.Windows.Forms.ToolStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripDropDownButton();
			this.mnuOpen = new System.Windows.Forms.ToolStripButton();
			this.mnuExport = new System.Windows.Forms.ToolStripButton();
			this.mnuPrint = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripButton();
			this.mnuView = new System.Windows.Forms.ToolStripDropDownButton();
			this.ViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// dlgOpenFile
			// 
			resources.ApplyResources(this.dlgOpenFile, "dlgOpenFile");
			this.dlgOpenFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenFile_FileOk);
			// 
			// mnuMain
			// 
			resources.ApplyResources(this.mnuMain, "mnuMain");
			this.mnuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuFile,
			this.mnuView});
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			// 
			// mnuFile
			// 
			resources.ApplyResources(this.mnuFile, "mnuFile");
			this.mnuFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.mnuOpen,
			this.mnuExport,
			this.mnuPrint,
			this.toolStripSeparator,
			this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.ShowDropDownArrow = false;
			// 
			// mnuOpen
			// 
			resources.ApplyResources(this.mnuOpen, "mnuOpen");
			this.mnuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuOpen.Name = "mnuOpen";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
			// 
			// mnuExport
			// 
			resources.ApplyResources(this.mnuExport, "mnuExport");
			this.mnuExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuExport.Name = "mnuExport";
			this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
			// 
			// mnuPrint
			// 
			resources.ApplyResources(this.mnuPrint, "mnuPrint");
			this.mnuPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuPrint.Name = "mnuPrint";
			this.mnuPrint.Click += new System.EventHandler(this.mnuPrint_Click);
			// 
			// toolStripSeparator
			// 
			resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
			this.toolStripSeparator.Name = "toolStripSeparator";
			// 
			// mnuExit
			// 
			resources.ApplyResources(this.mnuExit, "mnuExit");
			this.mnuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuView
			// 
			resources.ApplyResources(this.mnuView, "mnuView");
			this.mnuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.ViewToolStripMenuItem,
			this.mnuToolbar});
			this.mnuView.Name = "mnuView";
			this.mnuView.ShowDropDownArrow = false;
			// 
			// ViewToolStripMenuItem
			// 
			resources.ApplyResources(this.ViewToolStripMenuItem, "ViewToolStripMenuItem");
			this.ViewToolStripMenuItem.CheckOnClick = true;
			this.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
			this.ViewToolStripMenuItem.Click += new System.EventHandler(this.ViewToolStripMenuItem_Click);
			// 
			// mnuToolbar
			// 
			resources.ApplyResources(this.mnuToolbar, "mnuToolbar");
			this.mnuToolbar.Checked = true;
			this.mnuToolbar.CheckOnClick = true;
			this.mnuToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.mnuToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.mnuToolbar.Name = "mnuToolbar";
			this.mnuToolbar.Click += new System.EventHandler(this.mnuToolbar_Click);
			// 
			// arvMain
			// 
			resources.ApplyResources(this.arvMain, "arvMain");
			this.arvMain.BackColor = System.Drawing.SystemColors.Control;
			this.arvMain.CurrentPage = 0;
			this.arvMain.HyperlinkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.arvMain.HyperlinkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.arvMain.Name = "arvMain";
			this.arvMain.PagesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.arvMain.PreviewPages = 0;
			this.arvMain.SearchResultsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
			this.arvMain.SearchResultsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
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
			this.arvMain.Sidebar.SelectedIndex = 0;
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
			this.arvMain.SplitView = false;
			this.arvMain.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage;
			this.arvMain.Zoom = 1F;
			// 
			// RdfViewerForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.arvMain);
			this.Controls.Add(this.mnuMain);
			this.Name = "RdfViewerForm";
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.ToolStrip mnuMain;
		private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
		private ToolStripDropDownButton mnuView;
		private ToolStripDropDownButton mnuFile;
		private ToolStripButton mnuOpen;
		private ToolStripButton mnuExport;
		private ToolStripButton mnuPrint;
		private ToolStripSeparator toolStripSeparator;
		private ToolStripButton mnuExit;
		private ToolStripMenuItem mnuToolbar;
		private ToolStripMenuItem ViewToolStripMenuItem;
	}
		
}
