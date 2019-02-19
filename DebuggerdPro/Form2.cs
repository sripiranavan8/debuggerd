using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DebuggerdPro
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            employeeView ev = new employeeView();
            ev.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            paymentView pv = new paymentView();
            pv.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerView cv = new CustomerView();
            cv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Form1 f = new Form1();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductView pv = new ProductView();
            pv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SupplierView sv = new SupplierView();
            sv.Show();
        }
    }
}
