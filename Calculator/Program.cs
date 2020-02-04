using System;
using System.Collections.Generic;
using System.Linq;



/*
*   Michael Cerase 02/03/2020
*   Basic Calculator app with FizzBuzz functionality
*   App has a basic main menu that branches off into functionality of both classes Calculator and FizzBuzz
*   TODO in main: 
*   Notes(2/3/20):
*   1.Throughout the calculator switch cases, I reused variable names and iterated them by 1, this may be more difficult to read then utilizing
*   unique names, however for now that was the simplest way to handle the usage of multiple variables in such short space
*   2.The text goes very fast in the console, not sure if there is a way to delay?
*   3.Calculator will let you return to menu easily, FizzBuzz is less consistent, should find a way to more consistently offer a way to return
*   to menu
*   4. Both of the classes could easily be static, still deciding if I want to change that, will be in a future commit.
*/
namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. FizzBuzz\n2. Four Function Calculator\n3. Quit");
                Console.WriteLine("Type a number\n");
                string input = Console.ReadLine();
                if (input.ToLower() == "3")
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
                
                //FIZZBUZZ Functionality
                else if (input == "1")
                {
                    
                    //Checks input for either numbers or "quit"
                    Console.WriteLine("Type in number(s) you want to check against or quit to exit\n");
                    string temp = Console.ReadLine();
                    if(temp == "quit") //if quit, exit program, however realistically I only want to allow quit from main menu, but have not found a decent way to return to menu from this point TODO
                    {
                        Console.WriteLine("Goodbye");
                        break;
                    }
                    string[] values = temp.Split(' '); //Create string array of the numbers, the decimals still exist at this point if they were entered however parse breaks this
                    List<long?> numValues = new List<long?>(); //Might be overcomplicated to require 3 different variables to convert string to long
                    foreach(string a in values)
                    {
                        if(long.TryParse(a,out long b)  == true) //parses a long with tryparse and adds it to the list if valid, does not work with decimals dissapointingly
                        {
                            numValues.Add(long.Parse(a));
                        }
                        else //if the program cannot parse a long it will input a 0 into the list and tell the user that the string it found is invalid
                        {
                            Console.WriteLine($"{a} is not a valid input\n");
                            numValues.Add(0);
                        }
                    }

                    //Values input
                    Console.WriteLine("Type in two numbers to FizzBuzz your values");
                    temp = Console.ReadLine();
                    string[] values2 = temp.Split(' ');
                    List<long?> numChecks = new List<long?>();
                    while (numChecks.Count <= 2)
                    {
                        foreach (string a in values2)
                        {
                            if (long.TryParse(a, out long b) == true)
                            {
                                numChecks.Add(long.Parse(a));
                            }
                            else
                            {
                                Console.WriteLine($"{a} is not a valid input, adding 1\n");
                                numChecks.Add(1);
                            }

                        }
                    }
                    //Calls FizzBuzz.IsFizzBuzz on the two lists
                    var FizzBuzzed = FizzBuzz.IsFizzBuzz(numChecks, numValues);
                    Console.WriteLine("The results are: \n");

                    //Writes the results
                    foreach(string a in FizzBuzzed)
                    {
                        Console.Write(a + " ");
                    }
                    Console.WriteLine("\n\n\n\n\n\n");

                }

                //Calculator Functionality
                else if (input == "2")
                {
                    /*For all four functions, I use the following syntax, same variable names iterated up by one each time
                    *Have not decided if the same names with different numbers is a weakpoint yet, therefore leaving extended notes here to
                    *explain functionality for Sum/Addition that applies to all four
                    *Asks user for input on what basic function to do
                    *includes an escape option to return to main menu
                    *The same (for the most part) syntax is used for all four functions
                    */
                    Console.WriteLine("What function?");
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide\n5.Return");
                    string s = Console.ReadLine();
                    switch (s)
                    {

                        //Add
                        case ("1"):
                            Console.WriteLine("What two or more numbers do you want to add?");
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

                        //Subtract
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

                        //Multiply
                        case ("3"):
                            Console.WriteLine("What two or more numbers do you want to multiply?");
                            string temp3 = Console.ReadLine();
                            string[] nums3 = temp3.Split(' ');
                            List<long> convertNums3 = new List<long>();
                            foreach(string a in nums3)
                            {
                                if(long.TryParse(a, out long b) == true)
                                {
                                    convertNums3.Add(long.Parse(a));
                                }
                                else
                                {
                                    Console.WriteLine($"{a} is invalid input");
                                }
                            }
                            long result3 = Calculator.Product(convertNums3.ToArray());
                            Console.WriteLine($"The product of your numbers is: {result3}\n");
                            break;

                        //Divide with Remainder
                        case ("4"):
                            Console.WriteLine("What two numbers do you want to divide?");
                            string temp4 = Console.ReadLine();
                            string[] nums4 = temp4.Split(' ');
                            List<long> convertNums4 = new List<long>();
                            foreach (string a in nums4)
                            {
                                if (long.TryParse(a, out long b) == true)
                                {
                                    convertNums4.Add(long.Parse(a));
                                }
                                else
                                {
                                    Console.WriteLine($"{a} is invalid input");
                                }
                            }
                            Console.WriteLine($"The quotient is " + Calculator.Division(convertNums4[0], convertNums4[1]));
                            break;

                        //Return to menu
                        case ("5"):
                            Console.WriteLine("Returning to main menu");
                            break;

                        //Invalid input returns them to menu as well
                        default:
                            Console.WriteLine("Invalid input, returning to menu");
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
