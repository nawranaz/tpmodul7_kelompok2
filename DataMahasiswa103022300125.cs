using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022300125
{
    public class Nama
    {
        public string depan { get; set; } // Property untuk "nama.depan"
        public string belakang { get; set; } // Property untuk "nama.belakang"
    }

    public class Mahasiswa // Class utama Mahasiswa untuk menampung struktur data JSON
    {
        public Nama nama { get; set; }
        public long nim { get; set; }
        public string fakultas { get; set; }
    }

    public static void ReadJSON() // Method untuk membaca file JSON dan mengubahnya menjadi object
    {
        string filePath = "tp7_1_103022300125.json";  // Nama file JSON yang akan dibaca (harus ada di folder bin/Debug)

        try
        {
            string jsonContent = File.ReadAllText(filePath); // Baca semua isi file JSON sebagai string
            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(jsonContent); // Deserialize string JSON menjadi objek Mahasiswa

            if (data != null)
            {
                Console.WriteLine($"Nama {data.nama.depan} {data.nama.belakang} dengan nim {data.nim} dari fakultas {data.fakultas}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca file JSON: " + ex.Message);
        }
    }
}
