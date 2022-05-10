using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bebida: Alimento
    {
        public enum Tamanio
        {
            Lata_330ml, Lata_473ml, Botella_710ml, Botella_975ml, Botella_1500ml
        }

        Tamanio presentacion;

        public Bebida(string nombre, float precio, int cantidad, int stock, Tamanio presentacion) : base(nombre, precio, cantidad, stock)
        {
            this.presentacion = presentacion;
        }

        public Tamanio Presentacion
        {
            get
            {
                return this.presentacion;
            }
        }

        public override string NombreCompleto
        {
            get
            {
                return NombreCompletoBebida();
            }
        }

        private string NombreCompletoBebida()
        {
            string nombre = this.Nombre;
            nombre += " ";
            nombre += this.Presentacion;
            return nombre;
        }

        public static bool operator == (Bebida b1, Bebida b2)
        {
            return b1.Nombre == b2.Nombre && b1.presentacion == b2.presentacion;
        }

        public static bool operator !=(Bebida b1, Bebida b2)
        {
            return !(b1 == b2);
        }
    }
}
