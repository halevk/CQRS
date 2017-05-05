using System;

namespace Shop.Order.Shared
{
    public interface IBus
    {
        void Subscribe<T>(string topic, IEventHandler<T> action) where T : IEvent;
        void Publish<T>(string topic, T eventToPublish) where T : IEvent;
    } 
}
