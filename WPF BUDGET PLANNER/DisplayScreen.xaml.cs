using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_BUDGET_PLANNER
{
    /// <summary>
    /// Interaction logic for DisplayScreen.xaml
    /// </summary>
    public partial class DisplayScreen : Window

    {
        public string[] display1 { get; set; }
        public string[] dipslay2 { get; set; }
        public delegate void ExpenseCompare();
        public delegate void ExpenseReport();
        public DisplayScreen()
        {
            InitializeComponent();
            HomeLoan H = new HomeLoan();
            ExpensesCalc E = new ExpensesCalc();
            Vehicle v = new Vehicle();
            MainWindow w = new MainWindow();
            // setting target Method for Delegate

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
               
                
                 txtblock.Text = String.Empty;
                  var Result = DisplayingOption2.lst.OrderByDescending(x => x.Amounts);
                  foreach (DisplayingOption2 item in Result) // setiitng to List and making sure that the program goes through each line
                  {
                   txtblock.Text += "\n" + item.ToString() + "\n";
                  }

                  var Result2 = DisplayingOption1.lst.OrderByDescending(x => x.Amounts);
                  foreach (DisplayingOption1 item in Result2 ) // setiitng to List and making sure that the program goes through each line
                  {
                      txtblock.Text += "\n" + item.ToString() + "\n";
                  }
           

        }
 public void ReportAlert2()
            {
            MainWindow w = new MainWindow();
                ExpensesCalc E = new ExpensesCalc();
                HomeLoan H = new HomeLoan();
              
            } // does the same thing as the method ReportAlert()
        private void btnSummary_Click(object sender, RoutedEventArgs e)
        {
            txtblock.Text = String.Empty;
          
             foreach(BudgetHelper item in BudgetHelper.lst)
            {
                txtblock.Text += "\n" + item.ToString() + "\n";
            }
        }

        private void btnSaving_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Savings s = new Savings();
            s.Show();


            
        }
    }
}
