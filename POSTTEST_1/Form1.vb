Public Class Form1

    Private totalIP As Double = 0
    Private jumlahSemester As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtIPK.ReadOnly = True
        txtIPK.Text = ""
        lblPredikat.Text = ""
        txtIPSemester.Text = ""
        txtIPSemester.Focus()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim ipSemester As Double

        If Not Double.TryParse(txtIPSemester.Text, ipSemester) Then
            MessageBox.Show("Masukkan IP Semester yang valid (0.00 - 4.00)")
            txtIPSemester.Focus()
            Exit Sub
        End If

        If ipSemester < 0 Or ipSemester > 4 Then
            MessageBox.Show("IP Semester harus antara 0.00 sampai 4.00")
            txtIPSemester.Focus()
            Exit Sub
        End If

        totalIP = totalIP + ipSemester
        jumlahSemester = jumlahSemester + 1

        Dim ipk As Double = totalIP / jumlahSemester

        txtIPK.Text = ipk.ToString("0.00")

        If ipk >= 2.0 And ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
            lblPredikat.ForeColor = Color.DarkOrange

        ElseIf ipk >= 2.76 And ipk <= 3.0 Then
            lblPredikat.Text = "Memuaskan"
            lblPredikat.ForeColor = Color.SteelBlue

        ElseIf ipk >= 3.01 Then
            lblPredikat.Text = "Sangat Memuaskan"
            lblPredikat.ForeColor = Color.ForestGreen

        Else
            lblPredikat.Text = "-"
            lblPredikat.ForeColor = Color.Black
        End If

        txtIPSemester.Clear()
        txtIPSemester.Focus()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        totalIP = 0
        jumlahSemester = 0

        txtIPSemester.Clear()
        txtIPK.Clear()
        lblPredikat.Text = ""

        txtIPSemester.Focus()

    End Sub

End Class