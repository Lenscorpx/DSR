using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_fuel : Form
    {
        Codes.Fuel fuel = new Codes.Fuel();
        Codes.Client clients = new Codes.Client();
        public frm_fuel()
        {
            InitializeComponent();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            _Client_List.Refresh();
            _dt_fuel_date.Text = Convert.ToString(DateTime.Now);
            _txt_close_dip.Clear();
            _txt_id_client.Clear();
            _txt_id_rec.Clear();
            _txt_issues.Clear();
            _txt_open_dip.Clear();
            _txt_receipts.Clear();
        }

        private void dtgrid_fuel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //DataGridViewRow row = dtgrid_fuel.Rows[i];
            _txt_id_rec.Text = dtgrid_fuel.SelectedRows[0].Cells[0].Value.ToString();
            _txt_open_dip.Text = dtgrid_fuel.SelectedRows[0].Cells[1].Value.ToString();
            _txt_close_dip.Text = dtgrid_fuel.SelectedRows[0].Cells[2].Value.ToString();
            _txt_receipts.Text = dtgrid_fuel.SelectedRows[0].Cells[3].Value.ToString();
            _txt_issues.Text = dtgrid_fuel.SelectedRows[0].Cells[4].Value.ToString();
            _dt_fuel_date.Text = dtgrid_fuel.SelectedRows[0].Cells[5].Value.ToString();
            _txt_id_client.Text = dtgrid_fuel.SelectedRows[0].Cells[6].Value.ToString();         
        }

        private void frm_fuel_Load(object sender, EventArgs e)
        {            
            fuel.load_fuel_info(this.dtgrid_fuel);
            clients.load_list_client(_Client_List);
        }

        private void _txt_id_client_TextChanged(object sender, EventArgs e)
        {
            fuel.search_fuel_info_by_client(dtgrid_fuel, _txt_id_client.Text);
        }

        private void _dt_fuel_date_ValueChanged(object sender, EventArgs e)
        {
            fuel.search_fuel_info_by_date(this.dtgrid_fuel, Convert.ToDateTime(_dt_fuel_date.Text));
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(_txt_close_dip.Text=="" || _txt_id_client.Text==""||
                _txt_issues.Text=="" || _txt_open_dip.Text==""||
                _txt_receipts.Text=="")
            {
                MessageBox.Show("Complete the blank spaces before adding datas onto database please!");
            }
            else
            {
                fuel.insert_fuel_info(Convert.ToDecimal(_txt_open_dip.Text), Convert.ToDecimal(_txt_close_dip.Text),
                                      Convert.ToDecimal(_txt_receipts.Text), Convert.ToDecimal(_txt_issues.Text), Convert.ToDateTime(_dt_fuel_date.Text), _txt_id_client.Text);
                btn_refresh_Click(sender, e);
                frm_fuel_Load(sender, e);
            }
            
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (_txt_close_dip.Text == "" || _txt_id_client.Text == "" ||
                _txt_issues.Text == "" || _txt_open_dip.Text == "" ||
                _txt_receipts.Text == ""|| _txt_id_rec.Text=="")
            {
                MessageBox.Show("Complete the blank spaces before adding datas onto database please!");
            }
            else
            {
                fuel.update_fuel_info(Convert.ToInt32(_txt_id_rec.Text),Convert.ToDecimal(_txt_open_dip.Text), Convert.ToDecimal(_txt_close_dip.Text),
                                      Convert.ToDecimal(_txt_receipts.Text), Convert.ToDecimal(_txt_issues.Text), Convert.ToDateTime(_dt_fuel_date.Text), _txt_id_client.Text);
                
                btn_refresh_Click(sender, e);
                frm_fuel_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(_txt_id_rec.Text=="")
            {
                MessageBox.Show("Complete the blank spaces before adding datas onto database please!");
            }
            else
            {
                var rs = new DialogResult();
                rs = MessageBox.Show("Are you sure, you want to delete these information?","Deletion of data",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(rs==DialogResult.Yes)
                {
                    fuel.delete_fuel_info(Convert.ToInt32(_txt_id_rec.Text));
                    
                    btn_refresh_Click(sender, e);
                    frm_fuel_Load(sender, e);
                }
            }
        }

        private void _Client_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txt_id_client.Text = Convert.ToString(_Client_List.SelectedItem);
            //int i = e.RowIndex;
            //DataGridViewRow row = _Client_List.Items.[i];
            //_txt_id_rec.Text = row.Cells[0].Value.ToString();
            //_txt_open_dip.Text = row.Cells[1].Value.ToString();
            //_txt_close_dip.Text = row.Cells[2].Value.ToString();
            //_txt_receipts.Text = row.Cells[3].Value.ToString();
            //_txt_issues.Text = row.Cells[4].Value.ToString();
            //_dt_fuel_date.Text = row.Cells[5].Value.ToString();
            //_txt_id_client.Text = row.Cells[6].Value.ToString();
        }
    }
}
