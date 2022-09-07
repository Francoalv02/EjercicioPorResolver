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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            decimal varNro;
            string varnombreCliente, varActivo ,varComision;



            varnombreCliente = txtNombreCliente.Text;
            varNro = nudCliente.Value;
            varActivo = cbActivo.Text;
            varComision = cbComision.Text;


            StreamWriter vendedor = new StreamWriter("./Vendedor.txt", true);
            vendedor.Close();

            if (txtNombreCliente.Text != "" && nudCliente.Value != 0 && cbActivo.Text != "" && cbComision.Text != "") 
            {
                
                MessageBox.Show("Datos cargados correctamente", "Validado", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNombreCliente.Text = "";
                nudCliente.Value = 0;
                cbActivo.Text = "";
                cbComision.Text = "";

                txtNombreCliente.Focus();
            }
            else
            {
                MessageBox.Show("ERROR, llene los datos correctamente");
            }
                


            using (StreamWriter swClientes = File.AppendText("./Vendedor.txt"))
            {
                swClientes.WriteLine(varNro + " , " + varnombreCliente + " , " + varActivo + " , " + varComision);
            }

            
            
        }
    }
}
