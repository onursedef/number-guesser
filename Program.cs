using System;

namespace numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            while (true) {
                Random random = new Random();

                int correctNumber = random.Next(1, 20);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 20.");

                while (guess != correctNumber) {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess)) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please use an actual number.");
                        Console.ResetColor();

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber) {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong number, please try again.");
                        Console.ResetColor();
                    }

                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Corrent! You are awesome!");
                Console.ResetColor();

                Console.WriteLine();

                Console.WriteLine("Play Again? [Y / N]");

                string getAnswer = Console.ReadLine().ToUpper();

                if (getAnswer == "Y") {
                    continue;
                } else if (getAnswer == "N") {
                    return;
                } else {
                    return;
                }
            }
        }

        static void GetAppInfo() {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Onur Sedef (real author Brad Traversy)";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();   
        }
    }
}
