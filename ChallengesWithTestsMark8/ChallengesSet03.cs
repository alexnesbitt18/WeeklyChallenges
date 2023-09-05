﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach(var item in vals)
            {
                if(item == false)
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isDigit = false;
            bool isLetter = false;
            bool isUpper = false;

            foreach (var letter in password)
            {
                if (char.IsLower(letter))
                {
                    isLetter = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper = true;
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                }
            }
            return isUpper && isDigit && isLetter;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[(int)val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] myArray = new int[50];
            int index = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    myArray[index] = i;
                    index ++;
                }
            }
            return myArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i  = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
