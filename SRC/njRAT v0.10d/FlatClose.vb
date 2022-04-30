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
	' Token: 0x02000026 RID: 38
	Friend Class FlatClose
		Inherits Control

		' Token: 0x060005AF RID: 1455 RVA: 0x00032A54 File Offset: 0x00030C54
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatClose.__ENCList
			SyncLock _ENCList
				If FlatClose.__ENCList.Count = FlatClose.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatClose.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatClose.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatClose.__ENCList(num) = FlatClose.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatClose.__ENCList.RemoveRange(num, FlatClose.__ENCList.Count - num)
					FlatClose.__ENCList.Capacity = FlatClose.__ENCList.Count
				End If
				FlatClose.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005B0 RID: 1456 RVA: 0x000031D8 File Offset: 0x000013D8
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005B1 RID: 1457 RVA: 0x000031EE File Offset: 0x000013EE
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060005B2 RID: 1458 RVA: 0x00003204 File Offset: 0x00001404
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060005B3 RID: 1459 RVA: 0x0000321A File Offset: 0x0000141A
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005B4 RID: 1460 RVA: 0x00003230 File Offset: 0x00001430
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			Me.Invalidate()
		End Sub

		' Token: 0x060005B5 RID: 1461 RVA: 0x0000324B File Offset: 0x0000144B
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Environment.[Exit](0)
		End Sub

		' Token: 0x060005B6 RID: 1462 RVA: 0x00032B3C File Offset: 0x00030D3C
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Dim size As Size = New Size(18, 18)
			Me.Size = size
		End Sub

		' Token: 0x17000207 RID: 519
		' (get) Token: 0x060005B7 RID: 1463 RVA: 0x00032B64 File Offset: 0x00030D64
		' (set) Token: 0x060005B8 RID: 1464 RVA: 0x0000325A File Offset: 0x0000145A
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000208 RID: 520
		' (get) Token: 0x060005B9 RID: 1465 RVA: 0x00032B7C File Offset: 0x00030D7C
		' (set) Token: 0x060005BA RID: 1466 RVA: 0x00003263 File Offset: 0x00001463
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x060005BB RID: 1467 RVA: 0x00032B94 File Offset: 0x00030D94
		Public Sub New()
			FlatClose.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(50, 50, 50)
			Me._TextColor = Color.FromArgb(220, 220, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.White
			Dim size As Size = New Size(18, 18)
			Me.Size = size
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Font = New Font("Marlett", 12F)
		End Sub

		' Token: 0x060005BC RID: 1468 RVA: 0x00032C2C File Offset: 0x00030E2C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Dim bitmap As Bitmap = New Bitmap(Me.Width, Me.Height)
			Dim graphics As Graphics = Graphics.FromImage(bitmap)
			Dim rect As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
			Dim graphics2 As Graphics = graphics
			graphics2.SmoothingMode = SmoothingMode.HighQuality
			graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality
			graphics2.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			graphics2.Clear(Me.BackColor)
			graphics2.FillRectangle(New SolidBrush(Me._BaseColor), rect)
			Dim graphics3 As Graphics = graphics2
			Dim s As String = "r"
			Dim font As Font = Me.Font
			Dim brush As Brush = New SolidBrush(Me.TextColor)
			Dim r As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height)
			graphics3.DrawString(s, font, brush, r, Helpers.CenterSF)
			Select Case Me.State
				Case MouseState.Over
					graphics2.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.White)), rect)
				Case MouseState.Down
					graphics2.FillRectangle(New SolidBrush(Color.FromArgb(30, Color.Black)), rect)
			End Select
			MyBase.OnPaint(e)
			graphics.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(bitmap, 0, 0)
			bitmap.Dispose()
		End Sub

		' Token: 0x040002BE RID: 702
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002BF RID: 703
		Private State As MouseState

		' Token: 0x040002C0 RID: 704
		Private x As Integer

		' Token: 0x040002C1 RID: 705
		Private _BaseColor As Color

		' Token: 0x040002C2 RID: 706
		Private _TextColor As Color
	End Class
End Namespace
