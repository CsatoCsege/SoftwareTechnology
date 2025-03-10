using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas
{
    internal class KaracsonyGomb : Button
    {
        Random random = new Random();
        public KaracsonyGomb()
        {
            Height = 20;
            Width = 20;
            /*
            {
                BackColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            }
            */
        }
    }
}
