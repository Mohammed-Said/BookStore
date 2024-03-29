﻿namespace BookStore.Admin.Forms
{
  partial class OrdersForm
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 87);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(531, 360);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(39, 55, 77);
            button1.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(25, 440);
            button1.Name = "button1";
            button1.Size = new Size(160, 50);
            button1.TabIndex = 1;
            button1.Text = "View Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ViewAll_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(39, 55, 77);
            button2.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(25, 537);
            button2.Name = "button2";
            button2.Size = new Size(160, 50);
            button2.TabIndex = 2;
            button2.Text = "Cancle Order";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Cancle_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(39, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ID";
            textBox1.Size = new Size(300, 35);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(39, 91);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Status";
            textBox2.Size = new Size(300, 35);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(39, 156);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Adress";
            textBox3.Size = new Size(300, 35);
            textBox3.TabIndex = 5;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(39, 221);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Price";
            textBox4.Size = new Size(300, 35);
            textBox4.TabIndex = 6;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(205, 454);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(196, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker2.Location = new Point(205, 552);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(196, 21);
            dateTimePicker2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(227, 429);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 9;
            label1.Text = " Ordered  Date Time";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(258, 526);
            label3.Name = "label3";
            label3.Size = new Size(106, 18);
            label3.TabIndex = 11;
            label3.Text = "Arrived Order";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Location = new Point(25, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 285);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(773, 22);
            label2.Name = "label2";
            label2.Size = new Size(218, 63);
            label2.TabIndex = 13;
            label2.Text = "Orders";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button3.BackColor = Color.Teal;
            button3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(441, 472);
            button3.Name = "button3";
            button3.Size = new Size(130, 40);
            button3.TabIndex = 14;
            button3.Text = "Previous";
            button3.UseVisualStyleBackColor = false;
            button3.Click += prevBtn;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(842, 472);
            button4.Name = "button4";
            button4.Size = new Size(130, 40);
            button4.TabIndex = 15;
            button4.Text = "Next";
            button4.UseVisualStyleBackColor = false;
            button4.Click += nextBtn;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1003, 628);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "OrdersForm";
            Text = "Orders";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label3;
        private Panel panel1;
        private Label label2;
        private Button button3;
        private Button button4;
    }
}