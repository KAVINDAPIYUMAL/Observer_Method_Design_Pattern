using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Method_Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherStation weatherStation = new WeatherStation();

            DisplayDevice mobileApp = new DisplayDevice("Mobile App");
            DisplayDevice website = new DisplayDevice("Website");
            DisplayDevice dedicatedDevice = new DisplayDevice("Dedicated Device");

            weatherStation.AddObserver(mobileApp);
            weatherStation.AddObserver(website);
            weatherStation.AddObserver(dedicatedDevice);

            weatherStation.SetWeather("Sunny"); // All displays should update
            weatherStation.SetWeather("Rainy"); // All displays should update

            Console.ReadLine();
        }
    }
}
