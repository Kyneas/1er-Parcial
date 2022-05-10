using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Posicion
    {
        public enum Donde
        {
            Barra, Mesa
        }

        private Donde lugar;
        private bool ocupada;
        Dictionary<int, Alimento> listaComidaPedida;

        public Posicion(Donde lugar)
        {
            this.lugar = lugar;
            this.ocupada = false;
        }

        public Dictionary<int, Alimento> ListaComidaPedida
        {
            get
            {
                return this.listaComidaPedida;
            }
            set
            {
                this.listaComidaPedida = value;
            }
        }

        public Donde Lugar
        {
            get { return this.lugar; }
        }

        public float Saldo
        {
            //set { Saldo = VerificarSaldo(); }
            get { return VerificarSaldo(); }
        }

        public bool Ocupada
        {
            get { return this.ocupada; }
            set { this.ocupada = value; }
        }


        public void MesaSeOcupo()
        {
            if (this.Saldo > 0)
            {
                this.ocupada = true;
            }
        }

        private float VerificarSaldo()
        {

            if (this.listaComidaPedida.Count == 0)
                return 0;
            float acumulador = 0;
            foreach (Alimento alimento in this.listaComidaPedida.Values)
            {
                acumulador += alimento.Precio * alimento.Cantidad;
            }
            return acumulador;
        }

        public void VaciarMesa()
        {
            this.ocupada = false;
            foreach (Alimento alimento in this.listaComidaPedida.Values)
            {
                alimento.Cantidad = 0;
            }
        }

    }
}
