using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kviz
{
    public partial class KerdesKontrol : UserControl
    {
        int jovalasz;

        public bool jo { get; set; } = false;
        public bool valaszolt { get; set; } = false;

        public KerdesKontrol()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="kerdes"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="a3"></param>
        /// <param name="a4"></param>
        /// <param name="jovalasz"></param>
        public KerdesKontrol(string kerdes, string a1, string a2, string a3, string a4, int jovalasz)
        {
            InitializeComponent();
            label1.Text = kerdes;
            button1.Text = a1;
            button2.Text = a2;
            button3.Text = a3;
            button4.Text = a4;
            this.jovalasz = jovalasz;

        
        }
        void szinez()
        {
            if (jovalasz == 1)
            {
                button1.BackColor = Color.Green;
            }
            if (jovalasz == 2)
            {
                button2.BackColor = Color.Green;
            }
            if (jovalasz == 3)
            {
                button3.BackColor = Color.Green;
            }
            if (jovalasz == 4)
            {
                button4.BackColor = Color.Green;
            }
            Enabled = false;
            valaszolt = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            if (jovalasz == 1)
            {
                this.jo = true;
            }
            szinez();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            szinez();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            szinez();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            szinez();

        }

    }
}
