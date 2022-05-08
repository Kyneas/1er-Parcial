
namespace Bar
{
    partial class ConfirmarVenta
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
            this.chbPagaCredito = new System.Windows.Forms.CheckBox();
            this.chbUsaEstacionamiento = new System.Windows.Forms.CheckBox();
            this.lblSaldoParaCerrar = new System.Windows.Forms.Label();
            this.btnConfirmarCerrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lvwAlimentosPedidos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // chbPagaCredito
            // 
            this.chbPagaCredito.AutoSize = true;
            this.chbPagaCredito.Location = new System.Drawing.Point(206, 12);
            this.chbPagaCredito.Name = "chbPagaCredito";
            this.chbPagaCredito.Size = new System.Drawing.Size(115, 19);
            this.chbPagaCredito.TabIndex = 0;
            this.chbPagaCredito.Text = "Paga con credito";
            this.chbPagaCredito.UseVisualStyleBackColor = true;
            // 
            // chbUsaEstacionamiento
            // 
            this.chbUsaEstacionamiento.AutoSize = true;
            this.chbUsaEstacionamiento.Location = new System.Drawing.Point(206, 37);
            this.chbUsaEstacionamiento.Name = "chbUsaEstacionamiento";
            this.chbUsaEstacionamiento.Size = new System.Drawing.Size(136, 19);
            this.chbUsaEstacionamiento.TabIndex = 1;
            this.chbUsaEstacionamiento.Text = "Usa Estacionamiento";
            this.chbUsaEstacionamiento.UseVisualStyleBackColor = true;
            // 
            // lblSaldoParaCerrar
            // 
            this.lblSaldoParaCerrar.AutoSize = true;
            this.lblSaldoParaCerrar.Location = new System.Drawing.Point(206, 200);
            this.lblSaldoParaCerrar.Name = "lblSaldoParaCerrar";
            this.lblSaldoParaCerrar.Size = new System.Drawing.Size(43, 15);
            this.lblSaldoParaCerrar.TabIndex = 3;
            this.lblSaldoParaCerrar.Text = "#Saldo";
            // 
            // btnConfirmarCerrar
            // 
            this.btnConfirmarCerrar.Location = new System.Drawing.Point(12, 221);
            this.btnConfirmarCerrar.Name = "btnConfirmarCerrar";
            this.btnConfirmarCerrar.Size = new System.Drawing.Size(97, 49);
            this.btnConfirmarCerrar.TabIndex = 4;
            this.btnConfirmarCerrar.Text = "Confirmar Cierre";
            this.btnConfirmarCerrar.UseVisualStyleBackColor = true;
            this.btnConfirmarCerrar.Click += new System.EventHandler(this.btnConfirmarCerrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 221);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 49);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lvwAlimentosPedidos
            // 
            this.lvwAlimentosPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwAlimentosPedidos.HideSelection = false;
            this.lvwAlimentosPedidos.Location = new System.Drawing.Point(12, 12);
            this.lvwAlimentosPedidos.Name = "lvwAlimentosPedidos";
            this.lvwAlimentosPedidos.Size = new System.Drawing.Size(188, 203);
            this.lvwAlimentosPedidos.TabIndex = 6;
            this.lvwAlimentosPedidos.UseCompatibleStateImageBehavior = false;
            this.lvwAlimentosPedidos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Item";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 312);
            this.Controls.Add(this.lvwAlimentosPedidos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmarCerrar);
            this.Controls.Add(this.lblSaldoParaCerrar);
            this.Controls.Add(this.chbUsaEstacionamiento);
            this.Controls.Add(this.chbPagaCredito);
            this.Name = "Venta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.Venta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbPagaCredito;
        private System.Windows.Forms.CheckBox chbUsaEstacionamiento;
        private System.Windows.Forms.Label lblSaldoParaCerrar;
        private System.Windows.Forms.Button btnConfirmarCerrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListView lvwAlimentosPedidos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}