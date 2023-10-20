using Observer.Interfaces;

namespace Observer
{
    public class AlarmClassObserver : IObserver
    {
        public void Update(IObservable observable)
        {
            if (((ERBObservable)observable).Alarm.Contains("RF"))
            {
                Console.WriteLine("Alarm Class: Radio Frequence");
            }
            else
            {
                Console.WriteLine("Alarm Class: Transmission");
            }
        }
    }
}
