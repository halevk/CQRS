using Shop.Order.Shared;

namespace Shop.Order.Write.Commands
{
    public class CancelOrder : ICommand
    {
        public int OrderId { get; set; }        
        public decimal TotalAmount { get; set; }
        public int CustomerId { get; set; }
    }
}
