using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaAccesoDatos;

namespace CapaLogicadeNegocios
{
    public class TransacAlumno
    {
        MantenimientoAlumno obj = new MantenimientoAlumno();
        public DataTable mostrar_Alumnos()
        {
            return obj.mostrarAlumnos("Alumnos","");
        }
        public DataTable buscar_Alumnos(String p)
        {
            return obj.mostrarAlumnos("Alumnos", p);
        }
        public string agregar_alumno(String nombre,String apellido,String direccion,String fecha)
        {
            Alumno a = new Alumno(1, nombre, apellido, direccion, fecha);
            return obj.agregar(a);

        }
        public string modificar_alumno(String id,String nombre, String apellido, String direccion, String fecha)
        {
            Alumno a = new Alumno(int.Parse(id), nombre, apellido, direccion, fecha);
            return obj.modificar(a);

        }
        public string eliminar_alumno(String id)
        {
            Alumno a = new Alumno(int.Parse(id), "","","","");
            return obj.eliminar(a);
          
        }

    }
}
