using System;
namespace ProjectEuler
{
	public static class Problem4
	{
		public static void Solution()
		{
            int largestPalindrome = FindLargestPalindromeProduct();

            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is: {largestPalindrome}");
        }

        static int FindLargestPalindromeProduct()
        {
            int largestPalindrome = 0;

            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    int product = i * j;

                    if (IsPalindrome(product) && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            return largestPalindrome;
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int left = 0;
            int right = numberString.Length - 1;

            while (left < right)
            {
                if (numberString[left] != numberString[right])
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}

