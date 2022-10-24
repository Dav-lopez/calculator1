using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;
            float result;
            bool inputError = false;
            string ops;

            do
            {
                try
                {
                    Console.WriteLine("pick your frist number");
                    num1 = float.Parse(Console.ReadLine());
                    inputError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine( "write correct input type");
                    inputError = true;
                }

            } while (inputError);
            do
            {
                try
                {
                    Console.WriteLine("pick your second number");
                    num2 = float.Parse(Console.ReadLine());
                    inputError = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("write correct input type");
                    inputError = true;
                }

            } while (inputError);


            /*Console.WriteLine("pick your operator: (+, -,*, /");
            ops = Console.ReadLine();*/

            /*if (ops == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result);

            }
            else if (ops == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result);
            }
            else if (ops == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result);
            }
            else if (ops == "/")
            {
                result = num1 / num2;
                Console.WriteLine(result);
            }
            else
            {
                throw new Exception("an error occured, check operator or number type");
            };*/

            Console.WriteLine("chose on of these options to perform an operation");
            Console.WriteLine("\t\t\t a - Add");
            Console.WriteLine("\t\t\t s - subtract");
            Console.WriteLine("\t\t\t d - Divide");
            Console.WriteLine("\t\t\t m - Mutiply");
            Console.WriteLine("\n");
            Console.WriteLine("your option");


            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2) );
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "d":
                    while (num2 == 0)
                    {
                        Console.WriteLine("cant divide by 0");
                        Console.WriteLine("Pick another number");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
                    /*if (num2 == 0)
                    {
                        Console.WriteLine("cant divide by 0");
                    }
                    else
                    {
                        num2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                        
                    }*/
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
            }

            Console.ReadKey();
        }
    }
}
