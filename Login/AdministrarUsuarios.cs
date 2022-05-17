using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Bar
{
    public partial class AdministrarUsuarios : Form
    {
        int dniEmpleadoSeleccionado;
        public AdministrarUsuarios()
        {
            InitializeComponent();
            dniEmpleadoSeleccionado = 45;
        }

        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            LogicaForms.CambiarColores(this);
            AgregarTodosLosUsuarios();
        }
        /// <summary>
        /// Agrega todos los usuarios que tiene el Sistema a la listView
        /// </summary>
        public void AgregarTodosLosUsuarios() 
        {
            lvwListaUsuariosSistema.Items.Clear();
            string admin = String.Empty;
            foreach (KeyValuePair<int, Persona> item in Sistema.listaEmpleados)
            {
                if (item.Value.EsAdmin)
                    admin = "✔";
                LogicaForms.AgregarFilaAListView(lvwListaUsuariosSistema, item.Key.ToString(), item.Value.NombreCompleto, admin);
                admin = String.Empty;
            }
        }
        /// <summary>
        /// En caso de que el usuario no sea el ultimo administrador, lo quita definitivamente luego de una confirmacion mas del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (Sistema.HaySoloUnAdministrador() && Sistema.listaEmpleados[dniEmpleadoSeleccionado].EsAdmin)
            {
                MessageBox.Show("Error, no puede eliminar a todos los administradores");
            }
            else 
            {
                if (MessageBox.Show($"Confirma que desea eliminar al usuario {Sistema.listaEmpleados[dniEmpleadoSeleccionado].NombreCompleto}?",
                "Confirmar borrar el usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Sistema.listaEmpleados.Remove(dniEmpleadoSeleccionado);
                    AgregarTodosLosUsuarios();
                    this.btnEliminarUsuario.Enabled = false;
                }
            }
        }

        private void lvwListaUsuariosSistema_Click(object sender, EventArgs e)
        {
            if (lvwListaUsuariosSistema.SelectedItems.Count != 0)
            {
                this.btnEliminarUsuario.Enabled = true;
                dniEmpleadoSeleccionado = int.Parse(lvwListaUsuariosSistema.SelectedItems[0].Text);
            }
        }

        private void lvwListaUsuariosSistema_MouseUp(object sender, MouseEventArgs e)
        {
            if (lvwListaUsuariosSistema.SelectedItems.Count == 0)
            {
                this.btnEliminarUsuario.Enabled = false;
            }
        }
        /// <summary>
        /// Agrega el nuevo usuario en caso de que todos los datos sean correctos y el DNI no se haya cargado previamente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombre.Text;
            string apellido = this.txtApellido.Text;
            string stringDni = this.txtDNI.Text;
            int dni;
            string clave = this.txtClave.Text;
            bool esAdmin = this.chkEsAdministrador.Checked;
            bool datosCorrectos = true;

            this.lblErrorNombre.Visible = false;
            this.lblErrorApellido.Visible = false;
            this.lblErrorClave.Visible = false;
            this.lblErrorDni.Visible = false;

            if (!Sistema.EsNombreOApellidoValido(nombre))
            {
                datosCorrectos = false;
                this.lblErrorNombre.Visible = true;
            }
            if (!Sistema.EsNombreOApellidoValido(apellido)) 
            {
                datosCorrectos = false;
                this.lblErrorApellido.Visible = true;
            }
            if (!Sistema.EsClaveValida(clave)) 
            {
                datosCorrectos = false;
                this.lblErrorClave.Visible = true;
            }
            if (!Sistema.EsDNIValido(stringDni, out dni))
            {
                datosCorrectos = false;
                this.lblErrorDni.Visible = true;
            }
            else if (Sistema.listaEmpleados.ContainsKey(dni))
            {
                datosCorrectos = false;
                MessageBox.Show("El DNI ya esta en el sistema");
            }

            if (datosCorrectos &&
                Sistema.CrearNuevoUsuario(stringDni, nombre, apellido, clave, esAdmin)) 
            {
                MessageBox.Show("Usuario creado con exito");
                AgregarTodosLosUsuarios();
            }

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblSoloNumeros.Visible = false;
            lblErrorDni.Visible = false;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                lblSoloNumeros.Visible = true;
            }
        }

        private void lvwListaUsuariosSistema_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwListaUsuariosSistema.Columns[e.ColumnIndex].Width;
        }
    }
}
