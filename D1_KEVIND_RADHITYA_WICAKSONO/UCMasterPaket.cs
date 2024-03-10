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
    public partial class UCMasterPaket : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCMasterPaket()
        {
            InitializeComponent();
        }

        void enableState()
        {
            hargaPerJamNumericUpDown.Enabled = true;
            namaTextBox.Enabled = true;
            iDJenisComboBox.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            checkBox1.Enabled = true;
        }

        void disableState()
        {
            hargaPerJamNumericUpDown.Enabled = false;
            namaTextBox.Enabled = false;
            iDJenisComboBox.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            checkBox1.Enabled = false;
        }

        private void UCMasterPaket_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            iDJenisComboBox.Enabled = false;

            hargaPerJamNumericUpDown.Maximum = decimal.MaxValue;
            bindingSource1.Clear();

            paketBindingSource.DataSource = db.Pakets.ToList();
            jeniBindingSource.DataSource = db.Jenis.ToList();

            bindingSource1.AddNew();

        }

        private void paketDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (paketDataGridView.Rows[e.RowIndex].DataBoundItem is Paket paket)
            {
                if (e.ColumnIndex == JenisCol.Index) e.Value = paket.Jeni?.Jenis;
                if (e.ColumnIndex == hargaCol.Index) e.Value = paket.HargaPerJam.ToString("C2", new CultureInfo("id-ID"));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableState();
            OnLoad(EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namaTextBox.Text))
            {
                MessageBox.Show("Nama paket tidak boleh kosong!");
                return;
            }

            if (hargaPerJamNumericUpDown.Value < 5000)
            {
                MessageBox.Show("Harga per jam minimal Rp.5.000,00");
                return;
            }

            if (bindingSource1.Current is Paket paket)
            {
                if (checkBox1.Checked)
                {
                    paket.IDJenis = null;
                }
                else
                {
                    paket.IDJenis = (int)iDJenisComboBox.SelectedValue;
                }
                db.Pakets.AddOrUpdate(paket);
                db.SaveChanges();

                disableState();

                OnLoad(EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("bukan");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (paketDataGridView.rowse < 1)

            if (paketDataGridView.SelectedRows[0].DataBoundItem is Paket paket)
            {
                bindingSource1.DataSource = db.Pakets.AsNoTracking().FirstOrDefault(f => f.ID == paket.ID);
                enableState();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disableState();
            OnLoad(EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (paketDataGridView.SelectedRows[0].DataBoundItem is Paket paket)
            {
                if (MessageBox.Show($"Apakah Kamu yakin mau menghapus {paket.Nama} dari daftar?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Pakets.Remove(paket);
                    db.SaveChanges();

                    disableState();
                    OnLoad(EventArgs.Empty);
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                iDJenisComboBox.Enabled = false;
            }
            else
            {
                iDJenisComboBox.Enabled = true;
            }
        }
    }
}
