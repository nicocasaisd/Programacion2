using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicacion_POO
{
    public class Animal
    {
        //ATRIBUTOS

        public string nombre;
        public int edad;
        public string tipoDeAnimal;
        // atributo estatico compartido por todos
        public static int contadorDeAnimales;

        // METODOS

        public string Hablar()
        {
            StringBuilder sb = new StringBuilder(); // --> System.Text
            // evitamos generar muchos strings por detrás del programa con cada +
            sb.Append("Mi nombre es "); // agregar linea
            sb.AppendLine(this.nombre); // agrega y da un '\n'
            sb.Append("Tengo ");
            sb.Append( this.edad.ToString() );
            sb.AppendLine(" años");
            sb.Append("Y soy un ");
            sb.AppendLine(this.tipoDeAnimal);

            return sb.ToString(); // pasamos el objeto sb a un string
        }
        // Hablar
        // Comer

        // CONSTRUCTOR
        // ctor + tab tab

        // constructor sin parametros
        public Animal()
        {
            // Aumentamos el contador de animales
            Animal.contadorDeAnimales++;
            // Es buena practica dar valores por defecto
            this.nombre = "Sin nombre";
            this.edad = 0;
            this.tipoDeAnimal = "Desconocido";
        }

        // constructor parametrizado
        public Animal(string nombre, int edad = 2, string tipoDeAnimal = "Perro") // <-- valor por defecto
        {
            Animal.contadorDeAnimales++;
            this.nombre = nombre;
            this.edad = edad;
            this.tipoDeAnimal = tipoDeAnimal;
        }

        // constructor estático
        static Animal()
        {
            Animal.contadorDeAnimales = 0;
        }


    }
}
