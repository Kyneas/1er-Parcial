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
        Posicion lugarCopia;
        Posicion lugarOriginal;

        public CargaDePedido()
        {
            InitializeComponent();
        }

        public CargaDePedido(int mesa, Posicion lugarOriginal) : this()
        {
            this.mesa = mesa;
            this.lugarOriginal = lugarOriginal;
            this.lugarCopia = new Posicion(lugarOriginal.Lugar);
            this.lugarCopia.ListaComidaPedida = new Dictionary<int, Alimento>();
            //foreach (KeyValuePair<int,Alimento> item in lugarOriginal.ListaComidaPedida)
            foreach (KeyValuePair<int,Alimento> item in Sistema.listaAlimentos)
            {
                if (item.Value is Comida)
                {
                    this.lugarCopia.ListaComidaPedida.Add(item.Key, new Comida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
                    lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                    ((Comida)lugarOriginal.ListaComidaPedida[item.Key]).Vegano));
                }
                if (item.Value is Bebida)
                {
                    this.lugarCopia.ListaComidaPedida.Add(item.Key, new Bebida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
                    lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                    ((Bebida)lugarOriginal.ListaComidaPedida[item.Key]).Presentacion));
                }
            }
        }

        private void CargaDePedido_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
            lblNumeroMesa.Text = $"Mesa: {mesa}";
            this.lvwListaAlimentos.FullRowSelect = true;//Seleccionar toda la fila
            ValidarSiHaySaldoParaHabilitarBotones();
            AgregarTodasLosAlimentos();
        }

        public void AgregarTodasLosAlimentos()
        {
            foreach (KeyValuePair<int, Alimento> item in lugarCopia.ListaComidaPedida)
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
                    lugarCopia.ListaComidaPedida[id].Cantidad++;
                    lugarCopia.ListaComidaPedida[id].Stock--;
                }
                else if (boton == btnMenos)
                {
                    lugarCopia.ListaComidaPedida[id].Cantidad--;
                    lugarCopia.ListaComidaPedida[id].Stock++;
                }
                int itemSeleccionado = lvwListaAlimentos.SelectedIndices[0];
                lvwListaAlimentos.Items.Clear();
                AgregarTodasLosAlimentos();
                lvwListaAlimentos.Items[itemSeleccionado].Selected = true;
                lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
                if (lugarCopia.ListaComidaPedida[id].Stock == 0 && boton == btnMas)
                {
                    boton.Enabled = false;
                }
                else if (lugarCopia.ListaComidaPedida[id].Cantidad == 0 && boton == btnMenos)
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
            ConfirmarVenta venta = new ConfirmarVenta(this.mesa, this.lugarCopia);
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

            if (lugarCopia.ListaComidaPedida[id].Stock == 0)
            {
                btnMas.Enabled = false;
            }

            if (lugarCopia.ListaComidaPedida[id].Cantidad == 0)
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
            if (lugarCopia.Saldo == 0)
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
                item.Value.Stock = lugarCopia.ListaComidaPedida[item.Key].Stock;//Actualizo stock de lista de sistema
                lugarOriginal.ListaComidaPedida[item.Key].Stock = lugarCopia.ListaComidaPedida[item.Key].Stock;//Actualizo stock de lista de mesa original
                lugarOriginal.ListaComidaPedida[item.Key].Cantidad = lugarCopia.ListaComidaPedida[item.Key].Cantidad;
                lugarOriginal.Ocupada = true;
            }
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
