using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double banKinh;
            while (true)
            {
                try
                {
                    Console.Write("Nhập bán kính: ");
                    banKinh = double.Parse(Console.ReadLine());
                    if (banKinh > 0)
                    {
                        break;//dừng while
                    }
                    Console.WriteLine("Bán kính phải không âm");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi nhập liệu: " + ex.Message);
                    Console.WriteLine("Vui lòng nhập lại");
                }
            }
            double chuVi = Math.Round(2 * banKinh * Math.PI, 3);
            double dienTich = Math.Round(Math.Pow(banKinh, 2) * Math.PI, 3);
            Console.WriteLine($"R={banKinh}, S = {dienTich}, P={chuVi}");
        }
    }
}
