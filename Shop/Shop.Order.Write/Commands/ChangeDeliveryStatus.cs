using Shop.Order.Shared;
using Shop.Order.Write.Domains;

namespace Shop.Order.Write.Commands
{
    public class ChangeDeliveryStatus : ICommand
    {
        public int OrderId { get; set; }
        public DeliveryStatus NewStatus { get; set; }
    }
}
