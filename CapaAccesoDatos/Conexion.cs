using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    class Conexion
    {
        public SqlConnection conex = new SqlConnection("Data source =localhost; Initial catalog = Escuela; Integrated Security=True");
        public void abrir_conexion()
        {
            if (conex.State == ConnectionState.Closed)
                conex.Open();
        }
        public void cerrar_conexion()
        {
            if (conex.State == ConnectionState.Open)
                conex.Close();
        }
    }
}
