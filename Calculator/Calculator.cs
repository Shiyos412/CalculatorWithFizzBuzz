using System;
namespace Calculator
{
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



        
    }
}
