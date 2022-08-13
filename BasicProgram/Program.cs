using System;

namespace BasicProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("select the number for relative program");
            Console.WriteLine(" 1 :for Flip Coin Percentage");
            Console.WriteLine(" 2 :for LeapYear");
            Console.WriteLine(" 3 :for Power Of Two");
            Console.WriteLine(" 4 :for Harmonic Number");
            Console.WriteLine(" 5 :for Prime Factor");
            Console.WriteLine(" 6 :for Compute Quotient and Remainder");
            Console.WriteLine(" 7 :for Swap Tow Number");

            int Answer = Convert.ToInt32(Console.ReadLine());

            switch (Answer)
            {
                case 1:
                    FlipCoinPercentage flipcoin = new FlipCoinPercentage();
                    flipcoin.FlipCoin();
                    break;
                case 2:
                    LeapYear leapyear = new LeapYear();
                    leapyear.Leapyear();
                    break;
                case 3:
                    PowerOfTwo poweroftwo = new PowerOfTwo();
                    poweroftwo.PowerOfTwoNumber();
                    break;
                case 4:
                    Harmonic harmonicnumber = new Harmonic();
                    harmonicnumber.HarmonicFunction();
                    break;
                case 5:
                    Factor factor = new Factor();
                    factor.PrimeFactor();
                    break;
                case 6:
                    ComputQuotientReminder querem = new ComputQuotientReminder();
                    querem.QueRem();
                    break;
                case 7:
                    SwapTwoNumber swap = new SwapTwoNumber();
                    swap.SwapingNumbers();
                    break;
            }
        }
    }
}
