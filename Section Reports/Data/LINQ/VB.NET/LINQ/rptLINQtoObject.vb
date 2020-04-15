Public Class rptLINQtoObject
	Structure Person
		Public id As Integer
		Public name As String
		Public age As Integer
		Public city As String
	End Structure
	Private Sub rptLINQtoObject_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
		' To run the report.
		Dim People As List(Of Person) = New List(Of Person)
		
		People.Add(New Person With {.id = 1, .name = "Jon Doe", .age = 25, .city = "New York"})	 
		'
		
		People.Add(New Person With {.id = 2, .name = "Jane Doe", .age = 21, .city = "New York"})	 
		'
		
		People.Add(New Person With {.id = 3, .name = "Robby", .age = 29, .city = "Boston"})	 
		'
		
		People.Add(New Person With {.id = 4, .name = "Mike", .age = 30, .city = "Denver"})	 
		'
		
		People.Add(New Person With {.id = 5, .name = "Lily", .age = 35, .city = "Denver"})	 
		'
		
		People.Add(New Person With {.id = 6, .name = "Martha", .age = 55, .city = "Washington"})	 
		'
		
		People.Add(New Person With {.id = 7, .name = "Harry", .age = 22, .city = "Washington"})	 
		'
		
		People.Add(New Person With {.id = 8, .name = "Marshall", .age = 29, .city = "Chicago"})	 
		'
		
		People.Add(New Person With {.id = 9, .name = "Temperance", .age = 32, .city = "Chicago"})	 
		'
		
		People.Add(New Person With {.id = 10, .name = "Joseph", .age = 32, .city = "Austin"})	 
		'
		' To create a query. To sort in descending order of Age.
		Dim data = From p In People _
				   Order By p.age Descending _
				   Select ID = p.id, _
						  Name = p.name, _
						  Age = p.age, _
						  City = p.city
		' To combine the data source in the report.
		Me.DataSource = data.ToList()
	End Sub
End Class
