namespace ProjetoQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (Convert.ToDouble(textBox1.Text)*Convert.ToDouble(textBox1.Text)).ToString();

            //double text = double.Parse(textBox1.Text);

            //double text2 = text * text;
            //string numtext = text2.ToString();
            //textBox2.Text = numtext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
