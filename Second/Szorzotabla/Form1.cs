namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool siker = int.TryParse(textBox1.Text, out int x);
            if (!siker)
            {
                textBox1.BackColor = Color.Salmon;
                return;
            }
            textBox1.BackColor = Color.White;
            int szamom = int.Parse(textBox1.Text);

            int meret = 40;
            for (int i = 1; i <= szamom; i++)
            {
                for (int j = 1; j <= szamom; j++)
                {
                    Button b = new Button();
                    b.Left = i * meret;
                    b.Top = j * meret;
                    b.Height = meret;
                    b.Width = meret;
                    int szam = i * j;

                    b.Text = szam.ToString();
                    Controls.Add(b);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}