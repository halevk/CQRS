using Shop.Order.Read.QueryModels;
using Shop.Order.Write.Commands;
using System;
using System.Web.Http;

namespace Shop.Order.UI.API.Controllers
{
    public class OrderController : BaseApiController
    {        
        [Route("api/order/create")]
        [HttpPost]
        public string CreateOrder(CreateOrder order)
        {
            var handler = GetCommandHandler<CreateOrder>();
            try
            {
                handler.Handle(order);
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        [Route("api/order/cancel")]
        [HttpPost]
        public string CancelOrder(CancelOrder cancelOrder)
        {
            var handler = GetCommandHandler<CancelOrder>();
            try
            {
                handler.Handle(cancelOrder);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        [Route("api/order/change-delivery-status")]
        [HttpPost]
        public string ChangeDeliveryStatus(ChangeDeliveryStatus newStatus)
        {
            var handler = GetCommandHandler<ChangeDeliveryStatus>();
            try
            {
                handler.Handle(newStatus);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        [Route("api/order/list")]
        [HttpGet]
        public string OrderList(OrderList newStatus)
        {
            var handler = GetQueryHandler<OrderList,OrderListResult>();
            try
            {
                handler.Handle(newStatus);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }

        [Route("api/order/list-summary")]
        [HttpGet]
        public string OrderSummaryList(OrderSummaryList query)
        {
            var handler = GetQueryHandler<OrderSummaryList, OrderSummaryListResult>();
            try
            {
                handler.Handle(query);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "ok";
        }
    }
}
