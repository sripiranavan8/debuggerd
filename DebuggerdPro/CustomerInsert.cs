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
    public partial class CustomerInsert : Form
    {
        public CustomerInsert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fna = fname.Text;
            String last = lname.Text;
            String da = jdate.Value.ToString("MM/dd/yyyy");
            String pho = mobile.Text;
            String addr = address.Text;
            String ty = "";
            if (exc.Checked)
            {
                ty = "Exclusive";
            }
            if (sexc.Checked)
            {
                ty = "Semi-Exclusive";
            }
            if (nexc.Checked)
            {
                ty = "Non-Exclusive";
            }
            if (fna == "" || last == "" || da == "" || pho == "" || ty == "")
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
                    comm.CommandText = "INSERT INTO customertable (`FirstName`,`LastName`,`Mobile`,`Type`,`Address`,`JoinDate`) VALUES (@ff,@ll,@mm,@tt,@aa,@jj);";
                    comm.Parameters.AddWithValue("@ff", fna);
                    comm.Parameters.AddWithValue("@ll", last);
                    comm.Parameters.AddWithValue("@jj", da);
                    comm.Parameters.AddWithValue("@mm", pho);
                    comm.Parameters.AddWithValue("@tt", ty);
                    comm.Parameters.AddWithValue("@aa", addr);
                    comm.ExecuteNonQuery();
                    databaseConnection.Close();
                    //clear the text
                    fname.Text = "";
                    lname.Text = "";
                    mobile.Text = "";
                    address.Text = "";
                    //message
                    MessageBox.Show("Data Has been successfully inserted");
                    this.Hide();
                    CustomerView cv = new CustomerView();
                    cv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            mobile.Text = "";
            address.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerView cv = new CustomerView();
            cv.Show();
        }
    }
}
