using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShoppingCart shop=new ShoppingCart();
            ShoppingCart shop1 = new ShoppingCart();

            shop.id = 101;
            shop.descr = " Laptop";
            shop.quantity = 5;
            shop.price = 45000;

            shop1.id = 102;
            shop1.descr = "Laptop";
            shop1.quantity = 2;
            shop1.price = 55000;

            shop.PrintItemDetails();
            shop1.PrintItemDetails();

            shop.PrintItem();
            shop1.PrintItem();
        }
    }
}
