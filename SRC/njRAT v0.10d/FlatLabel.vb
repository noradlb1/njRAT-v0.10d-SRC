Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace NJRAT
	' Token: 0x02000043 RID: 67
	Friend Class FlatLabel
		Inherits Label

		' Token: 0x06000713 RID: 1811 RVA: 0x00039158 File Offset: 0x00037358
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatLabel.__ENCList
			SyncLock _ENCList
				If FlatLabel.__ENCList.Count = FlatLabel.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatLabel.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatLabel.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatLabel.__ENCList(num) = FlatLabel.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatLabel.__ENCList.RemoveRange(num, FlatLabel.__ENCList.Count - num)
					FlatLabel.__ENCList.Capacity = FlatLabel.__ENCList.Count
				End If
				FlatLabel.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000714 RID: 1812 RVA: 0x00003B94 File Offset: 0x00001D94
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x06000715 RID: 1813 RVA: 0x00039240 File Offset: 0x00037440
		Public Sub New()
			FlatLabel.__ENCAddToList(Me)
			Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
			Me.Font = New Font("Segoe UI", 8F)
			Me.ForeColor = Color.White
			Me.BackColor = Color.Transparent
			Me.Text = Me.Text
		End Sub

		' Token: 0x04000373 RID: 883
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()
	End Class
End Namespace
