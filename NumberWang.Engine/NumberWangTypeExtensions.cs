using System;

namespace NumberWang.Engine
{
    public static class NumberWangTypeExtensions
    {
        static readonly string[] AudioFilesCorrect = { "ThatsNumberWang1.mp3", "ThatsNumberWang2.mp3" };
        static readonly string[] AudioFilesIncorrect = { "Wrong.mp3", "Wrong1.mp3", "Wrong2.mp3", "Wrong3.mp3" };
        static readonly string[] AudioFilesWangernumb = { "Wanganumb.mp3" };

        static readonly string BaseAudioFolder = "/Assets/Audio/";

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
                    return CreateRandomUriFromAudioFiles(AudioFilesCorrect);                    
                case NumberWangType.IsWangerNum:
                    return CreateRandomUriFromAudioFiles(AudioFilesWangernumb);
                case NumberWangType.NotNumberWang:
                    return CreateRandomUriFromAudioFiles(AudioFilesIncorrect);                    
                default:
                    throw new InvalidOperationException("Unknown NumberWangType");
            }
        }

        private static Uri CreateRandomUriFromAudioFiles(string[] audioFiles)
        {
            var rndm = new Random(DateTime.UtcNow.Millisecond);
            
            var filename = audioFiles[rndm.Next(audioFiles.Length)];
                        
            return new Uri(BaseAudioFolder + filename, UriKind.Relative);
        }
    }
}