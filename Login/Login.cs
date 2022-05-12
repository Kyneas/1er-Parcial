using System;
using System.Windows.Forms;
using Entidades;

namespace Bar
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSoloNumeros.Visible = false;
            lblNoDni.Visible = false;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                lblSoloNumeros.Visible = true;
            }
        }

        private void btnLoguear_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string clave = txtClave.Text;
            Persona usuario = Sistema.ExisteUsuario(dni);

            if (String.Empty != dni)
            {
                if (usuario is not null)
                {
                    if (Sistema.VerificarLogin(usuario, clave))
                    {
                        txtDni.Text = String.Empty;
                        txtClave.Text = String.Empty;
                        MenuPrincipal menuPrincipal = new MenuPrincipal(usuario);
                        this.Hide();
                        if (menuPrincipal.ShowDialog() == DialogResult.Yes)
                        {
                            this.Show();
                        }
                    }
                    else
                    {
                        lblErrorDniClave.Visible = true;
                    }
                }
                else
                {
                    lblErrorDniClave.Visible = true;
                }
            }
            else
            {
                lblNoDni.Visible = true;
            }  
        }
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSoloNumeros.Visible = false;
        }

        private void btnLoguearAdmin_Click(object sender, EventArgs e)
        {
            txtDni.Text = "12";
            txtClave.Text = "asd123";
        }

        private void btnLoguearNoAdmin_Click(object sender, EventArgs e)
        {
            txtDni.Text = "14";
            txtClave.Text = "gf457gfh4";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btbSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Confirma que desea salir?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
