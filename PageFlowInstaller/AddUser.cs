using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PageFlowInstaller
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname = "admin";
            string pwd_tmp = tb_pwd.Text;

            if (tb_pwd.TextLength > 4 || tb_pwd.Text != tb_pwd_rep.Text)
            {
                MessageBox.Show("Das Passwort muss mindestens 5 Zeichen lang sein und beide Passwörter müssen übereinstimmen.");
                return;

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AdminCreationFile.txt", false))
                {
                    sw.WriteLine("uname=" + uname);
                    sw.WriteLine("pwd=" + pwd_tmp);
                }

                Debug.WriteLine("Succesfully added AdminCreationFile");
            }
        }

    }
}
