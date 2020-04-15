Imports System.Data.OleDb
Public Class CategorySelectForm
	Inherits System.Windows.Forms.Form
	Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		InitCategories()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If Not (components Is Nothing) Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	'Required by the Windows Form Designer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	'Get valid categories for the report from the sample database.
	Private Sub InitCategories()
		Try
			'Clear the category combo box of all items.
			cbCategories.Items.Clear()
			'Populate the category combo box with the category names
			Dim cnnstring As String = My.Resources.ConnectionString
			Dim cnn As New OleDbConnection(cnnstring)
			Dim cmd As New OleDbCommand("SELECT CategoryID, CategoryName FROM Categories", cnn)
			cnn.Open()
			Dim categoryReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
			While categoryReader.Read()
				cbCategories.Items.Add(categoryReader.GetValue(1).ToString())
			End While
			categoryReader.Close()
			cnn.Close()
			'Set the category combo box on the first entry.
			cbCategories.SelectedIndex = 0
		Catch ex As OleDbException
			
			MessageBox.Show(Me, "Error fired while getting categories: " + ex.Message, "Category Retrieval Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			
			'
		End Try
	End Sub
	' Run the report with the supplied categoryName and assign it to the viewer control.
	' Parameter Name: categoryName - Category to run the report with.
	Private Sub runCategoryReport(ByVal categoryName As String)
		Try
			Dim tmp As Cursor
			tmp = Cursor
			Cursor = Cursors.WaitCursor
			Dim rpt As New CategoryProducts()
			Dim ds As New Data.OleDBDataSource()
			ds.ConnectionString = My.Resources.ConnectionString
			Dim sqlString As String = "Select Products.ProductName, Products.UnitPrice, Products.CategoryID, Categories.CategoryName"
			sqlString = sqlString + " FROM Products, Categories"
			sqlString = sqlString + " WHERE Products.CategoryID = Categories.CategoryID AND Categories.CategoryName = '"
			sqlString = sqlString + categoryName + "'"
			ds.SQL = sqlString
			rpt.DataSource = ds
			arvMain.LoadDocument(rpt)
			Cursor = tmp
		Catch ex As ReportException
			
			MessageBox.Show(Me, "Error fired while running the report: " + ex.Message, "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			
			'
		End Try
	End Sub
	Private Sub cbCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategories.SelectedIndexChanged
		runCategoryReport(cbCategories.Text)
	End Sub
End Class
