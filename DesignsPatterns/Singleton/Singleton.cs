
namespace DesignPatterns.Singleton
{
    public class Singleton<T>
        where T : class, new()
    {
        protected static readonly object _padlock = new();
        protected static T? _instance = null;

        protected Singleton() { }

        public static T Instance
        {
            get
            {
                lock (_padlock)
                {
                    _instance ??= new();
                }
                return _instance;
            }
        }
    }
}
