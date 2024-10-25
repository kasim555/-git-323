using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace канкулятор_сумма_и_вычиьтание
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Ввод первого числа
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                // Ввод второго числа
                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                // Сложение
                double sum = num1 + num2;
                Console.WriteLine($"Сумма: {num1} + {num2} = {sum}");

            double min = num1 - num2;
            Console.WriteLine($"Сумма: {num1} - {num2} = {min}");

            Console.ReadLine();
           ;
        }
    }
}
