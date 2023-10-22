using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int evenSum = 0;
            int oddSum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            return evenSum - oddSum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int minLength = Math.Min(Math.Min(Math.Min(str1.Length, str2.Length), str3.Length), str4.Length);
            return minLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return Math.Min(Math.Min(Math.Min(number1, number2), number3), number4);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3) && (sideLength1 + sideLength3 > sideLength2) && (sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            double number; 

            if (double.TryParse(input, out number))
            {               
                return true;
            }
         
            return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(obj => obj == null);
            int nonNullCount = objs.Length - nullCount;

            return nullCount > nonNullCount;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int evenSum = 0;
            int evenCount = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenSum += number;
                    evenCount++;
                }
            }

            if (evenCount == 0)
            {
                return 0;
            }

            return (double)evenSum / evenCount;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Factorial is not defined for negative numbers.");
            }

            if (number == 0)
            {
                return 1;
            }

            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
