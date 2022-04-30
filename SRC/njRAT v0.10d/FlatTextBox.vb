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
	' Token: 0x02000034 RID: 52
	<DefaultEvent("TextChanged")>
	Friend Class FlatTextBox
		Inherits Control

		' Token: 0x0600063A RID: 1594 RVA: 0x00034FF8 File Offset: 0x000331F8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatTextBox.__ENCList
			SyncLock _ENCList
				If FlatTextBox.__ENCList.Count = FlatTextBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatTextBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatTextBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatTextBox.__ENCList(num) = FlatTextBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatTextBox.__ENCList.RemoveRange(num, FlatTextBox.__ENCList.Count - num)
					FlatTextBox.__ENCList.Capacity = FlatTextBox.__ENCList.Count
				End If
				FlatTextBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700021C RID: 540
		' (get) Token: 0x0600063B RID: 1595 RVA: 0x000350E0 File Offset: 0x000332E0
		' (set) Token: 0x0600063C RID: 1596 RVA: 0x00003697 File Offset: 0x00001897
		Private Overridable Property TB As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TB
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TB = value
			End Set
		End Property

		' Token: 0x1700021D RID: 541
		' (get) Token: 0x0600063D RID: 1597 RVA: 0x000350F8 File Offset: 0x000332F8
		' (set) Token: 0x0600063E RID: 1598 RVA: 0x00035110 File Offset: 0x00033310
		<Category("Options")>
		Public Property TextAlign As HorizontalAlignment
			Get
				Return Me._TextAlign
			End Get
			Set(value As HorizontalAlignment)
				Me._TextAlign = value
				If Me.TB IsNot Nothing Then
					Me.TB.TextAlign = value
				End If
			End Set
		End Property

		' Token: 0x1700021E RID: 542
		' (get) Token: 0x0600063F RID: 1599 RVA: 0x00035140 File Offset: 0x00033340
		' (set) Token: 0x06000640 RID: 1600 RVA: 0x00035158 File Offset: 0x00033358
		<Category("Options")>
		Public Property MaxLength As Integer
			Get
				Return Me._MaxLength
			End Get
			Set(value As Integer)
				Me._MaxLength = value
				If Me.TB IsNot Nothing Then
					Me.TB.MaxLength = value
				End If
			End Set
		End Property

		' Token: 0x1700021F RID: 543
		' (get) Token: 0x06000641 RID: 1601 RVA: 0x00035188 File Offset: 0x00033388
		' (set) Token: 0x06000642 RID: 1602 RVA: 0x0003519C File Offset: 0x0003339C
		<Category("Options")>
		Public Property [ReadOnly] As Boolean
			Get
				Return Me._ReadOnly
			End Get
			Set(value As Boolean)
				Me._ReadOnly = value
				If Me.TB IsNot Nothing Then
					Me.TB.[ReadOnly] = value
				End If
			End Set
		End Property

		' Token: 0x17000220 RID: 544
		' (get) Token: 0x06000643 RID: 1603 RVA: 0x000351CC File Offset: 0x000333CC
		' (set) Token: 0x06000644 RID: 1604 RVA: 0x000351E0 File Offset: 0x000333E0
		<Category("Options")>
		Public Property UseSystemPasswordChar As Boolean
			Get
				Return Me._UseSystemPasswordChar
			End Get
			Set(value As Boolean)
				Me._UseSystemPasswordChar = value
				If Me.TB IsNot Nothing Then
					Me.TB.UseSystemPasswordChar = value
				End If
			End Set
		End Property

		' Token: 0x17000221 RID: 545
		' (get) Token: 0x06000645 RID: 1605 RVA: 0x00035210 File Offset: 0x00033410
		' (set) Token: 0x06000646 RID: 1606 RVA: 0x00035224 File Offset: 0x00033424
		<Category("Options")>
		Public Property Multiline As Boolean
			Get
				Return Me._Multiline
			End Get
			Set(value As Boolean)
				Me._Multiline = value
				If Me.TB IsNot Nothing Then
					Me.TB.Multiline = value
					If value Then
						Me.TB.Height = Me.Height - 11
					Else
						Me.Height = Me.TB.Height + 11
					End If
				End If
			End Set
		End Property

		' Token: 0x17000222 RID: 546
		' (get) Token: 0x06000647 RID: 1607 RVA: 0x00035280 File Offset: 0x00033480
		' (set) Token: 0x06000648 RID: 1608 RVA: 0x00035298 File Offset: 0x00033498
		<Category("Options")>
		Public Overrides Property Text As String
			Get
				Return MyBase.Text
			End Get
			Set(value As String)
				MyBase.Text = value
				If Me.TB IsNot Nothing Then
					Me.TB.Text = value
				End If
			End Set
		End Property

		' Token: 0x17000223 RID: 547
		' (get) Token: 0x06000649 RID: 1609 RVA: 0x000352C8 File Offset: 0x000334C8
		' (set) Token: 0x0600064A RID: 1610 RVA: 0x000352E0 File Offset: 0x000334E0
		<Category("Options")>
		Public Overrides Property Font As Font
			Get
				Return MyBase.Font
			End Get
			Set(value As Font)
				MyBase.Font = value
				If Me.TB IsNot Nothing Then
					Me.TB.Font = value
					Dim tb As Control = Me.TB
					Dim location As Point = New Point(3, 5)
					tb.Location = location
					Me.TB.Width = Me.Width - 6
					If Not Me._Multiline Then
						Me.Height = Me.TB.Height + 11
					End If
				End If
			End Set
		End Property

		' Token: 0x0600064B RID: 1611 RVA: 0x00035358 File Offset: 0x00033558
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			If Not Me.Controls.Contains(Me.TB) Then
				Me.Controls.Add(Me.TB)
			End If
		End Sub

		' Token: 0x0600064C RID: 1612 RVA: 0x000036A0 File Offset: 0x000018A0
		Private Sub OnBaseTextChanged(s As Object, e As EventArgs)
			Me.Text = Me.TB.Text
		End Sub

		' Token: 0x0600064D RID: 1613 RVA: 0x00035394 File Offset: 0x00033594
		Private Sub OnBaseKeyDown(s As Object, e As KeyEventArgs)
			If e.Control Then
				If e.KeyCode = Keys.A Then
					Me.TB.SelectAll()
					e.SuppressKeyPress = True
				End If
			End If
			If e.Control Then
				If e.KeyCode = Keys.C Then
					Me.TB.Copy()
					e.SuppressKeyPress = True
				End If
			End If
		End Sub

		' Token: 0x0600064E RID: 1614 RVA: 0x000353F0 File Offset: 0x000335F0
		Protected Overrides Sub OnResize(e As EventArgs)
			Dim tb As Control = Me.TB
			Dim location As Point = New Point(5, 5)
			tb.Location = location
			Me.TB.Width = Me.Width - 10
			If Me._Multiline Then
				Me.TB.Height = Me.Height - 11
			Else
				Me.Height = Me.TB.Height + 11
			End If
			MyBase.OnResize(e)
		End Sub

		' Token: 0x17000224 RID: 548
		' (get) Token: 0x0600064F RID: 1615 RVA: 0x00035460 File Offset: 0x00033660
		' (set) Token: 0x06000650 RID: 1616 RVA: 0x000036B3 File Offset: 0x000018B3
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x17000225 RID: 549
		' (get) Token: 0x06000651 RID: 1617 RVA: 0x00035460 File Offset: 0x00033660
		' (set) Token: 0x06000652 RID: 1618 RVA: 0x000036B3 File Offset: 0x000018B3
		Public Overrides Property ForeColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x06000653 RID: 1619 RVA: 0x000036BC File Offset: 0x000018BC
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x06000654 RID: 1620 RVA: 0x000036D2 File Offset: 0x000018D2
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.TB.Focus()
			Me.Invalidate()
		End Sub

		' Token: 0x06000655 RID: 1621 RVA: 0x000036F4 File Offset: 0x000018F4
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.TB.Focus()
			Me.Invalidate()
		End Sub

		' Token: 0x06000656 RID: 1622 RVA: 0x00003716 File Offset: 0x00001916
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x06000657 RID: 1623 RVA: 0x00035478 File Offset: 0x00033678
		Public Sub New()
			FlatTextBox.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._TextAlign = HorizontalAlignment.Left
			Me._MaxLength = 32767
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._TextColor = Color.FromArgb(192, 192, 192)
			Me._BorderColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.Transparent
			Me.TB = New TextBox()
			Me.TB.Font = New Font("Segoe UI", 10F)
			Me.TB.Text = Me.Text
			Me.TB.BackColor = Me._BaseColor
			Me.TB.ForeColor = Me._TextColor
			Me.TB.MaxLength = Me._MaxLength
			Me.TB.Multiline = Me._Multiline
			Me.TB.[ReadOnly] = Me._ReadOnly
			Me.TB.UseSystemPasswordChar = Me._UseSystemPasswordChar
			Me.TB.BorderStyle = BorderStyle.None
			Dim tb As Control = Me.TB
			Dim location As Point = New Point(5, 5)
			tb.Location = location
			Me.TB.Width = Me.Width - 10
			Me.TB.Cursor = Cursors.IBeam
			If Me._Multiline Then
				Me.TB.Height = Me.Height - 11
			Else
				Me.Height = Me.TB.Height + 11
			End If
			AddHandler Me.TB.TextChanged, AddressOf Me.OnBaseTextChanged
			AddHandler Me.TB.KeyDown, AddressOf Me.OnBaseKeyDown
		End Sub

		' Token: 0x06000658 RID: 1624 RVA: 0x0003564C File Offset: 0x0003384C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Me.TB.BackColor = Me._BaseColor
			Me.TB.ForeColor = Me._TextColor
			g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000305 RID: 773
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000306 RID: 774
		Private W As Integer

		' Token: 0x04000307 RID: 775
		Private H As Integer

		' Token: 0x04000308 RID: 776
		Private State As MouseState

		' Token: 0x04000309 RID: 777
		<AccessedThroughProperty("TB")>
		Private _TB As TextBox

		' Token: 0x0400030A RID: 778
		Private _TextAlign As HorizontalAlignment

		' Token: 0x0400030B RID: 779
		Private _MaxLength As Integer

		' Token: 0x0400030C RID: 780
		Private _ReadOnly As Boolean

		' Token: 0x0400030D RID: 781
		Private _UseSystemPasswordChar As Boolean

		' Token: 0x0400030E RID: 782
		Private _Multiline As Boolean

		' Token: 0x0400030F RID: 783
		Private _BaseColor As Color

		' Token: 0x04000310 RID: 784
		Private _TextColor As Color

		' Token: 0x04000311 RID: 785
		Private _BorderColor As Color
	End Class
End Namespace
