Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahBuku("Harry Potter", "Fantasi")
        TambahBuku("Sherlock Holmes", "Misteri")

        TampilBuku()

    End Sub


    Private Sub TampilBuku()

        lstBuku.Items.Clear()

        Dim i As Integer

        For i = 0 To jumlahBuku - 1

            Dim teks As String
            teks = FormatBuku(daftarBuku(i, 0), daftarBuku(i, 1))

            lstBuku.Items.Add(teks)

        Next

    End Sub


    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click

        Dim judul As String
        Dim genre As String

        judul = txtJudul.Text
        genre = txtGenre.Text

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre harus diisi")
            Exit Sub
        End If

        TambahBuku(judul, genre)

        txtJudul.Clear()
        txtGenre.Clear()

        TampilBuku()

    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click

        Dim judul As String
        judul = txtHapus.Text

        If judul = "" Then
            MessageBox.Show("Masukkan judul buku")
            Exit Sub
        End If

        HapusBuku(judul)

        txtHapus.Clear()

        TampilBuku()

    End Sub

End Class