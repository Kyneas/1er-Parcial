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
            this.cboAlimento.SelectedIndex = 0;
            this.rdoLata200ml.Checked = true;
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

        private void btbCambiarPrecio_Click(object sender, EventArgs e)
        {
            if (Sistema.EsPrecioValido(this.txtNuevoPrecio.Text, out float precio))
            {
                Sistema.listaAlimentos[alimentoSeleccionado].Precio = precio;
                AgregarTodosLosInsumosAListaStock();
            }
            else 
            {
                MessageBox.Show("Precio incorrecto");
            }
            this.txtNuevoPrecio.Text = String.Empty;
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (Sistema.EsStockValido(this.txtNuevoStock.Text, out int stock))
            {
                Sistema.listaAlimentos[alimentoSeleccionado].Stock = stock;
                AgregarTodosLosInsumosAListaStock();
            }
            else
            {
                MessageBox.Show("Stock incorrecto");
            }
            this.txtNuevoStock.Text = String.Empty;
        }

        private void txtNuevoStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtNuevoPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '.')

            {
                e.Handled = true;
            }
        }

        private void cboAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool seleccionoComida = cboAlimento.SelectedIndex == 0;

            this.grpPresentacionBebida.Visible = !seleccionoComida;
            this.chkEsVegano.Visible = seleccionoComida;
        }

        private void btbAgregarProducto_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombreParaNuevoAlimento.Text;
            string precioString = this.txtPrecioParaNuevoAlimento.Text;
            float precio;
            string stockString = this.txtStockParaNuevoAlimento.Text;
            int stock;
            int indice = -1;

            foreach (RadioButton item in grpPresentacionBebida.Controls.OfType<RadioButton>())
            {
                if (item.Checked) 
                {
                    indice = item.TabIndex;
                    break;
                }   
            }

            Bebida.Tamanio tamanio = (Bebida.Tamanio)indice;

            bool esVegano = this.chkEsVegano.Checked;

            bool datosCorrectos = true;

            this.lblErrorIngresoNombre.Visible = false;
            this.lblErrorIngresoPrecio.Visible = false;
            this.lblErrorIngresoStock.Visible = false;

            if (!Sistema.EsNombreOApellidoValido(nombre))
            {
                datosCorrectos = false;
                this.lblErrorIngresoNombre.Visible = true;
            }
            if (!Sistema.EsPrecioValido(precioString, out precio))
            {
                datosCorrectos = false;
                this.lblErrorIngresoPrecio.Visible = true;
            }
            if (!Sistema.EsStockValido(stockString, out stock))
            {
                datosCorrectos = false;
                this.lblErrorIngresoStock.Visible = true;
            }

            if (datosCorrectos) 
            {
                if (cboAlimento.SelectedIndex == 0)
                {
                    Comida alimento = new Comida(nombre, precio, 0, stock, esVegano);
                    if (Sistema.ElAlimentoYaEstaEnLaLista(alimento))
                    {
                        MessageBox.Show("Ya esta la comida.");
                    }
                    else 
                    {
                        Sistema.AgregarAlimento(alimento);
                        MessageBox.Show("Comida agregada.");
                        AgregarTodosLosInsumosAListaStock();
                    }
                }
                else
                {
                    Bebida alimento = new Bebida(nombre, precio, 0, stock, tamanio);
                    if (Sistema.ElAlimentoYaEstaEnLaLista(alimento))
                    {
                        MessageBox.Show("Ya esta la bebida.");
                    }
                    else
                    {
                        Sistema.AgregarAlimento(alimento);
                        MessageBox.Show("Bebida agregada.");
                        AgregarTodosLosInsumosAListaStock();
                    }
                }
            }
        }
    }
}
