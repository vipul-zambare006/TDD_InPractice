using System;

namespace CodingTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            ParathesisMatcher bc = new ParathesisMatcher();

            if (bc.checkBrackets("{}"))
                Console.WriteLine("Brackets matched");
            else
                Console.WriteLine("Brackets not matching");
            Console.ReadKey();
        }
    }
}