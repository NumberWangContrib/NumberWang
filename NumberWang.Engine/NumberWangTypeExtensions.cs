using System;

namespace NumberWang.Engine
{
    public static class NumberWangTypeExtensions
    {
        public static string ToWangString(this NumberWangType numberWangType)
        {
            switch (numberWangType)
            {
                case NumberWangType.IsNumberWang:
                    return "That's NumberWang!!";
                case NumberWangType.IsWangerNum:
                    return "A WangerNum!?!";
                case NumberWangType.NotNumberWang:
                    return "Not Numberwang";
                default:
                    throw new InvalidOperationException("Unknown NumberWangType");
            }
        }
    }
}