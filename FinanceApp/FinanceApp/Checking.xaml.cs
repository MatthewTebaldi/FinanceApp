using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static FinanceApp.Months;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace FinanceApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Checking : Page
    {

        private String currentMonth = "defaultMonth";
        

        public Checking()
        {
            this.InitializeComponent();
            this.ViewModel = new MonthsViewModel();
            Months myMonths = new Months();
            myMonths.MonthName = "WOOOOWOWOWOWOOWOW";
        }

        public MonthsViewModel ViewModel { get; set; }
        
        private void janButton_Click(object sender, RoutedEventArgs e)
        {
            this.monthButtonClicked("January");
        }
        private void febButton_Click(object sender, RoutedEventArgs e)
        {
            this.monthButtonClicked("February");
        }

        private void monthButtonClicked(string month)
        {
            currentMonth = month;

            switch (currentMonth)
            {
                case "January":
                    this.expenseTextBlock.Text = "January Expenses";
                    break;

                case "February":
                    this.expenseTextBlock.Text = "Febraury Expenses";
                    break;

                case "March":
                    this.expenseTextBlock.Text = "March Expenses";
                    break;

                default:
                    this.expenseTextBlock.Text = "Expenses";
                    break;
            }
            if (month.Equals("January"))
            {
                currentMonth = "jan";
                this.expenseTextBlock.Text = "January Expenses";
            }
        }
    }
}
