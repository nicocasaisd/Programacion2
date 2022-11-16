using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03_Geometria
{
    public class Rectangulo
    {

        #region Atributos

        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        #endregion

        #region Metodos

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            // calculo los otros vertices
            Punto vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            Punto vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());

            this.vertice2 = vertice2;
            this.vertice4 = vertice4;
        }

        public float Area()
        {
            float baseR;
            float alturaR;

            if(this.area == 0)
            {
                baseR = Math.Abs(this.vertice3.GetX() - this.vertice2.GetX());
                alturaR = Math.Abs(this.vertice1.GetY() - this.vertice2.GetY());
                this.area = (float)baseR * alturaR;
            }
            return this.area;
        }

        public float Perimetro()
        {
            float baseR;
            float alturaR;

            if (this.perimetro == 0)
            {
                baseR = Math.Abs(this.vertice3.GetX() - this.vertice2.GetX());
                alturaR = Math.Abs(this.vertice1.GetY() - this.vertice2.GetY());
                this.perimetro = (float) baseR*2 +  alturaR*2;
            }
            return this.perimetro;
        }

        #endregion
    }
}
