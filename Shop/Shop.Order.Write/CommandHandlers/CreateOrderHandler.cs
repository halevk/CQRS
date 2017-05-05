using Shop.Order.Shared;
using Shop.Order.Shared.Events;
using Shop.Order.Write.Commands;
using Shop.Order.Write.Errors;
using Shop.Order.Write.Repositories;
using Shop.Order.Write.Services;
using System;
using System.Collections.Generic;

namespace Shop.Order.Write.CommandHandlers
{
    class CreateOrderHandler : ICommandHandler<CreateOrder>
    {
        ICustomerCreditService _customerCreditService;
        IOrderRepository _orderRepository;
        IBus _bus;

        public CreateOrderHandler(
            ICustomerCreditService customerCreditService,
            IOrderRepository orderRepository,
            IBus bus)
        {
            _customerCreditService = customerCreditService;
            _orderRepository = orderRepository;
            _bus = bus;
        }

        public void Handle(CreateOrder command)
        {
            var order = new Shop.Order.Write.Domains.Order()
            {
                CustomerId = command.CustomerId,
                Note = command.Note,
                DeliveryAddress = command.DeliveryAddress,
                Items = new List<Domains.OrderItem>()
            };
            command.Items.ForEach(itm=> 
            {
                order.Items.Add(new Domains.OrderItem()
                {
                    Name = itm.Name,
                    Price = itm.Price,
                    Quantity = itm.Quantity
                });
            });

            order.CustomerName = _customerCreditService.GetCustomerName(command.CustomerId);           
            order.CalculateTotalPrice();

            var creditLimit = _customerCreditService.GetCustomerCreditLimit(command.CustomerId);
            if (order.Total > creditLimit)
                throw new CreditLimitExceedException("Siparişiniz size tanımlanan kredi limitini aşmaktadır");

            var result =_orderRepository.CreateOrder(order);
            if (result)
                _bus.Publish<OrderCreated>("orderCreated", new OrderCreated()
                {
                    Date = order.Date,
                    OrderId = order.OrderId,
                    TotalAmount = order.Total
                });
            else
                throw new Exception("sipariş kaydedilirken bir sorun meydana geldi");

        }
    }
}
