using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase5.Ej1
{ 

    public class TodoService : ITodoService
    {
        private List<Todo> _todoLista;

        public TodoService()
        {
            _todoLista.Add(
                new Todo(1, "Crear proyecto",new DateTime(20180810),new DateTime(20180814),true, "Agustin"),
                new Todo(2, "Asignar tareas", new DateTime(20180810), new DateTime(20180814), true, "Andres"),
                new Todo(3, "Confirmar participantes", new DateTime(20180811), new DateTime(20180813), false, ""),
                new Todo(4, "Revision mensual", new DateTime(20180810), new DateTime(20180814), true, "Francisco"),
                new Todo(5, "Conclusiones", new DateTime(20180813), new DateTime(20180814), true, "Guille")
            );
        }

        public int ActualizarTarea(Todo tarea)
        {
            throw new NotImplementedException();
        }

        public int EliminarTarea(int codigo)
        {
            throw new NotImplementedException();
        }

        public int GuardarTarea(Todo tarea)
        {
            throw new NotImplementedException();
        }

        public Todo ObtenerTareaPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public List<Todo> ObtenerTareas(DateTime fcdesde, DateTime fchasta, bool asignada)
        {
            throw new NotImplementedException();
        }
    }
}
