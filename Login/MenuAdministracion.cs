using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bar
{
    public partial class MenuAdministracion : Form
    {
        public MenuAdministracion()
        {
            InitializeComponent();
        }

        private void btbAgregarEmpleado_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(this.pnlAdministracion);

            AdministrarUsuarios adminUsuarios = new AdministrarUsuarios();
            adminUsuarios.TopLevel = false;
            pnlAdministracion.Controls.Add(adminUsuarios);
            adminUsuarios.Show();
        }

        private void btnAgregarAlimento_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(this.pnlAdministracion);

            AdministrarInsumos adminInsumos = new AdministrarInsumos();
            adminInsumos.TopLevel = false;
            pnlAdministracion.Controls.Add(adminInsumos);
            adminInsumos.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            LogicaForms.CerrarFormulariosDelPanel(this.pnlAdministracion);

            AdministrarVentas adminVentas = new AdministrarVentas();
            adminVentas.TopLevel = false;
            pnlAdministracion.Controls.Add(adminVentas);
            adminVentas.Show();
        }
    }
}
