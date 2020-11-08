Namespace Modules
    Public Module CategoryItemExtensions
        ''' <summary>
        ''' Get category by category identifier
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="categoryIdentifier">Valid category identifier</param>
        ''' <returns>A Category</returns>
        ''' <remarks>
        ''' Assumes the category exists, they are never removed possible the category name may change
        ''' </remarks>
        <Runtime.CompilerServices.Extension()>
        Public Function GetCurrentCategory(sender As ComboBox, categoryIdentifier As Integer) As Category
            Return CType(sender.DataSource, List(Of Category)).FirstOrDefault(Function(category) category.CategoryID = categoryIdentifier)
        End Function
    End Module
End Namespace