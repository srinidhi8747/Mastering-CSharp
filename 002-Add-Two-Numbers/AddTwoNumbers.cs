using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastering_CSharp._002_Add_Two_Numbers
{
    public class AddTwoNumbers
    {
        public static void Run()
        {
            int number1 = 10;
            int number2 = 20;

            int sum = number1 + number2;

            Console.WriteLine($"First Number  : {number1}");
            Console.WriteLine($"Second Number : {number2}");
            Console.WriteLine($"Sum is: {sum}");
        }
    }
}
