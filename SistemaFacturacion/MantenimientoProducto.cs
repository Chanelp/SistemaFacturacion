using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreia;
using Contolesusuario;

namespace SistemaFacturacion
{
    public partial class MantenimientoProducto : Mantenimiento
    {
        public MantenimientoProducto()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (ErrorTxtBox.ValidarForm(this, errorProvider1) == false)
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizaArticulos '{0}','{1}','{2}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPrecio.Text.Trim());
                    Utilidades.Ejecutar(cmd);

                    MessageBox.Show("Se ha guardado correctamente");

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", txtIdPro.Text.Trim());
                Utilidades.Ejecutar(cmd);

                MessageBox.Show("Se ha eliminado");
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }
    }
}
