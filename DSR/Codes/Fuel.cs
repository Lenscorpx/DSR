using System;
using System.Collections.Generic;
using System.Linq;
using DSR.DataAccessObject;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DSR.Codes
{
    public partial class Fuel
    {
        Connex cnx = new Connex();
        //SqlConnection con = new SqlConnection("Network Library=DBMSSOCN; Data Source=LENSX,1433; Initial Catalog=bd_daily_security; User Id=sa; Password=Windy@2015.com?;");
        public void load_fuel_info(DataGridView dtg)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                string requete = "load_fuels";
                SqlCommand cmd = new SqlCommand(requete, Connex.con);
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
        public void insert_fuel_info(Decimal open_dip, Decimal close_dip, Decimal receipts, Decimal issues, DateTime cntrl_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "insert_fuels";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("open_dip", SqlDbType.Decimal)).Value = open_dip;
                cmd.Parameters.Add(new SqlParameter("close_dip", SqlDbType.Decimal)).Value = close_dip;
                cmd.Parameters.Add(new SqlParameter("receipts", SqlDbType.Decimal)).Value = receipts;
                cmd.Parameters.Add(new SqlParameter("issues", SqlDbType.Decimal)).Value = issues;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = cntrl_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fuel's informations inserted succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        public void update_fuel_info(int rec_number, Decimal open_dip, Decimal close_dip, Decimal receipts, Decimal issues, DateTime cntrl_date, String client)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "update_fuels";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_fuels", SqlDbType.Int)).Value = rec_number;
                cmd.Parameters.Add(new SqlParameter("open_dip", SqlDbType.Decimal)).Value = open_dip;
                cmd.Parameters.Add(new SqlParameter("close_dip", SqlDbType.Decimal)).Value = close_dip;
                cmd.Parameters.Add(new SqlParameter("receipts", SqlDbType.Decimal)).Value = receipts;
                cmd.Parameters.Add(new SqlParameter("issues", SqlDbType.Decimal)).Value = issues;
                cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = cntrl_date;
                cmd.Parameters.Add(new SqlParameter("client_code", SqlDbType.NVarChar)).Value = client;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fuel's informations updated succesfully onto database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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
        public void delete_fuel_info(int rec_number)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "delete_fuels";
                var cmd = new SqlCommand(requete, Connex.con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("rec_number_fuels", SqlDbType.Int)).Value = rec_number;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fuel's informations deleted succesfully from database", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong!", "Delete Operation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        public void search_fuel_info_by_date(DataGridView dtg, DateTime datex)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_fuels_by_date";
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
        public void search_fuel_info_by_client(DataGridView dtg, string client_x)
        {
            Connex cnx = new Connex();
            try
            {
                if (Connex.con.State == ConnectionState.Closed)
                    Connex.con.Open();
                const string requete = "search_fuels_by_client";
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
    }
}
