using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Input from Console
            Console.Write("Enter value to show prime number : ");
            int InputVal = int.Parse(Console.ReadLine());
            bool PrimeYes;
            for (int primeloop = 2; primeloop <= InputVal; primeloop++)
            {
                PrimeYes = true;
                for (int divvalues = 2; divvalues <= (primeloop / 2); divvalues++)
                {
                    if (primeloop % divvalues == 0)
                    {
                        PrimeYes = false;
                        break;
                    }
                }
                if (PrimeYes)
                {
                    //Print prime number
                    Console.WriteLine(primeloop);
                }
            }
            // Tohold screen
            Console.ReadKey();
        }
    }
}
