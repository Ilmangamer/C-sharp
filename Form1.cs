namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        string input = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((textbox_result.Text == "0") || (isOperationPerformed))
                textbox_result.Text = null;

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ",")
            {
                if (!textbox_result.Text.Contains(","))
                    textbox_result.Text = textbox_result.Text + button.Text;

            }
            else

                textbox_result.Text = textbox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equal_button.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed + labelCurrentOperation.Text;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textbox_result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }
        private void textbox_result_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void sum_button(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textbox_result.Text = (resultValue + Double.Parse(textbox_result.Text)).ToString();
                    input = string.Empty;
                    break;
                case "-":
                    textbox_result.Text = (resultValue - Double.Parse(textbox_result.Text)).ToString();
                    input = string.Empty;
                    break;
                case "x":
                    textbox_result.Text = (resultValue * Double.Parse(textbox_result.Text)).ToString();
                    input = string.Empty;
                    break;
                case "/":
                    textbox_result.Text = (resultValue / Double.Parse(textbox_result.Text)).ToString();
                    input = string.Empty;
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textbox_result.Text);
            labelCurrentOperation.Text = "";

        }
        private void button18_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textbox_result.Text = "0";

        }

        private void labelCurrentOperation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
