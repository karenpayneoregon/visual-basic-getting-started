''' <summary>
''' Our connection string to the backend MS-Access database is hard-coded for this demo.
''' My method is to store the connection string in a configuration file.
''' </summary>
''' <remarks></remarks>
Module ConnectionStringSetting
    Public Builder As New OleDb.OleDbConnectionStringBuilder With
        {
            .DataSource = IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "Database1.accdb"),
            .Provider = "Microsoft.ACE.OLEDB.12.0"
        }

End Module
