

static class Helper
{
    private static DateOnly SetTargetDate() =>
        DateOnly.FromDateTime(DateTime.Now).AddDays(Random.Shared.Next(1, 366));
}