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
	' Token: 0x02000027 RID: 39
	Friend Class FlatMax
		Inherits Control

		' Token: 0x060005BE RID: 1470 RVA: 0x00032D58 File Offset: 0x00030F58
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatMax.__ENCList
			SyncLock _ENCList
				If FlatMax.__ENCList.Count = FlatMax.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatMax.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatMax.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatMax.__ENCList(num) = FlatMax.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatMax.__ENCList.RemoveRange(num, FlatMax.__ENCList.Count - num)
					FlatMax.__ENCList.Capacity = FlatMax.__ENCList.Count
				End If
				FlatMax.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060005BF RID: 1471 RVA: 0x00003278 File Offset: 0x00001478
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005C0 RID: 1472 RVA: 0x0000328E File Offset: 0x0000148E
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060005C1 RID: 1473 RVA: 0x000032A4 File Offset: 0x000014A4
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060005C2 RID: 1474 RVA: 0x000032BA File Offset: 0x000014BA
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005C3 RID: 1475 RVA: 0x000032D0 File Offset: 0x000014D0
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.X
			Me.Invalidate()
		End Sub

		' Token: 0x060005C4 RID: 1476 RVA: 0x00032E40 File Offset: 0x00031040
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Select Case Me.FindForm().WindowState
				Case FormWindowState.Normal
					Me.FindForm().WindowState = FormWindowState.Maximized
				Case FormWindowState.Maximized
					Me.FindForm().WindowState = FormWindowState.Normal
			End Select
		End Sub

		' Token: 0x17000209 RID: 521
		' (get) Token: 0x060005C5 RID: 1477 RVA: 0x00032E90 File Offset: 0x00031090
		' (set) Token: 0x060005C6 RID: 1478 RVA: 0x000032EB File Offset: 0x000014EB
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x1700020A RID: 522
		' (get) Token: 0x060005C7 RID: 1479 RVA: 0x00032EA8 File Offset: 0x000310A8
		' (set) Token: 0x060005C8 RID: 1480 RVA: 0x000032F4 File Offset: 0x000014F4
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x060005C9 RID: 1481 RVA: 0x00032B3C File Offset: 0x00030D3C
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Dim size As Size = New Size(18, 18)
			Me.Size = size
		End Sub

		' Token: 0x060005CA RID: 1482 RVA: 0x00032EC0 File Offset: 0x000310C0
		Public Sub New()
			FlatMax.__ENCAddToList(Me)
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

		' Token: 0x060005CB RID: 1483 RVA: 0x00032F58 File Offset: 0x00031158
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
			If Me.FindForm().WindowState = FormWindowState.Maximized Then
				Dim graphics3 As Graphics = graphics2
				Dim s As String = "1"
				Dim font As Font = Me.Font
				Dim brush As Brush = New SolidBrush(Me.TextColor)
				Dim r As Rectangle = New Rectangle(1, 1, Me.Width, Me.Height)
				graphics3.DrawString(s, font, brush, r, Helpers.CenterSF)
			ElseIf Me.FindForm().WindowState = FormWindowState.Normal Then
				Dim graphics4 As Graphics = graphics2
				Dim s2 As String = "2"
				Dim font2 As Font = Me.Font
				Dim brush2 As Brush = New SolidBrush(Me.TextColor)
				Dim r As Rectangle = New Rectangle(1, 1, Me.Width, Me.Height)
				graphics4.DrawString(s2, font2, brush2, r, Helpers.CenterSF)
			End If
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

		' Token: 0x040002C3 RID: 707
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002C4 RID: 708
		Private State As MouseState

		' Token: 0x040002C5 RID: 709
		Private x As Integer

		' Token: 0x040002C6 RID: 710
		Private _BaseColor As Color

		' Token: 0x040002C7 RID: 711
		Private _TextColor As Color
	End Class
End Namespace
