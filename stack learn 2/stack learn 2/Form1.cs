using System;
using System.Collections;
namespace stack_learn_2
{
    public partial class Form1 : Form
    {
        Stack<string> st = new Stack<string>();
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
            {
                st.Push("1");
                st.Push("2");


                foreach (string i in st)
                {
                    label1.Text = label1.Text + "\r\n" + i;


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                foreach (string i in st)
                {
                    label1.Text = label1.Text + "\r\n" + i;


                }
            }
        }
    }
}