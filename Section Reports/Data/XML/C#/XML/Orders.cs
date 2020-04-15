namespace GrapeCity.ActiveReports.Samples.XML
{
	public partial class Orders : GrapeCity.ActiveReports.SectionReport
	{
		public Orders()
		{
			InitializeComponent();
		}
		 /// <summary>
		/// ReportStart Event
		/// Use this event to initialize any objects or variables needed while running a report. 
		/// Also use this event to set any Subreport control objects to a new instance 
		/// of the report assigned to the Subreport control.
		/// </summary>
		private void Orders_ReportStart(object sender, System.EventArgs eArgs)
		{
			srptItems.Report = new OrderItems();
		}
		/// <summary>
		/// Format Event
		/// ActiveReports event that is called for every section (Page Header/Footer,
		/// but before the section is rendered to a page.The Format event is the only event in which you can change
		///  the section's height. Use this section to set or change the properties of any controls or the section itself.
		/// Also use the Format event to pass information, such as an SQL String, to a Subreport.
		/// </summary>
		private void Detail_Format(object sender, System.EventArgs eArgs)
		{
			// Get a count of the item nodes from the datasource
			Data.XMLDataSource xmlDS = DataSource as Data.XMLDataSource;
			if (xmlDS == null)
			{
				lblItems.Text = "0";
				return;
			}
			// Get the item node list.
			System.Xml.XmlNodeList nodeList = xmlDS.Field("ITEM", true) as System.Xml.XmlNodeList;
			if (nodeList == null)
			{
				lblItems.Text = "0";
				return;
			}
			//Set the lblItems.Text to the count of Item nodes. 
			
			lblItems.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "Item Count: {0}", nodeList.Count);
			
			
		}
	}
}
