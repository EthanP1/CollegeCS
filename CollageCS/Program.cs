using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollageCS
{
    class Program
    {
        static void Main(string[] args)
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
            byte bSel = Convert.ToByte(Console.ReadLine());
            switch (bSel)
            {
                case 1:
                    Rocket();

                    break;
                case 2:
                    Car();
                    break;
                default:
                    Console.WriteLine("Hmm, that's not right);
                    break;
            }
            Console.ReadKey();

        }
        public void Rocket()
        {
            Console.WriteLine("\n\n\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("\n  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("  *\n ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****\n ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("  *\n ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine(" ***\n*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("*****");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
        }
    public void Car()
        {
            Console.Write("Car go Brr");
            int i = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(i);
                Console.Write("r");
                i++;
                if (i > 100)
                {
                i = 0;
                }
}
        }
    }
}
