using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    class Color
    {
        private int red;
        private int green;
        private int blue;
        private int alpha;

        public int Red { get => red; set => red = value; }
        public int Green { get => green; set => green = value; }
        public int Blue { get => blue; set => blue = value; }
        public int Alpha { get => alpha; set => alpha = value; }

        public Color()
        {
            this.Red = 255;
            this.Green = 255;
            this.Blue = 255;
            this.Alpha = 255;
        }

        public Color(int red, int green, int blue, int alpha)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        public Color(Color color)
        {
            this.Red = color.Red;
            this.Green = color.Green;
            this.Blue = color.Blue;
            this.Alpha = color.Alpha;
        }

        public double GrayScale()
        {
            return (red + green + blue) / 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
