using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT6
{
    class Ball
    {

        private int size;
        private int color;
        private int count;

        public int Size { get => size; set => size = value; }
        public int Color { get => color; set => color = value; }
        public int Count { get => count; set => count = value; }

        public Ball()
        {
            this.size = 1;
            this.color = 255;
            this.count = 0;
        }

        public Ball(int size, int color, int count)
        {
            this.Size = size;
            this.Color = color;
            this.Count = count;
        }

        public int Pop()
        {
            return Size = 0;
        }

        public int Throw()
        {
            if (size != 0)
                Count++;
            return Count;
        }

        public void Input(int i)
        {
            Console.WriteLine($"Nhap Thong Tin Trai Banh Thu {i}");
            Console.Write($"Size Trai Banh Thu {i}: ");
            Size = int.Parse(Console.ReadLine());
            Console.Write($"Color Trai Banh Thu {i}: ");
            Color = int.Parse(Console.ReadLine());
            Console.Write($"Count Nem Trai Banh Thu {i}: ");
            Count = int.Parse(Console.ReadLine());
        }

        public void Output(int i)
        {
            Console.WriteLine($"------Trai Banh Thu {i}------");
            Console.WriteLine($"Size Trai Banh Thu {i}: {size} ");
            Console.WriteLine($"Color Trai Banh Thu {i}: {color} ");
            Console.WriteLine($"Count Nem Trai Banh Thu {i}: {count} ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap So Luong Trai Banh: ");
            int n = int.Parse(Console.ReadLine());

            Ball[] ball = new Ball[n];

            for (int i = 0; i < n; i++)
            {
                ball[i] = new Ball();
                ball[i].Input(i + 1);
            }

            //ball[0].Input(1);

            for (int i = 0; i < n; i++)
            {
                ball[i].Output(i + 1);
            }

            ball[1].Throw();
            ball[2].Throw();

            ball[1].Pop();
            ball[1].Throw();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"So Lan Nem Trai Banh Thu {i + 1}: {ball[i].Count}");
            }

        }
    }
}
