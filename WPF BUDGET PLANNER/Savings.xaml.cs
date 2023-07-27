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
    /// Interaction logic for Savings.xaml
    /// </summary>
    public partial class Savings : Window
    {
        public Savings()
        {
            InitializeComponent();
        }

        private void btnSaveValues_Click(object sender, RoutedEventArgs e)
        {
            if (rdbCmpInt.IsChecked == true) // if the compound interest option is selected
            {
            SavingsClaculater sv = new SavingsClaculater();
                /* sv.setA(double.Parse(txtA.Text));
                 sv.setR(double.Parse(txtR.Text));
                 sv.setN(double.Parse(txtN.Text));
                 sv.setT(double.Parse(txtT.Text));*/
                sv.R = double.Parse(txtR.Text);
                sv.N = double.Parse(txtN.Text);
                sv.T = double.Parse(txtT.Text);
                sv.A = double.Parse(txtA.Text);
            MessageBox.Show("You will need to save and amount of R:" + sv.CalcSavingsCmp() + " to reach your goal of R:" + sv.A + " in the next " + sv.T + " years");

            }
            
            if (rdbSmpInt.IsChecked == true)
            {
                SavingsClaculater sv = new SavingsClaculater();
                sv.A = double.Parse(txtA.Text);
                sv.R = double.Parse(txtR.Text);
                sv.N = double.Parse(txtN.Text);
                sv.T = double.Parse(txtT.Text);
                if (double.Parse(txtR.Text) >= 100) 
                {
                    MessageBox.Show("You have entred in the an unreasonable rate please re-entre");
                }
                else
                {
               MessageBox.Show("You will need to save and amount of R:" + sv.CalcSavingsSmp() + " to reach your goal of R:" + sv.A+ " in the next " + sv.T + " years");

                }
              
            }
        }

        private void btnGoback_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            DisplayScreen ds = new DisplayScreen();
            ds.Show();
        }
    }
}
