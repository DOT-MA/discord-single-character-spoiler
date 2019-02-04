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
            richTextBox1.Text = joy;
            textBox1.Text = joy;
            Clipboard.SetText(joy);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dumbstring = dumbcase(textBox1.Text);
            richTextBox1.Text = dumbstring;
            textBox1.Text = dumbstring;
            Clipboard.SetText(dumbstring);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dumspoiler = dumbcase(textBox1.Text);
            dumspoiler = spoiler(dumspoiler);
            if (dumspoiler.Length != 0) {
                Clipboard.SetText(dumspoiler);
            }
            richTextBox1.Text = dumspoiler;
            textBox1.Text = dumspoiler;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string upndownstring = upndown(textBox1.Text);
            if (upndownstring.Length != 0)
            {
                Clipboard.SetText(upndownstring);
            }
            richTextBox1.Text = upndownstring;
            textBox1.Text = upndownstring;
        }

        public string spoiler(string input)
        {
            if (input.Length == 0)
            {
                MessageBox.Show("Please enter something");
                return "Enter something";
            }
            string joystring = "";
            if (input.Length <= 499)
            {
                foreach (char c in input)
                {
                    joystring += "||" + c + "||";
                }
            }
            else
            {
                MessageBox.Show("Message too long for discord🤡!");
            }
            return joystring;
        }

        public string dumbcase(string input)
        {
            if (input.Length == 0)
            {
                MessageBox.Show("Please enter something");
                return "Enter something";
            }

            string lowerinput = input.ToLower();
            string dum = "";
            bool uppercase = true;
            if (input.Length <= 1999)
            {
                foreach (char c in lowerinput)
                {
                    dum += uppercase ? char.ToUpper(c) : c;

                    uppercase = Char.IsWhiteSpace(c) ? uppercase : !uppercase;
                }
            }
            else
            {
                MessageBox.Show("Message too long for discord🤡!");
            }
            return dum;
        }

        public string upndown(string input)
        {
            if (input.Length == 0)
            {
                MessageBox.Show("Please enter something");
                return "Enter something";
            }
            string output = "";
            string upperoutput = input.ToUpper();
            upperoutput = upperoutput.Replace(" ", string.Empty);
            if (input.Length <= 999)
            {
                foreach (char c in upperoutput)
                {
                    output += c + " ";
                }
                //too lazy to do it any other way 
                int lazyway = 0;
                foreach (char c in upperoutput)
                {
                    if (lazyway != 0)
                    {
                        output += "\n" + c;
                    }
                    lazyway++;
                }
            }
            else
            {
                MessageBox.Show("Message too long for discord🤡!");
            }
            return output;
        }
    }
}
