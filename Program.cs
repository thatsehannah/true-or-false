using System;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string? entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            string[] questions = { "LeBron James has 4 championship rings.", "Inglewood and Los Angeles are two different cities in California.", "Barack Obama only served as president for one term.", "Intermittent fasting is a great way to gain weight.", "Meta owns Facebook and Instagram." };
            bool[] answers = { true, true, false, false, true };

            RunQuiz(questions, answers);
        }

        static void RunQuiz(string[] questions, bool[] answers)
        {
            bool[] responses = AskQuestions(questions);
            int score = ScoreResponses(answers, responses);

            Console.WriteLine($"You got {score} out of {questions.Length} correct!");
        }

        static bool[] AskQuestions(string[] questions)
        {
            bool[] responses = new bool[questions.Length];

            int askingIndex = 0;
            foreach (string question in questions)
            {
                string? input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(question);
                Console.Write("True or False? ");
                input = Console.ReadLine();

                isBool = bool.TryParse(input, out inputBool);

                while (!isBool)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = bool.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            return responses;
        }

        static int ScoreResponses(bool[] answers, bool[] responses)
        {
            int score = 0;
            int scoringIndex = 0;

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

            return score;
        }
    }
}
