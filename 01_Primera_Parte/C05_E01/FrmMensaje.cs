using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05_E01
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje()
        {
            InitializeComponent();
        }

        public FrmMensaje(string titulo, string mensaje) : this()
        {
            this.Text = titulo;
            this.lblMensaje.Text = mensaje;
        }
    }
}
