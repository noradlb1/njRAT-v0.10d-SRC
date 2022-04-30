Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace NJRAT
	' Token: 0x0200006B RID: 107
	Public Class UserImage
		Inherits Control

		' Token: 0x060007DD RID: 2013 RVA: 0x0004565C File Offset: 0x0004385C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = UserImage.__ENCList
			SyncLock _ENCList
				If UserImage.__ENCList.Count = UserImage.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = UserImage.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = UserImage.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								UserImage.__ENCList(num) = UserImage.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					UserImage.__ENCList.RemoveRange(num, UserImage.__ENCList.Count - num)
					UserImage.__ENCList.Capacity = UserImage.__ENCList.Count
				End If
				UserImage.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000260 RID: 608
		' (get) Token: 0x060007DE RID: 2014 RVA: 0x00045744 File Offset: 0x00043944
		' (set) Token: 0x060007DF RID: 2015 RVA: 0x00003D4D File Offset: 0x00001F4D
		<Category("[ Colors ]")>
		Public Property ColorBorder As Color
			Get
				Return Me._ColorBorder
			End Get
			Set(value As Color)
				Me._ColorBorder = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000261 RID: 609
		' (get) Token: 0x060007E0 RID: 2016 RVA: 0x0004575C File Offset: 0x0004395C
		' (set) Token: 0x060007E1 RID: 2017 RVA: 0x00003D5C File Offset: 0x00001F5C
		<Category("[ Colors ]")>
		Public Property ColorProgress As Color
			Get
				Return Me._ColorProgress
			End Get
			Set(value As Color)
				Me._ColorProgress = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000262 RID: 610
		' (get) Token: 0x060007E2 RID: 2018 RVA: 0x00045774 File Offset: 0x00043974
		' (set) Token: 0x060007E3 RID: 2019 RVA: 0x00003D6B File Offset: 0x00001F6B
		<Category("[ Colors ]")>
		Public Property ColorActivityStatus As Color
			Get
				Return Me._ColorActivityStatus
			End Get
			Set(value As Color)
				Me._ColorActivityStatus = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000263 RID: 611
		' (get) Token: 0x060007E4 RID: 2020 RVA: 0x0004578C File Offset: 0x0004398C
		' (set) Token: 0x060007E5 RID: 2021 RVA: 0x00003D7A File Offset: 0x00001F7A
		<Category("[ Control ]")>
		Public Property EnableHover As Boolean
			Get
				Return Me._EnableHover
			End Get
			Set(value As Boolean)
				Me._EnableHover = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000264 RID: 612
		' (get) Token: 0x060007E6 RID: 2022 RVA: 0x000457A0 File Offset: 0x000439A0
		' (set) Token: 0x060007E7 RID: 2023 RVA: 0x00003D89 File Offset: 0x00001F89
		<Category("[ Control ]")>
		Public Property Maximum As Integer
			Get
				Return Me._Maximum
			End Get
			Set(value As Integer)
				Me._Maximum = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000265 RID: 613
		' (get) Token: 0x060007E8 RID: 2024 RVA: 0x000457B8 File Offset: 0x000439B8
		' (set) Token: 0x060007E9 RID: 2025 RVA: 0x00003D98 File Offset: 0x00001F98
		<Category("[ Control ]")>
		Public Property Value As Integer
			Get
				Return Me._Value
			End Get
			Set(value As Integer)
				Me._Value = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000266 RID: 614
		' (get) Token: 0x060007EA RID: 2026 RVA: 0x000457D0 File Offset: 0x000439D0
		' (set) Token: 0x060007EB RID: 2027 RVA: 0x00003DA7 File Offset: 0x00001FA7
		<Category("[ Control ]")>
		Public Property RotationAngle As Integer
			Get
				Return Me._RotationAngle
			End Get
			Set(value As Integer)
				Me._RotationAngle = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000267 RID: 615
		' (get) Token: 0x060007EC RID: 2028 RVA: 0x000457E8 File Offset: 0x000439E8
		' (set) Token: 0x060007ED RID: 2029 RVA: 0x00003DB6 File Offset: 0x00001FB6
		<Category("[ Control ]")>
		Public Property StartingAngle As Integer
			Get
				Return Me._StartingAngle
			End Get
			Set(value As Integer)
				Me._StartingAngle = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000268 RID: 616
		' (get) Token: 0x060007EE RID: 2030 RVA: 0x00045800 File Offset: 0x00043A00
		' (set) Token: 0x060007EF RID: 2031 RVA: 0x00003DC5 File Offset: 0x00001FC5
		<Category("[ Control ]")>
		Public Property ShowProgress As Boolean
			Get
				Return Me._ShowProgress
			End Get
			Set(value As Boolean)
				Me._ShowProgress = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x17000269 RID: 617
		' (get) Token: 0x060007F0 RID: 2032 RVA: 0x00045814 File Offset: 0x00043A14
		' (set) Token: 0x060007F1 RID: 2033 RVA: 0x00003DD4 File Offset: 0x00001FD4
		<Category("[ Control ]")>
		Public Property ShowActivityStatus As Boolean
			Get
				Return Me._ShowActivityStatus
			End Get
			Set(value As Boolean)
				Me._ShowActivityStatus = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700026A RID: 618
		' (get) Token: 0x060007F2 RID: 2034 RVA: 0x00045828 File Offset: 0x00043A28
		' (set) Token: 0x060007F3 RID: 2035 RVA: 0x00003DE3 File Offset: 0x00001FE3
		<Category("[ Control ]")>
		Public Property ShowImage As Boolean
			Get
				Return Me._ShowImage
			End Get
			Set(value As Boolean)
				Me._ShowImage = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700026B RID: 619
		' (get) Token: 0x060007F4 RID: 2036 RVA: 0x0004583C File Offset: 0x00043A3C
		' (set) Token: 0x060007F5 RID: 2037 RVA: 0x00003DF2 File Offset: 0x00001FF2
		<Category("[ Control ]")>
		Public Property UImage As Image
			Get
				Return Me._UImage
			End Get
			Set(value As Image)
				Me.IMG = Nothing
				Me._UImage = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700026C RID: 620
		' (get) Token: 0x060007F6 RID: 2038 RVA: 0x00045854 File Offset: 0x00043A54
		' (set) Token: 0x060007F7 RID: 2039 RVA: 0x00003E08 File Offset: 0x00002008
		<Category("[ Control ]")>
		Public Property BorderSize As Integer
			Get
				Return Me._BorderSize
			End Get
			Set(value As Integer)
				Me._BorderSize = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x1700026D RID: 621
		' (get) Token: 0x060007F8 RID: 2040 RVA: 0x0004586C File Offset: 0x00043A6C
		' (set) Token: 0x060007F9 RID: 2041 RVA: 0x00003E17 File Offset: 0x00002017
		<Category("[ Control ]")>
		Public Property ShowBorder As Boolean
			Get
				Return Me._ShowBorder
			End Get
			Set(value As Boolean)
				Me._ShowBorder = value
				Me.Invalidate()
			End Set
		End Property

		' Token: 0x060007FA RID: 2042 RVA: 0x00003E26 File Offset: 0x00002026
		Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
			MyBase.OnMouseUp(e)
			Me.State = UserImage.MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060007FB RID: 2043 RVA: 0x00003E3C File Offset: 0x0000203C
		Protected Overrides Sub OnMouseEnter(e As EventArgs)
			MyBase.OnMouseEnter(e)
			Me.State = UserImage.MouseState.Over
			Me.Invalidate()
		End Sub

		' Token: 0x060007FC RID: 2044 RVA: 0x00003E52 File Offset: 0x00002052
		Protected Overrides Sub OnMouseLeave(e As EventArgs)
			MyBase.OnMouseLeave(e)
			Me.State = UserImage.MouseState.None
			Me.Invalidate()
		End Sub

		' Token: 0x060007FD RID: 2045 RVA: 0x00003E68 File Offset: 0x00002068
		Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
			MyBase.OnMouseDown(e)
			Me.State = UserImage.MouseState.Down
			Me.Invalidate()
		End Sub

		' Token: 0x060007FE RID: 2046 RVA: 0x00003E7E File Offset: 0x0000207E
		Protected Overrides Sub OnResize(e As EventArgs)
			MyBase.OnResize(e)
			Me.RState = UserImage.RzState.t
			Me.Invalidate()
		End Sub

		' Token: 0x060007FF RID: 2047 RVA: 0x00045880 File Offset: 0x00043A80
		Public Sub New()
			UserImage.__ENCAddToList(Me)
			Me.State = UserImage.MouseState.None
			Me.RState = UserImage.RzState.f
			Me._ColorProgress = Color.FromArgb(101, 204, 169)
			Me._ColorActivityStatus = Color.FromArgb(101, 204, 169)
			Me._ColorBorder = Color.FromArgb(190, 190, 190)
			Me._UImage = Nothing
			Me._ShowImage = False
			Me._ShowActivityStatus = False
			Me._ShowProgress = False
			Me._EnableHover = False
			Me._Maximum = 100
			Me._Value = 50
			Me._StartingAngle = 70
			Me._RotationAngle = 310
			Me._BorderSize = 2
			Me._ShowBorder = True
			Me.IMG = Nothing
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Dim size As Size = New Size(125, 125)
			Me.Size = size
			Me.BackColor = Color.Transparent
		End Sub

		' Token: 0x06000800 RID: 2048 RVA: 0x0004597C File Offset: 0x00043B7C
		Private Function ResizeImage(im As Image, w As Integer, h As Integer) As Bitmap
			Return Me.ResizeImage(New Bitmap(im), w, h)
		End Function

		' Token: 0x06000801 RID: 2049 RVA: 0x0004599C File Offset: 0x00043B9C
		Private Function ResizeImage(bm As Bitmap, w As Integer, h As Integer) As Bitmap
			Dim bitmap As Bitmap = New Bitmap(w, h, PixelFormat.Format32bppArgb)
			Dim num As Double = CDbl(bm.Width) / CDbl(bm.Height)
			Dim num2 As Double = CDbl(bitmap.Width) / CDbl(bitmap.Height)
			Dim x As Integer = 0
			Dim y As Integer = 0
			Dim num3 As Integer = bitmap.Width
			Dim num4 As Integer = bitmap.Height
			If num2 > num Then
				num3 = Convert.ToInt32(Math.Floor(num * CDbl(num4)))
				x = Convert.ToInt32(Math.Floor(CDbl((bitmap.Width - num3)) / 2.0))
			Else
				num4 = Convert.ToInt32(Math.Floor(1.0 / num * CDbl(num3)))
				y = Convert.ToInt32(Math.Floor(CDbl((bitmap.Height - num4)) / 2.0))
			End If
			Using graphics As Graphics = Graphics.FromImage(bitmap)
				Dim graphics2 As Graphics = graphics
				graphics2.CompositingQuality = CompositingQuality.HighQuality
				graphics2.InterpolationMode = InterpolationMode.HighQualityBicubic
				graphics2.PixelOffsetMode = PixelOffsetMode.HighQuality
				graphics2.SmoothingMode = SmoothingMode.AntiAlias
				graphics2.CompositingMode = CompositingMode.SourceOver
				graphics2.DrawImage(bm, x, y, num3, num4)
			End Using
			Return bitmap
		End Function

		' Token: 0x06000802 RID: 2050 RVA: 0x00045ACC File Offset: 0x00043CCC
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			If Me.Width < 16 Or Me.Height < 16 Then
				Me.Width = 16
				Me.Height = 16
			End If
			If Me.Width <> Me.Height Then
				Me.Width = Me.Height
			End If
			If Me.Dock <> DockStyle.None Then
				Me.Dock = DockStyle.None
			End If
			Dim borderSize As Integer = Me.BorderSize
			Dim graphics As Graphics = e.Graphics
			Dim graphics2 As Graphics = graphics
			graphics2.SmoothingMode = SmoothingMode.HighQuality
			Dim colorActivityStatus As Color = Me.ColorActivityStatus
			Dim colorBorder As Color = Me.ColorBorder
			Dim pen As Pen = New Pen(Color.FromArgb(127, CInt(colorBorder.R), CInt(colorBorder.G), CInt(colorBorder.B)), CSng(borderSize))
			Dim pen2 As Pen = New Pen(Color.FromArgb(27, CInt(colorBorder.R), CInt(colorBorder.G), CInt(colorBorder.B)), CSng(borderSize))
			Dim pen3 As Pen = New Pen(Color.FromArgb(9, CInt(colorBorder.R), CInt(colorBorder.G), CInt(colorBorder.B)), CSng(borderSize))
			Dim bitmap As Bitmap
			If Me._ShowImage And Me._UImage IsNot Nothing Then
				If Me.IMG Is Nothing Or Me.RState = UserImage.RzState.t Then
					Me.IMG = New Bitmap(Me.ResizeImage(Me._UImage, Me.Width - 12, Me.Height - 12))
					bitmap = New Bitmap(Me.IMG)
					Me.RState = UserImage.RzState.f
				Else
					bitmap = New Bitmap(Me.IMG)
				End If
			Else
				bitmap = New Bitmap(Me.Width - 12, Me.Height - 12)
			End If
			Using bitmap2 As Bitmap = New Bitmap(bitmap.Width + 12, bitmap.Height + 12)
				Using graphics3 As Graphics = Graphics.FromImage(bitmap2)
					graphics3.SmoothingMode = SmoothingMode.AntiAlias
					graphics3.PixelOffsetMode = PixelOffsetMode.HighQuality
					Using textureBrush As TextureBrush = New TextureBrush(bitmap)
						textureBrush.TranslateTransform(6F, 6F)
						Using graphicsPath As GraphicsPath = New GraphicsPath()
							graphicsPath.AddEllipse(6, 6, bitmap.Width, bitmap.Height)
							graphics3.FillPath(textureBrush, graphicsPath)
							Dim num As Integer = 6
							Dim num2 As Integer = 12
							Dim num3 As Integer = 12
							Select Case Me.State
								Case UserImage.MouseState.Over, UserImage.MouseState.Down
									If Me.EnableHover Then
										Dim rect As Rectangle = New Rectangle(3, 3, bitmap.Width, bitmap.Height)
										Dim brush As LinearGradientBrush = New LinearGradientBrush(rect, Color.FromArgb(0, 0, 0, 0), Color.FromArgb(80, CInt(colorActivityStatus.R), CInt(colorActivityStatus.G), CInt(colorActivityStatus.B)), LinearGradientMode.ForwardDiagonal)
										graphics3.FillEllipse(brush, 6, 6, bitmap.Width, bitmap.Height)
									End If
							End Select
							If Me.ShowBorder Then
								graphics3.DrawEllipse(pen, num, num, bitmap2.Width - num2, bitmap2.Height - num3)
								graphics3.DrawEllipse(pen2, num - 1, num - 1, bitmap2.Width - num2 + 1, bitmap2.Height - num3 + 1)
								graphics3.DrawEllipse(pen3, num - 2, num - 2, bitmap2.Width - num2 + 2, bitmap2.Height - num3 + 2)
							End If
							If Me.ShowProgress Then
								Try
									Dim colorProgress As Color = Me.ColorProgress
									If Me.Value >= Me.Maximum Then
										Me._Value = Me.Maximum
									End If
									Dim value As Integer = Me._Value
									If value <> 0 Then
										If value = Me.Maximum Then
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(6, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 3))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, Me.RotationAngle)
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(12, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 2))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, Me.RotationAngle)
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(18, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 1))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, Me.RotationAngle)
											graphics3.DrawArc(New Pen(New SolidBrush(colorProgress), CSng(borderSize)), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, Me.RotationAngle)
										Else
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(6, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 3))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, CInt(Math.Round(CDbl(Me.RotationAngle) / CDbl(Me.Maximum) * CDbl(Me.Value))))
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(12, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 2))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, CInt(Math.Round(CDbl(Me.RotationAngle) / CDbl(Me.Maximum) * CDbl(Me.Value))))
											graphics3.DrawArc(New Pen(New SolidBrush(Color.FromArgb(18, CInt(colorProgress.R), CInt(colorProgress.G), CInt(colorProgress.B))), CSng((borderSize + 1))), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, CInt(Math.Round(CDbl(Me.RotationAngle) / CDbl(Me.Maximum) * CDbl(Me.Value))))
											graphics3.DrawArc(New Pen(New SolidBrush(colorProgress), CSng(borderSize)), num, num, bitmap2.Width - num2, bitmap2.Height - num3, Me.StartingAngle, CInt(Math.Round(CDbl(Me.RotationAngle) / CDbl(Me.Maximum) * CDbl(Me.Value))))
										End If
									End If
								Catch ex As Exception
								End Try
							End If
							If Me.ShowActivityStatus Then
								Using solidBrush As SolidBrush = New SolidBrush(colorActivityStatus)
									Dim num4 As Single = 3.14F
									Dim num5 As Single = CSng((CDbl(bitmap.Width) / 2.0))
									Dim num6 As Single = num5 / num4
									Dim num7 As Single = num5 * 2F - num6 + 6F
									Dim num8 As Single = num5 * 2F - num6 + 6F
									graphics3.FillEllipse(solidBrush, num7 - CSng(CInt(Math.Round(CDbl((num6 / 2F))))), num8 - CSng(CInt(Math.Round(CDbl((num6 / 2F))))), num6, num6)
								End Using
							End If
						End Using
					End Using
				End Using
				graphics2.DrawImage(bitmap2, 0, 0)
				bitmap.Dispose()
				bitmap2.Dispose()
			End Using
			graphics2 = Nothing
		End Sub

		' Token: 0x04000468 RID: 1128
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000469 RID: 1129
		Private State As UserImage.MouseState

		' Token: 0x0400046A RID: 1130
		Private RState As UserImage.RzState

		' Token: 0x0400046B RID: 1131
		Private _ColorProgress As Color

		' Token: 0x0400046C RID: 1132
		Private _ColorActivityStatus As Color

		' Token: 0x0400046D RID: 1133
		Private _ColorBorder As Color

		' Token: 0x0400046E RID: 1134
		Private _UImage As Image

		' Token: 0x0400046F RID: 1135
		Private _ShowImage As Boolean

		' Token: 0x04000470 RID: 1136
		Private _ShowActivityStatus As Boolean

		' Token: 0x04000471 RID: 1137
		Private _ShowProgress As Boolean

		' Token: 0x04000472 RID: 1138
		Private _EnableHover As Boolean

		' Token: 0x04000473 RID: 1139
		Private _Maximum As Integer

		' Token: 0x04000474 RID: 1140
		Private _Value As Integer

		' Token: 0x04000475 RID: 1141
		Private _StartingAngle As Integer

		' Token: 0x04000476 RID: 1142
		Private _RotationAngle As Integer

		' Token: 0x04000477 RID: 1143
		Private _BorderSize As Integer

		' Token: 0x04000478 RID: 1144
		Private _ShowBorder As Boolean

		' Token: 0x04000479 RID: 1145
		Private IMG As Image

		' Token: 0x0200006C RID: 108
		Public Enum MouseState As Byte
			' Token: 0x0400047B RID: 1147
			None
			' Token: 0x0400047C RID: 1148
			Over
			' Token: 0x0400047D RID: 1149
			Down
		End Enum

		' Token: 0x0200006D RID: 109
		Public Enum RzState As Byte
			' Token: 0x0400047F RID: 1151
			f
			' Token: 0x04000480 RID: 1152
			t
		End Enum
	End Class
End Namespace
