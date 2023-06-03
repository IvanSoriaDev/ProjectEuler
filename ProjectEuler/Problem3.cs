using System;
namespace ProjectEuler
{
	public static class Problem3
	{
		public static void Solution()
		{
            long number = 600851475143;
            long largestPrimeFactor = FindLargestPrimeFactor(number);

            Console.WriteLine($"The largest prime factor of {number} is: {largestPrimeFactor}");
        }

        static long FindLargestPrimeFactor(long number)
        {
            long largestFactor = 1;

            // Divide the number by 2 repeatedly until it is no longer divisible by 2
            while (number % 2 == 0)
            {
                largestFactor = 2;
                number /= 2;
            }

            // Check for odd prime factors
            for (long i = 3; i <= Math.Sqrt(number); i += 2)
            {
                while (number % i == 0)
                {
                    largestFactor = i;
                    number /= i;
                }
            }

            // Handle the case where the remaining number itself is a prime factor
            if (number > 2)
            {
                largestFactor = number;
            }

            return largestFactor;
        }
    }
}

