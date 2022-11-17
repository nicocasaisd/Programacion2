using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAvisador : Form
    {
        Persona persona;

        public FrmAvisador()
        {
            InitializeComponent();
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if(persona == null)
            {
                persona = new Persona();
                // Suscribo el metodo al evento de persona
                persona.EventoString += NotificarCambio;
                this.btn_Crear.Text = "Actualizar";
            }
            persona.Nombre = txt_Nombre.Text;
            persona.Apellido = txt_Apellido.Text;
            lbl_NombreCompleto.Text = persona.Mostrar();
        }

        public static void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
