using DSR.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Codes
{
    class Client
    {
        //SqlConnection con = new SqlConnection("Network Library=DBMSSOCN; Data Source=LENSX,1433; Initial Catalog=bd_daily_security; User Id=sa; Password=Windy@2015.com?;");
        Connex cnx = new Connex();
        public void load_client_info(DataGridView dtg)
        {
            //cnx.Connect();
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                var cmd = new SqlCommand("load_client", Connex.con) { CommandType = CommandType.StoredProcedure };
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
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

        public void load_list_client(ListBox lst)
        {
            var cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                var cmd = new SqlCommand("get_code_client", Connex.con) { CommandType = CommandType.StoredProcedure };
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(dr[0]);
                }
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
        public void load_list_client(ComboBox lst)
        {
            var cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                var cmd = new SqlCommand("get_code_client", Connex.con) { CommandType = CommandType.StoredProcedure };
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                lst.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    lst.Items.Add(dr[0]);
                }
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
        public void search_client_info_by_code(DataGridView dtg, string datex)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_client_by_code";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = datex;

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Searching Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Failed Database Searching", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public void search_client_info_by_city(DataGridView dtg, string datex)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_client_by_city";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("client_city", SqlDbType.NVarChar)).Value = datex;

                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Searching Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Failed Database Searching", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public void insert_client(string client_code, string client_town, string client_fullname)
        {
            var cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "insert_client";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client_code;
                cmd.Parameters.Add(new SqlParameter("client_city", SqlDbType.NVarChar)).Value = client_town;
                cmd.Parameters.Add(new SqlParameter("client_name", SqlDbType.NVarChar)).Value = client_fullname;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Client's informations inserted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Insertion failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Failed Database Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        public void update_client(string client_code, string client_town, string client_fullname)
        {
            var cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "update_client";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client_code;
                cmd.Parameters.Add(new SqlParameter("client_city", SqlDbType.NVarChar)).Value = client_town;
                cmd.Parameters.Add(new SqlParameter("client_name", SqlDbType.NVarChar)).Value = client_fullname;


                cmd.ExecuteNonQuery();
                MessageBox.Show("Client's informations updated succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Failed Database Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally
            {
                Connex.con.Close();
            }
        }
        public void delete_client(string client_code)
        {
            var cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "delete_client";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client_code;     

                cmd.ExecuteNonQuery();
                MessageBox.Show("Client's informations deleted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Deleting failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Will you please see the error code?", "Failed Database Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally
            {
                Connex.con.Close();
            }
        }
    }
}
