Namespace Classes
    Public Module ControlExtensions
        <Runtime.CompilerServices.Extension>
        Public Iterator Function Descendants(Of T As Class)(control As Control) As IEnumerable(Of T)
            For Each child As Control In control.Controls

                Dim currentChild = TryCast(child, T)
                If currentChild IsNot Nothing Then
                    Yield currentChild
                End If

                If child.HasChildren Then
                    For Each descendant As T In child.Descendants(Of T)()
                        Yield descendant
                    Next
                End If
            Next

        End Function
        <Runtime.CompilerServices.Extension>
        Public Function NumericTextBoxList(pControl As Control) As List(Of NumericTextBox)
            Return pControl.Descendants(Of NumericTextBox)().ToList()
        End Function

        ''' <summary>
        ''' Get names of controls 
        ''' </summary>
        ''' <param name="pControls"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function ControlNames(pControls As IEnumerable(Of Control)) As String()
            Return pControls.Select(Function(c) c.Name).ToArray()
        End Function

    End Module
End Namespace