using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DSR.Forms
{
    public partial class frm_welcome : Form
    {
        public frm_welcome()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void afficher_fuel()
        {
            tileControl1.Hide();
            var fa = new frm_fuel() { MdiParent = this };
            fa.Show();
        }
        private void afficher_logs()
        {
            tileControl1.Hide();
            var fa = new frm_logs();
            fa.Show();
        }
        private void afficher_client()
        {
            tileControl1.Hide();
            var fr = new frm_client();
            fr.MdiParent = this;
            fr.Show();
        }
        private void afficher_generator()
        {
            tileControl1.Hide();
            var fr = new frm_generator();
            fr.MdiParent = this;
            fr.Show();
        }
        private void afficher_manning()
        {
            tileControl1.Hide();
            var fr = new frm_manning();
            fr.MdiParent = this;
            fr.Show();
        }
        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This App was created by Lens Mutombo\n from DR Congo for Abbas Dbouk"+
                "\nCopyright LensCorp Enterprises 2016\nCall us on\n"+
                "+243977551835\n+243811960080\nor Like us on\nFacebook: Len's Mutombo\nLinkedin: Lens Mutombo\nTwitter: Lens Mutombo\n or"+
                " Send a mail to\n lensmutombo@outlook.com or freeletterslml@gmail.com", "Developer and Owner", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            afficher_fuel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tileControl1.Show();
        }

        private void fuelLevelsToolStripMenuItem_Click(object sender, EventArgs ex)
        {
            afficher_fuel();
        }

        private void button2_Click(object sender, EventArgs ex)
        {
            afficher_fuel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            afficher_generator();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            afficher_manning();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            afficher_client();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            afficher_client();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            afficher_generator();
        }

        private void generatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher_generator();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher_client();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            afficher_manning();
        }

        private void manningLevelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            afficher_manning();
        }

        private void applicationLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var log = new frm_logs();
            //log.MdiParent = this;
            log.ShowDialog();
            
        }
        private void frm_welcome_Load(object sender, EventArgs e)
        {
            
        }

        private void seConnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fe = new _Reports.frm_report_generator();
            fe.Show();
        }

        private void dailyReturnReportFuelByPlaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new _Reports.frm_rpt_generator();
            f.Show();
        }

        private void dailyReturnReportGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var d = new _Reports.frm_rpt_xgenerator();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            afficher_logs();
        }
    }
}
