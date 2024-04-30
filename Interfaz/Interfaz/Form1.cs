namespace Interfaz
{
    public partial class Form1 : Form
    {
        Empleado myEmpleado = new Empleado();
        Nomina myNomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            myEmpleado.Nombre = txtNombre.Text;
            myEmpleado.Identifiacion = txtIden.Text;
            myEmpleado.Asignacion = txtAsig.Text;
            myEmpleado.Dia = txtdias.Text;
            MessageBox.Show("Se guardó el registro correctamente");
        }

        private void btnSalario_Click(object sender, EventArgs e) => txtTtotal.Text = myNomina.CalcularNomina(Convert.ToInt32((myNomina.DiasLaborados), Convert.ToDecimal(myEmpleado.Asignacion).
            ;

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtIden.Clear();
            txtAsig.Clear();
            txtdias.Clear();
            txtTtotal.Clear();
        }
    }
}   
