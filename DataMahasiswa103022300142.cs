using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
            DataMahasiswa103022300142 data = JsonConvert.DeserializeObject<DataMahasiswa103022300142>(json);
            Console.WriteLine($"Nama {data.nama} dengan nim {data.nim} dari fakultas {data.fakultas}");
        }
    }
}
