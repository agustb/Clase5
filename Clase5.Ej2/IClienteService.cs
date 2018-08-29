using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase5.Ej2
{
    interface IClienteService
    {
        int AltaCliente(Cliente cliente);
        int BajaCliente(Cliente cliente);
        int ModificarCliente(int id, Cliente cliente);
        int EliminarCliente(int id);
        List<Cliente> BuscarClientes(string nombre);
        Cliente BuscarClientePorId(int id);

        // Esto es una prueba 

    }
}
