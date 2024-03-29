﻿using System;
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
        /// <summary>
        /// Lista todos los alimentos del sistema y los pinta en base al stock disponible
        /// </summary>
        public void AgregarTodosLosInsumosAListaStock()
        {
            ListViewItem filaLista = null;
            lvwListaInsumos.Items.Clear();
            foreach (KeyValuePair<int,Alimento> item in Sistema.listaAlimentos)
            {
                filaLista = LogicaForms.AgregarFilaAListView(lvwListaInsumos,item.Key.ToString(),item.Value.NombreCompleto, item.Value.Precio.ToString(), item.Value.Stock.ToString());
                filaLista.BackColor = Color.LightGreen;
                if (item.Value.Stock <= 10)
                    filaLista.BackColor = Color.Gold;
                if (item.Value.Stock < 5)
                    filaLista.BackColor = Color.Coral;
                if (item.Value.Stock == 0)
                    filaLista.BackColor = Color.Crimson;
            }
        }

        private void AdministrarInsumos_Load(object sender, EventArgs e)
        {
            LogicaForms.CambiarColores(this);
            AgregarTodosLosInsumosAListaStock();
            this.cboAlimento.SelectedIndex = 0;
            this.rdoLata200ml.Checked = true;
        }
        /// <summary>
        /// Guarda el ID del alimento seleccionado y habilita la posiblidar de modificar precio/stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Deshabilita la posibilidad de modificar stock/precio
        /// </summary>
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
        /// <summary>
        /// Quita el alimento de la lista previa confirmacion del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// En caso de ser un precio valido, lo modifica del alimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// En caso de ser un stock valido, lo modifica del alimento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Pinta en el form lo correspondiente en caso de que lo seleccionado en el comboBox sea Comida o Bebida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool seleccionoComida = cboAlimento.SelectedIndex == 0;

            this.grpPresentacionBebida.Visible = !seleccionoComida;
            this.chkEsVegano.Visible = seleccionoComida;
        }
        /// <summary>
        /// En caso de que los datos sean correctos, agregar la Comida/Bebida a la lista
        /// La comida no puede tener el mismo nombre ni ser Vegana, en caso de las bebidas no pueden repetir nombre ni la presentacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void lvwListaInsumos_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwListaInsumos.Columns[e.ColumnIndex].Width;
        }
    }
}
