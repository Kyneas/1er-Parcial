﻿using System;
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
            AdministrarUsuarios adminUsuarios = new AdministrarUsuarios();
            adminUsuarios.ShowDialog();
        }

        private void btnAgregarAlimento_Click(object sender, EventArgs e)
        {
            AdministrarInsumos adminInsumos = new AdministrarInsumos();
            adminInsumos.ShowDialog();
        }
    }
}
