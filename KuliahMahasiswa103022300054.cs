using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace tpmodul7_kelompok_2
{
    class KuliahMahasiswa103022300054
    {
        public class Course
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

        public class ListCourse
        {
            public List<Course> Courses { get; set; }
        }

        public void ReadJSON()
        {
            string path = "tp7_2_103022300054.json";
            string jsonString = File.ReadAllText(path);

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            ListCourse data = JsonSerializer.Deserialize<ListCourse>(jsonString, options);

            Console.WriteLine("Daftar mata kuliah yang diambil:");
            int i = 1;
            foreach (var course in data.Courses)
            {
                Console.WriteLine($"MK {i} {course.Code} - {course.Name}");
                i++;
            }
        }
    }
}
