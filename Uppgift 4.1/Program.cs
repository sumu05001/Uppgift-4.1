using System;
namespace Uppgift_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int talen = 10; talen <= 30; talen++)
            {
                Console.WriteLine(talen);
            }
            Console.WriteLine();

            for (int talen = 200; talen >= 180; talen --)
            {
                Console.WriteLine(talen);
            }
            Console.WriteLine();

            for (int talen = 1000; talen <= 1400; talen +=50)
            {
                Console.WriteLine(talen);
            }

        }  
    }  
}

