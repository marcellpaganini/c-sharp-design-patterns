namespace Strategy
{
    public class RandomNumberContext
    {
        private IRandomNumberStrategy _randomNumberStrategy;

        public RandomNumberContext() { }
        public RandomNumberContext(IRandomNumberStrategy randomNumberStrategy)
        {
            _randomNumberStrategy = randomNumberStrategy;
        }

        public void SetStrategy(IRandomNumberStrategy randomNumberStrategy)
        {
            _randomNumberStrategy = randomNumberStrategy;
        }

        public void DisplayRandomNumber()
        {
            Console.WriteLine(_randomNumberStrategy.DisplayRandomNumber().ToString());
        }
    }
}