using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    public partial class FormTambahDurasi : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public FormTambahDurasi()
        {
            InitializeComponent();
        }

        private void FormTambahDurasi_Load(object sender, EventArgs e)
        {
            var data = db.Transaksis.FirstOrDefault(f => f.ID == Runtime.IDtransaksi);
            textBox6.Text = data.Paket.Nama;
            textBox1.Text = $"Komputer {data.Komputer.Nomor}";
            textBox2.Text = data.Paket.HargaPerJam.ToString("C2", new CultureInfo("id-ID"));
            textBox3.Text = data.Durasi.ToString();

            try
            {
                var subTotal = Convert.ToDouble(textBox3.Text) * data.Paket.HargaPerJam;
                label12.Text = subTotal.ToString("C2", new CultureInfo("id-ID"));
            }
            catch
            {
                label12.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }

            try
            {
                var potHarga = (Convert.ToDouble(textBox3.Text) * data.Paket.HargaPerJam) * data.KodePotonganHarga.Presentase / 100;
                label13.Text = potHarga.ToString("C2", new CultureInfo("id-ID"));
            }
            catch
            {
                label13.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }

            try
            {
                var total = (Convert.ToDouble(textBox3.Text) * data.Paket.HargaPerJam) - ((Convert.ToDouble(textBox3.Text) * data.Paket.HargaPerJam) * data.KodePotonganHarga.Presentase / 100);
                label15.Text = total.ToString("C2", new CultureInfo("id-ID"));
            }
            catch
            {
                label15.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = db.Transaksis.FirstOrDefault(f => f.ID == Runtime.IDtransaksi);

            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Durasi wajib diisi!");
                return;
            }

            if (Convert.ToDouble(textBox3.Text) < data.Durasi)
            {
                MessageBox.Show("Durasi Tidak Boleh Kurang Dari Durasi Sebelumnya!");
                return;
            }

            data.Durasi = Convert.ToInt32(textBox3.Text);

            db.Transaksis.AddOrUpdate(data);
            db.SaveChanges();

            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            var price = textBox2.Text.Substring(2);
            try
            {
                var sum = Convert.ToDouble(price) * Convert.ToDouble(textBox3.Text);
                label12.Text = sum.ToString("C2", new CultureInfo("id-ID"));
            }
            catch
            {
                label12.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }

            var data = db.Transaksis.FirstOrDefault(f => f.ID == Runtime.IDtransaksi);
            var subs = label12.Text.Substring(2);

            var persen = Convert.ToDouble(subs) * data.KodePotonganHarga.Presentase / 100;
            label13.Text = persen.ToString("C2", new CultureInfo("id-ID"));

            var subs2 = label13.Text.Substring(2);
            var hitung = Convert.ToDouble(subs) - Convert.ToDouble(subs2);
            label15.Text = hitung.ToString("C2", new CultureInfo("id-ID"));
        }
    }
}
