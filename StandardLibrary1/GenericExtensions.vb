﻿Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Runtime.CompilerServices

Public Module GenericExtensions
    ''' <summary>
    ''' Determine if T is between lower and upper
    ''' </summary>
    ''' <typeparam name="T">Data type</typeparam>
    ''' <param name="actual">Value to determine if between lower and upper</param>
    ''' <param name="lower">Lower of range</param>
    ''' <param name="upper">Upper of range</param>
    ''' <returns>True if in range, false if not in range</returns>
    ''' <example>
    ''' <code>
    ''' var startDate = new DateTime(2018, 12, 2, 1, 12, 0);
    ''' var endDate = new DateTime(2018, 12, 15, 1, 12, 0);
    ''' var theDate = new DateTime(2018, 12, 13, 1, 12, 0);
    ''' Assert.IsTrue(theDate.Between(startDate,endDate));
    ''' </code>
    ''' </example>
    ''' <remarks>
    ''' To have upper inclusive use <= else <
    ''' </remarks>
    <Extension>
    Public Function Between(Of T As IComparable(Of T))(actual As T, lower As T, upper As T) As Boolean
        Return actual.CompareTo(lower) >= 0 AndAlso actual.CompareTo(upper) <= 0
    End Function

    <Extension>
    Public Function ToNullable(Of T As Structure)(sender As String) As T?

        Dim result As New T?()

        Try
            If Not String.IsNullOrWhiteSpace(sender) Then
                Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(T))
                result = CType(converter.ConvertFrom(sender), T)

            End If
        Catch
            ' don't care, caller should use HasValue before accessing the value.
        End Try

        Return result

    End Function
End Module

