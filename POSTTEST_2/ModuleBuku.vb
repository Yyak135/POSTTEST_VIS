Public Module ModuleBuku

    Public daftarBuku(99, 1) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)

        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = judul
            daftarBuku(jumlahBuku, 1) = genre
            jumlahBuku = jumlahBuku + 1
        End If

    End Sub

    Public Sub HapusBuku(ByVal judul As String)

        Dim i As Integer

        For i = 0 To jumlahBuku - 1

            If daftarBuku(i, 0).ToLower = judul.ToLower Then

                Dim j As Integer

                For j = i To jumlahBuku - 2
                    daftarBuku(j, 0) = daftarBuku(j + 1, 0)
                    daftarBuku(j, 1) = daftarBuku(j + 1, 1)
                Next

                jumlahBuku = jumlahBuku - 1
                Exit For

            End If

        Next

    End Sub

    Public Function FormatBuku(ByVal judul As String, ByVal genre As String) As String

        Dim hasil As String
        hasil = judul & " (" & genre & ")"
        Return hasil

    End Function

End Module