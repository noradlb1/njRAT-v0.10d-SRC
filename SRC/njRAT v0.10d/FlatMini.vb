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
	' Token: 0x02000028 RID: 40
	Friend Class FlatMini
		Inherits Control

		' Token: 0x060005CD RID: 1485 RVA: 0x000330E0 File Offset: 0x000312E0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatMini.__ENCList
			SyncLock _ENCList
				If FlatMini.__ENCList.Count = FlatMini.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatMini.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatMini.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatMini.__ENCList(num) = FlatMini.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatMini.__ENCList.RemoveRange(num, FlatMini.__ENCList.Count - num)
					FlatMini.__ENCList.Capacity = FlatMini.__ENCList.Count
				End If
				FlatMini.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005CE RID: 1486 RVA: 0x00003309 File Offset: 0x00001509
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005CF RID: 1487 RVA: 0x0000331F File Offset: 0x0000151F
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060005D0 RID: 1488 RVA: 0x00003335 File Offset: 0x00001535
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060005D1 RID: 1489 RVA: 0x0000334B File Offset: 0x0000154B
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005D2 RID: 1490 RVA: 0x00003361 File Offset: 0x00001561
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			Me.Invalidate()
		End Sub

		' Token: 0x060005D3 RID: 1491 RVA: 0x000331C8 File Offset: 0x000313C8
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Select Case Me.FindForm().WindowState
				Case FormWindowState.Normal
					Me.FindForm().WindowState = FormWindowState.Minimized
				Case FormWindowState.Maximized
					Me.FindForm().WindowState = FormWindowState.Minimized
			End Select
		End Sub

		' Token: 0x1700020B RID: 523
		' (get) Token: 0x060005D4 RID: 1492 RVA: 0x00033218 File Offset: 0x00031418
		' (set) Token: 0x060005D5 RID: 1493 RVA: 0x0000337C File Offset: 0x0000157C
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x1700020C RID: 524
		' (get) Token: 0x060005D6 RID: 1494 RVA: 0x00033230 File Offset: 0x00031430
		' (set) Token: 0x060005D7 RID: 1495 RVA: 0x00003385 File Offset: 0x00001585
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x060005D8 RID: 1496 RVA: 0x00032B3C File Offset: 0x00030D3C
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Dim size As Size = New Size(18, 18)
			Me.Size = size
		End Sub

		' Token: 0x060005D9 RID: 1497 RVA: 0x00033248 File Offset: 0x00031448
		Public Sub New()
			FlatMini.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(50, 50, 50)
			Me._TextColor = Color.FromArgb(243, 243, 243)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.White
			Dim size As Size = New Size(18, 18)
			Me.Size = size
			Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Right)
			Me.Font = New Font("Marlett", 12F)
		End Sub

		' Token: 0x060005DA RID: 1498 RVA: 0x000332E0 File Offset: 0x000314E0
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
			Dim s As String = "0"
			Dim font As Font = Me.Font
			Dim brush As Brush = New SolidBrush(Me.TextColor)
			Dim r As Rectangle = New Rectangle(2, 1, Me.Width, Me.Height)
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

		' Token: 0x040002C8 RID: 712
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002C9 RID: 713
		Private State As MouseState

		' Token: 0x040002CA RID: 714
		Private x As Integer

		' Token: 0x040002CB RID: 715
		Private _BaseColor As Color

		' Token: 0x040002CC RID: 716
		Private _TextColor As Color
	End Class
End Namespace
