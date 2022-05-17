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
using System.Media;


namespace Bar
{
    public partial class MenuPrincipal : Form
    {
        Persona usuario;
        int mesaSeleccionada;
        SoundPlayer sonidoAbrirMesa;
        SoundPlayer sonidoSalir;
        private MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Persona usuario) : this()
        {
            this.usuario = usuario;
            this.sonidoAbrirMesa = new SoundPlayer(Properties.Resources.modAbrirMesa);
            this.sonidoSalir = new SoundPlayer(Properties.Resources.exit);
        }
        /// <summary>
        /// Agrega mesas, modifica los colores y hace visible el panel en caso de ser admin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            AgregarTodasLasPosiciones();
            LogicaForms.CambiarColores(this);
            this.pnlAdminArriba.Visible = usuario.EsAdmin;

        }
        /// <summary>
        /// Borra la ListView, y luego agrega todas las mesas
        /// </summary>
        public void AgregarTodasLasPosiciones()
        {
            lvwUbicaciones.Items.Clear();
            ListViewItem filaLista = null;
            foreach (KeyValuePair<int, Posicion> item in Sistema.listaPosiciones)
            {
                filaLista = LogicaForms.AgregarFilaAListView(lvwUbicaciones, item.Key.ToString(), item.Value.Lugar.ToString(), item.Value.Saldo.ToString());
                filaLista.BackColor = Color.FromArgb(40, 40, 40);
                if (item.Value.Saldo > 0)
                    filaLista.BackColor = Color.FromArgb(238, 154, 73);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                sonidoSalir.Play();
                Task.Delay(150).Wait();
                Application.Exit();
            }
        }

        private void lvwUbicaciones_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwUbicaciones.Columns[e.ColumnIndex].Width;
        }
        /// <summary>
        /// Al clickear una mesa en la lista, cierra lo que hay dentro del panel y abre el form de carga de pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwUbicaciones_Click(object sender, EventArgs e)
        {
            mesaSeleccionada = lvwUbicaciones.SelectedIndices[0];
            int id = int.Parse(lvwUbicaciones.SelectedItems[0].Text);
            AgregarTodasLasPosiciones();
            LogicaForms.CerrarFormulariosDelPanel(this.pnlPrincipal);
            
            CargaDePedido menuPedido = new CargaDePedido(id, Sistema.listaPosiciones[id], usuario.EsAdmin, lvwUbicaciones);
            menuPedido.TopLevel = false;
            pnlPrincipal.Controls.Add(menuPedido);
            sonidoAbrirMesa.Play();
            menuPedido.Show();
        }
        /// <summary>
        /// Actualiza la lista cuando el form principal vuelve a estar activo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            AgregarTodasLasPosiciones();
            this.txtBuscarMesa.Text = String.Empty;
        }

        private void btbDesloguear_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que desea cerrar sesion?", "Cierre sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void txtBuscarMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Abre el form de carga de pedido de la mesa ingresa en caso de existir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIrAMesa_Click(object sender, EventArgs e)
        {
            IrAMesa();
        }
        /// <summary>
        /// Valida que la mesa ingresa exista y abre el form correspondiente para la carga del pedido, caso contrario avisa al usuario que el numero es incorrecto
        /// </summary>
        private void IrAMesa() 
        {
            if (Sistema.ExisteMesa(this.txtBuscarMesa.Text, out int mesa))
            {
                LogicaForms.CerrarFormulariosDelPanel(this.pnlPrincipal);

                CargaDePedido menuPedido = new CargaDePedido(mesa, Sistema.listaPosiciones[mesa], usuario.EsAdmin, lvwUbicaciones);
                menuPedido.TopLevel = false;
                pnlPrincipal.Controls.Add(menuPedido);
                sonidoAbrirMesa.Play();
                menuPedido.Show();
            }
            else
            {
                MessageBox.Show("No existe la mesa.");
            }
        }
        /// <summary>
        /// Abre el form de Administrador, 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AgregarTodasLasPosiciones();

            LogicaForms.CerrarFormulariosDelPanel(this.pnlPrincipal);
            //lvwUbicaciones.Items[mesaSeleccionada].Selected = false;
            MenuAdministracion menuAdmin = new MenuAdministracion();
            menuAdmin.TopLevel = false;
            pnlPrincipal.Controls.Add(menuAdmin);
            menuAdmin.Show();
        }
    }
}
