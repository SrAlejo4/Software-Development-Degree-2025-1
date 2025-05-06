using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Se importa este paquete . . .

namespace LicoreraDataBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //esta es la cadena de conexion
            SqlConnection objConectar = new SqlConnection("Data Source=localhost;Initial Catalog=Licorera;Integrated Security=SSPI;");
            try
            {
                objConectar.Open();
                Console.WriteLine("Se realizo la conexion...");
                SqlCommand comando = new SqlCommand("select * from PRODUCTOS", objConectar);
                SqlDataReader tabla = comando.ExecuteReader();
                Console.WriteLine("Código \t\t Nombre \t\t Cantidad \t'\t Precio \n");
                try {
                    while (tabla.Read() == true)
                    {
                        Console.WriteLine("" + tabla[0] + "\t\t" + tabla[1] + "\t\t" + tabla[2] + "\t\t" + tabla[3]);
                    }
                    tabla.Close();
                } catch (SqlException e)
                    {
                        Console.WriteLine("Falló la operación. " + e.Message);
                    }
            }
            catch (Exception ex) {
                Console.WriteLine("Mal conexión. " + ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
