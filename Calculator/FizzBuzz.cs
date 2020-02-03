using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public class FizzBuzz
    {
        //TODO - Comments
        //private List<long> checks;
        //public List<long> nums;
        public FizzBuzz()
        {
            
        }

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
