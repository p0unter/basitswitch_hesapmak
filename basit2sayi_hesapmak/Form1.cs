using System.Linq.Expressions;

namespace basit2sayi_hesapmak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;
            string islem;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            islem = textBox3.Text;
            switch (islem) 
            {
                case "+": label3.Text = Convert.ToString(sayi1 + sayi2); break;
                case "-": label3.Text = Convert.ToString(sayi1 - sayi2); break;
                case "*": label3.Text = Convert.ToString(sayi1 * sayi2); break;
                case "/": label3.Text = Convert.ToString(sayi1 / sayi2); break;
            }
        }
    }
}