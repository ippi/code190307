using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1 problem1 = new Problem1("joycastleisnotacastle", 't');
            problem1.Solve();
            problem1.PrintResult();

            Console.Write(Environment.NewLine);

            Problem2 problem2 = new Problem2(new Point[] { new Point(5f, 5f), new Point(2.5f, 7.5f), new Point(7.5f, 2.5f), new Point(5f, 2.5f), new Point(7.5f, 5f) });
            problem2.Solve();
            problem2.PrintResult();

            Console.ReadLine();
        }
    }
}
