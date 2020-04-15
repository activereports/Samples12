using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Collections;
namespace GrapeCity.ActiveReports.Sample.Inheritance
{
	public partial class ViewerForm
	{
	  
		#region Windows Form Designer generated code
	   
	   
		private SplitContainer splitContainer1;
internal Button Button2;
internal Button Button1;
private GrapeCity.ActiveReports.Viewer.Win.Viewer arvMain;
private System.ComponentModel.Container components = null;
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewerForm));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button1 = new System.Windows.Forms.Button();
			this.arvMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			resources.ApplyResources(this.splitContainer1, "splitContainer1");
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.Button2);
			this.splitContainer1.Panel1.Controls.Add(this.Button1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.arvMain);
			// 
			// Button2
			// 
			resources.ApplyResources(this.Button2, "Button2");
			this.Button2.Name = "Button2";
			this.Button2.UseVisualStyleBackColor = true;
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// Button1
			// 
			resources.ApplyResources(this.Button1, "Button1");
			this.Button1.Name = "Button1";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
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
			this.Controls.Add(this.splitContainer1);
			this.Name = "ViewerForm";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
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
