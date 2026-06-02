using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace PageFlowInstaller
{
    internal class SqlCommunication
    {
        public static bool TestConnection(string connectionString)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connection Test failed \n Error: " + ex.ToString());
                return false;
            }
        }
    }
}
