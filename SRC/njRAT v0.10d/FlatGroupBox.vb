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
	' Token: 0x02000029 RID: 41
	Friend Class FlatGroupBox
		Inherits ContainerControl

		' Token: 0x060005DC RID: 1500 RVA: 0x0003340C File Offset: 0x0003160C
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatGroupBox.__ENCList
			SyncLock _ENCList
				If FlatGroupBox.__ENCList.Count = FlatGroupBox.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatGroupBox.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatGroupBox.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatGroupBox.__ENCList(num) = FlatGroupBox.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatGroupBox.__ENCList.RemoveRange(num, FlatGroupBox.__ENCList.Count - num)
					FlatGroupBox.__ENCList.Capacity = FlatGroupBox.__ENCList.Count
				End If
				FlatGroupBox.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700020D RID: 525
		' (get) Token: 0x060005DD RID: 1501 RVA: 0x000334F4 File Offset: 0x000316F4
		' (set) Token: 0x060005DE RID: 1502 RVA: 0x0000339A File Offset: 0x0000159A
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x1700020E RID: 526
		' (get) Token: 0x060005DF RID: 1503 RVA: 0x0003350C File Offset: 0x0003170C
		' (set) Token: 0x060005E0 RID: 1504 RVA: 0x000033A3 File Offset: 0x000015A3
		Public Property ShowText As Boolean
			Get
				Return Me._ShowText
			End Get
			Set(value As Boolean)
				Me._ShowText = value
			End Set
		End Property

		' Token: 0x060005E1 RID: 1505 RVA: 0x00033520 File Offset: 0x00031720
		Public Sub New()
			FlatGroupBox.__ENCAddToList(Me)
			Me._ShowText = True
			Me._BaseColor = Color.FromArgb(60, 60, 60)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.SupportsTransparentBackColor Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.Transparent
			Dim size As Size = New Size(240, 180)
			Me.Size = size
			Me.Font = New Font("Segoe ui", 10F)
		End Sub

		' Token: 0x060005E2 RID: 1506 RVA: 0x0003359C File Offset: 0x0003179C
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim path As GraphicsPath = New GraphicsPath()
			Dim path2 As GraphicsPath = New GraphicsPath()
			Dim path3 As GraphicsPath = New GraphicsPath()
			Dim rectangle As Rectangle = New Rectangle(8, 8, Me.W - 16, Me.H - 16)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BackColor)
			path = Helpers.RoundRec(rectangle, 8)
			g.FillPath(New SolidBrush(Me._BaseColor), path)
			path2 = Helpers.DrawArrow(28, 2, False)
			g.FillPath(New SolidBrush(Me._BaseColor), path2)
			path3 = Helpers.DrawArrow(28, 8, True)
			g.FillPath(New SolidBrush(Color.FromArgb(60, 70, 73)), path3)
			If Me.ShowText Then
				Dim graphics As Graphics = g
				Dim text As String = Me.Text
				Dim font As Font = Me.Font
				Dim brush As Brush = New SolidBrush(Color.FromArgb(0, 170, 220))
				Dim r As Rectangle = New Rectangle(16, 16, Me.W, Me.H)
				graphics.DrawString(text, font, brush, r, Helpers.NearSF)
			End If
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x040002CD RID: 717
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040002CE RID: 718
		Private W As Integer

		' Token: 0x040002CF RID: 719
		Private H As Integer

		' Token: 0x040002D0 RID: 720
		Private _ShowText As Boolean

		' Token: 0x040002D1 RID: 721
		Private _BaseColor As Color
	End Class
End Namespace
