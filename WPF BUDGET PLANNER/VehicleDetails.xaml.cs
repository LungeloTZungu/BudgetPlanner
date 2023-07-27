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
    /// Interaction logic for VehicleDetails.xaml
    /// </summary>
    public partial class VehicleDetails : Window
    {
        public VehicleDetails()
        {
            InitializeComponent();
        }

        private void btnSumbit_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Vehicle v = new Vehicle();
                v.setvpurchaseprice(double.Parse(txtVPurchasePrice.Text)); // setting the vehicle values
                v.setvdeposite(double.Parse(txtVDeposite.Text));
                v.setvinterest(double.Parse(txtInterest.Text));
                v.setinsurance(double.Parse(txtInsurance.Text));
                if (double.Parse(txtInterest.Text) >= 100)
                {
                    MessageBox.Show("You have an unreasonalbe interest please re entre the interest");   // condition if user enters an interest of 100 or more
                }
                BudgetHelper.toalVehicleList.Add(v.CalcVehicle());
                MessageBox.Show("Vehicle Details have been saved");
                MessageBox.Show("Please press the Go Back Button and press Dislay to veiw results");
            }
            catch (Exception)
            {
                MessageBox.Show("You have entred the wrong Input please try again and make sure " +
                    "that you entre digits where there needs to be and Letters where you need to entre them");
            }
           
            
           
        }

        private void btnGoBck_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }
    }
}
