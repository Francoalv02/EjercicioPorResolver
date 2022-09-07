using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PryAlvarezER
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal varNro;
            string varnombreCliente;


            varnombreCliente = txtNombreCliente.Text;
            varNro = nudNroCliente.Value;
            

            StreamWriter clientes = new StreamWriter("./Clientes.txt", true);
            clientes.Close();

            if (txtNombreCliente.Text != "" && nudNroCliente.Value != 0)
            {

                MessageBox.Show("Datos cargados correctamente", "Validado", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNombreCliente.Text = "";
                nudNroCliente.Value = 0;

                txtNombreCliente.Focus();
            }
            else
            {
                MessageBox.Show("ERROR, llene los datos correctamente");
            }

            using (StreamWriter swClientes = File.AppendText("./Clientes.txt"))
            {
                swClientes.WriteLine(varNro + " , " + varnombreCliente);
            }

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNroCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudCliente_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
