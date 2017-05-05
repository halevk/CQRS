using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Shared.Events
{
    public class OrderCancelled : IEvent
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal OrderAmount { get; set; }
        public int CustomerId { get; set; }
    }
}
