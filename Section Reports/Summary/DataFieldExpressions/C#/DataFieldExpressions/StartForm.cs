using System;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.DataFieldExpressions
{
	/// <summary>
	/// 
	///This event is raised every time a new record is processed. The FetchData has an EOF parameter indicating whether 
	///the FetchData event should be raised. When working with bound reports (reports using a DataControl), the EOF 
	///parameter is automatically set by the report; however, when working with unbound reports this parameter needs to be 
	///controlled manually.
	/// 
	/// 
	/// </summary>
	public partial class StartForm : System.Windows.Forms.Form
	{
		public StartForm()
		{   
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
		}
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new StartForm());
		}
		private void StartForm_Load(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			DataFieldExpressionsReport rpt = new DataFieldExpressionsReport();
			arvMain.LoadDocument(rpt);
			Cursor = Cursors.Default;		
		}
	}
}
