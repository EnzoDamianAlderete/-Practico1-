namespace _Practico1_
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox de Apellido y Nombre
            string apellido = TBApellido.Text;
            string nombre = TBNombre.Text;

            // Concatenar Apellido y Nombre
            string resultado = apellido + " " + nombre;

            // Mostrar el resultado en el tercer TextBox (TBResultado)
            TBResultado.Text = resultado;
        }

        private void TBNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            TBResultado.Clear();
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            // Finalizar la aplicación
            Application.Exit();
        }
    }
}
