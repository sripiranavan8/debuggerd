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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");
            dateTime.Text = formattedTime;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ne = new Form1();
            ne.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String full = fullname.Text;
            String last = lastname.Text;
            String da = dob.Value.ToString("MM/dd/yyyy");
            String pho = phone.Text;
            String gen = "";
            if (male.Checked)
            {
                gen = "Male";
            }
            if (female.Checked)
            {
                gen = "Female";
            }
            Double sal = Convert.ToDouble(salary.Text);
            String ni = nic.Text;
            String add = address.Text;
            if (full == "" || last == "" || da =="" || pho =="" || gen =="" || ni == "" || add == "")
            {
                MessageBox.Show("Every Field are Required");
            }
            else
            {
                DateTime tod = DateTime.Today;
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                try
                {
                    databaseConnection.Open();
                    MySqlCommand comm = databaseConnection.CreateCommand();
                    comm.CommandText = "INSERT INTO employeetable(`FirstName`,`LastName`,`DOB`,`NIC`,`Gender`,`Address`,`Salary`,`PhoneNo`,`AppDate`) VALUES(@ff,@ll,@dd,@nn,@gg,@aa,@ss,@pp,@ap);";
                    comm.Parameters.AddWithValue("@ff", full);
                    comm.Parameters.AddWithValue("@ll", last);
                    comm.Parameters.AddWithValue("@dd", da);
                    comm.Parameters.AddWithValue("@nn", ni);
                    comm.Parameters.AddWithValue("@gg", gen);
                    comm.Parameters.AddWithValue("@aa", add);
                    comm.Parameters.AddWithValue("@ss", sal);
                    comm.Parameters.AddWithValue("@pp", pho);
                    comm.Parameters.AddWithValue("@ap", tod);
                    comm.ExecuteNonQuery();
                    databaseConnection.Close();
                    //clear the text
                    fullname.Text = "";
                    lastname.Text = "";
                    phone.Text = "";
                    salary.Text = "";
                    nic.Text = "";
                    address.Text = "";
                    //message
                    MessageBox.Show("Data Has been successfully inserted");
                    this.Hide();
                    employeeView ev = new employeeView();
                    ev.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fullname.Text = "";
            lastname.Text = "";
            phone.Text = "";
            salary.Text = "";
            nic.Text = "";
            address.Text = "";
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
