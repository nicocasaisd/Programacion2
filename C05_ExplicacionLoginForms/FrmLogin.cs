using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05_ExplicacionLoginForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void btn_loguearse_Click(object sender, EventArgs e)
        {
            if(this.tb_user.Text == "Lucas" && this.tb_pass.Text == "asd123")
            {
                FrmMenu menu = new FrmMenu();

                menu.Show(); // mostrate
                this.Hide(); // ocultate
                
                //MessageBox.Show("Usuario logueado.");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalida.");
                this.tb_user.Text = string.Empty;
                this.tb_pass.Text = "";
            }

            
        }
    }
}
