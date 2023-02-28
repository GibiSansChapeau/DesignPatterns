

using DesignPatterns.Observer;

namespace NaiveImplementation.Observer
{
    public class ItemValue : Observer<int, string>
    {
        public ItemValue(): base()
        {

        }

        private int _value0 = 0;
        private int _value1 = 0;

        public void Increment0()
        {
            _value0 += 1;
            NotifyListeners(0, _value0.ToString());
        }
        public void Increment1()
        {
            _value1 += 1;
            NotifyListeners(1, _value1.ToString());
        }
    }
}
