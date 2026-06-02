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

            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AdminCreationFile.txt";
            string uname = "admin";
            string pwd_tmp = tb_pwd.Text;

            if(!File.Exists(FilePath))
            {
                File.Create(FilePath);
            }

            if (tb_pwd.TextLength < 5 || tb_pwd.Text != tb_pwd_rep.Text)
            {
                Debug.WriteLine("Error Password not matching:" + tb_pwd.Text != tb_pwd_rep.Text);
                MessageBox.Show("Das Passwort muss mindestens 5 Zeichen lang sein und beide Passwörter müssen übereinstimmen.");
                return;

            }
            else
            {
                using (StreamWriter sw = new StreamWriter(FilePath, false))
                {
                    sw.WriteLine(uname);
                    sw.WriteLine(pwd_tmp);
                }

                Debug.WriteLine("Succesfully added AdminCreationFile");

                Finished_Succesfully nextstep = new Finished_Succesfully();
                nextstep.Show();
                this.Hide();
            }
        }

    }
}
