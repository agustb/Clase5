using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase5.Ej1
{ 
    public interface ITodoService
    {
        List<Todo> ObtenerTareas(DateTime fcdesde, DateTime fchasta, bool asignada);
        Todo ObtenerTareaPorCodigo(int codigo);
        int GuardarTarea(Todo tarea);
        int ActualizarTarea(Todo tarea);
        int EliminarTarea(int codigo);
    }
}
