using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_manning : Form
    {
        Codes.Manning mn = new Codes.Manning();
        public frm_manning()
        {
            InitializeComponent();
        }

        private void refresh_data()
        {
            var cl = new Codes.Client();
            cl.load_list_client(_Client_List);
            
            mn.load_manning_info(this.dtgrid_manning);
        }
        private void frm_manning_Load(object sender, EventArgs e)
        {
            refresh_data();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if(_txt_day_number.Text=="" || _txt_id_client.Text==""|| _txt_night_number.Text==""||
                _txt_observ.Text==""|| _txt_shift_patt.Text==""||_txt_total_number.Text==""|| _cbx_type_guard.Text=="")
            {
                MessageBox.Show("Please, complete all informations needed for this operation");
            }
            else
            {
                mn.insert_manning_info(Convert.ToInt32(_txt_day_number.Text), Convert.ToInt32(_txt_night_number.Text), Convert.ToInt32(_txt_total_number.Text),
                _txt_observ.Text,Convert.ToInt32(_txt_shift_patt.Text),_cbx_type_guard.Text,Convert.ToDateTime(_dt_manning_date.Text),_txt_id_client.Text);
                refresh_data();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (_txt_id_rec.Text==""|| _txt_day_number.Text == "" || _txt_id_client.Text == "" || _txt_night_number.Text == "" ||
                _txt_observ.Text == "" || _txt_shift_patt.Text == "" || _txt_total_number.Text == "" || _cbx_type_guard.Text == "")
            {
                MessageBox.Show("Please, complete all informations needed for this operation");
            }
            else
            {
                mn.update_manning_info(Convert.ToInt32(_txt_id_rec.Text),Convert.ToInt32(_txt_day_number.Text), Convert.ToInt32(_txt_night_number.Text), Convert.ToInt32(_txt_total_number.Text),
                _txt_observ.Text, Convert.ToInt32(_txt_shift_patt.Text), _cbx_type_guard.Text, Convert.ToDateTime(_dt_manning_date.Text), _txt_id_client.Text);
                refresh_data();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_txt_id_rec.Text == "")
            {
                MessageBox.Show("Please, complete all informations needed for this operation");
            }
            else
            {
                var rs = new DialogResult();
                rs.Equals(MessageBox.Show(this, "Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
                if(rs==DialogResult.Yes)
                {
                    mn.delete_manning_info(Convert.ToInt32(_txt_id_rec.Text));
                    refresh_data();
                }                    
            }
        }

        private void _Client_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txt_id_client.Text = Convert.ToString(_Client_List.SelectedItem);
        }

        private void dtgrid_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _txt_id_rec.Text = dtgrid_manning.SelectedRows[0].Cells[0].Value.ToString();
             _txt_day_number.Text = dtgrid_manning.SelectedRows[0].Cells[1].Value.ToString();
            _txt_night_number.Text = dtgrid_manning.SelectedRows[0].Cells[2].Value.ToString();
            _txt_total_number.Text = dtgrid_manning.SelectedRows[0].Cells[3].Value.ToString();
            _txt_observ.Text = dtgrid_manning.SelectedRows[0].Cells[4].Value.ToString();
            _txt_shift_patt.Text = dtgrid_manning.SelectedRows[0].Cells[5].Value.ToString();
            _cbx_type_guard.Text = dtgrid_manning.SelectedRows[0].Cells[6].Value.ToString();
            _dt_manning_date.Text = dtgrid_manning.SelectedRows[0].Cells[7].Value.ToString();
            _txt_id_client.Text = dtgrid_manning.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void _txt_id_client_TextChanged(object sender, EventArgs e)
        {
            var man = new Codes.Manning();
            man.search_manning_info_by_client(this.dtgrid_manning, _txt_id_client.Text);
        }

        private void _dt_manning_date_ValueChanged(object sender, EventArgs e)
        {
            var man = new Codes.Manning();
            man.search_manning_info_by_date(this.dtgrid_manning, Convert.ToDateTime(_dt_manning_date.Text));
        }
    }
}
