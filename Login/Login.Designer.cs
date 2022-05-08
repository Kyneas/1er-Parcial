
namespace Bar
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDni = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.btnLoguear = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblSoloNumeros = new System.Windows.Forms.Label();
            this.lblErrorDniClave = new System.Windows.Forms.Label();
            this.btnLoguearAdmin = new System.Windows.Forms.Button();
            this.btnLoguearNoAdmin = new System.Windows.Forms.Button();
            this.lblNoDni = new System.Windows.Forms.Label();
            this.btbSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(118, 55);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(27, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(118, 118);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(36, 15);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Clave";
            // 
            // btnLoguear
            // 
            this.btnLoguear.Location = new System.Drawing.Point(118, 191);
            this.btnLoguear.Name = "btnLoguear";
            this.btnLoguear.Size = new System.Drawing.Size(100, 23);
            this.btnLoguear.TabIndex = 2;
            this.btnLoguear.Text = "Ingresar";
            this.btnLoguear.UseVisualStyleBackColor = true;
            this.btnLoguear.Click += new System.EventHandler(this.btnLoguear_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(118, 73);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 23);
            this.txtDni.TabIndex = 3;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(118, 136);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 23);
            this.txtClave.TabIndex = 4;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            // 
            // lblSoloNumeros
            // 
            this.lblSoloNumeros.AutoSize = true;
            this.lblSoloNumeros.ForeColor = System.Drawing.Color.Red;
            this.lblSoloNumeros.Location = new System.Drawing.Point(118, 99);
            this.lblSoloNumeros.Name = "lblSoloNumeros";
            this.lblSoloNumeros.Size = new System.Drawing.Size(80, 15);
            this.lblSoloNumeros.TabIndex = 5;
            this.lblSoloNumeros.Text = "Solo numeros";
            this.lblSoloNumeros.Visible = false;
            // 
            // lblErrorDniClave
            // 
            this.lblErrorDniClave.AutoSize = true;
            this.lblErrorDniClave.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDniClave.Location = new System.Drawing.Point(118, 30);
            this.lblErrorDniClave.Name = "lblErrorDniClave";
            this.lblErrorDniClave.Size = new System.Drawing.Size(117, 15);
            this.lblErrorDniClave.TabIndex = 6;
            this.lblErrorDniClave.Text = "DNI/Clave Incorrecta";
            this.lblErrorDniClave.Visible = false;
            // 
            // btnLoguearAdmin
            // 
            this.btnLoguearAdmin.Location = new System.Drawing.Point(24, 238);
            this.btnLoguearAdmin.Name = "btnLoguearAdmin";
            this.btnLoguearAdmin.Size = new System.Drawing.Size(121, 23);
            this.btnLoguearAdmin.TabIndex = 7;
            this.btnLoguearAdmin.Text = "Logueo Admin";
            this.btnLoguearAdmin.UseVisualStyleBackColor = true;
            this.btnLoguearAdmin.Click += new System.EventHandler(this.btnLoguearAdmin_Click);
            // 
            // btnLoguearNoAdmin
            // 
            this.btnLoguearNoAdmin.Location = new System.Drawing.Point(24, 268);
            this.btnLoguearNoAdmin.Name = "btnLoguearNoAdmin";
            this.btnLoguearNoAdmin.Size = new System.Drawing.Size(121, 23);
            this.btnLoguearNoAdmin.TabIndex = 8;
            this.btnLoguearNoAdmin.Text = "Logueo No Admin";
            this.btnLoguearNoAdmin.UseVisualStyleBackColor = true;
            this.btnLoguearNoAdmin.Click += new System.EventHandler(this.btnLoguearNoAdmin_Click);
            // 
            // lblNoDni
            // 
            this.lblNoDni.AutoSize = true;
            this.lblNoDni.ForeColor = System.Drawing.Color.Red;
            this.lblNoDni.Location = new System.Drawing.Point(130, 30);
            this.lblNoDni.Name = "lblNoDni";
            this.lblNoDni.Size = new System.Drawing.Size(79, 15);
            this.lblNoDni.TabIndex = 9;
            this.lblNoDni.Text = "Escriba el DNI";
            this.lblNoDni.Visible = false;
            // 
            // btbSalir
            // 
            this.btbSalir.Location = new System.Drawing.Point(245, 12);
            this.btbSalir.Name = "btbSalir";
            this.btbSalir.Size = new System.Drawing.Size(75, 23);
            this.btbSalir.TabIndex = 10;
            this.btbSalir.Text = "Salir";
            this.btbSalir.UseVisualStyleBackColor = true;
            this.btbSalir.Click += new System.EventHandler(this.btbSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 313);
            this.Controls.Add(this.btbSalir);
            this.Controls.Add(this.lblNoDni);
            this.Controls.Add(this.btnLoguearNoAdmin);
            this.Controls.Add(this.btnLoguearAdmin);
            this.Controls.Add(this.lblErrorDniClave);
            this.Controls.Add(this.lblSoloNumeros);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.btnLoguear);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblDni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnLoguear;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblSoloNumeros;
        private System.Windows.Forms.Label lblErrorDniClave;
        private System.Windows.Forms.Button btnLoguearAdmin;
        private System.Windows.Forms.Button btnLoguearNoAdmin;
        private System.Windows.Forms.Label lblNoDni;
        private System.Windows.Forms.Button btbSalir;
    }
}

