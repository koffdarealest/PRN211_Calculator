using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {   
        static int getOperation()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Choose your operation (+, -, *, /):");
                    Console.WriteLine("1. +");
                    Console.WriteLine("2. -");
                    Console.WriteLine("3. *");
                    Console.WriteLine("4. /");
                    Console.Write("Your choice: ");
                    int n = int.Parse(Console.ReadLine());
                    if(0 < n && n <= 4)
                    {
                        return n;
                    }
                }catch (Exception e)
                {
                    Console.WriteLine("Invalid choice! Please choose again!");
                }
            }
        }

        static double enterInput(int ord)
        {
            while(true)
            {
                try
                {
                    Console.Write("Enter number " + ord + ":");
                    double n = double.Parse(Console.ReadLine());
                    return n;
                }catch (Exception e)
                {
                    Console.WriteLine("Invalid Number! Enter again!");
                }
            }
        }

        static double calculator(double x, double y, int ope)
        {
            double result = 0;
            if (ope == 1)
            {
                result = x + y;         
            }

            if (ope == 2)
            {
                result = x - y;
            }

            if (ope == 3)
            {
                result = x * y;
            }

            if (ope == 4)
            {
                result = x / y;
            }

            return result;

        }
        static void Main(string[] args)
        {
            double x = enterInput(1);
            double y = enterInput(2);
            int ope = getOperation();
            double result = calculator(x, y, ope);
            Console.WriteLine($"Result: {result}" );
            Console.ReadLine();
        }
    }
}
