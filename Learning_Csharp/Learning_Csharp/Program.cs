using System;

namespace MeuPrimeiroProjetoCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello, what's your name?");
                string nome = Console.ReadLine();

                Console.WriteLine($"Hi, {nome}! Welcome to my first project.");

                Console.WriteLine("How old are you?");
                int idade;

                while (true)
                {
                    string idadeInput = Console.ReadLine();
                    if (Int32.TryParse(idadeInput, out idade))
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age:");
                    }
                }

                if (idade < 18)
                {
                    Console.WriteLine("You are underage.");
                }
                else
                {
                    Console.WriteLine("You are of legal age.");
                }

                Console.WriteLine("Do you want to continue? (y/n)");
                string continueInput = Console.ReadLine();

                if (continueInput.ToLower() != "y")
                {
                    break;
                }
            }
        }
    }
}
