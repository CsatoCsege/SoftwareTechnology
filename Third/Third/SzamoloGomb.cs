using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class SzamoloGomb : Button
    {
        public int szam;
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;
            this.szam = 1;
            Text = szam.ToString();
            MouseClick += SzamoloGomb_MouseClick;
        }

        private void SzamoloGomb_MouseClick(object? sender, MouseEventArgs e)
        {
            if (this.szam == 5)
            {
                this.szam = 1;
            }
            else
            {
                this.szam++;
            }
            Text = szam.ToString();

        }
    }
}
