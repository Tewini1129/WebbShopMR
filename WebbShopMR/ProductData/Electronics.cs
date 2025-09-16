using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbShopMR.ProductData
{
    public class Electronics : Product
    {
        public int WarrantyYears;


        public override string GetInfo()
        {
            return $"this electronic item is named {Name}, its warranty is {WarrantyYears} years. Price: {Price} Dollars";
        }


        public override string ProductDetails()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} Dollars";
        }

    }
}
