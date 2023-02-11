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
        var overlappingEnd = End < budget.GetLastDay()
            ? End
            : budget.GetLastDay();
        
        var overlappingStart = Start > budget.GetFirstDay()
            ? Start
            : budget.GetFirstDay();

        return (overlappingEnd - overlappingStart).Days + 1;
    }
}