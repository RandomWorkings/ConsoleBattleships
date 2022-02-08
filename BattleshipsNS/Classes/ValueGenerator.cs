using System;

namespace BattleshipsNS
{
    public class ValueGenerator : IValueGenerator
    {
        private static readonly Random Rand = new Random();
        private static readonly object Synclock = new object();

        public int GetRandomInt(int limitInclusive)
        {
            int limitExclusive = limitInclusive + 1;

            lock (Synclock)
            {
                return Rand.Next(1, limitExclusive);
            }
        }

        public (int, int) GetRandomTuple(int leftLimitInclusive, int rightLimitInclusive)
        {          
            lock (Synclock)
            {
                int left = Rand.Next(0, leftLimit);
                int right = Rand.Next(0, rightLimit);
                return (left, right);
            }
        }
    }
}