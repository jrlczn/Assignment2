using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create student records
            List<Student> students = new List<Student>
            {
                new Student(101, "John",  "BSIT", 89),
                new Student(102, "Maria", "BSCS", 92),
                new Student(103, "Paul",  "BSIT", 75),
                new Student(104, "Ana",   "BSCS", 85),
                new Student(105, "Mark",  "BSIT", 90)
            };

            // Write to students.txt
            string filePath = "students.txt";
            File.WriteAllLines(filePath, students.Select(s => s.ToString()));



            // Display file contents (proof)
            Console.WriteLine("=== students.txt content ===");
            foreach (var line in File.ReadAllLines(filePath))
            {
                Console.WriteLine(line);
            }

            Console.WriteLine();

            // LINQ query execution (proof)
            Console.WriteLine("=== LINQ Query: BSIT Students Ordered by Grade (DESC) ===");
            var bsitStudents = students
                .Where(s => s.Course == "BSIT")
                .OrderByDescending(s => s.Grade);

            foreach (var s in bsitStudents)
            {
                Console.WriteLine($"{s.StudentID} - {s.Name} - {s.Grade}");
            }

            Console.ReadLine();
        }
    }
}