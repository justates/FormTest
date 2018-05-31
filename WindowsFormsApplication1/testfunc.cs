using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Text;

namespace TestFunc
{
    class converttime
    {
        private static string pluszero(string str)
        {
            if (str.Length == 1)
            {
                return "0" + str;
            }
            else
            {
                return str;
            }
        }
        public static string convertut(uint date)
        {

            string year = (((date >> 26) & 0x3f)).ToString();
            string mon = (((date >> 22) & 0xf) + 1).ToString();
            string day = ((date >> 17) & 0x1f).ToString();
            string hour = ((date >> 12) & 0x1f).ToString();
            string min = ((date >> 6) & 0x3f).ToString();
            string sec = (date & 0x3f).ToString();
            return pluszero(year) + pluszero(mon) + pluszero(day) + pluszero(hour) + pluszero(min) + pluszero(sec);
        }
        private static string datecheck(string s)
        {
            if (s.Length == 0)
            {
                return "null string";
            }
            else
            {
                return s;
            }
        }
    }

    class LabelTest
    {
        public static void LabelRed(Label TB, string str)
        {
            TB.Text = str;
            TB.ForeColor = Color.Red;
            TB.Show();
        }
    }

    class ConvertChar
    {
        public static string HEX2GBK(string HEXstr)
        {
            byte[] returnBytes = new byte[HEXstr.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
            {
                returnBytes[i] = Convert.ToByte(HEXstr.Substring(i * 2, 2), 16);
            }
            string GBKResultString = Encoding.GetEncoding("GBK").GetString(returnBytes);
            return GBKResultString;
        }
        public static string GBK2HEX(string GBKstr)
        {
            byte[] returnBytes = Encoding.GetEncoding("GBK").GetBytes(GBKstr);
            string Hex = null;
            for (int i = 0; i < returnBytes.Length; i++)
            {
                Hex = Hex + Convert.ToString(returnBytes[i], 16);
            }
            return Hex;
        }
    }

}

