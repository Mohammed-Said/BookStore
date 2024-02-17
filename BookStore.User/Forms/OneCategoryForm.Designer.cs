namespace BookStore.User.Forms
{
    partial class OneCategoryForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            prevBtn = new Button();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(339, 151);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(300, 150);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(56, 379);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(112, 34);
            prevBtn.TabIndex = 1;
            prevBtn.Text = "button1";
            prevBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            nextBtn.Location = new Point(579, 379);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(112, 34);
            nextBtn.TabIndex = 2;
            nextBtn.Text = "button2";
            nextBtn.UseVisualStyleBackColor = true;
            // 
            // OneCategoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextBtn);
            Controls.Add(prevBtn);
            Controls.Add(flowLayoutPanel1);
            Name = "OneCategoryForm";
            Text = "OneCategoryForm";
            Load += OneCategoryForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button prevBtn;
        private Button nextBtn;
    }
}