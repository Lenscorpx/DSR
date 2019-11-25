using DSR.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Codes
{
    class Generator
    {
        public void load_generator_info(DataGridView dtg)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                string requete = "load_generator";
                var cmd = new SqlCommand(requete, Connex.con);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public void search_generator_info_by_date(DataGridView dtg, DateTime datex)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_generator_by_date";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = datex;

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
        public void search_generator_info_by_client(DataGridView dtg, string client_x)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_generator_by_client";
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
        public void insert_generator_info(DateTime start_hour, DateTime stop_hour, Decimal receipts, DateTime cntrl_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "insert_generator";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("start_hour", SqlDbType.DateTime)).Value = start_hour;
                cmd.Parameters.Add(new SqlParameter("stop_hour", SqlDbType.DateTime)).Value = stop_hour;
                cmd.Parameters.Add(new SqlParameter("receipts", SqlDbType.Decimal)).Value = receipts;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = cntrl_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Generator's informations inserted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        public void update_generator_info(int rec, DateTime start_hour, DateTime stop_hour, Decimal receipts, DateTime cntrl_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "update_generator";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_generator", SqlDbType.Int)).Value = rec;
                cmd.Parameters.Add(new SqlParameter("start_hour", SqlDbType.DateTime)).Value = start_hour;
                cmd.Parameters.Add(new SqlParameter("stop_hour", SqlDbType.DateTime)).Value = stop_hour;
                cmd.Parameters.Add(new SqlParameter("receipts", SqlDbType.Decimal)).Value = receipts;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = cntrl_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Generator's informations inserted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
                Connex.con.Close(); Connex.con.Dispose();
            }
        }
        public void delete_generator_info(int rec)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "delete_generator";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_generator", SqlDbType.Int)).Value = rec;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Generator's informations deleted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
