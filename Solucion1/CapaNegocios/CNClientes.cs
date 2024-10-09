using CapaEntidad;
using CapaDatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaNegocios
{
    public class CNClientes
    {
        // Instancia de la capa de datos
        CDCliente cDCliente = new CDCliente(); // Asegúrate de que esta línea esté presente

        // Método para validar los datos del cliente
        public bool ValidarDatos(CECliente cliente)
        {
            bool validado = true; // Inicializa la variable validado como verdadera

            // Validar nombres
            if (string.IsNullOrEmpty(cliente.Nombres)) // Cambié a Nombres para que coincida con la propiedad
            {
                MessageBox.Show("Los Nombres son Obligatorios");
                validado = false;
            }

            // Validar apellidos
            if (string.IsNullOrEmpty(cliente.Apellidos)) // Cambié a Apellidos para que coincida con la propiedad
            {
                MessageBox.Show("Los Apellidos son Obligatorios");
                validado = false;
            }

            // Validar foto
            if (string.IsNullOrEmpty(cliente.Foto)) // Cambié a Foto para que coincida con la propiedad
            {
                MessageBox.Show("La Foto es Obligatoria");
                validado = false;
            }

            return validado; // Devuelve el resultado de la validación
        }

        // Método para crear un cliente
        public void CrearCliente(CECliente cliente)
        {
            if (ValidarDatos(cliente)) // Asegúrate de validar los datos primero
            {
                cDCliente.Crear(cliente); // Llama al método Crear en CDCliente
            }
        }

        // Método para listar clientes
        public DataSet ListarClientes()
        {
            return cDCliente.Listar(); // Llama al método Listar en CDCliente
        }

        public void EliminarCliente(int id)
        {
            cDCliente.Eliminar(id); // Llama al método Eliminar en la capa de datos
        }

    }
}
