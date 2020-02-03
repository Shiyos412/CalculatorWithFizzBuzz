using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. FizzBuzz\n2. Four Function Calculator");
                Console.WriteLine("Type a number or type quit to leave\n");
                string input = Console.ReadLine();
                if (input == "quit")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                else if (input == "1")
                {
                    //Comments
                    Console.WriteLine("Type in number(s) you want to check against\n");
                    string temp = Console.ReadLine();
                    string[] values = temp.Split(' ');
                    List<double?> numValues = new List<double?>();
                    foreach(string a in values)
                    {
                        if(Double.TryParse(a,out double b)  == true)
                        {
                            numValues.Add(Double.Parse(a));
                        }
                        else
                        {
                            Console.WriteLine($"{a} is not a valid input\n");
                        }
                    }
                    //Comments
                    Console.WriteLine("Type in two numbers to FizzBuzz your values");
                    temp = Console.ReadLine();
                    string[] values2 = temp.Split(' ');
                    List<double?> numChecks = new List<double?>();
                    foreach(string a in values2)
                    {
                        if (Double.TryParse(a, out double b) == true)
                        {
                            numChecks.Add(Double.Parse(a));
                        }
                        else
                        {
                            Console.WriteLine($"{a} is not a valid input\n");
                        }
                    }
                    var FizzBuzzed = FizzBuzz.IsFizzBuzz(numChecks, numValues);
                    Console.WriteLine("The results are: \n");
                    foreach(string a in FizzBuzzed)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine();

                }
                else if (input == "2")
                {
                    Console.WriteLine("goodbye\n");
                }
                else
                {
                    Console.WriteLine("Invalid Input\n");
                }
            }
        }
    }
}
