Module Module1

    Sub Main()
        Dim objMahasiswa As New Mahasiswa

        objMahasiswa.InputData()

        Console.Clear()

        Console.WriteLine("- REKAP DATA -")
        Console.WriteLine(objMahasiswa.nama)
        Console.Write("Nilai Akhir: ")
        objMahasiswa.hitungNilaiAkhir()
        Console.Write("Nilai Huruf: ")
        objMahasiswa.konversiNilaiAkhir()
        Console.ReadLine()

    End Sub

End Module
