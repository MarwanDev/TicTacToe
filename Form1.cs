using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Properties;
using static TicTacToe.clsGame;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private clsGame Game;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
            pictureBoxes = new List<PictureBox> { pb1, pb2, pb3, pb4, pb5, pb6, pb7, pb8, pb9 };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game = new clsGame();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen pen = new Pen(White);
            pen.Width = 20;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 800, 300, 1800, 300);
            e.Graphics.DrawLine(pen, 800, 500, 1800, 500);

            e.Graphics.DrawLine(pen, 1100, 100, 1100, 700);
            e.Graphics.DrawLine(pen, 1500, 100, 1500, 700);
        }

        private Image GetImage(byte tag)
        {
            return Game.GetBoxValue(tag) == clsGame.enBoxValue.X ? Resources.X :
                Game.GetBoxValue(tag) == clsGame.enBoxValue.O ? Resources.O :
                Resources.question_mark_96;
        }

        private void ShowMessageBox()
        {
            if (Game.GetGameResult() == clsGame.enResult.Draw ||
                Game.GetGameResult() == clsGame.enResult.Win)
            {
                ChangeWinningBoxesColors();
                MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
        }

        private void ChangeCurrentPlayerName()
        {
            lblCurrentPlayer.Text = Game.GetGameResult() == clsGame.enResult.TBD ?
                Game.GetCurrentPlayer().ToString() : "Game Over";
        }

        private void ChangeWinnerName()
        {
            lblWinner.Text = Game.GetGameResult() == clsGame.enResult.Win ?
                Game.GetWinner(Game.GetPlayerBoxValue(Game.GetCurrentPlayer())).ToString() :
                Game.GetGameResult() == clsGame.enResult.Draw ? "Draw" : "In Progress";
        }

        private void RestartGame()
        {
            Game = new clsGame();
            ChangeBoxImage(pb1, 1);
            ChangeBoxImage(pb2, 2);
            ChangeBoxImage(pb3, 3);
            ChangeBoxImage(pb4, 4);
            ChangeBoxImage(pb5, 5);
            ChangeBoxImage(pb6, 6);
            ChangeBoxImage(pb7, 7);
            ChangeBoxImage(pb8, 8);
            ChangeBoxImage(pb9, 9);
            ChangeCurrentPlayerName();
            ChangeWinnerName();
            ResetBoxColors();
        }

        private void ChangeBoxImage(object sender, byte boxIndex)
        {
            ((PictureBox)sender).Image = GetImage(boxIndex);
        }

        private void HandleCardClick(object sender, byte boxIndex)
        {
            if (Game.PlayTurn(boxIndex))
            {
                ChangeBoxImage(sender, boxIndex);
                if (Game.GetGameResult() != clsGame.enResult.TBD)
                    ShowMessageBox();
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            ChangeCurrentPlayerName();
            ChangeWinnerName();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 1);
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 2);
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 3);
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 4);
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 5);
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 6);
        }

        private void pb7_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 7);
        }

        private void pb8_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 8);
        }

        private void pb9_Click(object sender, EventArgs e)
        {
            HandleCardClick(sender, 9);
        }

        private void ResetBoxColors()
        {
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                pictureBox.BackColor = Color.Black;
            }
        }

        private void ChangeWinningBoxesColors(bool isRestart = false)
        {
            if (Game.GetGameResult() == enResult.Win)
            {
                List<byte> winningIndexes = new List<byte>();
                Game.GetWinningIndexes(ref winningIndexes);
                foreach (byte index in winningIndexes)
                {
                    foreach (PictureBox pictureBox in pictureBoxes)
                    {
                        try
                        {
                            byte tagValue = Convert.ToByte(pictureBox.Tag);
                            if (tagValue == index + 1)
                            {
                                pictureBox.BackColor = Color.White;
                            }
                        }
                        catch (Exception ex)
                        {
                            Debug.WriteLine($"Error converting Tag: {ex.Message}");
                        }
                    }
                }
            }
        }
    }
}
