using System;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Temporizador
    {
        CancellationToken cancellationToken;
        CancellationTokenSource cancellationTokenSource;
        Task hilo;
        int intervalo;
        bool estaActivo = false;
        int segundos;

        // Declaro el delegado
        public delegate void DelegadoTemporizador();

        // Declaro el evento
        public event DelegadoTemporizador TiempoCumplido;

        public int Intervalo
        {
            get { return intervalo; }
        }

        public bool EstaActivo
        {
            get { return estaActivo; }
            set { estaActivo = value; }
        }

        public int Segundos
        {
            get => segundos;
            set { segundos = value; }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        private void CorrerTiempo()
        {
            while(!cancellationToken.IsCancellationRequested)
            {
                Thread.Sleep(this.Intervalo);
                TiempoCumplido.Invoke();
            }
        }

        public void DetenerTemporizador()
        {
            if(this.EstaActivo == true)
            {
                cancellationTokenSource.Cancel();
                this.EstaActivo = false;
            }
        }

        public void IniciarTemporizador()
        {
            if(this.EstaActivo == false)
            {
                this.cancellationTokenSource = new CancellationTokenSource();
                this.cancellationToken = this.cancellationTokenSource.Token;
                hilo = Task.Run(CorrerTiempo, this.cancellationToken);

                this.EstaActivo = true;
            }
        }

        


    }
}
