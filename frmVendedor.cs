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
            //variables
            string varNombreVendedor, varActivo ,varComision;
            int id = 1;

            varNombreVendedor = txtNombreVendedor.Text;
            varActivo = cbActivo.Text;
            varComision = cbComision.Text;

            //se crean los archivos
   
            char separador = Convert.ToChar(",");
            StreamWriter sr = new StreamWriter("./Vendedor.txt", true);
            sr.Close();
            StreamReader sr2 = new StreamReader("./Vendedor.txt");

            //contador generador deL id
            while (!sr2.EndOfStream)
            {
                string[] arr = sr2.ReadLine().Split(separador);
                string id2 = arr[0];
                id = Convert.ToInt32(id2) + 1;
            }
            sr2.Close();

            //SI EL NOMBRE ES INDISTINTO DE VACIO,CARGAR LOS DATOS CORRECTAMENTE
            if (varNombreVendedor != "")
            {
                using (StreamWriter sw = File.AppendText("./Vendedor.txt"))
                {
                    sw.WriteLine(id + "," + varNombreVendedor + "," + varActivo + "," + varComision);
                    sw.Close();
                }
                txtNombreVendedor.Text = "";
                MessageBox.Show("Datos Cargados Correctamente");
            }
            else
            {
                MessageBox.Show("Error,Complete todos los datos");
            }

        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {

        }
    }
}
