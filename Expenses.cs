using System;

namespace PAYSCHEDULER
{
    class Expenses
    {
        private int totalCost,stepCost,startDate,endDate; // field
        private string costName,group; // name

        public int TotalCost   // property
        {
            get { return totalCost; }   // get method
            set { totalCost = value; }  // set method
        }
        public int StepCost   // property
        {
            get { return stepCost; }   // get method
            set { stepCost = value; }  // set method
        }
        public int StartDate   // property
        {
            get { return startDate; }   // get method
            set { startDate = value; }  // set method
        }
        public int EndDate   // property
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

    }
}