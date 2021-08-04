using System;

namespace Fibonacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci series");

            int temp = 0;
            int number = 1;
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(temp);
                int addedNumber =number + temp;
                temp = number;
                number = addedNumber;
                addedNumber = temp;
                
            }
        }
    }
}
