using System;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Is it prime?
            //Enter the number...
            int number = 13;
            if (IsPrimeNumber(number))
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", number);
            }

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    break;
                }
                else
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
