namespace Classic_Snake_Game
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            //setting the directions
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            for (int i = Snake.Count-1;i >=0; i--)
            {
                if (i==0)//when it finds the head of the snake
                {
                    switch(Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                    }
                    //outside of switch statement we need to set the boundaries
                    //when the snake reaches the edge it appears the other side
                    if (Snake[i].X <0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X> maxWidth) 
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y <0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;//body part follows the previous part
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
            picCanvas.Invalidate();//with each timer tick it will clear everything from the canvas and redraw.

        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {

        }
        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics; //create a canvas
            Brush snakeColour; //colour snake head and body

            for(int i = 0; i<Snake.Count; i++)
            {
                if (i==0)
                {
                    snakeColour = Brushes.Black;//if count is 0 then this is the head and hence Black
                }
                else
                {
                    snakeColour = Brushes.DarkGreen; //otherwise it's the body and green
                }
                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));//draw snake on canvas. 
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                        (
                        food.X * Settings.Width,
                        food.Y * Settings.Height,
                        Settings.Width, Settings.Height
                        ));//draw snake on canvas.

        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1; //provides a small buffer area so that we can calculate when snake is near the edge.
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear(); //clears the snake list

            btnSnap.Enabled = false; //disable both buttons so that the focus is on the game
            btnStart.Enabled = false;
            score = 0;
            lblScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 }; //specifying the start location of the head
            Snake.Add(head); //add head to snake list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            gameTimer.Start();

        }

        private void EatFood()
        {
            score += 1;

            lblScore.Text = "Score : " + score;
            Circle body = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
        };
        }

        private void GameOver()
        {

        }
    }
}