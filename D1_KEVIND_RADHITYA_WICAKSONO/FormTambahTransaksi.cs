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
    public partial class FormTambahTransaksi : Form
    {
        EsemNetEntities db = new EsemNetEntities();
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
                textBox2.Enabled = true;
                comboBox2.Enabled = true;
                textBox1.Text = paket.HargaPerJam.ToString("C2", new CultureInfo("id-ID"));
                if (paket.IDJenis == null)
                {
                    bindingSource2.DataSource = db.Komputers.ToList();
                }
                else
                {
                    bindingSource2.DataSource = db.Komputers.Where(f => f.IDJenis == paket.IDJenis).ToList();
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
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new FormMember().ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
