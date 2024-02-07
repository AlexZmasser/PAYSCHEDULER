using System;
using System.Collections.Generic; 

namespace PAYSCHEDULER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Expenses> expenses = new List<Expenses>();
            
            Expenses.AddExpenseToList(expenses, 89, DateTime.Now, "Foods",false);

            foreach (Expenses expense in expenses)
            {
                Console.WriteLine($"Amount: {expense.TotalCost}$ Step cost:{expense.StepCost}$");
                Console.WriteLine("Start Date: {0:D}",expense.StartDate);
                Console.WriteLine("End Date: {0:D}",expense.EndDate); 
                Console.WriteLine($"Paid: {expense.Paid}");
            }
        }
    }
}
