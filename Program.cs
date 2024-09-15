using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BTlop2_venha.Program;

namespace BTlop2_venha
{
    internal class Program
    {
        public delegate int Tuoi(int[] Age);
        public class Student
        {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        
        public Student(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}";
        }
    }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
                    
            List<Student> students = new List<Student>();

            students.Add(new Student(1, "Nguyen Van A", 20));
            students.Add(new Student(2, "Le Thi B", 17));
            students.Add(new Student(3, "Tran Van C", 15));
            students.Add(new Student(4, "Do Anh D ",23));
            students.Add(new Student(5, "Truong Van E", 24));
            Console.WriteLine("Danh sách học sinh:");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }



            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. xuất sinh viên từ 15 đến 18 tuổi ");
                Console.WriteLine("2. Hiển thị danh sách sinh viên có tên bắt đầu bằng A ");
                Console.WriteLine("3. xuất tổng số tuổi ");
                Console.WriteLine("4. xuất sinh viên có số tuổi lớn nhất ");
                Console.WriteLine("5. xuất danh sách sinh viên theo độ tuổi lớn nhất ");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("Nhập lựa chọn của bạn :");
        

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        var studentsBetween15And20 = students.Where(s => s.Age >= 15 && s.Age <= 20);

                        
                        Console.WriteLine("Học sinh từ 15 đến 20 tuổi:");
                        foreach (var student in studentsBetween15And20)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "2":
                        var studentsStartingWithA = students.Where(s => s.Name.Split(' ').Last().StartsWith("A", StringComparison.OrdinalIgnoreCase));

                        Console.WriteLine("Danh sách sinh viên có tên bắt đầu bằng A:");
                        foreach (var student in studentsStartingWithA)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "3":                
                        var sumAge = students.Sum(n => n.Age );
                        Console.WriteLine($"Tông số tuổi: {sumAge}");
                        break;
                    case "4":
                        var maxAge = students.OrderByDescending(n => n.Age ).FirstOrDefault();
                        Console.WriteLine(maxAge);
                        break;
                    case "5":
                        var sapXep = students.OrderBy(n => n.Age).ToList();
                        foreach (var student in sapXep)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("Kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                        break;
                }
                Console.WriteLine();
            }




        }

    }
}
