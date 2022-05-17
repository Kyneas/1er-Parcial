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
        int idAlimento;
        bool esAdmin;
        Posicion lugarCopia;
        Posicion lugarOriginal;
        Dictionary<int, Alimento> copiaDeListaDeComidasDelSistema;
        ListView listaDeMenuPrincipal;

        public CargaDePedido()
        {
            InitializeComponent();
        }

        public CargaDePedido(int mesa, Posicion lugarOriginal, bool esAdmin, ListView listaDeMenuPrincipal) : this()
        {
            this.mesa = mesa;
            this.lugarOriginal = lugarOriginal;
            this.esAdmin = esAdmin;

            this.copiaDeListaDeComidasDelSistema = new Dictionary<int, Alimento>();

            this.lugarCopia = new Posicion(lugarOriginal.Lugar);


            //foreach (KeyValuePair<int, Alimento> item in Sistema.listaAlimentos)//HAGO COPIA DE LISTA COMIDAS DE SISTEMA
            //{
            //    if (item.Value is Comida)
            //    {
            //        this.copiaDeListaDeComidasDelSistema.Add(item.Key, new Comida(Sistema.listaAlimentos[item.Key].Nombre,
            //        Sistema.listaAlimentos[item.Key].Precio, Sistema.listaAlimentos[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
            //        ((Comida)Sistema.listaAlimentos[item.Key]).Vegano));
            //    }
            //    else
            //    {
            //        this.copiaDeListaDeComidasDelSistema.Add(item.Key, new Bebida(Sistema.listaAlimentos[item.Key].Nombre,
            //        Sistema.listaAlimentos[item.Key].Precio, Sistema.listaAlimentos[item.Key].Cantidad, Sistema.listaAlimentos[item.Key].Stock,
            //        ((Bebida)Sistema.listaAlimentos[item.Key]).Presentacion));
            //    }
            //}

            //foreach (KeyValuePair<int, Alimento> item in lugarOriginal.ListaComidaPedida)
            //{
            //    if (item.Value is Comida)
            //    {
            //        this.lugarCopia.ListaComidaPedida.Add(item.Key, new Comida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
            //        lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, lugarOriginal.ListaComidaPedida[item.Key].Stock,
            //        ((Comida)lugarOriginal.ListaComidaPedida[item.Key]).Vegano));
            //    }
            //    else
            //    {
            //        this.lugarCopia.ListaComidaPedida.Add(item.Key, new Bebida(lugarOriginal.ListaComidaPedida[item.Key].Nombre,
            //        lugarOriginal.ListaComidaPedida[item.Key].Precio, lugarOriginal.ListaComidaPedida[item.Key].Cantidad, lugarOriginal.ListaComidaPedida[item.Key].Stock,
            //        ((Bebida)lugarOriginal.ListaComidaPedida[item.Key]).Presentacion));
            //    }
            //}

            Sistema.ClonarLista(Sistema.listaAlimentos, this.copiaDeListaDeComidasDelSistema);
            Sistema.ClonarLista(lugarOriginal.ListaComidaPedida, this.lugarCopia.ListaComidaPedida);

            this.listaDeMenuPrincipal = listaDeMenuPrincipal;
        }

        private void CargaDePedido_Load(object sender, EventArgs e)
        {
            LogicaForms.CambiarColores(this);
            this.lblNumeroMesa.Font = new Font("Calibri", 40, FontStyle.Bold);
            this.lblSaldo.Font = new Font("Calibri", 30, FontStyle.Bold);
            btnMenos.Visible = esAdmin;
            lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
            lblNumeroMesa.Text = $"Mesa {mesa}";
            ValidarSiHabiaSaldoParaHabilitarBotones();
            AgregarTodasLosAlimentosDisponiblesALista();

            lvwComidaEnMesa.Items.Clear();
            foreach (KeyValuePair<int, Alimento> item in lugarCopia.ListaComidaPedida)
            {
                if (item.Value.Cantidad > 0)
                    LogicaForms.AgregarFilaAListView(lvwComidaEnMesa, item.Key.ToString(), item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
            }
        }

        public void AgregarTodasLosAlimentosDisponiblesALista()
        {
            ListViewItem filaLista = null;
            lvwListaAlimentos.Items.Clear();
            foreach (KeyValuePair<int, Alimento> item in this.copiaDeListaDeComidasDelSistema)
            {
                filaLista = LogicaForms.AgregarFilaAListView(lvwListaAlimentos, item.Key.ToString(), item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Stock.ToString());
                filaLista.BackColor = Color.LightGreen;
                if (item.Value.Stock <= 10)
                    filaLista.BackColor = Color.Gold;
                if (item.Value.Stock < 5)
                    filaLista.BackColor = Color.Coral;
                if (item.Value.Stock == 0)
                    filaLista.BackColor = Color.Crimson;
            }
        }

        public void AgregarAListaLaComidaQueSePidio()
        {
            lvwComidaEnMesa.Items.Clear();
            foreach (KeyValuePair<int, Alimento> item in lugarCopia.ListaComidaPedida)
            {
                LogicaForms.AgregarFilaAListView(lvwComidaEnMesa, item.Key.ToString(), item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (lvwListaAlimentos.SelectedItems.Count > 0)
            {
                btnMenos.Enabled = true;
                AgregarOSumarComida(idAlimento);
                AgregarAListaLaComidaQueSePidio();

                int itemSeleccionado = lvwListaAlimentos.SelectedIndices[0];
                AgregarTodasLosAlimentosDisponiblesALista();
                lvwListaAlimentos.Items[itemSeleccionado].Selected = true;

                if (copiaDeListaDeComidasDelSistema[idAlimento].Stock == 0)
                {
                    btnMas.Enabled = false;
                }
                ValidarSiActualmenteHaySaldoParaHabilitarBotones();
                lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
            }

        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (lvwListaAlimentos.SelectedItems.Count > 0)
            {
                btnMas.Enabled = true;
                RestarOQuitarComida(idAlimento);
                AgregarAListaLaComidaQueSePidio();

                int itemSeleccionado = lvwListaAlimentos.SelectedIndices[0];
                AgregarTodasLosAlimentosDisponiblesALista();
                lvwListaAlimentos.Items[itemSeleccionado].Selected = true;

                if (!this.lugarCopia.ListaComidaPedida.ContainsKey(idAlimento))
                {
                    btnMenos.Enabled = false;
                }
                ValidarSiActualmenteHaySaldoParaHabilitarBotones();
                lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
            }
        }
        private void AgregarOSumarComida(int id)
        {
            if (this.lugarCopia.ListaComidaPedida.ContainsKey(id))
            {
                this.lugarCopia.ListaComidaPedida[id].Cantidad++;
                this.copiaDeListaDeComidasDelSistema[id].Stock--;
            }
            else
            {
                if (Sistema.listaAlimentos[id] is Comida)
                {
                    this.lugarCopia.ListaComidaPedida.Add(id, new Comida(Sistema.listaAlimentos[id].Nombre,
                    Sistema.listaAlimentos[id].Precio, 1, Sistema.listaAlimentos[id].Stock,
                    ((Comida)Sistema.listaAlimentos[id]).Vegano));
                }
                else
                {
                    this.lugarCopia.ListaComidaPedida.Add(id, new Bebida(Sistema.listaAlimentos[id].Nombre,
                    Sistema.listaAlimentos[id].Precio, 1, Sistema.listaAlimentos[id].Stock,
                    ((Bebida)Sistema.listaAlimentos[id]).Presentacion));
                }
                this.copiaDeListaDeComidasDelSistema[id].Stock--;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)//Boton CERRAR MESA
        {
            ActualizarStocksPorPedidoHecho();
            ConfirmarVenta venta = new ConfirmarVenta(this.mesa, this.lugarOriginal);
            if (venta.ShowDialog() == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void lvwListaAlimentos_Click(object sender, EventArgs e)
        {

            if (lvwListaAlimentos.SelectedItems.Count != 0)
            {
                idAlimento = int.Parse(lvwListaAlimentos.SelectedItems[0].Text);

                if (this.copiaDeListaDeComidasDelSistema[idAlimento].Stock == 0)
                {
                    btnMas.Enabled = false;
                }
                else
                {
                    btnMas.Enabled = true;
                }

                if (this.lugarCopia.ListaComidaPedida.ContainsKey(idAlimento))
                {
                    btnMenos.Enabled = true;
                }
                else
                {
                    btnMenos.Enabled = false;
                }
            }
        }

        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            ActualizarStocksPorPedidoHecho();
            this.Dispose();
        }

        private void ValidarSiHabiaSaldoParaHabilitarBotones()
        {
            if (lugarOriginal.Saldo == 0)
            {
                btnCerrarMesa.Enabled = false;
            }
            else
            {
                btnCerrarMesa.Enabled = true;
            }
        }

        private void ValidarSiActualmenteHaySaldoParaHabilitarBotones()
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
            List<int> listaDeComidasABorrar = new List<int>();
            foreach (KeyValuePair<int, Alimento> item in lugarCopia.ListaComidaPedida)
            {
                Sistema.listaAlimentos[item.Key].Stock = copiaDeListaDeComidasDelSistema[item.Key].Stock;

                if (this.lugarOriginal.ListaComidaPedida.ContainsKey(item.Key))
                {
                    lugarOriginal.ListaComidaPedida[item.Key].Cantidad = item.Value.Cantidad;
                }
                else
                {
                    if (item.Value is Comida)
                    {
                        this.lugarOriginal.ListaComidaPedida.Add(item.Key, new Comida(Sistema.listaAlimentos[item.Key].Nombre,
                        Sistema.listaAlimentos[item.Key].Precio, item.Value.Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                        ((Comida)Sistema.listaAlimentos[item.Key]).Vegano));
                    }
                    else
                    {
                        this.lugarOriginal.ListaComidaPedida.Add(item.Key, new Bebida(Sistema.listaAlimentos[item.Key].Nombre,
                        Sistema.listaAlimentos[item.Key].Precio, item.Value.Cantidad, Sistema.listaAlimentos[item.Key].Stock,
                        ((Bebida)Sistema.listaAlimentos[item.Key]).Presentacion));
                    }
                }

                ActualizarListViewDeMenuPrincipal(listaDeMenuPrincipal);
            }

            foreach (KeyValuePair<int, Alimento> item in this.lugarOriginal.ListaComidaPedida)
            {
                if (!lugarCopia.ListaComidaPedida.ContainsKey(item.Key))
                {
                    listaDeComidasABorrar.Add(item.Key);
                    Sistema.listaAlimentos[item.Key].Stock = copiaDeListaDeComidasDelSistema[item.Key].Stock;
                }
            }

            foreach (int item in listaDeComidasABorrar)
            {
                this.lugarOriginal.ListaComidaPedida.Remove(item);
            }
        }

        private void btbCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lvwListaAlimentos_MouseUp(object sender, MouseEventArgs e)
        {
            if (lvwListaAlimentos.SelectedItems.Count == 0)
            {
                btnMas.Enabled = false;
                btnMenos.Enabled = false;
            }
        }

        private void RestarOQuitarComida(int id)
        {
            if (this.lugarCopia.ListaComidaPedida[id].Cantidad == 1)
            {
                this.lugarCopia.ListaComidaPedida.Remove(id);

            }
            else if (this.lugarCopia.ListaComidaPedida[id].Cantidad > 1)
            {
                this.lugarCopia.ListaComidaPedida[id].Cantidad--;
            }
            this.copiaDeListaDeComidasDelSistema[id].Stock++;
        }

        private void ActualizarListViewDeMenuPrincipal(ListView listaMenuPrincipal) 
        {
            listaMenuPrincipal.Items.Clear();
            ListViewItem filaLista = null;
            foreach (KeyValuePair<int, Posicion> item in Sistema.listaPosiciones)
            {
                filaLista = LogicaForms.AgregarFilaAListView(listaMenuPrincipal, item.Key.ToString(), item.Value.Lugar.ToString(), item.Value.Saldo.ToString());
                filaLista.BackColor = Color.FromArgb(40, 40, 40);
                if (item.Value.Saldo > 0)
                    filaLista.BackColor = Color.FromArgb(238, 154, 73);
            }
        }

        private void lvwListaAlimentos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwListaAlimentos.Columns[e.ColumnIndex].Width;
        }

        private void lvwComidaEnMesa_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwComidaEnMesa.Columns[e.ColumnIndex].Width;
        }
    }
}
