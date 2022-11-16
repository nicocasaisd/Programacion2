using System;

namespace Explicacion_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // Instanciar un objeto
            Animal animal1; //  <-- memoria STACK (estática)

            // constructor
            animal1 = new Animal("Pepe", 10, "Perro"); // <-- memoria HEAP (dinámica)
                                    //      reserva espacio en memoria
            //animal1.nombre = "Pepe";
            //animal1.edad = 10;
            //animal1.tipoDeAnimal = "Perro";
            Console.WriteLine(animal1.Hablar());


            Animal animal2;
            animal2 = new Animal("Juana", 5, "Gato");
            //animal2 = new Animal();
            //animal2.nombre = "Juana";
            //animal2.edad = 5;
            //animal2.tipoDeAnimal = "Gato";
            Console.WriteLine(animal2.Hablar());

            Console.WriteLine(animal2.nombre + " es de tipo "+ animal2.tipoDeAnimal);

            Console.WriteLine("Cantidad de animales: " + Animal.contadorDeAnimales);

        }
    }
}
