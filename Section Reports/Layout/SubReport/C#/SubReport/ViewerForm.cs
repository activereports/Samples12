using System;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
namespace GrapeCity.ActiveReports.Samples.SubReport
{
	/// <summary>
	/// A description of the overview of the ViewerForm.
	/// 
	/// </summary>
	public partial class ViewerForm : System.Windows.Forms.Form
	{
	   
		public ViewerForm()
		{
			//
			//Required for Windows Form Designer support.
			// 
			//
			InitializeComponent();
			//
			//TODO: after the call to InitializeComponent, please add the constructor code.
			// 
			//
		}
		/// <summary>
		/// The main entry point for the application.
		/// 
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ViewerForm());
		}
		private void ViewerForm_Load(object sender, EventArgs e)
		{
			
			cboReport.Items.Add("Select a Sample Report from DropDown List");
			cboReport.Items.Add("Simple SubReport");
			cboReport.Items.Add("Nested SubReport");
			cboReport.Items.Add("Hierarchical SubReport");
			cboReport.Items.Add("SubReport using the data set that contains relationship");
			cboReport.Items.Add("Master-detail report containing a SubReport");
			cboReport.Items.Add("Bookmark in SubReport");
			cboReport.Items.Add("Use a parameter in the SubReport");
			cboReport.Items.Add("To view the DataSet with multiple tables using SubReports");
			
			
			cboReport.SelectedIndex = 0;
		   
		}
	   
		private void cboReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				// Change the cursor
				//
				Cursor = Cursors.WaitCursor;
				Application.DoEvents();
				switch (((ComboBox)sender).SelectedIndex)
				{
					case 1: // Simple sub-report 
						RunReport_Simple();
						break;
					case 2: // Nested sub-reports 
						RunReport_Nested();
						break;
					case 3: // Hierarchical structure of sub-reports 
						RunReport_Hierarchical();
						break;
					case 4: // Sub report using the data set that contains the relationship 
						RunReport_DSRelations();
						break;
					case 5: // Master-detail report containing a subreport 
						RunReport_MasterSubreport();
						break;
					case 6: // Bookmark in sub-report 
						RunReport_Bookmark();
						break;
					case 7: // Use a parameter in the subreport 
						RunReport_Parameter();
						break;
					case 8: // To view the DataSet with multiple tables using sub-reports 
						RunReport_UnboundDataSet();
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				//Cursor back to the original
				//
				Cursor = Cursors.Default;
				Application.DoEvents();
			}
		}
		private void RunReport_Simple()
		{
			// ***** Simple sub-report *****
			//
			rptSimpleMain rpt = new rptSimpleMain();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_Nested()
		{
			// ***** Nested sub-reports *****
			//
			rptNestedParent rpt = new rptNestedParent();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_Hierarchical()
		{
			// *****Hierarchical structure of sub-reports *****
			//
			rptHierarchicalMain rpt = new rptHierarchicalMain();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_DSRelations()
		{
			// ***** Sub report using the data set that contains the relationship *****
			//
			DataSet myJoinedDS = new DataSet();
			rptDSRelationParent rpt = new rptDSRelationParent();
			string cnnString = Properties.Resources.ConnectionString;
			OleDbConnection cnn = new OleDbConnection(cnnString);
			cnn.Open();
			OleDbDataAdapter catAd = new OleDbDataAdapter("Select * from categories order by categoryname", cnn);
			OleDbDataAdapter prodAd = new OleDbDataAdapter("Select * from products order by productname", cnn);
			OleDbDataAdapter ODAd = new OleDbDataAdapter("Select * from [order details]", cnn);
			//Add three DataTables in the DataSet (myJoinedDS)
			//
			catAd.Fill(myJoinedDS, "Categories");
			prodAd.Fill(myJoinedDS, "Products");
			ODAd.Fill(myJoinedDS, "OrderDetails");
			cnn.Close();
			//Sets the parent-child relationship between DataTable.
			//
			myJoinedDS.Relations.Add("CategoriesProducts", myJoinedDS.Tables["Categories"].Columns["CategoryID"], myJoinedDS.Tables["Products"].Columns["CategoryID"]);
			myJoinedDS.Relations.Add("ProductsOrderDetails", myJoinedDS.Tables["Products"].Columns["ProductID"], myJoinedDS.Tables["OrderDetails"].Columns["ProductID"]);
			rpt.DataSource = (myJoinedDS);
			rpt.DataMember = "Categories";
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_MasterSubreport()
		{
			// ***** Master-detail report contains a subreport *****
			//
			rptMasterMain rpt = new rptMasterMain();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_Bookmark()
		{
			// ***** Bookmark in sub-report *****
			//
			rptBookmarkMain rpt = new rptBookmarkMain();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_Parameter()
		{
			// ***** Use a parameter in the subreport *****
			//
			rptParamMain rpt = new rptParamMain();
			arvMain.LoadDocument(rpt);
		}
		private void RunReport_UnboundDataSet()
		{
			// ***** To view the DataSet with multiple tables using sub-reports *****
			//
			// To generate dataset using "Customers" and "Orders" tables.
			//
			OleDbConnection nwindConn = new OleDbConnection(Properties.Resources.ConnectionString);
			OleDbCommand selectCMD = new OleDbCommand("SELECT * FROM Customers", nwindConn);
			selectCMD.CommandTimeout = 30;
			OleDbCommand selectCMD2 = new OleDbCommand("SELECT * FROM Orders", nwindConn);
			selectCMD2.CommandTimeout = 30;
			OleDbDataAdapter custDA = new OleDbDataAdapter();
			custDA.SelectCommand = selectCMD;
			OleDbDataAdapter ordersDA = new OleDbDataAdapter();
			ordersDA.SelectCommand = selectCMD2;
			DataSet DS = new DataSet();
			custDA.Fill(DS, "Customers");
			ordersDA.Fill(DS, "Orders");
			nwindConn.Close();
			rptUnboundDSMain rpt = new rptUnboundDSMain();
			rpt.DataSource = DS;
			rpt.DataMember = "Customers";
			arvMain.LoadDocument(rpt);
		}	   
	}
}
