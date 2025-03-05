namespace Third
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool siker = int.TryParse(textBox1.Text, out int ertek);
            if (!siker)
            {
                textBox1.BackColor = Color.Salmon;
            }
            else
            {
                textBox1.BackColor = Color.BlueViolet;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool succes = int.TryParse(textBox1.Text, out int meret);
            Random random = new Random(0);
            for (int sor = 0; sor < meret; sor++)
            {
                for (int oszlop = 0; oszlop < meret; oszlop++)
                {
                    //crt + k crt + d igazitas
                    VillogoGomb b = new VillogoGomb();
                    b.Left = oszlop * 20;
                    b.Top = sor * 20;
                    b.Height = 20;
                    b.Width = 20;
                    //b.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                    Controls.Add(b);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Height = 100;
            button.Width = 100;
            button.Left = ClientRectangle.Width / 2-50;
            button.Top = ClientRectangle.Height / 2-50;
            Controls.Add(button);
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Gomb gb = new Gomb();
                    gb.Left = i * 50;
                    gb.Top = j * 50;
                    gb.Height = 50;
                    gb.Width = 50;
                    gb.Text = (i * j).ToString();
                    Controls.Add(gb);
                }
            }
            SzamoloGomb gomb = new SzamoloGomb();
            Controls.Add(gomb);

        }
    }
}