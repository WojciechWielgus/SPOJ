using System;
using System.Collections.Generic;

namespace _663_Sort_1
{
    class Program
    {    
        class Point
        {
            string id;
            int x;
            int y;
            double distance;
        
            public Point(string id, int x, int y, double distance)
            {
                this.id = id;
                this.x = x;
                this.y = y;
                this.distance = distance;
            }
        }

        static void Main(string[] args)
        {
            List<Point> Points = new List<Point>();

            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                string[,] points = new string[n, 4];
                for (int j = 0; j < n; j++)
                {
                    string[] data = Console.ReadLine().Split(' ');
                    int a = int.Parse(data[1]);
                    int b = int.Parse(data[2]);
                    Points.Add(new Point(data[0], a, b, Distance(a,b)));
                                     
                    //points[j, 0] = data[0];
                    //points[j, 1] = data[1];
                    //points[j, 2] = data[2];
                    //points[j, 3] = Distance(int.Parse(data[1]), int.Parse(data[2])).ToString();
                }

                Points.Sort(co)

                

                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if(int.Parse(points[j,3]) > int.Parse(points[j+1,3])) points.

                    }
                }

            }



        }

      
        static double Distance(int a, int b)
        {
            return Math.Sqrt(a * a + b * b);
        }




    }


}
