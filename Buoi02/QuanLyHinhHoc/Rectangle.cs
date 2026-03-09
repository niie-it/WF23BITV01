using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHinhHoc
{
    public class Rectangle
    {
        public double _width;
        public double _height;

        public double Area
        {
            get { return _width * _height; }
        }
        public double Perimeter => (_width + _height) * 2;

        public Rectangle() { }
        public Rectangle(double x = 1.0, double y = 1.0)
        {
            _width = x; _height = y;
        }

        public override string ToString()
        {
            return $"Rectangle {_width} x {_height}, S={Area}, P={Perimeter}";
        }
    }
}
