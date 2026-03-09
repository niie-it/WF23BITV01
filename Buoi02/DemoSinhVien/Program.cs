using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student sv01 = new Student()
            {
                Id = 1,
                FullName = "David",
                Major = "IT",
                Gpa = 3.9
            };
            var sv02 = new Student(2, "Tèo", 3.4, "Business Admin");
            Console.WriteLine(sv01.Display());
            Console.WriteLine(sv02.Display());
        }
    }
}
