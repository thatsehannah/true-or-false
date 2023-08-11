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
        }
    }
}
