using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    public partial class UCDashboard : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCDashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = $"{DateTime.Now.ToString("dd MMMM yyyy hh:mm", new CultureInfo("id-ID"))}";
        }

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();

            var data = db.Penggunas.FirstOrDefault(f => f.ID == Runtime.IDpengguna);
            label1.Text = $"Selamat Datang {data.NamaPengguna}";
            var date = DateTime.Now.Date;
            label3.Text = $"{db.Transaksis.Where(f => f.Tanggal >= date && f.Tanggal <= date).Count()} Komputer Terpakai";

            foreach (var item in db.Transaksis.ToList())
            {
                UCkomputer uc = new UCkomputer()
                {
                    Tag = item
                };
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormTambahTransaksi().ShowDialog();
        }
    }
}
