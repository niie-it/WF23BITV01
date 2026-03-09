using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSinhVien
{
    public class Student
    {
        public Student() { }
        public Student(int id, string name, double gpa, string major)
        {
            Id = id; FullName = name; Gpa = gpa; Major = major;
        }

        public int _id; //field
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("StudentID must > 0");
                }
            }
        }

        public string FullName { get; set; }
        public string Major { get; set; }

        public double Gpa { get; set; }

        public string Display()
        {
            return $"Student {Id}, {FullName}, {Major}, {Gpa}";
        }
    }
}
