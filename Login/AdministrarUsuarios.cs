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
            AgregarTodosLosUsuarios();
            this.btnEliminarUsuario.Enabled = false;
        }

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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirma que desea eliminar al usuario {Sistema.listaEmpleados[dniEmpleadoSeleccionado].NombreCompleto}",
                "Confirmar borrar el usuario", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Sistema.listaEmpleados.Remove(dniEmpleadoSeleccionado);
                AgregarTodosLosUsuarios();
            }
            dniEmpleadoSeleccionado = 0;
        }

        private void lvwListaUsuariosSistema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string test = lvwListaUsuariosSistema.SelectedItems[0].Text;
            //dniEmpleadoSeleccionado = int.Parse(lvwListaUsuariosSistema.SelectedItems[0].Text);
        }

        private void lvwListaUsuariosSistema_Click(object sender, EventArgs e)
        {
            this.btnEliminarUsuario.Enabled = false;
            if (lvwListaUsuariosSistema.SelectedItems[0] is not null && lvwListaUsuariosSistema.SelectedItems.Count != 0) 
            {
                this.btnEliminarUsuario.Enabled = true;
                dniEmpleadoSeleccionado = int.Parse(lvwListaUsuariosSistema.SelectedItems[0].Text);
            }
            
        }
    }
}
