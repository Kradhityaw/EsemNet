using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    public partial class UCMasterComputer : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCMasterComputer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current is Komputer komputer)
            {
                if (komputer.ID == 0)
                {
                    if (db.Komputers.Any(f => f.Nomor == nomorNumericUpDown.Value))
                    {
                        MessageBox.Show("Nomor sudah ada!");
                        return;
                    }
                }
                komputer.IDJenis = (int)comboBox1.SelectedValue;
                db.Komputers.AddOrUpdate(komputer);
                db.SaveChanges();
                disableState();
                OnLoad(EventArgs.Empty);
            }
        }

        private void UCMasterComputer_Load(object sender, EventArgs e)
        {
            nomorNumericUpDown.Maximum = decimal.MaxValue;
            komputerBindingSource.DataSource = db.Komputers.ToList();
            jeniBindingSource.DataSource = db.Jenis.ToList();
            bindingSource1.AddNew();
        }

        void enableState()
        {
            merekTextBox.Enabled = true;
            nomorNumericUpDown.Enabled = true;
            comboBox1.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        void disableState()
        {
            merekTextBox.Enabled = false;
            nomorNumericUpDown.Enabled = false;
            comboBox1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableState();
            OnLoad(EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disableState();
            OnLoad(EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (komputerDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Silahkan Pilih data terlebih dahulu");
                return;
            }

            if (komputerDataGridView.SelectedRows[0].DataBoundItem is Komputer komputer)
            {
                bindingSource1.DataSource = db.Komputers.AsNoTracking().FirstOrDefault(f => f.ID == komputer.ID);
                enableState();
            }
        }

        private void komputerDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (komputerDataGridView.Rows[e.RowIndex].DataBoundItem is Komputer komputer)
            {
                if (e.ColumnIndex == jenisCol.Index)
                {
                    e.Value = komputer.Jeni.Jenis;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (komputerDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Silahkan Pilih data terlebih dahulu");
                return;
            }

            if (komputerDataGridView.SelectedRows[0].DataBoundItem is Komputer komputer)
            {
                if (MessageBox.Show($"Apakah kamu yakin mau menghapus {komputer.Merek} dari daftar?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Komputers.Remove(komputer);
                    db.SaveChanges();

                    OnLoad(EventArgs.Empty);
                }
            }
        }
    }
}
