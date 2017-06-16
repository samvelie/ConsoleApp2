using System;

namespace ConsoleApp2
{
    class Program
    {
        //this below is a "method"
        public static void Main(string[] args)
        {
            var numberOfBananas = 3;
            Console.WriteLine(numberOfBananas);
            numberOfBananas = 4;
            Console.WriteLine(numberOfBananas);
            var numberOfApples = 5;
            int applesPlusBananas = numberOfBananas + numberOfApples;
            Console.WriteLine(applesPlusBananas);
        }
    }
}
