using System;
using System.Threading;

namespace CollageCS
{
    internal static class Program
    {
        private static void Main()
        {
            /*
            Console.WriteLine("Give me two numbers between 0 - 255");
            Console.Write("Give me the first number: ");
            byte bNum1 = Convert.ToByte (Console.ReadLine());
            Console.Write("Give me the second number: ");
            byte bNum2 = Convert.ToByte (Console.ReadLine());
            Console.WriteLine(bNum1);
            Console.WriteLine(bNum2);
            */
            Console.Write("1 for Rocket\n2 for Car: ");
            var bSel = Convert.ToByte(Console.ReadLine());
            switch (bSel)
            {
                case 1:
                    Rocket();
                    break;
                case 2:
                    Car();
                    break;
                default:
                    Console.WriteLine("Hmm, that's not right");
                    break;
            }
            Console.WriteLine("Press any key to exit: ");
            Console.ReadKey();
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