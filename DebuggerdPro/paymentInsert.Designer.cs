namespace DebuggerdPro
{
    partial class paymentInsert
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bill = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ammount = new System.Windows.Forms.TextBox();
            this.pdate = new System.Windows.Forms.DateTimePicker();
            this.type = new System.Windows.Forms.ComboBox();
            this.description = new System.Windows.Forms.RichTextBox();
            this.exit = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert the Payments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bill No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Purchase Ammount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Payment Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(120, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Location = new System.Drawing.Point(281, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(209, 105);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(119, 20);
            this.bill.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Payment Date";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ammount
            // 
            this.ammount.Location = new System.Drawing.Point(504, 165);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(119, 20);
            this.ammount.TabIndex = 4;
            // 
            // pdate
            // 
            this.pdate.Location = new System.Drawing.Point(209, 166);
            this.pdate.Name = "pdate";
            this.pdate.Size = new System.Drawing.Size(141, 20);
            this.pdate.TabIndex = 5;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "Check"});
            this.type.Location = new System.Drawing.Point(504, 107);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(118, 21);
            this.type.TabIndex = 6;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(209, 226);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(196, 49);
            this.description.TabIndex = 7;
            this.description.Text = "";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.LightYellow;
            this.exit.Location = new System.Drawing.Point(444, 303);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(96, 36);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Location = new System.Drawing.Point(441, 369);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(0, 13);
            this.dateTime.TabIndex = 9;
            // 
            // paymentInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(660, 383);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.description);
            this.Controls.Add(this.type);
            this.Controls.Add(this.pdate);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "paymentInsert";
            this.Text = "paymentInsert";
            this.Load += new System.EventHandler(this.paymentInsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox bill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ammount;
        private System.Windows.Forms.DateTimePicker pdate;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.RichTextBox description;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label dateTime;
    }
}