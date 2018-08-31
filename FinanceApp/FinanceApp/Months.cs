using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
   public class Months{

        public string MonthName { get; set; }
        private ObservableCollection<Purchase> purchases;
   
    public Months(){
        this.MonthName = "January";
    }

    public string OneLineSummary{
            get
            {
                return $"The Month is {this.MonthName}";
            }
    }
        public string AmountSummary
        {
            get
            {
                return $"{this.getPurchaseAmount()}";
            }
        }
        public void addPurchase(DateTime d, string des, string cat, float amount)
        {
            Purchase p = new Purchase(d, des, cat, amount);
            purchases.Add(p);
        }

        

        public float getPurchaseAmount()
        {
            Purchase p = purchases.First();
            return p.getAmount();
        }


    public class MonthsViewModel{
            private Months defaultMonths = new Months();
            public Months DefaultMonths { get { return this.defaultMonths; } }
    }




    }
}
