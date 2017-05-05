using Shop.Order.Shared;
using Shop.Order.Shared.Events;

namespace Shop.Order.Read.EventHandlers
{
    public class OrderCreatedHandler : IEventHandler<OrderCreated>
    {
        public void Handle(OrderCreated @event)
        {
            // sipariş özetlerine kayıt girilecek
        }
    }
}
