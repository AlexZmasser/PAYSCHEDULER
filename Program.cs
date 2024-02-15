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
            RecurringExpense recurringExpense = new RecurringExpense(50, DateTime.Now, "Food",3); 

            recurringExpense.AddMonthlyExpense(expenses, 100, DateTime.Now, "Rent", 6);
            Expenses.AddExpenseToList(expenses, 89, DateTime.Now, "Foods");
            

            foreach (Expenses expense in expenses)
            {
                Console.WriteLine($"Name: {expense.Group}, Amount: {expense.TotalCost},  Date {expense.StartDate}");
            }
        }
    }
}
