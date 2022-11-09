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
    public partial class Form1 : Form
    {
        FrmMostrar frmMostrar;
        FrmTestDelegados frmTestDelegados;

        //Action<string> delegado;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;

            frmTestDelegados = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
        }


        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
            this.toolStripMenuItem2.Enabled = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}
