using System;
namespace ProjectEuler
{
	public static class Problem2
	{
		public static void Solution()
		{
            int limit = 4000000;
            int sum = 0;
            int prev = 1;
            int current = 2;

            while (current <= limit)
            {
                if (current % 2 == 0)
                {
                    sum += current;
                }

                int next = prev + current;
                prev = current;
                current = next;
            }

            Console.WriteLine($"The sum of the even-valued terms in the Fibonacci sequence not exceeding 4 million is: {sum}");
        }
	}
}

