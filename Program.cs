using System;
using System.Linq;
using System.Collections.Generic;

namespace MagicMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> expressions = new List<string>()
            {
                "As I see it, yes.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again."
            };

            Console.Write("Enter a question: ");
            string question = Console.ReadLine();
            Random r = new Random();

            Console.WriteLine(expressions[r.Next(0, 5)]);
        }
    }
}
