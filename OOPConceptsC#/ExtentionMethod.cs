using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConceptsC_
{
    internal class ExtentionMethod
    {
    }

    public interface IShoppingCart
    {
        void AddItem(Item item);
        void RemoveItem(Item item);
        List<Item> GetItems();
    }

    public static class ShoppingCartExtensions
    {
        public static decimal CalculateTotalPrice(this IShoppingCart cart)
        {
            if (cart == null)
                throw new ArgumentNullException(nameof(cart));

            return cart.GetItems().Sum(item => item.Price);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ShoppingCart : IShoppingCart
    {
        private List<Item> items;

        public ShoppingCart()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"Added {item.Name} to the shopping cart.");
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
            Console.WriteLine($"Removed {item.Name} from the shopping cart.");
        }

        //public IEnumerable<Item> GetItems()
        //{
        //    return items;
        //}

        public List<Item> GetItems()
        {
            return items.ToList();
        }
    }

}
