using System;
using System.Collections.Generic;
using System.Text;


namespace WPF_BUDGET_PLANNER
{
    class ExpensesCalc : Expenses // inheriting from the expense class
    {

        private double groceries;
        private double waterandLight;
        private double travelCost;
        private double phoneBills;
        private double other;
        private double tax;
        private double rent;
        private double gross;
        HomeLoan H = new HomeLoan();
        
        public delegate string ExpenseCompare ();
        public void Method()
        {

          /*  ExpenseCompare ex = delegate ()
            {
               string  result ;
                if (AllExpense() > (ExpenseLimiter.Compare*0.75))
                {
                  MessageBox.Show("Your Expenses are grater than 75% of your  Gross Salary please cut down on expenses or find a new job");
                }
                return 


            };*/
        }
        Vehicle v = new Vehicle();
        public ExpensesCalc(double groceries, double waterAndLight, double travelCost, double phoneBills, double other, double tax, double rent, double gross) :
                   base(groceries, waterAndLight, travelCost, phoneBills, other, tax, rent)
        {
            this.travelCost = travelCost;
            this.phoneBills = phoneBills;
            this.other = other;
            this.groceries = groceries;
            this.waterandLight = waterAndLight;
            this.tax = tax;
            this.rent = rent;
            this.gross = gross;
        }

        public void setGrossSal(double g)
        {
            this.gross = g;
        }

        public double getGross()
        {
            return gross;
        }


        public double AllExpense() // calculates all expenses when user rents a house 
        {
          double  result = getGroceries() + getTax() + getTravelCost() + getWaterandLight() + getPhoneBill() + getRent() + v.CalcVehicle();
                return Math.Round(result , 2); // Returning a double value 
          
        }
        public double HomeExpense()
        {
            double result = getGroceries() + getTax() + getTravelCost() + getWaterandLight() + getPhoneBill() + v.CalcVehicle();
            return Math.Round(result, 2); // Returning a double value 
        }

       
        

        public ExpensesCalc()
        {

        }

        public static List<ExpensesCalc> ExpenseLst = new List<ExpensesCalc>();
        
    }
    

   
   
}
