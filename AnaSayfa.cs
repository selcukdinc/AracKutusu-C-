using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KarakterDonusum
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox2, textBox1);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox2, textBox1);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Fn.TextBDeg(textBox1, textBox2);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox2.Text = Convert.ToString((char)Convert.ToDouble(0+textBox1.Text));
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            textBox1.Text = "";
            textBox2.Text = "";
            int ascii = e.KeyValue;
            textBox1.Text = Convert.ToString(ascii);
        }

        private void textBGirdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBSyc.Text = Convert.ToString(textBGirdi.TextLength);
        }
    }
}
