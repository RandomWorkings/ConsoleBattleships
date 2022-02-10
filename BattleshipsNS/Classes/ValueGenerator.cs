using System;

namespace BattleshipsNS
{
    public class ValueGenerator : IValueGenerator
    {
        private static readonly Random Rand = new Random();
        private static readonly object Synclock = new object();

        public int GetRandomInt()
        {
            lock (Synclock)
            {
                return Rand.Next();
            }
        }
        public int GetRandomInt(int rangeLimit)
        {
            lock (Synclock)
            {
                return Rand.Next(0, rangeLimit);
            }
        }

        public (int, int) GetRandomTuple()
        {
            lock (Synclock)
            {
                int left = Rand.Next();
                int right = Rand.Next();
                return (left, right);
            }
        }

        public (int, int) GetRandomTuple(int rangeLimitItem1, int rangeLimitItem2)
        {
            lock (Synclock)
            {
                int left = Rand.Next(0, rangeLimitItem1);
                int right = Rand.Next(0, rangeLimitItem2);
                return (left, right);
            }
        }
    }
}