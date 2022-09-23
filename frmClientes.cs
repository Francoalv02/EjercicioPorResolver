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
            //variables
            string varnombreCliente;
            int id = 1;
            varnombreCliente = txtNombreCliente.Text;

            //SE CREA EL ARCHIVO
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./cliente.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./cliente.txt");
            //CONTADOR GENERADOR DEL iD
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string id2 = arr[0];
                id = Convert.ToInt32(id2) + 1; 
            }
            sr2.Close();

            //SI VAR CLIENTES ES DISTINTO DE VACIO CARGAR LOS DATOS EN ARCHIVO
            if (varnombreCliente != "")
            {
                using (StreamWriter sw = File.AppendText("./cliente.txt"))
                {
                    sw.WriteLine(id + "," + varnombreCliente);
                    sw.Close();
                }
                txtNombreCliente.Text = "";
                MessageBox.Show("Datos Cargados Correctamente");
            }
            else
            {
                MessageBox.Show("error,Complete todos los datos");
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
