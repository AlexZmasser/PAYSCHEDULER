using System;
using System.Collections.Generic;

namespace PAYSCHEDULER
{
    public class RecurringExpense : Expenses
    {
        public RecurringExpense( decimal TotalCost, DateTime StartDate, String Group, bool Paid): base(TotalCost,StartDate,Group,Paid)
        {
            
        }

        public void AddMonthlyExpense(List<Expenses> expenseList,decimal TotalCost, DateTime StartDate, String Group, int numMonths)
        {
            DateTime currentDate = StartDate; 
            for(int i=0;i < numMonths; i++)
            {  
                Expenses newEpense = new Expenses(TotalCost,StartDate, Group);
                expenseList.Add(newEpense);
                currentDate = currentDate.AddMonths(1);
            }
       }
    }


}