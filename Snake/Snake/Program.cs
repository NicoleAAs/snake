using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0], y = numList[1], z = numList[2];

            foreach (int i in numList) Console.WriteLine(i);

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            Console.ReadLine();
        }

        public static void Func1(int value) {

        }

        public static void Func2(int value) {
            value++;
        }

        public static void Func3(int x) {
            x++;
        }

        public static void Move(Point p, int dx, int dy) {
            p.x = p.x + dx;
            p.y = p.y + dx;
        }

        public static void Reset(Point p) {
            p = new Point(0, 0, '\0');
        }

    }
}
