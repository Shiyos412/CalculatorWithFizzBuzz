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
                if (input.ToLower() == "quit")
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
                    List<long?> numValues = new List<long?>();
                    foreach(string a in values)
                    {
                        if(long.TryParse(a,out long b)  == true)
                        {
                            numValues.Add(long.Parse(a));
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
                    List<long?> numChecks = new List<long?>();
                    foreach(string a in values2)
                    {
                        if (long.TryParse(a, out long b) == true)
                        {
                            numChecks.Add(long.Parse(a));
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
                    Console.WriteLine("\n\n\n\n\n\n");

                }
                else if (input == "2")
                {
                    Console.WriteLine("What function?");
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide");
                    string s = Console.ReadLine();
                    switch (s)
                    {
                        case ("1"):
                            Console.WriteLine("What numbers do you want to add?");
                            string temp = Console.ReadLine();
                            string[] nums = temp.Split(' ');
                            List<long> convertNums = new List<long>();
                            foreach(string a in nums)
                            {
                                if(long.TryParse(a, out long b) == true)
                                {
                                    convertNums.Add(long.Parse(a));
                                }
                                else
                                {
                                    Console.WriteLine($"{a} is invalid input");
                                }
                            }
                            long result = Calculator.Sum(convertNums.ToArray());
                            Console.WriteLine($"The sum of your numbers is: {result}\n");
                            break;
                        case ("2"):
                            Console.WriteLine("What two numbers do you want to subtract?");
                            string temp2 = Console.ReadLine();
                            string[] nums2 = temp2.Split(' ');
                            List<long> convertNums2 = new List<long>();
                            foreach (string a in nums2)
                            {
                                if (long.TryParse(a, out long b) == true)
                                {
                                    convertNums2.Add(long.Parse(a));
                                }
                                else
                                {
                                    Console.WriteLine($"{a} is invalid input");
                                }
                            }
                            long result2 = Calculator.Sub(convertNums2[0], convertNums2[1]);
                            Console.WriteLine($"The difference of your numbers is: {result2}\n");
                            break;
                        case ("3"):
                            break;
                        case ("4"):
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input\n");
                }
            }
        }
    }
}
