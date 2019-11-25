using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_logs : Form
    {
        public frm_logs()
        {
            InitializeComponent();
        }

        private void afficher_logs()
        {
            var rd = new Codes.Logs();
            rd.load_logs_info(this.dtgrid_fuel);
        }
        private void frm_logs_Load(object sender, EventArgs e)
        {
            afficher_logs();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            afficher_logs();
        }
    }
}
