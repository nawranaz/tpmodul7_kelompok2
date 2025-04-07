// See https://aka.ms/new-console-template for more information
using tpmodul7_kelompok_2;


class Program
{
    static void Main(string[] args)
    {
        DataMahasiswa103022300142.ReadJSON();
        Console.WriteLine();

        
        var kuliah = new KuliahMahasiswa103022300142();
        kuliah.ReadJSON();
    }
}