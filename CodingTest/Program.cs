using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest
{
    public class Program
    {
        int number = Convert.ToInt32(Console.ReadLine());

        public int calculateFactorial(int number)
        {
            return number * calculateFactorial(number - 1);
        }
    }
}
