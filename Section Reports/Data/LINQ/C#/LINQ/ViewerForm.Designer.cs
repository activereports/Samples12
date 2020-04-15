namespace GrapeCity.ActiveReports.Samples.LINQ
{
	partial class ViewerForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		/// <param name="disposing">If true, is not destroyed if managed resources should be discarded falseマネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		
		#region Windows Designer Generated Code
		
		
		/// <summary>
		/// Required method for Designer support. The contents of this method
		///Please do not change in the code editor. 
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
			this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.toolStripContainer.ContentPanel.SuspendLayout();
			this.toolStripContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.ContentPanel
			// 
			this.toolStripContainer.ContentPanel.Controls.Add(this.arvMain);
			resources.ApplyResources(this.toolStripContainer.ContentPanel, "toolStripContainer.ContentPanel");
			resources.ApplyResources(this.toolStripContainer, "toolStripContainer");
			this.toolStripContainer.Name = "toolStripContainer";
			// 
			// arvMain
			// 
			this.arvMain.BackColor = System.Drawing.SystemColors.Control;
			this.arvMain.CurrentPage = 0;
			resources.ApplyResources(this.arvMain, "arvMain");
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
			// ViewerForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStripContainer);
			this.Name = "ViewerForm";
			this.Load += new System.EventHandler(this.ViewerForm_Load);
			this.toolStripContainer.ContentPanel.ResumeLayout(false);
			this.toolStripContainer.ResumeLayout(false);
			this.toolStripContainer.PerformLayout();
			this.ResumeLayout(false);
		}
		#endregion
		private System.Windows.Forms.ToolStripContainer toolStripContainer;
		private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
	}
}
