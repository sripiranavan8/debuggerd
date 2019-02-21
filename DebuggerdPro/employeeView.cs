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
    public partial class employeeView : Form
    {
        public employeeView()
        {
            InitializeComponent();
            var time = DateTime.Now;
            string formattedTime = time.ToString("yyyy, MM, dd, hh, mm, ss");
            dateTime.Text = formattedTime;
            DisplayTable();
        }
        MySqlDataAdapter sda;
        MySqlCommandBuilder scb;
        DataTable dbdataset;
        private void DisplayTable()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand("select * from employeetable;",conDataBase);
            try
            {
                sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            register ne = new register();
            ne.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dbdataset);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }

        private void searchtext_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("Firstname like '%{0}%'", searchtext.Text);
            dataGridView2.DataSource = DV;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string emp = dataGridView2.CurrentCell.Value.ToString();
            try
            {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
                string Query = "delete from employeetable where EmpID='" + emp + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                MessageBox.Show("Data Deleted");
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();
                DisplayTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
