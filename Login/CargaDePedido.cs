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

        public CargaDePedido(int mesa, Posicion lugar) : this()
        {
            this.mesa = mesa;
            this.lugarOriginal = lugar;
            this.lugar = new Posicion(lugar.Lugar,lugar.Ocupada);
            this.lugar.ListaComidaPedida = new Dictionary<int, Alimento>();
            foreach (KeyValuePair<int,Alimento> item in lugar.ListaComidaPedida)
            {
                this.lugar.ListaComidaPedida.Add(item.Key,new Alimento(lugar.ListaComidaPedida[item.Key].Nombre,
                    lugar.ListaComidaPedida[item.Key].Precio, lugar.ListaComidaPedida[item.Key].Cantidad,
                    lugar.ListaComidaPedida[item.Key].EsBebida, Sistema.listaAlimentos[item.Key].Stock));
            }
        }

        private void CargaDePedido_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: ${lugar.Saldo}";
            lblNumeroMesa.Text = $"Mesa: {mesa}";
            this.lvwListaAlimentos.FullRowSelect = true;
            ValidarSiHaySaldoParaHabilitarBotones();
            AgregarTodasLosAlimentos();
        }

        private void MostrarAlimentos(string id, string nombreComida, string precio, string cantidad)
        {
            String[] fila = { id, nombreComida, precio, cantidad };
            ListViewItem item = new ListViewItem(fila);
            this.lvwListaAlimentos.Items.Add(item);
        }

        public void AgregarTodasLosAlimentos()
        {
            foreach (KeyValuePair<int, Alimento> item in lugar.ListaComidaPedida)
            {
                MostrarAlimentos(item.Key.ToString(), item.Value.Nombre, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
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
                btbConfirmarPedido.Enabled = false;
            }
            else
            {
                btnCerrarMesa.Enabled = true;
                btbConfirmarPedido.Enabled = true;
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
