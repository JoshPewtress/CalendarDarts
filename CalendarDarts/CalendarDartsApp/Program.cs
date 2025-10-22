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
