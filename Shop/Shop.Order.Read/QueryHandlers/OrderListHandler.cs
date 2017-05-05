using Shop.Order.Read.QueryModels;
using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Read.QueryHandlers
{
    public class OrderListHandler : IQueryHandler<OrderList, OrderListResult>
    {
        public OrderListResult Handle(OrderList query)
        {
            return new OrderListResult();
        }
    }
}
