using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

using System.Drawing.Imaging;//jpg compression inside it, when we take a bitmap screenshot off the pictureBox it compresses to jpg

namespace Classic_Snakes_Game_Tutorial___MOO_ICT
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();//type is circle
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random rand = new Random();//creates a random number

        bool goLeft, goRight, goDown, goUp;


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
            if (e.KeyCode ==Keys.Right && Settings.directions != "left")
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
        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {
            Label caption = new Label();
            caption.Text = "I scored: " + score + " and my Highscore is " + highScore + "on the Snake Game from MOO ICT";
            caption.Font = new Font("Ariel", 9, FontStyle.Bold);
            caption.ForeColor = Color.LightBlue;
            caption.AutoSize = false;//we do not want the label to autosize, we decide the size
            caption.Width = picCanvas.Width;
            caption.Height = 30;
            caption.TextAlign = ContentAlignment.MiddleCenter;
            picCanvas.Controls.Add(caption);


            SaveFileDialog dialog = new SaveFileDialog();
            dialog.FileName = " Snake Game Snapshot MOO ICT";
            dialog.DefaultExt = "jpg";
            //dialog.Filter = "JPG Image File | *.jpg";// we do not want to choose any other filetype than jpg
            dialog.ValidateNames = true;//prevents accidently put a comma or symbols in the file name that causes issues with windows

            if (dialog.ShowDialog() == DialogResult.OK)//if we clicked saved
            {
                int width = Convert.ToInt32(picCanvas.Width);
                int height = Convert.ToInt32(picCanvas.Height);
                Bitmap bmp = new Bitmap(width, height);
                picCanvas.DrawToBitmap(bmp, new Rectangle(0, 0, width, height));
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
                picCanvas.Controls.Remove(caption);              
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
                    
        private void GameTimerEvent(object sender, EventArgs e)
        {
            // setting the directions

            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }
            /*end of directions.
            because this is inside the timer we want to make sure all bodyparts
            moving accordingly*/

            for (int i = Snake.Count -1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    //when the snake reaches border the snake reappears on the other site
                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;//move it to the other corner
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }
                    //program in the part where the snake eats the food
                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)//checks if head and food are on the same place
                    {             //head is snake i
                        EatFood();//runs method line 235
                    }

                    for (int j = 1; j < Snake.Count; j++)//checks if head bites tail
                    {            //body is snake j
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                    }
                }
                //lines 98 to 165 tells the head what to do, below we tell the body what to
                else
                {
                    Snake[i].X = Snake[i - 1].X;//when its incrementing one bodypart follows the other
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }

            picCanvas.Invalidate();//with each take it will clear the canvas and will be redrawn
        }
        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();//clears List on line 4

            startButton.Enabled = false;//when these buttons are enabled we cannot
            snapButton.Enabled = false;//the up, down, left, right keys
            score = 0;
            txtScore.Text = "Score: " + score;

            Circle head = new Circle { X = 10, Y = 5 };//places the snake in the middle of picturebox
            Snake.Add(head); //call for the very first index of the List

            for (int i = 0; i < 10; i++)//run this loop 10 times and then we create another circle
            {
                Circle body = new Circle();
                Snake.Add(body);
            }

            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };//2 is for not to close at the wall

            gameTimer.Start();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        { //paint event linked to the picturebox
            Graphics canvas = e.Graphics;//linking paint event to that canvas

            Brush snakeColour;//colors the snakes head and body

            for (int i = 0; i < Snake.Count; i++)//Snake.Count depending how many bodyparts the snake has at the moment 
            {
                if (i == 0) 
                {
                    snakeColour = Brushes.Black;
                }
                else
                {
                    snakeColour = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * Settings.Width,
                    Snake[i].Y * Settings.Height,
                    Settings.Width, Settings.Height
                    ));
            }

            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
            (
            food.X * Settings.Width,
            food.Y * Settings.Height,
            Settings.Width, Settings.Height
            ));
        }

        private void EatFood()
        {
            score += 1;

            txtScore.Text = " Score: " + score;

            Circle body = new Circle//add new circle
            {
                X = Snake[Snake.Count - 1].X,//add it to the last index
                Y = Snake[Snake.Count - 1].Y
            };//adding a new instance of the circle class

            Snake.Add(body);
            //we also want to generate a new position for the foodcircle
            food = new Circle { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };
        }
        
        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true; //re-enable
            snapButton.Enabled = true;

            if (score > highScore)
            {
                highScore= score;

                txtHighScore.Text = "High Score: " + Environment.NewLine + highScore;//one paragraph down from where that label is
                txtHighScore.ForeColor = Color.Maroon;
                txtHighScore.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}
