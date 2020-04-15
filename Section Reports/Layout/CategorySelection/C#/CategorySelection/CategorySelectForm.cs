using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.CategorySelection
{	
	/// <summary>
	///
	/// This sample demonstrates ad hoc report filter by modifying the report SQL at run time.
	/// </summary>
	public partial class CategorySelectForm : System.Windows.Forms.Form
	{
		
		public CategorySelectForm()
		{
			//Required for Windows Form Designer support
			InitializeComponent();
			InitCategories();
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CategorySelectForm());
		}
		/// <summary>
		/// Get valid categories for the report from the sample database.
		/// </summary>
		private void InitCategories()
		{
			try
			{
				//Clear the category combo box of all items.//
				cbCategories.Items.Clear();
				//Populate the category combo box with the category names//				
				string cnnstring = Properties.Resources.ConnectionString;
				
				OleDbConnection cnn = new OleDbConnection(cnnstring); 
				OleDbCommand cmd = new OleDbCommand("SELECT CategoryID, CategoryName FROM Categories", cnn);
				cnn.Open();
				OleDbDataReader categoryReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
				while (categoryReader.Read())
					cbCategories.Items.Add(categoryReader.GetValue(1).ToString());
				categoryReader.Close();
				cnn.Close();
				//Set the category combo box on the first entry.
				cbCategories.SelectedIndex=0;
			}
			catch(OleDbException ex)
			{
				
				MessageBox.Show(this,"Error fired while getting categories: " + ex.Message,"Category Retrieval Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
				
			}
		}
		/// <summary>
		/// Run the report with the supplied categoryName and assign it to the viewer control.
		/// </summary>
		/// <param name="categoryName">Category to run the report with.</param>
		private void runCategoryReport(string categoryName)
		{
			try
			{
				Cursor tmp = Cursor;
				Cursor = Cursors.WaitCursor;
				CategoryProducts rpt = new CategoryProducts();
				Data.OleDBDataSource dS = new Data.OleDBDataSource();
				dS.ConnectionString = Properties.Resources.ConnectionString;
				
				string sqlString = "Select Products.ProductName, Products.UnitPrice, Products.CategoryID, Categories.CategoryName";
				sqlString += " FROM Products, Categories";
				sqlString += " WHERE Products.CategoryID = Categories.CategoryID AND Categories.CategoryName = '";
				sqlString += categoryName + "'";
				dS.SQL = sqlString;
				rpt.DataSource = dS;
			   
				arvMain.LoadDocument(rpt);
				Cursor = tmp;
			}
			catch (ReportException ex)
			{
				 
				MessageBox.Show(this,"Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				
				
			}
		}
		private void cbCategories_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			runCategoryReport(cbCategories.Text);
		}
	}
}
