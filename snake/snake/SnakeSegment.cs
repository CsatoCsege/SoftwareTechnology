using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{

    internal class SnakeSegment : PictureBox //object, internal máshonnan nem elérhető
    {
        public static int SnakeSegmentSize { get; } = 20; //egy lesz belőle static
        public SnakeSegment()
        {
            BackColor = Color.LimeGreen;
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
            
        }
        /// <summary>
        /// VÁLTOZTATJAASZÍNÉTBASZOD
        /// </summary>
        /// <param name="step"></param>
        public SnakeSegment(int step) //method túlterhelés ugyan az a név, más parameter 
        {
            Width = SnakeSegmentSize;
            Height = SnakeSegmentSize;
            if (step % 2 == 0)
            {
                BackColor = Color.LimeGreen;
            }
            else
            {
                BackColor = Color.Fuchsia;
            }
        }
    }
}
