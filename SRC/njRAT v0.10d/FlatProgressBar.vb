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
	' Token: 0x02000038 RID: 56
	Friend Class FlatProgressBar
		Inherits Control

		' Token: 0x06000679 RID: 1657 RVA: 0x000366D4 File Offset: 0x000348D4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatProgressBar.__ENCList
			SyncLock _ENCList
				If FlatProgressBar.__ENCList.Count = FlatProgressBar.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatProgressBar.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatProgressBar.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatProgressBar.__ENCList(num) = FlatProgressBar.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatProgressBar.__ENCList.RemoveRange(num, FlatProgressBar.__ENCList.Count - num)
					FlatProgressBar.__ENCList.Capacity = FlatProgressBar.__ENCList.Count
				End If
				FlatProgressBar.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700022C RID: 556
		' (get) Token: 0x0600067A RID: 1658 RVA: 0x000367BC File Offset: 0x000349BC
		' (set) Token: 0x0600067B RID: 1659 RVA: 0x000367D4 File Offset: 0x000349D4
		<Category("Control")>
		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(value As Integer)
				If value < Me._Value Then
					Me._Value = value
				End If
				Me._Maximum = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700022D RID: 557
		' (get) Token: 0x0600067C RID: 1660 RVA: 0x00036804 File Offset: 0x00034A04
		' (set) Token: 0x0600067D RID: 1661 RVA: 0x0003682C File Offset: 0x00034A2C
		<Category("Control")>
		Public Property Value As Integer
			Get
				Dim value As Integer = Me._Value
				Dim result As Integer
				If value = 0 Then
					result = 0
				Else
					result = Me._Value
				End If
				Return result
			End Get
			Set(value As Integer)
				Dim num As Integer = value
				If num > Me._Maximum Then
					value = Me._Maximum
					Me.Invalidate()
				End If
				Me._Value = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700022E RID: 558
		' (get) Token: 0x0600067E RID: 1662 RVA: 0x00036864 File Offset: 0x00034A64
		' (set) Token: 0x0600067F RID: 1663 RVA: 0x00003871 File Offset: 0x00001A71
		<Category("Colors")>
		Public Property ProgressColor As Color
			Get
				Return Me._ProgressColor
			End Get
			Set(value As Color)
				Me._ProgressColor = value
			End Set
		End Property

		' Token: 0x1700022F RID: 559
		' (get) Token: 0x06000680 RID: 1664 RVA: 0x0003687C File Offset: 0x00034A7C
		' (set) Token: 0x06000681 RID: 1665 RVA: 0x0000387A File Offset: 0x00001A7A
		<Category("Colors")>
		Public Property DarkerProgress As Color
			Get
				Return Me._DarkerProgress
			End Get
			Set(value As Color)
				Me._DarkerProgress = value
			End Set
		End Property

		' Token: 0x06000682 RID: 1666 RVA: 0x00003777 File Offset: 0x00001977
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 42
		End Sub

		' Token: 0x06000683 RID: 1667 RVA: 0x00003883 File Offset: 0x00001A83
		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
			Me.Height = 42
		End Sub

		' Token: 0x06000684 RID: 1668 RVA: 0x00003893 File Offset: 0x00001A93
		Public Sub Increment(Amount As Integer)
			Me.Value += Amount
		End Sub

		' Token: 0x06000685 RID: 1669 RVA: 0x00036894 File Offset: 0x00034A94
		Public Sub New()
			FlatProgressBar.__ENCAddToList(Me)
			Me._Value = 0
			Me._Maximum = 100
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._ProgressColor = Color.FromArgb(0, 170, 220)
			Me._DarkerProgress = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.FromArgb(50, 50, 50)
			Me.Height = 30
		End Sub

		' Token: 0x06000686 RID: 1670 RVA: 0x00036928 File Offset: 0x00034B28
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(0, 24, Me.W, Me.H)
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim path As GraphicsPath = New GraphicsPath()
			Dim path2 As GraphicsPath = New GraphicsPath()
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Dim num As Integer = CInt(Math.Round(CDbl(Me._Value) / CDbl(Me._Maximum) * CDbl(Me.Width)))
			Dim value As Integer = Me.Value
			If value = 0 Then
				g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
				Dim graphics As Graphics = g
				Dim brush As Brush = New SolidBrush(Me._ProgressColor)
				Dim rectangle As Rectangle = New Rectangle(0, 24, num - 1, Me.H - 1)
				graphics.FillRectangle(brush, rectangle)
			ElseIf value = 100 Then
				g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
				Dim graphics2 As Graphics = g
				Dim brush2 As Brush = New SolidBrush(Me._ProgressColor)
				Dim rectangle As Rectangle = New Rectangle(0, 24, num - 1, Me.H - 1)
				graphics2.FillRectangle(brush2, rectangle)
			Else
				g.FillRectangle(New SolidBrush(Me._BaseColor), rect)
				Dim graphicsPath2 As GraphicsPath = graphicsPath
				Dim rectangle As Rectangle = New Rectangle(0, 24, num - 1, Me.H - 1)
				graphicsPath2.AddRectangle(rectangle)
				g.FillPath(New SolidBrush(Me._ProgressColor), graphicsPath)
				Dim hatchBrush As HatchBrush = New HatchBrush(HatchStyle.Plaid, Me._DarkerProgress, Me._ProgressColor)
				Dim graphics3 As Graphics = g
				Dim brush3 As Brush = hatchBrush
				rectangle = New Rectangle(0, 24, num - 1, Me.H - 1)
				graphics3.FillRectangle(brush3, rectangle)
				Dim rectangle2 As Rectangle = New Rectangle(num - 18, 0, 34, 16)
				path = Helpers.RoundRec(rectangle2, 4)
				g.FillPath(New SolidBrush(Me._BaseColor), path)
				path2 = Helpers.DrawArrow(num - 9, 16, True)
				g.FillPath(New SolidBrush(Me._BaseColor), path2)
				Dim graphics4 As Graphics = g
				Dim s As String = Conversions.ToString(Me.Value)
				Dim font As Font = New Font("Segoe UI", 10F)
				Dim brush4 As Brush = New SolidBrush(Me._ProgressColor)
				rectangle = New Rectangle(num - 11, -2, Me.W, Me.H)
				graphics4.DrawString(s, font, brush4, rectangle, Helpers.NearSF)
			End If
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x0400032A RID: 810
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400032B RID: 811
		Private W As Integer

		' Token: 0x0400032C RID: 812
		Private H As Integer

		' Token: 0x0400032D RID: 813
		Private _Value As Integer

		' Token: 0x0400032E RID: 814
		Private _Maximum As Integer

		' Token: 0x0400032F RID: 815
		Private _BaseColor As Color

		' Token: 0x04000330 RID: 816
		Private _ProgressColor As Color

		' Token: 0x04000331 RID: 817
		Private _DarkerProgress As Color
	End Class
End Namespace
