using Shop.Order.Read.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Order.Read.QueryModels;

namespace Shop.Order.Read.Data
{
    public class FakeOrderInfoRepository : IOrderInfoRepository
    {
        public OrderListResult GetOrderList()
        {
            return new OrderListResult()
            {
                TotalCount = 1,
                Items = new List<OrderListResultItem>()
                 {
                      new OrderListResultItem() {
                          CustomerName ="John Doe",
                          DeliveryAddress ="Charlston Road 2LK3W Houston, Texas",
                           Date=DateTime.UtcNow,
                            DeliveryStatus= "Packing",
                             InvoiceNumber="",
                              IsInvoiceIssued=false,
                               OrderId=1054,
                                OrderStatus="Confirmed",
                                 PaidBy="John Doe",
                                  PaidWith="Credit Card",
                                  TotalAmount=4500,
                                  Items=new List<OrderItemDetail> {
                                       new OrderItemDetail() {Name= "LCD LED TV",Price= 1500, Quantity=1 },
                                       new OrderItemDetail() {Name= "Samsung Frigde",Price=3000, Quantity=1 }
                                  }
                      }
                 }
            };
        }
    }
}
