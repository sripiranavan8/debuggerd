﻿using System;
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
    public partial class CustomerView : Form
    {
        public CustomerView()
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
            MySqlCommand cmdDataBase = new MySqlCommand("select * from customertable;", conDataBase);
            try
            {
                sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dbdataset);
            DV.RowFilter = string.Format("FirstName like '%{0}%'", searchtxt.Text);
            dataGridView1.DataSource = DV;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main f = new Main();
            f.Show();
        }

        private void add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInsert ci = new CustomerInsert();
            ci.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            scb = new MySqlCommandBuilder(sda);
            sda.Update(dbdataset);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string emp = dataGridView1.CurrentCell.Value.ToString();
            try
            {
                string MyConnection2 = "datasource=127.0.0.1;port=3306;username=root;password=;database=debuggeddb;";
                string Query = "delete from customertable where CID='" + emp + "';";
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

        private void CustomerView_Load(object sender, EventArgs e)
        {

        }
    }
}
