var userGuess = Helper.PlayGame();

Console.WriteLine(userGuess);

Console.ReadLine();

static class Helper
{
    public static int PlayGame()
    {
        var targetDate = SetTargetDate();
        var userGuess = GuessAmountOfDays(targetDate);
        return userGuess;
    }

    private static int GuessAmountOfDays(DateOnly targetDate)
    {
        int output;
        bool validInput = false;

        do
        {
            Console.Write($"Amount of days between {targetDate} and today: ");

            validInput = (int.TryParse(Console.ReadLine(), out output) && output > 0);
        } while (validInput == false);

        return output;
    }

    private static DateOnly SetTargetDate() =>
        DateOnly.FromDateTime(DateTime.Now).AddDays(Random.Shared.Next(1, 366));
}