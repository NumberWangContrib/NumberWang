using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberWang.Engine
{
    public sealed class NumberWangModel
    {
        private readonly List<decimal> _guesses = new List<decimal>();
        private readonly Random _random = new Random();

        public bool IsNumberWang(decimal wang)
        {
            _guesses.Add(wang);

            if (_guesses.Count > 5)
            {
                _guesses.RemoveAt(0);
            }

            if (_guesses.Count(x => x == wang) % 2 == 0)
            {
                return false;
            }

            bool result = _random.Next(0, 1000) < 132;

            return result;
        }
    }
}