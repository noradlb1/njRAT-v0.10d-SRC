Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000023 RID: 35
	Friend NotInheritable Module Helpers
		' Token: 0x06000598 RID: 1432 RVA: 0x000322A4 File Offset: 0x000304A4
		Public Function RoundRec(Rectangle As Rectangle, Curve As Integer) As GraphicsPath
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Integer = Curve * 2
			Dim graphicsPath2 As GraphicsPath = graphicsPath
			Dim rect As Rectangle = New Rectangle(Rectangle.X, Rectangle.Y, num, num)
			graphicsPath2.AddArc(rect, -180F, 90F)
			Dim graphicsPath3 As GraphicsPath = graphicsPath
			rect = New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num)
			graphicsPath3.AddArc(rect, -90F, 90F)
			Dim graphicsPath4 As GraphicsPath = graphicsPath
			rect = New Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num)
			graphicsPath4.AddArc(rect, 0F, 90F)
			Dim graphicsPath5 As GraphicsPath = graphicsPath
			rect = New Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num)
			graphicsPath5.AddArc(rect, 90F, 90F)
			Dim graphicsPath6 As GraphicsPath = graphicsPath
			Dim point As Point = New Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y)
			Dim pt As Point = point
			Dim pt2 As Point = New Point(Rectangle.X, Curve + Rectangle.Y)
			graphicsPath6.AddLine(pt, pt2)
			Return graphicsPath
		End Function

		' Token: 0x06000599 RID: 1433 RVA: 0x000323C8 File Offset: 0x000305C8
		Public Function RoundRect(x As Single, y As Single, w As Single, h As Single, Optional r As Single = 0.3F, Optional TL As Boolean = True, Optional TR As Boolean = True, Optional BR As Boolean = True, Optional BL As Boolean = True) As GraphicsPath
			Dim num As Single = Math.Min(w, h) * r
			Dim num2 As Single = x + w
			Dim num3 As Single = y + h
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim graphicsPath2 As GraphicsPath = graphicsPath
			If TL Then
				graphicsPath2.AddArc(x, y, num, num, 180F, 90F)
			Else
				graphicsPath2.AddLine(x, y, x, y)
			End If
			If TR Then
				graphicsPath2.AddArc(num2 - num, y, num, num, 270F, 90F)
			Else
				graphicsPath2.AddLine(num2, y, num2, y)
			End If
			If BR Then
				graphicsPath2.AddArc(num2 - num, num3 - num, num, num, 0F, 90F)
			Else
				graphicsPath2.AddLine(num2, num3, num2, num3)
			End If
			If BL Then
				graphicsPath2.AddArc(x, num3 - num, num, num, 90F, 90F)
			Else
				graphicsPath2.AddLine(x, num3, x, num3)
			End If
			graphicsPath2.CloseFigure()
			Return graphicsPath
		End Function

		' Token: 0x0600059A RID: 1434 RVA: 0x0003249C File Offset: 0x0003069C
		Public Function DrawArrow(x As Integer, y As Integer, flip As Boolean) As GraphicsPath
			Dim graphicsPath As GraphicsPath = New GraphicsPath()
			Dim num As Integer = 12
			Dim num2 As Integer = 6
			If flip Then
				graphicsPath.AddLine(x + 1, y, x + num + 1, y)
				graphicsPath.AddLine(x + num, y, x + num2, y + num2 - 1)
			Else
				graphicsPath.AddLine(x, y + num2, x + num, y + num2)
				graphicsPath.AddLine(x + num, y + num2, x + num2, y)
			End If
			graphicsPath.CloseFigure()
			Return graphicsPath
		End Function

		' Token: 0x040002A6 RID: 678
		Friend G As Graphics

		' Token: 0x040002A7 RID: 679
		Friend B As Bitmap

		' Token: 0x040002A8 RID: 680
		Friend _FlatColor As Color = Color.FromArgb(35, 168, 109)

		' Token: 0x040002A9 RID: 681
		Friend NearSF As StringFormat = New StringFormat() With { .Alignment = StringAlignment.Near, .LineAlignment = StringAlignment.Near }

		' Token: 0x040002AA RID: 682
		Friend CenterSF As StringFormat = New StringFormat() With { .Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center }
	End Module
End Namespace
