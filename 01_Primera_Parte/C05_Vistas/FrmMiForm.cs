namespace C05_Vistas
{
    public partial class FrmMiForm : Form
    {
        public FrmMiForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Error");
            }
            else
            {
                MessageBox.Show($"Hola {nombre}", "Bienvenido", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSaludarForm_Click(object sender, EventArgs e)
        {
            string nombre;
            nombre = this.txtNombre.Text;
            // Instanciamos el formulario
            FrmSaludar frmSaludar = new FrmSaludar(nombre);
            // Lo mostramos y preguntamos por la bandera DialogResult
            if (frmSaludar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Usted acepta su nombre");
            }
            else
            {
                MessageBox.Show("No le gusta su nombre");
            }
        }
    }
}