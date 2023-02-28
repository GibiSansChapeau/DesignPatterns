

using NaiveImplementation.Adapter;
using NaiveImplementation.Observer;
using NaiveImplementation.Singleton;
/**
* Adapter
*/
ISayIt hello = new SayHello();
HelloValue helloValue = new HelloValue();
Adapter adapter = new(helloValue);
hello.SayIt();
adapter.SayIt();
Console.WriteLine($"hello :: is ISayIt => {hello is ISayIt}");
Console.WriteLine($"adapter :: is ISayIt => {adapter is ISayIt}");

/**
 * Observer
 * */
ItemValue itemValue = new();
Listener listenerA = new() { Name = "A" };
Listener listenerB = new() { Name = "B" };
Listener listenerD = new() { Name = "D" };
Listener listenerC = new() { Name = "C" };
itemValue.Subscribe(0, listenerA);
itemValue.Subscribe(0, listenerB);
itemValue.Subscribe(0, listenerC);
itemValue.Subscribe(1, listenerD);
itemValue.Subscribe(1, listenerC);
itemValue.Increment0();
itemValue.Increment1();
itemValue.Unsubscribe(0, listenerB);
itemValue.Increment0();
itemValue.Increment1();

/**
 * Singleton
 * */
NaiveSingleton a = NaiveSingleton.Instance;
NaiveSingleton b = NaiveSingleton.Instance;

a.Increment();
b.Increment();
NaiveSingleton.Instance.Increment();

a.Log();
b.Log();
