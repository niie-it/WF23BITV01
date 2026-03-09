using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi03
{
    public class Shape
    {
        public string Color { get; set; }
        protected Shape(string color)

        {

            Color = color;

        }



        public abstract double GetArea();

        public abstract double GetPerimeter();
    }
}
