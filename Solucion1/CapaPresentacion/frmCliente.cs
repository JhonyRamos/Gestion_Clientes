using System;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;// Asegúrate de importar la capa de entidad
using CapaNegocios;// Asegúrate de importar la capa de negocios
using System.Data;

namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {
        // Declaración del OpenFileDialog
        OpenFileDialog ofdFoto;

        // Instancia de la capa de negocios
        private CNClientes cNClientes;

        public frmCliente()
        {
            InitializeComponent();

            // Inicialización del OpenFileDialog
            ofdFoto = new OpenFileDialog(); // Inicializa el objeto en el constructor

            cNClientes = new CNClientes(); // Inicializar la instancia de CNClientes


            CargarDatos(); // Llama a cargar datos en el constructor

        }

        private void CargarDatos()
        {
            // Llama al método ListarClientes de CNClientes
            var dataSet = cNClientes.ListarClientes(); // Asegúrate de que cNClientes esté instanciado

            // Supongamos que tienes un DataGridView llamado gridDatos
            gridDatos.DataSource = dataSet.Tables[0]; // Asigna la tabla del DataSet al DataGridView
        }



        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Restablecer los campos del formulario
            txtId.Value = 0;                   // Restablecer el valor del NumericUpDown a 0
            txtNombres.Text = string.Empty;     // Limpiar el campo de Nombres
            txtApellidos.Text = string.Empty;   // Limpiar el campo de Apellidos
            picFoto.Image = null;               // Eliminar la imagen en el PictureBox
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdFoto.FileName = string.Empty; // Limpiar el nombre del archivo antes de abrir el diálogo

            // Configurar el filtro para permitir solo imágenes
            ofdFoto.Filter = "Imagenes (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";


            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                picFoto.Load(ofdFoto.FileName);// Cargar la imagen seleccionada en el PictureBox
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool validado;

            // Crear una nueva instancia de CECliente
            CECliente cECliente = new CECliente();

            // Asignar los valores de los controles del formulario a las propiedades de CECliente
            cECliente.Id = (int)txtId.Value;             // Asignar el valor del NumericUpDown a Id
            cECliente.Nombres = txtNombres.Text;         // Asignar el texto de txtNombres a Nombres
            cECliente.Apellidos = txtApellidos.Text;     // Asignar el texto de txtApellidos a Apellidos
            cECliente.Foto = picFoto.ImageLocation;      // Asignar la ubicación de la imagen en PictureBox a Foto

            // Validar los datos del cliente
            validado = cNClientes.ValidarDatos(cECliente);

            // Si los datos no son válidos, terminar el proceso
            if (validado == false)
            {
                return;
            }

            // Crear el cliente utilizando la capa de negocios
            cNClientes.CrearCliente(cECliente);

            // Actualizar los datos después de guardar el cliente
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gridDatos.SelectedRows.Count > 0) // Verifica que hay una fila seleccionada
            {
                // Obtén el ID del cliente seleccionado
                int id = Convert.ToInt32(gridDatos.SelectedRows[0].Cells["Id"].Value);

                // Confirmar la eliminación
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Llamar al método EliminarCliente en la capa de negocios
                    cNClientes.EliminarCliente(id);

                    // Actualizar los datos después de eliminar el cliente
                    CargarDatos();
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
            }
        }
    }
}
