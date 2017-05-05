using Shop.Order.Shared;
using Shop.Order.Shared.Events;
using Shop.Order.Write.Commands;
using Shop.Order.Write.Repositories;
using System;

namespace Shop.Order.Write.CommandHandlers
{
    public class CancelOrderHandler : ICommandHandler<CancelOrder>
    {
        IOrderRepository _orderRepository;
        IBus _bus;
        public CancelOrderHandler(IOrderRepository orderRepository,
            IBus bus)
        {
            _orderRepository = orderRepository;
            _bus = bus;
        }
        public void Handle(CancelOrder command)
        {
            var result =_orderRepository.CancelOrder(command.OrderId);
            if (result)
                _bus.Publish<OrderCancelled>("orderCancelled", new OrderCancelled()
                {
                    OrderId = command.OrderId,
                    CustomerId = command.CustomerId,
                    Date = DateTime.UtcNow,
                    OrderAmount = command.TotalAmount
                });
            else
                throw new Exception(string.Format("{0} numaralı sipariş ipral edilemedi", command.OrderId));
        }
    }
}
