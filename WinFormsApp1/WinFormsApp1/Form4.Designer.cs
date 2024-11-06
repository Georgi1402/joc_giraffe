namespace WinFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lbl_score = new Label();
            lbl_over = new Label();
            label1 = new Label();
            lbl_value = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.giraffe;
            player.Location = new Point(685, 486);
            player.Name = "player";
            player.Size = new Size(125, 64);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.leaf;
            pictureBox1.Location = new Point(658, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(47, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "tile";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.leaf;
            pictureBox2.Location = new Point(258, 423);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(47, 42);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "tile";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.granite;
            pictureBox3.Location = new Point(125, 91);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 47);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "obstacles";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.granite;
            pictureBox4.Location = new Point(555, 368);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(58, 47);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "obstacles";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.lion;
            pictureBox5.Location = new Point(428, 101);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 47);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "obstacles";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.lion;
            pictureBox6.Location = new Point(258, 237);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(54, 47);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "obstacles";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.BackColor = Color.Transparent;
            lbl_score.Font = new Font("Imprint MT Shadow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_score.ForeColor = Color.White;
            lbl_score.Location = new Point(311, 42);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(119, 33);
            lbl_score.TabIndex = 7;
            lbl_score.Text = "Score: 0";
            // 
            // lbl_over
            // 
            lbl_over.AutoSize = true;
            lbl_over.BackColor = Color.Transparent;
            lbl_over.Font = new Font("Imprint MT Shadow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_over.ForeColor = Color.White;
            lbl_over.Location = new Point(232, 308);
            lbl_over.Name = "lbl_over";
            lbl_over.Size = new Size(338, 71);
            lbl_over.TabIndex = 8;
            lbl_over.Text = "Game Over";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Imprint MT Shadow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 33);
            label1.TabIndex = 9;
            label1.Text = "High Score: ";
            // 
            // lbl_value
            // 
            lbl_value.AutoSize = true;
            lbl_value.BackColor = Color.Transparent;
            lbl_value.Font = new Font("Imprint MT Shadow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_value.ForeColor = Color.White;
            lbl_value.Location = new Point(477, 9);
            lbl_value.Name = "lbl_value";
            lbl_value.Size = new Size(38, 33);
            lbl_value.TabIndex = 10;
            lbl_value.Text = " 0";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._6204882;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(811, 551);
            Controls.Add(lbl_value);
            Controls.Add(label1);
            Controls.Add(lbl_over);
            Controls.Add(lbl_score);
            Controls.Add(player);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox6);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "Form4";
            KeyDown += Form4_KeyDown;
            KeyUp += Form4_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label lbl_score;
        private Label lbl_over;
        private Label label1;
        private Label lbl_value;
    }
}