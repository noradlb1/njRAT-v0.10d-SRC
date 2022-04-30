Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<DesignerGenerated()>
	Public Partial Class STNG
		Inherits Form

		' Token: 0x06000524 RID: 1316 RVA: 0x00002FB2 File Offset: 0x000011B2
		<DebuggerNonUserCode()>
		Public Sub New()
			AddHandler MyBase.Load, AddressOf Me.STNG_Load
			STNG.__ENCAddToList(Me)
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000525 RID: 1317 RVA: 0x0002EBA4 File Offset: 0x0002CDA4
		<DebuggerNonUserCode()>
		Private Shared Sub __ENCAddToList(value As Object)
			Dim _ENCList As List(Of WeakReference) = STNG.__ENCList
			SyncLock _ENCList
				If STNG.__ENCList.Count = STNG.__ENCList.Capacity Then
					Dim num As Integer = 0
					Dim num2 As Integer = 0
					Dim num3 As Integer = STNG.__ENCList.Count - 1
					Dim num4 As Integer = num2
					While True
						Dim num5 As Integer = num4
						Dim num6 As Integer = num3
						If num5 > num6 Then
							Exit For
						End If
						Dim weakReference As WeakReference = STNG.__ENCList(num4)
						If weakReference.IsAlive Then
							If num4 <> num Then
								STNG.__ENCList(num) = STNG.__ENCList(num4)
							End If
							num += 1
						End If
						num4 += 1
					End While
					STNG.__ENCList.RemoveRange(num, STNG.__ENCList.Count - num)
					STNG.__ENCList.Capacity = STNG.__ENCList.Count
				End If
				STNG.__ENCList.Add(New WeakReference(RuntimeHelpers.GetObjectValue(value)))
			End SyncLock
		End Sub

		' Token: 0x170001D6 RID: 470
		' (get) Token: 0x06000528 RID: 1320 RVA: 0x00030884 File Offset: 0x0002EA84
		' (set) Token: 0x06000529 RID: 1321 RVA: 0x00002FD9 File Offset: 0x000011D9
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

		' Token: 0x170001D7 RID: 471
		' (get) Token: 0x0600052A RID: 1322 RVA: 0x0003089C File Offset: 0x0002EA9C
		' (set) Token: 0x0600052B RID: 1323 RVA: 0x000308B4 File Offset: 0x0002EAB4
		Friend Overridable Property Button1 As Button
			<DebuggerNonUserCode()>
			Get
				Return Me._Button1
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As Button)
				Dim value2 As EventHandler = AddressOf Me.Button1_Click
				If Me._Button1 IsNot Nothing Then
					RemoveHandler Me._Button1.Click, value2
				End If
				Me._Button1 = value
				If Me._Button1 IsNot Nothing Then
					AddHandler Me._Button1.Click, value2
				End If
			End Set
		End Property

		' Token: 0x170001D8 RID: 472
		' (get) Token: 0x0600052C RID: 1324 RVA: 0x0003090C File Offset: 0x0002EB0C
		' (set) Token: 0x0600052D RID: 1325 RVA: 0x00002FE2 File Offset: 0x000011E2
		Friend Overridable Property GroupBox6 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox6
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox6 = value
			End Set
		End Property

		' Token: 0x170001D9 RID: 473
		' (get) Token: 0x0600052E RID: 1326 RVA: 0x00030924 File Offset: 0x0002EB24
		' (set) Token: 0x0600052F RID: 1327 RVA: 0x00002FEB File Offset: 0x000011EB
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

		' Token: 0x170001DA RID: 474
		' (get) Token: 0x06000530 RID: 1328 RVA: 0x0003093C File Offset: 0x0002EB3C
		' (set) Token: 0x06000531 RID: 1329 RVA: 0x00002FF4 File Offset: 0x000011F4
		Friend Overridable Property scrI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._scrI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._scrI = value
			End Set
		End Property

		' Token: 0x170001DB RID: 475
		' (get) Token: 0x06000532 RID: 1330 RVA: 0x00030954 File Offset: 0x0002EB54
		' (set) Token: 0x06000533 RID: 1331 RVA: 0x00002FFD File Offset: 0x000011FD
		Friend Overridable Property GroupBox5 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox5
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox5 = value
			End Set
		End Property

		' Token: 0x170001DC RID: 476
		' (get) Token: 0x06000534 RID: 1332 RVA: 0x0003096C File Offset: 0x0002EB6C
		' (set) Token: 0x06000535 RID: 1333 RVA: 0x00003006 File Offset: 0x00001206
		Friend Overridable Property MICI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._MICI = value
			End Set
		End Property

		' Token: 0x170001DD RID: 477
		' (get) Token: 0x06000536 RID: 1334 RVA: 0x00030984 File Offset: 0x0002EB84
		' (set) Token: 0x06000537 RID: 1335 RVA: 0x0000300F File Offset: 0x0000120F
		Friend Overridable Property MICAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._MICAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._MICAUT = value
			End Set
		End Property

		' Token: 0x170001DE RID: 478
		' (get) Token: 0x06000538 RID: 1336 RVA: 0x0003099C File Offset: 0x0002EB9C
		' (set) Token: 0x06000539 RID: 1337 RVA: 0x00003018 File Offset: 0x00001218
		Friend Overridable Property GroupBox4 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox4
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox4 = value
			End Set
		End Property

		' Token: 0x170001DF RID: 479
		' (get) Token: 0x0600053A RID: 1338 RVA: 0x000309B4 File Offset: 0x0002EBB4
		' (set) Token: 0x0600053B RID: 1339 RVA: 0x00003021 File Offset: 0x00001221
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

		' Token: 0x170001E0 RID: 480
		' (get) Token: 0x0600053C RID: 1340 RVA: 0x000309CC File Offset: 0x0002EBCC
		' (set) Token: 0x0600053D RID: 1341 RVA: 0x0000302A File Offset: 0x0000122A
		Friend Overridable Property CAMI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._CAMI = value
			End Set
		End Property

		' Token: 0x170001E1 RID: 481
		' (get) Token: 0x0600053E RID: 1342 RVA: 0x000309E4 File Offset: 0x0002EBE4
		' (set) Token: 0x0600053F RID: 1343 RVA: 0x00003033 File Offset: 0x00001233
		Friend Overridable Property CAMAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._CAMAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._CAMAUT = value
			End Set
		End Property

		' Token: 0x170001E2 RID: 482
		' (get) Token: 0x06000540 RID: 1344 RVA: 0x000309FC File Offset: 0x0002EBFC
		' (set) Token: 0x06000541 RID: 1345 RVA: 0x0000303C File Offset: 0x0000123C
		Friend Overridable Property GroupBox3 As GroupBox
			<DebuggerNonUserCode()>
			Get
				Return Me._GroupBox3
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As GroupBox)
				Me._GroupBox3 = value
			End Set
		End Property

		' Token: 0x170001E3 RID: 483
		' (get) Token: 0x06000542 RID: 1346 RVA: 0x00030A14 File Offset: 0x0002EC14
		' (set) Token: 0x06000543 RID: 1347 RVA: 0x00003045 File Offset: 0x00001245
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

		' Token: 0x170001E4 RID: 484
		' (get) Token: 0x06000544 RID: 1348 RVA: 0x00030A2C File Offset: 0x0002EC2C
		' (set) Token: 0x06000545 RID: 1349 RVA: 0x0000304E File Offset: 0x0000124E
		Friend Overridable Property SCI As ComboBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCI
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As ComboBox)
				Me._SCI = value
			End Set
		End Property

		' Token: 0x170001E5 RID: 485
		' (get) Token: 0x06000546 RID: 1350 RVA: 0x00030A44 File Offset: 0x0002EC44
		' (set) Token: 0x06000547 RID: 1351 RVA: 0x00003057 File Offset: 0x00001257
		Friend Overridable Property SCAUT As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._SCAUT
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._SCAUT = value
			End Set
		End Property

		' Token: 0x170001E6 RID: 486
		' (get) Token: 0x06000548 RID: 1352 RVA: 0x00030A5C File Offset: 0x0002EC5C
		' (set) Token: 0x06000549 RID: 1353 RVA: 0x00003060 File Offset: 0x00001260
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

		' Token: 0x170001E7 RID: 487
		' (get) Token: 0x0600054A RID: 1354 RVA: 0x00030A74 File Offset: 0x0002EC74
		' (set) Token: 0x0600054B RID: 1355 RVA: 0x00003069 File Offset: 0x00001269
		Friend Overridable Property LOGLOGIN As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLOGIN
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLOGIN = value
			End Set
		End Property

		' Token: 0x170001E8 RID: 488
		' (get) Token: 0x0600054C RID: 1356 RVA: 0x00030A8C File Offset: 0x0002EC8C
		' (set) Token: 0x0600054D RID: 1357 RVA: 0x00003072 File Offset: 0x00001272
		Friend Overridable Property LOGCONNECTIONS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGCONNECTIONS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGCONNECTIONS = value
			End Set
		End Property

		' Token: 0x170001E9 RID: 489
		' (get) Token: 0x0600054E RID: 1358 RVA: 0x00030AA4 File Offset: 0x0002ECA4
		' (set) Token: 0x0600054F RID: 1359 RVA: 0x0000307B File Offset: 0x0000127B
		Friend Overridable Property LOGLERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGLERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGLERR = value
			End Set
		End Property

		' Token: 0x170001EA RID: 490
		' (get) Token: 0x06000550 RID: 1360 RVA: 0x00030ABC File Offset: 0x0002ECBC
		' (set) Token: 0x06000551 RID: 1361 RVA: 0x00003084 File Offset: 0x00001284
		Friend Overridable Property LOGRERR As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGRERR
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGRERR = value
			End Set
		End Property

		' Token: 0x170001EB RID: 491
		' (get) Token: 0x06000552 RID: 1362 RVA: 0x00030AD4 File Offset: 0x0002ECD4
		' (set) Token: 0x06000553 RID: 1363 RVA: 0x0000308D File Offset: 0x0000128D
		Friend Overridable Property LOGMSGS As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._LOGMSGS
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._LOGMSGS = value
			End Set
		End Property

		' Token: 0x170001EC RID: 492
		' (get) Token: 0x06000554 RID: 1364 RVA: 0x00030AEC File Offset: 0x0002ECEC
		' (set) Token: 0x06000555 RID: 1365 RVA: 0x00003096 File Offset: 0x00001296
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

		' Token: 0x170001ED RID: 493
		' (get) Token: 0x06000556 RID: 1366 RVA: 0x00030B04 File Offset: 0x0002ED04
		' (set) Token: 0x06000557 RID: 1367 RVA: 0x0000309F File Offset: 0x0000129F
		Friend Overridable Property ShowAlert As CheckBox
			<DebuggerNonUserCode()>
			Get
				Return Me._ShowAlert
			End Get
			<DebuggerNonUserCode()>
			<MethodImpl(MethodImplOptions.Synchronized)>
			Set(value As CheckBox)
				Me._ShowAlert = value
			End Set
		End Property

		' Token: 0x170001EE RID: 494
		' (get) Token: 0x06000558 RID: 1368 RVA: 0x00030B1C File Offset: 0x0002ED1C
		' (set) Token: 0x06000559 RID: 1369 RVA: 0x000030A8 File Offset: 0x000012A8
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

		' Token: 0x170001EF RID: 495
		' (get) Token: 0x0600055A RID: 1370 RVA: 0x00030B34 File Offset: 0x0002ED34
		' (set) Token: 0x0600055B RID: 1371 RVA: 0x00030B4C File Offset: 0x0002ED4C
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

		' Token: 0x170001F0 RID: 496
		' (get) Token: 0x0600055C RID: 1372 RVA: 0x00030BA4 File Offset: 0x0002EDA4
		' (set) Token: 0x0600055D RID: 1373 RVA: 0x000030B1 File Offset: 0x000012B1
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

		' Token: 0x170001F1 RID: 497
		' (get) Token: 0x0600055E RID: 1374 RVA: 0x00030BBC File Offset: 0x0002EDBC
		' (set) Token: 0x0600055F RID: 1375 RVA: 0x000030BA File Offset: 0x000012BA
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

		' Token: 0x06000560 RID: 1376 RVA: 0x00030BD4 File Offset: 0x0002EDD4
		Private Sub STNG_Load(sender As Object, e As EventArgs)
			Me.SCAUT.Checked = Class7.class8_0.bool_6
			Me.SCI.SelectedIndex = Conversions.ToInteger(Class7.class8_0.string_0)
			Me.CAMAUT.Checked = Class7.class8_0.bool_7
			Me.CAMI.SelectedIndex = Class7.class8_0.int_0
			Me.MICAUT.Checked = Class7.class8_0.bool_8
			Me.LOGCONNECTIONS.Checked = Class7.class8_0.bool_2
			Me.LOGLERR.Checked = Class7.class8_0.bool_3
			Me.LOGRERR.Checked = Class7.class8_0.bool_4
			Me.LOGMSGS.Checked = Class7.class8_0.bool_5
			Me.LOGLOGIN.Checked = Class7.class8_0.bool_1
			Me.ShowAlert.Checked = Class7.class8_0.bool_0
			Me.MICI.SelectedIndex = Class7.class8_0.int_1
			Me.scrI.SelectedIndex = Class7.class8_0.int_2
		End Sub

		' Token: 0x06000561 RID: 1377 RVA: 0x00030CF8 File Offset: 0x0002EEF8
		Private Sub Button1_Click(sender As Object, e As EventArgs)
			Class7.class8_0.bool_6 = Me.SCAUT.Checked
			Class7.class8_0.string_0 = Conversions.ToString(Me.SCI.SelectedIndex)
			Class7.class8_0.bool_7 = Me.CAMAUT.Checked
			Class7.class8_0.int_0 = Me.CAMI.SelectedIndex
			Class7.class8_0.bool_8 = Me.MICAUT.Checked
			Class7.class8_0.bool_2 = Me.LOGCONNECTIONS.Checked
			Class7.class8_0.bool_3 = Me.LOGLERR.Checked
			Class7.class8_0.bool_4 = Me.LOGRERR.Checked
			Class7.class8_0.bool_5 = Me.LOGMSGS.Checked
			Class7.class8_0.bool_1 = Me.LOGLOGIN.Checked
			Class7.class8_0.bool_0 = Me.ShowAlert.Checked
			Class7.class8_0.int_1 = Me.MICI.SelectedIndex
			Class7.class8_0.int_2 = Me.scrI.SelectedIndex
			Class7.class8_0.method_1()
			Me.Close()
		End Sub

		' Token: 0x06000562 RID: 1378 RVA: 0x00002199 File Offset: 0x00000399
		Private Sub FlatButton2_Click(sender As Object, e As EventArgs)
			Me.Close()
		End Sub

		' Token: 0x04000260 RID: 608
		Private Shared __ENCList As List(Of WeakReference) = New List(Of WeakReference)()

		' Token: 0x04000262 RID: 610
		<AccessedThroughProperty("FormSkin1")>
		Private _FormSkin1 As FormSkin

		' Token: 0x04000263 RID: 611
		<AccessedThroughProperty("Button1")>
		Private _Button1 As Button

		' Token: 0x04000264 RID: 612
		<AccessedThroughProperty("GroupBox6")>
		Private _GroupBox6 As GroupBox

		' Token: 0x04000265 RID: 613
		<AccessedThroughProperty("Label3")>
		Private _Label3 As Label

		' Token: 0x04000266 RID: 614
		<AccessedThroughProperty("scrI")>
		Private _scrI As ComboBox

		' Token: 0x04000267 RID: 615
		<AccessedThroughProperty("GroupBox5")>
		Private _GroupBox5 As GroupBox

		' Token: 0x04000268 RID: 616
		<AccessedThroughProperty("MICI")>
		Private _MICI As ComboBox

		' Token: 0x04000269 RID: 617
		<AccessedThroughProperty("MICAUT")>
		Private _MICAUT As CheckBox

		' Token: 0x0400026A RID: 618
		<AccessedThroughProperty("GroupBox4")>
		Private _GroupBox4 As GroupBox

		' Token: 0x0400026B RID: 619
		<AccessedThroughProperty("Label2")>
		Private _Label2 As Label

		' Token: 0x0400026C RID: 620
		<AccessedThroughProperty("CAMI")>
		Private _CAMI As ComboBox

		' Token: 0x0400026D RID: 621
		<AccessedThroughProperty("CAMAUT")>
		Private _CAMAUT As CheckBox

		' Token: 0x0400026E RID: 622
		<AccessedThroughProperty("GroupBox3")>
		Private _GroupBox3 As GroupBox

		' Token: 0x0400026F RID: 623
		<AccessedThroughProperty("Label1")>
		Private _Label1 As Label

		' Token: 0x04000270 RID: 624
		<AccessedThroughProperty("SCI")>
		Private _SCI As ComboBox

		' Token: 0x04000271 RID: 625
		<AccessedThroughProperty("SCAUT")>
		Private _SCAUT As CheckBox

		' Token: 0x04000272 RID: 626
		<AccessedThroughProperty("GroupBox2")>
		Private _GroupBox2 As GroupBox

		' Token: 0x04000273 RID: 627
		<AccessedThroughProperty("LOGLOGIN")>
		Private _LOGLOGIN As CheckBox

		' Token: 0x04000274 RID: 628
		<AccessedThroughProperty("LOGCONNECTIONS")>
		Private _LOGCONNECTIONS As CheckBox

		' Token: 0x04000275 RID: 629
		<AccessedThroughProperty("LOGLERR")>
		Private _LOGLERR As CheckBox

		' Token: 0x04000276 RID: 630
		<AccessedThroughProperty("LOGRERR")>
		Private _LOGRERR As CheckBox

		' Token: 0x04000277 RID: 631
		<AccessedThroughProperty("LOGMSGS")>
		Private _LOGMSGS As CheckBox

		' Token: 0x04000278 RID: 632
		<AccessedThroughProperty("GroupBox1")>
		Private _GroupBox1 As GroupBox

		' Token: 0x04000279 RID: 633
		<AccessedThroughProperty("ShowAlert")>
		Private _ShowAlert As CheckBox

		' Token: 0x0400027A RID: 634
		<AccessedThroughProperty("FlatMini2")>
		Private _FlatMini2 As FlatMini

		' Token: 0x0400027B RID: 635
		<AccessedThroughProperty("FlatButton2")>
		Private _FlatButton2 As FlatButton

		' Token: 0x0400027C RID: 636
		<AccessedThroughProperty("PictureBox4")>
		Private _PictureBox4 As PictureBox

		' Token: 0x0400027D RID: 637
		<AccessedThroughProperty("UserImage1")>
		Private _UserImage1 As UserImage
	End Class
End Namespace
