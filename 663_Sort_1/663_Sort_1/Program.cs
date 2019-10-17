using System;
using System.Collections.Generic;

namespace _663_Sort_1
{
    class Program
    {    
        public class Point : IComparable<Point>
        {
            public string id { get; set; }
            public int x { get; set; }
            public int y { get; set; }
            public double distance { get; set; }
            
            public Point(string id, int x, int y, double distance)
            {
                this.id = id;
                this.x = x;
                this.y = y;
                this.distance = distance;
            }

            public int CompareTo(Point other)
            {
                if (this.distance > other.distance) return 1;
                else if (this.distance < other.distance) return -1;
                else return 0;
            }
        }

        static void Main(string[] args)
        {
            List<Point> Points = new List<Point>();

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    string[] data = Console.ReadLine().Split(' ');
                    int a = int.Parse(data[1]);
                    int b = int.Parse(data[2]);
                    
                    Points.Add(new Point(data[0], a, b, Distance(a,b)));
                }

                Points.Sort();
                foreach (Point p in Points)
                {
                    Console.WriteLine("{0} {1} {2}", p.id, p.x, p.y);
                }
                Points.Clear();
                Console.WriteLine();
                string pause = Console.ReadLine();

            }
        }

      
        static double Distance(int a, int b)
        {
            return Math.Sqrt(a * a + b * b);
        }
    }


}
