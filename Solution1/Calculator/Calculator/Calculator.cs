using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            String Num1, Num2;
            float num1, num2, sum = 0;
            String symbol;
            bool x = true;
            Console.WriteLine("Welcome to the easy calculator!");
            Console.WriteLine("Please input the first number:");
            Num1 = Console.ReadLine();
            Console.WriteLine("Please input the second number:");
            Num2 = Console.ReadLine();
            Console.WriteLine("Now tell me how you want to calculate the two numbers(+,-,/,*):");
            symbol = Console.ReadLine();
            num1 = float.Parse(Num1);
            num2 = float.Parse(Num2);
            while(x){
                if (symbol == "+")
                {
                    sum = num1 + num2;
                }
                else if (symbol == "-")
                {
                    sum = num1 - num2;
                }
                else if (symbol == "/")
                {
                    sum = num1 / num2;
                }
                else if (symbol == "*")
                {
                    sum = num1 * num2;
                }
                else
                {
                    Console.WriteLine("You input the incorrect symbol,please try again.");
                    continue;
                }
                Console.WriteLine(sum.ToString());
                x = false;
                Console.ReadKey();
            }
        }
    }
}
