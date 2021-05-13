﻿using System;
using System.Threading;

namespace CollageCS
{
    internal static class Program
    {
        private static int i;
        private static void Main()
        {
            bool DevMode = true;
            bool Menu = true;
            if (DevMode == true)
            {
                Menu = false;
                Console.ForegroundColor = ConsoleColor.Green;
                Animation();
            }
            
            while (Menu == true)
            {
                Console.Write("1 Projects\n2 Fun: ");
                var bSel = Convert.ToByte(Console.ReadLine());

                switch (bSel)
                {
                    case 1:
                        Console.Write("\n\n1 Print Two Numbers\n2 Selection\n3 Switch\n4 Add two numbers\n5 Sub two numbers\n6 Interest Calculator: ");
                        var bSel2 = Convert.ToByte(Console.ReadLine());
                        switch (bSel2)
                        {
                            case 1:
                                //Print Two Numbers - 22/03/21
                                PrintTwoNum();
                                break;
                            case 2:
                                //Selection 01/04/21
                                Selection();
                                break;
                            case 3:
                                //Switch 21/04/21
                                Switchtest();
                                break;
                            case 4:
                                //Add Two Numbers - 29/04/21
                                Console.Clear();
                                int iNum1 = 9;
                                int iNum2 = 10;
                                AddTwoNumbers(ref iNum1, ref iNum2);
                                break;
                            case 5:
                                //Sub Two Numbers - 29/04/21
                                Console.Clear();
                                int iNum3 = 10;
                                int iNum4 = 9;
                                SubTwoNumbers(ref iNum3, ref iNum4);
                                break;
                            case 6:
                                //Interest Calculator - 06/05/21
                                Interest();
                                break;
                            default:
                                break;
                        }
                        string sSel1;
                        Console.Write("Would you like to run another project? y/n: ");
                        sSel1 = Console.ReadLine();
                        if (sSel1 == "y")
                        {
                            Menu = true;
                        }
                        else if(sSel1 == "n")
                        {
                            Menu = false;
                        }
                        else
                        {
                            Console.WriteLine("Sorry I was looking for a y/n...");
                            Menu = false;
                        }
                        break;
                    case 2:
                        Console.Write("1 Rocket\n2 Car\n3 Wave Animation: ");
                        var bSel3 = Convert.ToByte(Console.ReadLine());
                        switch (bSel3)
                        {
                            case 1:
                                //Rocket - 01/04/21
                                Rocket();
                                break;
                            case 2:
                                //Car - 24/03/21
                                Car();
                                break;
                            default:
                                Console.WriteLine("Something went wrong, try again with a number between 1-2");
                                break;
                        }
                        break;
                    case 3:
                        Animation();
                        break;
                    default:
                        Console.WriteLine("Hmm, that's not right");
                        break;
                }
            }
            
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
        }

        private static void Animation()
        {
            //string Animation = "Ne, ko";
            //string[] TheAnimation = Animation.Split(", ");
            //foreach (string Animatio in TheAnimation)
            //    Console.WriteLine(Animatio);
            string dot = ".";
            for (int i = 0; i < 10; i++)
            {
                int j = 0;
                while (j < 100)
                {
                    for (int k = 0; k < j; k++)
                    {
                        Console.Write(dot);
                    }
                    System.Threading.Thread.Sleep(10);
                    Console.WriteLine("\n");
                    j++;
                }
                while (j != 0)
                {
                    for (int l = 0; l < j; l++)
                    {
                        Console.Write(dot);
                    }
                    System.Threading.Thread.Sleep(10);
                    Console.WriteLine("\n");
                    j--;
                }
            }
        }

        private static void Interest()
        {
            Console.Clear();
            //Interest given by the user
            Console.Write("Please enter the interest rate you wish to calculate (e.g. 1.06 for 6%): ");
            double dIntRate = Convert.ToDouble(Console.ReadLine());
            //Amount given by the user
            Console.Write("Please enter your initial amount: £");
            double dAmount= Convert.ToDouble(Console.ReadLine());
            //Number of years they will be leaving the money in the bank
            Console.Write("Now enter the number of years you intend to leave it there: ");
            byte bNumOfYears = Convert.ToByte(Console.ReadLine());
            //Calculation
            for (int i = 0; i < bNumOfYears; i++)
            {
                dAmount = dAmount * dIntRate;
            }
            double truncated = Math.Truncate(dAmount * 100) / 100;

            Console.WriteLine("£" + truncated);
        }

        private static void SubTwoNumbers(ref int iNum3, ref int iNum4)
        {
            int iAns2;
            iAns2 = iNum3 - iNum4;
            Console.WriteLine("{0} - {1} = {2}", iNum3, iNum4, iAns2);
        }

        private static void AddTwoNumbers(ref int iNum1,ref int iNum2)
        {
            int iAns;
            iNum2 = 60;
            iAns = iNum1 + iNum2;
            Console.WriteLine("{0} + {1} = {2}", iNum1, iNum2, iAns);
        }

        private static void PrintTwoNum()
        {
            Console.Clear();
            Console.WriteLine("Give me two numbers between 0 - 255");
            Console.Write("Give me the first number: ");
            byte bNum1 = Convert.ToByte(Console.ReadLine());
            Console.Write("Give me the second number: ");
            byte bNum2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(bNum1);
            Console.WriteLine(bNum2);
        }

        private static void Switchtest()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            do
            {
                Console.WriteLine("testing", i);
                i++;
            }
            while (i <= 15);
            {
                Console.WriteLine("Fun", i);
            }
        }

        private static void Selection()
        {
            //Console.Write("What temerature is it: ");
            //byte temperature = Convert.ToByte(Console.ReadLine());


            //if (temperature >= 40)
            //{
            //    Console.WriteLine("hot");
            //}
            //else
            //{
            //    Console.WriteLine("cold");
            //}

            ushort iSal= 0;
            Console.Write("How much are you earning: £");
            ushort.TryParse(Console.ReadLine(), out iSal);

            
            Console.Write("and how long have you worked here: ");
            Byte bYears = Convert.ToByte(Console.ReadLine());
            if (iSal > 40000)
            {
                if (bYears >= 2)
                {
                    Console.WriteLine("\nCongrats! \nYour invited to the Christmas party!");
                }
                else
                {
                    Console.WriteLine("Thanks for the hard work!");
                }
            }
            else
            {
                Console.WriteLine("Keep up the good work!");
            }
        }

        private static void Rocket()
        {
            Console.WriteLine("\n\n\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("  *\n ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n*****");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****");
            Thread.Sleep(500);
            Console.Clear();
        }

        private static void Car()
        {
            Console.Write("Car go Brr");
            var i = 0;
            var k = 0;
            while (k < 4)
            {
                Thread.Sleep(i);
                Console.Write("r");
                i++;
                if (i > 100)
                {
                    i = 1;
                    k++;
                }
                {

                }
            }
        }
        public static string Truncate(this string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }
    }
}