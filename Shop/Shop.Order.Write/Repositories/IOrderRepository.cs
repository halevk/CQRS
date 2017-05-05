using Shop.Order.Write.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Repositories
{
    public interface IOrderRepository
    {
        bool CreateOrder(Shop.Order.Write.Domains.Order order);
        bool CancelOrder(int orderId);
        bool ChangeDeliveryStatus(int orderId, DeliveryStatus newStatus);
    }
}
