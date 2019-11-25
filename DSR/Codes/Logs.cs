using DSR.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Codes
{
    class Logs
    {
        public void load_logs_info(DataGridView dtg)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                var cmd = new SqlCommand("load_logs", Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
                //MessageBox.Show("Data loaded successfully!", "Loading with Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Loading data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Loading data Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally { Connex.con.Close(); Connex.con.Dispose(); }
        }
        public void insert_logs(DateTime control_date, string machine_name, string username_comp, string os_version)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "insert_logs";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };                
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.DateTime)).Value = control_date;
                cmd.Parameters.Add(new SqlParameter("machine_name", SqlDbType.NVarChar)).Value = machine_name;
                cmd.Parameters.Add(new SqlParameter("username_comp", SqlDbType.NVarChar)).Value = username_comp;
                cmd.Parameters.Add(new SqlParameter("os_version", SqlDbType.NVarChar)).Value = os_version;               

                cmd.ExecuteNonQuery();
                //MessageBox.Show("Connected succesfully to database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Verify your connection to the Enterprise's LAN!", "Connection failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Do you want to see the error code?", "Failed Database Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally
            {
                Connex.con.Close(); Connex.con.Dispose();
            }
        }
    }
}
