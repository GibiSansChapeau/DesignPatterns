
namespace NaiveImplementation.Adapter
{
    public class Adapter : ISayIt
    {
        private HelloValue _adaptee;

        public Adapter(HelloValue adaptee)
        {
            _adaptee = adaptee;
        }

        public void SayIt()
        {
            Console.WriteLine(_adaptee.Value);
        }
    }
}
