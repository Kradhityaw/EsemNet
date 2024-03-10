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
    public partial class UCMasterPotongan : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCMasterPotongan()
        {
            InitializeComponent();
        }

        void enableState()
        {
            namaTextBox.Enabled = true;
            presentaseNumericUpDown.Enabled = true;
            maksimalNumericUpDown.Enabled = true;
            kodeTextBox.Enabled = true;
            berlakuSampaiDateTimePicker.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        void disableState()
        {
            namaTextBox.Enabled = false;
            presentaseNumericUpDown.Enabled = false;
            maksimalNumericUpDown.Enabled = false;
            kodeTextBox.Enabled = false;
            berlakuSampaiDateTimePicker.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void kodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namaTextBox.Text))
            {
                MessageBox.Show("Nama wajib diisi");
            }

            if (berlakuSampaiDateTimePicker.Value.Date <= DateTime.Now.Date)
            {
                MessageBox.Show("Minimal 1 hari setelah tanggal pembuatan!");
                return;
            }

            if (bindingSource1.Current is KodePotonganHarga kode)
            {
                db.KodePotonganHargas.AddOrUpdate(kode);
                db.SaveChanges();

                disableState();

                OnLoad(EventArgs.Empty);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableState();
            OnLoad(EventArgs.Empty);
        }

        private void UCMasterPotongan_Load(object sender, EventArgs e)
        {
            bindingSource1.Clear();
            kodePotonganHargaBindingSource.DataSource = db.KodePotonganHargas.ToList();
            bindingSource1.AddNew();
        }

        private void kodePotonganHargaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (kodePotonganHargaDataGridView.Rows[e.RowIndex].DataBoundItem is KodePotonganHarga kode)
            {
                if (e.ColumnIndex == berlakucol.Index)
                {
                    e.Value = kode.BerlakuSampai?.ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
                }
                if (e.ColumnIndex == maksimalcol.Index)
                {
                    e.Value = kode.Maksimal?.ToString("C2", new CultureInfo("id-ID"));
                }
                if (e.ColumnIndex == persencol.Index)
                {
                    e.Value = $"{kode.Presentase}%";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kodePotonganHargaDataGridView.SelectedRows[0].DataBoundItem is KodePotonganHarga kode)
            {
                bindingSource1.DataSource = db.KodePotonganHargas.Where(f => f.ID == kode.ID).FirstOrDefault();
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
            if (kodePotonganHargaDataGridView.SelectedRows[0].DataBoundItem is KodePotonganHarga kode)
            {
                if (MessageBox.Show($"Apakah kamu yakin hapus {kode.Nama} dari daftar?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.KodePotonganHargas.Remove(kode);
                    db.SaveChanges();

                    disableState();
                    OnLoad(EventArgs.Empty);
                }
            }
        }
    }
}
