using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            rectangles.Add(new Rectangle(3, 2));
            rectangles.Add(new Rectangle(23, 21));
            rectangles.Add(new Rectangle(3.3, 2.1));
            rectangles.Add(new Rectangle(7, 14));

            //duyệt và in ra
            foreach (var item in rectangles)
            {
                Console.WriteLine(item);
            }
        }
    }
}
