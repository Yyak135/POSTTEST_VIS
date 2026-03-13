Public Class Form1

    Public Sub HanyaAngka(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaHuruf(sender As Object, e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        HanyaAngka(sender, e)
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim openFile As New OpenFileDialog

        openFile.Filter = "Image Files|*.jpg;*.png"

        If openFile.ShowDialog = DialogResult.OK Then

            picFoto.Image = Image.FromFile(openFile.FileName)

        End If

    End Sub


    Private Function AmbilHobby() As String

        Dim hasil As String = ""

        For Each ctrl As Control In grpHobby.Controls

            If TypeOf ctrl Is CheckBox Then

                Dim chk As CheckBox = CType(ctrl, CheckBox)

                If chk.Checked Then

                    hasil &= chk.Text & ", "

                End If

            End If

        Next

        Return hasil

    End Function


    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

        If txtNama.Text = "" Or txtUmur.Text = "" Or txtTelepon.Text = "" Or txtAlamat.Text = "" Then

            MessageBox.Show("Inputan tidak boleh kosong")

            Exit Sub

        End If

        If rbLaki.Checked = False And rbPerempuan.Checked = False Then

            MessageBox.Show("Pilih jenis kelamin")

            Exit Sub

        End If

        If AmbilHobby() = "" Then

            MessageBox.Show("Pilih minimal 1 hobby")

            Exit Sub

        End If

        Dim kartu As New FormHasil

        kartu.lblNama.Text = txtNama.Text
        kartu.lblUmur.Text = txtUmur.Text
        kartu.lblTanggal.Text = dtpTanggal.Text
        kartu.lblTelepon.Text = txtTelepon.Text
        kartu.lblAlamat.Text = txtAlamat.Text

        If rbLaki.Checked Then
            kartu.lblJK.Text = "Laki-Laki"
        Else
            kartu.lblJK.Text = "Perempuan"
        End If

        kartu.lblHobby.Text = AmbilHobby()

        kartu.picHasil.Image = picFoto.Image

        kartu.Show()

    End Sub

End Class