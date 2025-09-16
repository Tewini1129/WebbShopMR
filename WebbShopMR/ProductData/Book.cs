using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbShopMR.ProductData
{
    public class Book: Product
    {
        public string Author;

        public Book()
        {
            
        }


        public override string GetInfo()
        {
            return $"The book {Name} was written by {Author} and published by {Brand}. Price: {Price} dollars";
        }


        public override string ProductDetails()
        {
            return $"Id: {Id}\nName: {Name}\nPrice: {Price} Dollars";
        }


    }
}
