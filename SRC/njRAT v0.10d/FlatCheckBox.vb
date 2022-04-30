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
	' Token: 0x02000031 RID: 49
	<DefaultEvent("CheckedChanged")>
	Friend Class FlatCheckBox
		Inherits Control

		' Token: 0x06000621 RID: 1569 RVA: 0x00034A00 File Offset: 0x00032C00
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatCheckBox.__ENCList
			SyncLock _ENCList
				If FlatCheckBox.__ENCList.Count = FlatCheckBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatCheckBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatCheckBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatCheckBox.__ENCList(num) = FlatCheckBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatCheckBox.__ENCList.RemoveRange(num, FlatCheckBox.__ENCList.Count - num)
					FlatCheckBox.__ENCList.Capacity = FlatCheckBox.__ENCList.Count
				End If
				FlatCheckBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000622 RID: 1570 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x17000218 RID: 536
		' (get) Token: 0x06000623 RID: 1571 RVA: 0x00034AE8 File Offset: 0x00032CE8
		' (set) Token: 0x06000624 RID: 1572 RVA: 0x000035D7 File Offset: 0x000017D7
		Public Property Checked As Boolean
			Get
				Return Me._Checked
			End Get
			Set(value As Boolean)
				Me._Checked = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x14000003 RID: 3
		' (add) Token: 0x06000625 RID: 1573 RVA: 0x000035E6 File Offset: 0x000017E6
		' (remove) Token: 0x06000626 RID: 1574 RVA: 0x000035FF File Offset: 0x000017FF
		<DebuggerNonUserCode()>
		Public Event CheckedChanged As FlatCheckBox.CheckedChangedEventHandler

		' Token: 0x06000627 RID: 1575 RVA: 0x00034AFC File Offset: 0x00032CFC
		Protected Overrides Sub OnClick(e As EventArgs)
			Me._Checked = Not Me._Checked
			Dim checkedChangedEvent As FlatCheckBox.CheckedChangedEventHandler = Me.CheckedChangedEvent
			If checkedChangedEvent IsNot Nothing Then
				checkedChangedEvent(Me)
			End If
			MyBase.OnClick(e)
		End Sub

		' Token: 0x17000219 RID: 537
		' (get) Token: 0x06000628 RID: 1576 RVA: 0x00034B38 File Offset: 0x00032D38
		' (set) Token: 0x06000629 RID: 1577 RVA: 0x00003618 File Offset: 0x00001818
		<Category("Options")>
		Public Property Options As FlatCheckBox._Options
			Get
				Return Me.O
			End Get
			Set(value As FlatCheckBox._Options)
				Me.O = value
			End Set
		End Property

		' Token: 0x0600062A RID: 1578 RVA: 0x00003550 File Offset: 0x00001750
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 22
		End Sub

		' Token: 0x1700021A RID: 538
		' (get) Token: 0x0600062B RID: 1579 RVA: 0x00034B50 File Offset: 0x00032D50
		' (set) Token: 0x0600062C RID: 1580 RVA: 0x00003621 File Offset: 0x00001821
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x1700021B RID: 539
		' (get) Token: 0x0600062D RID: 1581 RVA: 0x00034B68 File Offset: 0x00032D68
		' (set) Token: 0x0600062E RID: 1582 RVA: 0x0000362A File Offset: 0x0000182A
		<Category("Colors")>
		Public Property BorderColor As Color
			Get
				Return Me._BorderColor
			End Get
			Set(value As Color)
				Me._BorderColor = value
			End Set
		End Property

		' Token: 0x0600062F RID: 1583 RVA: 0x00003633 File Offset: 0x00001833
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x06000630 RID: 1584 RVA: 0x00003649 File Offset: 0x00001849
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000631 RID: 1585 RVA: 0x0000365F File Offset: 0x0000185F
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000632 RID: 1586 RVA: 0x00003675 File Offset: 0x00001875
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x06000633 RID: 1587 RVA: 0x00034B80 File Offset: 0x00032D80
		Public Sub New()
			FlatCheckBox.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._BorderColor = Color.FromArgb(0, 170, 220)
			Me._TextColor = Color.FromArgb(243, 243, 243)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.FromArgb(50, 50, 50)
			Me.Cursor = Cursors.Hand
			Me.Font = New Font("Segoe UI", 10F)
			Dim size As Size = New Size(112, 22)
			Me.Size = size
		End Sub

		' Token: 0x06000634 RID: 1588 RVA: 0x00034C38 File Offset: 0x00032E38
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(0, 2, Me.Height - 5, Me.Height - 5)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.O
				Case FlatCheckBox._Options.Style1
					g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
					Select Case Me.State
						Case MouseState.Over
							g.DrawRectangle(New Pen(Me._BorderColor), rect)
						Case MouseState.Down
							g.DrawRectangle(New Pen(Me._BorderColor), rect)
					End Select
					Dim r As Rectangle
					If Me.Checked Then
						Dim graphics As Graphics = g
						Dim s As String = "ü"
						Dim font As Font = New Font("Wingdings", 18F)
						Dim brush As Brush = New SolidBrush(Me._BorderColor)
						r = New Rectangle(5, 7, Me.H - 9, Me.H - 9)
						graphics.DrawString(s, font, brush, r, Helpers.CenterSF)
					End If
					If Not Me.Enabled Then
						g.FillRectangle(New SolidBrush(Color.FromArgb(54, 58, 61)), rect)
						Dim graphics2 As Graphics = g
						Dim text As String = Me.Text
						Dim font2 As Font = Me.Font
						Dim brush2 As Brush = New SolidBrush(Color.FromArgb(140, 142, 143))
						r = New Rectangle(20, 2, Me.W, Me.H)
						graphics2.DrawString(text, font2, brush2, r, Helpers.NearSF)
					End If
					Dim graphics3 As Graphics = g
					Dim text2 As String = Me.Text
					Dim font3 As Font = Me.Font
					Dim brush3 As Brush = New SolidBrush(Me._TextColor)
					r = New Rectangle(20, 2, Me.W, Me.H)
					graphics3.DrawString(text2, font3, brush3, r, Helpers.NearSF)
				Case FlatCheckBox._Options.Style2
					g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
					Select Case Me.State
						Case MouseState.Over
							g.DrawRectangle(New Pen(Me._BorderColor), rect)
							g.FillRectangle(New SolidBrush(Color.FromArgb(118, 213, 170)), rect)
						Case MouseState.Down
							g.DrawRectangle(New Pen(Me._BorderColor), rect)
							g.FillRectangle(New SolidBrush(Color.FromArgb(118, 213, 170)), rect)
					End Select
					Dim r As Rectangle
					If Me.Checked Then
						Dim graphics4 As Graphics = g
						Dim s2 As String = "ü"
						Dim font4 As Font = New Font("Wingdings", 18F)
						Dim brush4 As Brush = New SolidBrush(Me._BorderColor)
						r = New Rectangle(5, 7, Me.H - 9, Me.H - 9)
						graphics4.DrawString(s2, font4, brush4, r, Helpers.CenterSF)
					End If
					If Not Me.Enabled Then
						g.FillRectangle(New SolidBrush(Color.FromArgb(54, 58, 61)), rect)
						Dim graphics5 As Graphics = g
						Dim text3 As String = Me.Text
						Dim font5 As Font = Me.Font
						Dim brush5 As Brush = New SolidBrush(Color.FromArgb(48, 119, 91))
						r = New Rectangle(20, 2, Me.W, Me.H)
						graphics5.DrawString(text3, font5, brush5, r, Helpers.NearSF)
					End If
					Dim graphics6 As Graphics = g
					Dim text4 As String = Me.Text
					Dim font6 As Font = Me.Font
					Dim brush6 As Brush = New SolidBrush(Me._TextColor)
					r = New Rectangle(20, 2, Me.W, Me.H)
					graphics6.DrawString(text4, font6, brush6, r, Helpers.NearSF)
			End Select
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x040002F8 RID: 760
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002F9 RID: 761
		Private W As Integer

		' Token: 0x040002FA RID: 762
		Private H As Integer

		' Token: 0x040002FB RID: 763
		Private State As MouseState

		' Token: 0x040002FC RID: 764
		Private O As FlatCheckBox._Options

		' Token: 0x040002FD RID: 765
		Private _Checked As Boolean

		' Token: 0x040002FF RID: 767
		Private _BaseColor As Color

		' Token: 0x04000300 RID: 768
		Private _BorderColor As Color

		' Token: 0x04000301 RID: 769
		Private _TextColor As Color

		' Token: 0x02000032 RID: 50
		' (Invoke) Token: 0x06000638 RID: 1592
		Public Delegate Sub CheckedChangedEventHandler(sender As Object)

		' Token: 0x02000033 RID: 51
		<Flags()>
		Public Enum _Options
			' Token: 0x04000303 RID: 771
			Style1 = 0
			' Token: 0x04000304 RID: 772
			Style2 = 1
		End Enum
	End Class
End Namespace
