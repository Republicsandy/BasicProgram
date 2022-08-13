using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class Factor
    {
        public void PrimeFactor()
        {
            Console.WriteLine("Enter the Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i * i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
