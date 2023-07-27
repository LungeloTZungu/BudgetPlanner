using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_BUDGET_PLANNER
{
    class HomeLoan 
    {

        private double PurchasePrice;
        private double Interest;
        private double Deposit;
        private double NumMonth;
        private double LoanAmount;
        private double MonthlyAmount;
      
       
        public double PurchasePrice1 { get => PurchasePrice; set => PurchasePrice = value; }  // gets and sets for the varaibles
        public double Interest1 { get => Interest; set => Interest = value; }
        public double Deposit1 { get => Deposit; set => Deposit = value; }
        public double NumMonth1 { get => NumMonth; set => NumMonth = value; }

        protected HomeLoan(  double PurchasePrice , double Interest , double Deposit, double NumMonth) // constructor
           
        {
            this.PurchasePrice = PurchasePrice;
            this.Interest1 = Interest;
            this.NumMonth1 = NumMonth;
            this.Deposit1 = Deposit;
        }


        public double CalcMonthlyPayment() // method to calculate the monthly payments
        {
            LoanAmount = ((PurchasePrice - Deposit) * ((1 + (Interest / 100) * (NumMonth / 12))));
            MonthlyAmount = LoanAmount / NumMonth;
            return Math.Round(MonthlyAmount, 2);

        }
        public HomeLoan()
        {

        }
    }
}


