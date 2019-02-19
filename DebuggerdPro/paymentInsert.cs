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
    public partial class paymentInsert : Form
    {
        public paymentInsert()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String bi = bill.Text;
            String ty = type.Text;
            String da = pdate.Value.ToString("MM/dd/yyyy");
            String am = ammount.Text;
            String des = description.Text ;
            if (bi == "" || ty == "" || da == "" || am == "" || des == "")
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
                    comm.CommandText = "INSERT INTO paymenttable (`BillNo`,`PayDate`,`Ammount`,`Description`,`PayType`) VALUES(@bb,@pp,@aa,@dd,@pt);";
                    comm.Parameters.AddWithValue("@bb", bi);
                    comm.Parameters.AddWithValue("@pp", da);
                    comm.Parameters.AddWithValue("@aa", am);
                    comm.Parameters.AddWithValue("@dd", des);
                    comm.Parameters.AddWithValue("@pt", ty);
                    comm.ExecuteNonQuery();
                    databaseConnection.Close();
                    //clear the text
                    bill.Text = "";
                    pdate.Text = "";
                    type.Text = "";
                    ammount.Text = "";
                    description.Text = "";
                    //message
                    MessageBox.Show("Data Has been successfully inserted");
                    this.Hide();
                    paymentView pv = new paymentView();
                    pv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bill.Text = "";
            pdate.Text = "";
            type.Text = "";
            ammount.Text = "";
            description.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }
    }
}
