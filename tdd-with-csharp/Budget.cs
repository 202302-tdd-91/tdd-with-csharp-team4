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
        var firstDay = DateTime.ParseExact(YearMonth, "yyyyMM", null);
        return DateTime.DaysInMonth(firstDay.Year, firstDay.Month);
    }
}