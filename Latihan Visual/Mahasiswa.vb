Public Class Mahasiswa
    'Deklarasi Properti
    Public nama As String
    Public nim As Integer
    Public nilaiTugas As Integer
    Public nilaiUts As Integer
    Public nilaiUas As Integer
    Public nilaiAkhir As Integer
    Public nilaiHuruf As String

    Public Sub New()
        nama = ""
        nim = 0
        nilaiTugas = 0
        nilaiUts = 0
        nilaiUas = 0
    End Sub

    Public Sub InputData()
        Console.Write("Masukkan Nama: ")
        nama = Console.ReadLine()
        Console.Write("Masukkan NIM: ")
        nim = Console.ReadLine()
        Console.Write("Masukkan Nilai Tugas: ")
        nilaiTugas = Console.ReadLine()
        Console.Write("Masukkan Nilai UTS: ")
        nilaiUts = Console.ReadLine()
        Console.Write("Masukkan Nilai UAS: ")
        nilaiUas = Console.ReadLine()
    End Sub

    Public Sub hitungNilaiAkhir()
        nilaiAkhir = (nilaiTugas + nilaiUts + nilaiUas) / 3
        Console.WriteLine(nilaiAkhir)
    End Sub

    Public Sub konversiNilaiAkhir()

        If nilaiAkhir <= 100 And nilaiAkhir >= 70 Then
            nilaiHuruf = "A"
            Console.WriteLine(nilaiHuruf)
        ElseIf nilaiAkhir <= 69 And nilaiAkhir >= 60 Then
            nilaiHuruf = "B"
            Console.WriteLine(nilaiHuruf)
        ElseIf nilaiAkhir <= 59 And nilaiAkhir >= 50 Then
            nilaiHuruf = "C"
            Console.WriteLine(nilaiHuruf)
        ElseIf nilaiAkhir <= 49 And nilaiAkhir >= 0 Then
            nilaiHuruf = "D"
            Console.WriteLine(nilaiHuruf)
        End If
    End Sub

    Public ReadOnly Property GetNilaiAkhir() As Double
        Get
            Return nilaiAkhir
        End Get
    End Property

    Public ReadOnly Property GetNilaiHuruf() As String
        Get
            Return nilaiHuruf
        End Get
    End Property

End Class



