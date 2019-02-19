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
    public partial class ProductInsert : Form
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }

        private void save_Click(object sender, EventArgs e)
        {
            String name = pname.Text;
            String type = ptype.Text;
            Double price = Convert.ToDouble(sprice.Text);
            Double discount = Convert.ToDouble(sdiscount.Text);

            if (name == "" || type == "" || price == null || discount == null)
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
                    comm.CommandText = "INSERT INTO productstable (`ProductName`,`ProductType`,`SellingPrice`,`Discount`) VALUES (@pn,@pt,@sp,@dd);";
                    comm.Parameters.AddWithValue("@pn", name);
                    comm.Parameters.AddWithValue("@pt", type);
                    comm.Parameters.AddWithValue("@sp", price);
                    comm.Parameters.AddWithValue("@dd", discount);
                    comm.ExecuteNonQuery();
                    databaseConnection.Close();
                    //clear the text
                    pname.Text = "";
                    ptype.Text = "";
                    sdiscount.Text = "";
                    sprice.Text = "";
                    //message
                    MessageBox.Show("Data Has been successfully inserted");
                    this.Hide();
                    ProductView pv = new ProductView();
                    pv.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            pname.Text = "";
            ptype.Text = "";
            sdiscount.Text = "";
            sprice.Text = "";
        }
    }
}
