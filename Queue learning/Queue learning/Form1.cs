using System.Collections;
namespace Queue_learning
{
    public partial class Form1 : Form

    {
        Queue my_qu = new Queue();
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

            my_qu.Enqueue("Subscribe");
            my_qu.Enqueue("To");
            my_qu.Enqueue("Channel");

            foreach (string i in my_qu)
            {
                label1.Text = label1.Text + "\r\n" + i;


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                foreach (string i in my_qu)
                {
                    label1.Text = label1.Text + "\r\n" + i;


                }

            }
        }
    }
}