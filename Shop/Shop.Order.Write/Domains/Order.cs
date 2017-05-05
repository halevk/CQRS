using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Order.Write.Domains
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        public string DeliveryAddress { get; set; }
        public string Note { get; set; }
        public List<OrderItem> Items { get; set; }
        public PaymentInfo PaymentInfo { get; set; }
        public bool HasInvoiceIssued { get; set; }
        public DateTime InvoiceIssueDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public Order()
        {
            Date = DateTime.UtcNow;
        }
        
        public void CalculateTotalPrice()
        {
            Total = Items.Select(i => i.Price).Sum();
        }      

    }

    public enum OrderStatus
    {
        None,
        Created,
        Confirmed,
        Cancelled
    }

    public enum DeliveryStatus
    {
        None,
        Delivered,
        CustomerNotFoundInAddress,
        Refused,
        OnTheWay,
        Packing
    }
}
