using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego = -1;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            nupPrecio.Maximum = 10000;
            this.codigoJuego = codigoJuego;
            PintarForm();
        }

        private void PintarForm()
        {
            if(codigoJuego > 0)
            {
                Juego juego = JuegoDAO.LeerPorId(this.codigoJuego);
                txtNombre.Text = juego.Nombre;
                txtGenero.Text = juego.Genero;
                nupPrecio.Value = (decimal)juego.Precio;
            }
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            cmbUsuarios.DataSource = UsuarioDAO.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if(codigoJuego == -1)
                {
                    Juego juegoNuevo = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);
                    JuegoDAO.Guardar(juegoNuevo);
                }
                else
                {
                    Juego juegoExistente = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text, this.codigoJuego, ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);
                    JuegoDAO.Modificar(juegoExistente);
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.Cancel;
            }

        }
    }
}
