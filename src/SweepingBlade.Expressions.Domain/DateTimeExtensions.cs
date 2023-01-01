namespace SweepingBlade.Expressions.Domain;

public static class DateTimeExtensions
{
    public static bool IsHighSeason(this DateTime dateTime)
    {
        if (dateTime.Month is >= 6 and <= 9)
        {
            if (dateTime is { Month: 6, Day: < 21 }) return false;

            if (dateTime is { Month: 9, Day: > 23 }) return false;

            return true;
        }

        return false;
    }

    public static bool IsLowSeason(this DateTime dateTime)
    {
        if (dateTime.Month is > 3 and < 12) return false;

        if (dateTime is { Month: 3, Day: > 20 }) return false;

        if (dateTime is { Month: 12, Day: < 21 }) return false;

        return true;
    }

    public static bool IsWeekend(this DateTime dateTime)
    {
        return dateTime.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday;
    }
}