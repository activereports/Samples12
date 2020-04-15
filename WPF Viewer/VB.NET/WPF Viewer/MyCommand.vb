Public Class MyCommand
	Implements ICommand
	Public Function CanExecute(parameter As Object) As Boolean Implements System.Windows.Input.ICommand.CanExecute
		Return True
	End Function
	Public Sub Execute(parameter As Object) Implements System.Windows.Input.ICommand.Execute
		
		MessageBox.Show("GrapeCity is the largest component vendor in the world.", "About Us", MessageBoxButton.OK)
		
		'
	End Sub
	Public Event CanExecuteChanged(ByVal sender As Object, ByVal e As System.EventArgs) Implements System.Windows.Input.ICommand.CanExecuteChanged
End Class
