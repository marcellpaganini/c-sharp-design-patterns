namespace Observer.Interfaces
{
    public interface IObserver
    {
        public void Update(IObservable observable);
    }
}
