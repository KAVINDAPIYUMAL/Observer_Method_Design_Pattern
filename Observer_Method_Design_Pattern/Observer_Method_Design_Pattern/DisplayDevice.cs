using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Method_Design_Pattern
{
    public class DisplayDevice : IObserver
    {
        private string displayLocation;

        public DisplayDevice(string location)
        {
            displayLocation = location;
        }

        public void Update(string weather)
        {
            Console.WriteLine($"Display at {displayLocation} updated. Current weather: {weather}");
        }
    }
}
