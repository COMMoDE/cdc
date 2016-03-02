using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDC
{
    public partial class frmCDC : Form
    {
        public frmCDC()
        {
            InitializeComponent();
        }

        private void frmCDC_Load(object sender, EventArgs e)
        {
            btnConverti.Enabled = false;
        }

        private void btnSfoglia_Click(object sender, EventArgs e)
        {
            ofdDatabase.ShowDialog();
        }

        private void ofdDatabase_FileOk(object sender, CancelEventArgs e)
        {
            txtPercorso.Text = ofdDatabase.FileName;
        }

        private void txtPercorso_TextChanged(object sender, EventArgs e)
        {
            btnConverti.Enabled = true;
        }

    }
}
