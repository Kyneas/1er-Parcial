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
        /// <summary>
        /// Genera una copia de Alimentos de la lista de Alimentos, y una copia de la posicion
        /// </summary>
        /// <param name="mesa">Numero de mesa</param>
        /// <param name="lugarOriginal">Direccion de la mesa original</param>
        /// <param name="esAdmin">Permisos de administrador</param>
        /// <param name="listaDeMenuPrincipal">listView del menu principal</param>
        public CargaDePedido(int mesa, Posicion lugarOriginal, bool esAdmin, ListView listaDeMenuPrincipal) : this()
        {
            this.mesa = mesa;
            this.lugarOriginal = lugarOriginal;
            this.esAdmin = esAdmin;

            this.copiaDeListaDeComidasDelSistema = new Dictionary<int, Alimento>();

            this.lugarCopia = new Posicion(lugarOriginal.Lugar);

            Sistema.ClonarLista(Sistema.listaAlimentos, this.copiaDeListaDeComidasDelSistema);
            Sistema.ClonarLista(lugarOriginal.ListaComidaPedida, this.lugarCopia.ListaComidaPedida);

            this.listaDeMenuPrincipal = listaDeMenuPrincipal;
        }
        /// <summary>
        /// Modifica los colores, solo permite que se quiten pedidos en caso de ser admin, muestra saldos y agrega elementos a las listView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CargaDePedido_Load(object sender, EventArgs e)
        {
            LogicaForms.CambiarColores(this);
            this.lblNumeroMesa.Font = new Font("Calibri", 40, FontStyle.Bold);
            this.lblSaldo.Font = new Font("Calibri", 30, FontStyle.Bold);
            btnMenos.Visible = esAdmin;
            lblSaldo.Text = $"Saldo: ${lugarCopia.Saldo}";
            lblNumeroMesa.Text = $"Mesa {mesa}";
            ValidarSiActualmenteHaySaldoParaHabilitarBotones();
            AgregarTodasLosAlimentosDisponiblesALista();
            AgregarAListaLaComidaQueSePidio();
        }
        /// <summary>
        /// Agrega todos los alimentos disponibles a la listView (segun la ubicacion), indicando por medio del color una alerta en base al stock
        /// </summary>
        public void AgregarTodasLosAlimentosDisponiblesALista()
        {
            ListViewItem filaLista = null;
            lvwListaAlimentos.Items.Clear();
            foreach (KeyValuePair<int, Alimento> item in this.copiaDeListaDeComidasDelSistema)
            {
                if (this.lugarOriginal.Lugar == Posicion.Donde.Mesa || this.lugarOriginal.Lugar == Posicion.Donde.Barra && item.Value is Bebida)
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
        }
        /// <summary>
        /// Agrega todos los alimentos que la mesa pidio a la listView
        /// </summary>
        public void AgregarAListaLaComidaQueSePidio()
        {
            lvwComidaEnMesa.Items.Clear();
            foreach (KeyValuePair<int, Alimento> item in lugarCopia.ListaComidaPedida)
            {
                LogicaForms.AgregarFilaAListView(lvwComidaEnMesa, item.Key.ToString(), item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
            }
        }
        /// <summary>
        /// Al presionar el boton + el alimento se agrega a la comida pedida, modificando stocks. En caso de que el stock sea 0, el boton se deshabilita
        /// Tambien verifica si se cargo algo para permitir cerrar la mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Al presionar el boton - quita alimentos de la comida pedida y vuelve a sumar stock. En caso de que la cantidad de ese alimento seleccionado
        /// sea 0 deshabilita el boton. Tambien valida que haya algun alimento en mesa para permitir o no cerrarla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Resta stock de la comida ingresada. En caso de que la mesa ya tenga algun alimento de ese tipo, le suma 1, en caso contrario 
        /// instancia un nuevo alimento de ese tipo y setea la cantidad en 1.
        /// </summary>
        /// <param name="id"></param>
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
        /// <summary>
        /// Actuliza stocks, confirma cambios y abre el formulario correspondiente al cierre total de la mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)//Boton CERRAR MESA
        {
            ActualizarStocksPorPedidoHecho();
            ConfirmarVenta venta = new ConfirmarVenta(this.mesa, this.lugarOriginal);
            if (venta.ShowDialog() == DialogResult.OK)
            {
                this.Dispose();
            }
        }
        /// <summary>
        /// Al clickear un alimento de los disponibles guarda el id. Tambien verifica stocks de esa comida, en caso de ser 0
        /// deshabilita la posibilidad de agregar mas. Y verifica si la mesa ya tiene algun alimento cargado de ese tipo, de no tenerlo
        /// impide que se puedan restar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Actualiza los stock y cierra el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbConfirmarPedido_Click(object sender, EventArgs e)
        {
            ActualizarStocksPorPedidoHecho();
            this.Dispose();
        }
        /// <summary>
        /// Verifica si tiene alimentos cargados para permitir o no cerrar la mesa.
        /// </summary>

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
        /// <summary>
        /// Actualiza los stocks del sistema en base a lo que la mesa pidio. Modifica la lista original de Alimentos del sistema y
        /// tambien la lista de comida pedida de la posicion
        /// </summary>
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
        /// <summary>
        /// Agrega stock al sistema luego de restar un Alimento. Si es el ultimo Alimento de ese tipo que tiene la mesa,
        /// lo quita de la lista, sino resta en 1 la cantidad.
        /// </summary>
        /// <param name="id"></param>
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
