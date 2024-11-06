using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_hover;

        }



        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_hover;
        }

        private void btn_start_MouseLeave(object sender, EventArgs e)
        {
            btn_start.Image = Properties.Resources.start_normal;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Facultate\An III\Medii vizuale\WinFormsApp1\WinFormsApp1\Resources\hhhhhhhhhhhhhhhh.wav");
            sound.Play();
        }



        private void btn_exit_MouseLeave(object sender, EventArgs e)
        {
            btn_exit.Image = Properties.Resources.exit_normal;
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Facultate\An III\Medii vizuale\WinFormsApp1\WinFormsApp1\Resources\hhhhhhhhhhhhhhhh.wav");
            sound.Play();

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
