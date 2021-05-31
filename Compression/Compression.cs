using System;
using System.Linq;
using System.Text;

namespace Compression
{
    public static class Compression
    {
        private static int CalculateLenghtNewString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }

            int lenght = 0;
            int count = 1;
            char lastSymbol = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (lastSymbol == str[i])
                {
                    count++;
                }
                else
                {
                    lenght += 1 + (int) Math.Log10(count) + 1;
                    lastSymbol = str[i];
                    count = 1;
                }
            }

            return lenght;
        }

        public static string CompressionString(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException();
            }

            int lenght = CalculateLenghtNewString(str);

            if (lenght >= str.Length)
            {
                return str;
            }

            StringBuilder resultString = new StringBuilder(lenght);
            int count = 1;
            char lastSymbol = str[0];

            for (int i = 1; i < str.Length; i++)
            {
                if (lastSymbol == str[i])
                {
                    count++;
                }
                else
                {
                    resultString.Append(lastSymbol);
                    resultString.Append(count);
                    lastSymbol = str[i];
                    count = 1;
                }
            }

            resultString.Append(lastSymbol);
            resultString.Append(count);
            return resultString.ToString();
        }
    }
}