Namespace NJRAT
	' Token: 0x02000016 RID: 22
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class Mic
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x060003C0 RID: 960 RVA: 0x00023648 File Offset: 0x00021848
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

		' Token: 0x060003C1 RID: 961 RVA: 0x00023688 File Offset: 0x00021888
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.Mic))
			Me.vmethod_4 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.ProgressBar1 = New Global.System.Windows.Forms.ProgressBar()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.ComboBox2 = New Global.System.Windows.Forms.ComboBox()
			Me.Label1 = New Global.System.Windows.Forms.Label()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.UserImage1 = New Global.NJRAT.UserImage()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Me.vmethod_4.Enabled = True
			Me.vmethod_4.Interval = 50
			Dim progressBar As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(76, 131)
			progressBar.Location = location
			Dim progressBar2 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			progressBar2.Margin = margin
			Me.ProgressBar1.Name = "ProgressBar1"
			Dim progressBar3 As Global.System.Windows.Forms.Control = Me.ProgressBar1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(419, 12)
			progressBar3.Size = size
			Me.ProgressBar1.TabIndex = 4
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.UserImage1)
			Me.FormSkin1.Controls.Add(Me.ComboBox2)
			Me.FormSkin1.Controls.Add(Me.Label1)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.ComboBox1)
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
			size = New Global.System.Drawing.Size(468, 233)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 5
			Me.FormSkin1.Text = "Mic"
			Me.ComboBox2.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox2.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox2.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox2.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox2.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox2.FormattingEnabled = True
			Me.ComboBox2.Items.AddRange(New Object() { "4 kb 8bit", "6 kb 8bit", "8 kb 8bit", "8 kb 16bit", "12 kb 16bit", "16 kb 16bit", "20 kb 16bit", "24 kb 16bit" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox2
			location = New Global.System.Drawing.Point(262, 105)
			comboBox.Location = location
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox2
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox2.Margin = margin
			Me.ComboBox2.Name = "ComboBox2"
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox2
			size = New Global.System.Drawing.Size(191, 25)
			comboBox3.Size = size
			Me.ComboBox2.TabIndex = 7
			Me.Label1.AutoSize = True
			Me.Label1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.Label1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Label1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim label As Global.System.Windows.Forms.Control = Me.Label1
			location = New Global.System.Drawing.Point(188, 111)
			label.Location = location
			Me.Label1.Name = "Label1"
			Dim label2 As Global.System.Windows.Forms.Control = Me.Label1
			size = New Global.System.Drawing.Size(68, 19)
			label2.Size = size
			Me.Label1.TabIndex = 6
			Me.Label1.Text = "BufferSize"
			Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(192, 161)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(261, 59)
			button3.Size = size
			Me.Button1.TabIndex = 5
			Me.Button1.Text = "Start"
			Me.Button1.UseVisualStyleBackColor = False
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.Font = New Global.System.Drawing.Font("Segoe UI", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox1.FormattingEnabled = True
			Dim comboBox4 As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(192, 71)
			comboBox4.Location = location
			Dim comboBox5 As Global.System.Windows.Forms.Control = Me.ComboBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox5.Margin = margin
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox6 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(261, 25)
			comboBox6.Size = size
			Me.ComboBox1.TabIndex = 4
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(435, 22)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 37
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(70, 176)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(105, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 36
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(12, 176)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 35
			Me.PictureBox4.TabStop = False
			Me.UserImage1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UserImage1.BorderSize = 2
			Me.UserImage1.ColorActivityStatus = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.ColorBorder = Global.System.Drawing.Color.FromArgb(190, 190, 190)
			Me.UserImage1.ColorProgress = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.UserImage1.EnableHover = False
			Dim userImage As Global.System.Windows.Forms.Control = Me.UserImage1
			location = New Global.System.Drawing.Point(47, 50)
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
			Me.UserImage1.TabIndex = 34
			Me.UserImage1.Text = "UserImage1"
			Me.UserImage1.UImage = CType(componentResourceManager.GetObject("UserImage1.UImage"), Global.System.Drawing.Image)
			Me.UserImage1.Value = 50
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.Color.Black
			size = New Global.System.Drawing.Size(468, 233)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.ProgressBar1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.MaximizeBox = False
			Me.Name = "Mic"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Mic"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x040001B7 RID: 439
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
