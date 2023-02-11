#region

using System;
using System.Linq;

#endregion

namespace tdd_with_csharp;

public class BudgetService
{
    private readonly IBudgetRepo _budgetRepo;

    public BudgetService(IBudgetRepo budgetRepo)
    {
        _budgetRepo = budgetRepo;
    }

    public double Query(DateTime start, DateTime end)
    {
        var budgets = _budgetRepo.GetAll();
        var period = new Period(start, end);

        return budgets.Sum(budget => budget.GetOverlappingAmount(period));
    }
}