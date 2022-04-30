Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000004 RID: 4
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "8.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x06000009 RID: 9 RVA: 0x00003FEC File Offset: 0x000021EC
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x0600000A RID: 10 RVA: 0x00004008 File Offset: 0x00002208
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00004024 File Offset: 0x00002224
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00004040 File Offset: 0x00002240
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000D RID: 13 RVA: 0x0000405C File Offset: 0x0000225C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000002 RID: 2
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000003 RID: 3
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000004 RID: 4
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000005 RID: 5
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000006 RID: 6
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000005 RID: 5
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x17000006 RID: 6
			' (get) Token: 0x0600000E RID: 14 RVA: 0x00004078 File Offset: 0x00002278
			' (set) Token: 0x06000024 RID: 36 RVA: 0x000043E8 File Offset: 0x000025E8
			Public Property About As About
				<DebuggerNonUserCode()>
				Get
					Me.m_About = MyProject.MyForms.Create__Instance__(Of About)(Me.m_About)
					Return Me.m_About
				End Get
				<DebuggerNonUserCode()>
				Set(value As About)
					If value IsNot Me.m_About Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of About)(Me.m_About)
					End If
				End Set
			End Property

			' Token: 0x17000007 RID: 7
			' (get) Token: 0x0600000F RID: 15 RVA: 0x000040A0 File Offset: 0x000022A0
			' (set) Token: 0x06000025 RID: 37 RVA: 0x00004420 File Offset: 0x00002620
			Public Property Asemb As Asemb
				<DebuggerNonUserCode()>
				Get
					Me.m_Asemb = MyProject.MyForms.Create__Instance__(Of Asemb)(Me.m_Asemb)
					Return Me.m_Asemb
				End Get
				<DebuggerNonUserCode()>
				Set(value As Asemb)
					If value IsNot Me.m_Asemb Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Asemb)(Me.m_Asemb)
					End If
				End Set
			End Property

			' Token: 0x17000008 RID: 8
			' (get) Token: 0x06000010 RID: 16 RVA: 0x000040C8 File Offset: 0x000022C8
			' (set) Token: 0x06000026 RID: 38 RVA: 0x00004458 File Offset: 0x00002658
			Public Property Builder As Builder
				<DebuggerNonUserCode()>
				Get
					Me.m_Builder = MyProject.MyForms.Create__Instance__(Of Builder)(Me.m_Builder)
					Return Me.m_Builder
				End Get
				<DebuggerNonUserCode()>
				Set(value As Builder)
					If value IsNot Me.m_Builder Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Builder)(Me.m_Builder)
					End If
				End Set
			End Property

			' Token: 0x17000009 RID: 9
			' (get) Token: 0x06000011 RID: 17 RVA: 0x000040F0 File Offset: 0x000022F0
			' (set) Token: 0x06000027 RID: 39 RVA: 0x00004490 File Offset: 0x00002690
			Public Property Cam As Cam
				<DebuggerNonUserCode()>
				Get
					Me.m_Cam = MyProject.MyForms.Create__Instance__(Of Cam)(Me.m_Cam)
					Return Me.m_Cam
				End Get
				<DebuggerNonUserCode()>
				Set(value As Cam)
					If value IsNot Me.m_Cam Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Cam)(Me.m_Cam)
					End If
				End Set
			End Property

			' Token: 0x1700000A RID: 10
			' (get) Token: 0x06000012 RID: 18 RVA: 0x00004118 File Offset: 0x00002318
			' (set) Token: 0x06000028 RID: 40 RVA: 0x000044C8 File Offset: 0x000026C8
			Public Property Chat As Chat
				<DebuggerNonUserCode()>
				Get
					Me.m_Chat = MyProject.MyForms.Create__Instance__(Of Chat)(Me.m_Chat)
					Return Me.m_Chat
				End Get
				<DebuggerNonUserCode()>
				Set(value As Chat)
					If value IsNot Me.m_Chat Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Chat)(Me.m_Chat)
					End If
				End Set
			End Property

			' Token: 0x1700000B RID: 11
			' (get) Token: 0x06000013 RID: 19 RVA: 0x00004140 File Offset: 0x00002340
			' (set) Token: 0x06000029 RID: 41 RVA: 0x00004500 File Offset: 0x00002700
			Public Property DW As DW
				<DebuggerNonUserCode()>
				Get
					Me.m_DW = MyProject.MyForms.Create__Instance__(Of DW)(Me.m_DW)
					Return Me.m_DW
				End Get
				<DebuggerNonUserCode()>
				Set(value As DW)
					If value IsNot Me.m_DW Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of DW)(Me.m_DW)
					End If
				End Set
			End Property

			' Token: 0x1700000C RID: 12
			' (get) Token: 0x06000014 RID: 20 RVA: 0x00004168 File Offset: 0x00002368
			' (set) Token: 0x0600002A RID: 42 RVA: 0x00004538 File Offset: 0x00002738
			Public Property Form1 As Form1
				<DebuggerNonUserCode()>
				Get
					Me.m_Form1 = MyProject.MyForms.Create__Instance__(Of Form1)(Me.m_Form1)
					Return Me.m_Form1
				End Get
				<DebuggerNonUserCode()>
				Set(value As Form1)
					If value IsNot Me.m_Form1 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Form1)(Me.m_Form1)
					End If
				End Set
			End Property

			' Token: 0x1700000D RID: 13
			' (get) Token: 0x06000015 RID: 21 RVA: 0x00004190 File Offset: 0x00002390
			' (set) Token: 0x0600002B RID: 43 RVA: 0x00004570 File Offset: 0x00002770
			Public Property FromLink As FromLink
				<DebuggerNonUserCode()>
				Get
					Me.m_FromLink = MyProject.MyForms.Create__Instance__(Of FromLink)(Me.m_FromLink)
					Return Me.m_FromLink
				End Get
				<DebuggerNonUserCode()>
				Set(value As FromLink)
					If value IsNot Me.m_FromLink Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FromLink)(Me.m_FromLink)
					End If
				End Set
			End Property

			' Token: 0x1700000E RID: 14
			' (get) Token: 0x06000016 RID: 22 RVA: 0x000041B8 File Offset: 0x000023B8
			' (set) Token: 0x0600002C RID: 44 RVA: 0x000045A8 File Offset: 0x000027A8
			Public Property FURL As FURL
				<DebuggerNonUserCode()>
				Get
					Me.m_FURL = MyProject.MyForms.Create__Instance__(Of FURL)(Me.m_FURL)
					Return Me.m_FURL
				End Get
				<DebuggerNonUserCode()>
				Set(value As FURL)
					If value IsNot Me.m_FURL Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FURL)(Me.m_FURL)
					End If
				End Set
			End Property

			' Token: 0x1700000F RID: 15
			' (get) Token: 0x06000017 RID: 23 RVA: 0x000041E0 File Offset: 0x000023E0
			' (set) Token: 0x0600002D RID: 45 RVA: 0x000045E0 File Offset: 0x000027E0
			Public Property kl As kl
				<DebuggerNonUserCode()>
				Get
					Me.m_kl = MyProject.MyForms.Create__Instance__(Of kl)(Me.m_kl)
					Return Me.m_kl
				End Get
				<DebuggerNonUserCode()>
				Set(value As kl)
					If value IsNot Me.m_kl Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of kl)(Me.m_kl)
					End If
				End Set
			End Property

			' Token: 0x17000010 RID: 16
			' (get) Token: 0x06000018 RID: 24 RVA: 0x00004208 File Offset: 0x00002408
			' (set) Token: 0x0600002E RID: 46 RVA: 0x00004618 File Offset: 0x00002818
			Public Property Manager As Manager
				<DebuggerNonUserCode()>
				Get
					Me.m_Manager = MyProject.MyForms.Create__Instance__(Of Manager)(Me.m_Manager)
					Return Me.m_Manager
				End Get
				<DebuggerNonUserCode()>
				Set(value As Manager)
					If value IsNot Me.m_Manager Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Manager)(Me.m_Manager)
					End If
				End Set
			End Property

			' Token: 0x17000011 RID: 17
			' (get) Token: 0x06000019 RID: 25 RVA: 0x00004230 File Offset: 0x00002430
			' (set) Token: 0x0600002F RID: 47 RVA: 0x00004650 File Offset: 0x00002850
			Public Property Mic As Mic
				<DebuggerNonUserCode()>
				Get
					Me.m_Mic = MyProject.MyForms.Create__Instance__(Of Mic)(Me.m_Mic)
					Return Me.m_Mic
				End Get
				<DebuggerNonUserCode()>
				Set(value As Mic)
					If value IsNot Me.m_Mic Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Mic)(Me.m_Mic)
					End If
				End Set
			End Property

			' Token: 0x17000012 RID: 18
			' (get) Token: 0x0600001A RID: 26 RVA: 0x00004258 File Offset: 0x00002458
			' (set) Token: 0x06000030 RID: 48 RVA: 0x00004688 File Offset: 0x00002888
			Public Property Mynoip As Mynoip
				<DebuggerNonUserCode()>
				Get
					Me.m_Mynoip = MyProject.MyForms.Create__Instance__(Of Mynoip)(Me.m_Mynoip)
					Return Me.m_Mynoip
				End Get
				<DebuggerNonUserCode()>
				Set(value As Mynoip)
					If value IsNot Me.m_Mynoip Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Mynoip)(Me.m_Mynoip)
					End If
				End Set
			End Property

			' Token: 0x17000013 RID: 19
			' (get) Token: 0x0600001B RID: 27 RVA: 0x00004280 File Offset: 0x00002480
			' (set) Token: 0x06000031 RID: 49 RVA: 0x000046C0 File Offset: 0x000028C0
			Public Property Note As Note
				<DebuggerNonUserCode()>
				Get
					Me.m_Note = MyProject.MyForms.Create__Instance__(Of Note)(Me.m_Note)
					Return Me.m_Note
				End Get
				<DebuggerNonUserCode()>
				Set(value As Note)
					If value IsNot Me.m_Note Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Note)(Me.m_Note)
					End If
				End Set
			End Property

			' Token: 0x17000014 RID: 20
			' (get) Token: 0x0600001C RID: 28 RVA: 0x000042A8 File Offset: 0x000024A8
			' (set) Token: 0x06000032 RID: 50 RVA: 0x000046F8 File Offset: 0x000028F8
			Public Property notf As notf
				<DebuggerNonUserCode()>
				Get
					Me.m_notf = MyProject.MyForms.Create__Instance__(Of notf)(Me.m_notf)
					Return Me.m_notf
				End Get
				<DebuggerNonUserCode()>
				Set(value As notf)
					If value IsNot Me.m_notf Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of notf)(Me.m_notf)
					End If
				End Set
			End Property

			' Token: 0x17000015 RID: 21
			' (get) Token: 0x0600001D RID: 29 RVA: 0x000042D0 File Offset: 0x000024D0
			' (set) Token: 0x06000033 RID: 51 RVA: 0x00004730 File Offset: 0x00002930
			Public Property Pass As Pass
				<DebuggerNonUserCode()>
				Get
					Me.m_Pass = MyProject.MyForms.Create__Instance__(Of Pass)(Me.m_Pass)
					Return Me.m_Pass
				End Get
				<DebuggerNonUserCode()>
				Set(value As Pass)
					If value IsNot Me.m_Pass Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Pass)(Me.m_Pass)
					End If
				End Set
			End Property

			' Token: 0x17000016 RID: 22
			' (get) Token: 0x0600001E RID: 30 RVA: 0x000042F8 File Offset: 0x000024F8
			' (set) Token: 0x06000034 RID: 52 RVA: 0x00004768 File Offset: 0x00002968
			Public Property port As port
				<DebuggerNonUserCode()>
				Get
					Me.m_port = MyProject.MyForms.Create__Instance__(Of port)(Me.m_port)
					Return Me.m_port
				End Get
				<DebuggerNonUserCode()>
				Set(value As port)
					If value IsNot Me.m_port Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of port)(Me.m_port)
					End If
				End Set
			End Property

			' Token: 0x17000017 RID: 23
			' (get) Token: 0x0600001F RID: 31 RVA: 0x00004320 File Offset: 0x00002520
			' (set) Token: 0x06000035 RID: 53 RVA: 0x000047A0 File Offset: 0x000029A0
			Public Property RGv As RGv
				<DebuggerNonUserCode()>
				Get
					Me.m_RGv = MyProject.MyForms.Create__Instance__(Of RGv)(Me.m_RGv)
					Return Me.m_RGv
				End Get
				<DebuggerNonUserCode()>
				Set(value As RGv)
					If value IsNot Me.m_RGv Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of RGv)(Me.m_RGv)
					End If
				End Set
			End Property

			' Token: 0x17000018 RID: 24
			' (get) Token: 0x06000020 RID: 32 RVA: 0x00004348 File Offset: 0x00002548
			' (set) Token: 0x06000036 RID: 54 RVA: 0x000047D8 File Offset: 0x000029D8
			Public Property sc As sc
				<DebuggerNonUserCode()>
				Get
					Me.m_sc = MyProject.MyForms.Create__Instance__(Of sc)(Me.m_sc)
					Return Me.m_sc
				End Get
				<DebuggerNonUserCode()>
				Set(value As sc)
					If value IsNot Me.m_sc Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of sc)(Me.m_sc)
					End If
				End Set
			End Property

			' Token: 0x17000019 RID: 25
			' (get) Token: 0x06000021 RID: 33 RVA: 0x00004370 File Offset: 0x00002570
			' (set) Token: 0x06000037 RID: 55 RVA: 0x00004810 File Offset: 0x00002A10
			Public Property script As script
				<DebuggerNonUserCode()>
				Get
					Me.m_script = MyProject.MyForms.Create__Instance__(Of script)(Me.m_script)
					Return Me.m_script
				End Get
				<DebuggerNonUserCode()>
				Set(value As script)
					If value IsNot Me.m_script Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of script)(Me.m_script)
					End If
				End Set
			End Property

			' Token: 0x1700001A RID: 26
			' (get) Token: 0x06000022 RID: 34 RVA: 0x00004398 File Offset: 0x00002598
			' (set) Token: 0x06000038 RID: 56 RVA: 0x00004848 File Offset: 0x00002A48
			Public Property STNG As STNG
				<DebuggerNonUserCode()>
				Get
					Me.m_STNG = MyProject.MyForms.Create__Instance__(Of STNG)(Me.m_STNG)
					Return Me.m_STNG
				End Get
				<DebuggerNonUserCode()>
				Set(value As STNG)
					If value IsNot Me.m_STNG Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of STNG)(Me.m_STNG)
					End If
				End Set
			End Property

			' Token: 0x1700001B RID: 27
			' (get) Token: 0x06000023 RID: 35 RVA: 0x000043C0 File Offset: 0x000025C0
			' (set) Token: 0x06000039 RID: 57 RVA: 0x00004880 File Offset: 0x00002A80
			Public Property up As up
				<DebuggerNonUserCode()>
				Get
					Me.m_up = MyProject.MyForms.Create__Instance__(Of up)(Me.m_up)
					Return Me.m_up
				End Get
				<DebuggerNonUserCode()>
				Set(value As up)
					If value IsNot Me.m_up Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of up)(Me.m_up)
					End If
				End Set
			End Property

			' Token: 0x0600003A RID: 58 RVA: 0x000048B8 File Offset: 0x00002AB8
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim result As T
				If Instance IsNot Nothing AndAlso Not Instance.IsDisposed Then
					result = Instance
				Else
					If MyProject.MyForms.m_FormBeingCreated IsNot Nothing Then
						If MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T)) Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						result = Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return result
			End Function

			' Token: 0x0600003B RID: 59 RVA: 0x000049C8 File Offset: 0x00002BC8
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x0600003C RID: 60 RVA: 0x000020D7 File Offset: 0x000002D7
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub

			' Token: 0x0600003D RID: 61 RVA: 0x000049F0 File Offset: 0x00002BF0
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x0600003E RID: 62 RVA: 0x00004A0C File Offset: 0x00002C0C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x0600003F RID: 63 RVA: 0x00004A24 File Offset: 0x00002C24
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x06000040 RID: 64 RVA: 0x00004A40 File Offset: 0x00002C40
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x04000007 RID: 7
			Public m_About As About

			' Token: 0x04000008 RID: 8
			Public m_Asemb As Asemb

			' Token: 0x04000009 RID: 9
			Public m_Builder As Builder

			' Token: 0x0400000A RID: 10
			Public m_Cam As Cam

			' Token: 0x0400000B RID: 11
			Public m_Chat As Chat

			' Token: 0x0400000C RID: 12
			Public m_DW As DW

			' Token: 0x0400000D RID: 13
			Public m_Form1 As Form1

			' Token: 0x0400000E RID: 14
			Public m_FromLink As FromLink

			' Token: 0x0400000F RID: 15
			Public m_FURL As FURL

			' Token: 0x04000010 RID: 16
			Public m_kl As kl

			' Token: 0x04000011 RID: 17
			Public m_Manager As Manager

			' Token: 0x04000012 RID: 18
			Public m_Mic As Mic

			' Token: 0x04000013 RID: 19
			Public m_Mynoip As Mynoip

			' Token: 0x04000014 RID: 20
			Public m_Note As Note

			' Token: 0x04000015 RID: 21
			Public m_notf As notf

			' Token: 0x04000016 RID: 22
			Public m_Pass As Pass

			' Token: 0x04000017 RID: 23
			Public m_port As port

			' Token: 0x04000018 RID: 24
			Public m_RGv As RGv

			' Token: 0x04000019 RID: 25
			Public m_sc As sc

			' Token: 0x0400001A RID: 26
			Public m_script As script

			' Token: 0x0400001B RID: 27
			Public m_STNG As STNG

			' Token: 0x0400001C RID: 28
			Public m_up As up

			' Token: 0x0400001D RID: 29
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable
		End Class

		' Token: 0x02000006 RID: 6
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class MyWebServices
			' Token: 0x06000041 RID: 65 RVA: 0x000049F0 File Offset: 0x00002BF0
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06000042 RID: 66 RVA: 0x00004A0C File Offset: 0x00002C0C
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06000043 RID: 67 RVA: 0x00004A58 File Offset: 0x00002C58
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x06000044 RID: 68 RVA: 0x00004A40 File Offset: 0x00002C40
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x06000045 RID: 69 RVA: 0x00004A74 File Offset: 0x00002C74
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim result As T
				If instance Is Nothing Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x06000046 RID: 70 RVA: 0x00004A98 File Offset: 0x00002C98
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x06000047 RID: 71 RVA: 0x000020D7 File Offset: 0x000002D7
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x02000007 RID: 7
		<ComVisible(False)>
		<EditorBrowsable(EditorBrowsableState.Never)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x1700001C RID: 28
			' (get) Token: 0x06000048 RID: 72 RVA: 0x00004AB4 File Offset: 0x00002CB4
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					If MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x06000049 RID: 73 RVA: 0x000020D7 File Offset: 0x000002D7
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x0400001E RID: 30
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
