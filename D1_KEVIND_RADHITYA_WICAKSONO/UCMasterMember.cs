using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D1_KEVIND_RADHITYA_WICAKSONO
{
    public partial class UCMasterMember : UserControl
    {
        EsemNetEntities db = new EsemNetEntities();
        public UCMasterMember()
        {
            InitializeComponent();
        }

        void enableState()
        {
            button4.Enabled = true;
            button5.Enabled = true;
            namaTextBox.Enabled = true;
            alamatTextBox.Enabled = true;
            teleponTextBox.Enabled = true;
        }

        void disableState()
        {
            button4.Enabled = false;
            button5.Enabled = false;
            namaTextBox.Enabled = false;
            alamatTextBox.Enabled = false;
            teleponTextBox.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(namaTextBox.Text))
            {
                MessageBox.Show("Nama harus diisi!");
                return;
            }

            if (teleponTextBox.Text.Length < 10 || teleponTextBox.Text.Length > 15)
            {
                MessageBox.Show("Nomor telepon minimal 10 ");
                return;
            }

            if (bindingSource1.Current is Member member)
            {
                member.MasihAktif = true;

                db.Members.AddOrUpdate(member);
                db.SaveChanges();

                disableState();
                OnLoad(EventArgs.Empty);
            }
        }

        private void memberDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (memberDataGridView.Rows[e.RowIndex].DataBoundItem is Member member)
            {
                if (e.ColumnIndex == statuscol.Index)
                {
                    if (member.MasihAktif == true)
                    {
                        e.Value = "Akfif";
                    }
                    else
                    {
                        e.Value = "Nonaktif";
                    }
                }
            }
        }

        private void UCMasterMember_Load(object sender, EventArgs e)
        {
            memberBindingSource.Clear();
            bindingSource1.Clear();
            memberBindingSource.DataSource = db.Members.ToList();
            bindingSource1.AddNew();
        }

        private void teleponTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enableState();
            OnLoad(EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows[0].DataBoundItem is Member member)
            {
                bindingSource1.DataSource = db.Members.AsNoTracking().FirstOrDefault(f => f.ID == member.ID);
                enableState();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows[0].DataBoundItem is Member member)
            {
                member.MasihAktif = false;

                db.Members.AddOrUpdate(member);
                db.SaveChanges();

                OnLoad(EventArgs.Empty);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows[0].DataBoundItem is Member member)
            {
                member.MasihAktif = true;

                db.Members.AddOrUpdate(member);
                db.SaveChanges();

                OnLoad(EventArgs.Empty);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            disableState();
            OnLoad(EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (memberDataGridView.SelectedRows[0].DataBoundItem is Member member)
            {
                if (MessageBox.Show($"Apakah kamu yakin menghapus {member.Nama} dari daftar member?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    db.Members.Remove(member);
                    db.SaveChanges();

                    disableState();
                    OnLoad(EventArgs.Empty);
                }
            }
        }
    }
}
