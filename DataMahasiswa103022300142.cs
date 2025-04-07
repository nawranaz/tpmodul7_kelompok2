using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace tpmodul7_kelompok_2
{
    class DataMahasiswa103022300142
    {
        public string nama { get; set; }
        public string nim { get; set; }
        public string fakultas { get; set; }

        

        public static void ReadJSON()
          {
                
                string json = File.ReadAllText("tp7_1_103022300142.json");

             JObject data = JObject.Parse(json);

             string namaDepan = data["nama"]?["depan"]?.ToString();
              string namaBelakang = data["nama"]?["belakang"]?.ToString();
              string nim = data["nim"]?.ToString();
              string fakultas = data["fakultas"]?.ToString();

                Console.WriteLine($"Nama {namaDepan} {namaBelakang} dengan NIM {nim} dari fakultas {fakultas}");
          }

        }
}
