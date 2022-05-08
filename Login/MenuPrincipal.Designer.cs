
namespace Bar
{
    partial class MenuPrincipal
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblEsAdmn = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvwUbicaciones = new System.Windows.Forms.ListView();
            this.lblCuadroUbicaciones_ID = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Ubicacion = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Saldo = new System.Windows.Forms.ColumnHeader("(none)");
            this.btbDesloguear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(38, 15);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "label1";
            // 
            // lblEsAdmn
            // 
            this.lblEsAdmn.AutoSize = true;
            this.lblEsAdmn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEsAdmn.Location = new System.Drawing.Point(12, 647);
            this.lblEsAdmn.Name = "lblEsAdmn";
            this.lblEsAdmn.Size = new System.Drawing.Size(186, 25);
            this.lblEsAdmn.TabIndex = 1;
            this.lblEsAdmn.Text = "Sos Admin Wachin";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1177, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvwUbicaciones
            // 
            this.lvwUbicaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lblCuadroUbicaciones_ID,
            this.lblCuadroUbicaciones_Ubicacion,
            this.lblCuadroUbicaciones_Saldo});
            this.lvwUbicaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwUbicaciones.HideSelection = false;
            this.lvwUbicaciones.Location = new System.Drawing.Point(872, 42);
            this.lvwUbicaciones.Name = "lvwUbicaciones";
            this.lvwUbicaciones.Size = new System.Drawing.Size(222, 522);
            this.lvwUbicaciones.TabIndex = 3;
            this.lvwUbicaciones.UseCompatibleStateImageBehavior = false;
            this.lvwUbicaciones.View = System.Windows.Forms.View.Details;
            this.lvwUbicaciones.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwUbicaciones_ColumnWidthChanging);
            this.lvwUbicaciones.Click += new System.EventHandler(this.lvwUbicaciones_Click);
            // 
            // lblCuadroUbicaciones_ID
            // 
            this.lblCuadroUbicaciones_ID.Text = "ID";
            this.lblCuadroUbicaciones_ID.Width = 40;
            // 
            // lblCuadroUbicaciones_Ubicacion
            // 
            this.lblCuadroUbicaciones_Ubicacion.Text = "Ubicacion";
            this.lblCuadroUbicaciones_Ubicacion.Width = 100;
            // 
            // lblCuadroUbicaciones_Saldo
            // 
            this.lblCuadroUbicaciones_Saldo.Text = "Saldo";
            // 
            // btbDesloguear
            // 
            this.btbDesloguear.Location = new System.Drawing.Point(27, 562);
            this.btbDesloguear.Name = "btbDesloguear";
            this.btbDesloguear.Size = new System.Drawing.Size(75, 23);
            this.btbDesloguear.TabIndex = 4;
            this.btbDesloguear.Text = "Desloguear";
            this.btbDesloguear.UseVisualStyleBackColor = true;
            this.btbDesloguear.Click += new System.EventHandler(this.btbDesloguear_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.ControlBox = false;
            this.Controls.Add(this.btbDesloguear);
            this.Controls.Add(this.lvwUbicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEsAdmn);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblEsAdmn;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvwUbicaciones;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_ID;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Ubicacion;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Saldo;
        private System.Windows.Forms.Button btbDesloguear;
    }
}