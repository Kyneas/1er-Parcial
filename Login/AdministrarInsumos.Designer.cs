
namespace Bar
{
    partial class AdministrarInsumos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwListaInsumos = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btbCambiarPrecio = new System.Windows.Forms.Button();
            this.btnAgregarStock = new System.Windows.Forms.Button();
            this.txtNuevoPrecio = new System.Windows.Forms.TextBox();
            this.txtNuevoStock = new System.Windows.Forms.TextBox();
            this.txtNombreParaNuevoAlimento = new System.Windows.Forms.TextBox();
            this.txtPrecioParaNuevoAlimento = new System.Windows.Forms.TextBox();
            this.txtStockParaNuevoAlimento = new System.Windows.Forms.TextBox();
            this.cboAlimento = new System.Windows.Forms.ComboBox();
            this.lnlIngresoNombre = new System.Windows.Forms.Label();
            this.lnlIngresoPrecio = new System.Windows.Forms.Label();
            this.lnlIngresoStock = new System.Windows.Forms.Label();
            this.chkEsVegano = new System.Windows.Forms.CheckBox();
            this.grpPresentacionBebida = new System.Windows.Forms.GroupBox();
            this.rdoBotella1500ml = new System.Windows.Forms.RadioButton();
            this.rdoBotella975ml = new System.Windows.Forms.RadioButton();
            this.rdoBotella710ml = new System.Windows.Forms.RadioButton();
            this.rdoBotella375ml = new System.Windows.Forms.RadioButton();
            this.rdoLata900ml = new System.Windows.Forms.RadioButton();
            this.rdoLata473ml = new System.Windows.Forms.RadioButton();
            this.rdoLata330ml = new System.Windows.Forms.RadioButton();
            this.rdoLata200ml = new System.Windows.Forms.RadioButton();
            this.btbAgregarProducto = new System.Windows.Forms.Button();
            this.lblErrorIngresoNombre = new System.Windows.Forms.Label();
            this.lblErrorIngresoPrecio = new System.Windows.Forms.Label();
            this.lblErrorIngresoStock = new System.Windows.Forms.Label();
            this.grpPresentacionBebida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwListaInsumos
            // 
            this.lvwListaInsumos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwListaInsumos.FullRowSelect = true;
            this.lvwListaInsumos.HideSelection = false;
            this.lvwListaInsumos.Location = new System.Drawing.Point(54, 43);
            this.lvwListaInsumos.Name = "lvwListaInsumos";
            this.lvwListaInsumos.Size = new System.Drawing.Size(329, 325);
            this.lvwListaInsumos.TabIndex = 0;
            this.lvwListaInsumos.Tag = "usacolor";
            this.lvwListaInsumos.UseCompatibleStateImageBehavior = false;
            this.lvwListaInsumos.View = System.Windows.Forms.View.Details;
            this.lvwListaInsumos.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwListaInsumos_ColumnWidthChanging);
            this.lvwListaInsumos.Click += new System.EventHandler(this.lvwListaInsumos_Click);
            this.lvwListaInsumos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwListaInsumos_MouseUp);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Prducto";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Precio";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Stock";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Enabled = false;
            this.btnEliminarProducto.Location = new System.Drawing.Point(54, 396);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(81, 63);
            this.btnEliminarProducto.TabIndex = 1;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btbCambiarPrecio
            // 
            this.btbCambiarPrecio.Enabled = false;
            this.btbCambiarPrecio.Location = new System.Drawing.Point(308, 395);
            this.btbCambiarPrecio.Name = "btbCambiarPrecio";
            this.btbCambiarPrecio.Size = new System.Drawing.Size(75, 23);
            this.btbCambiarPrecio.TabIndex = 2;
            this.btbCambiarPrecio.Text = "N Precio";
            this.btbCambiarPrecio.UseVisualStyleBackColor = true;
            this.btbCambiarPrecio.Click += new System.EventHandler(this.btbCambiarPrecio_Click);
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Enabled = false;
            this.btnAgregarStock.Location = new System.Drawing.Point(308, 436);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStock.TabIndex = 3;
            this.btnAgregarStock.Text = "N Stock";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            this.btnAgregarStock.Click += new System.EventHandler(this.btnAgregarStock_Click);
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(172, 396);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtNuevoPrecio.TabIndex = 4;
            this.txtNuevoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoPrecio_KeyPress);
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.Location = new System.Drawing.Point(172, 436);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.Size = new System.Drawing.Size(100, 23);
            this.txtNuevoStock.TabIndex = 5;
            this.txtNuevoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevoStock_KeyPress);
            // 
            // txtNombreParaNuevoAlimento
            // 
            this.txtNombreParaNuevoAlimento.Location = new System.Drawing.Point(481, 99);
            this.txtNombreParaNuevoAlimento.Name = "txtNombreParaNuevoAlimento";
            this.txtNombreParaNuevoAlimento.Size = new System.Drawing.Size(188, 23);
            this.txtNombreParaNuevoAlimento.TabIndex = 6;
            // 
            // txtPrecioParaNuevoAlimento
            // 
            this.txtPrecioParaNuevoAlimento.Location = new System.Drawing.Point(481, 139);
            this.txtPrecioParaNuevoAlimento.Name = "txtPrecioParaNuevoAlimento";
            this.txtPrecioParaNuevoAlimento.Size = new System.Drawing.Size(188, 23);
            this.txtPrecioParaNuevoAlimento.TabIndex = 7;
            // 
            // txtStockParaNuevoAlimento
            // 
            this.txtStockParaNuevoAlimento.Location = new System.Drawing.Point(481, 182);
            this.txtStockParaNuevoAlimento.Name = "txtStockParaNuevoAlimento";
            this.txtStockParaNuevoAlimento.Size = new System.Drawing.Size(188, 23);
            this.txtStockParaNuevoAlimento.TabIndex = 8;
            // 
            // cboAlimento
            // 
            this.cboAlimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlimento.FormattingEnabled = true;
            this.cboAlimento.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.cboAlimento.Location = new System.Drawing.Point(516, 43);
            this.cboAlimento.Name = "cboAlimento";
            this.cboAlimento.Size = new System.Drawing.Size(121, 23);
            this.cboAlimento.TabIndex = 10;
            this.cboAlimento.SelectedIndexChanged += new System.EventHandler(this.cboAlimento_SelectedIndexChanged);
            // 
            // lnlIngresoNombre
            // 
            this.lnlIngresoNombre.AutoSize = true;
            this.lnlIngresoNombre.Location = new System.Drawing.Point(413, 107);
            this.lnlIngresoNombre.Name = "lnlIngresoNombre";
            this.lnlIngresoNombre.Size = new System.Drawing.Size(51, 15);
            this.lnlIngresoNombre.TabIndex = 11;
            this.lnlIngresoNombre.Text = "Nombre";
            // 
            // lnlIngresoPrecio
            // 
            this.lnlIngresoPrecio.AutoSize = true;
            this.lnlIngresoPrecio.Location = new System.Drawing.Point(413, 147);
            this.lnlIngresoPrecio.Name = "lnlIngresoPrecio";
            this.lnlIngresoPrecio.Size = new System.Drawing.Size(40, 15);
            this.lnlIngresoPrecio.TabIndex = 12;
            this.lnlIngresoPrecio.Text = "Precio";
            // 
            // lnlIngresoStock
            // 
            this.lnlIngresoStock.AutoSize = true;
            this.lnlIngresoStock.Location = new System.Drawing.Point(413, 190);
            this.lnlIngresoStock.Name = "lnlIngresoStock";
            this.lnlIngresoStock.Size = new System.Drawing.Size(36, 15);
            this.lnlIngresoStock.TabIndex = 13;
            this.lnlIngresoStock.Text = "Stock";
            // 
            // chkEsVegano
            // 
            this.chkEsVegano.AutoSize = true;
            this.chkEsVegano.Location = new System.Drawing.Point(693, 103);
            this.chkEsVegano.Name = "chkEsVegano";
            this.chkEsVegano.Size = new System.Drawing.Size(65, 19);
            this.chkEsVegano.TabIndex = 14;
            this.chkEsVegano.Text = "Vegano";
            this.chkEsVegano.UseVisualStyleBackColor = true;
            // 
            // grpPresentacionBebida
            // 
            this.grpPresentacionBebida.Controls.Add(this.rdoBotella1500ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoBotella975ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoBotella710ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoBotella375ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoLata900ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoLata473ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoLata330ml);
            this.grpPresentacionBebida.Controls.Add(this.rdoLata200ml);
            this.grpPresentacionBebida.Location = new System.Drawing.Point(452, 240);
            this.grpPresentacionBebida.Name = "grpPresentacionBebida";
            this.grpPresentacionBebida.Size = new System.Drawing.Size(295, 138);
            this.grpPresentacionBebida.TabIndex = 15;
            this.grpPresentacionBebida.TabStop = false;
            this.grpPresentacionBebida.Text = "Presentacion";
            // 
            // rdoBotella1500ml
            // 
            this.rdoBotella1500ml.AutoSize = true;
            this.rdoBotella1500ml.Location = new System.Drawing.Point(176, 98);
            this.rdoBotella1500ml.Name = "rdoBotella1500ml";
            this.rdoBotella1500ml.Size = new System.Drawing.Size(86, 19);
            this.rdoBotella1500ml.TabIndex = 7;
            this.rdoBotella1500ml.TabStop = true;
            this.rdoBotella1500ml.Text = "Botella 1,5lt";
            this.rdoBotella1500ml.UseVisualStyleBackColor = true;
            // 
            // rdoBotella975ml
            // 
            this.rdoBotella975ml.AutoSize = true;
            this.rdoBotella975ml.Location = new System.Drawing.Point(176, 73);
            this.rdoBotella975ml.Name = "rdoBotella975ml";
            this.rdoBotella975ml.Size = new System.Drawing.Size(96, 19);
            this.rdoBotella975ml.TabIndex = 6;
            this.rdoBotella975ml.TabStop = true;
            this.rdoBotella975ml.Text = "Botella 975ml";
            this.rdoBotella975ml.UseVisualStyleBackColor = true;
            // 
            // rdoBotella710ml
            // 
            this.rdoBotella710ml.AutoSize = true;
            this.rdoBotella710ml.Location = new System.Drawing.Point(176, 48);
            this.rdoBotella710ml.Name = "rdoBotella710ml";
            this.rdoBotella710ml.Size = new System.Drawing.Size(96, 19);
            this.rdoBotella710ml.TabIndex = 5;
            this.rdoBotella710ml.TabStop = true;
            this.rdoBotella710ml.Text = "Botella 710ml";
            this.rdoBotella710ml.UseVisualStyleBackColor = true;
            // 
            // rdoBotella375ml
            // 
            this.rdoBotella375ml.AutoSize = true;
            this.rdoBotella375ml.Location = new System.Drawing.Point(176, 22);
            this.rdoBotella375ml.Name = "rdoBotella375ml";
            this.rdoBotella375ml.Size = new System.Drawing.Size(96, 19);
            this.rdoBotella375ml.TabIndex = 4;
            this.rdoBotella375ml.TabStop = true;
            this.rdoBotella375ml.Text = "Botella 375ml";
            this.rdoBotella375ml.UseVisualStyleBackColor = true;
            // 
            // rdoLata900ml
            // 
            this.rdoLata900ml.AutoSize = true;
            this.rdoLata900ml.Location = new System.Drawing.Point(6, 99);
            this.rdoLata900ml.Name = "rdoLata900ml";
            this.rdoLata900ml.Size = new System.Drawing.Size(82, 19);
            this.rdoLata900ml.TabIndex = 3;
            this.rdoLata900ml.TabStop = true;
            this.rdoLata900ml.Text = "Lata 900ml";
            this.rdoLata900ml.UseVisualStyleBackColor = true;
            // 
            // rdoLata473ml
            // 
            this.rdoLata473ml.AutoSize = true;
            this.rdoLata473ml.Location = new System.Drawing.Point(7, 74);
            this.rdoLata473ml.Name = "rdoLata473ml";
            this.rdoLata473ml.Size = new System.Drawing.Size(82, 19);
            this.rdoLata473ml.TabIndex = 2;
            this.rdoLata473ml.TabStop = true;
            this.rdoLata473ml.Text = "Lata 473ml";
            this.rdoLata473ml.UseVisualStyleBackColor = true;
            // 
            // rdoLata330ml
            // 
            this.rdoLata330ml.AutoSize = true;
            this.rdoLata330ml.Location = new System.Drawing.Point(6, 48);
            this.rdoLata330ml.Name = "rdoLata330ml";
            this.rdoLata330ml.Size = new System.Drawing.Size(82, 19);
            this.rdoLata330ml.TabIndex = 1;
            this.rdoLata330ml.TabStop = true;
            this.rdoLata330ml.Text = "Lata 330ml";
            this.rdoLata330ml.UseVisualStyleBackColor = true;
            // 
            // rdoLata200ml
            // 
            this.rdoLata200ml.AutoSize = true;
            this.rdoLata200ml.Location = new System.Drawing.Point(7, 23);
            this.rdoLata200ml.Name = "rdoLata200ml";
            this.rdoLata200ml.Size = new System.Drawing.Size(82, 19);
            this.rdoLata200ml.TabIndex = 0;
            this.rdoLata200ml.TabStop = true;
            this.rdoLata200ml.Tag = "";
            this.rdoLata200ml.Text = "Lata 200ml";
            this.rdoLata200ml.UseVisualStyleBackColor = true;
            // 
            // btbAgregarProducto
            // 
            this.btbAgregarProducto.Location = new System.Drawing.Point(541, 395);
            this.btbAgregarProducto.Name = "btbAgregarProducto";
            this.btbAgregarProducto.Size = new System.Drawing.Size(128, 64);
            this.btbAgregarProducto.TabIndex = 16;
            this.btbAgregarProducto.Text = "Agregar Producto";
            this.btbAgregarProducto.UseVisualStyleBackColor = true;
            this.btbAgregarProducto.Click += new System.EventHandler(this.btbAgregarProducto_Click);
            // 
            // lblErrorIngresoNombre
            // 
            this.lblErrorIngresoNombre.AutoSize = true;
            this.lblErrorIngresoNombre.Location = new System.Drawing.Point(675, 99);
            this.lblErrorIngresoNombre.Name = "lblErrorIngresoNombre";
            this.lblErrorIngresoNombre.Size = new System.Drawing.Size(12, 15);
            this.lblErrorIngresoNombre.TabIndex = 17;
            this.lblErrorIngresoNombre.Tag = "Error";
            this.lblErrorIngresoNombre.Text = "*";
            this.lblErrorIngresoNombre.Visible = false;
            // 
            // lblErrorIngresoPrecio
            // 
            this.lblErrorIngresoPrecio.AutoSize = true;
            this.lblErrorIngresoPrecio.Location = new System.Drawing.Point(675, 147);
            this.lblErrorIngresoPrecio.Name = "lblErrorIngresoPrecio";
            this.lblErrorIngresoPrecio.Size = new System.Drawing.Size(12, 15);
            this.lblErrorIngresoPrecio.TabIndex = 18;
            this.lblErrorIngresoPrecio.Tag = "Error";
            this.lblErrorIngresoPrecio.Text = "*";
            this.lblErrorIngresoPrecio.Visible = false;
            // 
            // lblErrorIngresoStock
            // 
            this.lblErrorIngresoStock.AutoSize = true;
            this.lblErrorIngresoStock.Location = new System.Drawing.Point(675, 185);
            this.lblErrorIngresoStock.Name = "lblErrorIngresoStock";
            this.lblErrorIngresoStock.Size = new System.Drawing.Size(12, 15);
            this.lblErrorIngresoStock.TabIndex = 19;
            this.lblErrorIngresoStock.Tag = "Error";
            this.lblErrorIngresoStock.Text = "*";
            this.lblErrorIngresoStock.Visible = false;
            // 
            // AdministrarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 540);
            this.Controls.Add(this.lblErrorIngresoStock);
            this.Controls.Add(this.lblErrorIngresoPrecio);
            this.Controls.Add(this.lblErrorIngresoNombre);
            this.Controls.Add(this.btbAgregarProducto);
            this.Controls.Add(this.chkEsVegano);
            this.Controls.Add(this.lnlIngresoStock);
            this.Controls.Add(this.lnlIngresoPrecio);
            this.Controls.Add(this.lnlIngresoNombre);
            this.Controls.Add(this.cboAlimento);
            this.Controls.Add(this.txtStockParaNuevoAlimento);
            this.Controls.Add(this.txtPrecioParaNuevoAlimento);
            this.Controls.Add(this.txtNombreParaNuevoAlimento);
            this.Controls.Add(this.txtNuevoStock);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btbCambiarPrecio);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lvwListaInsumos);
            this.Controls.Add(this.grpPresentacionBebida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarInsumos";
            this.Text = "AdministrarInsumos";
            this.Load += new System.EventHandler(this.AdministrarInsumos_Load);
            this.grpPresentacionBebida.ResumeLayout(false);
            this.grpPresentacionBebida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaInsumos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btbCambiarPrecio;
        private System.Windows.Forms.Button btnAgregarStock;
        private System.Windows.Forms.TextBox txtNuevoPrecio;
        private System.Windows.Forms.TextBox txtNuevoStock;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtNombreParaNuevoAlimento;
        private System.Windows.Forms.TextBox txtPrecioParaNuevoAlimento;
        private System.Windows.Forms.TextBox txtStockParaNuevoAlimento;
        private System.Windows.Forms.ComboBox cboAlimento;
        private System.Windows.Forms.Label lnlIngresoNombre;
        private System.Windows.Forms.Label lnlIngresoPrecio;
        private System.Windows.Forms.Label lnlIngresoStock;
        private System.Windows.Forms.CheckBox chkEsVegano;
        private System.Windows.Forms.GroupBox grpPresentacionBebida;
        private System.Windows.Forms.RadioButton rdoLata900ml;
        private System.Windows.Forms.RadioButton rdoLata473ml;
        private System.Windows.Forms.RadioButton rdoLata330ml;
        private System.Windows.Forms.RadioButton rdoLata200ml;
        private System.Windows.Forms.RadioButton rdoBotella1500ml;
        private System.Windows.Forms.RadioButton rdoBotella975ml;
        private System.Windows.Forms.RadioButton rdoBotella710ml;
        private System.Windows.Forms.RadioButton rdoBotella375ml;
        private System.Windows.Forms.Button btbAgregarProducto;
        private System.Windows.Forms.Label lblErrorIngresoNombre;
        private System.Windows.Forms.Label lblErrorIngresoPrecio;
        private System.Windows.Forms.Label lblErrorIngresoStock;
    }
}