using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
               return false;
            }

            int sum = numbers.Where(n => n % 2 != 0).Sum();
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return !string.IsNullOrEmpty(password) &&
           password.Any(char.IsUpper) &&
           password.Any(char.IsLower) &&
           password.Any(char.IsDigit);
        }

        public char GetFirstLetterOfString(string val)
        {
            if (!string.IsNullOrEmpty(val))
            {
                return val[0];
            }
            throw new ArgumentException("String is empty");
        }
    

        public char GetLastLetterOfString(string val)
        {
        if (!string.IsNullOrEmpty(val))
        {
            return val[^1]; 
        }
        throw new ArgumentException("String is empty");
    }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
        if (nums.Length < 2)
        {
            throw new ArgumentException("Array must have at least two elements.");
        }
        return nums[nums.Length - 1] - nums[0];
    }

        public int[] GetOddsBelow100()
        {
        return Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
    }

        public void ChangeAllElementsToUppercase(string[] words)
        {
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToUpper();
        }
    }
    }
}
