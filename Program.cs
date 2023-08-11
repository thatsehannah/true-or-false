using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            string[] questions = { "LeBron James has 4 championship rings.", "Inglewood and Los Angeles are two different cities in California.", "Barack Obama only served as president for one term.", "Intermittent fasting is a great way to gain weight.", "Meta owns Facebook and Instagram." };
            bool[] answers = { true, true, false, false, true };
            bool[] responses = new bool[answers.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("WARNING: the length of the questions array and the length of the answers array are NOT equal");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.Write("True or False? ");
                input = Console.ReadLine();

                isBool = Boolean.TryParse(input, out inputBool);

                while(!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            int scoringIndex = 0;
            int score = 0;
            foreach (bool answer in answers)
            {
                bool response = responses[scoringIndex];
                Console.WriteLine($"{scoringIndex + 1}. Input: {response} | Answer: {answer}");

                if (response == answer)
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }
    }
}
