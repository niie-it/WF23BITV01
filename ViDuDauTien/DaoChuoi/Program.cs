using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaoChuoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập vào chuỗi: ");
            string chuoi = Console.ReadLine().Trim();

            //Cách 1: Dùng hàm
            foreach(var item in chuoi.Reverse())
            {
                Console.Write(item);
            }
            Console.WriteLine();

            //Cách 2: Dùng vòng lặp
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                Console.Write(chuoi[i]);
            }
        }
    }
}
