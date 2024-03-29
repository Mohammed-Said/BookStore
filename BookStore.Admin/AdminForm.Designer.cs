﻿namespace BookStore.Admin
{
  partial class AdminForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            panelMenu = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            HeaderPanel = new Panel();
            Headerlabel = new Label();
            DesktopPanel = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(82, 109, 130);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(2, 2, 2, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(218, 524);
            panelMenu.TabIndex = 0;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 406);
            button5.Margin = new Padding(2, 2, 2, 2);
            button5.Name = "button5";
            button5.Padding = new Padding(7, 0, 0, 0);
            button5.Size = new Size(218, 80);
            button5.TabIndex = 4;
            button5.Text = "LogOut";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(238, 238, 238);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 326);
            button4.Margin = new Padding(2, 2, 2, 2);
            button4.Name = "button4";
            button4.Padding = new Padding(7, 0, 0, 0);
            button4.Size = new Size(218, 80);
            button4.TabIndex = 3;
            button4.Text = "     Categories";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(238, 238, 238);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 246);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Padding = new Padding(7, 0, 0, 0);
            button3.Size = new Size(218, 80);
            button3.TabIndex = 2;
            button3.Text = "  Orders";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(238, 238, 238);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 166);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(7, 0, 0, 0);
            button2.Size = new Size(218, 80);
            button2.TabIndex = 1;
            button2.Text = "    Customers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(238, 238, 238);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 86);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(7, 0, 0, 0);
            button1.Size = new Size(218, 80);
            button1.TabIndex = 0;
            button1.Text = "Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(39, 55, 77);
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(2, 2, 2, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(218, 86);
            panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Broadway", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(238, 238, 238);
            label1.Location = new Point(8, 24);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 31);
            label1.TabIndex = 0;
            label1.Text = "BookStore";
            // 
            // HeaderPanel
            // 
            HeaderPanel.BackColor = Color.FromArgb(39, 55, 77);
            HeaderPanel.Controls.Add(Headerlabel);
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.Location = new Point(218, 0);
            HeaderPanel.Margin = new Padding(2, 2, 2, 2);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(893, 86);
            HeaderPanel.TabIndex = 1;
            // 
            // Headerlabel
            // 
            Headerlabel.Anchor = AnchorStyles.None;
            Headerlabel.AutoSize = true;
            Headerlabel.FlatStyle = FlatStyle.Flat;
            Headerlabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Headerlabel.ForeColor = Color.FromArgb(238, 238, 238);
            Headerlabel.Location = new Point(368, 24);
            Headerlabel.Margin = new Padding(2, 0, 2, 0);
            Headerlabel.Name = "Headerlabel";
            Headerlabel.Size = new Size(111, 45);
            Headerlabel.TabIndex = 0;
            Headerlabel.Text = "Home";
            Headerlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DesktopPanel
            // 
            DesktopPanel.Dock = DockStyle.Fill;
            DesktopPanel.Location = new Point(218, 86);
            DesktopPanel.Margin = new Padding(2, 2, 2, 2);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(893, 438);
            DesktopPanel.TabIndex = 2;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 524);
            Controls.Add(DesktopPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(panelMenu);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(1123, 530);
            Name = "AdminForm";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button1;
    private Panel HeaderPanel;
    private Panel panelLogo;
    private Label label1;
    private Label Headerlabel;
    private Panel DesktopPanel;
  }
}
