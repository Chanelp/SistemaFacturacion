using System.Data;
using System.Data.SqlClient;
using MiLibreia;

namespace SistemaFacturacion
{
    public partial class VentanaLogin : FormBase
    {
        public VentanaLogin()
        {
            InitializeComponent();
        }

        public static String Codigo = "";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = string.Format("Select * FROM Usuarios Where account='{0}' AND password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(cmd);

                Codigo = ds.Tables[0].Rows[0]["id"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();


                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin vAdmin = new VentanaAdmin();
                        this.Hide();
                        vAdmin.Show();
                    }
                    else
                    {
                        VentanaUser vUser = new VentanaUser();
                        this.Hide();
                        vUser.Show();
                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Usuario o contraseña incorrecta!... " + error.Message);
            }

        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}