using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OperacaoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escolha um segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Agora escolha uma operação para ser realizada com esses dois números: ");
            String simb = Console.ReadLine().ToUpper();

            switch(simb)
            {
                case "+":
                    double res1 = num1 + num2;
                    Console.WriteLine("o resultado é: " + res1);
                    break;

                case "-":
                    double res2 = num1 - num2;
                    Console.WriteLine("o resultado é: " + res2);
                    break;

                case "*":
                    double res3 = num1 * num2;
                    Console.WriteLine("o resultado é: " + res3);
                    break;

                case "/":
                    double res4 = num1 / num2;
                    Console.WriteLine("o resultado é: "+ res4);
                    break;

                default: 
                    Console.WriteLine("opção inválida");
                    break;


            }

            Console.ReadKey();


            }




        }
    }

