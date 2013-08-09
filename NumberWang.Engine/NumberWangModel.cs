using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberWang.Engine
{
    public sealed class NumberWangModel
    {
        private readonly List<decimal> _guesses = new List<decimal>();
        private readonly Random _random = new Random();

        public NumberWangType TestNumberWang(decimal wang)
        {
            _guesses.Add(wang);

            if (_guesses.Count > 5)
            {
                _guesses.RemoveAt(0);
            }

            if (_guesses.Count(x => x == wang)%2 == 0)
            {
                return NumberWangType.NotNumberWang;
            }

            int result = _random.Next(0, 10000);

            if (result < 250)
            {
                return NumberWangType.IsWangerNum;
            }

            if (result < 1350)
            {
                return NumberWangType.IsNumberWang;
            }

            return NumberWangType.NotNumberWang;
        }
    }
}