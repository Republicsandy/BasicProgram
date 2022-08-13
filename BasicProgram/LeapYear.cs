using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class LeapYear
    {
        public void Leapyear()
        {

            Console.WriteLine("Enter yhe year:");
            int Year = Convert.ToInt32(Console.ReadLine());
            while (Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Invalid input , Enter the Year:");
                Year = Convert.ToInt32(Console.ReadLine());
            }
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("Year is Leap Year");
            }
            else
            {
                Console.WriteLine("Year is not leap Year");
            }
        }
    }
}
