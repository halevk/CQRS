using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Commands
{
    public class CreateOrder : ICommand
    {
        public int CustomerId { get; set; }
        public string DeliveryAddress { get; set; }
        public string Note { get; set; }
        public List<CartItem> Items { get; set; }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
