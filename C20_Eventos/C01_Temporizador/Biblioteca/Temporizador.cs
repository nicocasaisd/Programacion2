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

        public int Intervalo
        {
            get { return intervalo; }
        }

        public bool EstaActivo
        {
            get { return cancellationToken.IsCancellationRequested; }
        }

        public Temporizador(int intervalo)
        {
            this.intervalo = intervalo;
        }

        public void CorrerTiempo()
        {

        }

        public void DetenerTemporizador()
        {

        }

        public void IniciarTemporizador()
        {

        }

        // Declaro el delegado
        public delegate void DelegadoTemporizador();

        // Declaro el evento



    }
}
