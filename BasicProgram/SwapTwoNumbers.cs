using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class SwapTwoNumber
    {
        public void SwapingNumbers()
        {
            int num1, num2, swap = 0;
            Console.WriteLine("Please enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number enter by user: first={0},second={1}", num1, num2);
            swap = num1;
            num1 = num2;
            num2 = swap;
            Console.WriteLine("Number after swaping:first={0},second={1}", num1, num2);
        }
    }
}
