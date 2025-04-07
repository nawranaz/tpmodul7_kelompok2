using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class KuliahMahasiswa103022300125
{
    // Class untuk mewakili satu mata kuliah
    public class Course
    {
        public string code { get; set; }   // Kode mata kuliah
        public string name { get; set; }   // Nama mata kuliah
    }

    // Class wrapper untuk semua courses
    public class CourseList
    {
        public List<Course> courses { get; set; }
    }

    // Method untuk membaca dan menampilkan JSON
    public static void ReadJSON()
    {
        string filePath = "tp7_2_103022300125.json"; // Nama file JSON

        try
        {
            string jsonContent = File.ReadAllText(filePath); // Baca isi file
            CourseList courseList = JsonSerializer.Deserialize<CourseList>(jsonContent); // Parse JSON ke object

            if (courseList != null && courseList.courses != null)
            {
                Console.WriteLine("Daftar mata kuliah yang diambil:");
                int index = 1;
                foreach (var course in courseList.courses)
                {
                    Console.WriteLine($"MK {index} {course.code} - {course.name}");
                    index++;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Gagal membaca file JSON: " + ex.Message);
        }
    }
}
