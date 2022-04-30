Imports System
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices

Namespace NJRAT.My
	' Token: 0x02000070 RID: 112
	<CompilerGenerated()>
	<HideModuleName()>
	<DebuggerNonUserCode()>
	Friend NotInheritable Module MySettingsProperty
		' Token: 0x1700027E RID: 638
		' (get) Token: 0x06000817 RID: 2071 RVA: 0x000465E0 File Offset: 0x000447E0
		<HelpKeyword("My.Settings")>
		Friend ReadOnly Property Settings As MySettings
			Get
				Return MySettings.[Default]
			End Get
		End Property
	End Module
End Namespace
