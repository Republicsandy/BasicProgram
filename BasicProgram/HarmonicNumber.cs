using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
   class Harmonic
    {
        public void HarmonicFunction()
        {
            Console.WriteLine("Enter the numbre :");
            int N = Convert.ToInt32(Console.ReadLine());
            while (N <= 0)
            {
                Console.WriteLine("Invaled intput , Enter the number :");
                N = Convert.ToInt32(Console.ReadLine());
            }
            float Result = 0;
            for (float i = 1; i <= N; i++)
            {
                Result += 1 / i;
            }
            Console.WriteLine("The harmonic function is " + Result);
        }
    }
}
