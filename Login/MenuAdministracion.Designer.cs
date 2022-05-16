
namespace Bar
{
    partial class MenuAdministracion
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
            this.btbAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarAlimento = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.pnlAdministracion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btbAgregarEmpleado
            // 
            this.btbAgregarEmpleado.Location = new System.Drawing.Point(40, 12);
            this.btbAgregarEmpleado.Name = "btbAgregarEmpleado";
            this.btbAgregarEmpleado.Size = new System.Drawing.Size(127, 75);
            this.btbAgregarEmpleado.TabIndex = 0;
            this.btbAgregarEmpleado.Text = "Administrar Usuario";
            this.btbAgregarEmpleado.UseVisualStyleBackColor = true;
            this.btbAgregarEmpleado.Click += new System.EventHandler(this.btbAgregarEmpleado_Click);
            // 
            // btnAgregarAlimento
            // 
            this.btnAgregarAlimento.Location = new System.Drawing.Point(284, 12);
            this.btnAgregarAlimento.Name = "btnAgregarAlimento";
            this.btnAgregarAlimento.Size = new System.Drawing.Size(127, 75);
            this.btnAgregarAlimento.TabIndex = 1;
            this.btnAgregarAlimento.Text = "Insumos";
            this.btnAgregarAlimento.UseVisualStyleBackColor = true;
            this.btnAgregarAlimento.Click += new System.EventHandler(this.btnAgregarAlimento_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Location = new System.Drawing.Point(541, 12);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(127, 75);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // pnlAdministracion
            // 
            this.pnlAdministracion.Location = new System.Drawing.Point(31, 117);
            this.pnlAdministracion.Name = "pnlAdministracion";
            this.pnlAdministracion.Size = new System.Drawing.Size(669, 466);
            this.pnlAdministracion.TabIndex = 3;
            // 
            // MenuAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 611);
            this.Controls.Add(this.pnlAdministracion);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnAgregarAlimento);
            this.Controls.Add(this.btbAgregarEmpleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuAdministracion";
            this.Text = "MenuAdministracion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btbAgregarEmpleado;
        private System.Windows.Forms.Button btnAgregarAlimento;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel pnlAdministracion;
    }
}