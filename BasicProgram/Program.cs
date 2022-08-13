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
            Console.WriteLine(" 2 :for Power Of Two");

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
            }
        }
    }
}
