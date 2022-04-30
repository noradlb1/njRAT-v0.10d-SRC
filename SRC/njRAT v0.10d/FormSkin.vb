Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000022 RID: 34
	Public Class FormSkin
		Inherits ContainerControl

		' Token: 0x06000583 RID: 1411 RVA: 0x00031C88 File Offset: 0x0002FE88
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FormSkin.__ENCList
			SyncLock _ENCList
				If FormSkin.__ENCList.Count = FormSkin.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FormSkin.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FormSkin.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FormSkin.__ENCList(num) = FormSkin.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FormSkin.__ENCList.RemoveRange(num, FormSkin.__ENCList.Count - num)
					FormSkin.__ENCList.Capacity = FormSkin.__ENCList.Count
				End If
				FormSkin.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001FC RID: 508
		' (get) Token: 0x06000584 RID: 1412 RVA: 0x00031D70 File Offset: 0x0002FF70
		' (set) Token: 0x06000585 RID: 1413 RVA: 0x0000311A File Offset: 0x0000131A
		<Category("Colors")>
		Public Property HeaderColor As Color
			Get
				Return Me._HeaderColor
			End Get
			Set(value As Color)
				Me._HeaderColor = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x170001FD RID: 509
		' (get) Token: 0x06000586 RID: 1414 RVA: 0x00031D88 File Offset: 0x0002FF88
		' (set) Token: 0x06000587 RID: 1415 RVA: 0x00003129 File Offset: 0x00001329
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x170001FE RID: 510
		' (get) Token: 0x06000588 RID: 1416 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		' (set) Token: 0x06000589 RID: 1417 RVA: 0x00003138 File Offset: 0x00001338
		<Category("Colors")>
		Public Property BorderColor As Color
			Get
				Return Me._BorderColor
			End Get
			Set(value As Color)
				Me._BorderColor = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x170001FF RID: 511
		' (get) Token: 0x0600058A RID: 1418 RVA: 0x00031DB8 File Offset: 0x0002FFB8
		' (set) Token: 0x0600058B RID: 1419 RVA: 0x00003147 File Offset: 0x00001347
		<Category("Colors")>
		Public Property BorderSize As Integer
			Get
				Return Me._BorderSize
			End Get
			Set(value As Integer)
				Me._BorderSize = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x17000200 RID: 512
		' (get) Token: 0x0600058C RID: 1420 RVA: 0x00031DD0 File Offset: 0x0002FFD0
		' (set) Token: 0x0600058D RID: 1421 RVA: 0x00003156 File Offset: 0x00001356
		<Category("Colors")>
		Public Property FlatColor As Color
			Get
				Return Me._FlatColor
			End Get
			Set(value As Color)
				Me._FlatColor = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x17000201 RID: 513
		' (get) Token: 0x0600058E RID: 1422 RVA: 0x00031DE8 File Offset: 0x0002FFE8
		' (set) Token: 0x0600058F RID: 1423 RVA: 0x00003165 File Offset: 0x00001365
		<Category("Options")>
		Public Property HeaderMaximize As Boolean
			Get
				Return Me._HeaderMaximize
			End Get
			Set(value As Boolean)
				Me._HeaderMaximize = value
				Me.Refresh()
			End Set
		End Property

		' Token: 0x06000590 RID: 1424 RVA: 0x00031DFC File Offset: 0x0002FFFC
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Dim flag As Boolean = e.Button = MouseButtons.Left
			Dim rectangle As Rectangle = New Rectangle(0, 0, Me.Width, Conversions.ToInteger(Me.MoveHeight))
			Dim rectangle2 As Rectangle = rectangle
			If flag And rectangle2.Contains(e.Location) Then
				Me.Cap = True
				Me.MousePoint = e.Location
			End If
		End Sub

		' Token: 0x06000591 RID: 1425 RVA: 0x00031E5C File Offset: 0x0003005C
		Private Sub FormSkin_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			If Me.HeaderMaximize Then
				Dim flag As Boolean = e.Button = MouseButtons.Left
				Dim rectangle As Rectangle = New Rectangle(0, 0, Me.Width, Conversions.ToInteger(Me.MoveHeight))
				Dim rectangle2 As Rectangle = rectangle
				If flag And rectangle2.Contains(e.Location) Then
					If Me.FindForm().WindowState = FormWindowState.Normal Then
						Me.FindForm().WindowState = FormWindowState.Maximized
						Me.FindForm().Refresh()
					ElseIf Me.FindForm().WindowState = FormWindowState.Maximized Then
						Me.FindForm().WindowState = FormWindowState.Normal
						Me.FindForm().Refresh()
					End If
				End If
			End If
		End Sub

		' Token: 0x06000592 RID: 1426 RVA: 0x00003174 File Offset: 0x00001374
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.Cap = False
		End Sub

		' Token: 0x06000593 RID: 1427 RVA: 0x00031F00 File Offset: 0x00030100
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If Me.Cap Then
				Me.Parent.Location = Control.MousePosition - CType(Me.MousePoint, Size)
			End If
		End Sub

		' Token: 0x06000594 RID: 1428 RVA: 0x00031F3C File Offset: 0x0003013C
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.ParentForm.FormBorderStyle = FormBorderStyle.None
			Me.ParentForm.AllowTransparency = False
			Me.ParentForm.TransparencyKey = Color.Fuchsia
			Me.ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen
			Me.Dock = DockStyle.Fill
			Me.Invalidate()
		End Sub

		' Token: 0x06000595 RID: 1429 RVA: 0x00031F98 File Offset: 0x00030198
		Public Sub New()
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.FormSkin_MouseDoubleClick
			FormSkin.__ENCAddToList(Me)
			Me._BorderSize = 5
			Me.Cap = False
			Me._HeaderMaximize = False
			Me.MousePoint = New Point(0, 0)
			Me.MoveHeight = 50
			Me._FlatColor = Color.FromArgb(35, 168, 109)
			Me.NearSF = New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }
			Me.CenterSF = New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center }
			Me._HeaderColor = Color.FromArgb(50, 50, 50)
			Me._BaseColor = Color.FromArgb(50, 50, 50)
			Me._BorderColor = Color.FromArgb(0, 170, 220)
			Me.TextColor = Color.FromArgb(212, 198, 209)
			Me._HeaderLight = Color.FromArgb(171, 171, 172)
			Me._BaseLight = Color.FromArgb(196, 199, 200)
			Me.TextLight = Color.FromArgb(45, 47, 49)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.White
			Me.Font = New Font("Segoe UI", 12F)
		End Sub

		' Token: 0x06000596 RID: 1430 RVA: 0x00032108 File Offset: 0x00030308
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Me.B = New Bitmap(Me.Width, Me.Height)
			Me.G = Graphics.FromImage(Me.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim rectangle As Rectangle = New Rectangle(0, 0, Me.W, 50)
			Dim g As Graphics = Me.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
			Dim graphics As Graphics = g
			Dim text As String = Me.Text
			Dim font As Font = Me.Font
			Dim brush As Brush = New SolidBrush(Me.TextColor)
			Dim r As Rectangle = New Rectangle(26, 15, Me.W, Me.H)
			graphics.DrawString(text, font, brush, r, Me.NearSF)
			Dim pen As Pen = New Pen(Me._BorderColor, CSng(Me._BorderSize))
			g.DrawRectangle(pen, rect)
			MyBase.OnPaint(e)
			Me.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Me.B, 0, 0)
			Me.B.Dispose()
		End Sub

		' Token: 0x04000292 RID: 658
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000293 RID: 659
		Private _BorderSize As Integer

		' Token: 0x04000294 RID: 660
		Private W As Integer

		' Token: 0x04000295 RID: 661
		Private H As Integer

		' Token: 0x04000296 RID: 662
		Private Cap As Boolean

		' Token: 0x04000297 RID: 663
		Private _HeaderMaximize As Boolean

		' Token: 0x04000298 RID: 664
		Private MousePoint As Point

		' Token: 0x04000299 RID: 665
		Private MoveHeight As Object

		' Token: 0x0400029A RID: 666
		Friend G As Graphics

		' Token: 0x0400029B RID: 667
		Friend B As Bitmap

		' Token: 0x0400029C RID: 668
		Friend _FlatColor As Color

		' Token: 0x0400029D RID: 669
		Friend NearSF As StringFormat

		' Token: 0x0400029E RID: 670
		Friend CenterSF As StringFormat

		' Token: 0x0400029F RID: 671
		Private _HeaderColor As Color

		' Token: 0x040002A0 RID: 672
		Private _BaseColor As Color

		' Token: 0x040002A1 RID: 673
		Private _BorderColor As Color

		' Token: 0x040002A2 RID: 674
		Private TextColor As Color

		' Token: 0x040002A3 RID: 675
		Private _HeaderLight As Color

		' Token: 0x040002A4 RID: 676
		Private _BaseLight As Color

		' Token: 0x040002A5 RID: 677
		Public TextLight As Color
	End Class
End Namespace
