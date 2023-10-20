namespace Observer.Interfaces
{
    public interface IObservable
    {
        public void Add(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}
