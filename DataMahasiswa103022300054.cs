using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace tpmodul7_kelompok_2
{
    public class DataMahasiswa103022300054
    {
        public class Nama
        {
            [JsonPropertyName("depan")]
            public string Depan { get; set; }

            [JsonPropertyName("belakang")]
            public string Belakang { get; set; }
        }

        public class Mahasiswa
        {
            [JsonPropertyName("nama")]
            public Nama Nama { get; set; }

            [JsonPropertyName("nim")]
            public string Nim { get; set; }

            [JsonPropertyName("fakultas")]
            public string Fakultas { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "tp7_1_103022300054.json";
            string jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            Mahasiswa mhs = JsonSerializer.Deserialize<Mahasiswa>(jsonString, options);

            Console.WriteLine($"Nama {mhs.Nama.Depan} {mhs.Nama.Belakang} dengan nim {mhs.Nim} dari fakultas {mhs.Fakultas}");
        }
    }
}
