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
	' Token: 0x0200002A RID: 42
	Friend Class FlatButton
		Inherits Control

		' Token: 0x060005E4 RID: 1508 RVA: 0x0003372C File Offset: 0x0003192C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatButton.__ENCList
			SyncLock _ENCList
				If FlatButton.__ENCList.Count = FlatButton.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatButton.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatButton.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatButton.__ENCList(num) = FlatButton.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatButton.__ENCList.RemoveRange(num, FlatButton.__ENCList.Count - num)
					FlatButton.__ENCList.Capacity = FlatButton.__ENCList.Count
				End If
				FlatButton.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700020F RID: 527
		' (get) Token: 0x060005E5 RID: 1509 RVA: 0x00033814 File Offset: 0x00031A14
		' (set) Token: 0x060005E6 RID: 1510 RVA: 0x000033B8 File Offset: 0x000015B8
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000210 RID: 528
		' (get) Token: 0x060005E7 RID: 1511 RVA: 0x0003382C File Offset: 0x00031A2C
		' (set) Token: 0x060005E8 RID: 1512 RVA: 0x000033C1 File Offset: 0x000015C1
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x17000211 RID: 529
		' (get) Token: 0x060005E9 RID: 1513 RVA: 0x00033844 File Offset: 0x00031A44
		' (set) Token: 0x060005EA RID: 1514 RVA: 0x000033CA File Offset: 0x000015CA
		<Category("Options")>
		Public Property Rounded As Boolean
			Get
				Return Me._Rounded
			End Get
			Set(value As Boolean)
				Me._Rounded = value
			End Set
		End Property

		' Token: 0x060005EB RID: 1515 RVA: 0x000033D3 File Offset: 0x000015D3
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060005EC RID: 1516 RVA: 0x000033E9 File Offset: 0x000015E9
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005ED RID: 1517 RVA: 0x000033FF File Offset: 0x000015FF
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060005EE RID: 1518 RVA: 0x00003415 File Offset: 0x00001615
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060005EF RID: 1519 RVA: 0x00033858 File Offset: 0x00031A58
		Public Sub New()
			FlatButton.__ENCAddToList(Me)
			Me._Rounded = False
			Me.State = MouseState.None
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

		' Token: 0x060005F0 RID: 1520 RVA: 0x00033900 File Offset: 0x00031B00
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim path As GraphicsPath = New GraphicsPath()
			Dim rectangle As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.State
				Case MouseState.None
					If Me.Rounded Then
						path = Helpers.RoundRec(rectangle, 6)
						g.FillPath(New SolidBrush(Me._BaseColor), path)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					Else
						g.FillRectangle(New SolidBrush(Me._BaseColor), rectangle)
						g.DrawString(Me.Text, Me.Font, New SolidBrush(Me._TextColor), rectangle, Helpers.CenterSF)
					End If
				Case MouseState.Over
					If Me.Rounded Then
						path = Helpers.RoundRec(rectangle, 6)
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
						path = Helpers.RoundRec(rectangle, 6)
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

		' Token: 0x040002D2 RID: 722
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002D3 RID: 723
		Private W As Integer

		' Token: 0x040002D4 RID: 724
		Private H As Integer

		' Token: 0x040002D5 RID: 725
		Private _Rounded As Boolean

		' Token: 0x040002D6 RID: 726
		Private State As MouseState

		' Token: 0x040002D7 RID: 727
		Private _BaseColor As Color

		' Token: 0x040002D8 RID: 728
		Private _TextColor As Color
	End Class
End Namespace
