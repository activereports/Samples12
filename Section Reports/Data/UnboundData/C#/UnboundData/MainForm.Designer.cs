using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.UnboundData
{
	public partial class MainForm
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private System.Windows.Forms.Panel pnlOptions;
private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
private System.Windows.Forms.TabControl tabDataBinding;
private System.Windows.Forms.TabPage tabDataSet;
private System.Windows.Forms.TabPage tabDataReader;
private System.Windows.Forms.Button btnDataSet;
private System.Windows.Forms.Label lblDataSet;
private System.Windows.Forms.Label lblDataReader;
private System.Windows.Forms.Button btnDataReader;
private System.Windows.Forms.TabPage tabTextFile;
private System.Windows.Forms.Button btnTextFile;
private System.Windows.Forms.TabPage tabArray;
private System.Windows.Forms.Button btnArray;
private System.Windows.Forms.Label lblTextFile;
private System.Windows.Forms.Label lblArray;
private System.ComponentModel.Container components = null;
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlOptions = new System.Windows.Forms.Panel();
			this.tabDataBinding = new System.Windows.Forms.TabControl();
			this.tabDataSet = new System.Windows.Forms.TabPage();
			this.lblDataSet = new System.Windows.Forms.Label();
			this.btnDataSet = new System.Windows.Forms.Button();
			this.tabDataReader = new System.Windows.Forms.TabPage();
			this.btnDataReader = new System.Windows.Forms.Button();
			this.lblDataReader = new System.Windows.Forms.Label();
			this.tabTextFile = new System.Windows.Forms.TabPage();
			this.lblTextFile = new System.Windows.Forms.Label();
			this.btnTextFile = new System.Windows.Forms.Button();
			this.tabArray = new System.Windows.Forms.TabPage();
			this.lblArray = new System.Windows.Forms.Label();
			this.btnArray = new System.Windows.Forms.Button();
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.pnlOptions.SuspendLayout();
			this.tabDataBinding.SuspendLayout();
			this.tabDataSet.SuspendLayout();
			this.tabDataReader.SuspendLayout();
			this.tabTextFile.SuspendLayout();
			this.tabArray.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlOptions
			// 
			resources.ApplyResources(this.pnlOptions, "pnlOptions");
			this.pnlOptions.Controls.Add(this.tabDataBinding);
			this.pnlOptions.Name = "pnlOptions";
			// 
			// tabDataBinding
			// 
			resources.ApplyResources(this.tabDataBinding, "tabDataBinding");
			this.tabDataBinding.Controls.Add(this.tabDataSet);
			this.tabDataBinding.Controls.Add(this.tabDataReader);
			this.tabDataBinding.Controls.Add(this.tabTextFile);
			this.tabDataBinding.Controls.Add(this.tabArray);
			this.tabDataBinding.Name = "tabDataBinding";
			this.tabDataBinding.SelectedIndex = 0;
			this.tabDataBinding.SelectedIndexChanged += new System.EventHandler(this.tabDataBinding_SelectedIndexChanged);
			// 
			// tabDataSet
			// 
			resources.ApplyResources(this.tabDataSet, "tabDataSet");
			this.tabDataSet.Controls.Add(this.lblDataSet);
			this.tabDataSet.Controls.Add(this.btnDataSet);
			this.tabDataSet.Name = "tabDataSet";
			// 
			// lblDataSet
			// 
			resources.ApplyResources(this.lblDataSet, "lblDataSet");
			this.lblDataSet.Name = "lblDataSet";
			// 
			// btnDataSet
			// 
			resources.ApplyResources(this.btnDataSet, "btnDataSet");
			this.btnDataSet.Name = "btnDataSet";
			this.btnDataSet.Click += new System.EventHandler(this.btnDataSet_Click);
			// 
			// tabDataReader
			// 
			resources.ApplyResources(this.tabDataReader, "tabDataReader");
			this.tabDataReader.Controls.Add(this.btnDataReader);
			this.tabDataReader.Controls.Add(this.lblDataReader);
			this.tabDataReader.Name = "tabDataReader";
			// 
			// btnDataReader
			// 
			resources.ApplyResources(this.btnDataReader, "btnDataReader");
			this.btnDataReader.Name = "btnDataReader";
			this.btnDataReader.Click += new System.EventHandler(this.btnDataReader_Click);
			// 
			// lblDataReader
			// 
			resources.ApplyResources(this.lblDataReader, "lblDataReader");
			this.lblDataReader.Name = "lblDataReader";
			// 
			// tabTextFile
			// 
			resources.ApplyResources(this.tabTextFile, "tabTextFile");
			this.tabTextFile.Controls.Add(this.lblTextFile);
			this.tabTextFile.Controls.Add(this.btnTextFile);
			this.tabTextFile.Name = "tabTextFile";
			// 
			// lblTextFile
			// 
			resources.ApplyResources(this.lblTextFile, "lblTextFile");
			this.lblTextFile.Name = "lblTextFile";
			// 
			// btnTextFile
			// 
			resources.ApplyResources(this.btnTextFile, "btnTextFile");
			this.btnTextFile.Name = "btnTextFile";
			this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
			// 
			// tabArray
			// 
			resources.ApplyResources(this.tabArray, "tabArray");
			this.tabArray.Controls.Add(this.lblArray);
			this.tabArray.Controls.Add(this.btnArray);
			this.tabArray.Name = "tabArray";
			// 
			// lblArray
			// 
			resources.ApplyResources(this.lblArray, "lblArray");
			this.lblArray.Name = "lblArray";
			// 
			// btnArray
			// 
			resources.ApplyResources(this.btnArray, "btnArray");
			this.btnArray.Name = "btnArray";
			this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
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
			// MainForm
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.arvMain);
			this.Controls.Add(this.pnlOptions);
			this.Name = "MainForm";
			this.pnlOptions.ResumeLayout(false);
			this.tabDataBinding.ResumeLayout(false);
			this.tabDataSet.ResumeLayout(false);
			this.tabDataReader.ResumeLayout(false);
			this.tabTextFile.ResumeLayout(false);
			this.tabArray.ResumeLayout(false);
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
