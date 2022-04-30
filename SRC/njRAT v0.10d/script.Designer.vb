Namespace NJRAT
	' Token: 0x0200001F RID: 31
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class script
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600050D RID: 1293 RVA: 0x0002E1A4 File Offset: 0x0002C3A4
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

		' Token: 0x0600050E RID: 1294 RVA: 0x0002E1E4 File Offset: 0x0002C3E4
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.NJRAT.script))
			Me.Panel1 = New Global.System.Windows.Forms.Panel()
			Me.FormSkin1 = New Global.NJRAT.FormSkin()
			Me.ComboBox1 = New Global.System.Windows.Forms.ComboBox()
			Me.Button1 = New Global.System.Windows.Forms.Button()
			Me.TextBox1 = New Global.System.Windows.Forms.TextBox()
			Me.FlatMini2 = New Global.NJRAT.FlatMini()
			Me.FlatButton2 = New Global.NJRAT.FlatButton()
			Me.PictureBox4 = New Global.System.Windows.Forms.PictureBox()
			Me.FormSkin1.SuspendLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			Dim panel As Global.System.Windows.Forms.Control = Me.Panel1
			Dim location As Global.System.Drawing.Point = New Global.System.Drawing.Point(0, 333)
			panel.Location = location
			Dim panel2 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim margin As Global.System.Windows.Forms.Padding = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			panel2.Margin = margin
			Me.Panel1.Name = "Panel1"
			Dim panel3 As Global.System.Windows.Forms.Control = Me.Panel1
			Dim size As Global.System.Drawing.Size = New Global.System.Drawing.Size(600, 31)
			panel3.Size = size
			Me.Panel1.TabIndex = 0
			Me.FormSkin1.BackColor = Global.System.Drawing.Color.White
			Me.FormSkin1.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FormSkin1.BorderColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FormSkin1.BorderSize = 10
			Me.FormSkin1.Controls.Add(Me.FlatMini2)
			Me.FormSkin1.Controls.Add(Me.FlatButton2)
			Me.FormSkin1.Controls.Add(Me.PictureBox4)
			Me.FormSkin1.Controls.Add(Me.ComboBox1)
			Me.FormSkin1.Controls.Add(Me.Button1)
			Me.FormSkin1.Controls.Add(Me.TextBox1)
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
			size = New Global.System.Drawing.Size(655, 462)
			formSkin2.Size = size
			Me.FormSkin1.TabIndex = 1
			Me.FormSkin1.Text = "script"
			Me.ComboBox1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.ComboBox1.DropDownStyle = Global.System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.ComboBox1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.ComboBox1.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ComboBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.ComboBox1.FormattingEnabled = True
			Me.ComboBox1.Items.AddRange(New Object() { "vbs", "bat", "cmd", "txt", "html", "hta" })
			Dim comboBox As Global.System.Windows.Forms.Control = Me.ComboBox1
			location = New Global.System.Drawing.Point(567, 401)
			comboBox.Location = location
			Dim comboBox2 As Global.System.Windows.Forms.Control = Me.ComboBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			comboBox2.Margin = margin
			Me.ComboBox1.Name = "ComboBox1"
			Dim comboBox3 As Global.System.Windows.Forms.Control = Me.ComboBox1
			size = New Global.System.Drawing.Size(77, 24)
			comboBox3.Size = size
			Me.ComboBox1.TabIndex = 2
			Me.Button1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.Button1.FlatStyle = Global.System.Windows.Forms.FlatStyle.Flat
			Me.Button1.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Button1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim button As Global.System.Windows.Forms.Control = Me.Button1
			location = New Global.System.Drawing.Point(193, 400)
			button.Location = location
			Dim button2 As Global.System.Windows.Forms.Control = Me.Button1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			button2.Margin = margin
			Me.Button1.Name = "Button1"
			Dim button3 As Global.System.Windows.Forms.Control = Me.Button1
			size = New Global.System.Drawing.Size(368, 47)
			button3.Size = size
			Me.Button1.TabIndex = 4
			Me.Button1.Text = "Execute"
			Me.Button1.UseVisualStyleBackColor = False
			Me.TextBox1.BackColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.TextBox1.Font = New Global.System.Drawing.Font("Tahoma", 7.8F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.TextBox1.ForeColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Dim textBox As Global.System.Windows.Forms.Control = Me.TextBox1
			location = New Global.System.Drawing.Point(32, 60)
			textBox.Location = location
			Dim textBox2 As Global.System.Windows.Forms.Control = Me.TextBox1
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			textBox2.Margin = margin
			Me.TextBox1.Multiline = True
			Me.TextBox1.Name = "TextBox1"
			Dim textBox3 As Global.System.Windows.Forms.Control = Me.TextBox1
			size = New Global.System.Drawing.Size(600, 333)
			textBox3.Size = size
			Me.TextBox1.TabIndex = 3
			Me.FlatMini2.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.FlatMini2.BackColor = Global.System.Drawing.Color.White
			Me.FlatMini2.BaseColor = Global.System.Drawing.Color.FromArgb(33, 33, 50)
			Me.FlatMini2.Font = New Global.System.Drawing.Font("Marlett", 12F)
			Dim flatMini As Global.System.Windows.Forms.Control = Me.FlatMini2
			location = New Global.System.Drawing.Point(614, 12)
			flatMini.Location = location
			Me.FlatMini2.Name = "FlatMini2"
			Dim flatMini2 As Global.System.Windows.Forms.Control = Me.FlatMini2
			size = New Global.System.Drawing.Size(18, 18)
			flatMini2.Size = size
			Me.FlatMini2.TabIndex = 44
			Me.FlatMini2.Text = "FlatMini2"
			Me.FlatMini2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.FlatButton2.BackColor = Global.System.Drawing.Color.Transparent
			Me.FlatButton2.BaseColor = Global.System.Drawing.Color.FromArgb(34, 33, 51)
			Me.FlatButton2.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.FlatButton2.Font = New Global.System.Drawing.Font("Segoe UI", 10.8F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Dim flatButton As Global.System.Windows.Forms.Control = Me.FlatButton2
			location = New Global.System.Drawing.Point(82, 400)
			flatButton.Location = location
			Me.FlatButton2.Name = "FlatButton2"
			Me.FlatButton2.Rounded = False
			Dim flatButton2 As Global.System.Windows.Forms.Control = Me.FlatButton2
			size = New Global.System.Drawing.Size(105, 47)
			flatButton2.Size = size
			Me.FlatButton2.TabIndex = 43
			Me.FlatButton2.Text = "Exit"
			Me.FlatButton2.TextColor = Global.System.Drawing.Color.FromArgb(105, 93, 235)
			Me.PictureBox4.BackColor = Global.System.Drawing.Color.Transparent
			Me.PictureBox4.Image = CType(componentResourceManager.GetObject("PictureBox4.Image"), Global.System.Drawing.Image)
			Dim pictureBox As Global.System.Windows.Forms.Control = Me.PictureBox4
			location = New Global.System.Drawing.Point(24, 400)
			pictureBox.Location = location
			Me.PictureBox4.Name = "PictureBox4"
			Dim pictureBox2 As Global.System.Windows.Forms.Control = Me.PictureBox4
			size = New Global.System.Drawing.Size(52, 47)
			pictureBox2.Size = size
			Me.PictureBox4.TabIndex = 42
			Me.PictureBox4.TabStop = False
			Dim autoScaleDimensions As Global.System.Drawing.SizeF = New Global.System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleDimensions = autoScaleDimensions
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = Global.System.Drawing.SystemColors.ActiveCaptionText
			size = New Global.System.Drawing.Size(655, 462)
			Me.ClientSize = size
			Me.Controls.Add(Me.FormSkin1)
			Me.Controls.Add(Me.Panel1)
			Me.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			margin = New Global.System.Windows.Forms.Padding(3, 4, 3, 4)
			Me.Margin = margin
			Me.Name = "script"
			Me.ShowIcon = False
			Me.StartPosition = Global.System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "script"
			Me.TransparencyKey = Global.System.Drawing.Color.Fuchsia
			Me.FormSkin1.ResumeLayout(False)
			Me.FormSkin1.PerformLayout()
			CType(Me.PictureBox4, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
		End Sub

		' Token: 0x04000254 RID: 596
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
