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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_BUDGET_PLANNER
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] LivingOptions { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            LivingOptions = new string[] { "Rent", "Purchase House" };
            DataContext = this;
            txtRent.Visibility = Visibility.Hidden;
            lblRent.Visibility = Visibility.Hidden;
            txtHMonths.Visibility = Visibility.Hidden;
           
            
         

        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {

            try
            {
          
                Vehicle v = new Vehicle();      // Vehicle class instance
                ExpensesCalc E = new ExpensesCalc();   // Expense class instance
                E.setGroceries(double.Parse(txtGroceries.Text));   // setting the variables 
                E.setWaterandLights(double.Parse(txtW_E.Text));
                E.setRent(double.Parse(txtRent.Text));
                E.setTravelCost(double.Parse(txtTravelCost.Text));
                E.setPhoneBill(double.Parse(txtPhoneBill.Text));
                E.setOther(double.Parse(txtOther.Text));
                E.setGrossSal(double.Parse(txtGrossSalary.Text));
                if (double.Parse(txtGrossSalary.Text) <= 205900)     // All stements like these are to set the tax if the gross salary reaches a certain amount
                {
                    E.setTax(double.Parse(txtGrossSalary.Text) * 0.18);
                }
                if (double.Parse(txtGrossSalary.Text) > 205900)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.26) + 37062);
                }
                if (double.Parse(txtGrossSalary.Text) > 321600)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.31) + 67114);
                }
                if (double.Parse(txtGrossSalary.Text) > 445100)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.36) + 105429);
                }
                if (double.Parse(txtGrossSalary.Text) > 584200)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.39) + 155505);
                }
                if (double.Parse(txtGrossSalary.Text) > 744800)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.41) + 218139);
                }
                if (double.Parse(txtGrossSalary.Text) >= 1577301)
                {
                    E.setTax((double.Parse(txtGrossSalary.Text) * 0.45) + 559464);
                }

                HomeLoan H = new HomeLoan();   // Home class Instance
                H.PurchasePrice1 = double.Parse(txtHPurchasePrice.Text);
                H.Interest1 = double.Parse(txtHInterest.Text);
                H.Deposit1 = double.Parse(txtHDeposit.Text);
                H.NumMonth1 = double.Parse(TxtHMonths.Text);
                BudgetHelper.totalLoanList.Add(H.CalcMonthlyPayment());
                if (rdbRent.IsChecked==true)  // if rent option is selected
                {
                    DisplayingOption2.lst.Add(new DisplayingOption2("Gross Salary: R", E.getGross()));   // Adding to the Display option2 List
                    DisplayingOption2.lst.Add(new DisplayingOption2("Groceries: R", E.getGroceries()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Water and Light: R", E.getWaterandLight()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Travel Costs: R", E.getTravelCost()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Phone Bill :R", E.getPhoneBill()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Rent: R", E.getRent()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Tax: R", E.getTax()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Other: R", E.getOther()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Vehicle Payments: R", getVehiclCalc()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Total Expense : R", E.AllExpense()));
                    BudgetHelper.lst.Add(new BudgetHelper("Gross Salary: R", E.getGross()));
                    BudgetHelper.lst.Add(new BudgetHelper("All Expenses: R", E.AllExpense()));
                    BudgetHelper.lst.Add(new BudgetHelper("Money Left Over: R", E.getGross() - E.AllExpense()));
                    
                    if (E.getWaterandLight() > E.getGross())
                    {
                        MessageBox.Show("Your Water and Lighst are to greate please re-enter or cut your expenses");
                    }
                    if (H.CalcMonthlyPayment() > E.getGross())
                    {
                        MessageBox.Show("Your Rent is  to greate please re-enter or cut your expenses");
                    }
                    if (E.getOther() > E.getGross())
                    {
                        MessageBox.Show("Your Other amount are to greate please re-enter or cut your expenses");
                    }
                    if (E.getGroceries() > E.getGross())
                    {
                        MessageBox.Show("Your Grocceries are to greate please re-enter or cut your expenses");
                    }
                    if (E.getTravelCost() > E.getGross())
                    {
                        MessageBox.Show("Your Travel Costs are to greate please re-enter or cut your expenses");
                    }
                    if (E.getPhoneBill() > E.getGross())
                    {
                        MessageBox.Show("Your PhneBill are to greate please re-enter or cut your expenses");
                    }


                }
                if (rdbPH.IsChecked==true) // if Purchase House Otption is selected
                {
                    DisplayingOption1.lst.Add(new DisplayingOption1("Gross Salary R:", E.getGross()));  // Adding to the display option1 List
                    DisplayingOption1.lst.Add(new DisplayingOption1("Groceries: R", E.getGroceries()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Water and Light: R", E.getWaterandLight()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Travel Costs: R", E.getTravelCost()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Phone Bill : R", E.getPhoneBill()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Deposite: R", H.Deposit1));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Tax: R", E.getTax()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Monthly Payments: R", getHomeLoanPay()));
                    DisplayingOption1.lst.Add(new DisplayingOption1("Vehicle Payments R:", getVehiclCalc()));
                    DisplayingOption2.lst.Add(new DisplayingOption2("Total Expense : R", E.HomeExpense()));
                    BudgetHelper.lst.Add(new BudgetHelper("Gross Salary: R", E.getGross()));
                    BudgetHelper.lst.Add(new BudgetHelper("All Expenses: R", E.AllExpense()));
                    BudgetHelper.lst.Add(new BudgetHelper("Money Left Over: R", E.getGross() -( E.HomeExpense()+H.CalcMonthlyPayment())));
                    if (E.getWaterandLight() > E.getGross())  // Measures incase of Human errors
                    {
                        MessageBox.Show("Your Water and Lighst are to greate please re-enter or cut your expenses");
                        
                    }
                    if (H.CalcMonthlyPayment() > E.getGross())
                    {
                        MessageBox.Show("Your Rent is  to greate please re-enter or cut your expenses");
                        
                    }
                    if (E.getOther() > E.getGross())
                    {
                        MessageBox.Show("Your Other amount are to greate please re-enter or cut your expenses");
                    }
                    if (E.getGroceries() > E.getGross())
                    {
                        MessageBox.Show("Your Grocceries are to greate please re-enter or cut your expenses");
                    }
                    if (E.getTravelCost() > E.getGross())
                    {
                        MessageBox.Show("Your Travel Costs are to greate please re-enter or cut your expenses");
                    }
                    if (E.getPhoneBill() > E.getGross())
                    {
                        MessageBox.Show("Your PhneBill are to greate please re-enter or cut your expenses");
                    }
                }


                MessageBox.Show("Infromation Saved");


            }
            catch (Exception)
            {
                MessageBox.Show("You have entered a field in the wrong fromat please try using numbers");
            }

            
            



        }
           
        private void btnShowVehiclePage_Click(object sender, RoutedEventArgs e)  // Button event to show the Vehicle details page
        {
            this.Hide();
            VehicleDetails v = new VehicleDetails();  
            v.Show();



        }

        public double getHomeLoanPay()  // Method to get values fromthe totalLoanList to be added to the main list
        {
            double result = 0;
            foreach (var item in BudgetHelper.totalLoanList)
            {
                result = item;
            }
            return result;
        }
        public double getVehiclCalc() // Method to get values fromthe totalVehicleList to be added to the main list
        {
            double result=0;
            foreach (double item in BudgetHelper.toalVehicleList)
            {
              result += item;
            }
            return result;
        }

       

        private void btnShowResult_Click(object sender, RoutedEventArgs e)  // Button to show the Dsiplay screen Window
        {
            this.Hide();
            DisplayScreen ds = new DisplayScreen();
            ds.Show();
        }

        private void rdbRent_Checked(object sender, RoutedEventArgs e)
        {
            if (rdbRent.IsChecked == true)
            {
                txtRent.Visibility = Visibility.Visible;
                lblRent.Visibility = Visibility.Visible;
            }
          
            

            
        }

        private void rdbRent_Unchecked(object sender, RoutedEventArgs e)
        {
            txtRent.Visibility = Visibility.Hidden;
            lblRent.Visibility = Visibility.Hidden;
        }

        private void rdbPH_Checked(object sender, RoutedEventArgs e)
        {
            txtHMonths.Visibility = Visibility.Visible;
        }

        private void rdbPH_Unchecked(object sender, RoutedEventArgs e)
        {
            txtHMonths.Visibility = Visibility.Hidden;
        }
    }
    }


