using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranPostureGenerator = new Random();
            string randomPosture;
            string userInputPosture;

            int randomNumber;
            randomNumber = ranPostureGenerator.Next(0, 3);

            if (randomNumber == 0)
            {
                randomPosture = "r";
            }
            else if (randomNumber == 1)
            {
                randomPosture = "p";
            }
            else
            {
                randomPosture = "s";
            }

            Console.WriteLine("Please choose r(Rock), p(Paper) or s(Scissors): ");
            userInputPosture = Console.ReadLine().ToLower();

            if (randomPosture == userInputPosture)
            {
                Console.WriteLine("This is a tie.");
            }
            else if (randomPosture == "r" && userInputPosture == "p" || randomPosture == "p" && userInputPosture == "s" || randomPosture == "s" && userInputPosture == "r")
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.WriteLine($"User input posture is {userInputPosture} and the random posture is {randomPosture}.");

            Console.ReadKey();

        }
    }
}
