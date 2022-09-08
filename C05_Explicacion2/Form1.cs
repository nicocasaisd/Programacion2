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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(this.tb_usuario.Text == "Nico" && this.tb_pass.Text == "asd123")
            {
                FrmMenu menu = new FrmMenu();
                menu.ActualizarMensaje(this.tb_usuario.Text);
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario incorrecto!");

            }


        }
    }
}
