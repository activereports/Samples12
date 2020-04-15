using System;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.AnnualReport
{
	/// <summary>
	/// Demonstrates subreports, nested subreports and modification of data source properties
	/// at run time, alternate row highlighting and pagebreak control.
	/// </summary>
	public partial class StartupForm : System.Windows.Forms.Form
	{
		public StartupForm()
		{
			// Required for Windows Form Designer support
			InitializeComponent();
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new StartupForm());
		}
		private void StartupForm_Load(object sender, EventArgs e)
		{
			try
			{
				// Setup a new instance of the AnnualReport.
				AnnualReport rpt = new AnnualReport();
				//Run the report, and set it to the viewer control on the Form.
				arvMain.LoadDocument(rpt);
			}
			catch (ReportException ex)
			{
				MessageBox.Show(ex.Message, Text);
			}
		}
	}
}
