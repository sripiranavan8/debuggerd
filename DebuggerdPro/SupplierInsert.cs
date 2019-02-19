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
    public partial class SupplierInsert : Form
    {
        public SupplierInsert()
        {
            InitializeComponent();
        }

        private void SupplierInsert_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = sname.Text;
            String pho = phone.Text;

            if (name == "" || pho == "")
            {
                MessageBox.Show("Every Field are Required");
            }
            else
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                try
                {
                    databaseConnection.Open();
                    MySqlCommand comm = databaseConnection.CreateCommand();
                    comm.CommandText = "INSERT INTO suppliertable (`SupplierName`,`PhoneNo`) VALUES (@sn,@ph);";
                    comm.Parameters.AddWithValue("@sn", name);
                    comm.Parameters.AddWithValue("@ph", pho);
                    comm.ExecuteNonQuery();
                    databaseConnection.Close();
                    //clear the text
                    sname.Text = "";
                    phone.Text = "";
                    //message
                    MessageBox.Show("Data Has been successfully inserted");
                    this.Hide();
                    SupplierView sv = new SupplierView();
                    sv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sname.Text = "";
            phone.Text = "";
        }
    }
}
