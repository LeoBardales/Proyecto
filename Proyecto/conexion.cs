using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proyecto
{
    class conexion
    {
        String cadena = "Data Source=DESKTOP-1; Initial Catalog=proyecto; Integrated Security=true";
        public SqlConnection conectar = new SqlConnection();

        public conexion()
        {
            conectar.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectar.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }
        public void close()
        {
            try
            {
                conectar.Close();
                Console.WriteLine("Conexion Cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
        }


    }
}
