using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord_Single_Character_Spoiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string joy = spoiler(textBox1.Text);
            label1.Text = joy;
        }
        public string spoiler(string input)
        {
            string joystring = "";
            foreach (char c in input)
            {
                joystring += "||" + c + "||";
            }
            Clipboard.SetText(joystring);
            return joystring;
        }
    }
}
