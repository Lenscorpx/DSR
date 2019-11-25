using DSR.DataAccessObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DSR._Reports
{
    public partial class frm_rpt_generator : Form
    {
        public frm_rpt_generator()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connex cnx = new Connex();
            //var con = new SqlConnection("Network Library=DBMSSOCN; Data Source=EPVSERVER,1433; Initial Catalog=bd_easyschool; User Id=sa; Password=EPVSERVER2016;");
            //var con = new SqlConnection("database=bd_easyschool;server=DESKTOP-DCMFQDO;uid=sa;pwd=EPVSERVER2016");
            //var con = new SqlConnection("Database=L;Server=DESKTOP-DCMFQDO;uid=sa;pwd=EPVSERVER2016");
            if(_dt_control_date.Text=="")
            {
                MessageBox.Show("Complete first the location and then click on button search");
            }
            else
            {
                try
                {
                    if (Connex.con.State == ConnectionState.Closed)
                        Connex.con.Open();
                    var cmd = new SqlCommand("daily_situation_manning", Connex.con) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.Add(new SqlParameter("control_date", SqlDbType.Date)).Value = Convert.ToDateTime(_dt_control_date.Text);
                    //cmd.Parameters.Add(new SqlParameter("code_client", SqlDbType.NVarChar)).Value = _cbx_type_guard.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    //DataTable dt = new DataTable();
                    var rpt = new _daily_return_manning();
                    DataSet dt = new DataSet();
                    da.Fill(dt, "daily_situation_manning");
                    rpt.DataSource = dt;
                    //rpt.SetDataSource(dt.Tables["rechercher_pay_bill"]);                    
                    documentViewer1.DocumentSource = rpt;
                    rpt.CreateDocument();
                    documentViewer1.Refresh();
                    //notifier_message("Classe chargée avec succès", "Chargement reussi");

                }
                catch (Exception et)
                {
                    MessageBox.Show("Erreur : " + et.Message);
                }
                finally { Connex.con.Close(); Connex.con.Dispose(); }
                }
            
            }
    }
    }