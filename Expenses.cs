using System;
using System.Collections.Generic;
//Main Expenses class 

namespace PAYSCHEDULER
{
    public class Expenses
    {
        //private variables
        private decimal totalCost,stepCost;
        private DateTime startDate; // field
        private string costName,group; // name
        private bool paid;

        public bool Paid   // paid
        {
            get { return paid; }   // get method
            set { paid = value; }  // set method
        }
        public decimal TotalCost   // property
        {
            get { return totalCost; }   // get method
            set { totalCost = value; }  // set method
        }
        public decimal StepCost   // property
        {
            get { return stepCost; }   // get method
            set { stepCost = value; }  // set method
        }
        public DateTime StartDate   // property
        {
            get { return startDate; }   // get method
            set { startDate = value; }  // set method
        }
        public string CostName   // property
        {
            get { return costName; }   // get method
            set { costName = value; }  // set method
        }
        public string Group   // property
        {
            get { return group; }   // get method
            set { group = value; }  // set method
        }
        public Expenses( decimal TotalCost, DateTime StartDate, String Group, bool Paid)
        {
            totalCost = TotalCost;
            StepCost = TotalCost/4;
            startDate = StartDate;
            group = Group;
            paid = Paid;
            
        }

        public static void AddExpenseToList(List<Expenses> expenseList, decimal TotalCost, DateTime StartDate, String Group, bool Paid)
        {
            Expenses newExpense = new Expenses(TotalCost,StartDate,Group,Paid);
            expenseList.Add(newExpense);

        }


    }
}