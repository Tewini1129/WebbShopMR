using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbShopMR
{
    public class Product
    {
        public static double GlobalDiscount = 0.0;
        public static int NextId = 1;
        private static int totalCount = 1;

        public static int TotalCount
        {
            get { return totalCount;  }
            set { value = TotalCount;  }
        }

        public virtual string GetInfo()
        {
            return $"\nName: {Name}\nPrice: {Price}";
        }


        public virtual string ProductDetails()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} Dollars";
        }





        public int Id;
        public string Name;
        public string Brand;
        public double Price;


        protected Product()
        {
            Id = NextId;
            NextId++;
            TotalCount++;


        }



        public virtual double FinalPrice()
        {
            double discountFactore = 1 - GlobalDiscount;
            return Price * discountFactore;
        }

        public static void SetGlobalDiscount(double percent)
        {
            GlobalDiscount = percent / 100;

        }

    }
}
