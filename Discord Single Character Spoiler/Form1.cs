﻿using System;
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
                Clipboard.SetText(joystring);
            }
            else
            {
                MessageBox.Show("Message too long for discord🤡!");
            }
            return joystring;
        }

        public string dumbcase(string input)
        {
            if(input.Length == 0)
            {
                MessageBox.Show("Please enter something");
                return "Enter something";
            }

            string lowerinput = input.ToLower();
            string dum = "";
            bool uppercase = true;
            if(input.Length <= 1999) {
                foreach (char c in lowerinput)
                {
                    dum += uppercase ? char.ToUpper(c) : c;

                    uppercase = Char.IsWhiteSpace(c) ? uppercase : !uppercase;
                }
                Clipboard.SetText(dum);
            }
            else
            {
                MessageBox.Show("Message too long for discord🤡!");
            }
            return dum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dumbstring = dumbcase(textBox1.Text);
            richTextBox1.Text = dumbstring;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dumspoiler = dumbcase(textBox1.Text);
            dumspoiler = spoiler(dumspoiler);
            if (dumspoiler == null) {
                Clipboard.SetText(dumspoiler);
            }
            richTextBox1.Text = dumspoiler;
        }
    }
}
