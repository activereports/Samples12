namespace GrapeCity.ActiveReports.Samples.EndUserDesigner
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
			this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.pBanner = new System.Windows.Forms.Panel();
			this.lblExport = new System.Windows.Forms.Label();
			this.lblSelectExportTxt = new System.Windows.Forms.Label();
			this.lblExportFormat = new System.Windows.Forms.Label();
			this.cmbExportFormat = new System.Windows.Forms.ComboBox();
			this.lblExportOptions = new System.Windows.Forms.Label();
			this.exportPropertyGrid = new System.Windows.Forms.PropertyGrid();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.pBanner.SuspendLayout();
			this.SuspendLayout();
			// 
			// pBanner
			// 
			resources.ApplyResources(this.pBanner, "pBanner");
			this.pBanner.BackColor = System.Drawing.Color.White;
			this.pBanner.Controls.Add(this.lblExport);
			this.pBanner.Controls.Add(this.lblSelectExportTxt);
			this.pBanner.Name = "pBanner";
			// 
			// lblExport
			// 
			resources.ApplyResources(this.lblExport, "lblExport");
			this.lblExport.Name = "lblExport";
			// 
			// lblSelectExportTxt
			// 
			resources.ApplyResources(this.lblSelectExportTxt, "lblSelectExportTxt");
			this.lblSelectExportTxt.Name = "lblSelectExportTxt";
			// 
			// lblExportFormat
			// 
			resources.ApplyResources(this.lblExportFormat, "lblExportFormat");
			this.lblExportFormat.Name = "lblExportFormat";
			// 
			// cmbExportFormat
			// 
			resources.ApplyResources(this.cmbExportFormat, "cmbExportFormat");
			this.cmbExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbExportFormat.Name = "cmbExportFormat";
			this.cmbExportFormat.SelectedIndexChanged += new System.EventHandler(this.cmbExportFormat_SelectedIndexChanged);
			// 
			// lblExportOptions
			// 
			resources.ApplyResources(this.lblExportOptions, "lblExportOptions");
			this.lblExportOptions.Name = "lblExportOptions";
			// 
			// exportPropertyGrid
			// 
			resources.ApplyResources(this.exportPropertyGrid, "exportPropertyGrid");
			this.exportPropertyGrid.LineColor = System.Drawing.SystemColors.ScrollBar;
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
			// ExportForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.exportPropertyGrid);
			this.Controls.Add(this.lblExportOptions);
			this.Controls.Add(this.lblExportFormat);
			this.Controls.Add(this.cmbExportFormat);
			this.Controls.Add(this.pBanner);
			this.Name = "ExportForm";
			this.Load += new System.EventHandler(this.ExportForm_Load);
			this.pBanner.ResumeLayout(false);
			this.pBanner.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion
		private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
		private System.Windows.Forms.Panel pBanner;
		private System.Windows.Forms.Label lblExport;
		private System.Windows.Forms.Label lblSelectExportTxt;
		private System.Windows.Forms.Label lblExportFormat;
		private System.Windows.Forms.ComboBox cmbExportFormat;
		private System.Windows.Forms.Label lblExportOptions;
		private System.Windows.Forms.PropertyGrid exportPropertyGrid;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
	}
}
