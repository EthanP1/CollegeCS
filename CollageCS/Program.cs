using System;
using System.Threading;

namespace CollageCS
{
    internal static class Program
    {
        private static int i;

        private static void Main()
        {
            Console.Write("1 Projects\n2 Fun: ");
            var bSel = Convert.ToByte(Console.ReadLine());
            switch (bSel)
            {
                case 1:
                    Console.Write("\n\n1 Print Two Numbers\n2 Selection\n3 Switch\n4 Function procedure: ");
                    var bSel2 = Convert.ToByte(Console.ReadLine());
                    switch (bSel2)
                    {
                        case 1:
                            PrintTwoNum();
                            break;
                        case 2:
                            Selection();
                            break;
                        case 3:
                            Switchtest();
                            break;
                        case 4:
                            Console.Clear();
                            int iNum1 = 9;
                            int iNum2 = 10;
                            AddTwoNumbers(iNum1, iNum2);
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    Console.Write("1 Rocket\n2 Car: ");
                    var bSel3 = Convert.ToByte(Console.ReadLine());
                    switch (bSel3)
                    {
                        case 1:
                            Rocket();
                            break;
                        case 2:
                            Car();
                            break;
                        default:
                            Console.WriteLine("Something went wrong, try again with a number between 1-2");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Hmm, that's not right");
                    break;
            }
            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }

        private static void AddTwoNumbers(int iNum1, int iNum2)
        {
            int iAns;
            iAns = iNum1 + iNum2;
            Console.WriteLine("{0} + {1} = {2}", iNum1, iNum2, iAns);
        }

        private static void PrintTwoNum()
        {
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

            Console.Write("How much are you earning: £");
            uint iSal = Convert.ToUInt16(Console.ReadLine());
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
    }
}