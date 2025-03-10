using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class SzamoloGomb : Button
    {
        int szam;
        //Random random = new Random();
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;
            Click += SzamoloGomb_Click;
            szam = 1;
            Text = szam.ToString();

            //BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            szam++;
            if (szam == 6)
            {
                szam = 1;
            }
            Text = szam.ToString();
            //BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }
    }
}
