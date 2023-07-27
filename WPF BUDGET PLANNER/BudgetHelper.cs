using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BUDGET_PLANNER
{
     class BudgetHelper
    {
        public static List<double> totalLoanList = new List<double>(); // list for the toal Loan 
        public static List<double> toalVehicleList = new List<double>(); // List for the total vehicle amount
        public static List<double> totalHomeLoan = new List<double>(); // list for total from homeLoan
        public static List<double> Savings = new List<double>();   // list for savings 
       public  string Statement;
       public double Amount;

        public BudgetHelper(string state, double amout)
        {
            Statement = state;
            Amount = amout;
        }
        public static List<BudgetHelper> lst = new List<BudgetHelper>();  // creating a list of type BudgetHelper

        public override string ToString() // Overidding ToString Method 
        {
            return Statement + Amount;

        }
    }
}
