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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
            char separador = Convert.ToChar(","); 
            StreamReader srClienteId = new StreamReader("./cliente.txt");
            while (!srClienteId.EndOfStream)
            {
                string[] arrCliente = srClienteId.ReadLine().Split(separador);
                cbClienteID.Items.Add(arrCliente[0]);
            }
            srClienteId.Close();
            
            StreamReader srVendedorId = new StreamReader("./vendedor.txt");
            while (!srVendedorId.EndOfStream)
            {
                string[] arrVendedor = srVendedorId.ReadLine().Split(separador);
                cbVendedorID.Items.Add(arrVendedor[0]);
            }
            srVendedorId.Close();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            //variables
            int idVentas = 1;
            string varVendedorID = cbVendedorID.Text;
            string varClientesID = cbClienteID.Text;
            string facturaTipo = cbFactura.Text;
            int facturaNro = Convert.ToInt32(nudFacturaNro.Text);
            int monto = Convert.ToInt32(nudMonto.Text);

            //crear carpetas
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./ventas.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./ventas.txt");

            //contador id
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string idVentas2 = arr[0];
                idVentas = Convert.ToInt32(idVentas2) + 1;
            }
            sr2.Close();

            //si estan los datos cargados correctamente se guarda en archivo
            if (varVendedorID != "0" && varClientesID != "0" && facturaTipo != "" && facturaNro != 0 && monto != 0)
            {
                using (StreamWriter sw = File.AppendText("./ventas.txt"))
                {
                    sw.WriteLine(idVentas + "," + varVendedorID + "," + varClientesID + "," + facturaTipo + "," + facturaNro + "," + monto);
                    sw.Close();
                }
                MessageBox.Show("Datos Cargados Correctamente");
            }
            else
            {
                MessageBox.Show("Error,Complete todos los datos");
            }
        }
    }
}
