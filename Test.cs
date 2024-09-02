using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Test
    {
        public Test() { }
        public string ReverseString(string input)
        {
            string ReverseString = "";
            for (int i = 0; i < input.Length; i++)
            {
                ReverseString += input[input.Length - (i + 1)];
            }
            return ReverseString;
        }
        public bool EsPrimo(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        public List<(int, int)> SumaDePares(int[] numbers, int targetSum)
        {
            var pairs = new List<(int, int)>();
            var seenNumbers = new HashSet<int>();

            foreach (var number in numbers)
            {
                int complement = targetSum - number;
                if (seenNumbers.Contains(complement))
                {
                    pairs.Add((complement, number));
                }
                seenNumbers.Add(number);
            }

            return pairs;
        }
        public int[] OrdenarArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
            return arr;
        }
        public bool EsPalindromo(string word)
        {
            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        public int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        public int Fibonacci(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            Console.Write(n);
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
        public int Mayor(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("El array no debe estar vacío");
            }

            int max = numbers[0];

            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }
        public int[] InvertirArray(int[] numbers)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int temp = numbers[left];
                numbers[left] = numbers[right];
                numbers[right] = temp;

                left++;
                right--;
            }
            return numbers;
        }
        public int ContarVocales(string input)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";

            foreach (char c in input)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
