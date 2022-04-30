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
	' Token: 0x02000039 RID: 57
	Friend Class FlatComboBox
		Inherits ComboBox

		' Token: 0x06000688 RID: 1672 RVA: 0x00036BDC File Offset: 0x00034DDC
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatComboBox.__ENCList
			SyncLock _ENCList
				If FlatComboBox.__ENCList.Count = FlatComboBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatComboBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatComboBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatComboBox.__ENCList(num) = FlatComboBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatComboBox.__ENCList.RemoveRange(num, FlatComboBox.__ENCList.Count - num)
					FlatComboBox.__ENCList.Capacity = FlatComboBox.__ENCList.Count
				End If
				FlatComboBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000689 RID: 1673 RVA: 0x000038AF File Offset: 0x00001AAF
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x0600068A RID: 1674 RVA: 0x000038C5 File Offset: 0x00001AC5
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x0600068B RID: 1675 RVA: 0x000038DB File Offset: 0x00001ADB
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x0600068C RID: 1676 RVA: 0x000038F1 File Offset: 0x00001AF1
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x0600068D RID: 1677 RVA: 0x00036CC4 File Offset: 0x00034EC4
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.x = e.Location.X
			Me.y = e.Location.Y
			Me.Invalidate()
			If e.X < Me.Width - 41 Then
				Me.Cursor = Cursors.IBeam
			Else
				Me.Cursor = Cursors.Hand
			End If
		End Sub

		' Token: 0x0600068E RID: 1678 RVA: 0x00036D34 File Offset: 0x00034F34
		Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)
			MyBase.OnDrawItem(e)
			Me.Invalidate()
			If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
				Me.Invalidate()
			End If
		End Sub

		' Token: 0x0600068F RID: 1679 RVA: 0x00003907 File Offset: 0x00001B07
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Me.Invalidate()
		End Sub

		' Token: 0x17000230 RID: 560
		' (get) Token: 0x06000690 RID: 1680 RVA: 0x00036D64 File Offset: 0x00034F64
		' (set) Token: 0x06000691 RID: 1681 RVA: 0x00003916 File Offset: 0x00001B16
		<Category("Colors")>
		Public Property HoverColor As Color
			Get
				Return Me._HoverColor
			End Get
			Set(value As Color)
				Me._HoverColor = value
			End Set
		End Property

		' Token: 0x17000231 RID: 561
		' (get) Token: 0x06000692 RID: 1682 RVA: 0x00036D7C File Offset: 0x00034F7C
		' (set) Token: 0x06000693 RID: 1683 RVA: 0x00036D94 File Offset: 0x00034F94
		Private Property StartIndex As Integer
			Get
				Return Me._StartIndex
			End Get
			Set(value As Integer)
				Me._StartIndex = value
				Try
					MyBase.SelectedIndex = value
				Catch ex As Exception
				End Try
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x06000694 RID: 1684 RVA: 0x00036DD4 File Offset: 0x00034FD4
		Public Sub DrawItem_(sender As Object, e As DrawItemEventArgs)
			If e.Index >= 0 Then
				e.DrawBackground()
				e.DrawFocusRectangle()
				e.Graphics.SmoothingMode = SmoothingMode.HighQuality
				e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
				e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
				e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
				If(e.State And DrawItemState.Selected) = DrawItemState.Selected Then
					e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(0, 170, 220)), e.Bounds)
				Else
					e.Graphics.FillRectangle(New SolidBrush(Me._BaseColor), e.Bounds)
				End If
				Dim graphics As Graphics = e.Graphics
				Dim itemText As String = MyBase.GetItemText(RuntimeHelpers.GetObjectValue(MyBase.Items(e.Index)))
				Dim font As Font = New Font("Segoe UI", 8F)
				Dim white As Brush = Brushes.White
				Dim r As Rectangle = New Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Width, e.Bounds.Height)
				graphics.DrawString(itemText, font, white, r)
				e.Graphics.Dispose()
			End If
		End Sub

		' Token: 0x06000695 RID: 1685 RVA: 0x0000391F File Offset: 0x00001B1F
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 18
		End Sub

		' Token: 0x06000696 RID: 1686 RVA: 0x00036F0C File Offset: 0x0003510C
		Public Sub New()
			AddHandler MyBase.DrawItem, AddressOf Me.DrawItem_
			FlatComboBox.__ENCAddToList(Me)
			Me._StartIndex = 0
			Me.State = MouseState.None
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me._BGColor = Color.FromArgb(60, 60, 60)
			Me._HoverColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.DrawMode = DrawMode.OwnerDrawFixed
			Me.BackColor = Color.FromArgb(50, 50, 50)
			Me.ForeColor = Color.White
			Me.DropDownStyle = ComboBoxStyle.DropDownList
			Me.Cursor = Cursors.Hand
			Me.StartIndex = 0
			Me.ItemHeight = 18
			Me.Font = New Font("Segoe UI", 8F, FontStyle.Regular)
		End Sub

		' Token: 0x06000697 RID: 1687 RVA: 0x00036FEC File Offset: 0x000351EC
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim rect2 As Rectangle = New Rectangle(Me.W - 40, 0, Me.W, Me.H)
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			New GraphicsPath()
			Dim g As Graphics = Helpers.G
			g.Clear(Color.FromArgb(0, 170, 220))
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.FillRectangle(New SolidBrush(Me._BGColor), rect)
			graphicsPath.Reset()
			graphicsPath.AddRectangle(rect2)
			g.SetClip(graphicsPath)
			g.FillRectangle(New SolidBrush(Me._BaseColor), rect2)
			g.ResetClip()
			g.DrawLine(Pens.White, Me.W - 10, 6, Me.W - 30, 6)
			g.DrawLine(Pens.White, Me.W - 10, 12, Me.W - 30, 12)
			g.DrawLine(Pens.White, Me.W - 10, 18, Me.W - 30, 18)
			Dim graphics As Graphics = g
			Dim text As String = Me.Text
			Dim font As Font = Me.Font
			Dim white As Brush = Brushes.White
			Dim p As Point = New Point(4, 6)
			graphics.DrawString(text, font, white, p, Helpers.NearSF)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000332 RID: 818
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000333 RID: 819
		Private W As Integer

		' Token: 0x04000334 RID: 820
		Private H As Integer

		' Token: 0x04000335 RID: 821
		Private _StartIndex As Integer

		' Token: 0x04000336 RID: 822
		Private x As Integer

		' Token: 0x04000337 RID: 823
		Private y As Integer

		' Token: 0x04000338 RID: 824
		Private State As MouseState

		' Token: 0x04000339 RID: 825
		Private _BaseColor As Color

		' Token: 0x0400033A RID: 826
		Private _BGColor As Color

		' Token: 0x0400033B RID: 827
		Private _HoverColor As Color
	End Class
End Namespace
