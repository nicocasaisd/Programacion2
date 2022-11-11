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
            //AsignarHora();

            //Punto 3
            //Task t1 = Task.Run(AsignarHoraConInvoker);

            Task t2 = Task.Run(AsignarHoraSinInvoker);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //AsignarHora();
        }

        //Punto 3:
        public void AsignarHoraConInvoker()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.lblHora.Text = DateTime.UtcNow.ToString();
                    });
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }

            }
        }

        public void AsignarHoraConInvokerResumido()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)
                {
                    this.lblHora.BeginInvoke(() => {this.lblHora.Text = DateTime.UtcNow.ToString(); });
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }

            }
        }

        public void AsignarHoraSinInvoker()
        {
            while (true)
            {
                Thread.Sleep(1000);
                this.lblHora.Text = DateTime.UtcNow.ToString();
            }
        }


    }
}
