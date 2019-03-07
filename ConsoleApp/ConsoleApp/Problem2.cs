using System;

namespace ConsoleApp
{
    public class Point
    {
        public float x;
        public float y;

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Problem2
    {
        private Point[] points;
        private int result;
        public Problem2(Point[] points)
        {
            this.points = points;
        }

        public void Solve()
        {
            result = 0;
            if (points.Length <= 2)
            {
                result = points.Length;
                return;
            }
            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int count = 2;
                    for (int k = 0; k < points.Length; k++)
                    {
                        if (k == i || k == j)//skip the same points
                        {
                            continue;
                        }
                        if ((points[k].x - points[i].x) * (points[i].y - points[j].y) == (points[i].x - points[j].x) * (points[k].y - points[i].y))//check three point on a line
                        {
                            count++;
                        }
                    }
                    if (count > result)
                    {
                        result = count;
                    }
                }
            }
        }

        public void PrintResult()
        {
            Console.Write("The max points on a line is: {0}", result);
        }
    }
}
