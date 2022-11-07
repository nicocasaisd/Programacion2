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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int id = ((Persona)lst_Personas.SelectedItem).Id;

            if(PersonaDAO.Modificar(id, txt_Nombre.Text, txt_Apellido.Text) != 0)
            {
                MessageBox.Show("Se modifico el registro.");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_Nombre.Text) || String.IsNullOrEmpty(txt_Apellido.Text))
            {
                MessageBox.Show("Los campos de nombre y apellido no pueden estar vacios");
                return;
            }
            if(PersonaDAO.Guardar(txt_Nombre.Text, txt_Apellido.Text) != 0)
            {
                MessageBox.Show("Se ha agregado un registro.");
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            int id = ((Persona)lst_Personas.SelectedItem).Id;

            if (PersonaDAO.Borrar(id) != 0)
            {
                MessageBox.Show("Se ha eliminado un registro.");
            }
        }
    }
}
