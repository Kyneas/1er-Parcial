using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Bar
{
    public partial class CargaDePedido : Form
    {
        int mesa;
        Posicion lugar;
        Posicion lugarOriginal;

        public CargaDePedido()
        {
            InitializeComponent();
        }

        public CargaDePedido(int mesa, Posicion lugarOriginal) : this()
        {
            this.mesa = mesa;
            this.lugarOriginal = lugarOriginal;
            this.lugar = new Posicion(lugarOriginal.Lugar);
            this.lugar.ListaComidaPedida = new Dictionary<int, Alimento>();
            foreach (KeyValuePair<int,Alimento> item in lugarOriginal.ListaComidaPedida)
            {
                if (item.Value is Comida)
                {
                    this.lugar.ListaComidaPedida.Add(item.Key, new Comida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
                    lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                    ((Comida)lugarOriginal.ListaComidaPedida[item.Key]).Vegano));
                }
                if (item.Value is Bebida)
                {
                    this.lugar.ListaComidaPedida.Add(item.Key, new Bebida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
                    lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                    ((Bebida)lugarOriginal.ListaComidaPedida[item.Key]).Presentacion));
                }
            }
        }

        private void CargaDePedido_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: ${lugar.Saldo}";
            lblNumeroMesa.Text = $"Mesa: {mesa}";
            this.lvwListaAlimentos.FullRowSelect = true;//Seleccionar toda la fila
            ValidarSiHaySaldoParaHabilitarBotones();
            AgregarTodasLosAlimentos();
        }

        public void AgregarTodasLosAlimentos()
        {
            foreach (KeyValuePair<int, Alimento> item in lugar.ListaComidaPedida)
            {
                LogicaForms.AgregarFilaAListView(lvwListaAlimentos, item.Key.ToString(), item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            RestarOSumarProductosALaMesa(btnMas);
        }

        private void btbMenos_Click(object sender, EventArgs e)
        {
            RestarOSumarProductosALaMesa(btnMenos);
        }

        private void RestarOSumarProductosALaMesa (Button boton)
        {
            if (lvwListaAlimentos.SelectedItems.Count > 0)
            {
                int id = int.Parse(lvwListaAlimentos.SelectedItems[0].Text);
                if (boton == btnMas)
                {
                    lugar.ListaComidaPedida[id].Cantidad++;
                    lugar.ListaComidaPedida[id].Stock--;
                }
                else if (boton == btnMenos)
                {
                    lugar.ListaComidaPedida[id].Cantidad--;
                    lugar.ListaComidaPedida[id].Stock++;
                }
                int itemSeleccionado = lvwListaAlimentos.SelectedIndices[0];
                lvwListaAlimentos.Items.Clear();
                AgregarTodasLosAlimentos();
                lvwListaAlimentos.Items[itemSeleccionado].Selected = true;
                lblSaldo.Text = $"Saldo: ${lugar.Saldo}";
                if (lugar.ListaComidaPedida[id].Stock == 0 && boton == btnMas)
                {
                    boton.Enabled = false;
                }
                else if (lugar.ListaComidaPedida[id].Cantidad == 0 && boton == btnMenos)
                {
                    boton.Enabled = false;
                }
                ValidarSiHaySaldoParaHabilitarBotones();
        }
            else
            {
                boton.Enabled = false;
            }
}

        private void btnCerrar_Click(object sender, EventArgs e)//Boton CERRAR MESA
        {
            ActualizarStocksPorPedidoHecho();
            ConfirmarVenta venta = new ConfirmarVenta(this.mesa, this.lugar);
            if (venta.ShowDialog() == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void lvwListaAlimentos_Click(object sender, EventArgs e)
        {
            btnMas.Enabled = true;
            btnMenos.Enabled = true;

            int id= int.Parse(lvwListaAlimentos.SelectedItems[0].Text);

            if (lugar.ListaComidaPedida[id].Stock == 0)
            {
                btnMas.Enabled = false;
            }

            if (lugar.ListaComidaPedida[id].Cantidad == 0)
            {
                btnMenos.Enabled = false;
            }

        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            ActualizarStocksPorPedidoHecho();
            this.Dispose();
        }

        private void ValidarSiHaySaldoParaHabilitarBotones()
        {
            if (lugar.Saldo == 0)
            {
                btnCerrarMesa.Enabled = false;
            }
            else
            {
                btnCerrarMesa.Enabled = true;
            }
        }

        private void ActualizarStocksPorPedidoHecho()
        {
            foreach (KeyValuePair<int, Alimento> item in Sistema.listaAlimentos)
            {
                item.Value.Stock = lugar.ListaComidaPedida[item.Key].Stock;//Actualizo stock de lista de sistema
                lugarOriginal.ListaComidaPedida[item.Key].Stock = lugar.ListaComidaPedida[item.Key].Stock;//Actualizo stock de lista de mesa original
                lugarOriginal.ListaComidaPedida[item.Key].Cantidad = lugar.ListaComidaPedida[item.Key].Cantidad;
                lugarOriginal.Ocupada = true;
            }
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
