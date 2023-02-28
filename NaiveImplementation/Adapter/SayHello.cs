using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaiveImplementation.Adapter
{
    public class SayHello : ISayIt
    {
        public void SayIt()
        {
            Console.WriteLine("Hello");
        }
    }
}
