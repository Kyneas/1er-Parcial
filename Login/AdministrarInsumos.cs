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
    public partial class AdministrarInsumos : Form
    {
        int alimentoSeleccionado;
        public AdministrarInsumos()
        {
            InitializeComponent();
        }

        public void AgregarTodosLosInsumosAListaStock()
        {
            lvwListaInsumos.Items.Clear();
            foreach (KeyValuePair<int,Alimento> item in Sistema.listaAlimentos)
            {
                LogicaForms.AgregarFilaAListView(lvwListaInsumos,item.Key.ToString(),item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Stock.ToString());
            }
        }

        private void AdministrarInsumos_Load(object sender, EventArgs e)
        {
            AgregarTodosLosInsumosAListaStock();
        }

        private void lvwListaInsumos_Click(object sender, EventArgs e)
        {
            if (lvwListaInsumos.SelectedItems.Count != 0)
            {
                this.btnEliminarProducto.Enabled = true;
                this.btbCambiarPrecio.Enabled = true;
                this.btnAgregarStock.Enabled = true;
                this.txtNuevoPrecio.ReadOnly = false;
                this.txtNuevoStock.ReadOnly = false;
                alimentoSeleccionado = int.Parse(lvwListaInsumos.SelectedItems[0].Text);
            }
        }

        private void lvwListaInsumos_MouseUp(object sender, MouseEventArgs e)
        {
            if (lvwListaInsumos.SelectedItems.Count == 0)
            {
                DesactivarBotonesYTextBoxDeLaParteDeEliminar();
            }
        }

        private void DesactivarBotonesYTextBoxDeLaParteDeEliminar() 
        {
            this.btnEliminarProducto.Enabled = false;
            this.btbCambiarPrecio.Enabled = false;
            this.btnAgregarStock.Enabled = false;
            this.txtNuevoPrecio.Text = String.Empty;
            this.txtNuevoStock.Text = String.Empty;
            this.txtNuevoPrecio.ReadOnly = true;
            this.txtNuevoStock.ReadOnly = true;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirma que desea eliminar el alimento {Sistema.listaAlimentos[alimentoSeleccionado].NombreCompleto}?",
                "Confirmar borrar el usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Sistema.listaAlimentos.Remove(alimentoSeleccionado);
                AgregarTodosLosInsumosAListaStock();
                DesactivarBotonesYTextBoxDeLaParteDeEliminar();
            }
        }
    }
}
