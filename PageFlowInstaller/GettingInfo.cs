using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PageFlowInstaller
{
    public partial class GettingInfo : Form
    {
        public GettingInfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_proceed_Click(object sender, EventArgs e)
        {
            string db_name = tb_con.Text;
            string db_user = tb_dbuser.Text;
            string db_pwd = tb_dbpwd.Text;
            bool sspi = cbk_sspi.Checked;

            string FilePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\PageFlow_Properties.txt";
            Debug.WriteLine(FilePath);

            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
            }

            if (db_name.Equals("") || (db_user.Equals("") && !sspi) || (db_pwd.Equals("") && !sspi))
            {
                MessageBox.Show("Bitte füllen Sie alle benötigten Felder aus");
                return;
            }

            else
            {
                Debug.WriteLine("Data Source=localhost;Initial Catalog=" + db_name + ";Integrated Security=" + sspi + ";User ID=" + db_user + ";Password=" + db_pwd + ";Trust Server Certificate=False");
                if(SqlCommunication.TestConnection("Data Source="+db_name+";Initial Catalog = Master; Integrated Security=" + sspi + ";User ID=" + db_user + ";Password=" + db_pwd + ";Encrypt = false") == false)
                {
                    MessageBox.Show("Verbindung zur Datenbank konnte nicht hergestellt werden. Bitte überprüfen Sie Ihre Eingaben.");
                }



                using (StreamWriter sw = new StreamWriter(FilePath, false))
                {
                    sw.WriteLine("db_name=" + db_name);
                    sw.WriteLine("sspi=" + sspi);
                    sw.WriteLine("db_user=" + db_user);
                    sw.WriteLine("db_pwd=" + db_pwd);

                    Debug.WriteLine("File Succesfully created");
                }

                AddUser nextstep = new AddUser();
                nextstep.Show();
                this.Hide();
            }
        }

        private void cbk_sspi_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbk_sspi.Checked)
            {
                tb_dbpwd.Enabled = false;
                tb_dbuser.Enabled = false;
            }
            else
            {
                tb_dbpwd.Enabled = true;
                tb_dbuser.Enabled = true;
            }
        }
    }
}
