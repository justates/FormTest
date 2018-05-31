using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFunc;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            uint tb1 = Convert.ToUInt32(textBox1.Text);
            resulttext.Text = converttime.convertut(tb1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint tb1 = Convert.ToUInt32(textBox1.Text);

            resulttext.Text = converttime.convertut(tb1);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TipText.Hide();
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
                TipText.Hide();
            }
            else
            {
                e.Handled = true;
                TipText.Show();
                TipText.Text = "invalid number!";
                TipText.ForeColor = Color.Red;
            }
        }

        private void ConverBtn_Click(object sender, EventArgs e)
        {
            HEX2GBK_Result.Hide();
            string strutf8 = HEXOri.Text;
            if (strutf8.Length == 0)
            {
                LabelTest.LabelRed(HEX2GBK_Result, "invalid string");
            }
            else if (strutf8.Length % 2 != 0)
            {
                LabelTest.LabelRed(HEX2GBK_Result, "invalid length");
            }
            else
            {
                GBKResult.Text = ConvertChar.HEX2GBK(strutf8);
            }
        }

        private void GBK2HEXBtn_Click(object sender, EventArgs e)
        {
            GBK2HEX_Result.Hide();
            string strgbk = GBKOri.Text;
            if (strgbk.Length == 0)
            {
                LabelTest.LabelRed(GBK2HEX_Result, "invalid length");
            }

            else
            {
                byte[] returnBytes = Encoding.GetEncoding("GBK").GetBytes(strgbk);
                string Hex = null;
                for (int i = 0; i < returnBytes.Length; i++)
                {
                    Hex = Hex + Convert.ToString(returnBytes[i], 16);
                }
                HEXResult.Text = ConvertChar.GBK2HEX(strgbk);
            }
        }
    }
}
