using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class Alumno
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Fecha_Nac { get; set; }

        public Alumno()
        {
        }

        public Alumno(int pId, string pNombre, string pApellido, string pDireccion, string pFecha_Nac)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Direccion = pDireccion;
            this.Fecha_Nac = pFecha_Nac;
        }
    }
}
