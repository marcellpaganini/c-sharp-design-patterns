namespace Strategy
{
    public class RandomIntegerStrategy : IRandomNumberStrategy
    {   
        public object DisplayRandomNumber()
        {
            var randomNumber = new Random();
            return randomNumber.Next();
        }
    }
}
