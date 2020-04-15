using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.CustomDataProviderUITest
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new GrapeCity.ActiveReports.Samples.CustomDataProviderUITest.DesignerForm());
		}
	}
}
