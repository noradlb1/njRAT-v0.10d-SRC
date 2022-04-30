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
	' Token: 0x0200003A RID: 58
	Friend Class FlatStickyButton
		Inherits Control

		' Token: 0x06000699 RID: 1689 RVA: 0x000371B4 File Offset: 0x000353B4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatStickyButton.__ENCList
			SyncLock _ENCList
				If FlatStickyButton.__ENCList.Count = FlatStickyButton.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatStickyButton.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatStickyButton.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatStickyButton.__ENCList(num) = FlatStickyButton.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatStickyButton.__ENCList.RemoveRange(num, FlatStickyButton.__ENCList.Count - num)
					FlatStickyButton.__ENCList.Capacity = FlatStickyButton.__ENCList.Count
				End If
				FlatStickyButton.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x0600069A RID: 1690 RVA: 0x0000393C File Offset: 0x00001B3C
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x0600069B RID: 1691 RVA: 0x00003952 File Offset: 0x00001B52
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x0600069C RID: 1692 RVA: 0x00003968 File Offset: 0x00001B68
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x0600069D RID: 1693 RVA: 0x0000397E File Offset: 0x00001B7E
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x0600069E RID: 1694 RVA: 0x0003729C File Offset: 0x0003549C
		Private Function GetConnectedSides() As Boolean()
			Dim array As Boolean() = New Boolean() { False, False, False, False }
			Try
				For Each obj As Object In Me.Parent.Controls
					Dim control As Control = CType(obj, Control)
					If TypeOf control Is FlatStickyButton AndAlso Not(control Is Me Or Not Me.Rect.IntersectsWith(Me.Rect)) Then
						Dim num As Double = Math.Atan2(CDbl((Me.Left - control.Left)), CDbl((Me.Top - control.Top))) * 2.0 / 3.1415926535897931
						If CDbl((CLng(Math.Round(num)) / 1L)) = num Then
							array(CInt(Math.Round(num + 1.0))) = True
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return array
		End Function

		' Token: 0x17000232 RID: 562
		' (get) Token: 0x0600069F RID: 1695 RVA: 0x000373B8 File Offset: 0x000355B8
		Private ReadOnly Property Rect As Rectangle
			Get
				Dim result As Rectangle = New Rectangle(Me.Left, Me.Top, Me.Width, Me.Height)
				Return result
			End Get
		End Property

		' Token: 0x17000233 RID: 563
		' (get) Token: 0x060006A0 RID: 1696 RVA: 0x000373E8 File Offset: 0x000355E8
		' (set) Token: 0x060006A1 RID: 1697 RVA: 0x00003994 File Offset: 0x00001B94
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000234 RID: 564
		' (get) Token: 0x060006A2 RID: 1698 RVA: 0x00037400 File Offset: 0x00035600
		' (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000399D File Offset: 0x00001B9D
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x17000235 RID: 565
		' (get) Token: 0x060006A4 RID: 1700 RVA: 0x00037418 File Offset: 0x00035618
		' (set) Token: 0x060006A5 RID: 1701 RVA: 0x000039A6 File Offset: 0x00001BA6
		<Category("Options")>
		Public Property Rounded As Boolean
			Get
				Return Me._Rounded
			End Get
			Set(value As Boolean)
				Me._Rounded = value
			End Set
		End Property

		' Token: 0x060006A6 RID: 1702 RVA: 0x000039AF File Offset: 0x00001BAF
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
		End Sub

		' Token: 0x060006A7 RID: 1703 RVA: 0x000039B8 File Offset: 0x00001BB8
		Protected Overrides Sub OnCreateControl()
			MyBase.OnCreateControl()
		End Sub

		' Token: 0x060006A8 RID: 1704 RVA: 0x0003742C File Offset: 0x0003562C
		Public Sub New()
			FlatStickyButton.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me._Rounded = False
			Me._BaseColor = Color.FromArgb(0, 170, 220)
			Me._TextColor = Color.FromArgb(243, 243, 243)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Dim size As Size = New Size(106, 32)
			Me.Size = size
			Me.BackColor = Color.Transparent
			Me.Font = New Font("Segoe UI", 10F)
			Me.Cursor = Cursors.Hand
		End Sub

		' Token: 0x060006A9 RID: 1705 RVA: 0x000374D4 File Offset: 0x000356D4
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim path As GraphicsPath = New GraphicsPath()
			Dim connectedSides As Boolean() = Me.GetConnectedSides()
			Dim graphicsPath As GraphicsPath = Helpers.RoundRect(0F, 0F, CSng(Me.W), CSng(Me.H), 0.3F, Not(connectedSides(2) Or connectedSides(1)), Not(connectedSides(1) Or connectedSides(0)), Not(connectedSides(3) Or connectedSides(0)), Not(connectedSides(3) Or connectedSides(2)))
			Dim rectangle As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.State
				Case MouseState.None
					If Me.Rounded Then
						path = graphicsPath
						g.FillPath(New SolidBrush(Me._BaseColor), path)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					Else
						g.FillRectangle(New SolidBrush(Me._BaseColor), rectangle)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					End If
				Case MouseState.Over
					If Me.Rounded Then
						path = graphicsPath
						g.FillPath(New SolidBrush(Me._BaseColor), path)
						g.FillPath(New SolidBrush(Color.FromArgb(20, Color.White)), path)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					Else
						g.FillRectangle(New SolidBrush(Me._BaseColor), rectangle)
						g.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.White)), rectangle)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					End If
				Case MouseState.Down
					If Me.Rounded Then
						path = graphicsPath
						g.FillPath(New SolidBrush(Me._BaseColor), path)
						g.FillPath(New SolidBrush(Color.FromArgb(20, Color.Black)), path)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					Else
						g.FillRectangle(New SolidBrush(Me._BaseColor), rectangle)
						g.FillRectangle(New SolidBrush(Color.FromArgb(20, Color.Black)), rectangle)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					End If
			End Select
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x0400033C RID: 828
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400033D RID: 829
		Private W As Integer

		' Token: 0x0400033E RID: 830
		Private H As Integer

		' Token: 0x0400033F RID: 831
		Private State As MouseState

		' Token: 0x04000340 RID: 832
		Private _Rounded As Boolean

		' Token: 0x04000341 RID: 833
		Private _BaseColor As Color

		' Token: 0x04000342 RID: 834
		Private _TextColor As Color
	End Class
End Namespace
