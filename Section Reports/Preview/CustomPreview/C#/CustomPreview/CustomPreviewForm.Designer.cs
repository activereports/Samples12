using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.CustomPreview
{
	public partial class CustomPreviewForm
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private System.Windows.Forms.MainMenu mnuMain;
private System.Windows.Forms.OpenFileDialog dlgOpenFile;
private System.Windows.Forms.MenuItem mnuFile;
private System.Windows.Forms.MenuItem mnuFileOpen;
private System.Windows.Forms.MenuItem mnuFileExit;
private System.Windows.Forms.MenuItem mnuReports;
private System.Windows.Forms.MenuItem mnuRCatalog;
private System.Windows.Forms.MenuItem mnuRCustomerLabels;
private System.Windows.Forms.MenuItem mnuREmployeeProfiles;
private System.Windows.Forms.MenuItem mnuRInvoice;
private System.Windows.Forms.MenuItem mnuRLetter;
private System.Windows.Forms.MenuItem mnuWindow;
private System.Windows.Forms.MenuItem mnuEmployeeSales;
private MenuItem menuSpreadBuilderitem;
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomPreviewForm));
			this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuFileOpen = new System.Windows.Forms.MenuItem();
			this.menuSpreadBuilderitem = new System.Windows.Forms.MenuItem();
			this.mnuFileExit = new System.Windows.Forms.MenuItem();
			this.mnuReports = new System.Windows.Forms.MenuItem();
			this.mnuRCatalog = new System.Windows.Forms.MenuItem();
			this.mnuRCustomerLabels = new System.Windows.Forms.MenuItem();
			this.mnuREmployeeProfiles = new System.Windows.Forms.MenuItem();
			this.mnuRInvoice = new System.Windows.Forms.MenuItem();
			this.mnuRLetter = new System.Windows.Forms.MenuItem();
			this.mnuEmployeeSales = new System.Windows.Forms.MenuItem();
			this.mnuWindow = new System.Windows.Forms.MenuItem();
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.mnuFile,
			this.mnuReports,
			this.mnuWindow});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.mnuFileOpen,
			this.menuSpreadBuilderitem,
			this.mnuFileExit});
			this.mnuFile.MergeType = System.Windows.Forms.MenuMerge.MergeItems;
			resources.ApplyResources(this.mnuFile, "mnuFile");
			// 
			// mnuFileOpen
			// 
			this.mnuFileOpen.Index = 0;
			resources.ApplyResources(this.mnuFileOpen, "mnuFileOpen");
			this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
			// 
			// menuSpreadBuilderitem
			// 
			this.menuSpreadBuilderitem.Index = 1;
			resources.ApplyResources(this.menuSpreadBuilderitem, "menuSpreadBuilderitem");
			this.menuSpreadBuilderitem.Click += new System.EventHandler(this.menuSpreadBuilderitem_Click);
			// 
			// mnuFileExit
			// 
			this.mnuFileExit.Index = 2;
			this.mnuFileExit.MergeOrder = 1;
			resources.ApplyResources(this.mnuFileExit, "mnuFileExit");
			this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
			// 
			// mnuReports
			// 
			this.mnuReports.Index = 1;
			this.mnuReports.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
			this.mnuRCatalog,
			this.mnuRCustomerLabels,
			this.mnuREmployeeProfiles,
			this.mnuRInvoice,
			this.mnuRLetter,
			this.mnuEmployeeSales});
			resources.ApplyResources(this.mnuReports, "mnuReports");
			// 
			// mnuRCatalog
			// 
			this.mnuRCatalog.Index = 0;
			resources.ApplyResources(this.mnuRCatalog, "mnuRCatalog");
			this.mnuRCatalog.Click += new System.EventHandler(this.mnuRCatalog_Click);
			// 
			// mnuRCustomerLabels
			// 
			this.mnuRCustomerLabels.Index = 1;
			resources.ApplyResources(this.mnuRCustomerLabels, "mnuRCustomerLabels");
			this.mnuRCustomerLabels.Click += new System.EventHandler(this.mnuRCustomerLabels_Click);
			// 
			// mnuREmployeeProfiles
			// 
			this.mnuREmployeeProfiles.Index = 2;
			resources.ApplyResources(this.mnuREmployeeProfiles, "mnuREmployeeProfiles");
			this.mnuREmployeeProfiles.Click += new System.EventHandler(this.mnuREmployeeProfiles_Click);
			// 
			// mnuRInvoice
			// 
			this.mnuRInvoice.Index = 3;
			resources.ApplyResources(this.mnuRInvoice, "mnuRInvoice");
			this.mnuRInvoice.Click += new System.EventHandler(this.mnuRInvoice_Click);
			// 
			// mnuRLetter
			// 
			this.mnuRLetter.Index = 4;
			resources.ApplyResources(this.mnuRLetter, "mnuRLetter");
			this.mnuRLetter.Click += new System.EventHandler(this.mnuRLetter_Click);
			// 
			// mnuEmployeeSales
			// 
			this.mnuEmployeeSales.Index = 5;
			resources.ApplyResources(this.mnuEmployeeSales, "mnuEmployeeSales");
			this.mnuEmployeeSales.Click += new System.EventHandler(this.mnuEmployeeSales_Click);
			// 
			// mnuWindow
			// 
			this.mnuWindow.Index = 2;
			this.mnuWindow.MdiList = true;
			resources.ApplyResources(this.mnuWindow, "mnuWindow");
			// 
			// CustomPreviewForm
			// 
			resources.ApplyResources(this, "$this");
			this.IsMdiContainer = true;
			this.Menu = this.mnuMain;
			this.Name = "CustomPreviewForm";
			this.ResumeLayout(false);
		}
		#endregion
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
	}
}
