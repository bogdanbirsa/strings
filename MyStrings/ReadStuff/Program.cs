using System;

namespace ReadStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a string");
            string readedLine = Console.ReadLine();

            Console.WriteLine("please enter the second string");
            string readedLine2 = Console.ReadLine();

            if (readedLine == readedLine2)
            {
                Console.WriteLine("ok");
            }

            //compare - true = A mare = a mic

            Console.WriteLine(string.Compare(readedLine, readedLine2, true));

            if (readedLine.Equals(readedLine2))
            {
                Console.WriteLine("Equals");
            }
        }
    }
}
