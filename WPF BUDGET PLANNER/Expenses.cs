using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_BUDGET_PLANNER
{
  abstract   class Expenses 
    { 
        private double Groceries;
        private double WaterAndLight;
        private double TravelCost;
        private double PhoneBills;
        private double Other;
        private double Rent;
        private double Tax;
       

        public void setGroceries(double G)   // Making gets and sets fir this class which can be used.
        {
            this.Groceries = G;
        }
        public double getGroceries()
        {
            return Groceries;
        }

        public void setWaterandLights(double WL)
        {
            this.WaterAndLight = WL;
        }
        public double getWaterandLight()
        {
            return WaterAndLight;
        }

        public void setTravelCost(double TC)
        {
            this.TravelCost = TC;
        }
        public double getTravelCost()
        {
            return TravelCost;
        }

        public void setPhoneBill(double PB)
        {
            this.PhoneBills = PB;
        }
        public double getPhoneBill()
        {
            return PhoneBills;
        }

        public void setOther(double OT)
        {
            this.Other = OT;
        }
        public double getOther()
        {
            return Other;
        }

        public void setTax(double T)
        {
            this.Tax = T;
        }
        public double getTax()
        {
            return Tax;
        }

        public void setRent(double R)
        {
            this.Rent = R;
        }

        public double getRent()
        {
            return Rent;
        }


     

        protected  Expenses(double groceries, double waterAndLight, double travelCost, double phoneBills, double other, double tax , double rent )
            
        {
            Groceries = groceries;
            WaterAndLight = waterAndLight;
            TravelCost = travelCost;
            PhoneBills = phoneBills;
            Other = other;
            Tax = tax;
            Rent = rent;
        }



     
        public Expenses()
        {

        }



    }
}




