using System;
using System.Collections.Generic;

namespace PAYSCHEDULER
{
    public class Expenses
    {
        private decimal totalCost,stepCost;
        private DateTime startDate,endDate; // field
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
        public DateTime EndDate   // property
        {
            get { return endDate; }   // get method
            set { endDate = value; }  // set method
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
            endDate = startDate.AddDays(56);
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