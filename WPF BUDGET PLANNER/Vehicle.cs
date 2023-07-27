using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BUDGET_PLANNER
{
   public  class Vehicle
    {
        private String modelandmake;  // Declaring Varavialbes 
        private double vpurchaseprice;
        private double vinterest;
        private double vdeposite;
        private double insurance;

        public Vehicle(string modelandmake, double vpurchaseprice, double vinterest, double vdeposite, double insurance) // Constructor for the vehicle Class
        {
            this.modelandmake = modelandmake;
            this.vpurchaseprice = vpurchaseprice;
            this.vinterest = vinterest;
            this.vdeposite = vdeposite;
            this.insurance = insurance;
        }

        public void setModelMake(string mm)
        {
            this.modelandmake = mm;
        }
        public string getmodelandMake()
        {
           
            return modelandmake;
        }

        public void setvpurchaseprice(double vpp)
        {
            this.vpurchaseprice =vpp ;
        }
        public double getvpirchaseprice()
        {
            return vpurchaseprice;
        }

        public void setvinterest(double vint)
        {
            this.vinterest = vint;
        }
        public double getvinterest()
        {
            return vinterest;
        }

        public void setvdeposite(double dv)
        {
            this.vdeposite = dv;
        }
        public double getvdeposite()
        {
            return vdeposite;
        }

        public void setinsurance(double i)
        {
            this.insurance = i;
        }
        public double getinsurance()
        {
            return insurance;
        }

        public double CalcVehicle() // Claculating overall vehicle expense
        {
            double VAmount = (getvpirchaseprice() - getvdeposite()) * (1 + (getvinterest() / 100) * (5));
            double Payment =( VAmount / 60) + getinsurance();
            return Math.Round(Payment, 2);
        }

        public Vehicle()
        {

        }
     
    }
}
