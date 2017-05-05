using Shop.Order.Read.Data;
using Shop.Order.Read.EventHandlers;
using Shop.Order.Read.Repositories;
using Shop.Order.Shared;
using Shop.Order.Shared.Events;
using Shop.Order.Write.Data;
using Shop.Order.Write.ExternalServices;
using Shop.Order.Write.Repositories;
using Shop.Order.Write.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Shop.Order.UI.API
{
    public class ContainerRegistry  
    {        
        public static IServiceProvider Register()
        {
            var container = new SimpleInjector.Container();

            var bus = new FakeBus();
            bus.Subscribe<OrderCreated>("orderCreated", new OrderCreatedHandler());           
            container.RegisterSingleton(typeof(IBus), bus);

            container.Register<IOrderRepository, FakeOrderRepository>();
            container.Register<IOrderInfoRepository, FakeOrderInfoRepository>();
            container.Register<ICustomerCreditService, FakeCustomerCreditService>();
            container.Register(typeof(ICommandHandler<>), GetAsm("Shop.Order.Write"));
            container.Register(typeof(IQueryHandler<,>), GetAsm("Shop.Order.Read"));
            container.Register(typeof(IEventHandler<>), GetAsm("Shop.Order.Read"));          

            return container;           
        }

        
      
        private static IEnumerable<Assembly> GetAsm(string asmName)
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .Where(i => i.FullName.Contains(asmName));                
        }                
    }
}