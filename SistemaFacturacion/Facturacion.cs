using MiLibreia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaFacturacion
{
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void errorTxtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {
        }

        private void Facturacion_Load_1(object sender, EventArgs e)
        {
            string cmd = "Select * FROM Usuarios Where id=" + VentanaLogin.Codigo;

            DataSet ds;

            ds = Utilidades.Ejecutar(cmd);

            lblAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtCodigoCli.Text.Trim()) == false)
            {
                try
                {
                    string cmd = string.Format("Select Nom_Cli FROM Clientes WHERE id='{0}'", txtCodigoCli.Text.Trim());

                    DataSet ds = Utilidades.Ejecutar(cmd);

                    txtCliente.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();

                    txtCodigoPro.Focus();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                }
            }
        }
    }
}
