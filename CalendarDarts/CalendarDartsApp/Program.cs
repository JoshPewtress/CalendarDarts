
static class Helper
{
    public static void PlayGame()
    {
        var targetDate = SetTargetDate();
        var userGuess = GuessAmountOfDays(targetDate);
        var dayDifference = GetDateDifference(targetDate, userGuess);
    }

    private static int GetDateDifference(DateOnly targetDate, int userGuess) =>
        DateOnly.FromDateTime(DateTime.Today.AddDays(userGuess)).DayNumber - targetDate.DayNumber;

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