using DesignPatterns.Observer;

namespace NaiveImplementation.Observer
{
    public class Listener : IListener<string>
    {
        public string Name { get; set; }
        public void Update(string message)
        {
            Console.WriteLine($"{Name} - {message}");
        }
    }
}
