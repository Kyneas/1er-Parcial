
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
            this.lvwListaInsumos.UseCompatibleStateImageBehavior = false;
            this.lvwListaInsumos.View = System.Windows.Forms.View.Details;
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
            this.btnEliminarProducto.Location = new System.Drawing.Point(54, 375);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 1;
            this.btnEliminarProducto.Text = "Elimnar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btbCambiarPrecio
            // 
            this.btbCambiarPrecio.Location = new System.Drawing.Point(172, 375);
            this.btbCambiarPrecio.Name = "btbCambiarPrecio";
            this.btbCambiarPrecio.Size = new System.Drawing.Size(75, 23);
            this.btbCambiarPrecio.TabIndex = 2;
            this.btbCambiarPrecio.Text = "N Precio";
            this.btbCambiarPrecio.UseVisualStyleBackColor = true;
            // 
            // btnAgregarStock
            // 
            this.btnAgregarStock.Location = new System.Drawing.Point(172, 415);
            this.btnAgregarStock.Name = "btnAgregarStock";
            this.btnAgregarStock.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarStock.TabIndex = 3;
            this.btnAgregarStock.Text = "N Stock";
            this.btnAgregarStock.UseVisualStyleBackColor = true;
            // 
            // txtNuevoPrecio
            // 
            this.txtNuevoPrecio.Location = new System.Drawing.Point(283, 374);
            this.txtNuevoPrecio.Name = "txtNuevoPrecio";
            this.txtNuevoPrecio.Size = new System.Drawing.Size(100, 23);
            this.txtNuevoPrecio.TabIndex = 4;
            // 
            // txtNuevoStock
            // 
            this.txtNuevoStock.Location = new System.Drawing.Point(283, 415);
            this.txtNuevoStock.Name = "txtNuevoStock";
            this.txtNuevoStock.Size = new System.Drawing.Size(100, 23);
            this.txtNuevoStock.TabIndex = 5;
            // 
            // AdministrarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevoStock);
            this.Controls.Add(this.txtNuevoPrecio);
            this.Controls.Add(this.btnAgregarStock);
            this.Controls.Add(this.btbCambiarPrecio);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.lvwListaInsumos);
            this.Name = "AdministrarInsumos";
            this.Text = "AdministrarInsumos";
            this.Load += new System.EventHandler(this.AdministrarInsumos_Load);
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
    }
}