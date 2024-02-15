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
            RecurringExpense recurringExpense = new RecurringExpense(100, DateTime.Now, "Rent");
            
            Expenses.AddExpenseToList(expenses, 89, DateTime.Now, "Foods",false);
            

            foreach (Expenses expense in expenses)
            {
                Console.WriteLine($"+{expenses}: {expenses.TotalCost}$ Due {v.curentDate} ");
            }
        }
    }
}
