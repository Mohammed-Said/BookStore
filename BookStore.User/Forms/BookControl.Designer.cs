﻿namespace BookStore.User.Forms
{
  partial class BookControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      pictureBox1 = new PictureBox();
      label1 = new Label();
      label2 = new Label();
      button1 = new Button();
      flowLayoutPanel1 = new FlowLayoutPanel();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      flowLayoutPanel1.SuspendLayout();
      SuspendLayout();
      // 
      // pictureBox1
      // 
      pictureBox1.Dock = DockStyle.Top;
      pictureBox1.Location = new Point(0, 0);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(383, 395);
      pictureBox1.TabIndex = 0;
      pictureBox1.TabStop = false;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label1.ForeColor = Color.FromArgb(85, 85, 85);
      label1.Location = new Point(25, 5);
      label1.Margin = new Padding(25, 5, 3, 0);
      label1.Name = "label1";
      label1.Size = new Size(83, 32);
      label1.TabIndex = 1;
      label1.Text = "label1";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      label2.Location = new Point(25, 47);
      label2.Margin = new Padding(25, 10, 3, 0);
      label2.Name = "label2";
      label2.Size = new Size(83, 32);
      label2.TabIndex = 2;
      label2.Text = "label2";
      // 
      // button1
      // 
      button1.BackColor = Color.FromArgb(39, 55, 77);
      button1.Cursor = Cursors.Hand;
      button1.FlatAppearance.BorderSize = 0;
      button1.FlatStyle = FlatStyle.Flat;
      button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
      button1.ForeColor = Color.FromArgb(221, 230, 237);
      button1.Location = new Point(24, 546);
      button1.Name = "button1";
      button1.Size = new Size(338, 57);
      button1.TabIndex = 3;
      button1.Text = "Add To Cart";
      button1.UseVisualStyleBackColor = false;
      button1.Click += button1_Click;
      // 
      // flowLayoutPanel1
      // 
      flowLayoutPanel1.Controls.Add(label1);
      flowLayoutPanel1.Controls.Add(label2);
      flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
      flowLayoutPanel1.Location = new Point(0, 395);
      flowLayoutPanel1.Name = "flowLayoutPanel1";
      flowLayoutPanel1.Size = new Size(380, 145);
      flowLayoutPanel1.TabIndex = 4;
      // 
      // BookControl
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.WhiteSmoke;
      Controls.Add(flowLayoutPanel1);
      Controls.Add(button1);
      Controls.Add(pictureBox1);
      Margin = new Padding(10);
      Name = "BookControl";
      Size = new Size(383, 624);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      flowLayoutPanel1.ResumeLayout(false);
      flowLayoutPanel1.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private PictureBox pictureBox1;
    private Label label1;
    private Label label2;
    private Button button1;
    private FlowLayoutPanel flowLayoutPanel1;
  }
}
