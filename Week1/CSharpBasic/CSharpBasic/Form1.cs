using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "bool";
            textBox2.Text = sizeof(bool).ToString();
            textBox3.Text = bool.FalseString.ToString();
            textBox4.Text = bool.TrueString.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "char";
            textBox2.Text = sizeof(char).ToString();
            textBox3.Text = (char.MinValue - '\0').ToString();
            textBox4.Text = (char.MaxValue - '\0').ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "unsigned int 16 bit";
            textBox2.Text = sizeof(UInt16).ToString();
            textBox3.Text = (uint.MinValue - '\0').ToString();
            textBox4.Text = (uint.MaxValue - '\0').ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Sbyte";
            textBox2.Text = sizeof(SByte).ToString();
            textBox3.Text = sbyte.MinValue.ToString();
            textBox4.Text = sbyte.MaxValue.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Long";
            textBox2.Text = sizeof(long).ToString();
            textBox3.Text = long.MinValue.ToString();
            textBox4.Text = long.MaxValue.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "float";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = float.MinValue.ToString();
            textBox4.Text = float.MaxValue.ToString();

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Ulong";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = ulong.MinValue.ToString();
            textBox4.Text = ulong.MaxValue.ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Short";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = short.MinValue.ToString();
            textBox4.Text = short.MaxValue.ToString();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Ushort";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = ushort.MinValue.ToString();
            textBox4.Text = ushort.MaxValue.ToString();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "byte";
            textBox2.Text = sizeof(byte).ToString();
            textBox3.Text = byte.MinValue.ToString();
            textBox4.Text = byte.MaxValue.ToString();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "Int";
            textBox2.Text = sizeof(float).ToString();
            textBox3.Text = int.MinValue.ToString();
            textBox4.Text = int.MaxValue.ToString();
        }
    }
}
