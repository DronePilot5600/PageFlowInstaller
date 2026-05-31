namespace PageFlowInstaller
{
    partial class StartScreen
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
            lbl_Header = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 25F);
            lbl_Header.ForeColor = Color.White;
            lbl_Header.Location = new Point(118, 9);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(289, 46);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "PageFlow Installer";
            lbl_Header.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageFlow_Logo;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 114);
            label1.Name = "label1";
            label1.Size = new Size(201, 28);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Pageflow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 158);
            label2.Name = "label2";
            label2.Size = new Size(559, 15);
            label2.TabIndex = 3;
            label2.Text = "Vielen Dank dass Sie Pageflow benutzen, in den folgenden Schritten werden Sie nun Pageflow installieren";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 186, 84);
            button1.FlatAppearance.BorderColor = Color.FromArgb(26, 186, 84);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "weiter";
            button1.UseVisualStyleBackColor = false;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 28, 30);
            ClientSize = new Size(830, 214);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Header);
            Name = "StartScreen";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Header;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
