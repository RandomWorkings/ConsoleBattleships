using System;

namespace BattleshipsNS
{
    public class RandomGenerator : IValueGenerators
    {
        private static readonly Random Rand = new Random();
        private static readonly object Synclock = new object();

        public int GetRandomInt(int limit)
        {
            lock (Synclock)
            {
                return Rand.Next(0, limit);
            }
        }

        public (int, int) GetRandomTuple(int leftLimit, int rightLimit)
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