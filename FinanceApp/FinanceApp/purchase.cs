using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceApp
{
    class Purchase
    { 
        private DateTime date { get; set; }
        private string description { get; set; }
        private string category { get; set;  }
        private float amount { get; set; }

        public Purchase(DateTime d, string des, string cat, float a)
        {
            date = d;
            description = des;
            category = cat;
            amount = a;
        }
  

    public float getAmount()
    {
        return amount;
    }
    }
}
