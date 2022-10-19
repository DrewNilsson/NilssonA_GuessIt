// Andrew Nilsson
// 09/15/2022
// Mini Challenge #8 - Guess It
// This is a console project that the user inputs the mode they want then guesses a random number
// Peer reviewed by: Isaiah Ferguson Works great guess count will cycle again when same mode is activated 
// two times in a row (He is fixing it now) the flow chart is extremely well written and flows nicely!


int mode = 0;
int tries = 0;
int guess = -10;
string? modeStr;
bool validNum;
bool loopGame = true;
bool loopMode = true;

while (loopGame)
{
    tries = 0;

    loopMode = true;
    while (loopMode)
    {
        Console.WriteLine("Choose Easy, Medium, or Hard");

        modeStr = Console.ReadLine().ToLower();

        if (modeStr == "easy")
        {
            mode = 11;
            loopMode = false;
        }
        else if (modeStr == "medium")
        {
            mode = 51;
            loopMode = false;
        }
        else if (modeStr == "hard")
        {
            mode = 101;
            loopMode = false;
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }


    Random rnd = new Random();
    int num = rnd.Next(1, mode);

    Console.WriteLine($"Guess a number between 1 and {mode - 1}");

    while (guess != num)
    {
        validNum = int.TryParse(Console.ReadLine(), out guess);

        if (validNum)
        {
            if (guess < num)
            {
                Console.WriteLine($"{guess} was less than the winning number. Try another.");
            }
            else if (guess > num)
            {
                Console.WriteLine($"{guess} was more than the winning number. Try another.");
            }
            tries++;
        }
        else
        {
            Console.WriteLine("Invalid input. Enter a number");
        }
    }

    Console.WriteLine($"Congrats! The number was {num} and it took you {tries} tries.");

    Console.WriteLine("Would you like to play again? Yes or No");

    bool loopGameValidInput = false;
    while (!loopGameValidInput)
    {
        string loopGameInput = Console.ReadLine().ToLower();

        if (loopGameInput == "yes")
        {
            loopGameValidInput = true;
        }
        else if (loopGameInput == "no")
        {
            loopGameValidInput = true;
            loopGame = false;
            Console.WriteLine("Have a great day");
        }
        else
        {
            Console.WriteLine("INVALID INPUT!\nEnter Yes or No");
        }
    }
}
