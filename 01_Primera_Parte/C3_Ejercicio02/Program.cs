using System;
using Entidades;

/*
 *Ejercicio I02 - ¿Vos cuántas primaveras tenés?
Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no. 
 *
 */

namespace C3_Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1;
            DateTime fechaDeNacimiento = new DateTime(1991, 9, 19);
            persona1 = new Persona("Nicolas", fechaDeNacimiento, "36396134");

            Persona persona2;
            DateTime fechaDeNacimiento2 = new DateTime(2005, 5, 15);
            persona2 = new Persona("Juan", fechaDeNacimiento2, "50123456");

            Persona persona3;
            DateTime fechaDeNacimiento3 = new DateTime(1965, 12, 27);
            persona3 = new Persona("Edith", fechaDeNacimiento3, "17768822");


            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine($"{persona1.GetNombre()} es mayor de edad? : {persona1.EsMayorDeEdad()} \n");

            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine($"{persona2.GetNombre()} es mayor de edad? : {persona2.EsMayorDeEdad()} \n");

            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine($"{persona3.GetNombre()} es mayor de edad? : {persona3.EsMayorDeEdad()} \n");

        }
    }
}
