static class Helper
{
    private static readonly DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now);

    public static string PlayGame()
    {
        int randomResult = Random.Shared.Next(1, 366);

        DateOnly targetDate = GetNewDate(randomResult);
        int userGuess = GuessAmountOfDays(targetDate);
        DateOnly userDate = GetNewDate(userGuess);
        return DisplayResults(randomResult, userGuess, targetDate, userDate);
    }

    private static string DisplayResults(int randomResult, int userGuess, DateOnly targetDate, DateOnly userDate)
    {
        var difference = Math.Abs(randomResult - userGuess);

        var dateDifference = $"Your Guess of {userDate.ToString("MMMM dd, yyyy")} was {difference} " +
            $"{((difference) <= 1 ? "day" : "days")} away from the correct date of {targetDate.ToString("MMMM dd, yyyy")}";

        return difference <= 5
                ? $"You won! {dateDifference}"
                : $"Sorry, You lost. {dateDifference}";
    }

    private static DateOnly GetNewDate(int daysToAdd) =>
        todaysDate.AddDays(daysToAdd);

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
}