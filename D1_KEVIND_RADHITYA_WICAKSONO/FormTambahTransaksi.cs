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
    public partial class FormTambahTransaksi : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        double total;
        int SelectedID = 0;
        public FormTambahTransaksi()
        {
            InitializeComponent();
        }

        public TextBox tb
        {
            get { return textBox3; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox4.Enabled = true;
                button3.Enabled = false;
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
            else
            {
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                button3.Enabled = true;
                textBox4.Enabled = false;

                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
            }
        }

        private void FormTambahTransaksi_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = db.Pakets.ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Paket paket)
            {
                //textBox2.Text = "1";
                textBox2.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Text = paket.HargaPerJam.ToString("C2", new CultureInfo("id-ID"));

                if (!string.IsNullOrEmpty(textBox2.Text))
                {
                    var jumlah = paket.HargaPerJam * Convert.ToDouble(textBox2.Text);
                    label12.Text = jumlah.ToString("C2", new CultureInfo("id-ID"));
                }

                if (paket.IDJenis == null)
                {
                    var fromDb = db.Komputers.ToList();
                    var formatted = fromDb.Select(f => new
                    {
                        ValueMem = f.ID,
                        DisplayMem = $"Komputer {f.Nomor}"
                    }).ToList();

                    bindingSource2.DataSource = formatted;
                    comboBox2.DisplayMember = "DisplayMem";
                    comboBox2.ValueMember = "ValueMem";
                }
                else
                {
                    var fromDb = db.Komputers.Where(f => f.IDJenis == paket.IDJenis).ToList();
                    var formatted = fromDb.Select(f => new
                    {
                        ValueMem = f.ID,
                        DisplayMem = $"Komputer {f.Nomor}"
                    }).ToList();

                    bindingSource2.DataSource = formatted;
                    comboBox2.DisplayMember = "DisplayMem";
                    comboBox2.ValueMember = "ValueMem";
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Paket paket)
            {
                label12.Text = paket.HargaPerJam.ToString();
            }
            else
            {
                MessageBox.Show("Bukan");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem is Paket paket)
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    label12.Text = 0.ToString("C2", new CultureInfo("id-ID"));
                }
                else if (textBox2.Text == "0")
                {
                    MessageBox.Show("Minimal 1 Jam");
                    textBox2.Text = "1";
                }
                else
                {
                    double data = paket.HargaPerJam * Convert.ToDouble(textBox2.Text);
                    label12.Text = data.ToString("C2", new CultureInfo("id-ID"));
                    label12.Tag = data;
                    total = data;
                }
            }

            var sample = label12.Text.Substring(2);
            if (db.KodePotonganHargas.Any(f => f.Kode == textBox6.Text))
            {
                //MessageBox.Show("oke");
                var data = db.KodePotonganHargas.FirstOrDefault(f => f.Kode == textBox6.Text);
                var jumlah = Convert.ToDouble(sample) * data.Presentase / 100;
                label13.Text = jumlah.ToString("C2", new CultureInfo("id-ID"));
            }
            else
            {
                label13.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }

            var oke = label13.Text.Substring(2);
            var rumus = Convert.ToDouble(sample) - Convert.ToDouble(oke);
            label15.Text = rumus.ToString("C2", new CultureInfo("id-ID"));
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormMember().ShowDialog();
            var data = db.Members.FirstOrDefault(f => f.ID == Runtime.IDmember);
            textBox3.Text = data.Nama;
            textBox4.Text = data.Telepon;
            textBox5.Text = data.Alamat;
            SelectedID = data.ID;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            var sample = label12.Text.Substring(2);
            if (db.KodePotonganHargas.Any(f => f.Kode == textBox6.Text))
            {
                //MessageBox.Show("oke");
                var data = db.KodePotonganHargas.FirstOrDefault(f => f.Kode == textBox6.Text);
                var jumlah = Convert.ToDouble(sample) * data.Presentase / 100;
                label13.Text = jumlah.ToString("C2", new CultureInfo("id-ID"));
            }
            else
            {
                label13.Text = 0.ToString("C2", new CultureInfo("id-ID"));
            }

            var oke = label13.Text.Substring(2);
            var rumus = Convert.ToDouble(sample) - Convert.ToDouble(oke);
            label15.Text = rumus.ToString("C2", new CultureInfo("id-ID"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Semua data wajib Diisi!");
                return;
            }

            var data = db.KodePotonganHargas.FirstOrDefault(f => f.Kode == textBox6.Text);

            if (!string.IsNullOrEmpty(textBox3.Text) || !string.IsNullOrEmpty(textBox4.Text) || !string.IsNullOrEmpty(textBox5.Text))
            {
                Member member = new Member()
                {
                    Nama = textBox3.Text,
                    Telepon = textBox4.Text,
                    Alamat = textBox5.Text,
                    MasihAktif = true
                };

                db.Members.Add(member);
                db.SaveChanges();

                SelectedID = member.ID;
            }

            int IsID = SelectedID;

            if (SelectedID == 0)
            {
                Transaksi transaksi = new Transaksi()
                {
                    DibuatOleh = Runtime.IDpengguna,
                    Durasi = Convert.ToInt32(textBox2.Text),
                    IDKomputer = (int)comboBox2.SelectedValue,
                    IDMember = null,
                    IDPaket = (int)comboBox1.SelectedValue,
                    IDPotonganHarga = data?.ID,
                    Tanggal = DateTime.Now,
                    Waktu = DateTime.Now.TimeOfDay,
                };

                db.Transaksis.Add(transaksi);
                db.SaveChanges();

                this.Close();
            }
            else
            {
                try
                {
                    Transaksi transaksi = new Transaksi()
                    {
                        DibuatOleh = Runtime.IDpengguna,
                        Durasi = Convert.ToInt32(textBox2.Text),
                        IDKomputer = (int)comboBox2.SelectedValue,
                        IDMember = Runtime.IDmember,
                        IDPaket = (int)comboBox1.SelectedValue,
                        IDPotonganHarga = data?.ID,
                        Tanggal = DateTime.Now,
                        Waktu = DateTime.Now.TimeOfDay,
                    };

                    db.Transaksis.Add(transaksi);
                    db.SaveChanges();

                    this.Close();
                }
                catch
                {
                    Transaksi transaksi = new Transaksi()
                    {
                        DibuatOleh = Runtime.IDpengguna,
                        Durasi = Convert.ToInt32(textBox2.Text),
                        IDKomputer = (int)comboBox2.SelectedValue,
                        IDMember = IsID,
                        IDPaket = (int)comboBox1.SelectedValue,
                        IDPotonganHarga = data?.ID,
                        Tanggal = DateTime.Now,
                        Waktu = DateTime.Now.TimeOfDay,
                    };

                    db.Transaksis.AddOrUpdate(transaksi);
                    db.SaveChanges();

                    this.Close();
                }
            };
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
