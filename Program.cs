using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Ralph", 25);
            SayHi("Rich", 19);
            SayHi("Sara", 32);

            GoodNight("Ted");

            Console.ReadLine();
        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name} you are {age}");
        }

        static void GoodNight(string name)
        {
            Console.WriteLine($"GoodNight {name} ");
        }


    }

}
