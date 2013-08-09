using System;

namespace NumberWang.Engine
{
    public class George6thModel
    {
        private static readonly Random _random = new Random();

        public static string GetGeorgeThe6th()
        {
            int kingNumber = _random.Next(0, 10) <= 1 ? _random.Next(1, 9) : 6;
            return String.Format("{0} {1}", GetName(), ConvertToRoman(kingNumber));
        }

        private static string GetName()
        {
            int randy = _random.Next(0, 100);

            if (randy < 3)
            {
                return "Cuthbert";
            }
            if (randy < 10)
            {
                return "Gregory";
            }

            return "George";
        }

        private static string ConvertToRoman(int input)
        {
            switch (input)
            {
                case 1:
                    return "I";
                case 2:
                    return "II";
                case 3:
                    return "III";
                case 4:
                    return "IV";
                case 5:
                    return "V";
                case 6:
                    return "VI";
                case 7:
                    return "VII";
                case 8:
                    return "VIII";
                case 9:
                    return "IX";
                default:
                    throw new InvalidOperationException("Unknown numeral");
            }
        }
    }
}