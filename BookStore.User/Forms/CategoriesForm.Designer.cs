namespace BookStore.User.Forms
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            code = new Button();
            Fiction = new Button();
            Science = new Button();
            Beauty = new Button();
            Suspense = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.design_thinking;
            pictureBox1.Location = new Point(99, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.poster;
            pictureBox2.Location = new Point(676, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(233, 239);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pencil_case;
            pictureBox3.Location = new Point(963, 279);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(233, 239);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.science_book;
            pictureBox4.Location = new Point(1254, 279);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(233, 239);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Control;
            pictureBox5.Image = Properties.Resources.globe;
            pictureBox5.Location = new Point(390, 279);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(235, 239);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(511, 129);
            label1.Name = "label1";
            label1.Size = new Size(462, 66);
            label1.TabIndex = 5;
            label1.Text = "Books Category";
            label1.Click += label1_Click;
            // 
            // code
            // 
            code.BackColor = Color.FromArgb(39, 55, 77);
            code.Cursor = Cursors.Hand;
            code.FlatAppearance.BorderSize = 0;
            code.FlatStyle = FlatStyle.Flat;
            code.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            code.ForeColor = Color.FromArgb(255, 192, 192);
            code.Location = new Point(99, 533);
            code.Name = "code";
            code.Size = new Size(233, 57);
            code.TabIndex = 20;
            code.Text = "Code";
            code.UseVisualStyleBackColor = false;
            code.Click += code_Click;
            // 
            // Fiction
            // 
            Fiction.BackColor = Color.FromArgb(39, 55, 77);
            Fiction.Cursor = Cursors.Hand;
            Fiction.FlatAppearance.BorderSize = 0;
            Fiction.FlatStyle = FlatStyle.Flat;
            Fiction.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Fiction.ForeColor = Color.FromArgb(255, 192, 192);
            Fiction.Location = new Point(392, 533);
            Fiction.Name = "Fiction";
            Fiction.Size = new Size(233, 57);
            Fiction.TabIndex = 25;
            Fiction.Text = "Fiction";
            Fiction.UseVisualStyleBackColor = false;
            Fiction.Click += Fiction_Click;
            // 
            // Science
            // 
            Science.BackColor = Color.FromArgb(39, 55, 77);
            Science.Cursor = Cursors.Hand;
            Science.FlatAppearance.BorderSize = 0;
            Science.FlatStyle = FlatStyle.Flat;
            Science.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Science.ForeColor = Color.FromArgb(255, 192, 192);
            Science.Location = new Point(1254, 533);
            Science.Name = "Science";
            Science.Size = new Size(233, 57);
            Science.TabIndex = 26;
            Science.Text = "Science";
            Science.UseVisualStyleBackColor = false;
            Science.Click += Science_Click;
            // 
            // Beauty
            // 
            Beauty.BackColor = Color.FromArgb(39, 55, 77);
            Beauty.Cursor = Cursors.Hand;
            Beauty.FlatAppearance.BorderSize = 0;
            Beauty.FlatStyle = FlatStyle.Flat;
            Beauty.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Beauty.ForeColor = Color.FromArgb(255, 192, 192);
            Beauty.Location = new Point(963, 533);
            Beauty.Name = "Beauty";
            Beauty.Size = new Size(233, 57);
            Beauty.TabIndex = 27;
            Beauty.Text = "Beauty";
            Beauty.UseVisualStyleBackColor = false;
            Beauty.Click += Beauty_Click;
            // 
            // Suspense
            // 
            Suspense.BackColor = Color.FromArgb(39, 55, 77);
            Suspense.Cursor = Cursors.Hand;
            Suspense.FlatAppearance.BorderSize = 0;
            Suspense.FlatStyle = FlatStyle.Flat;
            Suspense.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            Suspense.ForeColor = Color.FromArgb(255, 192, 192);
            Suspense.Location = new Point(676, 533);
            Suspense.Name = "Suspense";
            Suspense.Size = new Size(233, 57);
            Suspense.TabIndex = 28;
            Suspense.Text = "Suspense";
            Suspense.UseVisualStyleBackColor = false;
            Suspense.Click += Suspense_Click;
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1603, 719);
            Controls.Add(Suspense);
            Controls.Add(Beauty);
            Controls.Add(Science);
            Controls.Add(Fiction);
            Controls.Add(code);
            Controls.Add(label1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CategoriesForm";
            Text = "Categories";
            Load += CategoriesForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label1;
        private Button code;
        private Button Fiction;
        private Button Science;
        private Button Beauty;
        private Button Suspense;
    }
}