Module StringExtensions
    <System.Diagnostics.DebuggerStepThrough()> _
    <Runtime.CompilerServices.Extension()> _
    Public Function ProperCase(ByVal sender As String) As String
        Dim TI As System.Globalization.TextInfo = New System.Globalization.CultureInfo("en-US", False).TextInfo
        Return TI.ToTitleCase(sender.ToLower)
    End Function
    <System.Diagnostics.DebuggerStepThrough()> _
    <Runtime.CompilerServices.Extension()> _
    Public Function ProjectFolder(ByVal sender As String) As String
        Console.WriteLine("Project folder [{0}]", IO.Directory.GetParent(IO.Directory.GetParent(sender).FullName).FullName)
        Return IO.Directory.GetParent(IO.Directory.GetParent(sender).FullName).FullName
    End Function
End Module
