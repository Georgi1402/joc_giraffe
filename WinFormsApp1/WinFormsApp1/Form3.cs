using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        private MySqlConnection conn;

        public Form3()
        {
            InitializeComponent();
            string mysqlCon = "Server=127.0.0.1; Database=game; Uid=root; Pwd=fbtn1zfb;";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                MessageBox.Show("Connection success");

                conn = mySqlConnection;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
            try
            {
                String querry = "Select * from login where username = '" + txt_username.Text + "' AND password = '" + txt_password.Text + "'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    int score = dtable.Rows[0].Field<int>("score");

                    Form4 form4 = new Form4(username, score);
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    txt_username.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            // Verificăm dacă username-ul este disponibil
            conn.Open();
            MySqlCommand checkUsernameCmd = new MySqlCommand("SELECT * FROM login WHERE Username = @UserName", conn);
            checkUsernameCmd.Parameters.AddWithValue("@UserName", txt_username.Text);

            bool usernameExists = false;

            using (var dr = checkUsernameCmd.ExecuteReader())
            {
                if (usernameExists = dr.HasRows)
                    MessageBox.Show("Username not available!");
            }

            if (!usernameExists)
            {
                // Înregistrare utilizator
                string insertQuery = "INSERT INTO login(`id`,`username`, `password`, `score`) VALUES (NULL, @UserName, @Password, '0')";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);

                insertCmd.Parameters.AddWithValue("@UserName", txt_username.Text);
                insertCmd.Parameters.AddWithValue("@Password", txt_password.Text);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Account Successfully Created! Please login.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to register user: " + ex.Message, "Error");
                }
            }

            conn.Close();
        }
    }
}

