<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHasil
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHasil))
        lblTitle = New Label()
        picLogo = New PictureBox()
        picHasil = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblNama = New Label()
        lblUmur = New Label()
        lblTanggal = New Label()
        Label6 = New Label()
        lblJK = New Label()
        lblTelepon = New Label()
        Label7 = New Label()
        lblHobby = New Label()
        lblAlamat = New Label()
        lblFooter = New Label()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHasil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.BackColor = Color.Maroon
        lblTitle.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Gold
        lblTitle.Location = New Point(0, -2)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(900, 50)
        lblTitle.TabIndex = 0
        lblTitle.Text = "HOGWARTS UNIVERSITY"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(730, 60)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(120, 90)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 1
        picLogo.TabStop = False
        ' 
        ' picHasil
        ' 
        picHasil.BackColor = Color.Transparent
        picHasil.BorderStyle = BorderStyle.FixedSingle
        picHasil.Location = New Point(40, 90)
        picHasil.Name = "picHasil"
        picHasil.Size = New Size(180, 220)
        picHasil.SizeMode = PictureBoxSizeMode.StretchImage
        picHasil.TabIndex = 2
        picHasil.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(260, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 23)
        Label5.TabIndex = 17
        Label5.Text = "Alamat"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(260, 210)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 16
        Label4.Text = "No Telepon"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(260, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 23)
        Label3.TabIndex = 15
        Label3.Text = "Tanggal Lahir"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(260, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 23)
        Label2.TabIndex = 14
        Label2.Text = "Umur"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(260, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 13
        Label1.Text = "Nama"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.BackColor = Color.Transparent
        lblNama.Location = New Point(400, 90)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(0, 20)
        lblNama.TabIndex = 18
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.BackColor = Color.Transparent
        lblUmur.Location = New Point(400, 120)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(0, 20)
        lblUmur.TabIndex = 19
        ' 
        ' lblTanggal
        ' 
        lblTanggal.AutoSize = True
        lblTanggal.BackColor = Color.Transparent
        lblTanggal.Location = New Point(400, 150)
        lblTanggal.Name = "lblTanggal"
        lblTanggal.Size = New Size(0, 20)
        lblTanggal.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(260, 180)
        Label6.Name = "Label6"
        Label6.Size = New Size(119, 23)
        Label6.TabIndex = 21
        Label6.Text = "Jenis Kelamin"
        ' 
        ' lblJK
        ' 
        lblJK.AutoSize = True
        lblJK.BackColor = Color.Transparent
        lblJK.Location = New Point(400, 180)
        lblJK.Name = "lblJK"
        lblJK.Size = New Size(0, 20)
        lblJK.TabIndex = 22
        ' 
        ' lblTelepon
        ' 
        lblTelepon.AutoSize = True
        lblTelepon.BackColor = Color.Transparent
        lblTelepon.Location = New Point(400, 210)
        lblTelepon.Name = "lblTelepon"
        lblTelepon.Size = New Size(0, 20)
        lblTelepon.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(260, 240)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 23)
        Label7.TabIndex = 24
        Label7.Text = "Hobby"
        ' 
        ' lblHobby
        ' 
        lblHobby.BackColor = Color.Transparent
        lblHobby.Location = New Point(400, 240)
        lblHobby.Name = "lblHobby"
        lblHobby.Size = New Size(350, 40)
        lblHobby.TabIndex = 25
        ' 
        ' lblAlamat
        ' 
        lblAlamat.BackColor = Color.Transparent
        lblAlamat.Location = New Point(400, 290)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(350, 40)
        lblAlamat.TabIndex = 26
        ' 
        ' lblFooter
        ' 
        lblFooter.BackColor = Color.Maroon
        lblFooter.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFooter.ForeColor = Color.Gold
        lblFooter.Location = New Point(0, 383)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(900, 40)
        lblFooter.TabIndex = 27
        lblFooter.Text = "STUDENT IDENTIFICATION CARD"
        lblFooter.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(882, 422)
        Controls.Add(lblFooter)
        Controls.Add(lblAlamat)
        Controls.Add(lblHobby)
        Controls.Add(Label7)
        Controls.Add(lblTelepon)
        Controls.Add(lblJK)
        Controls.Add(Label6)
        Controls.Add(lblTanggal)
        Controls.Add(lblUmur)
        Controls.Add(lblNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picHasil)
        Controls.Add(picLogo)
        Controls.Add(lblTitle)
        DoubleBuffered = True
        Name = "FormHasil"
        Text = "FormHasil"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picHasil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picHasil As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblTanggal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblTelepon As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblFooter As Label
End Class
