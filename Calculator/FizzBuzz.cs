using System;
using System.Collections.Generic;
using System.Linq;


/*
 * FizzBuzz class for checking through arrays of longs parsed through user input in main
 * TODO:
 * 1. Comment out
 * 2. expand functionality
 * Notes(2/3/20):
 * 1. Checks two numbers, could add more to check for n digits, would have to limit amount?
 * 2. Could offer an explanation of what a fizzbuzz is in Main, as it seems to be something realistically only common to CS people.
 * 3. Brainstorming on other ways to expand this, but may need to redo main if I add further functionality, most likely just doing
 * something similar to calculator where it offers a menu list to enter a number to choose what they want to do.
 * 
 */
namespace Calculations
{
    //Left the class as non static for potential future implementation that could require instantiation? May change later
    public class FizzBuzz
    {
        //TODO - Comments
        //private List<long> checks; -- unecessary storage of checks and nums from main, did not end up needing
        //public List<long> nums;
        

        public static List<string> IsFizzBuzz(List<long?> checks, List<long?> nums)
        {
            List<string> end = new List<string>();


            foreach (long? a in nums)
            {
                string result = "";

                if (a == null)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (a % checks[0] == 0)
                {
                    result += "Fizz";
                }

                if(a % checks[1] == 0)
                {
                    result += "Buzz";
                }

                if(result == "")
                {
                    end.Add(a.ToString());
                }

                else
                {
                    end.Add(result);
                } 
            }
            return end;
        }

    }
}
