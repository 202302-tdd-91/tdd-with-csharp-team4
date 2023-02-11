#region

using System;

#endregion

namespace tdd_with_csharp;

public class Period
{
    public Period(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    private DateTime End { get; }
    private DateTime Start { get; }

    public int GetOverlappingDays(Budget budget)
    {
        var another = new Period(budget.GetFirstDay(), budget.GetLastDay());
        var firstDay = budget.GetFirstDay();
        var lastDay = budget.GetLastDay();
        var overlappingEnd = End < lastDay
            ? End
            : lastDay;

        var overlappingStart = Start > firstDay
            ? Start
            : firstDay;

        return (overlappingEnd - overlappingStart).Days + 1;
    }
}