Namespace NJRAT
	' Token: 0x0200000B RID: 11
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Cam
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x06000152 RID: 338 RVA: 0x0000DCAC File Offset: 0x0000BEAC
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

		' Token: 0x06000153 RID: 339 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Cam))
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.vmethod_6 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.CheckBox3 = New Global.System.Windows.Forms.CheckBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox2 = New Global.System.Windows.Forms.PictureBox()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(54, 237)
			progressBar.Location = location
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			progressBar2.Margin = margin
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(568, 12)
			progressBar3.Size = size
			Me.ProgressBar1.TabIndex = 2
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox2)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.ComboBox2)
			Me.FormSkin1.Controls.Add(Me.PictureBox1)
			Me.FormSkin1.Controls.Add(Me.ComboBox1)
			Me.FormSkin1.Controls.Add(Me.CheckBox3)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.Panel1)
			Me.FormSkin1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.FormSkin1.FlatColor = Global.System.Drawing.Color.FromArgb(35, 168, 109)
			Me.FormSkin1.Font = New Global.System.Drawing.Font("Segoe UI", 12F)
			Me.FormSkin1.ForeColor = Global.System.Drawing.Color.SlateGray
			Me.FormSkin1.HeaderColor = Global.System.Drawing.Color.FromArgb(50, 50, 50)
			Me.FormSkin1.HeaderMaximize = False
			Dim formSkin As Global.System.Windows.Forms.Control = Me.FormSkin1
			location = New Global.System.Drawing.Point(0, 0)
			formSkin.Location = location
			Me.FormSkin1.Name = "FormSkin1"
			Dim formSkin2 As Global.System.Windows.Forms.Control = Me.FormSkin1
			size = New Global.System.Drawing.Size(775, 487)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 3
			Me.FormSkin1.Text = "Cam"
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "%100", "%90", "%80", "%70", "%60", "%50" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox2
			location = New Global.System.Drawing.Point(12, 273)
			comboBox.Location = location
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox2
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox2.Margin = margin
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox2
			size = New Global.System.Drawing.Size(197, 25)
			comboBox3.Size = size
			Me.ComboBox2.TabIndex = 4
			Me.PictureBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.PictureBox1.BackColor = Global.System.Drawing.Color.Transparent
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox1
			location = New Global.System.Drawing.Point(215, 46)
			pictureBox.Location = location
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			pictureBox2.Margin = margin
			Me.PictureBox1.Name = "PictureBox1"
			Dim pictureBox3 As Global.System.Windows.Forms.Control = Me.PictureBox1
			size = New Global.System.Drawing.Size(548, 396)
			pictureBox3.Size = size
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.PictureBox1.TabIndex = 3
			Me.PictureBox1.TabStop = False
			Me.ComboBox1.Anchor = (Global.System.Windows.Forms.AnchorStyles.Left Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox4 As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(12, 450)
			comboBox4.Location = location
			Dim comboBox5 As Global.System.Windows.Forms.Control = Me.ComboBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox5.Margin = margin
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox6 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(751, 25)
			comboBox6.Size = size
			Me.ComboBox1.TabIndex = 0
			Me.CheckBox3.AutoSize = True
			Me.CheckBox3.BackColor = Global.System.Drawing.Color.Transparent
			Me.CheckBox3.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim checkBox As Global.System.Windows.Forms.Control = Me.CheckBox3
			location = New Global.System.Drawing.Point(12, 315)
			checkBox.Location = location
			Dim checkBox2 As Global.System.Windows.Forms.Control = Me.CheckBox3
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			checkBox2.Margin = margin
			Me.CheckBox3.Name = "CheckBox3"
			Dim checkBox3 As Global.System.Windows.Forms.Control = Me.CheckBox3
			size = New Global.System.Drawing.Size(118, 32)
			checkBox3.Size = size
			Me.CheckBox3.TabIndex = 1
			Me.CheckBox3.Text = "AutoSave"
			Me.CheckBox3.UseVisualStyleBackColor = False
			Me.Button1.BackColor = Global.System.Drawing.Color.Transparent
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(12, 228)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(197, 37)
			button3.Size = size
			Me.Button1.TabIndex = 2
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = False
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			location = New Global.System.Drawing.Point(1049, 430)
			panel.Location = location
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			panel2.Margin = margin
			Me.Panel1.Name = "Panel1"
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			size = New Global.System.Drawing.Size(10, 40)
			panel3.Size = size
			Me.Panel1.TabIndex = 2
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(33, 63)
			userImage.Location = location
			Me.UserImage1.Maximum = 90
			Me.UserImage1.Name = "UserImage1"
			Me.UserImage1.RotationAngle = 310
			Me.UserImage1.ShowActivityStatus = True
			Me.UserImage1.ShowBorder = True
			Me.UserImage1.ShowImage = True
			Me.UserImage1.ShowProgress = True
			Dim userImage2 As Global.System.Windows.Forms.Control = Me.UserImage1
			size = New Global.System.Drawing.Size(146, 146)
			userImage2.Size = size
			Me.UserImage1.StartingAngle = 70
			Me.UserImage1.TabIndex = 8
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(74, 395)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(135, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 20
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox2.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox2.Image = CType(componentResourceManager.GetObject("PictureBox2.Image"), Global.System.Drawing.Image)
			Dim pictureBox4 As Global.System.Windows.Forms.Control = Me.PictureBox2
			location = New Global.System.Drawing.Point(16, 395)
			pictureBox4.Location = location
			Me.PictureBox2.Name = "PictureBox2"
			Dim pictureBox5 As Global.System.Windows.Forms.Control = Me.PictureBox2
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox5.Size = size
			Me.PictureBox2.TabIndex = 19
			Me.PictureBox2.TabStop = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(775, 487)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.ForeColor = Global.System.Drawing.Color.SlateBlue
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "Cam"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Cam"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.PictureBox2, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000090 RID: 144
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
