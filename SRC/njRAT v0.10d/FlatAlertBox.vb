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
	' Token: 0x02000036 RID: 54
	Friend Class FlatAlertBox
		Inherits Control

		' Token: 0x06000663 RID: 1635 RVA: 0x00035DF0 File Offset: 0x00033FF0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatAlertBox.__ENCList
			SyncLock _ENCList
				If FlatAlertBox.__ENCList.Count = FlatAlertBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatAlertBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatAlertBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatAlertBox.__ENCList(num) = FlatAlertBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatAlertBox.__ENCList.RemoveRange(num, FlatAlertBox.__ENCList.Count - num)
					FlatAlertBox.__ENCList.Capacity = FlatAlertBox.__ENCList.Count
				End If
				FlatAlertBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000228 RID: 552
		' (get) Token: 0x06000664 RID: 1636 RVA: 0x00035ED8 File Offset: 0x000340D8
		' (set) Token: 0x06000665 RID: 1637 RVA: 0x00035EF0 File Offset: 0x000340F0
		Private Overridable Property T As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._T
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.T_Tick
				If Me._T IsNot Nothing Then
					RemoveHandler Me._T.Tick, value2
				End If
				Me._T = value
				If Me._T IsNot Nothing Then
					AddHandler Me._T.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x17000229 RID: 553
		' (get) Token: 0x06000666 RID: 1638 RVA: 0x00035F48 File Offset: 0x00034148
		' (set) Token: 0x06000667 RID: 1639 RVA: 0x00003765 File Offset: 0x00001965
		<Category("Options")>
		Public Property kind As FlatAlertBox._Kind
			Get
				Return Me.K
			End Get
			Set(value As FlatAlertBox._Kind)
				Me.K = value
			End Set
		End Property

		' Token: 0x1700022A RID: 554
		' (get) Token: 0x06000668 RID: 1640 RVA: 0x00035280 File Offset: 0x00033480
		' (set) Token: 0x06000669 RID: 1641 RVA: 0x00035F60 File Offset: 0x00034160
		<Category("Options")>
		Public Overrides Property Text As String
			Get
				Return MyBase.Text
			End Get
			Set(value As String)
				MyBase.Text = value
				If Me._Text <> Nothing Then
					Me._Text = value
				End If
			End Set
		End Property

		' Token: 0x1700022B RID: 555
		' (get) Token: 0x0600066A RID: 1642 RVA: 0x00035F8C File Offset: 0x0003418C
		' (set) Token: 0x0600066B RID: 1643 RVA: 0x0000376E File Offset: 0x0000196E
		<Category("Options")>
		Public Property Visible As Boolean
			Get
				Return Not MyBase.Visible
			End Get
			Set(value As Boolean)
				MyBase.Visible = value
			End Set
		End Property

		' Token: 0x0600066C RID: 1644 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x0600066D RID: 1645 RVA: 0x00003777 File Offset: 0x00001977
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.Height = 42
		End Sub

		' Token: 0x0600066E RID: 1646 RVA: 0x00003788 File Offset: 0x00001988
		Public Sub ShowControl(Kind As FlatAlertBox._Kind, Str As String, Interval As Integer)
			Me.K = Kind
			Me.Text = Str
			Me.Visible = True
			Me.T = New Timer()
			Me.T.Interval = Interval
			Me.T.Enabled = True
		End Sub

		' Token: 0x0600066F RID: 1647 RVA: 0x000037C2 File Offset: 0x000019C2
		Private Sub T_Tick(sender As Object, e As EventArgs)
			Me.Visible = False
			Me.T.Enabled = False
			Me.T.Dispose()
		End Sub

		' Token: 0x06000670 RID: 1648 RVA: 0x000037E2 File Offset: 0x000019E2
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x06000671 RID: 1649 RVA: 0x000037F8 File Offset: 0x000019F8
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000672 RID: 1650 RVA: 0x0000380E File Offset: 0x00001A0E
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x06000673 RID: 1651 RVA: 0x00003824 File Offset: 0x00001A24
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x06000674 RID: 1652 RVA: 0x0000383A File Offset: 0x00001A3A
		Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
			MyBase.OnMouseMove(e)
			Me.X = e.X
			Me.Invalidate()
		End Sub

		' Token: 0x06000675 RID: 1653 RVA: 0x00003855 File Offset: 0x00001A55
		Protected Overrides Sub OnClick(e As EventArgs)
			MyBase.OnClick(e)
			Me.Visible = False
		End Sub

		' Token: 0x06000676 RID: 1654 RVA: 0x00035FA4 File Offset: 0x000341A4
		Public Sub New()
			FlatAlertBox.__ENCAddToList(Me)
			Me.State = MouseState.None
			Me.SuccessColor = Color.FromArgb(60, 85, 79)
			Me.SuccessText = Color.FromArgb(35, 169, 110)
			Me.ErrorColor = Color.FromArgb(87, 71, 71)
			Me.ErrorText = Color.FromArgb(254, 142, 122)
			Me.InfoColor = Color.FromArgb(70, 91, 94)
			Me.InfoText = Color.FromArgb(97, 185, 186)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.FromArgb(60, 70, 73)
			Dim size As Size = New Size(576, 42)
			Me.Size = size
			Dim location As Point = New Point(10, 61)
			Me.Location = location
			Me.Font = New Font("Segoe UI", 10F)
			Me.Cursor = Cursors.Hand
		End Sub

		' Token: 0x06000677 RID: 1655 RVA: 0x000360A8 File Offset: 0x000342A8
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			Select Case Me.K
				Case FlatAlertBox._Kind.Success
					g.FillRectangle(New SolidBrush(Me.SuccessColor), rect)
					Dim graphics As Graphics = g
					Dim brush As Brush = New SolidBrush(Me.SuccessText)
					Dim rectangle As Rectangle = New Rectangle(8, 9, 24, 24)
					graphics.FillEllipse(brush, rectangle)
					Dim graphics2 As Graphics = g
					Dim brush2 As Brush = New SolidBrush(Me.SuccessColor)
					rectangle = New Rectangle(10, 11, 20, 20)
					graphics2.FillEllipse(brush2, rectangle)
					Dim graphics3 As Graphics = g
					Dim s As String = "ü"
					Dim font As Font = New Font("Wingdings", 22F)
					Dim brush3 As Brush = New SolidBrush(Me.SuccessText)
					rectangle = New Rectangle(7, 7, Me.W, Me.H)
					graphics3.DrawString(s, font, brush3, rectangle, Helpers.NearSF)
					Dim graphics4 As Graphics = g
					Dim text As String = Me.Text
					Dim font2 As Font = Me.Font
					Dim brush4 As Brush = New SolidBrush(Me.SuccessText)
					rectangle = New Rectangle(48, 12, Me.W, Me.H)
					graphics4.DrawString(text, font2, brush4, rectangle, Helpers.NearSF)
					Dim graphics5 As Graphics = g
					Dim brush5 As Brush = New SolidBrush(Color.FromArgb(35, Color.Black))
					rectangle = New Rectangle(Me.W - 30, Me.H - 29, 17, 17)
					graphics5.FillEllipse(brush5, rectangle)
					Dim graphics6 As Graphics = g
					Dim s2 As String = "r"
					Dim font3 As Font = New Font("Marlett", 8F)
					Dim brush6 As Brush = New SolidBrush(Me.SuccessColor)
					rectangle = New Rectangle(Me.W - 28, 16, Me.W, Me.H)
					graphics6.DrawString(s2, font3, brush6, rectangle, Helpers.NearSF)
					Dim state As MouseState = Me.State
					If state = MouseState.Over Then
						Dim graphics7 As Graphics = g
						Dim s3 As String = "r"
						Dim font4 As Font = New Font("Marlett", 8F)
						Dim brush7 As Brush = New SolidBrush(Color.FromArgb(25, Color.White))
						rectangle = New Rectangle(Me.W - 28, 16, Me.W, Me.H)
						graphics7.DrawString(s3, font4, brush7, rectangle, Helpers.NearSF)
					End If
				Case FlatAlertBox._Kind.[Error]
					g.FillRectangle(New SolidBrush(Me.ErrorColor), rect)
					Dim graphics8 As Graphics = g
					Dim brush8 As Brush = New SolidBrush(Me.ErrorText)
					Dim rectangle As Rectangle = New Rectangle(8, 9, 24, 24)
					graphics8.FillEllipse(brush8, rectangle)
					Dim graphics9 As Graphics = g
					Dim brush9 As Brush = New SolidBrush(Me.ErrorColor)
					rectangle = New Rectangle(10, 11, 20, 20)
					graphics9.FillEllipse(brush9, rectangle)
					Dim graphics10 As Graphics = g
					Dim s4 As String = "r"
					Dim font5 As Font = New Font("Marlett", 16F)
					Dim brush10 As Brush = New SolidBrush(Me.ErrorText)
					rectangle = New Rectangle(6, 11, Me.W, Me.H)
					graphics10.DrawString(s4, font5, brush10, rectangle, Helpers.NearSF)
					Dim graphics11 As Graphics = g
					Dim text2 As String = Me.Text
					Dim font6 As Font = Me.Font
					Dim brush11 As Brush = New SolidBrush(Me.ErrorText)
					rectangle = New Rectangle(48, 12, Me.W, Me.H)
					graphics11.DrawString(text2, font6, brush11, rectangle, Helpers.NearSF)
					Dim graphics12 As Graphics = g
					Dim brush12 As Brush = New SolidBrush(Color.FromArgb(35, Color.Black))
					rectangle = New Rectangle(Me.W - 32, Me.H - 29, 17, 17)
					graphics12.FillEllipse(brush12, rectangle)
					Dim graphics13 As Graphics = g
					Dim s5 As String = "r"
					Dim font7 As Font = New Font("Marlett", 8F)
					Dim brush13 As Brush = New SolidBrush(Me.ErrorColor)
					rectangle = New Rectangle(Me.W - 30, 17, Me.W, Me.H)
					graphics13.DrawString(s5, font7, brush13, rectangle, Helpers.NearSF)
					Dim state2 As MouseState = Me.State
					If state2 = MouseState.Over Then
						Dim graphics14 As Graphics = g
						Dim s6 As String = "r"
						Dim font8 As Font = New Font("Marlett", 8F)
						Dim brush14 As Brush = New SolidBrush(Color.FromArgb(25, Color.White))
						rectangle = New Rectangle(Me.W - 30, 15, Me.W, Me.H)
						graphics14.DrawString(s6, font8, brush14, rectangle, Helpers.NearSF)
					End If
				Case FlatAlertBox._Kind.Info
					g.FillRectangle(New SolidBrush(Me.InfoColor), rect)
					Dim graphics15 As Graphics = g
					Dim brush15 As Brush = New SolidBrush(Me.InfoText)
					Dim rectangle As Rectangle = New Rectangle(8, 9, 24, 24)
					graphics15.FillEllipse(brush15, rectangle)
					Dim graphics16 As Graphics = g
					Dim brush16 As Brush = New SolidBrush(Me.InfoColor)
					rectangle = New Rectangle(10, 11, 20, 20)
					graphics16.FillEllipse(brush16, rectangle)
					Dim graphics17 As Graphics = g
					Dim s7 As String = "¡"
					Dim font9 As Font = New Font("Segoe UI", 20F, FontStyle.Bold)
					Dim brush17 As Brush = New SolidBrush(Me.InfoText)
					rectangle = New Rectangle(12, -4, Me.W, Me.H)
					graphics17.DrawString(s7, font9, brush17, rectangle, Helpers.NearSF)
					Dim graphics18 As Graphics = g
					Dim text3 As String = Me.Text
					Dim font10 As Font = Me.Font
					Dim brush18 As Brush = New SolidBrush(Me.InfoText)
					rectangle = New Rectangle(48, 12, Me.W, Me.H)
					graphics18.DrawString(text3, font10, brush18, rectangle, Helpers.NearSF)
					Dim graphics19 As Graphics = g
					Dim brush19 As Brush = New SolidBrush(Color.FromArgb(35, Color.Black))
					rectangle = New Rectangle(Me.W - 32, Me.H - 29, 17, 17)
					graphics19.FillEllipse(brush19, rectangle)
					Dim graphics20 As Graphics = g
					Dim s8 As String = "r"
					Dim font11 As Font = New Font("Marlett", 8F)
					Dim brush20 As Brush = New SolidBrush(Me.InfoColor)
					rectangle = New Rectangle(Me.W - 30, 17, Me.W, Me.H)
					graphics20.DrawString(s8, font11, brush20, rectangle, Helpers.NearSF)
					Dim state3 As MouseState = Me.State
					If state3 = MouseState.Over Then
						Dim graphics21 As Graphics = g
						Dim s9 As String = "r"
						Dim font12 As Font = New Font("Marlett", 8F)
						Dim brush21 As Brush = New SolidBrush(Color.FromArgb(25, Color.White))
						rectangle = New Rectangle(Me.W - 30, 17, Me.W, Me.H)
						graphics21.DrawString(s9, font12, brush21, rectangle, Helpers.NearSF)
					End If
			End Select
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000318 RID: 792
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000319 RID: 793
		Private W As Integer

		' Token: 0x0400031A RID: 794
		Private H As Integer

		' Token: 0x0400031B RID: 795
		Private K As FlatAlertBox._Kind

		' Token: 0x0400031C RID: 796
		Private _Text As String

		' Token: 0x0400031D RID: 797
		Private State As MouseState

		' Token: 0x0400031E RID: 798
		Private X As Integer

		' Token: 0x0400031F RID: 799
		<AccessedThroughProperty("T")>
		Private _T As Timer

		' Token: 0x04000320 RID: 800
		Private SuccessColor As Color

		' Token: 0x04000321 RID: 801
		Private SuccessText As Color

		' Token: 0x04000322 RID: 802
		Private ErrorColor As Color

		' Token: 0x04000323 RID: 803
		Private ErrorText As Color

		' Token: 0x04000324 RID: 804
		Private InfoColor As Color

		' Token: 0x04000325 RID: 805
		Private InfoText As Color

		' Token: 0x02000037 RID: 55
		<Flags()>
		Public Enum _Kind
			' Token: 0x04000327 RID: 807
			Success = 0
			' Token: 0x04000328 RID: 808
			[Error] = 1
			' Token: 0x04000329 RID: 809
			Info = 2
		End Enum
	End Class
End Namespace
