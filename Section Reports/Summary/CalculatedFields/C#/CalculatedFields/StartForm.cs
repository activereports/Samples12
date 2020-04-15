using System;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.CalculatedFields
{
	/// <summary>
	/// CalculatedFields sample shows how to create a new Calculated Field in an ActiveReport and use it with the built in summary features.
	/// </summary>
	public partial class StartForm : System.Windows.Forms.Form
	{
		public StartForm()
		{
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
		/// <summary>
		/// 
		/// StartForm_Load - Creates the ActiveReport document and loads it into
		/// the viewer control.  
		/// 
		/// </summary>
		private void StartForm_Load(object sender, EventArgs e)
		{
			SectionReport rpt = new OrdersReport();
			arvMain.LoadDocument(rpt);
		}
	}
}
