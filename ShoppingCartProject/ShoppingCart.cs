using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class ShoppingCart
    {
        public int id;
        public string descr;
        public int quantity;
        public double price;

        public void PrintItemDetails()
        {
            Console.WriteLine("id : " + id);
            Console.WriteLine("descr : " + descr);
            Console.WriteLine("quantity : " + quantity);
            Console.WriteLine("price : " + price);
            Console.WriteLine("--------------------------------------------------");
        }

        public void PrintItem()
        {
            double final_price;
            if (quantity == 2)
            {
                final_price = (price - (price * 10 / 100)) * quantity;
                Console.WriteLine("Congrats you have get 10% discount :" + final_price);
            }
            else

                if (quantity >= 3 && quantity <= 5)
            {
                final_price = (price - (price * 15 / 100)) * quantity;
                Console.WriteLine("Congrats you have get 15% discount :" + final_price);
            }
            else

                    if (quantity == 5)
            {
                final_price = (price - (price * 25 / 100)) * quantity;
                Console.WriteLine("Congrats you have get 25% discount :" + final_price);
            }
            

            
        }


        //constructor
        /*public ShoppingCart(int quantity)   
        {
           this.quantity= quantity;
        }*/
    }



}
