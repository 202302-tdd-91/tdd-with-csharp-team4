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
        DateTime overlappingEnd;
        DateTime overlappingStart = Start > budget.GetFirstDay()
            ? Start
            : budget.GetFirstDay();
        if (budget.YearMonth == Start.ToString("yyyyMM"))
        {
            overlappingEnd = budget.GetLastDay();
            // overlappingStart = Start;
        }
        else if (budget.YearMonth == End.ToString("yyyyMM"))
        {
            overlappingEnd = End;
            // overlappingStart = budget.GetFirstDay();
        }
        else
        {
            overlappingEnd = budget.GetLastDay();
            // overlappingStart = budget.GetFirstDay();
        }

        return (overlappingEnd - overlappingStart).Days + 1;
    }
}