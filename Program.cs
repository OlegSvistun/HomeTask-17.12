using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char operation;
            int result = 0;
            Console.WriteLine("Введіть перше число:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть математичну дію (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ділення на нуль неможливе.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Невірна математична дія.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Введіть перше число:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть математичну дію (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ділення на нуль неможливе.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Невірна математична дія.");
                    return;
            }

            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Введіть перше число:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введіть математичну дію (+, -, *, /):");
            operation = Convert.ToChar(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ділення на нуль неможливе.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Невірна математична дія.");
                    return;
            }
            Console.WriteLine($"Результат: {result}");
        }
    }
}
