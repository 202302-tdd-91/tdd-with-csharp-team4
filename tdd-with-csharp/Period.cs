﻿#region

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
        var overlappingEnd = End < another.End
            ? End
            : another.End;

        var overlappingStart = Start > another.Start
            ? Start
            : another.Start;

        return (overlappingEnd - overlappingStart).Days + 1;
    }
}