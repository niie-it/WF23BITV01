using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Xin chào các bạn");
            Console.Write("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Chào bạn " + hoTen);
            Console.WriteLine($"Hello {hoTen}");
        }
    }
}
