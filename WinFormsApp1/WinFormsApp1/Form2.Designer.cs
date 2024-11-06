namespace WinFormsApp1
{
    partial class Form2
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
            menu = new Panel();
            btn_exit = new PictureBox();
            btn_start = new PictureBox();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_exit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackgroundImage = Properties.Resources.menu;
            menu.BackgroundImageLayout = ImageLayout.Stretch;
            menu.Controls.Add(btn_exit);
            menu.Controls.Add(btn_start);
            menu.Location = new Point(225, 39);
            menu.Name = "menu";
            menu.Size = new Size(416, 498);
            menu.TabIndex = 0;
            // 
            // btn_exit
            // 
            btn_exit.BackgroundImage = Properties.Resources.start_normal;
            btn_exit.Image = Properties.Resources.exit_normal;
            btn_exit.Location = new Point(155, 271);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(100, 43);
            btn_exit.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_exit.TabIndex = 2;
            btn_exit.TabStop = false;
            btn_exit.Click += btn_exit_Click;
            btn_exit.MouseLeave += btn_exit_MouseLeave;
            btn_exit.MouseHover += btn_exit_MouseHover;
            // 
            // btn_start
            // 
            btn_start.BackgroundImage = Properties.Resources.start_normal;
            btn_start.Image = Properties.Resources.start_normal;
            btn_start.Location = new Point(155, 166);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(100, 43);
            btn_start.SizeMode = PictureBoxSizeMode.AutoSize;
            btn_start.TabIndex = 0;
            btn_start.TabStop = false;
            btn_start.Click += btn_start_Click;
            btn_start.MouseLeave += btn_start_MouseLeave;
            btn_start.MouseHover += btn_start_MouseHover;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(829, 598);
            Controls.Add(menu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_exit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_start).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menu;
        private PictureBox btn_start;
        private PictureBox btn_exit;
    }
}