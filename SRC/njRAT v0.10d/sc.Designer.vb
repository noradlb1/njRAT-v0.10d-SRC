Namespace NJRAT
	' Token: 0x0200001E RID: 30
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class sc
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060004CD RID: 1229 RVA: 0x0002BDEC File Offset: 0x00029FEC
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

		' Token: 0x060004CE RID: 1230 RVA: 0x0002BE2C File Offset: 0x0002A02C
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.sc))
			Me.vmethod_16 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.vmethod_12 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.FlatMini1 = New Global.NJRAT.FlatMini()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button2 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.p = New Global.System.Windows.Forms.PictureBox()
			Me.CheckBox1 = New Global.System.Windows.Forms.CheckBox()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.CheckBox2 = New Global.System.Windows.Forms.CheckBox()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.vmethod_16.Enabled = True
			Me.vmethod_16.Interval = 10
			Me.vmethod_12.Enabled = True
			Me.vmethod_12.Interval = 1000
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(198, 409)
			progressBar.Location = location
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			progressBar2.Margin = margin
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(495, 10)
			progressBar3.Size = size
			Me.ProgressBar1.TabIndex = 1
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatMini1)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox1)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.Label1)
			Me.FormSkin1.Controls.Add(Me.Button2)
			Me.FormSkin1.Controls.Add(Me.ComboBox1)
			Me.FormSkin1.Controls.Add(Me.p)
			Me.FormSkin1.Controls.Add(Me.CheckBox1)
			Me.FormSkin1.Controls.Add(Me.Panel1)
			Me.FormSkin1.Controls.Add(Me.CheckBox2)
			Me.FormSkin1.Controls.Add(Me.CheckBox3)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			location = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			size = New Global.System.Drawing.Size(772, 537)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 4
			Me.FormSkin1.Text = "Desktop"
			Me.FlatMini1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini1.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini1.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini1
			location = New Global.System.Drawing.Point(736, 10)
			flatMini.Location = location
			Me.FlatMini1.Name = "FlatMini1"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini1
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini1.TabIndex = 20
			Me.FlatMini1.Text = "FlatMini1"
			Me.FlatMini1.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(35, 57)
			userImage.Location = location
			Me.UserImage1.Maximum = 90
			Me.UserImage1.Name = "UserImage1"
			Me.UserImage1.RotationAngle = 310
			Me.UserImage1.ShowActivityStatus = True
			Me.UserImage1.ShowBorder = True
			Me.UserImage1.ShowImage = True
			Me.UserImage1.ShowProgress = True
			Dim userImage2 As Global.System.Windows.Forms.Control = Me.UserImage1
			size = New Global.System.Drawing.Size(119, 119)
			userImage2.Size = size
			Me.UserImage1.StartingAngle = 70
			Me.UserImage1.TabIndex = 19
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(70, 476)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(105, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 18
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(12, 476)
			pictureBox.Location = location
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox1.TabIndex = 6
			Me.PictureBox1.TabStop = False
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(22, 203)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(143, 31)
			button3.Size = size
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = False
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Label1.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(136, 248)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(37, 16)
			label2.Size = size
			Me.Label1.TabIndex = 4
			Me.Label1.Text = "Size"
			Me.Button2.BackColor = Global.System.Drawing.Color.WhiteSmoke
			Me.Button2.BackgroundImageLayout = Global.System.Windows.Forms.ImageLayout.Stretch
			Me.Button2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Button2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Dim button4 As Global.System.Windows.Forms.Control = Me.Button2
			location = New Global.System.Drawing.Point(787, 43)
			button4.Location = location
			Dim button5 As Global.System.Windows.Forms.Control = Me.Button2
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button5.Margin = margin
			Me.Button2.Name = "Button2"
			Dim button6 As Global.System.Windows.Forms.Control = Me.Button2
			size = New Global.System.Drawing.Size(12, 15)
			button6.Size = size
			Me.Button2.TabIndex = 5
			Me.Button2.UseVisualStyleBackColor = False
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "%100", "%95", "%90", "%85", "%80", "%75", "%70", "%65", "%60", "%55", "%50" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(22, 248)
			comboBox.Location = location
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox2.Margin = margin
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(106, 25)
			comboBox3.Size = size
			Me.ComboBox1.TabIndex = 3
			Me.p.BackColor = Global.System.Drawing.Color.Transparent
			Dim p As Global.System.Windows.Forms.Control = Me.p
			location = New Global.System.Drawing.Point(181, 41)
			p.Location = location
			Dim p2 As Global.System.Windows.Forms.Control = Me.p
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			p2.Margin = margin
			Me.p.Name = "p"
			Dim p3 As Global.System.Windows.Forms.Control = Me.p
			size = New Global.System.Drawing.Size(578, 482)
			p3.Size = size
			Me.p.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.p.TabIndex = 4
			Me.p.TabStop = False
			Me.CheckBox1.AutoSize = True
			Me.CheckBox1.BackColor = Global.System.Drawing.Color.Transparent
			Me.CheckBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox1
			location = New Global.System.Drawing.Point(35, 428)
			checkBox.Location = location
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			checkBox2.Margin = margin
			Me.CheckBox1.Name = "CheckBox1"
			Dim checkBox3 As Global.System.Windows.Forms.Control = Me.CheckBox1
			size = New Global.System.Drawing.Size(89, 32)
			checkBox3.Size = size
			Me.CheckBox1.TabIndex = 2
			Me.CheckBox1.Text = "Mouse"
			Me.CheckBox1.UseVisualStyleBackColor = False
			Me.Panel1.BackColor = Global.System.Drawing.Color.Transparent
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(792, 56)
			panel.Location = location
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			panel2.Margin = margin
			Me.Panel1.Name = "Panel1"
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(10, 43)
			panel3.Size = size
			Me.Panel1.TabIndex = 3
			Me.CheckBox2.AutoSize = True
			Me.CheckBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.CheckBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim checkBox4 As Global.System.Windows.Forms.Control = Me.CheckBox2
			location = New Global.System.Drawing.Point(35, 388)
			checkBox4.Location = location
			Dim checkBox5 As Global.System.Windows.Forms.Control = Me.CheckBox2
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			checkBox5.Margin = margin
			Me.CheckBox2.Name = "CheckBox2"
			Dim checkBox6 As Global.System.Windows.Forms.Control = Me.CheckBox2
			size = New Global.System.Drawing.Size(115, 32)
			checkBox6.Size = size
			Me.CheckBox2.TabIndex = 1
			Me.CheckBox2.Text = "Keyboard"
			Me.CheckBox2.UseVisualStyleBackColor = False
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.BackColor = Global.System.Drawing.Color.Transparent
			Me.CheckBox3.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim checkBox7 As Global.System.Windows.Forms.Control = Me.CheckBox3
			location = New Global.System.Drawing.Point(35, 348)
			checkBox7.Location = location
			Dim checkBox8 As Global.System.Windows.Forms.Control = Me.CheckBox3
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			checkBox8.Margin = margin
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox9 As Global.System.Windows.Forms.Control = Me.CheckBox3
			size = New Global.System.Drawing.Size(114, 32)
			checkBox9.Size = size
			Me.CheckBox3.TabIndex = 0
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(772, 537)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "sc"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "sc"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.p, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000232 RID: 562
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
