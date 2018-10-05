using RomanNumerals.Classes;
using System;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertNumber convertNumber = new ConvertNumber();
            string userInput = string.Empty;

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Bem-vindo ao programa conversor de números decimais para números romanos.");
            Console.WriteLine("Os valores permitidos pelo sistema são entre 1 e 3000.");
            Console.WriteLine("--------------------------------------------------------------------------");

            try
            {
                while (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("");
                    Console.Write("Informe o número decimal a ser convertido: ");
                    userInput = Console.ReadLine();

                    int value = 0;

                    if (int.TryParse(userInput, out value))
                    {
                        Console.WriteLine("Resultado: " + convertNumber.IntToRomanNumeral(value));
                    }
                    else
                    {
                        Console.WriteLine("Valor incorreto, os valores permitidos pelo sistema são entre 1 e 3000.");
                        userInput = string.Empty;
                    }
                }

                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("Pressione qualquer tecla para fechar");
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.ReadKey();

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
