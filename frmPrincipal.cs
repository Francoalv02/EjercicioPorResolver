using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAlvarezER
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmL = new frmClientes();
            frmL.Show();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor frmL = new frmVendedor();
            frmL.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas frmL = new frmVentas();
            frmL.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
