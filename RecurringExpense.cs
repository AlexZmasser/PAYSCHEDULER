using System;
using System.Collections.Generic;
//class to add recurring expense user can let it repeat itself a selected times 
namespace PAYSCHEDULER
{
    public class RecurringExpense : Expenses
    {
        public RecurringExpense( decimal TotalCost, DateTime StartDate, String Group,int numMonthss): base(TotalCost,StartDate,Group)
        {
            
        }

        public void AddMonthlyExpense(List<Expenses> expenseList,decimal TotalCost, DateTime StartDate, String Group, int numMonths)
        {
            DateTime currentDate = StartDate; 
            for(int i=0;i < numMonths; i++)
            {  
                Expenses.AddExpenseToList(expenseList, TotalCost,currentDate,Group);
                currentDate = currentDate.AddMonths(1);
            }
       }
    }


}