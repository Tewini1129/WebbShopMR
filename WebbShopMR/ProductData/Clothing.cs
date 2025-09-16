using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbShopMR.ProductData
{
    public class Clothing : Product
    {
        public string Size;



        public override string GetInfo()
        {
            return $"This Clothing item is named {Name} and is size {Size}. Price: {Price} Dollars";
        }

        public override string ProductDetails()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} Dollars";
        }
    }
}
