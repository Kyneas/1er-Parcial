
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvwUbicaciones = new System.Windows.Forms.ListView();
            this.lblCuadroUbicaciones_ID = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Ubicacion = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Saldo = new System.Windows.Forms.ColumnHeader("(none)");
            this.btbDesloguear = new System.Windows.Forms.Button();
            this.txtBuscarMesa = new System.Windows.Forms.TextBox();
            this.btnIrAMesa = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.pnlAdminArriba = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = global::Bar.Properties.Resources._1492790919_81power_84209;
            this.btnSalir.Location = new System.Drawing.Point(143, 655);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Tag = "conImagen";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvwUbicaciones
            // 
            this.lvwUbicaciones.BackColor = System.Drawing.SystemColors.Control;
            this.lvwUbicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwUbicaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lblCuadroUbicaciones_ID,
            this.lblCuadroUbicaciones_Ubicacion,
            this.lblCuadroUbicaciones_Saldo});
            this.lvwUbicaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwUbicaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lvwUbicaciones.FullRowSelect = true;
            this.lvwUbicaciones.HideSelection = false;
            this.lvwUbicaciones.Location = new System.Drawing.Point(13, 89);
            this.lvwUbicaciones.Name = "lvwUbicaciones";
            this.lvwUbicaciones.Size = new System.Drawing.Size(233, 529);
            this.lvwUbicaciones.TabIndex = 3;
            this.lvwUbicaciones.Tag = "";
            this.lvwUbicaciones.UseCompatibleStateImageBehavior = false;
            this.lvwUbicaciones.View = System.Windows.Forms.View.Details;
            this.lvwUbicaciones.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwUbicaciones_ColumnWidthChanging);
            this.lvwUbicaciones.Click += new System.EventHandler(this.lvwUbicaciones_Click);
            // 
            // lblCuadroUbicaciones_ID
            // 
            this.lblCuadroUbicaciones_ID.Text = "#";
            this.lblCuadroUbicaciones_ID.Width = 40;
            // 
            // lblCuadroUbicaciones_Ubicacion
            // 
            this.lblCuadroUbicaciones_Ubicacion.Text = "Ubicacion";
            this.lblCuadroUbicaciones_Ubicacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblCuadroUbicaciones_Ubicacion.Width = 120;
            // 
            // lblCuadroUbicaciones_Saldo
            // 
            this.lblCuadroUbicaciones_Saldo.Text = "$";
            this.lblCuadroUbicaciones_Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblCuadroUbicaciones_Saldo.Width = 70;
            // 
            // btbDesloguear
            // 
            this.btbDesloguear.BackColor = System.Drawing.Color.Transparent;
            this.btbDesloguear.FlatAppearance.BorderSize = 0;
            this.btbDesloguear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btbDesloguear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btbDesloguear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbDesloguear.Image = global::Bar.Properties.Resources._4213459_common_door_exit_logout_out_signout_115411;
            this.btbDesloguear.Location = new System.Drawing.Point(57, 655);
            this.btbDesloguear.Name = "btbDesloguear";
            this.btbDesloguear.Size = new System.Drawing.Size(42, 42);
            this.btbDesloguear.TabIndex = 4;
            this.btbDesloguear.Tag = "conImagen";
            this.btbDesloguear.UseVisualStyleBackColor = false;
            this.btbDesloguear.Click += new System.EventHandler(this.btbDesloguear_Click);
            // 
            // txtBuscarMesa
            // 
            this.txtBuscarMesa.Location = new System.Drawing.Point(13, 60);
            this.txtBuscarMesa.Name = "txtBuscarMesa";
            this.txtBuscarMesa.PlaceholderText = "Buscar mesa...";
            this.txtBuscarMesa.Size = new System.Drawing.Size(100, 23);
            this.txtBuscarMesa.TabIndex = 6;
            this.txtBuscarMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMesa_KeyPress);
            // 
            // btnIrAMesa
            // 
            this.btnIrAMesa.Location = new System.Drawing.Point(176, 60);
            this.btnIrAMesa.Name = "btnIrAMesa";
            this.btnIrAMesa.Size = new System.Drawing.Size(70, 23);
            this.btnIrAMesa.TabIndex = 7;
            this.btnIrAMesa.Text = "Ir...";
            this.btnIrAMesa.UseVisualStyleBackColor = true;
            this.btnIrAMesa.Click += new System.EventHandler(this.btnIrAMesa_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(12, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(233, 42);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Administracion";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPrincipal.BackgroundImage = global::Bar.Properties.Resources.logo_utnMODIFICADO2;
            this.pnlPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnlPrincipal.Location = new System.Drawing.Point(252, 12);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(808, 703);
            this.pnlPrincipal.TabIndex = 9;
            // 
            // pnlAdminArriba
            // 
            this.pnlAdminArriba.BackColor = System.Drawing.Color.DarkRed;
            this.pnlAdminArriba.Location = new System.Drawing.Point(-2, 0);
            this.pnlAdminArriba.Name = "pnlAdminArriba";
            this.pnlAdminArriba.Size = new System.Drawing.Size(1078, 10);
            this.pnlAdminArriba.TabIndex = 10;
            this.pnlAdminArriba.Visible = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 727);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnIrAMesa);
            this.Controls.Add(this.txtBuscarMesa);
            this.Controls.Add(this.btbDesloguear);
            this.Controls.Add(this.lvwUbicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlAdminArriba);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvwUbicaciones;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_ID;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Ubicacion;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Saldo;
        private System.Windows.Forms.Button btbDesloguear;
        private System.Windows.Forms.TextBox txtBuscarMesa;
        private System.Windows.Forms.Button btnIrAMesa;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Panel pnlAdminArriba;
    }
}