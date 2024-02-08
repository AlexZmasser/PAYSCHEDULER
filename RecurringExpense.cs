using System;
using System.Collections.Generic;

namespace PAYSCHEDULER
{
    public class RecurringExpense : Expenses
    {
        public RecurringExpense( decimal TotalCost, DateTime StartDate, String Group, bool Paid): base(TotalCost,StartDate,Group,Paid)
        {
            
        }
    }


}