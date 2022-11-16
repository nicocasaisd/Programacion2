using System.Text;

namespace C05_E01
{
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            FrmMensaje frmMensaje = new FrmMensaje("Saludo", $"Soy {txtNombre.Text} {txtApellido.Text} y mi materia favorita es {cbMateria.Text}");

            if (String.IsNullOrWhiteSpace(txtApellido.Text) || String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se deben completar los siguientes campos: ");
                if (String.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    sb.AppendLine("Nombre");
                }
                if (String.IsNullOrWhiteSpace(txtApellido.Text))
                {
                    sb.AppendLine("Apellido");
                }
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                frmMensaje.ShowDialog();
            }
        }

        private void FrmBienvenida_Load(object sender, EventArgs e)
        {
            cbMateria.Items.Clear();
            cbMateria.Items.Add("Programacion I");
            cbMateria.Items.Add("Programacion II");
            cbMateria.Items.Add("SPD");
            cbMateria.Items.Add("Matemática");
            cbMateria.Items.Add("Inglés");
            cbMateria.SelectedIndex = 3;
        }
    }
}