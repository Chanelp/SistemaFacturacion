﻿using MiLibreia;
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
    public partial class MantenimientoCliente : Mantenimiento
    {
        public MantenimientoCliente()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("EXEC ActualizaCliente  '{0}','{1}','{2}'", txtIdCli.Text.Trim(), txtNomCli.Text.Trim(), txtApeCli.Text.Trim());
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

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarClientes '{0}'", txtIdCli.Text.Trim());
                Utilidades.Ejecutar(cmd);

                MessageBox.Show("Se ha eliminado!");
            }
            catch (Exception error)
            {

                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

    }
}
