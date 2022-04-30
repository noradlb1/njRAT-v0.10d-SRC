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
	' Token: 0x02000042 RID: 66
	Friend Class FlatStatusBar
		Inherits Control

		' Token: 0x06000704 RID: 1796 RVA: 0x00038D84 File Offset: 0x00036F84
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatStatusBar.__ENCList
			SyncLock _ENCList
				If FlatStatusBar.__ENCList.Count = FlatStatusBar.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatStatusBar.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatStatusBar.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatStatusBar.__ENCList(num) = FlatStatusBar.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatStatusBar.__ENCList.RemoveRange(num, FlatStatusBar.__ENCList.Count - num)
					FlatStatusBar.__ENCList.Capacity = FlatStatusBar.__ENCList.Count
				End If
				FlatStatusBar.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x06000705 RID: 1797 RVA: 0x00003B55 File Offset: 0x00001D55
		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
			Me.Dock = DockStyle.Bottom
		End Sub

		' Token: 0x06000706 RID: 1798 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x17000256 RID: 598
		' (get) Token: 0x06000707 RID: 1799 RVA: 0x00038E6C File Offset: 0x0003706C
		' (set) Token: 0x06000708 RID: 1800 RVA: 0x00003B64 File Offset: 0x00001D64
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000257 RID: 599
		' (get) Token: 0x06000709 RID: 1801 RVA: 0x00038E84 File Offset: 0x00037084
		' (set) Token: 0x0600070A RID: 1802 RVA: 0x00003B6D File Offset: 0x00001D6D
		<Category("Colors")>
		Public Property TextColor As Color
			Get
				Return Me._TextColor
			End Get
			Set(value As Color)
				Me._TextColor = value
			End Set
		End Property

		' Token: 0x17000258 RID: 600
		' (get) Token: 0x0600070B RID: 1803 RVA: 0x00038E9C File Offset: 0x0003709C
		' (set) Token: 0x0600070C RID: 1804 RVA: 0x00003B76 File Offset: 0x00001D76
		<Category("Colors")>
		Public Property RectColor As Color
			Get
				Return Me._RectColor
			End Get
			Set(value As Color)
				Me._RectColor = value
			End Set
		End Property

		' Token: 0x17000259 RID: 601
		' (get) Token: 0x0600070D RID: 1805 RVA: 0x00038EB4 File Offset: 0x000370B4
		' (set) Token: 0x0600070E RID: 1806 RVA: 0x00003B7F File Offset: 0x00001D7F
		Public Property ShowTimeDate As Boolean
			Get
				Return Me._ShowTimeDate
			End Get
			Set(value As Boolean)
				Me._ShowTimeDate = value
			End Set
		End Property

		' Token: 0x0600070F RID: 1807 RVA: 0x00038EC8 File Offset: 0x000370C8
		Public Function GetTimeDate() As String
			Return String.Concat(New String() { Conversions.ToString(DateTime.Now.[Date]), " ", Conversions.ToString(DateTime.Now.Hour), ":", Conversions.ToString(DateTime.Now.Minute) })
		End Function

		' Token: 0x06000710 RID: 1808 RVA: 0x00038F3C File Offset: 0x0003713C
		Public Sub New()
			FlatStatusBar.__ENCAddToList(Me)
			Me._ShowTimeDate = False
			Me._BaseColor = Color.FromArgb(50, 50, 50)
			Me._TextColor = Color.White
			Me._RectColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.Font = New Font("Segoe UI", 8F)
			Me.ForeColor = Color.White
			Dim size As Size = New Size(Me.Width, 20)
			Me.Size = size
		End Sub

		' Token: 0x06000711 RID: 1809 RVA: 0x00038FD8 File Offset: 0x000371D8
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width
			Me.H = Me.Height
			Dim rect As Rectangle = New Rectangle(0, 0, Me.W, Me.H)
			Dim g As Graphics = Helpers.G
			g.SmoothingMode = SmoothingMode.HighQuality
			g.PixelOffsetMode = PixelOffsetMode.HighQuality
			g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			g.Clear(Me.BaseColor)
			g.FillRectangle(New SolidBrush(Me.BaseColor), rect)
			Dim graphics As Graphics = g
			Dim text As String = Me.Text
			Dim font As Font = Me.Font
			Dim white As Brush = Brushes.White
			Dim rectangle As Rectangle = New Rectangle(10, 4, Me.W, Me.H)
			graphics.DrawString(text, font, white, rectangle, Helpers.NearSF)
			Dim graphics2 As Graphics = g
			Dim brush As Brush = New SolidBrush(Me._RectColor)
			rectangle = New Rectangle(4, 4, 4, 14)
			graphics2.FillRectangle(brush, rectangle)
			If Me.ShowTimeDate Then
				Dim graphics3 As Graphics = g
				Dim timeDate As String = Me.GetTimeDate()
				Dim font2 As Font = Me.Font
				Dim brush2 As Brush = New SolidBrush(Me._TextColor)
				rectangle = New Rectangle(-4, 2, Me.W, Me.H)
				graphics3.DrawString(timeDate, font2, brush2, rectangle, New StringFormat() With { .Alignment = StringAlignment.Far, .LineAlignment = StringAlignment.Center })
			End If
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x0400036C RID: 876
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400036D RID: 877
		Private W As Integer

		' Token: 0x0400036E RID: 878
		Private H As Integer

		' Token: 0x0400036F RID: 879
		Private _ShowTimeDate As Boolean

		' Token: 0x04000370 RID: 880
		Private _BaseColor As Color

		' Token: 0x04000371 RID: 881
		Private _TextColor As Color

		' Token: 0x04000372 RID: 882
		Private _RectColor As Color
	End Class
End Namespace
