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
	' Token: 0x0200003B RID: 59
	Friend Class FlatNumeric
		Inherits Control

		' Token: 0x060006AB RID: 1707 RVA: 0x00037814 File Offset: 0x00035A14
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatNumeric.__ENCList
			SyncLock _ENCList
				If FlatNumeric.__ENCList.Count = FlatNumeric.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatNumeric.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatNumeric.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatNumeric.__ENCList(num) = FlatNumeric.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatNumeric.__ENCList.RemoveRange(num, FlatNumeric.__ENCList.Count - num)
					FlatNumeric.__ENCList.Capacity = FlatNumeric.__ENCList.Count
				End If
				FlatNumeric.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000236 RID: 566
		' (get) Token: 0x060006AC RID: 1708 RVA: 0x000378FC File Offset: 0x00035AFC
		' (set) Token: 0x060006AD RID: 1709 RVA: 0x00037914 File Offset: 0x00035B14
		Public Property Value As Long
			Get
				Return Me._Value
			End Get
			Set(value As Long)
				If value <= Me._Max And value >= Me._Min Then
					Me._Value = value
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000237 RID: 567
		' (get) Token: 0x060006AE RID: 1710 RVA: 0x0003794C File Offset: 0x00035B4C
		' (set) Token: 0x060006AF RID: 1711 RVA: 0x00037964 File Offset: 0x00035B64
		Public Property Maximum As Long
			Get
				Return Me._Max
			End Get
			Set(value As Long)
				If value > Me._Min Then
					Me._Max = value
				End If
				If Me._Value > Me._Max Then
					Me._Value = Me._Max
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000238 RID: 568
		' (get) Token: 0x060006B0 RID: 1712 RVA: 0x000379A8 File Offset: 0x00035BA8
		' (set) Token: 0x060006B1 RID: 1713 RVA: 0x000379C0 File Offset: 0x00035BC0
		Public Property Minimum As Long
			Get
				Return Me._Min
			End Get
			Set(value As Long)
				If value < Me._Max Then
					Me._Min = value
				End If
				If Me._Value < Me._Min Then
					Me._Value = Me.Minimum
				End If
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x060006B2 RID: 1714 RVA: 0x00037A04 File Offset: 0x00035C04
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.Location.X
			Me.y = e.Location.Y
			Me.Invalidate()
			If e.X < Me.Width - 23 Then
				Me.Cursor = Cursors.IBeam
			Else
				Me.Cursor = Cursors.Hand
			End If
		End Sub

		' Token: 0x060006B3 RID: 1715 RVA: 0x00037A74 File Offset: 0x00035C74
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			If Me.x > Me.Width - 21 AndAlso Me.x < Me.Width - 3 Then
				If Me.y < 15 Then
					If Me.Value + 1L <= Me._Max Then
						Me._Value += 1L
					End If
				ElseIf Me.Value - 1L >= Me._Min Then
					Me._Value -= 1L
				End If
			Else
				Me.Bool = Not Me.Bool
				Me.Focus()
			End If
			Me.Invalidate()
		End Sub

		' Token: 0x060006B4 RID: 1716 RVA: 0x00037B40 File Offset: 0x00035D40
		Protected Overrides Sub OnKeyPress(e As KeyPressEventArgs)
			MyBase.OnKeyPress(e)
			Try
				If Me.Bool Then
					Me._Value = Conversions.ToLong(Conversions.ToString(Me._Value) + e.KeyChar.ToString())
				End If
				If Me._Value > Me._Max Then
					Me._Value = Me._Max
				End If
				Me.Invalidate()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060006B5 RID: 1717 RVA: 0x00037BC8 File Offset: 0x00035DC8
		Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			If e.KeyCode = Keys.Back Then
				Me.Value = 0L
			End If
		End Sub

		' Token: 0x060006B6 RID: 1718 RVA: 0x000039CC File Offset: 0x00001BCC
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 30
		End Sub

		' Token: 0x17000239 RID: 569
		' (get) Token: 0x060006B7 RID: 1719 RVA: 0x00037BF8 File Offset: 0x00035DF8
		' (set) Token: 0x060006B8 RID: 1720 RVA: 0x000039DD File Offset: 0x00001BDD
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x1700023A RID: 570
		' (get) Token: 0x060006B9 RID: 1721 RVA: 0x00037C10 File Offset: 0x00035E10
		' (set) Token: 0x060006BA RID: 1722 RVA: 0x000039E6 File Offset: 0x00001BE6
		<Category("Colors")>
		Public Property ButtonColor As Color
			Get
				Return Me._ButtonColor
			End Get
			Set(value As Color)
				Me._ButtonColor = value
			End Set
		End Property

		' Token: 0x060006BB RID: 1723 RVA: 0x00037C28 File Offset: 0x00035E28
		Public Sub New()
			FlatNumeric.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._ButtonColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 10F)
			Me.BackColor = Color.FromArgb(60, 70, 73)
			Me.ForeColor = Color.White
			Me._Min = 0L
			Me._Max = 9999999L
		End Sub

		' Token: 0x060006BC RID: 1724 RVA: 0x00037CD4 File Offset: 0x00035ED4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
			Dim graphics As Graphics = g
			Dim brush As Brush = New SolidBrush(Me._ButtonColor)
			Dim rectangle As Rectangle = New Rectangle(Me.Width - 24, 0, 24, Me.H)
			graphics.FillRectangle(brush, rectangle)
			Dim graphics2 As Graphics = g
			Dim s As String = "+"
			Dim font As Font = New Font("Segoe UI", 12F)
			Dim white As Brush = Brushes.White
			Dim p As Point = New Point(Me.Width - 12, 8)
			graphics2.DrawString(s, font, white, p, Helpers.CenterSF)
			Dim graphics3 As Graphics = g
			Dim s2 As String = "-"
			Dim font2 As Font = New Font("Segoe UI", 10F, FontStyle.Bold)
			Dim white2 As Brush = Brushes.White
			p = New Point(Me.Width - 12, 22)
			graphics3.DrawString(s2, font2, white2, p, Helpers.CenterSF)
			Dim graphics4 As Graphics = g
			Dim s3 As String = Conversions.ToString(Me.Value)
			Dim font3 As Font = Me.Font
			Dim white3 As Brush = Brushes.White
			rectangle = New Rectangle(5, 1, Me.W, Me.H)
			graphics4.DrawString(s3, font3, white3, rectangle, New StringFormat() With { .LineAlignment = StringAlignment.Center })
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000343 RID: 835
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000344 RID: 836
		Private W As Integer

		' Token: 0x04000345 RID: 837
		Private H As Integer

		' Token: 0x04000346 RID: 838
		Private State As MouseState

		' Token: 0x04000347 RID: 839
		Private x As Integer

		' Token: 0x04000348 RID: 840
		Private y As Integer

		' Token: 0x04000349 RID: 841
		Private _Value As Long

		' Token: 0x0400034A RID: 842
		Private _Min As Long

		' Token: 0x0400034B RID: 843
		Private _Max As Long

		' Token: 0x0400034C RID: 844
		Private Bool As Boolean

		' Token: 0x0400034D RID: 845
		Private _BaseColor As Color

		' Token: 0x0400034E RID: 846
		Private _ButtonColor As Color
	End Class
End Namespace
