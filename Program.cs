using System;
using System.Collections.Generic; 

namespace PAYSCHEDULER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Expenses> expenses = new List<Expenses>(); 
            RecurringExpense recurringExpense = new RecurringExpense(100, DateTime.Now,""); 

            recurringExpense.AddMonthlyExpense(expenses, 100, DateTime.Now, "Rent", 6); 
            recurringExpense.AddWeeklyExpense(expenses,20, DateTime.Now, "Food",4);
            Expenses.AddExpenseToList(expenses, 89, DateTime.Now, "Game");
            

            Console.WriteLine("All expenses listed by date:");
            expenses.Sort((x, y) => x.StartDate.CompareTo(y.StartDate));
            foreach (Expenses expense in expenses)
            {
                Console.WriteLine($"Name: {expense.Group}, Amount: {expense.TotalCost},  Date {expense.StartDate}");
            }
        }
    }
}