using System;

namespace Uppgift_3_1Jakub

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string ålder = Console.ReadLine();
            int åldernmr = int.Parse(ålder);

            if (åldernmr > 19)
            {
                Console.WriteLine("Du är för gammal för att delta i tävlingen.");
            }
            if (åldernmr < 16)
            {
                Console.WriteLine("Du är för ung för att delta i tävlingen.");
            }
            else if (åldernmr >= 16 && åldernmr <= 19)
            {
                Console.WriteLine("Du kan delta i tävlingen!");
            }
        }
    }

}