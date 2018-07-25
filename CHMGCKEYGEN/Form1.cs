using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CHMGCKEYGEN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (i % 2 == 0)
                    s += ((textBox1.Text[i].ToString()).ToUpper()) + i.ToString();
                else
                    s += ((textBox1.Text[i].ToString()).ToLower()) + i.ToString();
            }

            string s1 = s.Substring(0, 3);
            string s2 = s.Substring(1, s.Length - 3);
            string s3 = s.Substring(s.Length - 3, 3);

            string c1 = "";
            for (int i = 0; i < s1.Length; i++)
            {
                c1 += (char)((int)s1[i] +3);
            }

            string c2 = "";
            for (int i = 0; i < s2.Length; i++)
            {
                c2 += (char)((int)s2[i] + 2);
            }

            string c3 = "";
            for (int i = 0; i < s3.Length; i++)
            {
                c3+= (char)((int)s3[i] + 4);
            }

            textBox2.Text = string.Format("{0}-{1}-{2}", c1,c2,c3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c1 = textBox2.Text.Split('-')[0];
            string c2 = textBox2.Text.Split('-')[1];
            string c3 = textBox2.Text.Split('-')[2];

            string s1 = "";
            for (int i = 0; i < c1.Length; i++)
            {
                s1 += (char)((int)c1[i] - 3);
            }

            string s2 = "";
            for (int i = 0; i < c2.Length; i++)
            {
                s2 += (char)((int)c2[i] - 2);
            }

            string s3 = "";
            for (int i = 0; i < c3.Length; i++)
            {
                s3 += (char)((int)c3[i] - 4);
            }

            string s = string.Format("{0}{1}{2}", s1.Substring(0,1), s2.Substring(0, s2.Length-1), s3);
            
            textBox3.Text = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i < 20)
                {
                    if (i % 2 == 0)
                    {
                        textBox3.Text += s[i].ToString().ToUpper();
                    }
                }
                else
                {
                    textBox3.Text += s[i].ToString().ToUpper();
                    i = i + 2;
                    
                }
            }
            
        }
    }
}