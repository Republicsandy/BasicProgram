using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class PowerOfTwo
    {
        public void PowerOfTwoNumber()
        {
            Console.WriteLine("Please enter the number :");
            int Number = Convert.ToInt32(Console.ReadLine());
            while (Number < 0 || Number >= 31)
            {
                Console.WriteLine("Invalid Input , Please enter the number:");
                Number = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
