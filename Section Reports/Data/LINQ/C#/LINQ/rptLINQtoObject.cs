using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace GrapeCity.ActiveReports.Samples.LINQ
{
	/// <summary>
	/// A description of the overview of the rptLINQtoObject.
	/// </summary>
	public partial class rptLINQtoObject : GrapeCity.ActiveReports.SectionReport
	{
		public rptLINQtoObject()
		{
			//
			// Designer support is required to ActiveReport.
			//
			InitializeComponent();
		}
		struct Person
		{
			public int id;
			public string name;
			public int age;
			public string city;
		}
		private void rptLINQtoObject_ReportStart(object sender, System.EventArgs e)
		{
			// To run the report.
			List<Person> People = new List<Person>{
				
			
			 new Person{id = 1, name = "Jon Doe", age = 25, city = "New York"},
			
			//
			
			 new Person{id = 2, name = "Jane Doe", age = 21, city = "New York"},
			
			//
			
			 new Person{id = 3, name = "Robby", age = 29, city = "Boston"},
			
			//
			   
			
			 new Person{id = 4, name = "Mike", age = 30, city = "Denver"},
			
			//
			
			 new Person{id = 5, name = "Lily", age = 35, city = "Denver"},
			
			//
			
			 new Person{id = 6, name = "Martha", age = 55, city = "Washington"},
			
			//
			
			 new Person{id = 7, name = "Harry", age = 22, city = "Washington"},
			
			//
				
			
			 new Person{id = 8, name = "Marshall", age = 29, city = "Chicago"},
			
			//
				
			
			 new Person{id = 9, name = "Temprence", age = 32, city = "Chicago"},
			
			//
		 
			
			 new Person{id = 10, name = "Joseph", age = 42, city = "Austin"},
			
			//
			};
			// To create a query. To sort in descending order of Age.
			var data = from p in People
					   orderby p.age descending
					   select new
					   {
						   ID = p.id,
						   Name = p.name,
						   Age = p.age,
						   City = p.city
					   };
			// To combine the data source in the report.
			this.DataSource = data.ToList();
		}
	}
}
