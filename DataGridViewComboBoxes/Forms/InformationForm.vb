Imports DataGridViewComboBoxes.Classes.Delegates

Namespace Forms
    Public Class ChildForm
        ''' <summary>
        ''' Subscribe to event in main form for receiving information from
        ''' a DataGridView double click on a cell
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub ChildForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Dim mainForm = CType(Owner, MainForm)
            AddHandler mainForm.OnMessageInformationChanged, AddressOf MessageReceived
        End Sub
        ''' <summary>
        ''' Assign column name and value to controls.
        ''' </summary>
        ''' <param name="args">Column name of cell double click and value</param>
        Private Sub MessageReceived(args As PassingArgs)
            ColumnNameLabel.Text = args.ColumnName
            ValueTextBox.Text = args.Value
        End Sub
    End Class
End Namespace