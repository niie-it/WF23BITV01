using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nguoi01 = new Person();
            nguoi01.Id = 1;
            nguoi01.Name = "David";
            Console.WriteLine(nguoi01.Print());
            Console.WriteLine(nguoi01);
            Console.WriteLine(nguoi01.ToString());

            Person person = new Person()
            {
                Id = 3,
                Name = "Ronaldo"
            };
            Console.WriteLine(person);
        }
    }
}
