using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public abstract class Observer<EventType,Message> : IObserver<EventType,Message>
        where EventType : IEquatable<EventType>
    {
        protected Dictionary<EventType, List<IListener<Message>>> Listeners { get; } = new Dictionary<EventType, List<IListener<Message>>>();
        public void Subscribe(EventType eventType, IListener<Message> listener)
        {
            if (!Listeners.ContainsKey(eventType))
            {
                Listeners.Add(eventType, new List<IListener<Message>>());
            }
            Listeners[eventType].Add(listener);
        }
        public void Unsubscribe(EventType eventType, IListener<Message> listener)
        {
            if (Listeners.ContainsKey(eventType)
                && Listeners[eventType].Contains(listener))
            {
                Listeners[eventType].Remove(listener);
            }
        }
        public void NotifyListeners(EventType eventType, Message message)
        {
            if (Listeners.TryGetValue(eventType, out List<IListener<Message>>? listeners))
            {
                foreach (IListener<Message> listener in listeners) listener.Update(message);
            }
        }
    }
}
