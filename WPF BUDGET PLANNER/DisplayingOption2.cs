using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_BUDGET_PLANNER
{
  public  class DisplayingOption2 // Creates list when user clicks on the Purchase Option and displays neccessary info
    {
        public String Statments { get; set; }
        public Double Amounts { get; set; }

   public   DisplayingOption2(string state, double amout) 
        {
            Statments = state;
            Amounts = amout;
        }

   public static  List<DisplayingOption2> lst = new List<DisplayingOption2>(); // Creating a List of Type DisplayingOption2
     

     

        public override string ToString() // Overinding ToString Method
        {
            return Statments + Amounts;



        }

    }

  
}
