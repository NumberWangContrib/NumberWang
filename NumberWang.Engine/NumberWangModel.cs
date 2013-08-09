using System;
using System.Collections.Generic;

namespace NumberWang.Engine
{
    public sealed class NumberWangModel
    {
        private readonly List<decimal> _guesses = new List<decimal>();
        private readonly Random _random = new Random();

        public bool IsNumberWang(decimal wang)
        {
            try
            {
                if (_guesses.Count > 5)
                {
                    _guesses.RemoveAt(0);
                }

                if (_guesses.Contains(wang))
                {
                    return false;
                }

                return _random.Next(0, 1000) < 132;
            }
            finally
            {
                _guesses.Add(wang);
            }
        }
    }
}