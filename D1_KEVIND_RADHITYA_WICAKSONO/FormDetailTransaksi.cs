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
    public partial class FormDetailTransaksi : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public FormDetailTransaksi()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FormDetailTransaksi_Load(object sender, EventArgs e)
        {
            var data = db.Transaksis.FirstOrDefault(f => f.ID == Runtime.IDtransaksi);

            textBox6.Text = data.Paket.Nama;
            textBox7.Text = data.Komputer.Merek;
            textBox1.Text = data.Paket.HargaPerJam.ToString("C2", new CultureInfo("id-ID"));
            textBox2.Text = $"{data.Durasi} Jam";

            textBox3.Text = data.Member.Nama;
            textBox4.Text = data.Member.Telepon;
            textBox5.Text = data.Member.Alamat;

            double total = data.Paket.HargaPerJam * data.Durasi;
            label12.Text = total.ToString("C2", new CultureInfo("id-ID"));

            double nilaiDiskon = ((double)data.KodePotonganHarga.Presentase / 100) * total;
            double hargaDiskon = total - nilaiDiskon;
            label13.Text = nilaiDiskon.ToString("C2", new CultureInfo("id-ID"));

            // Seumpama kalau member dapat diskon 5%
            double diskonMember = ((double)5 / 100) * total;
            label14.Text = diskonMember.ToString("C2", new CultureInfo("id-ID"));

            double totalSemua = total - nilaiDiskon - diskonMember;
            label15.Text = totalSemua.ToString("C2", new CultureInfo("id-ID"));
        }
    }
}
