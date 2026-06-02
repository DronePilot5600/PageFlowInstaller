namespace PageFlowInstaller
{
    partial class GettingInfo
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
            lbl_Header = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_con = new TextBox();
            tb_dbpwd = new TextBox();
            tb_dbuser = new TextBox();
            bt_proceed = new Button();
            cbk_sspi = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.PageFlow_Logo;
            pictureBox1.Location = new Point(9, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.TabIndex = 3;
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
            lbl_Header.TabIndex = 2;
            lbl_Header.Text = "PageFlow Installer";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(30, 40, 43);
            pictureBox2.Location = new Point(12, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(776, 222);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(30, 40, 43);
            label1.Location = new Point(20, 165);
            label1.Name = "label1";
            label1.Size = new Size(319, 15);
            label1.TabIndex = 5;
            label1.Text = "Bitte geben Sie folgende Informationen an um fortzufahren";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 40, 43);
            label2.Location = new Point(20, 190);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 6;
            label2.Text = "Datenbankverbindung: ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 40, 43);
            label3.Location = new Point(42, 215);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 7;
            label3.Text = "Inetgrated Security:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 40, 43);
            label4.Location = new Point(38, 239);
            label4.Name = "label4";
            label4.Size = new Size(113, 15);
            label4.TabIndex = 8;
            label4.Text = "Datenbankbenutzer:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 40, 43);
            label5.Location = new Point(94, 264);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Passwort:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 40, 43);
            label6.Font = new Font("Segoe UI", 15F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 129);
            label6.Name = "label6";
            label6.Size = new Size(202, 28);
            label6.TabIndex = 10;
            label6.Text = "Datenbankanbindung";
            // 
            // tb_con
            // 
            tb_con.BackColor = Color.FromArgb(21, 28, 30);
            tb_con.BorderStyle = BorderStyle.None;
            tb_con.ForeColor = Color.FromArgb(0, 15, 255, 255);
            tb_con.Location = new Point(146, 187);
            tb_con.Name = "tb_con";
            tb_con.Size = new Size(631, 16);
            tb_con.TabIndex = 11;
            // 
            // tb_dbpwd
            // 
            tb_dbpwd.BackColor = Color.FromArgb(21, 28, 30);
            tb_dbpwd.BorderStyle = BorderStyle.None;
            tb_dbpwd.ForeColor = Color.FromArgb(0, 15, 255, 255);
            tb_dbpwd.Location = new Point(146, 264);
            tb_dbpwd.Name = "tb_dbpwd";
            tb_dbpwd.Size = new Size(631, 16);
            tb_dbpwd.TabIndex = 12;
            // 
            // tb_dbuser
            // 
            tb_dbuser.BackColor = Color.FromArgb(21, 28, 30);
            tb_dbuser.BorderStyle = BorderStyle.None;
            tb_dbuser.ForeColor = Color.FromArgb(0, 15, 255, 255);
            tb_dbuser.Location = new Point(146, 239);
            tb_dbuser.Name = "tb_dbuser";
            tb_dbuser.Size = new Size(631, 16);
            tb_dbuser.TabIndex = 13;
            // 
            // bt_proceed
            // 
            bt_proceed.BackColor = Color.FromArgb(26, 186, 84);
            bt_proceed.FlatAppearance.BorderColor = Color.FromArgb(26, 186, 84);
            bt_proceed.FlatStyle = FlatStyle.Flat;
            bt_proceed.ForeColor = Color.White;
            bt_proceed.Location = new Point(702, 295);
            bt_proceed.Name = "bt_proceed";
            bt_proceed.Size = new Size(75, 23);
            bt_proceed.TabIndex = 15;
            bt_proceed.Text = "weiter";
            bt_proceed.UseVisualStyleBackColor = false;
            bt_proceed.Click += bt_proceed_Click;
            // 
            // cbk_sspi
            // 
            cbk_sspi.AutoSize = true;
            cbk_sspi.Location = new Point(149, 217);
            cbk_sspi.Name = "cbk_sspi";
            cbk_sspi.Size = new Size(15, 14);
            cbk_sspi.TabIndex = 16;
            cbk_sspi.UseVisualStyleBackColor = true;
            // 
            // GettingInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(21, 28, 30);
            ClientSize = new Size(800, 345);
            Controls.Add(cbk_sspi);
            Controls.Add(bt_proceed);
            Controls.Add(tb_dbuser);
            Controls.Add(tb_dbpwd);
            Controls.Add(tb_con);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_Header);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "GettingInfo";
            Text = "GettingInfo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Header;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_con;
        private TextBox tb_dbpwd;
        private TextBox tb_dbuser;
        private Button bt_proceed;
        private CheckBox cbk_sspi;
    }
}