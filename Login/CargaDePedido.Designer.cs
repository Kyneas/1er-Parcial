
namespace Bar
{
    partial class CargaDePedido
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
            this.lblNumeroMesa = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lvwListaAlimentos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.btbConfirmarPedido = new System.Windows.Forms.Button();
            this.btbCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroMesa
            // 
            this.lblNumeroMesa.AutoSize = true;
            this.lblNumeroMesa.Location = new System.Drawing.Point(24, 60);
            this.lblNumeroMesa.Name = "lblNumeroMesa";
            this.lblNumeroMesa.Size = new System.Drawing.Size(38, 15);
            this.lblNumeroMesa.TabIndex = 0;
            this.lblNumeroMesa.Text = "label1";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.Location = new System.Drawing.Point(208, 291);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(100, 32);
            this.lblSaldo.TabIndex = 1;
            this.lblSaldo.Text = "#Precio";
            // 
            // lvwListaAlimentos
            // 
            this.lvwListaAlimentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvwListaAlimentos.HideSelection = false;
            this.lvwListaAlimentos.Location = new System.Drawing.Point(101, 12);
            this.lvwListaAlimentos.Name = "lvwListaAlimentos";
            this.lvwListaAlimentos.Size = new System.Drawing.Size(332, 262);
            this.lvwListaAlimentos.TabIndex = 3;
            this.lvwListaAlimentos.UseCompatibleStateImageBehavior = false;
            this.lvwListaAlimentos.View = System.Windows.Forms.View.Details;
            this.lvwListaAlimentos.Click += new System.EventHandler(this.lvwListaAlimentos_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 25;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Comida";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cantidad";
            // 
            // btnMenos
            // 
            this.btnMenos.Enabled = false;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMenos.Location = new System.Drawing.Point(358, 280);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(75, 59);
            this.btnMenos.TabIndex = 4;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btbMenos_Click);
            // 
            // btnMas
            // 
            this.btnMas.Enabled = false;
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMas.Location = new System.Drawing.Point(101, 280);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(75, 59);
            this.btnMas.TabIndex = 5;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = true;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Location = new System.Drawing.Point(347, 345);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(86, 51);
            this.btnCerrarMesa.TabIndex = 6;
            this.btnCerrarMesa.Text = "Cerrar Mesa";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            this.btnCerrarMesa.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btbConfirmarPedido
            // 
            this.btbConfirmarPedido.Location = new System.Drawing.Point(222, 345);
            this.btbConfirmarPedido.Name = "btbConfirmarPedido";
            this.btbConfirmarPedido.Size = new System.Drawing.Size(86, 51);
            this.btbConfirmarPedido.TabIndex = 7;
            this.btbConfirmarPedido.Text = "Confirmar Pedido";
            this.btbConfirmarPedido.UseVisualStyleBackColor = true;
            this.btbConfirmarPedido.Click += new System.EventHandler(this.btbConfirmarPedido_Click);
            // 
            // btbCancelar
            // 
            this.btbCancelar.Location = new System.Drawing.Point(101, 345);
            this.btbCancelar.Name = "btbCancelar";
            this.btbCancelar.Size = new System.Drawing.Size(86, 51);
            this.btbCancelar.TabIndex = 8;
            this.btbCancelar.Text = "Cancelar";
            this.btbCancelar.UseVisualStyleBackColor = true;
            this.btbCancelar.Click += new System.EventHandler(this.btbCancelar_Click);
            // 
            // CargaDePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 418);
            this.ControlBox = false;
            this.Controls.Add(this.btbCancelar);
            this.Controls.Add(this.btbConfirmarPedido);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.lvwListaAlimentos);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblNumeroMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CargaDePedido";
            this.Text = "CargaDePedido";
            this.Load += new System.EventHandler(this.CargaDePedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroMesa;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.ListView lvwListaAlimentos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Button btnCerrarMesa;
        private System.Windows.Forms.Button btbConfirmarPedido;
        private System.Windows.Forms.Button btbCancelar;
    }
}