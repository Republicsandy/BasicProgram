using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    class FlipCoinPercentage
    {
        int Head = 0;
        int Tail = 0;
        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of time you want to flip the coin :");
            int NumberOfFilps = Convert.ToInt32(Console.ReadLine());
            while (NumberOfFilps <= 0)
            {
                Console.WriteLine("Invalide input Enter the number of time you want to flip the coin");
                NumberOfFilps = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < NumberOfFilps; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);
                if (HoT < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tail++;
                }
                float Head_Percentage = Head * 100 / NumberOfFilps;
                float Tali_Percentage = Tail * 100 / NumberOfFilps;
                Console.WriteLine("Percentage of Heads are:" + Head_Percentage);
                Console.WriteLine("Percentage of Heads are:" + Tali_Percentage);
            }
        }
    }
}
