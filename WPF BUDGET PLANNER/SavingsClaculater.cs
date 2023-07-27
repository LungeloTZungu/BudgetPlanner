using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_BUDGET_PLANNER
{
    class SavingsClaculater
    {

        private double a;   // Future amount
        private double r;   // Rate
        private double n;   // Number of months
        private double t;   // Number of Years

        public double A { get => a; set => a = value; }
       
        public double R { get => r; set => r = value; }
        public double N { get => n; set => n = value; }
        public double T { get => t; set => t = value; }

        public SavingsClaculater(double A, double R, double N, double T) // Constructor
        {
            this.a = A;
            this.r = R;
            this.n = N;
            this.t = T;
        }

        public SavingsClaculater()
        {

        }

        
        public double CalcSavingsCmp()// calculations for compund interest
        {
            double result;
            double sP; // solving for P
            sP = Math.Pow(((1 + r/100)/ n), n * t);  
            result = (a/sP);
                return Math.Round(result,2);
        }

        public double CalcSavingsSmp() // Calculations for simple interest
        {
            double result;



             double money =  a/(1 + (r * t));
            result = money / (t * 12);
            return Math.Round(result, 2);

        }
    }
}
