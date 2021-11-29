using System;

namespace switch_case_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var response = Console.ReadLine();
            switch (response)
            {
                case "math":
                    Console.WriteLine($"Math is cool!");
                    break;
                case "english":
                    Console.WriteLine($"Thats ok, but i dont like to read");
                    break;
                case "science":
                    Console.WriteLine($"Science is alot of memorization and studying!");
                    break;
                case "spanish":
                    Console.WriteLine($"I dont know anything about that i took French");
                    break;
                case "history":
                    Console.WriteLine($"History is just stories of the past!");
                    break;
                default:
                    Console.WriteLine($"Thats interesting i havnt heard of that on yet! Whats that the study of?");
                    break;

            }
        }
    }
}
