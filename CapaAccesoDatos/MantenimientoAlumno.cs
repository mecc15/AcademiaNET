using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class MantenimientoAlumno
    {
        String sql;
        Conexion conn = new Conexion();
        SqlCommand cmd;
        String error;
        int res=0;
        public DataTable mostrarAlumnos(String tabla,String p)
        {
            DataTable datos = new DataTable();
            SqlDataAdapter adap;
            if(p=="")
               this.sql = "select * from " + tabla;
            else
               this.sql = "select * from " + tabla + " where Nombre like '%"+p+"%' or Apellido like '%"+p+"%'";
            try
            {
                conn.abrir_conexion();
               
                adap = new SqlDataAdapter(this.sql, conn.conex);
                adap.Fill(datos);
            }
            catch (Exception e)
            {
                error="Error " + e.ToString();
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return datos;
        }
        public string agregar(Alumno a)
        {
            cmd = new SqlCommand(string.Format("Insert Into Alumnos(Nombre, Apellido, Direccion, Fecha_Nacimiento) values('{0}', '{1}', '{2}', '{3}')",
            a.Nombre, a.Apellido, a.Direccion,a.Fecha_Nac), conn.conex);
            try
            {
                conn.abrir_conexion();
                res=cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + res;
        }
        public string modificar(Alumno a)
        {
            cmd = new SqlCommand(string.Format("Update Alumnos set Nombre='{0}',Apellido='{1}',Direccion='{2}',Fecha_Nacimiento='{3}' where Id='{4}'",
            a.Nombre, a.Apellido, a.Direccion, a.Fecha_Nac, a.Id), conn.conex);
            try
            {
                conn.abrir_conexion();
                res=cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return "" + res;
        }
        public string eliminar(Alumno a)
        {
            cmd = new SqlCommand(string.Format("Delete From Alumnos where Id='{0}'",a.Id), conn.conex);
            try
            {
                conn.abrir_conexion();
                res=cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                error = "Error " + e.Message;
                return error;
            }
            finally
            {
                conn.cerrar_conexion();
            }
            return ""+res;
        }
    }
}
