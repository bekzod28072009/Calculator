namespace Calculator
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

        private void button22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            txtDisplay.Text += btn.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtAnswer.Clear();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {

        }
    }
}