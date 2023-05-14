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
    public partial class VentanaUser : FormBase
    {
        public VentanaUser()
        {
            InitializeComponent();
        }

        private void VentanaUser_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Usuarios WHERE id=" + VentanaLogin.Codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);

            lblNomUs.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblUs.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblCodigo.Text = DS.Tables[0].Rows[0]["id"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void VentanaUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal ConP = new ContenedorPrincipal();
            this.Hide();
            ConP.Show();
        }
    }
}
