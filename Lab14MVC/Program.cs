using System;

namespace Lab14MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            CountryController cc = new CountryController();
            Console.WriteLine("\tWelcome to the Country app");
            while (loop)
            {
                cc.WelcomeAction();
           
                Console.WriteLine("Would you like to learn about another country? y/n");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "y")
                {
                    loop = true;
                }
                if (answer == "n")
                {
                    Console.WriteLine("Goodbye!");
                    Environment.Exit(0);
                }
                else
                {
                    loop = true;
                }
            }
        }
    }
}
