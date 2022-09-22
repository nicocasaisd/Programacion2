﻿using System;

namespace Entidades
{
    public class Cliente
    {
        // ATRIBUTOS
        private string nombre;
        private int numero;

        // PROPIEDADES
        public string Nombre 
        {
            get { return this.nombre; } 
            set { this.nombre = value; }
        }

        public int Numero
        {
            get { return this.numero; }
        }

        // METODOS
        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(int numero, string nombre) :this(numero)
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
