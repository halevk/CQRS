using Shop.Order.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shop.Order.UI.API
{
    public class FakeBus : IBus
    {
        Dictionary<string, List<object>> broker;

        public FakeBus()
        {
            broker = new Dictionary<string, List<object>>();
        }

        public void Publish<T>(string topic, T eventToPublish) where T : IEvent
        {
            List<object> list;
            if (broker.TryGetValue(topic, out list))
                list.ForEach(itm=> 
                {
                     ((IEventHandler<T>)itm).Handle(eventToPublish);                    
                });
        }

        public void Subscribe<T>(string topic, IEventHandler<T> action) where T : IEvent
        {           
            var isTopicExists = broker.ContainsKey(topic);
            if (!isTopicExists)            
                broker.Add(topic, new List<object>() { action });
            else           
                broker[topic].Add(action);                     
        }
    }
}