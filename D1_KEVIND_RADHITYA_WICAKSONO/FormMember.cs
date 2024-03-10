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
    public partial class FormMember : Form
    {
        EsemNetEntities db = new EsemNetEntities();
        public FormMember()
        {
            InitializeComponent();
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            memberBindingSource.DataSource = db.Members.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var data = db.Members.AsQueryable();

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                data = db.Members.Where(f => f.Nama.Contains(textBox1.Text));
            }

            memberBindingSource.DataSource = data.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is Member member)
            {
                Runtime.IDmember = member.ID;
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
