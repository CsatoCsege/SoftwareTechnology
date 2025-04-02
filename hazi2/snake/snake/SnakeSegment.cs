using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace snake
{


    internal class SnakeSegment : PictureBox
    {
        public static int SnakeSegmentSize { get; } = 20;
        public SnakeSegment()
        {
            BackColor = Color.LimeGreen;
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
        }
        public SnakeSegment(int step)
        {
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
            BackColor = (step % 2 == 0) ? Color.LimeGreen : Color.Fuchsia;
        }
    }
}
