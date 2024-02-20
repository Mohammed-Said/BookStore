namespace BookStore.Admin.Forms
{
  partial class CategoriesForm
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
            textBox1 = new TextBox();
            addBtn = new Button();
            updateBtn = new Button();
            getOne = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(376, 36);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(638, 265);
            dataGridView1.TabIndex = 24;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(38, 89);
            textBox1.MaximumSize = new Size(250, 62);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category Name";
            textBox1.Size = new Size(250, 34);
            textBox1.TabIndex = 25;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(11, 302);
            addBtn.Margin = new Padding(2);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(161, 40);
            addBtn.TabIndex = 26;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(176, 302);
            updateBtn.Margin = new Padding(2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(161, 40);
            updateBtn.TabIndex = 27;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // getOne
            // 
            getOne.Location = new Point(11, 380);
            getOne.Margin = new Padding(2);
            getOne.Name = "getOne";
            getOne.Size = new Size(161, 40);
            getOne.TabIndex = 28;
            getOne.Text = "Get One";
            getOne.UseVisualStyleBackColor = true;
            getOne.Click += getOne_Click;
            // 
            // button5
            // 
            button5.Location = new Point(176, 380);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(161, 40);
            button5.TabIndex = 29;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 465);
            Controls.Add(button5);
            Controls.Add(getOne);
            Controls.Add(updateBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Margin = new Padding(2);
            Name = "CategoriesForm";
            Text = "Categories";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button addBtn;
        private Button updateBtn;
        private Button getOne;
        private Button button5;
       
    }
}