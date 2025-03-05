using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    internal class Gomb : Button
    {
        public Gomb()
        {
            Height = 100;
            Width = 100;
            MouseClick += Gomb_MouseClick;
        }

        private void Gomb_MouseClick(object? sender, MouseEventArgs e)
        {
            BackColor = Color.Blue;
        }
    }
}
