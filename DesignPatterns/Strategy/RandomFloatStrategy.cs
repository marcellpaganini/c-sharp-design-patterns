namespace Strategy
{
    public class RandomFloatStrategy : IRandomNumberStrategy
    {
        public object DisplayRandomNumber()
        {
            var randomNumber = new Random();
            return randomNumber.NextDouble();
        }
    }
}
