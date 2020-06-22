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
    public partial class GameField : Form
    {
        private int[] model;
        public GameField()
        {
            InitializeComponent();
        }

        private void GameField_Load(object sender, EventArgs e)
        {
            model = FieldModel.model;

            for (int i = 0; i < FieldModel.PlayingField; i++)
            {
                Button button = new Button
                {
                    Size = new Size(FieldModel.ImageSizeX, FieldModel.ImageSizeY),
                    Location = new Point(i % 4 * FieldModel.ImageSizeX, i / 4 * FieldModel.ImageSizeY),
                    Text = "",
                    Tag = model[i]
                };
                Controls.Add(button);
            }
            ShowPlayingField();

        }

        private void ShowPlayingField()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].BackgroundImage = FieldModel.images[model[i]];
            }
        }

        private void HidePlayingField()
        {
            for (int i = 0; i < Controls.Count; i++)
            {
                Controls[i].BackgroundImage = null;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            HidePlayingField();
            timer.Stop();

            Game game = new Game();
            game.Show();

            this.Hide();
        }
    }
}
