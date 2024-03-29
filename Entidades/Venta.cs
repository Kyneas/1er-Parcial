﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        DateTime fechaVenta;
        bool usoCredito;
        bool usoEstacionamiento;
        int numeroMesa;
        List<Alimento> listaComida;
        float saldo;
        float saldoTotal;
        string consumision;
        static float recargoCredito;
        static int recargoEstacionamiento;

        public Venta(int idMesa, float saldo, List<Alimento> listaComida, bool usoCredito, bool usoEstacionamiento)
        {
            this.fechaVenta = DateTime.Now;
            this.numeroMesa = idMesa;
            this.saldo = saldo;
            this.listaComida = listaComida;
            this.usoCredito = usoCredito;
            this.usoEstacionamiento = usoEstacionamiento;
            this.saldoTotal = this.SaldoTotal;
            this.consumision = ListarConsumisiones();
        }

        static Venta()
        {
            recargoCredito = 1.1f;
            recargoEstacionamiento = 50;
        }

        public bool UsoCredito
        {
            get 
            {
                return this.usoCredito;
            }
        }

        public bool UsoEstacionamiento
        {
            get
            {
                return this.usoEstacionamiento;
            }
        }

        public float SaldoParcial 
        {
            get { return this.saldo; }
        }

        public float SaldoTotal 
        {
            //set { this.saldoTotal = VerificarSaldoTotal();}
            get { return VerificarSaldoTotal(); }
        }

        public static float RecargoCredito 
        {
            get { return recargoCredito; }
        }

        public static int RecargoEstacionamiento 
        {
            get { return recargoEstacionamiento; }
        }

        public DateTime FechaVenta 
        {
            get { return this.fechaVenta; }
        }

        private string ListarConsumisiones()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("------------------------------");
            foreach (Alimento item in listaComida)
            {
                sb.AppendLine($"#{item.Cantidad,-5} {item.NombreCompleto,-30} {item.Precio,-5} {(item.Cantidad * item.Precio),-5}");
            }
            sb.AppendLine("------------------------------");
            return sb.ToString();
        }

        private float VerificarSaldoTotal()
        {
            float saldoTotal = this.saldo;
            if (this.usoCredito)
            {
                saldoTotal *= Venta.recargoCredito;
            }
            if (this.usoEstacionamiento)
            {
                saldoTotal += Venta.recargoEstacionamiento;
            }
            return saldoTotal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Fecha: {this.fechaVenta}");
            sb.AppendLine($"Mesa: {this.numeroMesa}");
            sb.Append(this.consumision);
            sb.AppendLine($"Saldo parcial: {this.saldo}");
            if (usoCredito)
            {
                sb.AppendLine($"*Recargo pago con credito {Venta.recargoCredito}");
            }
            if (usoEstacionamiento)
            {
                sb.AppendLine($"*Recargo estacionamiento {Venta.recargoEstacionamiento}");
            }
            sb.AppendLine($"Saldo total: {this.SaldoTotal}");
            return sb.ToString();
        }
    }
}
