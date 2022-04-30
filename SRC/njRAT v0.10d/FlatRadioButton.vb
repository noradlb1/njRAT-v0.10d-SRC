Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace NJRAT
	' Token: 0x0200002E RID: 46
	<DefaultEvent("CheckedChanged")>
	Friend Class FlatRadioButton
		Inherits Control

		' Token: 0x06000607 RID: 1543 RVA: 0x000343AC File Offset: 0x000325AC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatRadioButton.__ENCList
			SyncLock _ENCList
				If FlatRadioButton.__ENCList.Count = FlatRadioButton.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatRadioButton.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatRadioButton.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatRadioButton.__ENCList(num) = FlatRadioButton.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatRadioButton.__ENCList.RemoveRange(num, FlatRadioButton.__ENCList.Count - num)
					FlatRadioButton.__ENCList.Capacity = FlatRadioButton.__ENCList.Count
				End If
				FlatRadioButton.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x14000002 RID: 2
		' (add) Token: 0x06000608 RID: 1544 RVA: 0x00003507 File Offset: 0x00001707
		' (remove) Token: 0x06000609 RID: 1545 RVA: 0x00003520 File Offset: 0x00001720
		<DebuggerNonUserCode()>
		Public Event CheckedChanged As FlatRadioButton.CheckedChangedEventHandler

		' Token: 0x17000214 RID: 532
		' (get) Token: 0x0600060A RID: 1546 RVA: 0x00034494 File Offset: 0x00032694
		' (set) Token: 0x0600060B RID: 1547 RVA: 0x000344A8 File Offset: 0x000326A8
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
				Me.InvalidateControls()
				Dim checkedChangedEvent As FlatRadioButton.CheckedChangedEventHandler = Me.CheckedChangedEvent
				If checkedChangedEvent IsNot Nothing Then
					checkedChangedEvent(Me)
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x0600060C RID: 1548 RVA: 0x000344E0 File Offset: 0x000326E0
		Protected Overrides Sub OnClick(e As EventArgs)
			If Not Me._Checked Then
				Me.Checked = True
			End If
			MyBase.OnClick(e)
		End Sub

		' Token: 0x0600060D RID: 1549 RVA: 0x00034508 File Offset: 0x00032708
		Private Sub InvalidateControls()
			If Me.IsHandleCreated AndAlso Me._Checked Then
				Try
					For Each obj As Object In Me.Parent.Controls
						Dim control As Control = CType(obj, Control)
						If control IsNot Me AndAlso TypeOf control Is RadioButton Then
							CType(control, RadioButton).Checked = False
							Me.Invalidate()
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600060E RID: 1550 RVA: 0x00003539 File Offset: 0x00001739
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
			Me.InvalidateControls()
		End Sub

		' Token: 0x17000215 RID: 533
		' (get) Token: 0x0600060F RID: 1551 RVA: 0x00034598 File Offset: 0x00032798
		' (set) Token: 0x06000610 RID: 1552 RVA: 0x00003547 File Offset: 0x00001747
		<Category("Options")>
		Public Property Options As FlatRadioButton._Options
			Get
				Return Me.O
			End Get
			Set(value As FlatRadioButton._Options)
				Me.O = value
			End Set
		End Property

		' Token: 0x06000611 RID: 1553 RVA: 0x00003550 File Offset: 0x00001750
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 22
		End Sub

		' Token: 0x17000216 RID: 534
		' (get) Token: 0x06000612 RID: 1554 RVA: 0x000345B0 File Offset: 0x000327B0
		' (set) Token: 0x06000613 RID: 1555 RVA: 0x00003561 File Offset: 0x00001761
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000217 RID: 535
		' (get) Token: 0x06000614 RID: 1556 RVA: 0x000345C8 File Offset: 0x000327C8
		' (set) Token: 0x06000615 RID: 1557 RVA: 0x0000356A File Offset: 0x0000176A
		<Category("Colors")>
		Public Property BorderColor As Color
			Get
				Return Me._BorderColor
			End Get
			Set(value As Color)
				Me._BorderColor = value
			End Set
		End Property

		' Token: 0x06000616 RID: 1558 RVA: 0x00003573 File Offset: 0x00001773
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x06000617 RID: 1559 RVA: 0x00003589 File Offset: 0x00001789
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000618 RID: 1560 RVA: 0x0000359F File Offset: 0x0000179F
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000619 RID: 1561 RVA: 0x000035B5 File Offset: 0x000017B5
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x0600061A RID: 1562 RVA: 0x000345E0 File Offset: 0x000327E0
		Public Sub New()
			FlatRadioButton.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._BorderColor = Color.FromArgb(0, 170, 220)
			Me._TextColor = Color.FromArgb(243, 243, 243)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.Cursor = Cursors.Hand
			Dim size As Size = New Size(100, 22)
			Me.Size = size
			Me.BackColor = Color.FromArgb(50, 50, 50)
			Me.Font = New Font("Segoe UI", 10F)
		End Sub

		' Token: 0x0600061B RID: 1563 RVA: 0x00034698 File Offset: 0x00032898
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(0, 2, Me.Height - 5, Me.Height - 5)
			Dim rect2 As Rectangle = New Rectangle(4, 6, Me.H - 12, Me.H - 12)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.O
				Case FlatRadioButton._Options.Style1
					g.FillEllipse(New SolidBrush(Me._BaseColor), rect)
					Select Case Me.State
						Case MouseState.Over
							g.DrawEllipse(New Pen(Me._BorderColor), rect)
						Case MouseState.Down
							g.DrawEllipse(New Pen(Me._BorderColor), rect)
					End Select
					If Me.Checked Then
						g.FillEllipse(New SolidBrush(Me._BorderColor), rect2)
					End If
					Dim r As Rectangle
					If Not Me.Enabled Then
						g.FillEllipse(New SolidBrush(Color.FromArgb(54, 58, 61)), rect)
						Dim graphics As Graphics = g
						Dim text As String = Me.Text
						Dim font As Font = Me.Font
						Dim brush As Brush = New SolidBrush(Color.FromArgb(140, 142, 143))
						r = New Rectangle(20, 2, Me.W, Me.H)
						graphics.DrawString(text, font, brush, r, Helpers.NearSF)
					End If
					Dim graphics2 As Graphics = g
					Dim text2 As String = Me.Text
					Dim font2 As Font = Me.Font
					Dim brush2 As Brush = New SolidBrush(Me._TextColor)
					r = New Rectangle(20, 2, Me.W, Me.H)
					graphics2.DrawString(text2, font2, brush2, r, Helpers.NearSF)
				Case FlatRadioButton._Options.Style2
					g.FillEllipse(New SolidBrush(Me._BaseColor), rect)
					Select Case Me.State
						Case MouseState.Over
							g.DrawEllipse(New Pen(Me._BorderColor), rect)
							g.FillEllipse(New SolidBrush(Color.FromArgb(118, 213, 170)), rect)
						Case MouseState.Down
							g.DrawEllipse(New Pen(Me._BorderColor), rect)
							g.FillEllipse(New SolidBrush(Color.FromArgb(118, 213, 170)), rect)
					End Select
					If Me.Checked Then
						g.FillEllipse(New SolidBrush(Me._BorderColor), rect2)
					End If
					Dim r As Rectangle
					If Not Me.Enabled Then
						g.FillEllipse(New SolidBrush(Color.FromArgb(54, 58, 61)), rect)
						Dim graphics3 As Graphics = g
						Dim text3 As String = Me.Text
						Dim font3 As Font = Me.Font
						Dim brush3 As Brush = New SolidBrush(Color.FromArgb(48, 119, 91))
						r = New Rectangle(20, 2, Me.W, Me.H)
						graphics3.DrawString(text3, font3, brush3, r, Helpers.NearSF)
					End If
					Dim graphics4 As Graphics = g
					Dim text4 As String = Me.Text
					Dim font4 As Font = Me.Font
					Dim brush4 As Brush = New SolidBrush(Me._TextColor)
					r = New Rectangle(20, 2, Me.W, Me.H)
					graphics4.DrawString(text4, font4, brush4, r, Helpers.NearSF)
			End Select
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x040002EB RID: 747
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002EC RID: 748
		Private State As MouseState

		' Token: 0x040002ED RID: 749
		Private W As Integer

		' Token: 0x040002EE RID: 750
		Private H As Integer

		' Token: 0x040002EF RID: 751
		Private O As FlatRadioButton._Options

		' Token: 0x040002F0 RID: 752
		Private _Checked As Boolean

		' Token: 0x040002F2 RID: 754
		Private _BaseColor As Color

		' Token: 0x040002F3 RID: 755
		Private _BorderColor As Color

		' Token: 0x040002F4 RID: 756
		Private _TextColor As Color

		' Token: 0x0200002F RID: 47
		' (Invoke) Token: 0x0600061F RID: 1567
		Public Delegate Sub CheckedChangedEventHandler(sender As Object)

		' Token: 0x02000030 RID: 48
		<Flags()>
		Public Enum _Options
			' Token: 0x040002F6 RID: 758
			Style1 = 0
			' Token: 0x040002F7 RID: 759
			Style2 = 1
		End Enum
	End Class
End Namespace
