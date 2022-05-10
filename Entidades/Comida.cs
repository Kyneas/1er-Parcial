using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comida: Alimento
    {
        bool vegano;

        public Comida (string nombre, float precio, int cantidad, int stock, bool vegano):base(nombre, precio, cantidad, stock)
        {
            this.vegano = vegano;
        }

        public bool Vegano
        {
            get { return this.vegano; }
        }

        public override string NombreCompleto
        {
            get { return NombreCompletoComida(); }
        }

        private string NombreCompletoComida()
        {
            string nombre = this.Nombre;
            if (this.Vegano)
                nombre += " 🐄❤";
            return nombre;
        }

        public static bool operator ==(Comida c1, Comida c2)
        {
            return c1.Nombre == c2.Nombre && c1.vegano == c2.vegano;
        }
        public static bool operator !=(Comida c1, Comida c2)
        {
            return !(c1 == c2);
        }
    }
}
