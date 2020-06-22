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
    enum Img { Apple, Bear, Coconut, Leaf, Mushroom, Nut, Pineapple, Scorpio }
    public partial class Game : Form
    {        

        private List<int> tags = new List<int>();
        private List<int> buttonIndices = new List<int>();
        
        private int score = 0;
        private int amountButton = FieldModel.SizeModel;

        public int[] model;

        public Game()
        {
            InitializeComponent();
            
        }        

        private void Game_Load(object sender, EventArgs e)
        {
            model = FieldModel.model;
            label1.Text = "0";


            for (int i = 0; i < FieldModel.PlayingField; i++)
            {
                Button button = new Button
                {
                    Size = new Size(FieldModel.ImageSizeX, FieldModel.ImageSizeY),
                    Location = new Point(i % 4 * FieldModel.ImageSizeX, i / 4 * FieldModel.ImageSizeY),
                    Text = "",
                    Tag = model[i]
                };
                button.Click += Button_Click;
                Controls.Add(button);
            }
        }
            
        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int tag = (int)button.Tag;
            button.BackgroundImage = FieldModel.images[tag];

            int index = Controls.IndexOf(button);

            buttonIndices.Add(index);
            tags.Add(tag);

            Compare(button);
            
        }
        
        private void Compare(Button button)
        {
            for (int i = 0; i < 2; i++)
            {
                if (tags.Count > 1)
                {
                    if (tags[1] == tags[0])
                    {
                        MessageBox.Show($"Одинаковые +1 очко", "Information");
                        score++;
                        label1.Text = score.ToString();

                        amountButton -= 2;

                        Controls.RemoveAt(buttonIndices[0]);
                        Controls.Remove(button);

                        buttonIndices.Clear();
                        tags.Clear();

                        CheckButtonInTheGame(amountButton, score);
                    }
                    else
                    {
                        MessageBox.Show($"Разные -1 очко", "Information");
                        score--;
                        label1.Text = score.ToString();

                        button.BackgroundImage = null;
                        Controls[buttonIndices[0]].BackgroundImage = null;

                        buttonIndices.Clear();
                        tags.Clear();
                    }
                }
                else
                    break;

            }

        }

        private void CheckButtonInTheGame(int amount, int score)
        {
            if(amount == 0)
            {
                if (CheckScore(score))
                {
                    MessageBox.Show($"Вы выиграли!", "Information");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show($"Вы проиграли!", "Information");
                    Application.Exit();
                }
                    

            }
        }

        private bool CheckScore(int score) => score > 0;
        
        private void Button_Close_Click(object sender, EventArgs e) => Application.Exit();
        
    }
}
