public class guessingGame
{
    public static void Main()
    {
        int answer;
        int guess;
        bool rightGuess = false;

        do
        {
            Console.Write("User 1, enter a number between 0 and 100: ");
        }
        while (!int.TryParse(Console.ReadLine(), out answer) || answer > 100 || answer < 0);
        Console.Clear();

        Console.WriteLine("User 2, guess the number");
        do
        {
            Console.Write("What is your next guess? ");
            int.TryParse(Console.ReadLine(), out guess);
            if (guess - answer > 0)
                Console.WriteLine($"{guess} is too big.");
            else if (guess - answer < 0)
                Console.WriteLine($"{guess} is too small.");
            else if (guess - answer == 0)
            {
                Console.WriteLine("You guessed the number!");
                rightGuess = true;
                break;
            }

        }
        while (rightGuess == false);

    }
}
