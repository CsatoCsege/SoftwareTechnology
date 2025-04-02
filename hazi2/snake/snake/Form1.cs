using static System.Formats.Asn1.AsnWriter;

namespace snake
{
    //enumeráció 
    //enum

    

    public partial class Form1 : Form
    {
        int directionX = 1;
        int directionY = 0;
        int headX;
        int headY;
        int snakeLength = 5;
        int stepCounter = 0;
        int score = 0;
        List<SnakeSegment> snake = new List<SnakeSegment>();
        List<PictureBox> poisons = new List<PictureBox>();
        Label scoreLabel;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }
        private void ResetGame()
        {
            headX = ClientSize.Width / 2;
            headY = ClientSize.Height / 2;
            snake.Clear();
            Controls.Clear();
            snakeLength = 5;
            stepCounter = 0;
            score = 0;
            poisons.Clear();

            scoreLabel = new Label()
            {
                Text = "Score: 0",
                ForeColor = Color.White,
                Font = new Font("Arial", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            Controls.Add(scoreLabel);

            for (int i = 0; i < 20; i++)
            {
                PictureBox poison = new PictureBox()
                {
                    Size = new Size(SnakeSegment.SnakeSegmentSize, SnakeSegment.SnakeSegmentSize),
                    Image = Image.FromFile("sword.png"),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                Controls.Add(poison);
                poisons.Add(poison);
                PlacePoison(poison);
            }
        }
        private void PlacePoison(PictureBox poison)
        {
            poison.Left = rand.Next(ClientSize.Width / SnakeSegment.SnakeSegmentSize) * SnakeSegment.SnakeSegmentSize;
            poison.Top = rand.Next(ClientSize.Height / SnakeSegment.SnakeSegmentSize) * SnakeSegment.SnakeSegmentSize;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            headX += directionX * SnakeSegment.SnakeSegmentSize;
            headY += directionY * SnakeSegment.SnakeSegmentSize;

            if (headX < 0 || headY < 0 || headX >= ClientSize.Width || headY >= ClientSize.Height)
            {
                ResetGame();
                return;
            }

            foreach (var poison in poisons)
            {
                if (new Rectangle(headX, headY, SnakeSegment.SnakeSegmentSize, SnakeSegment.SnakeSegmentSize).IntersectsWith(poison.Bounds))
                {
                    ResetGame();
                    return;
                }
            }

            bool isSnakeDead = false;
            foreach (SnakeSegment segment in snake)
            {
                if (segment.Top == headY && segment.Left == headX)
                {
                    isSnakeDead = true;
                    break;
                }
            }
            if (isSnakeDead)
            {
                ResetGame();
                return;
            }

            var newHead = new SnakeSegment(stepCounter)
            {
                Top = headY,
                Left = headX,
            };
            Controls.Add(newHead);
            snake.Add(newHead);

            if (snake.Count > snakeLength)
            {
                var tailToCut = snake[0];
                snake.RemoveAt(0);
                Controls.Remove(tailToCut);
            }
            stepCounter++;
            score++;
            scoreLabel.Text = "Score: " + score;

            if (stepCounter % 5 == 0)
            {
                snakeLength++;
            }
        }
        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && directionY == 0)
            {
                directionX = 0;
                directionY = -1;
            }
            if (e.KeyCode == Keys.Down && directionY == 0)
            {
                directionX = 0;
                directionY = 1;
            }
            if (e.KeyCode == Keys.Left && directionX == 0)
            {
                directionX = -1;
                directionY = 0;
            }
            if (e.KeyCode == Keys.Right && directionX == 0)
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