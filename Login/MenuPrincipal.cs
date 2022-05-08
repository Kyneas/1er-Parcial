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
        private MenuPrincipal()
        {
            InitializeComponent();
        }

        public MenuPrincipal(Persona usuario) : this()
        {
            this.usuario = usuario;
            lblBienvenida.Text = $"que hace {usuario.Nombre}";
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.lblEsAdmn.Visible = usuario.EsAdmin;

            this.lvwUbicaciones.FullRowSelect = true;

            AgregarTodasLasPosiciones();
        }

        private void AgregarUbicacion(string id, string ubicacion, string saldo, bool ocupada)
        {
            String[] fila = { id, ubicacion, saldo };
            ListViewItem item = new ListViewItem(fila);
            item.BackColor = Color.Lime;
            if (ocupada)
                item.BackColor = Color.Crimson;


            this.lvwUbicaciones.Items.Add(item);
        }

        public void AgregarTodasLasPosiciones()
        {
            foreach (KeyValuePair<int, Posicion> item in Sistema.listaPosiciones)
            {
                item.Value.Ocupada = false;
                if (item.Value.Saldo > 0)
                {
                    item.Value.Ocupada = true;
                }
                AgregarUbicacion(item.Key.ToString(), item.Value.Lugar.ToString(), item.Value.Saldo.ToString(), item.Value.Ocupada);
            }
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
            lvwUbicaciones.Items.Clear();
            AgregarTodasLasPosiciones();
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
    }
}
