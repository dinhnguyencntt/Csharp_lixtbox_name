using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_lixtbox_name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.Add(txtnhapten.Text);
            txtnhapten.Text=string.Empty;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            lsbketqua.Items.RemoveAt(lsbketqua.SelectedIndex);
        }

        private void BTNSUA1_Click(object sender, EventArgs e)
        {
            if (lsbketqua.SelectedIndex < 0) return;
            lsbketqua.Items[lsbketqua.SelectedIndex] = txtnhapten.Text;
        }

        private void lsbketqua_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnhapten.Text = lsbketqua.SelectedIndex.ToString();
        }
    }
}
