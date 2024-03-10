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
    public partial class UCkomputer : UserControl
    {
        TimeSpan waktu;
        int durasi;
        DateTime tanggal;

        DateTime final;
        public UCkomputer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UCkomputer_Load(object sender, EventArgs e)
        {
            timer1.Start();

            if (this.Tag is Transaksi transaksi)
            {
                label1.Text = $"Komputer {transaksi.Komputer.Nomor}";
                label2.Text = $"{transaksi.Durasi} Jam";
                durasi = transaksi.Durasi;
                waktu = transaksi.Waktu;
                tanggal = transaksi.Tanggal;
            }
            var tgl = tanggal.ToString().Substring(0, 10);
            var hitung = $"{tgl} {waktu}";
            final = DateTime.Parse(hitung);
            //MessageBox.Show(final.AddHours(durasi).ToString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // jika jam sekarang sudah lebih dari durasi di warnet
            if (DateTime.Now > final.AddHours(durasi))
            {
                label3.Text = "00:00:00";
                this.Hide();
            }
            else
            {
                TimeSpan data = final.AddHours(durasi) - DateTime.Now;
                //TimeSpan data = DateTime.Now.AddHours(durasi) - final;
                label3.Text = $"{data.ToString("hh")}:{data.ToString("mm")}:{data.ToString("ss")}";
            }
        }
    }
}
