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
        lblTitle = New Label()
        lblJudul = New Label()
        lblGenre = New Label()
        txtJudul = New TextBox()
        txtGenre = New TextBox()
        txtHapus = New TextBox()
        btnTambah = New Button()
        btnHapus = New Button()
        lstBuku = New ListBox()
        grpTambah = New GroupBox()
        grpHapus = New GroupBox()
        lblJudulHapus = New Label()
        grpTambah.SuspendLayout()
        grpHapus.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.DarkSlateBlue
        lblTitle.Location = New Point(30, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(650, 40)
        lblTitle.TabIndex = 0
        lblTitle.Text = "SISTEM DAFTAR BUKU PERPUSTAKAAN"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.Black
        lblJudul.Location = New Point(20, 40)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(79, 20)
        lblJudul.TabIndex = 1
        lblJudul.Text = "Judul Buku"
        ' 
        ' lblGenre
        ' 
        lblGenre.AutoSize = True
        lblGenre.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGenre.Location = New Point(20, 80)
        lblGenre.Name = "lblGenre"
        lblGenre.Size = New Size(48, 20)
        lblGenre.TabIndex = 2
        lblGenre.Text = "Genre"
        ' 
        ' txtJudul
        ' 
        txtJudul.BorderStyle = BorderStyle.FixedSingle
        txtJudul.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtJudul.Location = New Point(130, 38)
        txtJudul.Name = "txtJudul"
        txtJudul.Size = New Size(160, 27)
        txtJudul.TabIndex = 3
        ' 
        ' txtGenre
        ' 
        txtGenre.BorderStyle = BorderStyle.FixedSingle
        txtGenre.Location = New Point(130, 78)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(160, 30)
        txtGenre.TabIndex = 4
        ' 
        ' txtHapus
        ' 
        txtHapus.BorderStyle = BorderStyle.FixedSingle
        txtHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtHapus.Location = New Point(130, 38)
        txtHapus.Name = "txtHapus"
        txtHapus.Size = New Size(160, 27)
        txtHapus.TabIndex = 5
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.MediumSlateBlue
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(100, 125)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 30)
        btnTambah.TabIndex = 6
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Crimson
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(100, 125)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(100, 30)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' lstBuku
        ' 
        lstBuku.BackColor = Color.White
        lstBuku.BorderStyle = BorderStyle.FixedSingle
        lstBuku.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstBuku.FormattingEnabled = True
        lstBuku.ItemHeight = 23
        lstBuku.Location = New Point(30, 270)
        lstBuku.Name = "lstBuku"
        lstBuku.Size = New Size(660, 163)
        lstBuku.TabIndex = 8
        ' 
        ' grpTambah
        ' 
        grpTambah.Controls.Add(lblJudul)
        grpTambah.Controls.Add(txtJudul)
        grpTambah.Controls.Add(lblGenre)
        grpTambah.Controls.Add(txtGenre)
        grpTambah.Controls.Add(btnTambah)
        grpTambah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpTambah.Location = New Point(30, 80)
        grpTambah.Name = "grpTambah"
        grpTambah.Size = New Size(310, 170)
        grpTambah.TabIndex = 9
        grpTambah.TabStop = False
        grpTambah.Text = "Tambah Buku"
        ' 
        ' grpHapus
        ' 
        grpHapus.Controls.Add(lblJudulHapus)
        grpHapus.Controls.Add(txtHapus)
        grpHapus.Controls.Add(btnHapus)
        grpHapus.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpHapus.Location = New Point(380, 80)
        grpHapus.Name = "grpHapus"
        grpHapus.Size = New Size(310, 170)
        grpHapus.TabIndex = 10
        grpHapus.TabStop = False
        grpHapus.Text = "Hapus Buku"
        ' 
        ' lblJudulHapus
        ' 
        lblJudulHapus.AutoSize = True
        lblJudulHapus.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJudulHapus.Location = New Point(20, 40)
        lblJudulHapus.Name = "lblJudulHapus"
        lblJudulHapus.Size = New Size(79, 20)
        lblJudulHapus.TabIndex = 11
        lblJudulHapus.Text = "Judul Buku"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(755, 544)
        Controls.Add(lblTitle)
        Controls.Add(grpHapus)
        Controls.Add(grpTambah)
        Controls.Add(lstBuku)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Daftar Buku Perpustakaan"
        grpTambah.ResumeLayout(False)
        grpTambah.PerformLayout()
        grpHapus.ResumeLayout(False)
        grpHapus.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblJudul As Label
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtHapus As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents lstBuku As ListBox
    Friend WithEvents grpTambah As GroupBox
    Friend WithEvents grpHapus As GroupBox
    Friend WithEvents lblJudulHapus As Label

End Class
