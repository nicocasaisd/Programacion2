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
            this.reloj.TiempoCumplido += IncrementarSegundos;
        }

        public void IncrementarSegundos()
        {
            reloj.Segundos++;
            lblReloj.Text = reloj.Segundos.ToString();
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
