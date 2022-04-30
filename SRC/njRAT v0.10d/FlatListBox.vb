Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200003C RID: 60
	Friend Class FlatListBox
		Inherits Control

		' Token: 0x060006BE RID: 1726 RVA: 0x00037E94 File Offset: 0x00036094
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatListBox.__ENCList
			SyncLock _ENCList
				If FlatListBox.__ENCList.Count = FlatListBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatListBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatListBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatListBox.__ENCList(num) = FlatListBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatListBox.__ENCList.RemoveRange(num, FlatListBox.__ENCList.Count - num)
					FlatListBox.__ENCList.Capacity = FlatListBox.__ENCList.Count
				End If
				FlatListBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700023B RID: 571
		' (get) Token: 0x060006BF RID: 1727 RVA: 0x00037F7C File Offset: 0x0003617C
		' (set) Token: 0x060006C0 RID: 1728 RVA: 0x00037F94 File Offset: 0x00036194
		Private Overridable Property ListBx As ListBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ListBx
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListBox)
				Dim value2 As DrawItemEventHandler = AddressOf Me.Drawitem
				If Me._ListBx IsNot Nothing Then
					RemoveHandler Me._ListBx.DrawItem, value2
				End If
				Me._ListBx = value
				If Me._ListBx IsNot Nothing Then
					AddHandler Me._ListBx.DrawItem, value2
				End If
			End Set
		End Property

		' Token: 0x1700023C RID: 572
		' (get) Token: 0x060006C1 RID: 1729 RVA: 0x00037FEC File Offset: 0x000361EC
		' (set) Token: 0x060006C2 RID: 1730 RVA: 0x000039FB File Offset: 0x00001BFB
		<Category("Options")>
		Public Property items As String()
			Get
				Return Me._items
			End Get
			Set(value As String())
				Me._items = value
				Me.ListBx.Items.Clear()
				Me.ListBx.Items.AddRange(value)
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700023D RID: 573
		' (get) Token: 0x060006C3 RID: 1731 RVA: 0x00038004 File Offset: 0x00036204
		' (set) Token: 0x060006C4 RID: 1732 RVA: 0x00003A2B File Offset: 0x00001C2B
		<Category("Colors")>
		Public Property SelectedColor As Color
			Get
				Return Me._SelectedColor
			End Get
			Set(value As Color)
				Me._SelectedColor = value
			End Set
		End Property

		' Token: 0x1700023E RID: 574
		' (get) Token: 0x060006C5 RID: 1733 RVA: 0x0003801C File Offset: 0x0003621C
		Public ReadOnly Property SelectedItem As String
			Get
				Return Conversions.ToString(Me.ListBx.SelectedItem)
			End Get
		End Property

		' Token: 0x1700023F RID: 575
		' (get) Token: 0x060006C6 RID: 1734 RVA: 0x0003803C File Offset: 0x0003623C
		Public ReadOnly Property SelectedIndex As Integer
			Get
				Return Me.ListBx.SelectedIndex
			End Get
		End Property

		' Token: 0x060006C7 RID: 1735 RVA: 0x00038058 File Offset: 0x00036258
		Public Sub Drawitem(sender As Object, e As DrawItemEventArgs)
			If e.Index >= 0 Then
				e.DrawBackground()
				e.DrawFocusRectangle()
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality
				e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
				e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
				e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
				If Strings.InStr(e.State.ToString(), "Selected,", CompareMethod.Binary) > 0 Then
					Dim graphics As Graphics = e.Graphics
					Dim brush As Brush = New SolidBrush(Me._SelectedColor)
					Dim bounds As Rectangle = e.Bounds
					Dim bounds2 As Rectangle = New Rectangle(bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
					graphics.FillRectangle(brush, bounds2)
					Dim graphics2 As Graphics = e.Graphics
					Dim s As String = " " + Me.ListBx.Items(e.Index).ToString()
					Dim font As Font = New Font("Segoe UI", 8F)
					Dim white As Brush = Brushes.White
					bounds = e.Bounds
					Dim x As Single = CSng(bounds.X)
					bounds2 = e.Bounds
					graphics2.DrawString(s, font, white, x, CSng((bounds2.Y + 2)))
				Else
					Dim graphics3 As Graphics = e.Graphics
					Dim brush2 As Brush = New SolidBrush(Color.FromArgb(60, 60, 60))
					Dim bounds2 As Rectangle = e.Bounds
					Dim bounds As Rectangle = New Rectangle(bounds2.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height)
					graphics3.FillRectangle(brush2, bounds)
					Dim graphics4 As Graphics = e.Graphics
					Dim s2 As String = " " + Me.ListBx.Items(e.Index).ToString()
					Dim font2 As Font = New Font("Segoe UI", 8F)
					Dim white2 As Brush = Brushes.White
					bounds = e.Bounds
					Dim x2 As Single = CSng(bounds.X)
					bounds2 = e.Bounds
					graphics4.DrawString(s2, font2, white2, x2, CSng((bounds2.Y + 2)))
				End If
				e.Graphics.Dispose()
			End If
		End Sub

		' Token: 0x060006C8 RID: 1736 RVA: 0x00038260 File Offset: 0x00036460
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			If Not Me.Controls.Contains(Me.ListBx) Then
				Me.Controls.Add(Me.ListBx)
			End If
		End Sub

		' Token: 0x060006C9 RID: 1737 RVA: 0x00003A34 File Offset: 0x00001C34
		Public Sub AddRange(items As Object())
			Me.ListBx.Items.Remove("")
			Me.ListBx.Items.AddRange(items)
		End Sub

		' Token: 0x060006CA RID: 1738 RVA: 0x00003A5C File Offset: 0x00001C5C
		Public Sub AddItem(item As Object)
			Me.ListBx.Items.Remove("")
			Me.ListBx.Items.Add(RuntimeHelpers.GetObjectValue(item))
		End Sub

		' Token: 0x060006CB RID: 1739 RVA: 0x0003829C File Offset: 0x0003649C
		Public Sub New()
			FlatListBox.__ENCAddToList(Me)
			Me.ListBx = New ListBox()
			Me._items = New String() { "" }
			Me.BaseColor = Color.FromArgb(60, 60, 60)
			Me._SelectedColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.ListBx.DrawMode = DrawMode.OwnerDrawFixed
			Me.ListBx.ScrollAlwaysVisible = False
			Me.ListBx.HorizontalScrollbar = False
			Me.ListBx.BorderStyle = BorderStyle.None
			Me.ListBx.BackColor = Me.BaseColor
			Me.ListBx.ForeColor = Color.White
			Dim listBx As Control = Me.ListBx
			Dim location As Point = New Point(3, 3)
			listBx.Location = location
			Me.ListBx.Font = New Font("Segoe UI", 8F)
			Me.ListBx.ItemHeight = 20
			Me.ListBx.Items.Clear()
			Me.ListBx.IntegralHeight = False
			Dim size As Size = New Size(131, 101)
			Me.Size = size
			Me.BackColor = Me.BaseColor
		End Sub

		' Token: 0x060006CC RID: 1740 RVA: 0x000383E0 File Offset: 0x000365E0
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Dim listBx As Control = Me.ListBx
			Dim size As Size = New Size(Me.Width - 6, Me.Height - 2)
			listBx.Size = size
			g.FillRectangle(New SolidBrush(Me.BaseColor), rect)
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x0400034F RID: 847
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000350 RID: 848
		<AccessedThroughProperty("ListBx")>
		Private _ListBx As ListBox

		' Token: 0x04000351 RID: 849
		Private _items As String()

		' Token: 0x04000352 RID: 850
		Private BaseColor As Color

		' Token: 0x04000353 RID: 851
		Private _SelectedColor As Color
	End Class
End Namespace
