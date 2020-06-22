using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestForm
{
    public partial class Saver : Form
    {
        private const int LocationNameGameY = 95;
        private const int Reduce = -5;
        private const int Add = 5;
        private const int PictureNumber = 6;

        private Image[] images;
        private int numberImage = 0;
        

        public Saver()
        {
            InitializeComponent();
            images = new[] 
            {
                Properties.Resources.Image1,
                Properties.Resources.Image2,
                Properties.Resources.Image3,
                Properties.Resources.Image4,
                Properties.Resources.Image5,
                Properties.Resources.Image6,
                Properties.Resources.Image7,
                Properties.Resources.Image8
            };
            
            button_PlayGame.Visible = false;
            button_ExitGame.Visible = false;
            pictureBox_NameGame.Location = new Point(pictureBox_NameGame.Location.X, LocationNameGameY);
        }

        private void LoadImages()
        {            
            if (numberImage == PictureNumber)
            {
                pictureBox_ForLoading.Image = images[numberImage - 1];
                pictureBox_ForLoading1.Image = images[numberImage];
                timer.Enabled = false;
                timerPlazma.Enabled = true;
            }
            else
                pictureBox_ForLoading.Image = images[numberImage];
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadImages();
            numberImage++;
            if (numberImage > images.Length)
                numberImage = 0;
        }

        private void TimerPlazma_Tick(object sender, EventArgs e)
        {
            PlazmaMoveRight();
            
            if(pictureBox_ForLoading1.Location.X == pictureBox_NameGame.Location.X)
            {
                pictureBox_ForLoading1.Visible = false;
                timerPlazma.Enabled = false;
                timer_NameGame.Enabled = true;
            }
        }
        private void PlazmaMoveRight() => pictureBox_ForLoading1.Location += new Size(Add, 0);
        

        private void Timer_NameGame_Tick(object sender, EventArgs e)
        {
            NameGameTextMove();
            if (pictureBox_NameGame.Location.Y == 0)
            {
                timer_NameGame.Enabled = false;
                button_PlayGame.Visible = true;
                button_ExitGame.Visible = true;
            }
                
                
        }
        private void NameGameTextMove() => pictureBox_NameGame.Location += new Size(0, Reduce);

        private void Button_PlayGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameField gameField = new GameField();
            gameField.Show();

            //Game game = new Game();
            //game.Show();
        }

        private void Button_ExitGame_Click(object sender, EventArgs e) => Application.Exit();

        
    }
}
