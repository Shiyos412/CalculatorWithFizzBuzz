using System;
namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
        }

        //Basic Addition/Summation - Array
        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int a in arr)
            {
                sum += a;
            }
            return sum;
        }

        //Product of inputs - Array
        public static int Product(params int[] arr)
        {
            int product = 1;
            foreach (int a in arr)
            {
                product *= a;
            }
            return product;
        }


        //Subtraction - 2 numbers
        public double Sub(double a, double b)
        {
            return a - b;
        }


        //Division - 2 numbers
        public string Division(double a, double b)
        {
            double c = a / b;
            double r = a % b;
            if(r == 0)
            {
                return $"{c}";
            }
            return $"{c} Remainder of {r}";
        }



        
    }
}
