﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------



'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Linq
Imports System.Xml.Linq
Imports System.Threading.Tasks

Namespace EnumerateFilesAsync
	Namespace My

		<System.Runtime.CompilerServices.CompilerGeneratedAttribute(), System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0"), System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
		Friend NotInheritable Partial Class Settings
			Inherits System.Configuration.ApplicationSettingsBase

			Private Shared defaultInstance As Settings = CType(System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

#Region "My.Settings Auto-Save Functionality"
#If WINDOWSFORMS Then
			Private Shared addedHandler As Boolean

			Private Shared addedHandlerLockObject As New Object()

			<System.Diagnostics.DebuggerNonUserCodeAttribute(), System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>
			Private Shared Sub AutoSaveSettings(ByVal sender As System.Object, ByVal e As System.EventArgs)
				If My.MyApplication.Application.SaveMySettingsOnExit Then
					defaultInstance.Save()
				End If
			End Sub
#End If
#End Region

			Public Shared ReadOnly Property [Default]() As Settings
				Get

#If WINDOWSFORMS Then
					   If Not addedHandler Then
							SyncLock addedHandlerLockObject
								If Not addedHandler Then
									AddHandler My.MyApplication.Application.Shutdown, AddressOf AutoSaveSettings
									addedHandler = True
								End If
							End SyncLock
					   End If
#End If
					Return defaultInstance
				End Get
			End Property
		End Class
	End Namespace

'INSTANT C# NOTE: This block was only required to support 'My.Settings' in VB. 'Properties.Settings' is used in C#:
'Namespace My
'
'	<Microsoft.VisualBasic.HideModuleNameAttribute(), System.Diagnostics.DebuggerNonUserCodeAttribute(), System.Runtime.CompilerServices.CompilerGeneratedAttribute()> Friend Module MySettingsProperty
'
'		<System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")> Friend ReadOnly Property Settings() As global::EnumerateFilesAsync.My.MySettings
'			Get
'				return global::EnumerateFilesAsync.My.MySettings.Default
'			End Get
'		End Property
'	End Module
'End Namespace

End Namespace