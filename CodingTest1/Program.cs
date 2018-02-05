using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 1)
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Enter Array Size");
            //int inputSize = Convert.ToInt32(Console.ReadLine());

            // int[] array1 = new int[] { 1, 3, 5, 7, 9 };
            //int[] array1 = new int[] { 1, -3, 5, 7, -9 };
            //int[] array1 = new int[] { 1 };
            //int[] array1 = new int[] { 9, 1, 3, 5 };

            //Console.WriteLine(GetLargeNumberFromArray(array1));

            //Console.WriteLine(findLargestNumber(5));

            BracketChecker bc = new BracketChecker();
            if (bc.checkBrackets("{))}"))
            {
                Console.WriteLine("Brackets matched");
            }
            else
            {
                Console.WriteLine("Brackets not matching");
            }
            Console.ReadKey();
        }

        public static int GetLargeNumberFromArray(int[] array1)
        {
            int large = 0;

            if (array1.Length == 0)
                return large;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.Length > 1)
                {
                    for (int j = i + 1; j < array1.Length; j++)
                    {
                        if (array1[i] < array1[j])
                        {
                            if (large < array1[j])
                                large = array1[j];
                        }
                        else
                        {
                            if (large < array1[i])
                            {
                                large = array1[i];
                                continue;
                            }
                        }
                    }
                }
                else
                {
                    large = array1[i];
                }
            }
            return large;
        }

        public static int findLargestNumber(int n)
        {
            int x = 0;
            double power = 0;
            while (power <= n)
            {
                power = Math.Pow(x, 2);
                x++;
            }
            return x;
        }
    }
}