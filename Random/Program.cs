using System;

namespace RandomExample
{
    internal class Program
    {

        
        static void Main(string[] args)
        {
            //dice
            Random dice = new Random();
            int numEyes;

            for(int i = 0; i < 10; i++)
            {
                numEyes = dice.Next(1,7);
                Console.Write(numEyes +" ");
            }

            //fortune teller
            Console.WriteLine("\nAsk your question");
            string question = Console.ReadLine();

            string[] answers = new string[] { "Yes", "No", "Maybe", };

            Random random = new Random();
            string randomAnswer = answers[random.Next(0, 3)];

            Console.WriteLine($"Your question was: {question}.\n");
            Console.WriteLine($"The answer is: {randomAnswer}");
            Console.ReadLine();
        }
        
    }
}
