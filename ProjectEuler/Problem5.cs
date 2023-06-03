using System;
namespace ProjectEuler
{
	public static class Problem5
	{
		public static void Solution()
		{
            int result = FindSmallestDivisible(20);
            Console.WriteLine($"The smallest positive number divisible by all numbers from 1 to 20 is: {result}");
        }

        // Function to calculate the LCM of two numbers
        public static int CalculateLCM(int a, int b)
        {
            // Calculate the greatest common divisor (GCD) using Euclid's algorithm
            int gcd = CalculateGCD(a, b);

            // LCM formula: LCM(a, b) = (a * b) / GCD(a, b)
            return (a * b) / gcd;
        }

        // Function to calculate the GCD of two numbers
        public static int CalculateGCD(int a, int b)
        {
            if (b == 0)
                return a;

            return CalculateGCD(b, a % b);
        }

        // Function to find the smallest positive number divisible by all numbers from 1 to n
        public static int FindSmallestDivisible(int n)
        {
            int lcm = 1;

            // Calculate the LCM iteratively for each number from 1 to n
            for (int i = 1; i <= n; i++)
            {
                lcm = CalculateLCM(lcm, i);
            }

            return lcm;
        }
    }
}

