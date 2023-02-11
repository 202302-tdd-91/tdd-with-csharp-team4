#region

using System;

#endregion

namespace tdd_with_csharp;

public class Budget
{
    public int Amount { get; init; }
    public string YearMonth { get; init; } = null!;

    public double GetOverlappingAmount(Period period)
    {
        return GetDailyAmount() * period.GetOverlappingDays(CreatePeriod());
    }

    private Period CreatePeriod()
    {
        return new Period(GetFirstDay(), GetLastDay());
    }

    private double GetDailyAmount()
    {
        return Amount / (double)GetDays();
    }

    private int GetDays()
    {
        var firstDay = GetFirstDay();
        return DateTime.DaysInMonth(firstDay.Year, firstDay.Month);
    }

    private DateTime GetFirstDay()
    {
        return DateTime.ParseExact(YearMonth, "yyyyMM", null);
    }

    private DateTime GetLastDay()
    {
        return DateTime.ParseExact(YearMonth + GetDays(), "yyyyMMdd", null);
    }
}