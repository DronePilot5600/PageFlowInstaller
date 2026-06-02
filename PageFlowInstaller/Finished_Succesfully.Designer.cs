namespace PageFlowInstaller
{
    partial class Finished_Succesfully
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
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 186, 84);
            button1.FlatAppearance.BorderColor = Color.FromArgb(26, 186, 84);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 182);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Fertig";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 152);
            label2.Name = "label2";
            label2.Size = new Size(488, 15);
            label2.TabIndex = 8;
            label2.Text = "PageFlow ist nun bereit eingesetzt zu werden, Sie können nun die Hauptanwendung starten";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 117);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 7;
            label1.Text = "Alles fertig!";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageFlow_Logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 25F);
            lbl_Header.ForeColor = Color.White;
            lbl_Header.Location = new Point(118, 12);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(289, 46);
            lbl_Header.TabIndex = 5;
            lbl_Header.Text = "PageFlow Installer";
            // 
            // Finished_Succesfully
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 28, 30);
            ClientSize = new Size(583, 221);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Header);
            Name = "Finished_Succesfully";
            Text = "Finished_Succesfully";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label lbl_Header;
    }
}