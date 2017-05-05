using Shop.Order.Write.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Order.Write.Domains;

namespace Shop.Order.Write.Data
{
    public class FakeOrderRepository : IOrderRepository
    {
        static List<Shop.Order.Write.Domains.Order> db = new List<Domains.Order>();
        
      
        public bool CancelOrder(int orderId)
        {
            var order = db.FirstOrDefault(i => i.OrderId == orderId);            
            order.OrderStatus = OrderStatus.Cancelled;
            return true;
        }

        public bool ChangeDeliveryStatus(int orderId, DeliveryStatus newStatus)
        {
            var order = db.FirstOrDefault(i => i.OrderId == orderId);
            order.DeliveryStatus = newStatus;
            return true;            
        }

        public bool CreateOrder(Domains.Order order)
        {
            db.Add(order);
            return true;
        }
    }
}
