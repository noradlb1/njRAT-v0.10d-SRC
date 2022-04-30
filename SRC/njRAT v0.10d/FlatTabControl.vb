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
	' Token: 0x02000035 RID: 53
	Friend Class FlatTabControl
		Inherits TabControl

		' Token: 0x0600065A RID: 1626 RVA: 0x00035748 File Offset: 0x00033948
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatTabControl.__ENCList
			SyncLock _ENCList
				If FlatTabControl.__ENCList.Count = FlatTabControl.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatTabControl.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatTabControl.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatTabControl.__ENCList(num) = FlatTabControl.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatTabControl.__ENCList.RemoveRange(num, FlatTabControl.__ENCList.Count - num)
					FlatTabControl.__ENCList.Capacity = FlatTabControl.__ENCList.Count
				End If
				FlatTabControl.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x0600065B RID: 1627 RVA: 0x00003738 File Offset: 0x00001938
		Protected Overrides Sub CreateHandle()
			MyBase.CreateHandle()
			Me.Alignment = TabAlignment.Top
		End Sub

		' Token: 0x17000226 RID: 550
		' (get) Token: 0x0600065C RID: 1628 RVA: 0x00035830 File Offset: 0x00033A30
		' (set) Token: 0x0600065D RID: 1629 RVA: 0x00003747 File Offset: 0x00001947
		<Category("Colors")>
		Public Property BaseColor As Color
			Get
				Return Me._BaseColor
			End Get
			Set(value As Color)
				Me._BaseColor = value
			End Set
		End Property

		' Token: 0x17000227 RID: 551
		' (get) Token: 0x0600065E RID: 1630 RVA: 0x00035848 File Offset: 0x00033A48
		' (set) Token: 0x0600065F RID: 1631 RVA: 0x00003750 File Offset: 0x00001950
		<Category("Colors")>
		Public Property ActiveColor As Color
			Get
				Return Me._ActiveColor
			End Get
			Set(value As Color)
				Me._ActiveColor = value
			End Set
		End Property

		' Token: 0x06000660 RID: 1632 RVA: 0x00035860 File Offset: 0x00033A60
		Public Sub New()
			FlatTabControl.__ENCAddToList(Me)
			Me.BGColor = Color.FromArgb(33, 33, 50)
			Me._BaseColor = Color.FromArgb(45, 47, 49)
			Me._ActiveColor = Color.FromArgb(0, 170, 220)
			Me.SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer, True)
			Me.DoubleBuffered = True
			Me.BackColor = Color.FromArgb(60, 70, 73)
			Me.Font = New Font("Segoe UI", 10F)
			Me.SizeMode = TabSizeMode.Fixed
			Dim itemSize As Size = New Size(120, 40)
			Me.ItemSize = itemSize
		End Sub

		' Token: 0x06000661 RID: 1633 RVA: 0x00035904 File Offset: 0x00033B04
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			Helpers.B = New Bitmap(Me.Width, Me.Height)
			Helpers.G = Graphics.FromImage(Helpers.B)
			Me.W = Me.Width - 1
			Me.H = Me.Height - 1
			Dim graphics As Graphics = Helpers.G
			graphics.SmoothingMode = SmoothingMode.HighQuality
			graphics.PixelOffsetMode = PixelOffsetMode.HighQuality
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
			graphics.Clear(Me._BaseColor)
			Try
				Me.SelectedTab.BackColor = Me.BGColor
			Catch ex As Exception
			End Try
			Dim num As Integer = 0
			Dim num2 As Integer = Me.TabCount - 1
			Dim num3 As Integer = num
			While True
				Dim num4 As Integer = num3
				Dim num5 As Integer = num2
				If num4 > num5 Then
					Exit For
				End If
				Dim location As Point = Me.GetTabRect(num3).Location
				Dim location2 As Point = New Point(location.X + 2, Me.GetTabRect(num3).Location.Y)
				Dim location3 As Point = location2
				Dim size As Size = New Size(Me.GetTabRect(num3).Width, Me.GetTabRect(num3).Height)
				Dim rectangle As Rectangle = New Rectangle(location3, size)
				Dim location4 As Point = rectangle.Location
				size = New Size(rectangle.Width, rectangle.Height)
				Dim rectangle2 As Rectangle = New Rectangle(location4, size)
				If num3 = Me.SelectedIndex Then
					graphics.FillRectangle(New SolidBrush(Me._BaseColor), rectangle2)
					graphics.FillRectangle(New SolidBrush(Me._ActiveColor), rectangle2)
					If Me.ImageList IsNot Nothing Then
						Try
							If Me.ImageList.Images(Me.TabPages(num3).ImageIndex) IsNot Nothing Then
								Dim graphics2 As Graphics = graphics
								Dim image As Image = Me.ImageList.Images(Me.TabPages(num3).ImageIndex)
								location2 = rectangle2.Location
								location = New Point(location2.X + 8, rectangle2.Location.Y + 6)
								graphics2.DrawImage(image, location)
								graphics.DrawString("      " + Me.TabPages(num3).Text, Me.Font, Brushes.White, rectangle2, Helpers.CenterSF)
							Else
								graphics.DrawString(Me.TabPages(num3).Text, Me.Font, Brushes.White, rectangle2, Helpers.CenterSF)
							End If
							GoTo IL_44E
						Catch ex2 As Exception
							Throw New Exception(ex2.Message)
						End Try
					End If
					graphics.DrawString(Me.TabPages(num3).Text, Me.Font, Brushes.White, rectangle2, Helpers.CenterSF)
				Else
					graphics.FillRectangle(New SolidBrush(Me._BaseColor), rectangle2)
					If Me.ImageList IsNot Nothing Then
						Try
							If Me.ImageList.Images(Me.TabPages(num3).ImageIndex) IsNot Nothing Then
								Dim graphics3 As Graphics = graphics
								Dim image2 As Image = Me.ImageList.Images(Me.TabPages(num3).ImageIndex)
								location2 = rectangle2.Location
								location = New Point(location2.X + 8, rectangle2.Location.Y + 6)
								graphics3.DrawImage(image2, location)
								graphics.DrawString("      " + Me.TabPages(num3).Text, Me.Font, New SolidBrush(Color.White), rectangle2, New StringFormat() With { .LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center })
							Else
								graphics.DrawString(Me.TabPages(num3).Text, Me.Font, New SolidBrush(Color.White), rectangle2, New StringFormat() With { .LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center })
							End If
							GoTo IL_44E
						Catch ex3 As Exception
							Throw New Exception(ex3.Message)
						End Try
					End If
					graphics.DrawString(Me.TabPages(num3).Text, Me.Font, New SolidBrush(Color.White), rectangle2, New StringFormat() With { .LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center })
				End If
				IL_44E:
				num3 += 1
			End While
			graphics = Nothing
			MyBase.OnPaint(e)
			Helpers.G.Dispose()
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic
			e.Graphics.DrawImageUnscaled(Helpers.B, 0, 0)
			Helpers.B.Dispose()
		End Sub

		' Token: 0x04000312 RID: 786
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000313 RID: 787
		Private W As Integer

		' Token: 0x04000314 RID: 788
		Private H As Integer

		' Token: 0x04000315 RID: 789
		Private BGColor As Color

		' Token: 0x04000316 RID: 790
		Private _BaseColor As Color

		' Token: 0x04000317 RID: 791
		Private _ActiveColor As Color
	End Class
End Namespace
