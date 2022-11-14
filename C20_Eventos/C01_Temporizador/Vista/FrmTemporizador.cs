using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Vista
{
    public partial class FrmTemporizador : Form
    {
        Temporizador reloj;

        public FrmTemporizador()
        {
            InitializeComponent();
        }

        private void FrmTemporizador_Load(object sender, EventArgs e)
        {
            this.reloj = new Temporizador(1000);
            // Suscribo un metodo al evento TiempoCumplido de Temporizador
            this.reloj.TiempoCumplido += AsignarHora;
            //this.reloj.TiempoCumplido += AsignarHora_InvokeRequired;
        }

        //public void IncrementarSegundos()
        //{
        //    //DateTime tiempo = reloj.DateTime;
        //    _ = reloj.DateTime.AddSeconds(1);
        //    //tiempo.AddSeconds(1);
        //    lblReloj.Text = reloj.DateTime.ToString();
        //}

        public void AsignarHora()
        {
            lblReloj.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // InvokeRequired

        public void AsignarHora_InvokeRequired()
        {
            if(lblReloj.InvokeRequired)
            {
                Action asignarHora = AsignarHora_InvokeRequired;
                lblReloj.Invoke(asignarHora);
            }
            else
            {
                lblReloj.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.reloj.IniciarTemporizador();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.reloj.DetenerTemporizador();
        }
    }
}
