namespace BookStore.Admin.Forms
{
  partial class CustomerForm
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 32);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(445, 72);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(600, 396);
            dataGridView1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(17, 27);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "First Name";
            textBox2.Size = new Size(137, 23);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(220, 29);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Last Name";
            textBox3.Size = new Size(137, 23);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(17, 89);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Address";
            textBox4.Size = new Size(137, 23);
            textBox4.TabIndex = 5;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(220, 89);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Phone";
            textBox5.Size = new Size(137, 23);
            textBox5.TabIndex = 6;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 149);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Password";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 7;
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(220, 149);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "UserName";
            textBox7.Size = new Size(137, 23);
            textBox7.TabIndex = 8;
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 212);
            textBox8.Name = "textBox8";
            textBox8.PlaceholderText = "Email";
            textBox8.Size = new Size(134, 23);
            textBox8.TabIndex = 9;
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(220, 212);
            textBox9.Name = "textBox9";
            textBox9.PlaceholderText = "ProfilePic";
            textBox9.Size = new Size(137, 23);
            textBox9.TabIndex = 10;
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(17, 279);
            textBox10.Name = "textBox10";
            textBox10.PlaceholderText = "Admin ";
            textBox10.Size = new Size(129, 23);
            textBox10.TabIndex = 11;
            textBox10.TextAlign = HorizontalAlignment.Center;
            textBox10.TextChanged += textBox10_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Olive;
            button1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(24, 402);
            button1.Name = "button1";
            button1.Size = new Size(105, 37);
            button1.TabIndex = 12;
            button1.Text = "Add ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ADD_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 279);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Customer ID";
            textBox1.Size = new Size(137, 23);
            textBox1.TabIndex = 13;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.Olive;
            button2.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(203, 402);
            button2.Name = "button2";
            button2.Size = new Size(100, 37);
            button2.TabIndex = 14;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Update_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Olive;
            button3.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Location = new Point(24, 463);
            button3.Name = "button3";
            button3.Size = new Size(105, 37);
            button3.TabIndex = 15;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += GetOne_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Olive;
            button4.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Location = new Point(203, 463);
            button4.Name = "button4";
            button4.Size = new Size(100, 37);
            button4.TabIndex = 16;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = false;
            button4.Click += DeleteClick;
            // 
            // button5
            // 
            button5.BackColor = Color.Maroon;
            button5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(489, 483);
            button5.Name = "button5";
            button5.Size = new Size(105, 37);
            button5.TabIndex = 17;
            button5.Text = "Previous";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Green;
            button6.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.Location = new Point(838, 483);
            button6.Name = "button6";
            button6.Size = new Size(105, 37);
            button6.TabIndex = 18;
            button6.Text = "Next";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox7);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(textBox9);
            panel1.Controls.Add(textBox10);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 384);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(620, 21);
            label2.Name = "label2";
            label2.Size = new Size(236, 45);
            label2.TabIndex = 20;
            label2.Text = "Customers";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 521);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "CustomerForm";
            Text = "Customers";
            Load += CustomerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    private DataGridView dataGridView1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel panel1;
        private Label label2;
    }
}