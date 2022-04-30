Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000063 RID: 99
	Public NotInheritable Class L1
		Inherits DataGridView

		' Token: 0x060007AE RID: 1966 RVA: 0x00044444 File Offset: 0x00042644
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = L1.__ENCList
			SyncLock _ENCList
				If L1.__ENCList.Count = L1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = L1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = L1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								L1.__ENCList(num) = L1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					L1.__ENCList.RemoveRange(num, L1.__ENCList.Count - num)
					L1.__ENCList.Capacity = L1.__ENCList.Count
				End If
				L1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060007AF RID: 1967 RVA: 0x0004452C File Offset: 0x0004272C
		Public Sub New()
			L1.__ENCAddToList(Me)
			Me.collection_0 = New Collection()
			Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect
			Me.DefaultCellStyle.WrapMode = DataGridViewTriState.[False]
			Me.RowHeadersVisible = False
			Me.DoubleBuffered = True
			Me.ShowCellErrors = True
			Me.ShowEditingIcon = True
			Me.ShowRowErrors = True
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.EnableNotifyMessage Or ControlStyles.OptimizedDoubleBuffer, True)
		End Sub

		' Token: 0x060007B0 RID: 1968 RVA: 0x000445B0 File Offset: 0x000427B0
		Public Function method_0(int_0 As Integer) As DataGridViewRow
			Return CType(Me.collection_0(int_0 + 1), DataGridViewRow)
		End Function

		' Token: 0x060007B1 RID: 1969 RVA: 0x000445D4 File Offset: 0x000427D4
		Public Function method_1(string_0 As String) As DataGridViewRow
			Return CType(Me.collection_0(string_0), DataGridViewRow)
		End Function

		' Token: 0x060007B2 RID: 1970 RVA: 0x000445F4 File Offset: 0x000427F4
		Public Sub method_10(int_0 As Integer)
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_10, New Object() { int_0 })
					Return
				End SyncLock
			End If
			Me.Rows.RemoveAt(int_0)
		End Sub

		' Token: 0x060007B3 RID: 1971 RVA: 0x00044664 File Offset: 0x00042864
		Public Sub method_11(string_0 As String, genum0_0 As L1.GEnum0, dataGridViewAutoSizeColumnMode_0 As DataGridViewAutoSizeColumnMode)
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Dim dataGridViewColumn As DataGridViewColumn = Nothing
				Select Case genum0_0
					Case L1.GEnum0.Text
						dataGridViewColumn = New DataGridViewTextBoxColumn()
					Case L1.GEnum0.Link
						dataGridViewColumn = New DataGridViewLinkColumn()
					Case L1.GEnum0.Image
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewColumn = dataGridViewImageColumn
					Case L1.GEnum0.StretchImage
						Dim dataGridViewImageColumn As DataGridViewImageColumn = New DataGridViewImageColumn() With { .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewColumn = dataGridViewImageColumn
				End Select
				dataGridViewColumn.AutoSizeMode = dataGridViewAutoSizeColumnMode_0
				dataGridViewColumn.Tag = genum0_0
				dataGridViewColumn.HeaderText = string_0
				Me.Columns.Add(dataGridViewColumn)
			End SyncLock
		End Sub

		' Token: 0x060007B4 RID: 1972 RVA: 0x00044718 File Offset: 0x00042918
		Public Function method_2(string_0 As String) As Boolean
			Return Me.collection_0.Contains(string_0)
		End Function

		' Token: 0x060007B5 RID: 1973 RVA: 0x00044734 File Offset: 0x00042934
		Public Function method_3() As DataGridViewRow()
			Dim list As List(Of DataGridViewRow) = New List(Of DataGridViewRow)()
			Dim result As DataGridViewRow()
			If Me.RowCount = 0 Then
				result = list.ToArray()
			Else
				Try
					Dim num As Integer = Me.FirstDisplayedScrollingRowIndex + Me.DisplayedRowCount(False)
					For i As Integer = Me.FirstDisplayedScrollingRowIndex To num
						If i > Me.RowCount - 1 Then
							Exit For
						End If
						Try
							list.Add(Me.Rows(i))
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End If
			Return result
		End Function

		' Token: 0x060007B6 RID: 1974 RVA: 0x00044804 File Offset: 0x00042A04
		Public Sub method_4()
			Dim collection As Collection = Me.collection_0
			Dim obj As Collection = collection
			SyncLock obj
				Me.Rows.Clear()
				Me.collection_0.Clear()
			End SyncLock
		End Sub

		' Token: 0x060007B7 RID: 1975 RVA: 0x00044850 File Offset: 0x00042A50
		Public Function method_5(object_0 As Object()) As DataGridViewRow
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_5, object_0), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow()
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Normal }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, Nothing, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060007B8 RID: 1976 RVA: 0x00044A18 File Offset: 0x00042C18
		Public Function method_6() As Integer
			Return Me.RowTemplate.Height
		End Function

		' Token: 0x060007B9 RID: 1977 RVA: 0x00003D14 File Offset: 0x00001F14
		Public Sub method_7(int_0 As Integer)
			Me.RowTemplate.Height = int_0
		End Sub

		' Token: 0x060007BA RID: 1978 RVA: 0x00044A34 File Offset: 0x00042C34
		Public Function method_8(string_0 As String, object_0 As Object()) As DataGridViewRow
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Return CType(Me.Invoke(AddressOf Me.method_8, New Object() { string_0, object_0 }), DataGridViewRow)
				End SyncLock
			End If
			Dim dataGridViewRow As DataGridViewRow = New DataGridViewRow() With { .Height = Me.method_6() }
			Dim num As Integer = Me.ColumnCount - 1
			For i As Integer = 0 To num
				Select Case Conversions.ToInteger(RuntimeHelpers.GetObjectValue(Me.Columns(i).Tag))
					Case 0
						Dim dataGridViewCell As DataGridViewTextBoxCell = New DataGridViewTextBoxCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell)
					Case 1
						Dim dataGridViewCell2 As DataGridViewLinkCell = New DataGridViewLinkCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))) }
						dataGridViewRow.Cells.Add(dataGridViewCell2)
					Case 2
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Zoom }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
					Case 3
						Dim dataGridViewCell3 As DataGridViewImageCell = New DataGridViewImageCell() With { .Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(object_0(i)))), .ImageLayout = DataGridViewImageCellLayout.Stretch }
						dataGridViewRow.Cells.Add(dataGridViewCell3)
				End Select
			Next
			dataGridViewRow.Resizable = DataGridViewTriState.[False]
			Me.collection_0.Add(dataGridViewRow, string_0, Nothing, Nothing)
			Me.Rows.Add(dataGridViewRow)
			Return dataGridViewRow
		End Function

		' Token: 0x060007BB RID: 1979 RVA: 0x00044C20 File Offset: 0x00042E20
		Public Sub method_9(dataGridViewRow_0 As DataGridViewRow)
			If Me.InvokeRequired Then
				Dim collection As Collection = Me.collection_0
				Dim obj As Collection = collection
				SyncLock obj
					Me.Invoke(AddressOf Me.method_9, New Object() { dataGridViewRow_0 })
					Return
				End SyncLock
			End If
			Me.Rows.Remove(dataGridViewRow_0)
		End Sub

		' Token: 0x060007BC RID: 1980 RVA: 0x00044C8C File Offset: 0x00042E8C
		Protected Overrides Sub OnMouseUp(mouseEventArgs_0 As MouseEventArgs)
			If mouseEventArgs_0.Button = MouseButtons.Right Then
				Try
					Dim hitTestInfo As DataGridView.HitTestInfo = Me.HitTest(mouseEventArgs_0.X, mouseEventArgs_0.Y)
					If hitTestInfo.RowIndex <> -1 Then
						Dim dataGridViewRow As DataGridViewRow = Me.Rows(hitTestInfo.RowIndex)
						If Not dataGridViewRow.Selected Then
							Me.ClearSelection()
							dataGridViewRow.Selected = True
						End If
					End If
				Catch ex As Exception
				End Try
			End If
			MyBase.OnMouseUp(mouseEventArgs_0)
		End Sub

		' Token: 0x060007BD RID: 1981 RVA: 0x00044D28 File Offset: 0x00042F28
		Protected Overrides Sub OnMouseWheel(mouseEventArgs_0 As MouseEventArgs)
			MyBase.OnMouseWheel(mouseEventArgs_0)
			Try
				Dim delta As Integer = mouseEventArgs_0.Delta
				If delta = 120 Then
					Me.FirstDisplayedScrollingRowIndex = Math.Max(0, Me.FirstDisplayedScrollingRowIndex - SystemInformation.MouseWheelScrollLines)
				ElseIf delta = -120 Then
					Me.FirstDisplayedScrollingRowIndex += SystemInformation.MouseWheelScrollLines
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060007BE RID: 1982 RVA: 0x00044DA8 File Offset: 0x00042FA8
		Protected Overrides Sub OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0 As DataGridViewRowPostPaintEventArgs)
			Try
				Dim dataGridViewRow As DataGridViewRow = Me.Rows(dataGridViewRowPostPaintEventArgs_0.RowIndex)
				If dataGridViewRow.Height <> Me.method_6() Then
					dataGridViewRow.Height = Me.method_6()
				End If
			Catch ex As Exception
			End Try
			MyBase.OnRowPostPaint(dataGridViewRowPostPaintEventArgs_0)
		End Sub

		' Token: 0x04000458 RID: 1112
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000459 RID: 1113
		Private collection_0 As Collection

		' Token: 0x02000064 RID: 100
		' (Invoke) Token: 0x060007C2 RID: 1986
		Private Delegate Function Delegate1(object_0 As Object()) As DataGridViewRow

		' Token: 0x02000065 RID: 101
		' (Invoke) Token: 0x060007C6 RID: 1990
		Private Delegate Function Delegate2(string_0 As String, object_0 As Object()) As DataGridViewRow

		' Token: 0x02000066 RID: 102
		' (Invoke) Token: 0x060007CA RID: 1994
		Private Delegate Sub Delegate3(dataGridViewRow_0 As DataGridViewRow)

		' Token: 0x02000067 RID: 103
		' (Invoke) Token: 0x060007CE RID: 1998
		Private Delegate Sub Delegate4(int_0 As Integer)

		' Token: 0x02000068 RID: 104
		Public Enum GEnum0
			' Token: 0x0400045B RID: 1115
			Image = 2
			' Token: 0x0400045C RID: 1116
			Link = 1
			' Token: 0x0400045D RID: 1117
			StretchImage = 3
			' Token: 0x0400045E RID: 1118
			Text = 0
		End Enum
	End Class
End Namespace
