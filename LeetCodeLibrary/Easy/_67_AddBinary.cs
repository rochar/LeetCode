using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace LeetCodeLibrary.Easy
{
    public class _67_AddBinary
    {
        public string AddBinary(string a, string b)
        {
            var res = ToBigInteger(a);
            var res2 = ToBigInteger(b);

            return ToBinaryString(res + res2);
        }

        private static BigInteger ToBigInteger(string base2String)
        {
            BigInteger res = 0;

            foreach (char c in base2String)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }

            return res;
        }

        /// <summary>
        ///     Converts from a BigInteger to a binary string.
        /// </summary>
        public static string ToBinaryString(BigInteger bigint)
        {
            var bytes = bigint.ToByteArray();
            var index = bytes.Length - 1;
            var base2 = new StringBuilder(bytes.Length * 8);
            //For this problem we do not want 0 in LSD
            if (bytes[index] != 0 || bytes.Length == 1)
            {
                var binary = Convert.ToString(bytes[index], 2);
                base2.Append(binary);
            }
            for (index--; index >= 0; index--)
            {
                base2.Append(Convert.ToString(bytes[index], 2).PadLeft(8, '0'));
            }
            return base2.ToString();
        }
    }
}