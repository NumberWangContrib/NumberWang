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
            var rndm = new Random(DateTime.UtcNow.Millisecond);

            switch (numberWangType)
            {
                case NumberWangType.IsNumberWang:
                    if (rndm.Next(2) == 1)
                        return new Uri("/Assets/Audio/ThatsNumberWang1.mp3", UriKind.Relative);
                    else
                        return new Uri("/Assets/Audio/ThatsNumberWang2.mp3", UriKind.Relative);
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