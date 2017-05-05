using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Read.QueryModels
{
    public class OrderSummaryListResult : IQueryResult
    {
        public int TotalCount { get; set; }
        public List<OrderSummaryListResultItem> Items { get; set; }

    }

    public class OrderSummaryListResultItem
    {
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public int OrderId { get; set; }

    }


}
