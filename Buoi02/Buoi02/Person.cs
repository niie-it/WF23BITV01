using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    public class Person
    {
        // Định nghĩa Field, Property (thành phần dữ liệu)
        public int Id { get; set; }
        public string Name { get; set; }

        //Định nghĩa hàm (method) - hành vi
        public string Print()
        {
            return $"Person {Id} - {Name}";
        }

        public override string ToString()
        {
            return $"Person {Id} - {Name}";
        }
    }
}
