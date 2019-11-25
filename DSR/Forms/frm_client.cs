using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_client : Form
    {
        Codes.Client cl = new Codes.Client();
        public frm_client()
        {
            InitializeComponent();
            cl.load_client_info(this.dtgrid_client);
        }

        private void btn_enregistrer_Click(object sender, EventArgs e)
        {
            cl.insert_client(txt_id_client.Text, txt_id_city.Text, txt_fullname.Text);
            cl.load_client_info(dtgrid_client);
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            cl.update_client(txt_id_client.Text, txt_id_city.Text, txt_fullname.Text);
            cl.load_client_info(dtgrid_client);
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            var rs = new DialogResult();
            rs = MessageBox.Show("Do you really wish to delete client information?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(rs==DialogResult.Yes)
            {
                cl.delete_client(txt_id_client.Text);
                cl.load_client_info(dtgrid_client);
            }            
        }

        private void frm_client_Load(object sender, EventArgs e)
        {
            var cs = new Codes.Client();
            cs.load_client_info(this.dtgrid_client);
        }

        private void dtgrid_client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_client.Text = dtgrid_client.SelectedRows[0].Cells[0].Value.ToString();
            txt_id_city.Text = dtgrid_client.SelectedRows[0].Cells[1].Value.ToString();
            txt_fullname.Text = dtgrid_client.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void txt_id_client_TextChanged(object sender, EventArgs e)
        {
            var cs = new Codes.Client();
            cs.search_client_info_by_code(this.dtgrid_client, txt_id_client.Text);
        }

        private void txt_id_city_TextChanged(object sender, EventArgs e)
        {
            var cs = new Codes.Client();
            cs.search_client_info_by_city(this.dtgrid_client, txt_id_city.Text);
        }
    }
}
