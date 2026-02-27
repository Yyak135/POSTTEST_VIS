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
        Label1 = New Label()
        txtIPSemester = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label2 = New Label()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        lblJudul = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(90, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 23)
        Label1.TabIndex = 0
        Label1.Text = "IP Semester"
        ' 
        ' txtIPSemester
        ' 
        txtIPSemester.BorderStyle = BorderStyle.FixedSingle
        txtIPSemester.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIPSemester.Location = New Point(225, 86)
        txtIPSemester.Name = "txtIPSemester"
        txtIPSemester.Size = New Size(225, 31)
        txtIPSemester.TabIndex = 1
        txtIPSemester.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.SteelBlue
        btnTambah.Cursor = Cursors.Hand
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(225, 138)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(107, 40)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.IndianRed
        btnReset.Cursor = Cursors.Hand
        btnReset.FlatAppearance.BorderSize = 0
        btnReset.FlatStyle = FlatStyle.Flat
        btnReset.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReset.ForeColor = Color.White
        btnReset.Location = New Point(343, 138)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(107, 40)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(90, 207)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 23)
        Label2.TabIndex = 4
        Label2.Text = "IP Kumulatif"
        ' 
        ' txtIPK
        ' 
        txtIPK.BorderStyle = BorderStyle.FixedSingle
        txtIPK.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtIPK.Location = New Point(286, 201)
        txtIPK.Name = "txtIPK"
        txtIPK.ReadOnly = True
        txtIPK.Size = New Size(140, 34)
        txtIPK.TabIndex = 5
        txtIPK.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPredikat.ForeColor = Color.ForestGreen
        lblPredikat.Location = New Point(225, 250)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(0, 28)
        lblPredikat.TabIndex = 6
        ' 
        ' lblJudul
        ' 
        lblJudul.AutoSize = True
        lblJudul.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblJudul.ForeColor = Color.DarkSlateGray
        lblJudul.Location = New Point(110, 20)
        lblJudul.Name = "lblJudul"
        lblJudul.Size = New Size(412, 38)
        lblJudul.TabIndex = 7
        lblJudul.Text = "KALKULATOR IP MAHASISWA"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 23F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(542, 314)
        Controls.Add(lblJudul)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(Label2)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIPSemester)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator IP Mahasiswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIPSemester As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents lblJudul As Label

End Class
