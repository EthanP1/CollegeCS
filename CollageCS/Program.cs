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
            Console.WriteLine("Give me two numbers between 0 - 255");
            Console.WriteLine("Give me the first number: ");
            byte bNum1 = Convert.ToByte (Console.ReadLine());
            Console.WriteLine("Give me the second number: ");
            byte bNum2 = Convert.ToByte (Console.ReadLine());
            Console.WriteLine(bNum1);
            Console.WriteLine(bNum2);

            Console.ReadKey();
        }
    }
}
