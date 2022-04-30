Imports System
Imports System.CodeDom.Compiler
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Globalization
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My.Resources
	' Token: 0x0200006E RID: 110
	<GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")>
	<HideModuleName()>
	<CompilerGenerated()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module Resources
		' Token: 0x1700026E RID: 622
		' (get) Token: 0x06000803 RID: 2051 RVA: 0x000462A8 File Offset: 0x000444A8
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend ReadOnly Property ResourceManager As ResourceManager
			Get
				If Object.ReferenceEquals(Resources.resourceMan, Nothing) Then
					Dim resourceManager As ResourceManager = New ResourceManager("NJRAT.Resources", GetType(Resources).Assembly)
					Resources.resourceMan = resourceManager
				End If
				Return Resources.resourceMan
			End Get
		End Property

		' Token: 0x1700026F RID: 623
		' (get) Token: 0x06000804 RID: 2052 RVA: 0x000462EC File Offset: 0x000444EC
		' (set) Token: 0x06000805 RID: 2053 RVA: 0x00003E94 File Offset: 0x00002094
		<EditorBrowsable(EditorBrowsableState.Advanced)>
		Friend Property Culture As CultureInfo
			Get
				Return Resources.resourceCulture
			End Get
			Set(value As CultureInfo)
				Resources.resourceCulture = value
			End Set
		End Property

		' Token: 0x17000270 RID: 624
		' (get) Token: 0x06000806 RID: 2054 RVA: 0x00046300 File Offset: 0x00044500
		Friend ReadOnly Property bullet_arrow_down As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_down", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000271 RID: 625
		' (get) Token: 0x06000807 RID: 2055 RVA: 0x00046330 File Offset: 0x00044530
		Friend ReadOnly Property bullet_arrow_up As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("bullet_arrow_up", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000272 RID: 626
		' (get) Token: 0x06000808 RID: 2056 RVA: 0x00046360 File Offset: 0x00044560
		Friend ReadOnly Property control_pause_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_pause_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000273 RID: 627
		' (get) Token: 0x06000809 RID: 2057 RVA: 0x00046390 File Offset: 0x00044590
		Friend ReadOnly Property control_play_blue As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("control_play_blue", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000274 RID: 628
		' (get) Token: 0x0600080A RID: 2058 RVA: 0x000463C0 File Offset: 0x000445C0
		Friend ReadOnly Property dotNET_Reactor As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("dotNET_Reactor", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x17000275 RID: 629
		' (get) Token: 0x0600080B RID: 2059 RVA: 0x000463F0 File Offset: 0x000445F0
		Friend ReadOnly Property icon As Icon
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("icon", Resources.resourceCulture))
				Return CType(objectValue, Icon)
			End Get
		End Property

		' Token: 0x17000276 RID: 630
		' (get) Token: 0x0600080C RID: 2060 RVA: 0x00046420 File Offset: 0x00044620
		Friend ReadOnly Property JPEG As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("JPEG", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000277 RID: 631
		' (get) Token: 0x0600080D RID: 2061 RVA: 0x00046450 File Offset: 0x00044650
		Friend ReadOnly Property mpress As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("mpress", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x17000278 RID: 632
		' (get) Token: 0x0600080E RID: 2062 RVA: 0x00046480 File Offset: 0x00044680
		Friend ReadOnly Property noip_logo As Bitmap
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("noip_logo", Resources.resourceCulture))
				Return CType(objectValue, Bitmap)
			End Get
		End Property

		' Token: 0x17000279 RID: 633
		' (get) Token: 0x0600080F RID: 2063 RVA: 0x000464B0 File Offset: 0x000446B0
		Friend ReadOnly Property notf As String
			Get
				Return Resources.ResourceManager.GetString("notf", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700027A RID: 634
		' (get) Token: 0x06000810 RID: 2064 RVA: 0x000464D4 File Offset: 0x000446D4
		Friend ReadOnly Property Res As Byte()
			Get
				Dim objectValue As Object = RuntimeHelpers.GetObjectValue(Resources.ResourceManager.GetObject("Res", Resources.resourceCulture))
				Return CType(objectValue, Byte())
			End Get
		End Property

		' Token: 0x1700027B RID: 635
		' (get) Token: 0x06000811 RID: 2065 RVA: 0x00046504 File Offset: 0x00044704
		Friend ReadOnly Property RHDiscription As String
			Get
				Return Resources.ResourceManager.GetString("RHDiscription", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x1700027C RID: 636
		' (get) Token: 0x06000812 RID: 2066 RVA: 0x00046528 File Offset: 0x00044728
		Friend ReadOnly Property RichTextBox1 As String
			Get
				Return Resources.ResourceManager.GetString("RichTextBox1", Resources.resourceCulture)
			End Get
		End Property

		' Token: 0x04000481 RID: 1153
		Private resourceMan As ResourceManager

		' Token: 0x04000482 RID: 1154
		Private resourceCulture As CultureInfo
	End Module
End Namespace
