using Shop.Order.Shared;
using System;
using System.Collections.Generic;

namespace Shop.Order.Read.QueryModels
{
    public class OrderListResult : IQueryResult
    {
        public int TotalCount { get; set; }
        public List<OrderListResultItem> Items { get; set; }
    }

    public class OrderListResultItem
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public string DeliveryAddress { get; set; }
        public string OrderStatus { get; set; }
        public string DeliveryStatus { get; set; }
        public bool IsInvoiceIssued { get; set; }
        public string InvoiceNumber { get; set; }
        public string PaidBy { get; set; }
        public string PaidWith { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItemDetail> Items { get; set; }

    }

    public class OrderItemDetail
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
