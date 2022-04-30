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
	' Token: 0x0200003F RID: 63
	<DefaultEvent("Scroll")>
	Friend Class FlatTrackBar
		Inherits Control

		' Token: 0x060006E6 RID: 1766 RVA: 0x00038690 File Offset: 0x00036890
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatTrackBar.__ENCList
			SyncLock _ENCList
				If FlatTrackBar.__ENCList.Count = FlatTrackBar.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatTrackBar.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatTrackBar.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatTrackBar.__ENCList(num) = FlatTrackBar.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatTrackBar.__ENCList.RemoveRange(num, FlatTrackBar.__ENCList.Count - num)
					FlatTrackBar.__ENCList.Capacity = FlatTrackBar.__ENCList.Count
				End If
				FlatTrackBar.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060006E7 RID: 1767 RVA: 0x00038778 File Offset: 0x00036978
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If e.Button = MouseButtons.Left Then
				Me.Val = CInt(Math.Round(CDbl((Me._Value - Me._Minimum)) / CDbl((Me._Maximum - Me._Minimum)) * CDbl((Me.Width - 11))))
				Me.Track = New Rectangle(Me.Val, 0, 10, 20)
				Me.Bool = Me.Track.Contains(e.Location)
			End If
		End Sub

		' Token: 0x060006E8 RID: 1768 RVA: 0x000387FC File Offset: 0x000369FC
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			If Me.Bool AndAlso e.X > -1 AndAlso e.X < Me.Width + 1 Then
				Me.Value = Me._Minimum + CInt(Math.Round(CDbl((Me._Maximum - Me._Minimum)) * (CDbl(e.X) / CDbl(Me.Width))))
			End If
		End Sub

		' Token: 0x060006E9 RID: 1769 RVA: 0x00003AD2 File Offset: 0x00001CD2
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.Bool = False
		End Sub

		' Token: 0x1700024F RID: 591
		' (get) Token: 0x060006EA RID: 1770 RVA: 0x00038864 File Offset: 0x00036A64
		' (set) Token: 0x060006EB RID: 1771 RVA: 0x00003AE2 File Offset: 0x00001CE2
		Public Property Style As FlatTrackBar._Style
			Get
				Return Me.Style_
			End Get
			Set(value As FlatTrackBar._Style)
				Me.Style_ = value
			End Set
		End Property

		' Token: 0x17000250 RID: 592
		' (get) Token: 0x060006EC RID: 1772 RVA: 0x0003887C File Offset: 0x00036A7C
		' (set) Token: 0x060006ED RID: 1773 RVA: 0x00003AEB File Offset: 0x00001CEB
		<Category("Colors")>
		Public Property TrackColor As Color
			Get
				Return Me._TrackColor
			End Get
			Set(value As Color)
				Me._TrackColor = value
			End Set
		End Property

		' Token: 0x17000251 RID: 593
		' (get) Token: 0x060006EE RID: 1774 RVA: 0x00038894 File Offset: 0x00036A94
		' (set) Token: 0x060006EF RID: 1775 RVA: 0x00003AF4 File Offset: 0x00001CF4
		<Category("Colors")>
		Public Property HatchColor As Color
			Get
				Return Me._HatchColor
			End Get
			Set(value As Color)
				Me._HatchColor = value
			End Set
		End Property

		' Token: 0x14000004 RID: 4
		' (add) Token: 0x060006F0 RID: 1776 RVA: 0x00003AFD File Offset: 0x00001CFD
		' (remove) Token: 0x060006F1 RID: 1777 RVA: 0x00003B16 File Offset: 0x00001D16
		<DebuggerNonUserCode()>
		Public Event Scroll As FlatTrackBar.ScrollEventHandler

		' Token: 0x17000252 RID: 594
		' (get) Token: 0x060006F2 RID: 1778 RVA: 0x000388AC File Offset: 0x00036AAC
		' (set) Token: 0x060006F3 RID: 1779 RVA: 0x000388BC File Offset: 0x00036ABC
		Public Property Minimum As Integer
			Get
				Return 0
			End Get
			Set(value As Integer)
				If value < 0 Then
				End If
				Me._Minimum = value
				If value > Me._Value Then
					Me._Value = value
				End If
				If value > Me._Maximum Then
					Me._Maximum = value
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000253 RID: 595
		' (get) Token: 0x060006F4 RID: 1780 RVA: 0x00038900 File Offset: 0x00036B00
		' (set) Token: 0x060006F5 RID: 1781 RVA: 0x00038918 File Offset: 0x00036B18
		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(value As Integer)
				If value < 0 Then
				End If
				Me._Maximum = value
				If value < Me._Value Then
					Me._Value = value
				End If
				If value < Me._Minimum Then
					Me._Minimum = value
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000254 RID: 596
		' (get) Token: 0x060006F6 RID: 1782 RVA: 0x0003895C File Offset: 0x00036B5C
		' (set) Token: 0x060006F7 RID: 1783 RVA: 0x00038974 File Offset: 0x00036B74
		Public Property Value As Integer
			Get
				Return Me._Value
			End Get
			Set(value As Integer)
				If value <> Me._Value Then
					If value > Me._Maximum OrElse value < Me._Minimum Then
					End If
					Me._Value = value
					Me.Invalidate()
					Dim scrollEvent As FlatTrackBar.ScrollEventHandler = Me.ScrollEvent
					If scrollEvent IsNot Nothing Then
						scrollEvent(Me)
					End If
				End If
			End Set
		End Property

		' Token: 0x17000255 RID: 597
		' (get) Token: 0x060006F8 RID: 1784 RVA: 0x000389C4 File Offset: 0x00036BC4
		' (set) Token: 0x060006F9 RID: 1785 RVA: 0x00003B2F File Offset: 0x00001D2F
		Public Property ShowValue As Boolean
			Get
				Return Me._ShowValue
			End Get
			Set(value As Boolean)
				Me._ShowValue = value
			End Set
		End Property

		' Token: 0x060006FA RID: 1786 RVA: 0x000389D8 File Offset: 0x00036BD8
		Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.KeyCode = Keys.Subtract Then
				If Me.Value <> 0 Then
					Me.Value -= 1
				End If
			ElseIf e.KeyCode = Keys.Add AndAlso Me.Value <> Me._Maximum Then
				Me.Value += 1
			End If
		End Sub

		' Token: 0x060006FB RID: 1787 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x060006FC RID: 1788 RVA: 0x00003B38 File Offset: 0x00001D38
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 23
		End Sub

		' Token: 0x060006FD RID: 1789 RVA: 0x00038A40 File Offset: 0x00036C40
		Public Sub New()
			FlatTrackBar.__ENCAddToList(Me)
			Me._Maximum = 10
			Me._ShowValue = False
			Me.BaseColor = Color.FromArgb(60, 60, 60)
			Me._TrackColor = Color.FromArgb(0, 170, 220)
			Me.SliderColor = Color.FromArgb(75, 75, 75)
			Me._HatchColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.Height = 18
			Me.BackColor = Color.FromArgb(50, 50, 50)
		End Sub

		' Token: 0x060006FE RID: 1790 RVA: 0x00038AE4 File Offset: 0x00036CE4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(1, 6, Me.W - 2, 8)
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim graphicsPath2 As GraphicsPath = New GraphicsPath()
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Me.Val = CInt(Math.Round(CDbl((Me._Value - Me._Minimum)) / CDbl((Me._Maximum - Me._Minimum)) * CDbl((Me.W - 10))))
			Me.Track = New Rectangle(Me.Val, 0, 10, 20)
			Me.Knob = New Rectangle(Me.Val, 4, 11, 14)
			graphicsPath.AddRectangle(rect)
			g.SetClip(graphicsPath)
			Dim graphics As Graphics = g
			Dim brush As Brush = New SolidBrush(Me.BaseColor)
			Dim rectangle As Rectangle = New Rectangle(0, 7, Me.W, 8)
			graphics.FillRectangle(brush, rectangle)
			Dim graphics2 As Graphics = g
			Dim brush2 As Brush = New SolidBrush(Me._TrackColor)
			rectangle = New Rectangle(0, 7, Me.Track.X + Me.Track.Width, 8)
			graphics2.FillRectangle(brush2, rectangle)
			g.ResetClip()
			Dim hatchBrush As HatchBrush = New HatchBrush(HatchStyle.Plaid, Me.HatchColor, Me._TrackColor)
			Dim graphics3 As Graphics = g
			Dim brush3 As Brush = hatchBrush
			rectangle = New Rectangle(-10, 7, Me.Track.X + Me.Track.Width, 8)
			graphics3.FillRectangle(brush3, rectangle)
			Select Case Me.Style
				Case FlatTrackBar._Style.Slider
					graphicsPath2.AddRectangle(Me.Track)
					g.FillPath(New SolidBrush(Me.SliderColor), graphicsPath2)
				Case FlatTrackBar._Style.Knob
					graphicsPath2.AddEllipse(Me.Knob)
					g.FillPath(New SolidBrush(Me.SliderColor), graphicsPath2)
			End Select
			If Me.ShowValue Then
				Dim graphics4 As Graphics = g
				Dim s As String = Conversions.ToString(Me.Value)
				Dim font As Font = New Font("Segoe UI", 8F)
				Dim white As Brush = Brushes.White
				rectangle = New Rectangle(1, 6, Me.W, Me.H)
				graphics4.DrawString(s, font, white, rectangle, New StringFormat() With { .Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Far })
			End If
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000358 RID: 856
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000359 RID: 857
		Private W As Integer

		' Token: 0x0400035A RID: 858
		Private H As Integer

		' Token: 0x0400035B RID: 859
		Private Val As Integer

		' Token: 0x0400035C RID: 860
		Private Bool As Boolean

		' Token: 0x0400035D RID: 861
		Private Track As Rectangle

		' Token: 0x0400035E RID: 862
		Private Knob As Rectangle

		' Token: 0x0400035F RID: 863
		Private Style_ As FlatTrackBar._Style

		' Token: 0x04000361 RID: 865
		Private _Minimum As Integer

		' Token: 0x04000362 RID: 866
		Private _Maximum As Integer

		' Token: 0x04000363 RID: 867
		Private _Value As Integer

		' Token: 0x04000364 RID: 868
		Private _ShowValue As Boolean

		' Token: 0x04000365 RID: 869
		Private BaseColor As Color

		' Token: 0x04000366 RID: 870
		Private _TrackColor As Color

		' Token: 0x04000367 RID: 871
		Private SliderColor As Color

		' Token: 0x04000368 RID: 872
		Private _HatchColor As Color

		' Token: 0x02000040 RID: 64
		<Flags()>
		Public Enum _Style
			' Token: 0x0400036A RID: 874
			Slider = 0
			' Token: 0x0400036B RID: 875
			Knob = 1
		End Enum

		' Token: 0x02000041 RID: 65
		' (Invoke) Token: 0x06000702 RID: 1794
		Public Delegate Sub ScrollEventHandler(sender As Object)
	End Class
End Namespace
