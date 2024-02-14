//created by Alexander Zmasser-Young

using System;
using System.Collections.Generic; 
//main class

namespace PAYSCHEDULER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Expenses> expenses = new List<Expenses>();
            
            Expenses.AddExpenseToList(expenses, 89, DateTime.Now, "Foods",false);
            
            List<RecurringExpense> recurringExpense = new List<RecurringExpense>(); 

            recurringExpense.AddExpenseToList(100, DateTime.Now,"rent", 6 );

            foreach (RecurringExpense  recurringExpenses in recurringExpense)
            {
                Console.WriteLine($"+{recurringExpenses.Group}: {recurringExpenses.TotalCost}$ Due {recurringExpenses.curentDate} ");
            }
        }
    }
}
