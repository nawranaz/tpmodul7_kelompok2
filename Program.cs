﻿// See https://aka.ms/new-console-template for more information
using tpmodul7_kelompok_2;

class Program
{
    static void Main(string[] args)
    {
        var data = new DataMahasiswa103022300054();
        data.ReadJSON();

        var kuliah = new KuliahMahasiswa103022300054();
        kuliah.ReadJSON();
    }
}

