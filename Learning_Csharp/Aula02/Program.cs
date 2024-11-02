using System;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Hello, what's your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}! Welcome to my first project.");

            Console.WriteLine("How old are you?");
            int yearsOld;

            while (true)
            {
                string yearsOldInput = Console.ReadLine();
                if (Int32.TryParse(yearsOldInput, out yearsOld))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid age:");
                }
            }

            if (yearsOld < 18)
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
