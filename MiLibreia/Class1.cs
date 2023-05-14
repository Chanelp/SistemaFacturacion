using System.Data;
using System.Data.SqlClient;
using System.Windows;


namespace MiLibreia
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            Con.Open();

            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);

            DP.Fill(DS);

            Con.Close();

            return DS;

        }

    }
}