using DesignPatterns.Singleton;

namespace NaiveImplementation.Singleton
{
    public class NaiveSingleton : Singleton<NaiveSingleton>
    {
        public NaiveSingleton() : base()
        {
            Value = 0;
        }

        public int Value { get; set; }

        public void Increment()
        {
            Value++;
        }

        public void Log()
        {
            Console.WriteLine(Value);
        }
    }
}
