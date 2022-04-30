Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Configuration
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x0200006F RID: 111
	<GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")>
	<CompilerGenerated()>
	<EditorBrowsable(EditorBrowsableState.Advanced)>
	Friend NotInheritable Partial Class MySettings
		Inherits ApplicationSettingsBase

		' Token: 0x06000815 RID: 2069 RVA: 0x0004654C File Offset: 0x0004474C
		<DebuggerNonUserCode()>
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Private Shared Sub AutoSaveSettings(sender As Object, e As EventArgs)
			If MyProject.Application.SaveMySettingsOnExit Then
				MySettingsProperty.Settings.Save()
			End If
		End Sub

		' Token: 0x1700027D RID: 637
		' (get) Token: 0x06000816 RID: 2070 RVA: 0x00046570 File Offset: 0x00044770
		Public Shared ReadOnly Property [Default] As MySettings
			Get
				If Not MySettings.addedHandler Then
					Dim obj As Object = MySettings.addedHandlerLockObject
					ObjectFlowControl.CheckForSyncLockOnValueType(obj)
					SyncLock obj
						If Not MySettings.addedHandler Then
							AddHandler MyProject.Application.Shutdown, AddressOf MySettings.AutoSaveSettings
							MySettings.addedHandler = True
						End If
					End SyncLock
				End If
				Return MySettings.defaultInstance
			End Get
		End Property

		' Token: 0x04000483 RID: 1155
		Private Shared defaultInstance As MySettings = CType(SettingsBase.Synchronized(New MySettings()), MySettings)

		' Token: 0x04000484 RID: 1156
		Private Shared addedHandler As Boolean

		' Token: 0x04000485 RID: 1157
		Private Shared addedHandlerLockObject As Object = RuntimeHelpers.GetObjectValue(New Object())
	End Class
End Namespace
