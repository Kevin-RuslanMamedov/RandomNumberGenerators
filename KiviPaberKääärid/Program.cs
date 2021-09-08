using System;

namespace KiviPaberKääärid
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string PlayerOne = "Harry Potter";
            string PlayerTwo = "Voldemort";

            int HarryThrow = rnd.Next(1, 7);
            int VoldemortThrow = rnd.Next(1, 7);

            Console.WriteLine($"{PlayerOne} threw {HarryThrow}");
            Console.WriteLine($"{PlayerTwo} threw {VoldemortThrow}");
            
            if(HarryThrow > VoldemortThrow)
            {
                Console.WriteLine($"{PlayerOne} wins!");
            }
            else if(HarryThrow < VoldemortThrow)
            {
                Console.WriteLine($"{PlayerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw! Try again");
            }


        }
    }
}
