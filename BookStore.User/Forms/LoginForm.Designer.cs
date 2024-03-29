﻿namespace BookStore.User.Forms
{
  partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Imgpanel = new Panel();
            LoginPanel = new Panel();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            label2 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            label1 = new Label();
            LoginPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Imgpanel
            // 
            Imgpanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Imgpanel.BackgroundImage = (Image)resources.GetObject("Imgpanel.BackgroundImage");
            Imgpanel.BackgroundImageLayout = ImageLayout.Zoom;
            Imgpanel.Location = new Point(499, 0);
            Imgpanel.Margin = new Padding(2);
            Imgpanel.Name = "Imgpanel";
            Imgpanel.Size = new Size(1015, 755);
            Imgpanel.TabIndex = 0;
            // 
            // LoginPanel
            // 
            LoginPanel.BackColor = Color.FromArgb(6, 53, 71);
            LoginPanel.Controls.Add(label3);
            LoginPanel.Controls.Add(linkLabel1);
            LoginPanel.Controls.Add(label2);
            LoginPanel.Controls.Add(button1);
            LoginPanel.Controls.Add(panel2);
            LoginPanel.Controls.Add(panel1);
            LoginPanel.Controls.Add(label1);
            LoginPanel.Dock = DockStyle.Left;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Margin = new Padding(2);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(501, 755);
            LoginPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 192, 192);
            label3.Location = new Point(74, 393);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "label3";
            label3.Visible = false;
            label3.Click += label3_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.White;
            linkLabel1.Location = new Point(246, 492);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(57, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "SignUp";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(238, 238, 238);
            label2.Location = new Point(74, 492);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(170, 20);
            label2.TabIndex = 5;
            label2.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(205, 205, 205);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(6, 53, 71);
            button1.Location = new Point(74, 428);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(337, 62);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(238, 238, 238);
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(74, 329);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 2, 8, 2);
            panel2.Size = new Size(335, 46);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(238, 238, 238);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 7);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Enter your password";
            textBox1.Size = new Size(302, 32);
            textBox1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(textBox2);
            panel1.Location = new Point(74, 251);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8, 2, 8, 2);
            panel1.Size = new Size(335, 46);
            panel1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = Color.FromArgb(238, 238, 238);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(10, 7);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter your user name";
            textBox2.Size = new Size(310, 32);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(170, 155);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 57);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1514, 755);
            Controls.Add(LoginPanel);
            Controls.Add(Imgpanel);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Imgpanel;
    private Panel LoginPanel;
    private Label label1;
    private Panel panel1;
    private TextBox textBox2;
    private Panel panel2;
    private TextBox textBox1;
    private Button button1;
    private Label label2;
    private LinkLabel linkLabel1;
    private Label label3;
  }
}