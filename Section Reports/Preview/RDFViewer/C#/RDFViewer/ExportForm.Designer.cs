namespace GrapeCity.ActiveReports.Samples.RdfViewer
{
	partial class ExportForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
			this.exportHeaderSplitContainer = new System.Windows.Forms.SplitContainer();
			this.lblSelectExportTxt = new System.Windows.Forms.Label();
			this.lblExport = new System.Windows.Forms.Label();
			this.exportSettingsSplitContainer = new System.Windows.Forms.SplitContainer();
			this.middleRightPanel = new System.Windows.Forms.Panel();
			this.cmbExportFormat = new System.Windows.Forms.ComboBox();
			this.middleLeftPanel = new System.Windows.Forms.Panel();
			this.lblExportFormat = new System.Windows.Forms.Label();
			this.lowerRightPanel = new System.Windows.Forms.Panel();
			this.exportPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lowerLeftPanel = new System.Windows.Forms.Panel();
			this.lblExportOptions = new System.Windows.Forms.Label();
			this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.exportHeaderSplitContainer.Panel1.SuspendLayout();
			this.exportHeaderSplitContainer.Panel2.SuspendLayout();
			this.exportHeaderSplitContainer.SuspendLayout();
			this.exportSettingsSplitContainer.Panel1.SuspendLayout();
			this.exportSettingsSplitContainer.Panel2.SuspendLayout();
			this.exportSettingsSplitContainer.SuspendLayout();
			this.middleRightPanel.SuspendLayout();
			this.middleLeftPanel.SuspendLayout();
			this.lowerRightPanel.SuspendLayout();
			this.lowerLeftPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// exportHeaderSplitContainer
			// 
			resources.ApplyResources(this.exportHeaderSplitContainer, "exportHeaderSplitContainer");
			this.exportHeaderSplitContainer.Name = "exportHeaderSplitContainer";
			// 
			// exportHeaderSplitContainer.Panel1
			// 
			this.exportHeaderSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.exportHeaderSplitContainer.Panel1.Controls.Add(this.lblSelectExportTxt);
			this.exportHeaderSplitContainer.Panel1.Controls.Add(this.lblExport);
			// 
			// exportHeaderSplitContainer.Panel2
			// 
			this.exportHeaderSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.exportHeaderSplitContainer.Panel2.Controls.Add(this.exportSettingsSplitContainer);
			// 
			// lblSelectExportTxt
			// 
			resources.ApplyResources(this.lblSelectExportTxt, "lblSelectExportTxt");
			this.lblSelectExportTxt.Name = "lblSelectExportTxt";
			// 
			// lblExport
			// 
			resources.ApplyResources(this.lblExport, "lblExport");
			this.lblExport.Name = "lblExport";
			// 
			// exportSettingsSplitContainer
			// 
			this.exportSettingsSplitContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			resources.ApplyResources(this.exportSettingsSplitContainer, "exportSettingsSplitContainer");
			this.exportSettingsSplitContainer.Name = "exportSettingsSplitContainer";
			// 
			// exportSettingsSplitContainer.Panel1
			// 
			this.exportSettingsSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.exportSettingsSplitContainer.Panel1.Controls.Add(this.middleRightPanel);
			this.exportSettingsSplitContainer.Panel1.Controls.Add(this.middleLeftPanel);
			// 
			// exportSettingsSplitContainer.Panel2
			// 
			this.exportSettingsSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.exportSettingsSplitContainer.Panel2.Controls.Add(this.lowerRightPanel);
			this.exportSettingsSplitContainer.Panel2.Controls.Add(this.lowerLeftPanel);
			// 
			// middleRightPanel
			// 
			this.middleRightPanel.Controls.Add(this.cmbExportFormat);
			resources.ApplyResources(this.middleRightPanel, "middleRightPanel");
			this.middleRightPanel.Name = "middleRightPanel";
			// 
			// cmbExportFormat
			// 
			resources.ApplyResources(this.cmbExportFormat, "cmbExportFormat");
			this.cmbExportFormat.FormattingEnabled = true;
			this.cmbExportFormat.Name = "cmbExportFormat";
			this.cmbExportFormat.SelectedIndexChanged += new System.EventHandler(this.cmbExportFormat_SelectedIndexChanged);
			// 
			// middleLeftPanel
			// 
			this.middleLeftPanel.Controls.Add(this.lblExportFormat);
			resources.ApplyResources(this.middleLeftPanel, "middleLeftPanel");
			this.middleLeftPanel.Name = "middleLeftPanel";
			// 
			// lblExportFormat
			// 
			resources.ApplyResources(this.lblExportFormat, "lblExportFormat");
			this.lblExportFormat.Name = "lblExportFormat";
			// 
			// lowerRightPanel
			// 
			this.lowerRightPanel.Controls.Add(this.exportPropertyGrid);
			this.lowerRightPanel.Controls.Add(this.btnOk);
			this.lowerRightPanel.Controls.Add(this.btnCancel);
			resources.ApplyResources(this.lowerRightPanel, "lowerRightPanel");
			this.lowerRightPanel.Name = "lowerRightPanel";
			// 
			// exportPropertyGrid
			// 
			resources.ApplyResources(this.exportPropertyGrid, "exportPropertyGrid");
			this.exportPropertyGrid.Name = "exportPropertyGrid";
			// 
			// btnOk
			// 
			resources.ApplyResources(this.btnOk, "btnOk");
			this.btnOk.Name = "btnOk";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			resources.ApplyResources(this.btnCancel, "btnCancel");
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// lowerLeftPanel
			// 
			this.lowerLeftPanel.Controls.Add(this.lblExportOptions);
			resources.ApplyResources(this.lowerLeftPanel, "lowerLeftPanel");
			this.lowerLeftPanel.Name = "lowerLeftPanel";
			// 
			// lblExportOptions
			// 
			resources.ApplyResources(this.lblExportOptions, "lblExportOptions");
			this.lblExportOptions.Name = "lblExportOptions";
			// 
			// ExportForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.exportHeaderSplitContainer);
			this.Name = "ExportForm";
			this.Load += new System.EventHandler(this.ExportForm_Load);
			this.exportHeaderSplitContainer.Panel1.ResumeLayout(false);
			this.exportHeaderSplitContainer.Panel1.PerformLayout();
			this.exportHeaderSplitContainer.Panel2.ResumeLayout(false);
			this.exportHeaderSplitContainer.ResumeLayout(false);
			this.exportSettingsSplitContainer.Panel1.ResumeLayout(false);
			this.exportSettingsSplitContainer.Panel2.ResumeLayout(false);
			this.exportSettingsSplitContainer.ResumeLayout(false);
			this.middleRightPanel.ResumeLayout(false);
			this.middleLeftPanel.ResumeLayout(false);
			this.middleLeftPanel.PerformLayout();
			this.lowerRightPanel.ResumeLayout(false);
			this.lowerLeftPanel.ResumeLayout(false);
			this.lowerLeftPanel.PerformLayout();
			this.ResumeLayout(false);
		}
		#endregion
		private System.Windows.Forms.SplitContainer exportHeaderSplitContainer;
		private System.Windows.Forms.Label lblSelectExportTxt;
		private System.Windows.Forms.Label lblExport;
		private System.Windows.Forms.SplitContainer exportSettingsSplitContainer;
		private System.Windows.Forms.ComboBox cmbExportFormat;
		private System.Windows.Forms.Label lblExportFormat;
		private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
		private System.Windows.Forms.Panel lowerRightPanel;
		private System.Windows.Forms.PropertyGrid exportPropertyGrid;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Panel lowerLeftPanel;
		private System.Windows.Forms.Label lblExportOptions;
		private System.Windows.Forms.Panel middleRightPanel;
		private System.Windows.Forms.Panel middleLeftPanel;
	}
}
