using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemSoLanXuatHien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập chuỗi: ");
            string chuoi = Console.ReadLine();
            Dictionary<string, int> thongKe = new Dictionary<string, int>();
            string[] words = chuoi.Split(' ');
            foreach (string word in words)
            {
                //thực hiện đếm số lần xuất hiện của từ đó trong chuỗi
            }
        }
    }
}
