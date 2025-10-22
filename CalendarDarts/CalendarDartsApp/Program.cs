
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

        return dayDifference >= -5 && dayDifference <= 5
                ? $"You won! The difference between {targetDate} and today is {GetDateDifferenceFromTargetAndToday(targetDate)} days."
                : $"Sorry, You lost. The difference was {dayDifference} days.";
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