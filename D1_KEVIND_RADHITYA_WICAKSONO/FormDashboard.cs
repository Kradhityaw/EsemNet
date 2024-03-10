using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCDashboard uc = new UCDashboard();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCDashboard uc = new UCDashboard();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void masterKomputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCMasterComputer uc = new UCMasterComputer();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void masterPaketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCMasterPaket uc = new UCMasterPaket();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterKodePotonganHargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCMasterPotongan uc = new UCMasterPotongan();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void masterMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCMasterMember uc = new UCMasterMember();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UCTransaksi uc = new UCTransaksi();
            uc.Show();
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Add(uc);
        }
    }
}
