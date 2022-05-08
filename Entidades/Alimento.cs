using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alimento
    {
        private string nombre;
        private float precio;
        private int cantidad;
        private bool esBebida;
        private int stock;

        public Alimento(string nombre, float precio, int cantidad, bool esBebida, int stock)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.esBebida = esBebida;
            this.stock = stock;
        }

        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = ValidarStock(value);
            }
        }

        private int ValidarStock(int value)
        {
            if (value < 0)
                return 0;
            return value;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = ValidarCantidad(value); }
        }

        private int ValidarCantidad(int value)
        {
            if (value < 0)
                return 0;
            return value;
        }

        public bool EsBebida
        {
            get { return this.esBebida; }
        }

        public bool HayExistencias
        {
            get { if (this.cantidad > 0 )
                    return true;
                return false;
            }
        }
    }
}
