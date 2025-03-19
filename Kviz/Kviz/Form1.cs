using System.Windows.Forms;

namespace Kviz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<KerdesKontrol> kerdesek = new List<KerdesKontrol>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("jatek.csv");
            int sorom = 0;
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] elemek = sor.Split(";");
                if (elemek.Length != 6)
                {
                    continue;
                }
                string kerdes = elemek[0];
                string valasz1 = elemek[1];
                string valasz2 = elemek[2];
                string valasz3 = elemek[3];
                string valasz4 = elemek[4];
                int jovalasz = int.Parse(elemek[5]);
                KerdesKontrol KK = new KerdesKontrol(kerdes, valasz1, valasz2, valasz3, valasz4, jovalasz);
                KK.Top = sorom * KK.Height;
                kerdesek.Add(KK);
                Controls.Add(KK);
                sorom++;
            }
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int megvalaszolt = 0;
            int jovalasz = 0;
            foreach (var item in kerdesek)
            {
                if (item.valaszolt)
                {
                    megvalaszolt++;
                    if (item.jo)
                    {
                        jovalasz++;
                    }
                }
            }
            //massage
        }
        
    }
}