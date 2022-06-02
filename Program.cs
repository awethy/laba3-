using System;

namespace laba3_
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Координаты: ");

            Dots A = new Dots(15.10, 14.10, 13.10, "A", "Red");
            Console.WriteLine(A.Print());

            Dots B = new Dots(18.35, 17.35, 15.30, "B", "Blue");
            Console.WriteLine(B.Print());
            Console.ReadLine();

        }

    }
}
