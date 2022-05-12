
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lvwUbicaciones = new System.Windows.Forms.ListView();
            this.lblCuadroUbicaciones_ID = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Ubicacion = new System.Windows.Forms.ColumnHeader();
            this.lblCuadroUbicaciones_Saldo = new System.Windows.Forms.ColumnHeader("(none)");
            this.btbDesloguear = new System.Windows.Forms.Button();
            this.lvwListadoPocoStock = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.txtBuscarMesa = new System.Windows.Forms.TextBox();
            this.btnIrAMesa = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.lblEsAdmn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Location = new System.Drawing.Point(253, 581);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(38, 15);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "label1";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(385, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 42);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lvwUbicaciones
            // 
            this.lvwUbicaciones.BackColor = System.Drawing.Color.Wheat;
            this.lvwUbicaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwUbicaciones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lblCuadroUbicaciones_ID,
            this.lblCuadroUbicaciones_Ubicacion,
            this.lblCuadroUbicaciones_Saldo});
            this.lvwUbicaciones.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvwUbicaciones.HideSelection = false;
            this.lvwUbicaciones.Location = new System.Drawing.Point(12, 41);
            this.lvwUbicaciones.Name = "lvwUbicaciones";
            this.lvwUbicaciones.Size = new System.Drawing.Size(195, 553);
            this.lvwUbicaciones.TabIndex = 3;
            this.lvwUbicaciones.UseCompatibleStateImageBehavior = false;
            this.lvwUbicaciones.View = System.Windows.Forms.View.Details;
            this.lvwUbicaciones.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwUbicaciones_ColumnWidthChanging);
            this.lvwUbicaciones.Click += new System.EventHandler(this.lvwUbicaciones_Click);
            // 
            // lblCuadroUbicaciones_ID
            // 
            this.lblCuadroUbicaciones_ID.Text = "#";
            this.lblCuadroUbicaciones_ID.Width = 35;
            // 
            // lblCuadroUbicaciones_Ubicacion
            // 
            this.lblCuadroUbicaciones_Ubicacion.Text = "Ubicacion";
            this.lblCuadroUbicaciones_Ubicacion.Width = 100;
            // 
            // lblCuadroUbicaciones_Saldo
            // 
            this.lblCuadroUbicaciones_Saldo.Text = "$";
            // 
            // btbDesloguear
            // 
            this.btbDesloguear.FlatAppearance.BorderSize = 0;
            this.btbDesloguear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btbDesloguear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btbDesloguear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btbDesloguear.Image = ((System.Drawing.Image)(resources.GetObject("btbDesloguear.Image")));
            this.btbDesloguear.Location = new System.Drawing.Point(337, 12);
            this.btbDesloguear.Name = "btbDesloguear";
            this.btbDesloguear.Size = new System.Drawing.Size(42, 42);
            this.btbDesloguear.TabIndex = 4;
            this.btbDesloguear.UseVisualStyleBackColor = true;
            this.btbDesloguear.Click += new System.EventHandler(this.btbDesloguear_Click);
            // 
            // lvwListadoPocoStock
            // 
            this.lvwListadoPocoStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvwListadoPocoStock.HideSelection = false;
            this.lvwListadoPocoStock.Location = new System.Drawing.Point(243, 79);
            this.lvwListadoPocoStock.Name = "lvwListadoPocoStock";
            this.lvwListadoPocoStock.Size = new System.Drawing.Size(232, 405);
            this.lvwListadoPocoStock.TabIndex = 5;
            this.lvwListadoPocoStock.UseCompatibleStateImageBehavior = false;
            this.lvwListadoPocoStock.View = System.Windows.Forms.View.Details;
            this.lvwListadoPocoStock.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvwListadoPocoStock_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Insumo";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cantidad";
            // 
            // txtBuscarMesa
            // 
            this.txtBuscarMesa.Location = new System.Drawing.Point(12, 12);
            this.txtBuscarMesa.Name = "txtBuscarMesa";
            this.txtBuscarMesa.PlaceholderText = "Buscar mesa...";
            this.txtBuscarMesa.Size = new System.Drawing.Size(100, 23);
            this.txtBuscarMesa.TabIndex = 6;
            this.txtBuscarMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarMesa_KeyPress);
            // 
            // btnIrAMesa
            // 
            this.btnIrAMesa.Location = new System.Drawing.Point(118, 12);
            this.btnIrAMesa.Name = "btnIrAMesa";
            this.btnIrAMesa.Size = new System.Drawing.Size(31, 23);
            this.btnIrAMesa.TabIndex = 7;
            this.btnIrAMesa.Text = "Ir...";
            this.btnIrAMesa.UseVisualStyleBackColor = true;
            this.btnIrAMesa.Click += new System.EventHandler(this.btnIrAMesa_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(232, 12);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(99, 42);
            this.btnAdmin.TabIndex = 8;
            this.btnAdmin.Text = "Administacion";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // picTest
            // 
            this.picTest.Image = ((System.Drawing.Image)(resources.GetObject("picTest.Image")));
            this.picTest.Location = new System.Drawing.Point(232, 79);
            this.picTest.Name = "picTest";
            this.picTest.Size = new System.Drawing.Size(286, 385);
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTest.TabIndex = 9;
            this.picTest.TabStop = false;
            // 
            // lblEsAdmn
            // 
            this.lblEsAdmn.AutoSize = true;
            this.lblEsAdmn.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEsAdmn.Location = new System.Drawing.Point(350, 581);
            this.lblEsAdmn.Name = "lblEsAdmn";
            this.lblEsAdmn.Size = new System.Drawing.Size(110, 25);
            this.lblEsAdmn.TabIndex = 1;
            this.lblEsAdmn.Text = "Sos Admin";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(551, 617);
            this.ControlBox = false;
            this.Controls.Add(this.picTest);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnIrAMesa);
            this.Controls.Add(this.txtBuscarMesa);
            this.Controls.Add(this.lvwListadoPocoStock);
            this.Controls.Add(this.btbDesloguear);
            this.Controls.Add(this.lvwUbicaciones);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblEsAdmn);
            this.Controls.Add(this.lblBienvenida);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Activated += new System.EventHandler(this.MenuPrincipal_Activated);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ListView lvwUbicaciones;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_ID;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Ubicacion;
        private System.Windows.Forms.ColumnHeader lblCuadroUbicaciones_Saldo;
        private System.Windows.Forms.Button btbDesloguear;
        private System.Windows.Forms.ListView lvwListadoPocoStock;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtBuscarMesa;
        private System.Windows.Forms.Button btnIrAMesa;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.Label lblEsAdmn;
    }
}