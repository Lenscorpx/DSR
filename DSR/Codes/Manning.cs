using DSR.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Codes
{
    class Manning
    {
        public void load_manning_info(DataGridView dtg)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                var cmd = new SqlCommand("load_manning", Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
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
        public void search_manning_info_by_client(DataGridView dtg, string client_x)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_manning_by_client";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@client_code", SqlDbType.NVarChar)).Value = client_x;

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
        public void search_manning_info_by_date(DataGridView dtg, DateTime client_x)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_manning_by_date";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@control_date", SqlDbType.Date)).Value = client_x;

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
        public void insert_manning_info(int day_number,int night_number, int total_number, string observ, int shift_pat, string type_guard, DateTime control_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "insert_manning";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("day_number", SqlDbType.Int)).Value = day_number;
                cmd.Parameters.Add(new SqlParameter("night_number", SqlDbType.Int)).Value = night_number;
                cmd.Parameters.Add(new SqlParameter("total_number", SqlDbType.Int)).Value = total_number;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observ;
                cmd.Parameters.Add(new SqlParameter("shift_pattern", SqlDbType.Int)).Value = shift_pat;
                cmd.Parameters.Add(new SqlParameter("type_guard", SqlDbType.NVarChar)).Value = type_guard;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = control_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Manning's informations inserted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        public void update_manning_info(int rec, int day_number, int night_number, int total_number, string observ, int shift_pat, string type_guard, DateTime control_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "update_manning";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_manning", SqlDbType.Int)).Value = rec;
                cmd.Parameters.Add(new SqlParameter("day_number", SqlDbType.Int)).Value = day_number;
                cmd.Parameters.Add(new SqlParameter("night_number", SqlDbType.Int)).Value = night_number;
                cmd.Parameters.Add(new SqlParameter("total_number", SqlDbType.Int)).Value = total_number;
                cmd.Parameters.Add(new SqlParameter("observation", SqlDbType.NVarChar)).Value = observ;
                cmd.Parameters.Add(new SqlParameter("shift_pattern", SqlDbType.Int)).Value = shift_pat;
                cmd.Parameters.Add(new SqlParameter("type_guard", SqlDbType.NVarChar)).Value = type_guard;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = control_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Manning's informations updated succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        public void delete_manning_info(int rec)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "delete_manning";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_manning", SqlDbType.Int)).Value = rec;
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manning's informations deleted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
    }
}
