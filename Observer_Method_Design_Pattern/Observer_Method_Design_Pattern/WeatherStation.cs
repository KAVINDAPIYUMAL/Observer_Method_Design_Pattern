using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Method_Design_Pattern
{
    class WeatherStation
    {
        private List<IObserver> observers = new List<IObserver>();
        private string currentWeather;

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(currentWeather);
            }
        }

        public void SetWeather(string newWeather)
        {
            currentWeather = newWeather;
            NotifyObservers();
        }
    }
}
