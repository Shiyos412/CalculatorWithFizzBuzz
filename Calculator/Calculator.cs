using System;


/*
 * Calculator class with 4 basic functionality as of 2/3/20
 * TODO:
 * 1. Add SQRT and Pow functionality
 * 2. potentially add some geometric calculations
 * 3. clean up methods
 * Notes (2/3/20):
 * 1. Very similar to math, however Sum is Math.Add + a potential summation of a list of longs, therefore a little added functionality beyond
 * a + b, same situation with Product
 * 2. Subtract and Division are limited to two numbers, I wasn't sure if being able to sub or div multiply numbers would be a good idea
 * 3. Does not handle decimals due to parsing in main, could replace parse with a better way to get the numeric value (ie: Char.GetNumericValue)
 * however, this would require changing the string arrays to char arrays but numbers w/ more then one digit would become difficult to parse
 * Need to look further into possible decimal implementation (decimal.parse does not catch decimals, it rounds all numbers down automatically)
 */
namespace Calculator
{
    //Left class as non static however it could be static and there would be no realistic difference, its similar to the Math class in system
    //Left as non static for potential reasons in the future(?) may change
    public class Calculator
    {

        //Basic Addition/Summation - Array
        public static long Sum(params long[] arr)
        {
            int sum = 0;
            foreach (int a in arr)
            {
                sum += a;
            }
            return sum;
        }

        //Product of inputs - Array
        public static long Product(params long[] arr)
        {
            int product = 1;
            foreach (int a in arr)
            {
                product *= a;
            }
            return product;
        }


        //Subtraction - 2 numbers
        public static long Sub(long a, long b)
        {
            return a - b;
        }


        //Division - 2 numbers
        public static string Division(long a, long b)
        {
            long c = a / b;
            long r = a % b;
            if(r == 0)
            {
                return $"{c}";
            }
            return $"{c} Remainder of {r}";
        }

        //SQRT
        //POW
        //Area of circle?
        //Area of polygon with n sides?

        
    }
}
