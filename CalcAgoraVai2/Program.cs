using System;
using System.Globalization;


namespace CalculadoraNaoni {
    class Program {

        static void Main(string[] args) {

            Console.WriteLine("-- Bem Vindo a Calculadora Padawan Naoni! -- ");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Insira seus dados no seguinte formato: ");
            Console.WriteLine("    número     operador     número     ");
            Console.WriteLine();
            Console.WriteLine("Se quiser parar a execução digite SAIR");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------");

            Boolean sair = false;
            //var expressao = string.Empty;


            while (!sair) {
                try {
                    string expressao = Console.ReadLine();





                    if (expressao == "SAIR") {
                        sair = true;
                    }
                    else {

                        double resultado = Calculadora.Calcular(expressao);
                        Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                    }
                }
                catch (FormatException) {
                    Console.WriteLine("Entrada invalida, por favor tente novamente");
                }
            }
        }
    }
    }