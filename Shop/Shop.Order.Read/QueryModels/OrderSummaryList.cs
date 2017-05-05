using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Read.QueryModels
{
    public class OrderSummaryList : IQuery
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int CustomerId { get; set; }
    }
}
