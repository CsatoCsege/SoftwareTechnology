using System;

namespace gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Button Gomb = new Button();
            Gomb.Top = (ClientRectangle.Height / 2)-10;
            Gomb.Left = (ClientRectangle.Width / 2)-10;
            Gomb.Width = 20;
            Gomb.Height = 20;
            Controls.Add(Gomb);
            Gomb.BackColor = Color.Fuchsia;
            */

            /*
            for (int i = 1; i < 11; i++)
            {
                for (int  j = 1;  j < 11;  j++)
                {
                    SzinezodoGomb button = new SzinezodoGomb();
                    button.Top = 40 * j;
                    button.Left = 40 * i;
                    button.Width = 40;
                    button.Height = 40;
                    button.Text = (i * j).ToString();
                    Controls.Add(button);
                }
                
            }
            */

            /*
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    SzamoloGomb button = new SzamoloGomb();
                    button.Top = 40 * j;
                    button.Left = 40 * i;
                    button.Width = 40;
                    button.Height = 40;
                    Controls.Add(button);
                }
            }
            */

            /*
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Button RandomGomb = new Button();
                RandomGomb.Height = 40;
                RandomGomb.Width = 40;
                RandomGomb.Top = random.Next(0,ClientRectangle.Height-40);
                RandomGomb.Left = random.Next(0,ClientRectangle.Width-40);
                RandomGomb.BackColor = Color.FromArgb(random.Next(0,255), random.Next(0,255), random.Next(0, 255));
                Controls.Add(RandomGomb);
            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SzinezodoGomb button = new SzinezodoGomb();
                    button.Top = 40 * j;
                    button.Left = 40 * i;
                    button.Width = 40;
                    button.Height = 40;
                    if (j >= i)
                    {
                        Controls.Add(button);
                    }
                    
                }
            }
            */

            /*
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    KaracsonyGomb button = new KaracsonyGomb();
                    button.Top = 40 * i;
                    button.Left = ClientRectangle.Width/2 - ((i+1)*20)+j*40;
                    button.Width = 40;
                    button.Height = 40;
                    Controls.Add(button);
                }
            }
            */

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    KaracsonyGomb button = new KaracsonyGomb();
                    button.Top = 40 * i;
                    button.Left = ClientRectangle.Width / 2 - ((i + 1) * 20) + j * 40;
                    button.Width = 40;
                    button.Height = 40;
                    Controls.Add(button);
                    List<Color> excludedColors = new List<Color>
            {
                Color.FromArgb(136, 8, 8),
                Color.FromArgb(170, 74, 68),
                Color.FromArgb(238, 75, 43),
                Color.FromArgb(165, 42, 42),
                Color.FromArgb(128, 0, 32),
                Color.FromArgb(110, 38, 14),
                Color.FromArgb(204, 85, 0),
                Color.FromArgb(233, 116, 81),
                Color.FromArgb(112, 41, 99),
                Color.FromArgb(210, 43, 43),
                Color.FromArgb(196, 30, 58),
                Color.FromArgb(215, 0, 64),
                Color.FromArgb(222, 49, 99),
                Color.FromArgb(210, 4, 45),
                Color.FromArgb(149, 69, 53),
                Color.FromArgb(129, 19, 49),
                Color.FromArgb(248, 131, 121),
                Color.FromArgb(129, 65, 65),
                Color.FromArgb(220, 20, 60),
                Color.FromArgb(139, 0, 0),
                Color.FromArgb(123, 24, 24),
                Color.FromArgb(154, 42, 42),
                Color.FromArgb(192, 64, 0),
                Color.FromArgb(128, 0, 0),
                Color.FromArgb(152, 104, 104),
                Color.FromArgb(119, 7, 55),
                Color.FromArgb(74, 4, 4),
                Color.FromArgb(250, 160, 160),
                Color.FromArgb(236, 88, 0),
                Color.FromArgb(227, 83, 53),
                Color.FromArgb(169, 92, 104),
                Color.FromArgb(227, 11, 92),
                Color.FromArgb(255, 0, 0),
                Color.FromArgb(165, 42, 42),
                Color.FromArgb(145, 56, 49),
                Color.FromArgb(255, 68, 51),
                Color.FromArgb(149, 53, 83),
                Color.FromArgb(194, 30, 86),
                Color.FromArgb(224, 17, 95),
                Color.FromArgb(128, 70, 27),
                Color.FromArgb(250, 128, 114),
                Color.FromArgb(255, 36, 0),
                Color.FromArgb(250, 95, 85),
                Color.FromArgb(227, 115, 94),
                Color.FromArgb(124, 48, 48),
                Color.FromArgb(99, 3, 48),
                Color.FromArgb(164, 42, 4),
                Color.FromArgb(227, 66, 52),
                Color.FromArgb(114, 47, 55),
                Color.FromArgb(255, 49, 49)
            };
                    while (!excludedColors.Contains(button.BackColor))
                    {
                        button.BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    }
                }
            }
            



        }
    }
}