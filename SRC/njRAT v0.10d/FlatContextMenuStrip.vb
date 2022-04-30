Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Namespace NJRAT
	' Token: 0x0200003D RID: 61
	Friend Class FlatContextMenuStrip
		Inherits ContextMenuStrip

		' Token: 0x060006CE RID: 1742 RVA: 0x000384C0 File Offset: 0x000366C0
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = FlatContextMenuStrip.__ENCList
			SyncLock _ENCList
				If FlatContextMenuStrip.__ENCList.Count = FlatContextMenuStrip.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = FlatContextMenuStrip.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = FlatContextMenuStrip.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								FlatContextMenuStrip.__ENCList(num) = FlatContextMenuStrip.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					FlatContextMenuStrip.__ENCList.RemoveRange(num, FlatContextMenuStrip.__ENCList.Count - num)
					FlatContextMenuStrip.__ENCList.Capacity = FlatContextMenuStrip.__ENCList.Count
				End If
				FlatContextMenuStrip.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x060006CF RID: 1743 RVA: 0x0000347B File Offset: 0x0000167B
		Protected Overrides Sub OnTextChanged(e As EventArgs)
			MyBase.OnTextChanged(e)
			Me.Invalidate()
		End Sub

		' Token: 0x060006D0 RID: 1744 RVA: 0x000385A8 File Offset: 0x000367A8
		Public Sub New()
			FlatContextMenuStrip.__ENCAddToList(Me)
			Me.Renderer = New ToolStripProfessionalRenderer(New FlatContextMenuStrip.TColorTable())
			Me.ShowImageMargin = False
			Me.ForeColor = Color.White
			Me.Font = New Font("Segoe UI", 8F)
		End Sub

		' Token: 0x060006D1 RID: 1745 RVA: 0x00003A96 File Offset: 0x00001C96
		Protected Overrides Sub OnPaint(e As PaintEventArgs)
			MyBase.OnPaint(e)
			e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit
		End Sub

		' Token: 0x04000354 RID: 852
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0200003E RID: 62
		Public Class TColorTable
			Inherits ProfessionalColorTable

			' Token: 0x060006D2 RID: 1746 RVA: 0x000385F8 File Offset: 0x000367F8
			Public Sub New()
				Me.BackColor = Color.FromArgb(60, 60, 60)
				Me.CheckedColor = Color.FromArgb(0, 170, 220)
				Me.BorderColor = Color.FromArgb(0, 170, 220)
			End Sub

			' Token: 0x17000240 RID: 576
			' (get) Token: 0x060006D3 RID: 1747 RVA: 0x00038648 File Offset: 0x00036848
			' (set) Token: 0x060006D4 RID: 1748 RVA: 0x00003AAB File Offset: 0x00001CAB
			<Category("Colors")>
			Public Property _BackColor As Color
				Get
					Return Me.BackColor
				End Get
				Set(value As Color)
					Me.BackColor = value
				End Set
			End Property

			' Token: 0x17000241 RID: 577
			' (get) Token: 0x060006D5 RID: 1749 RVA: 0x00038660 File Offset: 0x00036860
			' (set) Token: 0x060006D6 RID: 1750 RVA: 0x00003AB4 File Offset: 0x00001CB4
			<Category("Colors")>
			Public Property _CheckedColor As Color
				Get
					Return Me.CheckedColor
				End Get
				Set(value As Color)
					Me.CheckedColor = value
				End Set
			End Property

			' Token: 0x17000242 RID: 578
			' (get) Token: 0x060006D7 RID: 1751 RVA: 0x00038678 File Offset: 0x00036878
			' (set) Token: 0x060006D8 RID: 1752 RVA: 0x00003ABD File Offset: 0x00001CBD
			<Category("Colors")>
			Public Property _BorderColor As Color
				Get
					Return Me.BorderColor
				End Get
				Set(value As Color)
					Me.BorderColor = value
				End Set
			End Property

			' Token: 0x17000243 RID: 579
			' (get) Token: 0x060006D9 RID: 1753 RVA: 0x00038648 File Offset: 0x00036848
			Public Overrides ReadOnly Property ButtonSelectedBorder As Color
				Get
					Return Me.BackColor
				End Get
			End Property

			' Token: 0x17000244 RID: 580
			' (get) Token: 0x060006DA RID: 1754 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property CheckBackground As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x17000245 RID: 581
			' (get) Token: 0x060006DB RID: 1755 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property CheckPressedBackground As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x17000246 RID: 582
			' (get) Token: 0x060006DC RID: 1756 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property CheckSelectedBackground As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x17000247 RID: 583
			' (get) Token: 0x060006DD RID: 1757 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x17000248 RID: 584
			' (get) Token: 0x060006DE RID: 1758 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x17000249 RID: 585
			' (get) Token: 0x060006DF RID: 1759 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x1700024A RID: 586
			' (get) Token: 0x060006E0 RID: 1760 RVA: 0x00038678 File Offset: 0x00036878
			Public Overrides ReadOnly Property MenuBorder As Color
				Get
					Return Me.BorderColor
				End Get
			End Property

			' Token: 0x1700024B RID: 587
			' (get) Token: 0x060006E1 RID: 1761 RVA: 0x00038678 File Offset: 0x00036878
			Public Overrides ReadOnly Property MenuItemBorder As Color
				Get
					Return Me.BorderColor
				End Get
			End Property

			' Token: 0x1700024C RID: 588
			' (get) Token: 0x060006E2 RID: 1762 RVA: 0x00038660 File Offset: 0x00036860
			Public Overrides ReadOnly Property MenuItemSelected As Color
				Get
					Return Me.CheckedColor
				End Get
			End Property

			' Token: 0x1700024D RID: 589
			' (get) Token: 0x060006E3 RID: 1763 RVA: 0x00038678 File Offset: 0x00036878
			Public Overrides ReadOnly Property SeparatorDark As Color
				Get
					Return Me.BorderColor
				End Get
			End Property

			' Token: 0x1700024E RID: 590
			' (get) Token: 0x060006E4 RID: 1764 RVA: 0x00038648 File Offset: 0x00036848
			Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
				Get
					Return Me.BackColor
				End Get
			End Property

			' Token: 0x04000355 RID: 853
			Private BackColor As Color

			' Token: 0x04000356 RID: 854
			Private CheckedColor As Color

			' Token: 0x04000357 RID: 855
			Private BorderColor As Color
		End Class
	End Class
End Namespace
