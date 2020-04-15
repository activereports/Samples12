using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Samples.CategorySelection
{
	public partial class CategorySelectForm
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private System.Windows.Forms.Label lblSelect;
private System.Windows.Forms.ComboBox cbCategories;
private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
private System.Windows.Forms.Panel pnlCategorySelect;
private System.ComponentModel.Container components = null;
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorySelectForm));
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.pnlCategorySelect = new System.Windows.Forms.Panel();
			this.lblSelect = new System.Windows.Forms.Label();
			this.cbCategories = new System.Windows.Forms.ComboBox();
			this.pnlCategorySelect.SuspendLayout();
			this.SuspendLayout();
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
			// pnlCategorySelect
			// 
			resources.ApplyResources(this.pnlCategorySelect, "pnlCategorySelect");
			this.pnlCategorySelect.Controls.Add(this.lblSelect);
			this.pnlCategorySelect.Controls.Add(this.cbCategories);
			this.pnlCategorySelect.Name = "pnlCategorySelect";
			// 
			// lblSelect
			// 
			resources.ApplyResources(this.lblSelect, "lblSelect");
			this.lblSelect.Name = "lblSelect";
			// 
			// cbCategories
			// 
			resources.ApplyResources(this.cbCategories, "cbCategories");
			this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCategories.Name = "cbCategories";
			this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
			// 
			// CategorySelectForm
			// 
			resources.ApplyResources(this, "$this");
			this.Controls.Add(this.arvMain);
			this.Controls.Add(this.pnlCategorySelect);
			this.Name = "CategorySelectForm";
			this.pnlCategorySelect.ResumeLayout(false);
			this.pnlCategorySelect.PerformLayout();
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
