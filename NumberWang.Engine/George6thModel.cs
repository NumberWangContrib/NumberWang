using System;

namespace NumberWang.Engine
{
    public class George6thModel
    {
        private static readonly Random _random = new Random();

        public static string GetGeorgeThe6th()
        {
            int kingNumber = _random.Next(0, 10) <= 1 ? _random.Next(1, 8) : 6;
            return String.Format("{0} {1}{2}", GetName(), ConvertToRoman(kingNumber.ToString()), Ending(kingNumber));
        }

        private static string Ending(int kingNumber)
        {
            if (kingNumber == 1)
            {
                return "st";
            }
            if (kingNumber == 2)
            {
                return "nd";
            }
            if (kingNumber == 3)
            {
                return "rd";
            }
            return "th";
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

        private static string ConvertToRoman(string input)
        {
            int index = 0;
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                //Some magic here, this formula will calculate the correct starting
                //index of the roman literal to find in the look-up table.
                //Since units, tens and hundreds (up to thousand) can be formed of
                //three roman literals, we need three indices for looking up the
                //correct roman literal.
                index = 2*(input.Length - (i + 1)) + 1;

                char digit1 = DecimalToRoman(index);
                char digit2 = DecimalToRoman(index + 1);
                char digit3 = DecimalToRoman(index + 2);

                int originalValue = Convert.ToInt32(input[i] - '0');

                switch (originalValue)
                {
                    case 1:
                    case 2:
                    case 3:
                        for (int j = 0; j < originalValue; j++)
                            output += digit1.ToString();
                        break;
                    case 4:
                        output += digit1 + digit2;
                        break;
                    case 5:
                        output += digit2.ToString();
                        break;
                    case 6:
                    case 7:
                    case 8:
                        output += digit2.ToString();
                        for (int j = 0; j < originalValue - 5; j++)
                            output += digit1.ToString();
                        break;
                    case 9:
                        output += digit1 + digit3;
                        break;
                }
            }
            return output;
        }

        /// <summary>
        ///     Helper method that looks up a given index to it's roman value.
        /// </summary>
        /// <param name="decimalValue"></param>
        /// <returns>The roman literal corresponding to it's index</returns>
        private static char DecimalToRoman(int index)
        {
            switch (index)
            {
                case 1:
                    return 'I';
                case 2:
                    return 'V';
                case 3:
                    return 'X';
                case 4:
                    return 'L';
                case 5:
                    return 'C';
                case 6:
                    return 'D';
                case 7:
                    return 'M';
                default:
                    return ' ';
            }
        }
    }
}