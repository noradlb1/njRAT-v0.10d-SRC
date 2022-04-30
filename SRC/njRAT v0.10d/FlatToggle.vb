Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace NJRAT
	' Token: 0x0200002B RID: 43
	<DefaultEvent("CheckedChanged")>
	Friend Class FlatToggle
		Inherits Control

		' Token: 0x060005F2 RID: 1522 RVA: 0x00033BF0 File Offset: 0x00031DF0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatToggle.__ENCList
			SyncLock _ENCList
				If FlatToggle.__ENCList.Count = FlatToggle.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatToggle.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatToggle.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatToggle.__ENCList(num) = FlatToggle.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatToggle.__ENCList.RemoveRange(num, FlatToggle.__ENCList.Count - num)
					FlatToggle.__ENCList.Capacity = FlatToggle.__ENCList.Count
				End If
				FlatToggle.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x14000001 RID: 1
		' (add) Token: 0x060005F3 RID: 1523 RVA: 0x00003437 File Offset: 0x00001637
		' (remove) Token: 0x060005F4 RID: 1524 RVA: 0x00003450 File Offset: 0x00001650
		<DebuggerNonUserCode()>
		Public Event CheckedChanged As FlatToggle.CheckedChangedEventHandler

		' Token: 0x17000212 RID: 530
		' (get) Token: 0x060005F5 RID: 1525 RVA: 0x00033CD8 File Offset: 0x00031ED8
		' (set) Token: 0x060005F6 RID: 1526 RVA: 0x00003469 File Offset: 0x00001669
		<Category("Options")>
		Public Property Options As FlatToggle._Options
			Get
				Return Me.O
			End Get
			Set(value As FlatToggle._Options)
				Me.O = value
			End Set
		End Property

		' Token: 0x17000213 RID: 531
		' (get) Token: 0x060005F7 RID: 1527 RVA: 0x00033CF0 File Offset: 0x00031EF0
		' (set) Token: 0x060005F8 RID: 1528 RVA: 0x00003472 File Offset: 0x00001672
		<Category("Options")>
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
			End Set
		End Property

		' Token: 0x060005F9 RID: 1529 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x060005FA RID: 1530 RVA: 0x0000348A File Offset: 0x0000168A
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Width = 76
			Me.Height = 33
		End Sub

		' Token: 0x060005FB RID: 1531 RVA: 0x000034A3 File Offset: 0x000016A3
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005FC RID: 1532 RVA: 0x000034B9 File Offset: 0x000016B9
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060005FD RID: 1533 RVA: 0x000034CF File Offset: 0x000016CF
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060005FE RID: 1534 RVA: 0x000034E5 File Offset: 0x000016E5
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005FF RID: 1535 RVA: 0x00033D04 File Offset: 0x00031F04
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Me._Checked = Not Me._Checked
			Dim checkedChangedEvent As FlatToggle.CheckedChangedEventHandler = Me.CheckedChangedEvent
			If checkedChangedEvent IsNot Nothing Then
				checkedChangedEvent(Me)
			End If
		End Sub

		' Token: 0x06000600 RID: 1536 RVA: 0x00033D40 File Offset: 0x00031F40
		Public Sub New()
			FlatToggle.__ENCAddToList(Me)
			Me._Checked = False
			Me.State = MouseState.None
			Me.BaseColor = Color.FromArgb(0, 170, 220)
			Me.BaseColorRed = Color.FromArgb(0, 170, 220)
			Me.BGColor = Color.FromArgb(84, 85, 86)
			Me.ToggleColor = Color.FromArgb(45, 47, 49)
			Me.TextColor = Color.FromArgb(243, 243, 243)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.Transparent
			Dim size As Size = New Size(44, Me.Height + 1)
			Me.Size = size
			Me.Cursor = Cursors.Hand
			Me.Font = New Font("Segoe UI", 10F)
			size = New Size(56, 13)
			Me.Size = size
		End Sub

		' Token: 0x06000601 RID: 1537 RVA: 0x00033E38 File Offset: 0x00032038
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim path As GraphicsPath = New GraphicsPath()
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim rectangle As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim rectangle2 As Rectangle = New Rectangle(Me.W / 2, 0, 38, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.O
				Case FlatToggle._Options.Style1
					path = Helpers.RoundRec(rectangle, 6)
					graphicsPath = Helpers.RoundRec(rectangle2, 6)
					g.FillPath(New SolidBrush(Me.BGColor), path)
					g.FillPath(New SolidBrush(Me.ToggleColor), graphicsPath)
					Dim graphics As Graphics = g
					Dim s As String = "OFF"
					Dim font As Font = Me.Font
					Dim brush As Brush = New SolidBrush(Me.BGColor)
					Dim rectangle3 As Rectangle = New Rectangle(19, 1, Me.W, Me.H)
					graphics.DrawString(s, font, brush, rectangle3, Helpers.CenterSF)
					If Me.Checked Then
						path = Helpers.RoundRec(rectangle, 6)
						rectangle3 = New Rectangle(Me.W / 2, 0, 38, Me.H)
						graphicsPath = Helpers.RoundRec(rectangle3, 6)
						g.FillPath(New SolidBrush(Me.ToggleColor), path)
						g.FillPath(New SolidBrush(Me.BaseColor), graphicsPath)
						Dim graphics2 As Graphics = g
						Dim s2 As String = "ON"
						Dim font2 As Font = Me.Font
						Dim brush2 As Brush = New SolidBrush(Me.BaseColor)
						rectangle3 = New Rectangle(8, 7, Me.W, Me.H)
						graphics2.DrawString(s2, font2, brush2, rectangle3, Helpers.NearSF)
					End If
				Case FlatToggle._Options.Style2
					path = Helpers.RoundRec(rectangle, 6)
					rectangle2 = New Rectangle(4, 4, 36, Me.H - 8)
					graphicsPath = Helpers.RoundRec(rectangle2, 4)
					g.FillPath(New SolidBrush(Me.BaseColorRed), path)
					g.FillPath(New SolidBrush(Me.ToggleColor), graphicsPath)
					g.DrawLine(New Pen(Me.BGColor), 18, 20, 18, 12)
					g.DrawLine(New Pen(Me.BGColor), 22, 20, 22, 12)
					g.DrawLine(New Pen(Me.BGColor), 26, 20, 26, 12)
					Dim graphics3 As Graphics = g
					Dim s3 As String = "r"
					Dim font3 As Font = New Font("Marlett", 8F)
					Dim brush3 As Brush = New SolidBrush(Me.TextColor)
					Dim rectangle3 As Rectangle = New Rectangle(19, 2, Me.Width, Me.Height)
					graphics3.DrawString(s3, font3, brush3, rectangle3, Helpers.CenterSF)
					If Me.Checked Then
						path = Helpers.RoundRec(rectangle, 6)
						rectangle2 = New Rectangle(Me.W / 2 - 2, 4, 36, Me.H - 8)
						graphicsPath = Helpers.RoundRec(rectangle2, 4)
						g.FillPath(New SolidBrush(Me.BaseColor), path)
						g.FillPath(New SolidBrush(Me.ToggleColor), graphicsPath)
						g.DrawLine(New Pen(Me.BGColor), Me.W / 2 + 12, 20, Me.W / 2 + 12, 12)
						g.DrawLine(New Pen(Me.BGColor), Me.W / 2 + 16, 20, Me.W / 2 + 16, 12)
						g.DrawLine(New Pen(Me.BGColor), Me.W / 2 + 20, 20, Me.W / 2 + 20, 12)
						Dim graphics4 As Graphics = g
						Dim s4 As String = "ü"
						Dim font4 As Font = New Font("Wingdings", 14F)
						Dim brush4 As Brush = New SolidBrush(Me.TextColor)
						rectangle3 = New Rectangle(8, 7, Me.Width, Me.Height)
						graphics4.DrawString(s4, font4, brush4, rectangle3, Helpers.NearSF)
					End If
				Case FlatToggle._Options.Style3
					path = Helpers.RoundRec(rectangle, 16)
					rectangle2 = New Rectangle(Me.W - 28, 4, 22, Me.H - 8)
					graphicsPath.AddEllipse(rectangle2)
					g.FillPath(New SolidBrush(Me.ToggleColor), path)
					g.FillPath(New SolidBrush(Me.BaseColorRed), graphicsPath)
					Dim graphics5 As Graphics = g
					Dim s5 As String = "OFF"
					Dim font5 As Font = Me.Font
					Dim brush5 As Brush = New SolidBrush(Me.BaseColorRed)
					Dim rectangle3 As Rectangle = New Rectangle(-12, 2, Me.W, Me.H)
					graphics5.DrawString(s5, font5, brush5, rectangle3, Helpers.CenterSF)
					If Me.Checked Then
						path = Helpers.RoundRec(rectangle, 16)
						rectangle2 = New Rectangle(6, 4, 22, Me.H - 8)
						graphicsPath.Reset()
						graphicsPath.AddEllipse(rectangle2)
						g.FillPath(New SolidBrush(Me.ToggleColor), path)
						g.FillPath(New SolidBrush(Me.BaseColor), graphicsPath)
						Dim graphics6 As Graphics = g
						Dim s6 As String = "ON"
						Dim font6 As Font = Me.Font
						Dim brush6 As Brush = New SolidBrush(Me.BaseColor)
						rectangle3 = New Rectangle(12, 2, Me.W, Me.H)
						graphics6.DrawString(s6, font6, brush6, rectangle3, Helpers.CenterSF)
					End If
				Case FlatToggle._Options.Style4
					If Me.Checked Then
					End If
				Case FlatToggle._Options.Style5
					If Me.Checked Then
					End If
			End Select
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x040002D9 RID: 729
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002DA RID: 730
		Private W As Integer

		' Token: 0x040002DB RID: 731
		Private H As Integer

		' Token: 0x040002DC RID: 732
		Private O As FlatToggle._Options

		' Token: 0x040002DD RID: 733
		Private _Checked As Boolean

		' Token: 0x040002DE RID: 734
		Private State As MouseState

		' Token: 0x040002E0 RID: 736
		Private BaseColor As Color

		' Token: 0x040002E1 RID: 737
		Private BaseColorRed As Color

		' Token: 0x040002E2 RID: 738
		Private BGColor As Color

		' Token: 0x040002E3 RID: 739
		Private ToggleColor As Color

		' Token: 0x040002E4 RID: 740
		Private TextColor As Color

		' Token: 0x0200002C RID: 44
		' (Invoke) Token: 0x06000605 RID: 1541
		Public Delegate Sub CheckedChangedEventHandler(sender As Object)

		' Token: 0x0200002D RID: 45
		<Flags()>
		Public Enum _Options
			' Token: 0x040002E6 RID: 742
			Style1 = 0
			' Token: 0x040002E7 RID: 743
			Style2 = 1
			' Token: 0x040002E8 RID: 744
			Style3 = 2
			' Token: 0x040002E9 RID: 745
			Style4 = 3
			' Token: 0x040002EA RID: 746
			Style5 = 4
		End Enum
	End Class
End Namespace
