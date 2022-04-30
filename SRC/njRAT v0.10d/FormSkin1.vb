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
	' Token: 0x02000025 RID: 37
	Friend Class FormSkin1
		Inherits ContainerControl

		' Token: 0x0600059C RID: 1436 RVA: 0x00032504 File Offset: 0x00030704
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FormSkin1.__ENCList
			SyncLock _ENCList
				If FormSkin1.__ENCList.Count = FormSkin1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FormSkin1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FormSkin1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FormSkin1.__ENCList(num) = FormSkin1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FormSkin1.__ENCList.RemoveRange(num, FormSkin1.__ENCList.Count - num)
					FormSkin1.__ENCList.Capacity = FormSkin1.__ENCList.Count
				End If
				FormSkin1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000202 RID: 514
		' (get) Token: 0x0600059D RID: 1437 RVA: 0x000325EC File Offset: 0x000307EC
		' (set) Token: 0x0600059E RID: 1438 RVA: 0x00003190 File Offset: 0x00001390
		<Category("Colors")>
		Public Property HeaderColor As Color
			Get
				Return Me._HeaderColor
			End Get
			Set(value As Color)
				Me._HeaderColor = value
			End Set
		End Property

		' Token: 0x17000203 RID: 515
		' (get) Token: 0x0600059F RID: 1439 RVA: 0x00032604 File Offset: 0x00030804
		' (set) Token: 0x060005A0 RID: 1440 RVA: 0x00003199 File Offset: 0x00001399
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000204 RID: 516
		' (get) Token: 0x060005A1 RID: 1441 RVA: 0x0003261C File Offset: 0x0003081C
		' (set) Token: 0x060005A2 RID: 1442 RVA: 0x000031A2 File Offset: 0x000013A2
		<Category("Colors")>
		Public Property BorderColor As Color
			Get
				Return Me._BorderColor
			End Get
			Set(value As Color)
				Me._BorderColor = value
			End Set
		End Property

		' Token: 0x17000205 RID: 517
		' (get) Token: 0x060005A3 RID: 1443 RVA: 0x00032634 File Offset: 0x00030834
		' (set) Token: 0x060005A4 RID: 1444 RVA: 0x000031AB File Offset: 0x000013AB
		<Category("Colors")>
		Public Property FlatColor As Color
			Get
				Return Helpers._FlatColor
			End Get
			Set(value As Color)
				Helpers._FlatColor = value
			End Set
		End Property

		' Token: 0x17000206 RID: 518
		' (get) Token: 0x060005A5 RID: 1445 RVA: 0x00032648 File Offset: 0x00030848
		' (set) Token: 0x060005A6 RID: 1446 RVA: 0x000031B3 File Offset: 0x000013B3
		<Category("Options")>
		Public Property HeaderMaximize As Boolean
			Get
				Return Me._HeaderMaximize
			End Get
			Set(value As Boolean)
				Me._HeaderMaximize = value
			End Set
		End Property

		' Token: 0x060005A7 RID: 1447 RVA: 0x0003265C File Offset: 0x0003085C
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

		' Token: 0x060005A8 RID: 1448 RVA: 0x000326BC File Offset: 0x000308BC
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

		' Token: 0x060005A9 RID: 1449 RVA: 0x000031BC File Offset: 0x000013BC
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.Cap = False
		End Sub

		' Token: 0x060005AA RID: 1450 RVA: 0x00032760 File Offset: 0x00030960
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If Me.Cap Then
				Me.Parent.Location = Control.MousePosition - CType(Me.MousePoint, Size)
			End If
		End Sub

		' Token: 0x060005AB RID: 1451 RVA: 0x00031F3C File Offset: 0x0003013C
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.ParentForm.FormBorderStyle = FormBorderStyle.None
			Me.ParentForm.AllowTransparency = False
			Me.ParentForm.TransparencyKey = Color.Fuchsia
			Me.ParentForm.FindForm().StartPosition = FormStartPosition.CenterScreen
			Me.Dock = DockStyle.Fill
			Me.Invalidate()
		End Sub

		' Token: 0x060005AC RID: 1452 RVA: 0x0003279C File Offset: 0x0003099C
		Public Sub New()
			AddHandler MyBase.MouseDoubleClick, AddressOf Me.FormSkin_MouseDoubleClick
			FormSkin1.__ENCAddToList(Me)
			Me.Cap = False
			Me._HeaderMaximize = False
			Me.MousePoint = New Point(0, 0)
			Me.MoveHeight = 50
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

		' Token: 0x060005AD RID: 1453 RVA: 0x000328BC File Offset: 0x00030ABC
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim rect2 As Rectangle = New Rectangle(0, 0, Me.W, 50)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
			g.FillRectangle(New SolidBrush(Me._HeaderColor), rect2)
			Dim graphics As Graphics = g
			Dim brush As Brush = New SolidBrush(Color.FromArgb(243, 243, 243))
			Dim rectangle As Rectangle = New Rectangle(8, 16, 4, 18)
			graphics.FillRectangle(brush, rectangle)
			g.FillRectangle(New SolidBrush(Color.FromArgb(0, 170, 220)), 16, 16, 4, 18)
			Dim graphics2 As Graphics = g
			Dim text As String = Me.Text
			Dim font As Font = Me.Font
			Dim brush2 As Brush = New SolidBrush(Me.TextColor)
			rectangle = New Rectangle(26, 15, Me.W, Me.H)
			graphics2.DrawString(text, font, brush2, rectangle, Helpers.NearSF)
			g.DrawRectangle(New Pen(Me._BorderColor), rect)
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x040002B0 RID: 688
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002B1 RID: 689
		Private W As Integer

		' Token: 0x040002B2 RID: 690
		Private H As Integer

		' Token: 0x040002B3 RID: 691
		Private Cap As Boolean

		' Token: 0x040002B4 RID: 692
		Private _HeaderMaximize As Boolean

		' Token: 0x040002B5 RID: 693
		Private MousePoint As Point

		' Token: 0x040002B6 RID: 694
		Private MoveHeight As Object

		' Token: 0x040002B7 RID: 695
		Private _HeaderColor As Color

		' Token: 0x040002B8 RID: 696
		Private _BaseColor As Color

		' Token: 0x040002B9 RID: 697
		Private _BorderColor As Color

		' Token: 0x040002BA RID: 698
		Private TextColor As Color

		' Token: 0x040002BB RID: 699
		Private _HeaderLight As Color

		' Token: 0x040002BC RID: 700
		Private _BaseLight As Color

		' Token: 0x040002BD RID: 701
		Public TextLight As Color
	End Class
End Namespace
