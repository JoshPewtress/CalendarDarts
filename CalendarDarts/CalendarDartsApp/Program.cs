var continuePlaying = String.Empty;

Console.WriteLine(
    """
    Calendar Darts
    You will be shown a random date within the next year.
    You will guess the number of days between Today and the random date.
    If your guess is within 5 days you win!
    """);

Console.WriteLine();

do
{
    Console.WriteLine(Helper.PlayGame());

    Console.Write(@"Play again? Y\N: ");
    continuePlaying = Console.ReadLine();
}
while (continuePlaying.Trim().ToUpper() == "Y");

static class Helper
{
    public static string PlayGame()
    {
        var targetDate = SetTargetDate();
        var userGuess = GuessAmountOfDays(targetDate);
        var dayDifference = GetDateDifferenceFromUsersGuess(targetDate, userGuess);
        return DisplayResults(dayDifference, targetDate, userGuess);
    }

    private static string DisplayResults(int dayDifference, DateOnly targetDate, int userGuess)
    {
        var dateDifference = $"The difference between {targetDate} and today is {GetDateDifferenceFromTargetAndToday(targetDate)} days.\n";

        return dayDifference >= -5 && dayDifference <= 5
                ? $"You won! {dateDifference}"
                : $"Sorry, You lost. {dateDifference}";
    }

    private static int GetDateDifferenceFromUsersGuess(DateOnly targetDate, int userGuess) =>
        targetDate.DayNumber - DateOnly.FromDateTime(DateTime.Today.AddDays(userGuess)).DayNumber;

    private static int GetDateDifferenceFromTargetAndToday(DateOnly targetDate) =>
        targetDate.DayNumber - DateOnly.FromDateTime(DateTime.Today).DayNumber;

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