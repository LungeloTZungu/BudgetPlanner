using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_BUDGET_PLANNER
{
    class DisplayingOption1
    {

        public String Statments { get; set; } // setting and getting Statments
        public Double Amounts { get; set; } // Setting and gettting amounts

       

        public DisplayingOption1(string state, double amout)
        {
            Statments = state;
            Amounts = amout;
        }

        public static List<DisplayingOption1> lst = new List<DisplayingOption1>();  // creating a list of type DisplayOption1
  
      
        
             
        public override string ToString() // Overidding ToString Method 
        {
            return Statments + Amounts;

        }

    }
}
