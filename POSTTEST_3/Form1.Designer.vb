<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        lblTitle = New Label()
        picLogo = New PictureBox()
        picFoto = New PictureBox()
        btnBrowse = New Button()
        Label1 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtUmur = New TextBox()
        Label3 = New Label()
        dtpTanggal = New DateTimePicker()
        Label4 = New Label()
        txtTelepon = New TextBox()
        Label5 = New Label()
        txtAlamat = New TextBox()
        grpJK = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        grpHobby = New GroupBox()
        chkMemancing = New CheckBox()
        chkAkting = New CheckBox()
        chkMusik = New CheckBox()
        chkOlahraga = New CheckBox()
        chkMelukis = New CheckBox()
        chkMenulis = New CheckBox()
        chkMemasak = New CheckBox()
        chkTraveling = New CheckBox()
        chkCoding = New CheckBox()
        chkGaming = New CheckBox()
        btnCetak = New Button()
        CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(picFoto, ComponentModel.ISupportInitialize).BeginInit()
        grpJK.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkRed
        lblTitle.Location = New Point(25, 10)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(900, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Hogwart University Registration"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' picLogo
        ' 
        picLogo.BackColor = Color.Transparent
        picLogo.Image = CType(resources.GetObject("picLogo.Image"), Image)
        picLogo.Location = New Point(780, 60)
        picLogo.Name = "picLogo"
        picLogo.Size = New Size(120, 120)
        picLogo.SizeMode = PictureBoxSizeMode.Zoom
        picLogo.TabIndex = 1
        picLogo.TabStop = False
        ' 
        ' picFoto
        ' 
        picFoto.BackColor = Color.Transparent
        picFoto.BorderStyle = BorderStyle.FixedSingle
        picFoto.Location = New Point(40, 80)
        picFoto.Name = "picFoto"
        picFoto.Size = New Size(180, 220)
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage
        picFoto.TabIndex = 2
        picFoto.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.BackColor = Color.DarkRed
        btnBrowse.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(40, 310)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(180, 35)
        btnBrowse.TabIndex = 3
        btnBrowse.Text = "Browse"
        btnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(260, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 23)
        Label1.TabIndex = 4
        Label1.Text = "Nama"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(400, 80)
        txtNama.Name = "txtNama"
        txtNama.RightToLeft = RightToLeft.No
        txtNama.Size = New Size(220, 27)
        txtNama.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(260, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 23)
        Label2.TabIndex = 6
        Label2.Text = "Umur"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(400, 120)
        txtUmur.Name = "txtUmur"
        txtUmur.RightToLeft = RightToLeft.No
        txtUmur.Size = New Size(80, 27)
        txtUmur.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(260, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 23)
        Label3.TabIndex = 8
        Label3.Text = "Tanggal Lahir"
        ' 
        ' dtpTanggal
        ' 
        dtpTanggal.Location = New Point(400, 160)
        dtpTanggal.Name = "dtpTanggal"
        dtpTanggal.Size = New Size(200, 27)
        dtpTanggal.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(260, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 23)
        Label4.TabIndex = 10
        Label4.Text = "No Telepon"
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(400, 200)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.RightToLeft = RightToLeft.No
        txtTelepon.Size = New Size(220, 27)
        txtTelepon.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(260, 240)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 23)
        Label5.TabIndex = 12
        Label5.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(400, 240)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.RightToLeft = RightToLeft.No
        txtAlamat.Size = New Size(350, 27)
        txtAlamat.TabIndex = 13
        ' 
        ' grpJK
        ' 
        grpJK.BackColor = Color.Transparent
        grpJK.Controls.Add(rbPerempuan)
        grpJK.Controls.Add(rbLaki)
        grpJK.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpJK.Location = New Point(260, 280)
        grpJK.Name = "grpJK"
        grpJK.RightToLeft = RightToLeft.No
        grpJK.Size = New Size(220, 100)
        grpJK.TabIndex = 14
        grpJK.TabStop = False
        grpJK.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(20, 60)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(121, 27)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(20, 30)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(100, 27)
        rbLaki.TabIndex = 0
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' grpHobby
        ' 
        grpHobby.BackColor = Color.Transparent
        grpHobby.Controls.Add(chkMemancing)
        grpHobby.Controls.Add(chkAkting)
        grpHobby.Controls.Add(chkMusik)
        grpHobby.Controls.Add(chkOlahraga)
        grpHobby.Controls.Add(chkMelukis)
        grpHobby.Controls.Add(chkMenulis)
        grpHobby.Controls.Add(chkMemasak)
        grpHobby.Controls.Add(chkTraveling)
        grpHobby.Controls.Add(chkCoding)
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHobby.Location = New Point(500, 280)
        grpHobby.Name = "grpHobby"
        grpHobby.RightToLeft = RightToLeft.No
        grpHobby.Size = New Size(380, 150)
        grpHobby.TabIndex = 15
        grpHobby.TabStop = False
        grpHobby.Text = "Hobby"
        ' 
        ' chkMemancing
        ' 
        chkMemancing.AutoSize = True
        chkMemancing.Location = New Point(10, 115)
        chkMemancing.Name = "chkMemancing"
        chkMemancing.Size = New Size(126, 27)
        chkMemancing.TabIndex = 9
        chkMemancing.Text = "Memancing"
        chkMemancing.UseVisualStyleBackColor = True
        ' 
        ' chkAkting
        ' 
        chkAkting.AutoSize = True
        chkAkting.Location = New Point(240, 85)
        chkAkting.Name = "chkAkting"
        chkAkting.Size = New Size(87, 27)
        chkAkting.TabIndex = 8
        chkAkting.Text = "Akting"
        chkAkting.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(120, 85)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(80, 27)
        chkMusik.TabIndex = 7
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkOlahraga
        ' 
        chkOlahraga.AutoSize = True
        chkOlahraga.Location = New Point(10, 85)
        chkOlahraga.Name = "chkOlahraga"
        chkOlahraga.Size = New Size(105, 27)
        chkOlahraga.TabIndex = 6
        chkOlahraga.Text = "Olahraga"
        chkOlahraga.UseVisualStyleBackColor = True
        ' 
        ' chkMelukis
        ' 
        chkMelukis.AutoSize = True
        chkMelukis.Location = New Point(240, 55)
        chkMelukis.Name = "chkMelukis"
        chkMelukis.Size = New Size(94, 27)
        chkMelukis.TabIndex = 5
        chkMelukis.Text = "Melukis"
        chkMelukis.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(120, 55)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(94, 27)
        chkMenulis.TabIndex = 4
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkMemasak
        ' 
        chkMemasak.AutoSize = True
        chkMemasak.Location = New Point(10, 55)
        chkMemasak.Name = "chkMemasak"
        chkMemasak.Size = New Size(108, 27)
        chkMemasak.TabIndex = 3
        chkMemasak.Text = "Memasak"
        chkMemasak.UseVisualStyleBackColor = True
        ' 
        ' chkTraveling
        ' 
        chkTraveling.AutoSize = True
        chkTraveling.Location = New Point(240, 25)
        chkTraveling.Name = "chkTraveling"
        chkTraveling.Size = New Size(106, 27)
        chkTraveling.TabIndex = 2
        chkTraveling.Text = "Traveling"
        chkTraveling.UseVisualStyleBackColor = True
        ' 
        ' chkCoding
        ' 
        chkCoding.AutoSize = True
        chkCoding.Location = New Point(120, 25)
        chkCoding.Name = "chkCoding"
        chkCoding.Size = New Size(90, 27)
        chkCoding.TabIndex = 1
        chkCoding.Text = "Coding"
        chkCoding.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(10, 25)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(95, 27)
        chkGaming.TabIndex = 0
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' btnCetak
        ' 
        btnCetak.BackColor = Color.DarkRed
        btnCetak.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCetak.ForeColor = Color.White
        btnCetak.Location = New Point(320, 440)
        btnCetak.Name = "btnCetak"
        btnCetak.Size = New Size(300, 40)
        btnCetak.TabIndex = 16
        btnCetak.Text = "Cetak Kartu"
        btnCetak.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Beige
        ClientSize = New Size(932, 503)
        Controls.Add(btnCetak)
        Controls.Add(grpHobby)
        Controls.Add(grpJK)
        Controls.Add(txtAlamat)
        Controls.Add(Label5)
        Controls.Add(txtTelepon)
        Controls.Add(Label4)
        Controls.Add(dtpTanggal)
        Controls.Add(Label3)
        Controls.Add(txtUmur)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Label1)
        Controls.Add(btnBrowse)
        Controls.Add(picFoto)
        Controls.Add(picLogo)
        Controls.Add(lblTitle)
        Name = "Form1"
        RightToLeft = RightToLeft.Yes
        Text = "Hogwarts Student Registration"
        CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(picFoto, ComponentModel.ISupportInitialize).EndInit()
        grpJK.ResumeLayout(False)
        grpJK.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpTanggal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkMemasak As CheckBox
    Friend WithEvents chkTraveling As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents chkMemancing As CheckBox
    Friend WithEvents chkAkting As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkMelukis As CheckBox
    Friend WithEvents btnCetak As Button

End Class
