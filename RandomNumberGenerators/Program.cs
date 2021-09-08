using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int MyRandomNumber1 = rnd.Next(1, 11);


            //programm genereerib juhuslikku numbrit 1-10
            //programm kontrollib, kas genereeritud number on suurem, kui 5
            //kui number on suurem, kui 5, siis konsool kuvab
            //*juhuslik number on {MyRandomNumber}, see on suurem,
            //kui 5*;
            //kui juhuslik number on väiksem siis konsool kuvab "juhuslik on on väiksem kui 5"
            //kui number on 5 siis konsool kuvab "juhuslik number on 5

            if (MyRandomNumber1 < 5)
            {
                Console.WriteLine($"Mängija 1 juhuslik number on {MyRandomNumber1}, see on väiksem kui 5");
            }
            else if (MyRandomNumber1 > 5)
            {
                Console.WriteLine($"Mängija 1 juhuslik number on {MyRandomNumber1}, see on suurem kui 5");
            }
            else
            {
                Console.WriteLine("Mängija 1 juhuslik number on 5");
            }
            

            



        }
    }
}
