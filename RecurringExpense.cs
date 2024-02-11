using System;
using System.Collections.Generic;
//class to add recurring expense user can let it repeat itself a selected times 
namespace PAYSCHEDULER
{
    public class RecurringExpense : Expenses
    {
        public RecurringExpense( decimal TotalCost, DateTime StartDate, String Group, bool Paid): base(TotalCost,StartDate,Group,Paid)
        {
            
        }
    }


}