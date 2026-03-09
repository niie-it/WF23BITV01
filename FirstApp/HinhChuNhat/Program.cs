using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhChuNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("HÌNH CHỮ NHẬT");
            Console.Write("Nhập chiều dài: ");
            double chieuDai = 0;
            try
            {
                chieuDai = double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.ToString());
            }
            Console.Write("Nhập chiều rộng: ");
            double chieuRong = double.Parse(Console.ReadLine());
            double dienTich = Math.Round(chieuDai * chieuRong, 2);
            double chuVi = Math.Round((chieuRong + chieuDai) * 2, 2);
            Console.WriteLine($"D={chieuDai} x R={chieuRong} ==> S={dienTich}, P={chuVi}");
        }
    }
}
