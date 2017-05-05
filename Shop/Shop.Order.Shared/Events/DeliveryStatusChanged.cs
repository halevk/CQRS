using System;

namespace Shop.Order.Shared.Events
{
    public class DeliveryStatusChanged : IEvent
    {
        public int OrderId { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime Date { get; set; }
    }
}
