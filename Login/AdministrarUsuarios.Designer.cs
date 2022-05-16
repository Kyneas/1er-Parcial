
namespace Bar
{
    partial class AdministrarUsuarios
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
            this.lvwListaUsuariosSistema = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lblListaUsuarios = new System.Windows.Forms.Label();
            this.lblAgregarUsuario = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.chkEsAdministrador = new System.Windows.Forms.CheckBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.lblErrorDni = new System.Windows.Forms.Label();
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.lblErrorClave = new System.Windows.Forms.Label();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwListaUsuariosSistema
            // 
            this.lvwListaUsuariosSistema.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwListaUsuariosSistema.FullRowSelect = true;
            this.lvwListaUsuariosSistema.HideSelection = false;
            this.lvwListaUsuariosSistema.Location = new System.Drawing.Point(32, 40);
            this.lvwListaUsuariosSistema.Name = "lvwListaUsuariosSistema";
            this.lvwListaUsuariosSistema.Size = new System.Drawing.Size(298, 273);
            this.lvwListaUsuariosSistema.TabIndex = 0;
            this.lvwListaUsuariosSistema.UseCompatibleStateImageBehavior = false;
            this.lvwListaUsuariosSistema.View = System.Windows.Forms.View.Details;
            this.lvwListaUsuariosSistema.Click += new System.EventHandler(this.lvwListaUsuariosSistema_Click);
            this.lvwListaUsuariosSistema.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvwListaUsuariosSistema_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DNI";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre Completo";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Admin";
            // 
            // lblListaUsuarios
            // 
            this.lblListaUsuarios.AutoSize = true;
            this.lblListaUsuarios.Location = new System.Drawing.Point(71, 13);
            this.lblListaUsuarios.Name = "lblListaUsuarios";
            this.lblListaUsuarios.Size = new System.Drawing.Size(95, 15);
            this.lblListaUsuarios.TabIndex = 1;
            this.lblListaUsuarios.Text = "Lista de Usuarios";
            // 
            // lblAgregarUsuario
            // 
            this.lblAgregarUsuario.AutoSize = true;
            this.lblAgregarUsuario.Location = new System.Drawing.Point(350, 13);
            this.lblAgregarUsuario.Name = "lblAgregarUsuario";
            this.lblAgregarUsuario.Size = new System.Drawing.Size(126, 15);
            this.lblAgregarUsuario.TabIndex = 2;
            this.lblAgregarUsuario.Text = "Agrega Nuevo Usuario";
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(350, 50);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(30, 15);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(350, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(350, 132);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(350, 170);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(39, 15);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Clave:";
            // 
            // chkEsAdministrador
            // 
            this.chkEsAdministrador.AutoSize = true;
            this.chkEsAdministrador.Location = new System.Drawing.Point(350, 221);
            this.chkEsAdministrador.Name = "chkEsAdministrador";
            this.chkEsAdministrador.Size = new System.Drawing.Size(114, 19);
            this.chkEsAdministrador.TabIndex = 7;
            this.chkEsAdministrador.Text = "Es administrador";
            this.chkEsAdministrador.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(427, 50);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 23);
            this.txtDNI.TabIndex = 8;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(427, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(427, 132);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 10;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(427, 170);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 23);
            this.txtClave.TabIndex = 11;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(128, 319);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(117, 48);
            this.btnEliminarUsuario.TabIndex = 12;
            this.btnEliminarUsuario.Text = "Eliminar Usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(410, 319);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(117, 48);
            this.btnCrearUsuario.TabIndex = 13;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // lblErrorDni
            // 
            this.lblErrorDni.AutoSize = true;
            this.lblErrorDni.Location = new System.Drawing.Point(533, 53);
            this.lblErrorDni.Name = "lblErrorDni";
            this.lblErrorDni.Size = new System.Drawing.Size(0, 15);
            this.lblErrorDni.TabIndex = 14;
            this.lblErrorDni.Visible = false;
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Location = new System.Drawing.Point(534, 100);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(79, 15);
            this.lblErrorNombre.TabIndex = 15;
            this.lblErrorNombre.Text = "Error Nombre";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Location = new System.Drawing.Point(534, 139);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(79, 15);
            this.lblErrorApellido.TabIndex = 16;
            this.lblErrorApellido.Text = "Error Apellido";
            this.lblErrorApellido.Visible = false;
            // 
            // lblErrorClave
            // 
            this.lblErrorClave.AutoSize = true;
            this.lblErrorClave.Location = new System.Drawing.Point(534, 177);
            this.lblErrorClave.Name = "lblErrorClave";
            this.lblErrorClave.Size = new System.Drawing.Size(64, 15);
            this.lblErrorClave.TabIndex = 17;
            this.lblErrorClave.Text = "Error Clave";
            this.lblErrorClave.Visible = false;
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNumeros.Location = new System.Drawing.Point(438, 76);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(80, 15);
            this.lblSoloNumeros.TabIndex = 18;
            this.lblSoloNumeros.Text = "Solo numeros";
            this.lblSoloNumeros.Visible = false;
            // 
            // AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 379);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.lblErrorClave);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.lblErrorDni);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.chkEsAdministrador);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblAgregarUsuario);
            this.Controls.Add(this.lblListaUsuarios);
            this.Controls.Add(this.lvwListaUsuariosSistema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministrarUsuarios";
            this.Text = "AdministrarUsuarios";
            this.Load += new System.EventHandler(this.AdministrarUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaUsuariosSistema;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblListaUsuarios;
        private System.Windows.Forms.Label lblAgregarUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.CheckBox chkEsAdministrador;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label lblErrorDni;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.Label lblErrorClave;
        private System.Windows.Forms.Label lblSoloNumeros;
    }
}