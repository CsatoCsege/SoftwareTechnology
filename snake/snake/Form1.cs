namespace snake
{
    //enumeráció 
    //enum

    

    public partial class Form1 : Form
    {
        int directionX = 1;
        int directionY = 0;
        int headX = 100;
        int headY = 100;
        int snakeLength = 5;
        int stepCounter = 0;
        List<SnakeSegment> snake = new List<SnakeSegment>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headX += directionX * SnakeSegment.SnakeSegmentSize;
            headY += directionY * SnakeSegment.SnakeSegmentSize;
            //SnakeSegment newHead = new SnakeSegment();
            bool isSnakeDead = false;
            foreach (SnakeSegment segment in snake)
            {
                if (segment.Top == headY && segment.Left == headX)
                {
                    //timer1.Enabled = false;
                    isSnakeDead = true;
                    break;
                }
            }
            if (isSnakeDead)
            {
                snake.Clear();
                Controls.Clear();
            }
            var newHead = new SnakeSegment(stepCounter)
            {
                Top = headY,
                Left = headX,
            };
            Controls.Add(newHead);
            snake.Add(newHead);
            if (snake.Count() > snakeLength)
            {
                var tailToCut = snake[0]; //snake.FirstOrDefault
                snake.Remove(tailToCut); //snake.RemoveAt(0)
                Controls.Remove(tailToCut);
            }
            stepCounter++;

            if (stepCounter % 5 == 0)
            {
                snakeLength++;
            }
            label1.Text = stepCounter.ToString();
        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                directionX = 0;
                directionY = -1;
            }
            if (e.KeyCode == Keys.Down)
            {
                directionX = 0;
                directionY = 1;
            }
            if (e.KeyCode == Keys.Left)
            {

                directionX = -1;
                directionY = 0;
            }
            if (e.KeyCode == Keys.Right)
            {
                directionX = 1;
                directionY = 0;
            }
        }
        //pálya: új osztály poison, kép betöltése, poison lista, meghal,
        //másik kígyó
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}