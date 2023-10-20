using Observer.Interfaces;

namespace Observer
{
    public class AlarmLevelObserver : IObserver
    {
        public void Update(IObservable observable)
        {
            if (((ERBObservable)observable).Alarm.Contains("Green"))
            {
                Console.WriteLine("Alarm Level: Operational");
            }
            else if (((ERBObservable)observable).Alarm.Contains("Orange"))
            {
                Console.WriteLine("Alarm Level: Warning");
            }
            else
            {
                Console.WriteLine("Alarm Level: Failure");
            }
        }
    }
}
