using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase5.Ej1
{
    public class Todo
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public bool Asignada { get; set; }
        public string NombreResponsable { get; set; }

        public Todo(int codigo, string nombre, DateTime fechaCreacion, DateTime fechaActualizacion, bool asignada, string nombreResponsable)
        {
            this.Codigo = codigo;
            this.Nombre = nombre;
            this.FechaCreacion = fechaCreacion;
            this.FechaActualizacion = fechaActualizacion;
            this.Asignada = asignada;
            this.NombreResponsable = nombreResponsable;
        }
    }
}
