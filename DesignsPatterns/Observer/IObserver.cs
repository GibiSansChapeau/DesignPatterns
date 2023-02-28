using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public interface IObserver<EventType,Message>
        where EventType : IEquatable<EventType>
    {
        void NotifyListeners(EventType eventType, Message message);
        void Unsubscribe(EventType eventType, IListener<Message> listener);
        void Subscribe(EventType eventType, IListener<Message> listener);
    }
}
