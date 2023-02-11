#region

using System;

#endregion

namespace tdd_with_csharp;

public class Budget
{
    public int Amount { get; set; }
    public string YearMonth { get; set; }

    public int GetDays()
    {
        var firstDay = GetFirstDay();
        return DateTime.DaysInMonth(firstDay.Year, firstDay.Month);
    }

    public DateTime GetFirstDay()
    {
        return DateTime.ParseExact(YearMonth, "yyyyMM", null);
    }

    public DateTime GetLastDay()
    {
        return DateTime.ParseExact(YearMonth + GetDays(), "yyyyMMdd", null);
    }

    public Period CreatePeriod()
    {
        return new Period(GetFirstDay(), GetLastDay());
    }
}