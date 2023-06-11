using OOPConceptsC_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    public  class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            Item item1 = new Item { Name = "Shirt", Price = 29.99m };
            Item item2 = new Item { Name = "Jeans", Price = 49.99m };

            cart.AddItem(item1);
            cart.AddItem(item2);

            decimal totalPrice = cart.CalculateTotalPrice();
            Console.WriteLine($"Total price: {totalPrice:C}");
            Console.ReadKey();
        }
    }
}
