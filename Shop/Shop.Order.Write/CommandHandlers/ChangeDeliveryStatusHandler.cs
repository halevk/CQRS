using Shop.Order.Shared;
using Shop.Order.Shared.Events;
using Shop.Order.Write.Commands;
using Shop.Order.Write.Repositories;
using System;

namespace Shop.Order.Write.CommandHandlers
{
    public class ChangeDeliveryStatusHandler : ICommandHandler<ChangeDeliveryStatus>
    {
        IOrderRepository _orderRepository;
        IBus _bus;
        public ChangeDeliveryStatusHandler(IOrderRepository orderRepository,
            IBus bus)
        {
            _orderRepository = orderRepository;
            _bus = bus;
        }
        public void Handle(ChangeDeliveryStatus command)
        {
           var result = _orderRepository.ChangeDeliveryStatus(command.OrderId, command.NewStatus);
            if (result)
                _bus.Publish<DeliveryStatusChanged>("deliveryStatusChanged", new DeliveryStatusChanged()
                {
                    Date = DateTime.UtcNow,
                    DeliveryStatus = command.NewStatus.ToString(),
                    OrderId = command.OrderId
                });
            else
                throw new Exception(string.Format("Sipariş teslimat durumu değiştirilemedi"));
        }
    }
}
