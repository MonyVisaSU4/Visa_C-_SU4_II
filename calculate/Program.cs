using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            double sum, subtract, mutiple, divide, choose;
            double a, b;
            Console.WriteLine("-------Calculate---------");
            Console.WriteLine("1.Sum");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multipl");
            Console.WriteLine("4.Divide");
            Console.WriteLine("5.Exite");
            Console.WriteLine("-------------------------");
            Console.Write("Please choose:");
            choose = double.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("--------SUM---------");
                    Console.Write("a=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    sum = a + b;

                    Console.WriteLine("Total=" + sum);
                    break;

                case 2:
                    Console.WriteLine("--------Subtract---------");
                    Console.Write("a=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    subtract = a - b;
                    Console.WriteLine("Total=" + subtract);
                    break;
                case 3:
                    Console.WriteLine("--------Multipl---------");
                    Console.Write("a=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    mutiple = a * b;
                    Console.WriteLine("Total=" + mutiple);
                    break;
                case 4:
                    Console.WriteLine("--------Divide---------");
                    Console.Write("a=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    divide = a / b;
                    Console.WriteLine("Total=" + divide);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            goto start;

        }
    }
}
