using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DebuggerdPro
{
    public partial class userRegister : Form
    {
        public userRegister()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 10;
            rpassword.PasswordChar = '*';
            rpassword.MaxLength = 10;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = uname.Text;
            String pass = password.Text;
            String rpass = rpassword.Text;


            if (name == "" || pass == "" || rpass == "")
            {
                MessageBox.Show("Every Field are Required");
            }
            else
            {
                if (pass == rpass)
                {
                    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
                    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                    try
                    {
                        databaseConnection.Open();
                        MySqlCommand comm = databaseConnection.CreateCommand();
                        comm.CommandText = "INSERT INTO usertable (`UserName`,`Password`) VALUES (@un,@pas);";
                        comm.Parameters.AddWithValue("@un", name);
                        comm.Parameters.AddWithValue("@pas", pass);
                        comm.ExecuteNonQuery();
                        databaseConnection.Close();
                        //clear the text
                        uname.Text = "";
                        password.Text = "";
                        rpassword.Text = "";

                        //message
                        MessageBox.Show("Data Has been successfully inserted");
                        this.Hide();
                        Main m = new Main();
                        m.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Passwords Dosen't match");
                }
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
