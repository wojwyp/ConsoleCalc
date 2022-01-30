using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jaką operację chcesz wykonąć? Możliwe operaje to: '+', '-', '/', '*'.");
            var action = Console.ReadLine();

            Console.WriteLine("Podaj pierwszą liczbę:");
            var number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę:");
            var number2 = int.Parse(Console.ReadLine());

            var result = 0;

            switch (action)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację!");
            }

            Console.WriteLine("Wynik Twojego działania to: " + result);
        }
       
    }
}
