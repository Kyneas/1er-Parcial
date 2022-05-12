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
    public partial class MenuPrincipal : Form
    {
        Persona usuario;
        bool admin;
        bool hayBajoStock;
        private MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Persona usuario) : this()
        {
            this.usuario = usuario;
            lblBienvenida.Text = $"Buenas {usuario.Nombre}";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblEsAdmn.Visible = usuario.EsAdmin;
            this.btnAdmin.Visible = usuario.EsAdmin;
            this.lvwUbicaciones.FullRowSelect = true;

            AgregarTodasLasPosiciones();
            hayBajoStock = AgregarAlimentosConBajoStock();
            this.lvwListadoPocoStock.Visible = hayBajoStock;
            this.picTest.Visible = !hayBajoStock;
        }

        public void AgregarTodasLasPosiciones()
        {
            lvwUbicaciones.Items.Clear();
            ListViewItem filaLista = null;
            foreach (KeyValuePair<int, Posicion> item in Sistema.listaPosiciones)
            {
                filaLista = LogicaForms.AgregarFilaAListView(lvwUbicaciones, item.Key.ToString(), item.Value.Lugar.ToString(), item.Value.Saldo.ToString());
                filaLista.BackColor = Color.PaleGreen;
                if (item.Value.Saldo > 0)
                    filaLista.BackColor = Color.SkyBlue;
            }
        }

        public bool AgregarAlimentosConBajoStock()
        {
            lvwListadoPocoStock.Items.Clear();
            bool hayBajoStock = false;
            ListViewItem filaLista = null;
            foreach (Alimento item in Sistema.listaAlimentos.Values)
            {
                if (item.Stock <= 10)
                {
                    hayBajoStock = true;
                    filaLista = LogicaForms.AgregarFilaAListView(lvwListadoPocoStock, item.NombreCompleto, item.Stock.ToString());
                    filaLista.BackColor = Color.Gold;
                    if (item.Stock < 5)
                        filaLista.BackColor = Color.Coral;
                    if (item.Stock == 0)
                        filaLista.BackColor = Color.Crimson;
                }
            }
            return hayBajoStock;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvwUbicaciones_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwUbicaciones.Columns[e.ColumnIndex].Width;
        }

        private void lvwUbicaciones_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lvwUbicaciones.SelectedItems[0].Text);
            CargaDePedido menuPedido = new CargaDePedido(id, Sistema.listaPosiciones[id]);
            menuPedido.ShowDialog();
        }

        private void MenuPrincipal_Activated(object sender, EventArgs e)
        {
            AgregarTodasLasPosiciones();
            hayBajoStock = AgregarAlimentosConBajoStock();
            this.lvwListadoPocoStock.Visible = hayBajoStock;
            this.picTest.Visible = !hayBajoStock;
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
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIrAMesa_Click(object sender, EventArgs e)
        {
            if (Sistema.ExisteMesa(this.txtBuscarMesa.Text, out int mesa))
            {
                CargaDePedido menuPedido = new CargaDePedido(mesa, Sistema.listaPosiciones[mesa]);
                menuPedido.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No existe la mesa.");
            }
            

        }

        private void lvwListadoPocoStock_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwListadoPocoStock.Columns[e.ColumnIndex].Width;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            MenuAdministracion menuAdmin = new MenuAdministracion();
            menuAdmin.ShowDialog();
        }
    }
}
