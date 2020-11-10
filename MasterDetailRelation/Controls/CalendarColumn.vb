''' <summary>
''' Provides a DataGridView column which presents date fields in a drop down
''' Calendar control. Editing capabilities are in the class CalendarEditingControl
''' within this class module.
''' </summary>
''' <remarks>
''' I believe this control came from MSDN
''' </remarks>
Public Class CalendarColumn
   Inherits DataGridViewColumn

   Public Sub New()
      MyBase.New(New CalendarCell())
   End Sub

   Public Overrides Property CellTemplate() As DataGridViewCell
      Get
         Return MyBase.CellTemplate
      End Get
        Set(value As DataGridViewCell)
            ' Ensure that the cell used for the template is a CalendarCell.
            If Not (value Is Nothing) AndAlso Not value.GetType().IsAssignableFrom(GetType(CalendarCell)) Then
                Throw New InvalidCastException("Must be a CalendarCell")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property
End Class

Public Class CalendarCell
   Inherits DataGridViewTextBoxCell

   Public Sub New()
      Me.Style.Format = "d"  ' Use the short date format.
   End Sub
    Public Overrides Sub InitializeEditingControl(rowIndex As Integer, initialFormattedValue As Object, dataGridViewCellStyle As DataGridViewCellStyle)
        ' Set the value of the editing control to the current cell value.
        MyBase.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle)

        Dim TheControl As CalendarEditingControl = CType(DataGridView.EditingControl, CalendarEditingControl)
        TheControl.Value = CType(Me.Value, DateTime)

    End Sub
    Public Overrides ReadOnly Property EditType() As Type
      Get
         ' Return the type of the editing contol that CalendarCell uses.
         Return GetType(CalendarEditingControl)
      End Get
   End Property
   Public Overrides ReadOnly Property ValueType() As Type
      Get
         ' Return the type of the value that CalendarCell contains.
         Return GetType(DateTime)
      End Get
   End Property
   Public Overrides ReadOnly Property DefaultNewRowValue() As Object
      Get
         ' Use the current date and time as the default value.
         Return DateTime.Now
      End Get
   End Property
End Class
''' <summary>
''' Provides Calendar popup within the GridView.
''' </summary>
''' <remarks></remarks>
Class CalendarEditingControl
   Inherits DateTimePicker
   Implements IDataGridViewEditingControl

   Private dataGridViewControl As DataGridView
   Private valueIsChanged As Boolean = False
   Private rowIndexNumber As Integer

   Public Sub New()
        Format = DateTimePickerFormat.Short
    End Sub
   Public Property EditingControlFormattedValue() As Object Implements IDataGridViewEditingControl.EditingControlFormattedValue
      Get
         Return Me.Value.ToShortDateString()
      End Get

      Set(ByVal value As Object)
         If TypeOf value Is [String] Then
            Me.Value = DateTime.Parse(CStr(value))
         End If
      End Set
   End Property
    Public Function GetEditingControlFormattedValue(context As DataGridViewDataErrorContexts) As Object _
       Implements IDataGridViewEditingControl.GetEditingControlFormattedValue

        Return Me.Value.ToShortDateString()
    End Function
    Public Sub ApplyCellStyleToEditingControl(dataGridViewCellStyle As DataGridViewCellStyle) Implements IDataGridViewEditingControl.ApplyCellStyleToEditingControl
        Me.Font = dataGridViewCellStyle.Font
        Me.CalendarForeColor = dataGridViewCellStyle.ForeColor
        Me.CalendarMonthBackground = dataGridViewCellStyle.BackColor
    End Sub
    Public Property EditingControlRowIndex() As Integer Implements IDataGridViewEditingControl.EditingControlRowIndex
      Get
         Return rowIndexNumber
      End Get
      Set(ByVal value As Integer)
         rowIndexNumber = value
      End Set
   End Property
    Public Function EditingControlWantsInputKey(key As Keys, dataGridViewWantsInputKey As Boolean) As Boolean Implements IDataGridViewEditingControl.EditingControlWantsInputKey
        ' Let the DateTimePicker handle the keys listed.
        Select Case key And Keys.KeyCode
            Case Keys.Left, Keys.Up, Keys.Down, Keys.Right, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Sub PrepareEditingControlForEdit(ByVal selectAll As Boolean) Implements IDataGridViewEditingControl.PrepareEditingControlForEdit
      ' No preparation needs to be done.
   End Sub
   Public ReadOnly Property RepositionEditingControlOnValueChange() As Boolean Implements IDataGridViewEditingControl.RepositionEditingControlOnValueChange
      Get
         Return False
      End Get
   End Property
   Public Property EditingControlDataGridView() As DataGridView Implements IDataGridViewEditingControl.EditingControlDataGridView
      Get
         Return dataGridViewControl
      End Get
        Set(value As DataGridView)
            dataGridViewControl = value
        End Set
    End Property
   Public Property EditingControlValueChanged() As Boolean Implements IDataGridViewEditingControl.EditingControlValueChanged
      Get
         Return valueIsChanged
      End Get
        Set(value As Boolean)
            valueIsChanged = value
        End Set
    End Property
   Public ReadOnly Property EditingControlCursor() As Cursor Implements IDataGridViewEditingControl.EditingPanelCursor
      Get
         Return MyBase.Cursor
      End Get
   End Property
   Protected Overrides Sub OnValueChanged(ByVal eventargs As EventArgs)
      ' Notify the DataGridView that the contents of the cell have changed.
      valueIsChanged = True
        EditingControlDataGridView.NotifyCurrentCellDirty(True)
        MyBase.OnValueChanged(eventargs)
   End Sub
End Class
