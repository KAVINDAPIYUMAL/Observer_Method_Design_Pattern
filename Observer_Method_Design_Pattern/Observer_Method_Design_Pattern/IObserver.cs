using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Method_Design_Pattern
{
    public interface IObserver
    {
        void Update(string weather);
    }
}
