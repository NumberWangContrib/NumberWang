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

        public static Uri ToWangAudioFile(this NumberWangType numberWangType)
        {
            switch (numberWangType)
            {
                case NumberWangType.IsNumberWang:
                    return new Uri("/Assets/Audio/ThatsNumberWang1.mp3", UriKind.Relative);
                case NumberWangType.IsWangerNum:
                    return null; // TODO get more sound effects!
                case NumberWangType.NotNumberWang:
                    return null;
                default:
                    throw new InvalidOperationException("Unknown NumberWangType");
            }
        }
    }
}