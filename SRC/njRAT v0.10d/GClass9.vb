Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000053 RID: 83
	<DesignerGenerated()>
	Public NotInheritable Class GClass9
		Inherits ListView

		' Token: 0x0600077F RID: 1919 RVA: 0x00042F78 File Offset: 0x00041178
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = GClass9.__ENCList
			SyncLock _ENCList
				If GClass9.__ENCList.Count = GClass9.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = GClass9.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = GClass9.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								GClass9.__ENCList(num) = GClass9.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					GClass9.__ENCList.RemoveRange(num, GClass9.__ENCList.Count - num)
					GClass9.__ENCList.Capacity = GClass9.__ENCList.Count
				End If
				GClass9.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000780 RID: 1920 RVA: 0x00043060 File Offset: 0x00041260
		Public Sub New()
			GClass9.__ENCAddToList(Me)
			AddHandler MyBase.ParentChanged, AddressOf Me.GClass9_ParentChanged
			AddHandler MyBase.MouseMove, AddressOf Me.GClass9_MouseMove
			AddHandler MyBase.MouseUp, AddressOf Me.GClass9_MouseUp
			AddHandler MyBase.ColumnClick, AddressOf Me.GClass9_ColumnClick
			AddHandler MyBase.KeyDown, AddressOf Me.GClass9_KeyDown
			AddHandler MyBase.MouseDown, AddressOf Me.GClass9_MouseDown
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
			Me.point_1 = Point.Empty
			Me.AllowDrop = False
			Me.Font = New Font("arial", 8F, FontStyle.Bold)
			Me.Dock = DockStyle.Fill
			Me.FullRowSelect = True
			Me.View = View.Details
			Me.OwnerDraw = True
			Me.SetStyle(ControlStyles.UserPaint, False)
			Me.DoubleBuffered = True
			Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.SetStyle(ControlStyles.EnableNotifyMessage, True)
		End Sub

		' Token: 0x06000781 RID: 1921 RVA: 0x00003C63 File Offset: 0x00001E63
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__3(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x06000782 RID: 1922 RVA: 0x00003C63 File Offset: 0x00001E63
		<DebuggerStepThrough()>
		<CompilerGenerated()>
		Private Sub lam__4(sender As Object, e As EventArgs)
			Me.method_1()
		End Sub

		' Token: 0x06000783 RID: 1923 RVA: 0x00043168 File Offset: 0x00041368
		<DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.icontainer_0 IsNot Nothing Then
					Me.icontainer_0.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000784 RID: 1924 RVA: 0x000431A8 File Offset: 0x000413A8
		Public Sub GClass9_ColumnClick(sender As Object, e As ColumnClickEventArgs)
			SyncLock Me
				If e.Column <> -1 Then
					Try
						Dim columnHeader As ColumnHeader = CType(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(sender), Nothing, "Columns", New Object() { e.Column }, Nothing, Nothing, Nothing), ColumnHeader)
						Dim sortOrder_ As SortOrder
						If Me.columnHeader_0 Is Nothing Then
							sortOrder_ = SortOrder.Ascending
							columnHeader.Tag = "+"
						ElseIf columnHeader.Equals(Me.columnHeader_0) Then
							If Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.columnHeader_0.Tag), "+", False) Then
								sortOrder_ = SortOrder.Descending
								Me.columnHeader_0.Tag = "-"
							Else
								Me.columnHeader_0.Tag = "+"
								sortOrder_ = SortOrder.Ascending
							End If
						Else
							sortOrder_ = SortOrder.Ascending
						End If
						Me.columnHeader_0 = columnHeader
						If Me.columnHeader_0.Tag Is Nothing Then
							Me.columnHeader_0.Tag = "+"
						End If
						If sender IsNot Nothing Then
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { New GClass9.GClass10(e.Column, sortOrder_) }, Nothing, Nothing)
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(sender), Nothing, "Sort", New Object(-1) {}, Nothing, Nothing, Nothing, True)
							NewLateBinding.LateSet(RuntimeHelpers.GetObjectValue(sender), Nothing, "ListViewItemSorter", New Object() { Nothing }, Nothing, Nothing)
						End If
					Catch ex As Exception
					End Try
				End If
			End SyncLock
		End Sub

		' Token: 0x06000785 RID: 1925 RVA: 0x0004336C File Offset: 0x0004156C
		Private Sub GClass9_KeyDown(sender As Object, e As KeyEventArgs)
			If e.KeyCode = Keys.Space Then
				Me.method_3()
			End If
			If e.KeyCode = Keys.A And e.Control Then
				Try
					For Each obj As Object In Me.Items
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						listViewItem.Selected = True
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000786 RID: 1926 RVA: 0x000433F4 File Offset: 0x000415F4
		Private Sub GClass9_MouseDown(sender As Object, e As MouseEventArgs)
			If e.Button = MouseButtons.Left Then
				Me.listViewItem_0 = Me.GetItemAt(e.X, e.Y)
				Me.point_0 = e.Location
			End If
		End Sub

		' Token: 0x06000787 RID: 1927 RVA: 0x00043434 File Offset: 0x00041634
		Private Sub GClass9_MouseMove(sender As Object, e As MouseEventArgs)
			Me.point_1 = e.Location
			If Me.point_0 <> Point.Empty Then
				If Me.listViewItem_0 IsNot Nothing Then
					If Me.listViewItem_0.Index = -1 Then
						Me.listViewItem_0 = Nothing
					End If
				End If
				If(e.Button = MouseButtons.Left And Me.listViewItem_0 IsNot Nothing) AndAlso Me.listViewItem_0 IsNot Nothing Then
					Dim itemAt As ListViewItem = Me.GetItemAt(e.X, e.Y)
					If itemAt IsNot Nothing Then
						If itemAt.Index > Me.listViewItem_0.Index Then
							Dim index As Integer = itemAt.Index
							For i As Integer = Me.listViewItem_0.Index To index
								If Not Me.SelectedIndices.Contains(i) Then
									Me.SelectedIndices.Add(i)
								End If
							Next
							Try
								For Each obj As Object In Me.SelectedIndices
									Dim objectValue As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj)))
									If Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue), Me.listViewItem_0.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue), itemAt.Index, False))))) Then
										Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue)))
									End If
								Next
								Return
							Finally
								Dim enumerator As IEnumerator
								If TypeOf enumerator Is IDisposable Then
									TryCast(enumerator, IDisposable).Dispose()
								End If
							End Try
						End If
						Dim index2 As Integer = Me.listViewItem_0.Index
						For j As Integer = itemAt.Index To index2
							If Not Me.SelectedIndices.Contains(j) Then
								Me.SelectedIndices.Add(j)
							End If
						Next
						Try
							For Each obj2 As Object In Me.SelectedIndices
								Dim objectValue2 As Object = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(obj2)))
								If Conversions.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.OrObject(RuntimeHelpers.GetObjectValue(Operators.CompareObjectLess(RuntimeHelpers.GetObjectValue(objectValue2), itemAt.Index, False)), RuntimeHelpers.GetObjectValue(Operators.CompareObjectGreater(RuntimeHelpers.GetObjectValue(objectValue2), Me.listViewItem_0.Index, False))))) Then
									Me.SelectedIndices.Remove(Conversions.ToInteger(RuntimeHelpers.GetObjectValue(objectValue2)))
								End If
							Next
						Finally
							Dim enumerator2 As IEnumerator
							If TypeOf enumerator2 Is IDisposable Then
								TryCast(enumerator2, IDisposable).Dispose()
							End If
						End Try
					End If
				End If
			End If
		End Sub

		' Token: 0x06000788 RID: 1928 RVA: 0x00003C6B File Offset: 0x00001E6B
		Private Sub GClass9_MouseUp(sender As Object, e As MouseEventArgs)
			Me.listViewItem_0 = Nothing
			Me.point_0 = Point.Empty
		End Sub

		' Token: 0x06000789 RID: 1929 RVA: 0x000436F0 File Offset: 0x000418F0
		Private Sub GClass9_ParentChanged(sender As Object, e As EventArgs)
			Try
				If Me.Parent IsNot Nothing Then
					RemoveHandler Me.Parent.Resize, AddressOf Me.lam__3
				End If
				AddHandler Me.Parent.Resize, AddressOf Me.lam__4
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600078A RID: 1930 RVA: 0x00003C7F File Offset: 0x00001E7F
		<DebuggerStepThrough()>
		Private Sub method_0()
			Me.icontainer_0 = New Container()
		End Sub

		' Token: 0x0600078B RID: 1931 RVA: 0x00003C8C File Offset: 0x00001E8C
		Public Sub method_1()
			Me.method_3()
		End Sub

		' Token: 0x0600078C RID: 1932 RVA: 0x00043768 File Offset: 0x00041968
		Public Function method_2() As ListViewItem()
			Dim result As ListViewItem()
			SyncLock Me
				Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
				If Me.Items.Count = 0 Then
					Return list.ToArray()
				End If
				Try
					Dim listViewItem As ListViewItem = Me.TopItem
					list.Add(listViewItem)
					Dim num As Integer = Me.Items.Count - 1
					For i As Integer = listViewItem.Index + 1 To num
						Try
							listViewItem = Me.Items(i)
							If Not Me.Bounds.IntersectsWith(Me.Items(i).Bounds) Then
								Exit Try
							End If
							list.Add(listViewItem)
						Catch ex As Exception
							Exit Try
						End Try
					Next
				Catch ex2 As Exception
				End Try
				result = list.ToArray()
			End SyncLock
			Return result
		End Function

		' Token: 0x0600078D RID: 1933 RVA: 0x00043894 File Offset: 0x00041A94
		Public Sub method_3()
			Try
				If Me.Columns.Count <> 0 Then
					If Me.Items.Count = 0 Then
						Me.Columns(Me.Columns.Count - 1).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
					Else
						Dim num As Integer = Me.Columns.Count - 1
						For i As Integer = 0 To num
							Me.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
						Next
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600078E RID: 1934 RVA: 0x00043944 File Offset: 0x00041B44
		Protected Overrides Sub OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0 As DrawListViewColumnHeaderEventArgs)
			Try
				Dim format As StringFormat = New StringFormat() With { .FormatFlags = StringFormatFlags.NoWrap, .Trimming = StringTrimming.EllipsisCharacter, .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }
				Dim rect As Rectangle = New Rectangle(drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.Width, drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.Graphics.FillRectangle(New Pen(ControlPaint.Light(Me.BackColor, 0.1F)).Brush, rect)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawString(drawListViewColumnHeaderEventArgs_0.Header.Text, Me.Font, New Pen(Me.ForeColor).Brush, drawListViewColumnHeaderEventArgs_0.Bounds, format)
				drawListViewColumnHeaderEventArgs_0.Graphics.DrawLine(New Pen(Me.ForeColor), drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y, drawListViewColumnHeaderEventArgs_0.Bounds.X, drawListViewColumnHeaderEventArgs_0.Bounds.Y + drawListViewColumnHeaderEventArgs_0.Bounds.Height)
				drawListViewColumnHeaderEventArgs_0.DrawDefault = False
			Catch ex As Exception
			End Try
			MyBase.OnDrawColumnHeader(drawListViewColumnHeaderEventArgs_0)
		End Sub

		' Token: 0x0600078F RID: 1935 RVA: 0x00003C94 File Offset: 0x00001E94
		Protected Overrides Sub OnDrawItem(drawListViewItemEventArgs_0 As DrawListViewItemEventArgs)
			drawListViewItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawItem(drawListViewItemEventArgs_0)
		End Sub

		' Token: 0x06000790 RID: 1936 RVA: 0x00003CA4 File Offset: 0x00001EA4
		Protected Overrides Sub OnDrawSubItem(drawListViewSubItemEventArgs_0 As DrawListViewSubItemEventArgs)
			drawListViewSubItemEventArgs_0.DrawDefault = True
			MyBase.OnDrawSubItem(drawListViewSubItemEventArgs_0)
		End Sub

		' Token: 0x06000791 RID: 1937 RVA: 0x00043AC4 File Offset: 0x00041CC4
		Protected Overrides Sub OnNotifyMessage(message_0 As Message)
			If message_0.Msg <> 20 Then
				MyBase.OnNotifyMessage(message_0)
			End If
		End Sub

		' Token: 0x0400040E RID: 1038
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400040F RID: 1039
		Public columnHeader_0 As ColumnHeader

		' Token: 0x04000410 RID: 1040
		Private icontainer_0 As IContainer

		' Token: 0x04000411 RID: 1041
		Private listViewItem_0 As ListViewItem

		' Token: 0x04000412 RID: 1042
		Private point_0 As Point

		' Token: 0x04000413 RID: 1043
		Private point_1 As Point

		' Token: 0x02000054 RID: 84
		Public NotInheritable Class GClass10
			Implements IComparer

			' Token: 0x06000792 RID: 1938 RVA: 0x00003CB4 File Offset: 0x00001EB4
			Public Sub New(int_1 As Integer, sortOrder_1 As SortOrder)
				Me.int_0 = int_1
				Me.sortOrder_0 = sortOrder_1
			End Sub

			' Token: 0x06000793 RID: 1939 RVA: 0x00043AE8 File Offset: 0x00041CE8
			Public Function Compare(object_0 As Object, object_1 As Object) As Integer
				Dim listViewItem As ListViewItem = CType(object_0, ListViewItem)
				Dim listViewItem2 As ListViewItem = CType(object_1, ListViewItem)
				Dim text As String
				If listViewItem.SubItems.Count <= Me.int_0 Then
					text = String.Empty
				Else
					text = listViewItem.SubItems(Me.int_0).Text
				End If
				Dim text2 As String
				If listViewItem2.SubItems.Count <= Me.int_0 Then
					text2 = String.Empty
				Else
					text2 = listViewItem2.SubItems(Me.int_0).Text
				End If
				Dim result As Integer
				If Me.sortOrder_0 = SortOrder.Ascending Then
					If Versioned.IsNumeric(text) And Versioned.IsNumeric(text2) Then
						result = Conversion.Val(text).CompareTo(Conversion.Val(text2))
					ElseIf Information.IsDate(text) And Information.IsDate(text2) Then
						result = DateTime.Parse(text).CompareTo(DateTime.Parse(text2))
					Else
						result = String.Compare(text, text2)
					End If
				ElseIf Versioned.IsNumeric(text) And Versioned.IsNumeric(text2) Then
					result = Conversion.Val(text2).CompareTo(Conversion.Val(text))
				ElseIf Information.IsDate(text) And Information.IsDate(text2) Then
					result = DateTime.Parse(text2).CompareTo(DateTime.Parse(text))
				Else
					result = String.Compare(text2, text)
				End If
				Return result
			End Function

			' Token: 0x06000794 RID: 1940 RVA: 0x000388AC File Offset: 0x00036AAC
			Public Function Compare1(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
				Return 0
			End Function

			' Token: 0x04000414 RID: 1044
			Private int_0 As Integer

			' Token: 0x04000415 RID: 1045
			Private sortOrder_0 As SortOrder
		End Class
	End Class
End Namespace
