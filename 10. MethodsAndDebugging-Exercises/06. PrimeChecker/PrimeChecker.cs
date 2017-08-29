using System;

namespace _06.PrimeChecker
{
    public class PrimeChecker
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            bool isPrime = CheckPrimeNumber(num);

            Console.WriteLine(isPrime);
        }

        public static bool CheckPrimeNumber(long num)
        {
            bool isPrime = false;
            if (num < 2)
            {
                isPrime = false;
            }
            else
            {
                isPrime = true;
                for (long i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            return isPrime;
        }
    }
}
