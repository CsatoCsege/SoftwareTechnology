using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class SzinezodoGomb : Button
    {
        public Random random = new Random();
        public SzinezodoGomb()
        {
            Height = 20;
            Width = 20;
            BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            Click += SzinezodoGomb_Click;
        }

        private void SzinezodoGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
        }
    }
}
