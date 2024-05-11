namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstNum, secondNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value))
                txtDisplay.Text = "";
            enter_value = false;

            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                    txtDisplay.Text = txtDisplay.Text + ",";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + b.Text;
            }
        }

        private void operations_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                equalBtn.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblShowOps.Text = result + " " + operation;
            }
            else
            {
                operation = b.Text;
                result = double.Parse(txtDisplay.Text);
                enter_value = true;
                lblShowOps.Text = result + " " + operation;
                txtDisplay.Text = "";
            }
            firstNum = lblShowOps.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblShowOps.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;

        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            secondNum = txtDisplay.Text;
            lblShowOps.Text = "";
            switch (operation)
            {
                case "+":
                    {
                        txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "-":
                    {
                        txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "*":
                    {
                        txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                case "/":
                    {
                        txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            result = Double.Parse(txtDisplay.Text);
            operation = "";
            //---------------------------------------------------------

            btnClearHistory.Visible = true;
            rtDisplayHistory.AppendText(firstNum + "   " + secondNum + " =  " + "\n");
            rtDisplayHistory.AppendText("\n\t" + txtDisplay.Text + "\n\n");
            lblHistoryDisplay.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
        }

        private void rtDisplayHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearHistory_Click_1(object sender, EventArgs e)
        {
            rtDisplayHistory.Clear();
            if (lblHistoryDisplay.Text == "")
            {
                lblHistoryDisplay.Text = "There`s no history";
            }
            btnClearHistory.Visible = false;
            rtDisplayHistory.ScrollBars = 0;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}