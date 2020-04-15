namespace GrapeCity.ActiveReports.Sample.DigitalSignature
{
	partial class PDFDigitalSignature
	{
		private System.ComponentModel.IContainer components = null;
	  
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		#region  ActiveReports Designer generated code
		
		
	 
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDFDigitalSignature));
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.lblVisibilityType = new System.Windows.Forms.Label();
			this.cmbVisibilityType = new System.Windows.Forms.ComboBox();
			this.chkTimeStamp = new System.Windows.Forms.CheckBox();
			this.pdfExportButton = new System.Windows.Forms.Button();
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer
			// 
			resources.ApplyResources(this.splitContainer, "splitContainer");
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
			this.splitContainer.Panel1.Controls.Add(this.lblVisibilityType);
			this.splitContainer.Panel1.Controls.Add(this.cmbVisibilityType);
			this.splitContainer.Panel1.Controls.Add(this.chkTimeStamp);
			this.splitContainer.Panel1.Controls.Add(this.pdfExportButton);
			// 
			// splitContainer.Panel2
			// 
			resources.ApplyResources(this.splitContainer.Panel2, "splitContainer.Panel2");
			this.splitContainer.Panel2.Controls.Add(this.arvMain);
			// 
			// lblVisibilityType
			// 
			resources.ApplyResources(this.lblVisibilityType, "lblVisibilityType");
			this.lblVisibilityType.Name = "lblVisibilityType";
			// 
			// cmbVisibilityType
			// 
			resources.ApplyResources(this.cmbVisibilityType, "cmbVisibilityType");
			this.cmbVisibilityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbVisibilityType.FormattingEnabled = true;
			this.cmbVisibilityType.Items.AddRange(new object[] {
			resources.GetString("cmbVisibilityType.Items"),
			resources.GetString("cmbVisibilityType.Items1"),
			resources.GetString("cmbVisibilityType.Items2"),
			resources.GetString("cmbVisibilityType.Items3")});
			this.cmbVisibilityType.Name = "cmbVisibilityType";
			// 
			// chkTimeStamp
			// 
			resources.ApplyResources(this.chkTimeStamp, "chkTimeStamp");
			this.chkTimeStamp.Checked = true;
			this.chkTimeStamp.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkTimeStamp.Name = "chkTimeStamp";
			this.chkTimeStamp.UseVisualStyleBackColor = true;
			// 
			// pdfExportButton
			// 
			resources.ApplyResources(this.pdfExportButton, "pdfExportButton");
			this.pdfExportButton.Name = "pdfExportButton";
			this.pdfExportButton.UseVisualStyleBackColor = true;
			this.pdfExportButton.Click += new System.EventHandler(this.pdfExportButton_Click);
			// 
			// arvMain
			// 
			resources.ApplyResources(this.arvMain, "arvMain");
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
			// PDFDigitalSignature
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Name = "PDFDigitalSignature";
			this.Load += new System.EventHandler(this.PDFDigitalSignature_Load);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		#endregion
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label lblVisibilityType;
		private System.Windows.Forms.ComboBox cmbVisibilityType;
		private System.Windows.Forms.CheckBox chkTimeStamp;
		private System.Windows.Forms.Button pdfExportButton;
		private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
	}
}
