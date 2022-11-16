using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05_Explicacion2
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(string nombreUsuario) : this()
        {
            this.lb_mensaje.Text = this.lb_mensaje.Text + " " + nombreUsuario;
        }

        public void ActualizarMensaje(string nombreUsuario)
        {
            this.lb_mensaje.Text = this.lb_mensaje.Text + " " + nombreUsuario;
        }
    }
}
