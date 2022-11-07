using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {
            lst_Personas.DataSource = Entidades.PersonaDAO.Leer();
        }

        private void lst_Personas_SelectedValueChanged(object sender, EventArgs e)
        {
            Persona auxiliar = (Persona)lst_Personas.SelectedItem;
            txt_Nombre.Text = auxiliar.Nombre;
            txt_Apellido.Text = auxiliar.Apellido;
        }
    }
}
