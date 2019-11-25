using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_generator : Form
    {
        Codes.Generator gen = new Codes.Generator();
        public frm_generator()
        {
            InitializeComponent();
        }
        private void refresh_data()
        {
            var cl = new Codes.Client();
            cl.load_list_client(_Client_List);
            gen.load_generator_info(this.dtgrid_generator);           
        }

        private void frm_generator_Load(object sender, EventArgs e)
        {
            refresh_data();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            gen.insert_generator_info(Convert.ToDateTime(_dt_start_hour.Text), Convert.ToDateTime(_dt_stop_hour.Text), Convert.ToDecimal(_txt_receipts.Text),
                Convert.ToDateTime(_dt_manning_date.Text), _txt_id_client.Text);
            refresh_data();
        }

        private void _Client_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txt_id_client.Text = Convert.ToString(_Client_List.SelectedItem);
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            gen.update_generator_info(Convert.ToInt32(_txt_id_rec.Text),Convert.ToDateTime(_dt_start_hour.Text), Convert.ToDateTime(_dt_stop_hour.Text), Convert.ToDecimal(_txt_receipts.Text),
                Convert.ToDateTime(_dt_manning_date.Text), _txt_id_client.Text);
            refresh_data();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs.Equals(MessageBox.Show("do you really want to delete the record you selected?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2));
            if(rs==DialogResult.Yes)
            {
                gen.delete_generator_info(Convert.ToInt32(_txt_id_rec.Text));
                refresh_data();
            }            
        }
        private void dtgrid_generator_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _txt_id_rec.Text = dtgrid_generator.SelectedRows[0].Cells[0].Value.ToString();
            _dt_start_hour.Text = dtgrid_generator.SelectedRows[0].Cells[1].Value.ToString();
            _dt_stop_hour.Text = dtgrid_generator.SelectedRows[0].Cells[2].Value.ToString();
            _txt_receipts.Text = dtgrid_generator.SelectedRows[0].Cells[3].Value.ToString();
            _dt_manning_date.Text = dtgrid_generator.SelectedRows[0].Cells[4].Value.ToString();
            _txt_id_client.Text = dtgrid_generator.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void _txt_id_client_TextChanged(object sender, EventArgs e)
        {
            var gen = new Codes.Generator();
            gen.search_generator_info_by_client(this.dtgrid_generator, _txt_id_client.Text);
        }

        private void _dt_manning_date_ValueChanged(object sender, EventArgs e)
        {
            var genx = new Codes.Generator();
            genx.search_generator_info_by_date(this.dtgrid_generator, Convert.ToDateTime(_dt_manning_date.Text));
        }
    }
}