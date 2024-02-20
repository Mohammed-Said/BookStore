﻿namespace BookStore.Admin.Forms
{
  partial class BooksForm
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
            getOne = new Button();
            addBtn = new Button();
            updateBtn = new Button();
            button5 = new Button();
            nextBtn = new Button();
            prevBtn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.ColumnHeadersHeight = 34;
            dataGridView1.Location = new Point(438, 59);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(568, 280);
            dataGridView1.TabIndex = 0;
            // 
            // getOne
            // 
            getOne.BackColor = Color.OrangeRed;
            getOne.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            getOne.Location = new Point(30, 428);
            getOne.Margin = new Padding(2);
            getOne.Name = "getOne";
            getOne.Size = new Size(161, 40);
            getOne.TabIndex = 4;
            getOne.Text = "Get One";
            getOne.UseVisualStyleBackColor = false;
            getOne.Click += getOne_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.OrangeRed;
            addBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(30, 364);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 40);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.OrangeRed;
            updateBtn.BackgroundImageLayout = ImageLayout.None;
            updateBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            updateBtn.Location = new Point(210, 364);
            updateBtn.Margin = new Padding(2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 40);
            updateBtn.TabIndex = 6;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.OrangeRed;
            button5.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(210, 428);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(161, 40);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // nextBtn
            // 
            nextBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            nextBtn.BackColor = Color.SeaGreen;
            nextBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nextBtn.Location = new Point(840, 373);
            nextBtn.Margin = new Padding(2);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(129, 31);
            nextBtn.TabIndex = 8;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            prevBtn.BackColor = Color.SaddleBrown;
            prevBtn.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            prevBtn.Location = new Point(478, 369);
            prevBtn.Margin = new Padding(2);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(129, 31);
            prevBtn.TabIndex = 9;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(36, 11);
            textBox1.MaximumSize = new Size(250, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Book Name";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 10;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(36, 76);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Stock";
            textBox2.Size = new Size(250, 34);
            textBox2.TabIndex = 11;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(36, 143);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Description";
            textBox3.Size = new Size(250, 34);
            textBox3.TabIndex = 12;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(36, 205);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Price";
            textBox4.Size = new Size(250, 34);
            textBox4.TabIndex = 13;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(36, 271);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Image";
            textBox5.Size = new Size(250, 34);
            textBox5.TabIndex = 14;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Location = new Point(30, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(319, 327);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(617, 8);
            label1.Name = "label1";
            label1.Size = new Size(215, 45);
            label1.TabIndex = 16;
            label1.Text = "All Books";
            // 
            // BooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1033, 494);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(prevBtn);
            Controls.Add(nextBtn);
            Controls.Add(button5);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(getOne);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "BooksForm";
            Text = "Books";
            Load += BooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button getOne;
        private Button addBtn;
        private Button updateBtn;
        private Button button5;
        private Button nextBtn;
        private Button prevBtn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel panel1;
        private Label label1;
    }
}