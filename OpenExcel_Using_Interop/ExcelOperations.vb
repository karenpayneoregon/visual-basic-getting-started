Option Strict On
Option Infer On
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Public Class ExcelOperations

    Public Function GetSheets(fileName As String) As List(Of String)

        Dim sheetNames As New List(Of String)
        Dim success As Boolean = True

        If Not IO.File.Exists(fileName) Then
            Dim ex As New Exception("Failed to locate '" & fileName & "'")
            Throw ex
        End If

        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBooks As Excel.Workbooks = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlActiveRanges As Excel.Workbook = Nothing
        Dim xlNames As Excel.Names = Nothing
        Dim xlWorkSheets As Excel.Sheets = Nothing

        Try

            xlApp = New Excel.Application
            xlApp.DisplayAlerts = False
            xlWorkBooks = xlApp.Workbooks
            xlWorkBook = xlWorkBooks.Open(fileName)

            xlActiveRanges = xlApp.ActiveWorkbook
            xlNames = xlActiveRanges.Names

            xlWorkSheets = xlWorkBook.Sheets

            For index As Integer = 1 To xlWorkSheets.Count

                Dim currentSheet As Excel.Worksheet = CType(xlWorkSheets(index), Excel.Worksheet)
                sheetNames.Add(currentSheet.Name)
                Marshal.FinalReleaseComObject(currentSheet)
                currentSheet = Nothing

            Next

            xlWorkBook.Close()
            xlApp.UserControl = True
            xlApp.Quit()

        Catch ex As Exception
            success = False
        Finally

            If Not xlWorkSheets Is Nothing Then
                Marshal.FinalReleaseComObject(xlWorkSheets)
                xlWorkSheets = Nothing
            End If

            If Not xlNames Is Nothing Then
                Marshal.FinalReleaseComObject(xlNames)
                xlNames = Nothing
            End If

            If Not xlActiveRanges Is Nothing Then
                Marshal.FinalReleaseComObject(xlActiveRanges)
                xlActiveRanges = Nothing
            End If
            If Not xlActiveRanges Is Nothing Then
                Marshal.FinalReleaseComObject(xlActiveRanges)
                xlActiveRanges = Nothing
            End If

            If Not xlWorkBook Is Nothing Then
                Marshal.FinalReleaseComObject(xlWorkBook)
                xlWorkBook = Nothing
            End If

            If Not xlWorkBooks Is Nothing Then
                Marshal.FinalReleaseComObject(xlWorkBooks)
                xlWorkBooks = Nothing
            End If

            If Not xlApp Is Nothing Then
                Marshal.FinalReleaseComObject(xlApp)
                xlApp = Nothing
            End If
        End Try

        Return sheetNames

    End Function

End Class