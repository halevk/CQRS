using Shop.Order.Read.QueryModels;
using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Read.QueryHandlers
{
    public class OrderSummaryHandler : IQueryHandler<OrderSummaryList, OrderSummaryListResult>
    {
        public OrderSummaryListResult Handle(OrderSummaryList query)
        {
            return new OrderSummaryListResult();
        }
    }
}
