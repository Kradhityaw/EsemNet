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
    public partial class UCTransaksi : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCTransaksi()
        {
            InitializeComponent();
        }

        private void UCTransaksi_Load(object sender, EventArgs e)
        {
            transaksiBindingSource.DataSource = db.Transaksis.ToList();
        }

        private void transaksiDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (transaksiDataGridView.Rows[e.RowIndex].DataBoundItem is Transaksi transaksi)
            {
                if (e.ColumnIndex == komputerCol.Index)
                {
                    e.Value = transaksi.Komputer.Merek;
                }
                if (e.ColumnIndex == paketCol.Index)
                {
                    e.Value = transaksi.Paket.Nama;
                }
                if (e.ColumnIndex == durasiCol.Index)
                {
                    e.Value = $"{transaksi.Durasi} Jam";
                }
                if (e.ColumnIndex == dibuatCol.Index)
                {
                    e.Value = transaksi.Pengguna.NamaPengguna;
                }
                if (e.ColumnIndex == tanggalCol.Index)
                {
                    e.Value = transaksi.Tanggal.ToString("dd MMMM yyyy", new CultureInfo("id-ID"));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (transaksiDataGridView.SelectedRows[0].DataBoundItem is Transaksi transaksi)
            {
                Runtime.IDtransaksi = transaksi.ID;
                new FormDetailTransaksi().ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormTambahTransaksi().ShowDialog();
        }
    }
}
