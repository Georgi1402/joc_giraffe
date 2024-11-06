using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private string username;
        private int score;
        public Form4(string _username, int _score)
        {
            InitializeComponent();
            username = _username;
            score = _score;
            DoubleBuffered = true;
            lbl_over.Visible = false;
            lbl_value.Text = score.ToString();
        }
        void SaveScore(int score)
        {
            // Deschidem conexiunea către baza de date
            using (MySqlConnection connection = new MySqlConnection("Server=127.0.0.1; Database=game; Uid=root; Pwd=fbtn1zfb;"))
            {
                try
                {
                    connection.Open();

                    // Query pentru a actualiza scorul
                    string updateQuery = "UPDATE login SET score = @score WHERE username = @username";

                    // Comanda de actualizare
                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection))
                    {
                       updateCmd.Parameters.AddWithValue("@score", score);
                        updateCmd.Parameters.AddWithValue("@username", username);

                        // Executați comanda de actualizare
                        updateCmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to update score: " + ex.Message, "Error");
                }
            }
        }

        bool right, left, up;
        

        void Game_result()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacles")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        timer1.Stop();
                        lbl_over.Visible = true;
                        lbl_over.BringToFront();

                        SaveScore(score);
                    }
                    if (score > Int32.Parse(lbl_value.Text))
                    {
                        // Actualizare scor maxim și salvare
                        Properties.Settings.Default.h_score = score.ToString();
                        Properties.Settings.Default.Save();
                        lbl_value.Text = Properties.Settings.Default.h_score;

                       
                    }


                }
            }
        }

        void Obstacles_move()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "obstacles")
                {
                    if (j.Top > this.ClientSize.Height)
                    {
                        j.Top = 0;
                        Random rn = new Random();
                        int x = rn.Next(0, this.ClientSize.Width - j.Width);
                        j.Location = new Point(x, 10);
                    }
                    j.Top += 5;
                }
            }
        }

        void Tiles_move()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "tile")
                {
                    if (x.Top > 450)
                    {
                        x.Top = -100;
                    }
                    x.Top += 5;
                }
            }
        }

        void player_move()
        {
            if (right == true)
            {
                if (player.Left < 685)
                {
                    player.Left += 15;

                }
            }
            if (left == true)
            {
                if (player.Left > 5)
                {
                    player.Left -= 15;
                }
            }
            if (up == true)
            {
                Tiles_move();
                Obstacles_move();
            }
            foreach (Control tile in this.Controls)
            {
                if (tile is PictureBox && tile.Tag == "tile")
                {
                    if (player.Bounds.IntersectsWith(tile.Bounds))
                    {
                        // Ați prins un "tile", incrementați scorul
                        score++;
                        lbl_score.Text = "Score: " + score; // Actualizați afișarea scorului

                        // Plasați "tile" într-o nouă poziție
                        tile.Top = -100;
                    }
                }
            }
        }
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = true;
                    break;
                case Keys.Left:
                    left = true;
                    break;
                case Keys.Up:
                    up = true;
                    break;
            }
        }

        private void Form4_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    right = false;
                    break;
                case Keys.Left:
                    left = false;
                    break;
                case Keys.Up:
                    up = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            player_move();
            Tiles_move();
            Obstacles_move();
            Game_result();
        }
    }
}