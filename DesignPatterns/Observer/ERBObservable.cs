using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Interfaces;

namespace Observer
{
    public class ERBObservable : IObservable
    {
        public string Alarm { get; set; } = String.Empty;
        private List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void Add(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in Observers)
            {
                observer.Update(this);
            }
        }

        public string SimulateAlarmLevelChange()
        {
            List<string> alarms = new List<string> { "Green - RF", "Orange - RF", "Red - RF", "Green - Transmission", "Orange - Transmission", "Red - Transmission" };
            
            Random randomAlarm = new Random();
            int firstAlarmIndex = randomAlarm.Next(alarms.Count);

            Alarm = alarms[firstAlarmIndex];
            
            Thread.Sleep(2000);
            this.Notify();

            int secondAlarmIndex = randomAlarm.Next(alarms.Count);

            Alarm = alarms[secondAlarmIndex];

            Thread.Sleep(2000);
            this.Notify();

            return Alarm; 
        }
    }
}
