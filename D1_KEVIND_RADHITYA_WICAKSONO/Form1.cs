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
    public partial class Form1 : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Budi";
            textBox2.Text = "Sandi123";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = db.Penggunas.Where(f => f.NamaPengguna == textBox1.Text && f.KataSandi == textBox2.Text).FirstOrDefault();
            if (data != null)
            {
                Runtime.IDpengguna = data.ID;
                new FormDashboard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kamu Tidak Terdaftar di EsemNet!");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
