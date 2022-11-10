using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AsignarHora()
        {
            DateTime ahora = DateTime.Now;
            this.lblHora.Text = $"{ahora.Hour}:{ahora.Minute}:{ahora.Second}";
            //Thread.Sleep(1000);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Show();
            AsignarHora();
            //while (true)
            //{
            //    AsignarHora();

            //}
            //MessageBox.Show("Terminado");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AsignarHora();
        }
    }
}
