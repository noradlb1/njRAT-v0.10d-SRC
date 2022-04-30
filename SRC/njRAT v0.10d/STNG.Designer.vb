Namespace NJRAT
	' Token: 0x02000020 RID: 32
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class STNG
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000526 RID: 1318 RVA: 0x0002EC8C File Offset: 0x0002CE8C
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				If disposing AndAlso Me.components IsNot Nothing Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x06000527 RID: 1319 RVA: 0x0002ECCC File Offset: 0x0002CECC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.STNG))
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.GroupBox6 = New Global.System.Windows.Forms.GroupBox()
			Me.Label3 = New Global.System.Windows.Forms.Label()
			Me.scrI = New Global.System.Windows.Forms.ComboBox()
			Me.GroupBox5 = New Global.System.Windows.Forms.GroupBox()
			Me.MICI = New Global.System.Windows.Forms.ComboBox()
			Me.MICAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox4 = New Global.System.Windows.Forms.GroupBox()
			Me.Label2 = New Global.System.Windows.Forms.Label()
			Me.CAMI = New Global.System.Windows.Forms.ComboBox()
			Me.CAMAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox3 = New Global.System.Windows.Forms.GroupBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.SCI = New Global.System.Windows.Forms.ComboBox()
			Me.SCAUT = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox2 = New Global.System.Windows.Forms.GroupBox()
			Me.LOGLOGIN = New Global.System.Windows.Forms.CheckBox()
			Me.LOGCONNECTIONS = New Global.System.Windows.Forms.CheckBox()
			Me.LOGLERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGRERR = New Global.System.Windows.Forms.CheckBox()
			Me.LOGMSGS = New Global.System.Windows.Forms.CheckBox()
			Me.GroupBox1 = New Global.System.Windows.Forms.GroupBox()
			Me.ShowAlert = New Global.System.Windows.Forms.CheckBox()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FormSkin1.SuspendLayout()
			Me.GroupBox6.SuspendLayout()
			Me.GroupBox5.SuspendLayout()
			Me.GroupBox4.SuspendLayout()
			Me.GroupBox3.SuspendLayout()
			Me.GroupBox2.SuspendLayout()
			Me.GroupBox1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.GroupBox6)
			Me.FormSkin1.Controls.Add(Me.GroupBox5)
			Me.FormSkin1.Controls.Add(Me.GroupBox4)
			Me.FormSkin1.Controls.Add(Me.GroupBox3)
			Me.FormSkin1.Controls.Add(Me.GroupBox2)
			Me.FormSkin1.Controls.Add(Me.GroupBox1)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(486, 366)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 0
			Me.FormSkin1.Text = "Settings"
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(188, 318)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			Dim padding As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = padding
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(278, 31)
			button3.Size = size
			Me.Button1.TabIndex = 13
			Me.Button1.Text = "Save"
			Me.Button1.UseVisualStyleBackColor = False
			Me.GroupBox6.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox6.Controls.Add(Me.Label3)
			Me.GroupBox6.Controls.Add(Me.scrI)
			Me.GroupBox6.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox6.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox As Global.System.Windows.Forms.Control = Me.GroupBox6
			location = New Global.System.Drawing.Point(330, 231)
			groupBox.Location = location
			Dim groupBox2 As Global.System.Windows.Forms.Control = Me.GroupBox6
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox2.Margin = padding
			Me.GroupBox6.Name = "GroupBox6"
			Dim groupBox3 As Global.System.Windows.Forms.Control = Me.GroupBox6
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox3.Padding = padding
			Me.GroupBox6.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox4 As Global.System.Windows.Forms.Control = Me.GroupBox6
			size = New Global.System.Drawing.Size(136, 79)
			groupBox4.Size = size
			Me.GroupBox6.TabIndex = 12
			Me.GroupBox6.TabStop = False
			Me.GroupBox6.Text = "Screen"
			Me.Label3.AutoSize = True
			Me.Label3.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim label As Global.System.Windows.Forms.Control = Me.Label3
			location = New Global.System.Drawing.Point(6, 17)
			label.Location = location
			Me.Label3.Name = "Label3"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label3
			size = New Global.System.Drawing.Size(113, 16)
			label2.Size = size
			Me.Label3.TabIndex = 3
			Me.Label3.Text = "Refresh Speed"
			Me.scrI.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.scrI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.scrI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.scrI.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.scrI.FormattingEnabled = True
			Me.scrI.Items.AddRange(New Object() { "Ultra", "Fast", "Good", "Slow", "Slower" })
			Dim scrI As Global.System.Windows.Forms.Control = Me.scrI
			location = New Global.System.Drawing.Point(7, 44)
			scrI.Location = location
			Dim scrI2 As Global.System.Windows.Forms.Control = Me.scrI
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			scrI2.Margin = padding
			Me.scrI.Name = "scrI"
			Me.scrI.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim scrI3 As Global.System.Windows.Forms.Control = Me.scrI
			size = New Global.System.Drawing.Size(122, 24)
			scrI3.Size = size
			Me.scrI.TabIndex = 2
			Me.GroupBox5.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox5.Controls.Add(Me.MICI)
			Me.GroupBox5.Controls.Add(Me.MICAUT)
			Me.GroupBox5.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox5.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox5 As Global.System.Windows.Forms.Control = Me.GroupBox5
			location = New Global.System.Drawing.Point(188, 230)
			groupBox5.Location = location
			Dim groupBox6 As Global.System.Windows.Forms.Control = Me.GroupBox5
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox6.Margin = padding
			Me.GroupBox5.Name = "GroupBox5"
			Dim groupBox7 As Global.System.Windows.Forms.Control = Me.GroupBox5
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox7.Padding = padding
			Dim groupBox8 As Global.System.Windows.Forms.Control = Me.GroupBox5
			size = New Global.System.Drawing.Size(134, 79)
			groupBox8.Size = size
			Me.GroupBox5.TabIndex = 11
			Me.GroupBox5.TabStop = False
			Me.GroupBox5.Text = "Remote MIC"
			Me.MICI.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.MICI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.MICI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.MICI.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.MICI.FormattingEnabled = True
			Me.MICI.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Dim mici As Global.System.Windows.Forms.Control = Me.MICI
			location = New Global.System.Drawing.Point(7, 44)
			mici.Location = location
			Dim mici2 As Global.System.Windows.Forms.Control = Me.MICI
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			mici2.Margin = padding
			Me.MICI.Name = "MICI"
			Dim mici3 As Global.System.Windows.Forms.Control = Me.MICI
			size = New Global.System.Drawing.Size(119, 24)
			mici3.Size = size
			Me.MICI.TabIndex = 2
			Me.MICAUT.AutoSize = True
			Dim micaut As Global.System.Windows.Forms.Control = Me.MICAUT
			location = New Global.System.Drawing.Point(7, 23)
			micaut.Location = location
			Dim micaut2 As Global.System.Windows.Forms.Control = Me.MICAUT
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			micaut2.Margin = padding
			Me.MICAUT.Name = "MICAUT"
			Me.MICAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim micaut3 As Global.System.Windows.Forms.Control = Me.MICAUT
			size = New Global.System.Drawing.Size(89, 21)
			micaut3.Size = size
			Me.MICAUT.TabIndex = 1
			Me.MICAUT.Text = "AutoStart"
			Me.MICAUT.UseVisualStyleBackColor = True
			Me.GroupBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox4.Controls.Add(Me.Label2)
			Me.GroupBox4.Controls.Add(Me.CAMI)
			Me.GroupBox4.Controls.Add(Me.CAMAUT)
			Me.GroupBox4.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox4.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox9 As Global.System.Windows.Forms.Control = Me.GroupBox4
			location = New Global.System.Drawing.Point(188, 145)
			groupBox9.Location = location
			Dim groupBox10 As Global.System.Windows.Forms.Control = Me.GroupBox4
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox10.Margin = padding
			Me.GroupBox4.Name = "GroupBox4"
			Dim groupBox11 As Global.System.Windows.Forms.Control = Me.GroupBox4
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox11.Padding = padding
			Dim groupBox12 As Global.System.Windows.Forms.Control = Me.GroupBox4
			size = New Global.System.Drawing.Size(134, 79)
			groupBox12.Size = size
			Me.GroupBox4.TabIndex = 10
			Me.GroupBox4.TabStop = False
			Me.GroupBox4.Text = "Remote Cam"
			Me.Label2.AutoSize = True
			Dim label3 As Global.System.Windows.Forms.Control = Me.Label2
			location = New Global.System.Drawing.Point(7, 48)
			label3.Location = location
			Me.Label2.Name = "Label2"
			Dim label4 As Global.System.Windows.Forms.Control = Me.Label2
			size = New Global.System.Drawing.Size(31, 17)
			label4.Size = size
			Me.Label2.TabIndex = 3
			Me.Label2.Text = "Size"
			Me.CAMI.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.CAMI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.CAMI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CAMI.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.CAMI.FormattingEnabled = True
			Me.CAMI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim cami As Global.System.Windows.Forms.Control = Me.CAMI
			location = New Global.System.Drawing.Point(44, 44)
			cami.Location = location
			Dim cami2 As Global.System.Windows.Forms.Control = Me.CAMI
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			cami2.Margin = padding
			Me.CAMI.Name = "CAMI"
			Dim cami3 As Global.System.Windows.Forms.Control = Me.CAMI
			size = New Global.System.Drawing.Size(82, 24)
			cami3.Size = size
			Me.CAMI.TabIndex = 2
			Me.CAMAUT.AutoSize = True
			Me.CAMAUT.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim camaut As Global.System.Windows.Forms.Control = Me.CAMAUT
			location = New Global.System.Drawing.Point(7, 23)
			camaut.Location = location
			Dim camaut2 As Global.System.Windows.Forms.Control = Me.CAMAUT
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			camaut2.Margin = padding
			Me.CAMAUT.Name = "CAMAUT"
			Me.CAMAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim camaut3 As Global.System.Windows.Forms.Control = Me.CAMAUT
			size = New Global.System.Drawing.Size(89, 21)
			camaut3.Size = size
			Me.CAMAUT.TabIndex = 1
			Me.CAMAUT.Text = "AutoStart"
			Me.CAMAUT.UseVisualStyleBackColor = True
			Me.GroupBox3.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox3.Controls.Add(Me.Label1)
			Me.GroupBox3.Controls.Add(Me.SCI)
			Me.GroupBox3.Controls.Add(Me.SCAUT)
			Me.GroupBox3.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox3.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox13 As Global.System.Windows.Forms.Control = Me.GroupBox3
			location = New Global.System.Drawing.Point(188, 62)
			groupBox13.Location = location
			Dim groupBox14 As Global.System.Windows.Forms.Control = Me.GroupBox3
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox14.Margin = padding
			Me.GroupBox3.Name = "GroupBox3"
			Dim groupBox15 As Global.System.Windows.Forms.Control = Me.GroupBox3
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox15.Padding = padding
			Dim groupBox16 As Global.System.Windows.Forms.Control = Me.GroupBox3
			size = New Global.System.Drawing.Size(134, 79)
			groupBox16.Size = size
			Me.GroupBox3.TabIndex = 9
			Me.GroupBox3.TabStop = False
			Me.GroupBox3.Text = "Remote Desktop"
			Me.Label1.AutoSize = True
			Dim label5 As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(7, 48)
			label5.Location = location
			Me.Label1.Name = "Label1"
			Dim label6 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(31, 17)
			label6.Size = size
			Me.Label1.TabIndex = 3
			Me.Label1.Text = "Size"
			Me.SCI.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.SCI.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.SCI.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.SCI.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.SCI.FormattingEnabled = True
			Me.SCI.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim sci As Global.System.Windows.Forms.Control = Me.SCI
			location = New Global.System.Drawing.Point(44, 44)
			sci.Location = location
			Dim sci2 As Global.System.Windows.Forms.Control = Me.SCI
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			sci2.Margin = padding
			Me.SCI.Name = "SCI"
			Dim sci3 As Global.System.Windows.Forms.Control = Me.SCI
			size = New Global.System.Drawing.Size(82, 24)
			sci3.Size = size
			Me.SCI.TabIndex = 2
			Me.SCAUT.AutoSize = True
			Me.SCAUT.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim scaut As Global.System.Windows.Forms.Control = Me.SCAUT
			location = New Global.System.Drawing.Point(7, 23)
			scaut.Location = location
			Dim scaut2 As Global.System.Windows.Forms.Control = Me.SCAUT
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			scaut2.Margin = padding
			Me.SCAUT.Name = "SCAUT"
			Me.SCAUT.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim scaut3 As Global.System.Windows.Forms.Control = Me.SCAUT
			size = New Global.System.Drawing.Size(89, 21)
			scaut3.Size = size
			Me.SCAUT.TabIndex = 1
			Me.SCAUT.Text = "AutoStart"
			Me.SCAUT.UseVisualStyleBackColor = True
			Me.GroupBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox2.Controls.Add(Me.LOGLOGIN)
			Me.GroupBox2.Controls.Add(Me.LOGCONNECTIONS)
			Me.GroupBox2.Controls.Add(Me.LOGLERR)
			Me.GroupBox2.Controls.Add(Me.LOGRERR)
			Me.GroupBox2.Controls.Add(Me.LOGMSGS)
			Me.GroupBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.GroupBox2.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox17 As Global.System.Windows.Forms.Control = Me.GroupBox2
			location = New Global.System.Drawing.Point(328, 65)
			groupBox17.Location = location
			Dim groupBox18 As Global.System.Windows.Forms.Control = Me.GroupBox2
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox18.Margin = padding
			Me.GroupBox2.Name = "GroupBox2"
			Dim groupBox19 As Global.System.Windows.Forms.Control = Me.GroupBox2
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox19.Padding = padding
			Me.GroupBox2.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox20 As Global.System.Windows.Forms.Control = Me.GroupBox2
			size = New Global.System.Drawing.Size(136, 124)
			groupBox20.Size = size
			Me.GroupBox2.TabIndex = 8
			Me.GroupBox2.TabStop = False
			Me.GroupBox2.Text = "Logs"
			Me.LOGLOGIN.AutoSize = True
			Dim loglogin As Global.System.Windows.Forms.Control = Me.LOGLOGIN
			location = New Global.System.Drawing.Point(6, 17)
			loglogin.Location = location
			Dim loglogin2 As Global.System.Windows.Forms.Control = Me.LOGLOGIN
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			loglogin2.Margin = padding
			Me.LOGLOGIN.Name = "LOGLOGIN"
			Me.LOGLOGIN.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim loglogin3 As Global.System.Windows.Forms.Control = Me.LOGLOGIN
			size = New Global.System.Drawing.Size(91, 21)
			loglogin3.Size = size
			Me.LOGLOGIN.TabIndex = 5
			Me.LOGLOGIN.Text = "Login/Out"
			Me.LOGLOGIN.UseVisualStyleBackColor = True
			Me.LOGCONNECTIONS.AutoSize = True
			Dim logconnections As Global.System.Windows.Forms.Control = Me.LOGCONNECTIONS
			location = New Global.System.Drawing.Point(6, 37)
			logconnections.Location = location
			Dim logconnections2 As Global.System.Windows.Forms.Control = Me.LOGCONNECTIONS
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			logconnections2.Margin = padding
			Me.LOGCONNECTIONS.Name = "LOGCONNECTIONS"
			Me.LOGCONNECTIONS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logconnections3 As Global.System.Windows.Forms.Control = Me.LOGCONNECTIONS
			size = New Global.System.Drawing.Size(106, 21)
			logconnections3.Size = size
			Me.LOGCONNECTIONS.TabIndex = 4
			Me.LOGCONNECTIONS.Text = "Connections"
			Me.LOGCONNECTIONS.UseVisualStyleBackColor = True
			Me.LOGLERR.AutoSize = True
			Dim loglerr As Global.System.Windows.Forms.Control = Me.LOGLERR
			location = New Global.System.Drawing.Point(6, 57)
			loglerr.Location = location
			Dim loglerr2 As Global.System.Windows.Forms.Control = Me.LOGLERR
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			loglerr2.Margin = padding
			Me.LOGLERR.Name = "LOGLERR"
			Me.LOGLERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim loglerr3 As Global.System.Windows.Forms.Control = Me.LOGLERR
			size = New Global.System.Drawing.Size(111, 21)
			loglerr3.Size = size
			Me.LOGLERR.TabIndex = 3
			Me.LOGLERR.Text = "Listner Errors"
			Me.LOGLERR.UseVisualStyleBackColor = True
			Me.LOGRERR.AutoSize = True
			Me.LOGRERR.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim logrerr As Global.System.Windows.Forms.Control = Me.LOGRERR
			location = New Global.System.Drawing.Point(6, 78)
			logrerr.Location = location
			Dim logrerr2 As Global.System.Windows.Forms.Control = Me.LOGRERR
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			logrerr2.Margin = padding
			Me.LOGRERR.Name = "LOGRERR"
			Me.LOGRERR.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logrerr3 As Global.System.Windows.Forms.Control = Me.LOGRERR
			size = New Global.System.Drawing.Size(119, 21)
			logrerr3.Size = size
			Me.LOGRERR.TabIndex = 2
			Me.LOGRERR.Text = "Remote Errors"
			Me.LOGRERR.UseVisualStyleBackColor = True
			Me.LOGMSGS.AutoSize = True
			Dim logmsgs As Global.System.Windows.Forms.Control = Me.LOGMSGS
			location = New Global.System.Drawing.Point(6, 98)
			logmsgs.Location = location
			Dim logmsgs2 As Global.System.Windows.Forms.Control = Me.LOGMSGS
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			logmsgs2.Margin = padding
			Me.LOGMSGS.Name = "LOGMSGS"
			Me.LOGMSGS.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim logmsgs3 As Global.System.Windows.Forms.Control = Me.LOGMSGS
			size = New Global.System.Drawing.Size(87, 21)
			logmsgs3.Size = size
			Me.LOGMSGS.TabIndex = 1
			Me.LOGMSGS.Text = "Messages"
			Me.LOGMSGS.UseVisualStyleBackColor = True
			Me.GroupBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.GroupBox1.Controls.Add(Me.ShowAlert)
			Me.GroupBox1.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.GroupBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim groupBox21 As Global.System.Windows.Forms.Control = Me.GroupBox1
			location = New Global.System.Drawing.Point(330, 189)
			groupBox21.Location = location
			Dim groupBox22 As Global.System.Windows.Forms.Control = Me.GroupBox1
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox22.Margin = padding
			Me.GroupBox1.Name = "GroupBox1"
			Dim groupBox23 As Global.System.Windows.Forms.Control = Me.GroupBox1
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			groupBox23.Padding = padding
			Me.GroupBox1.RightToLeft = Global.System.Windows.Forms.RightToLeft.Yes
			Dim groupBox24 As Global.System.Windows.Forms.Control = Me.GroupBox1
			size = New Global.System.Drawing.Size(136, 38)
			groupBox24.Size = size
			Me.GroupBox1.TabIndex = 7
			Me.GroupBox1.TabStop = False
			Me.GroupBox1.Text = "OnLogin"
			Me.ShowAlert.AutoSize = True
			Dim showAlert As Global.System.Windows.Forms.Control = Me.ShowAlert
			location = New Global.System.Drawing.Point(7, 14)
			showAlert.Location = location
			Dim showAlert2 As Global.System.Windows.Forms.Control = Me.ShowAlert
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			showAlert2.Margin = padding
			Me.ShowAlert.Name = "ShowAlert"
			Me.ShowAlert.RightToLeft = Global.System.Windows.Forms.RightToLeft.No
			Dim showAlert3 As Global.System.Windows.Forms.Control = Me.ShowAlert
			size = New Global.System.Drawing.Size(95, 21)
			showAlert3.Size = size
			Me.ShowAlert.TabIndex = 0
			Me.ShowAlert.Text = "Show Alert"
			Me.ShowAlert.UseVisualStyleBackColor = True
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(456, 22)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 41
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(77, 302)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(105, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 40
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(19, 302)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 39
			Me.PictureBox4.TabStop = False
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(41, 71)
			userImage.Location = location
			Me.UserImage1.Maximum = 100
			Me.UserImage1.Name = "UserImage1"
			Me.UserImage1.RotationAngle = 310
			Me.UserImage1.ShowActivityStatus = True
			Me.UserImage1.ShowBorder = False
			Me.UserImage1.ShowImage = True
			Me.UserImage1.ShowProgress = True
			Dim userImage2 As Global.System.Windows.Forms.Control = Me.UserImage1
			size = New Global.System.Drawing.Size(93, 93)
			userImage2.Size = size
			Me.UserImage1.StartingAngle = 70
			Me.UserImage1.TabIndex = 38
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(486, 366)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.ForeColor = Global.System.Drawing.Color.White
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = padding
			Me.MaximizeBox = False
			Me.Name = "STNG"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Settings"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.GroupBox6.ResumeLayout(False)
			Me.GroupBox6.PerformLayout()
			Me.GroupBox5.ResumeLayout(False)
			Me.GroupBox5.PerformLayout()
			Me.GroupBox4.ResumeLayout(False)
			Me.GroupBox4.PerformLayout()
			Me.GroupBox3.ResumeLayout(False)
			Me.GroupBox3.PerformLayout()
			Me.GroupBox2.ResumeLayout(False)
			Me.GroupBox2.PerformLayout()
			Me.GroupBox1.ResumeLayout(False)
			Me.GroupBox1.PerformLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000261 RID: 609
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
