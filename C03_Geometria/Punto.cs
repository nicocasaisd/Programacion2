using System;

namespace C03_Geometria
{
    public class Punto
    {
        #region Atributos

        private int x;
        private int y;

        #endregion

        #region Metodos

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion

    }
}
