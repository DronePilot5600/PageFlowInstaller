namespace PageFlowInstaller
{
    partial class AddUser
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lbl_Header = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tb_pwd = new TextBox();
            tb_pwd_rep = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 186, 84);
            button1.FlatAppearance.BorderColor = Color.FromArgb(26, 186, 84);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(702, 295);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "weiter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(30, 40, 43);
            pictureBox2.Location = new Point(12, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 222);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageFlow_Logo;
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 25F);
            lbl_Header.ForeColor = Color.White;
            lbl_Header.Location = new Point(115, 9);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(289, 46);
            lbl_Header.TabIndex = 16;
            lbl_Header.Text = "PageFlow Installer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 40, 43);
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(19, 120);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 20;
            label6.Text = "Admin erstellen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 40, 43);
            label1.Location = new Point(21, 185);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 21;
            label1.Text = "Benutzername: Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 40, 43);
            label2.Location = new Point(21, 148);
            label2.Name = "label2";
            label2.Size = new Size(630, 15);
            label2.TabIndex = 22;
            label2.Text = "Innerhalb dieses Schrittes erstellen Sie den ersten Nutzer den Sie dann benötigen um alle anderen Nutzer hinzuzufügen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 40, 43);
            label3.Location = new Point(21, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 23;
            label3.Text = "Passwort:";
            // 
            // tb_pwd
            // 
            tb_pwd.BackColor = Color.FromArgb(21, 28, 30);
            tb_pwd.BorderStyle = BorderStyle.None;
            tb_pwd.Location = new Point(137, 202);
            tb_pwd.Name = "tb_pwd";
            tb_pwd.Size = new Size(640, 16);
            tb_pwd.TabIndex = 24;
            // 
            // tb_pwd_rep
            // 
            tb_pwd_rep.BackColor = Color.FromArgb(21, 28, 30);
            tb_pwd_rep.BorderStyle = BorderStyle.None;
            tb_pwd_rep.Location = new Point(137, 224);
            tb_pwd_rep.Name = "tb_pwd_rep";
            tb_pwd_rep.Size = new Size(640, 16);
            tb_pwd_rep.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 40, 43);
            label4.Location = new Point(21, 225);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 25;
            label4.Text = "Passwort bestätigen:";
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 28, 30);
            ClientSize = new Size(800, 347);
            Controls.Add(tb_pwd_rep);
            Controls.Add(label4);
            Controls.Add(tb_pwd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Header);
            ForeColor = Color.White;
            Name = "AddUser";
            Text = "AddUser";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lbl_Header;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tb_pwd;
        private TextBox tb_pwd_rep;
        private Label label4;
    }
}