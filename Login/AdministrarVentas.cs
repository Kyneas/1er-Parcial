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
    public partial class AdministrarVentas : Form
    {
        public AdministrarVentas()
        {
            InitializeComponent();
        }

        private void AdministrarVentas_Load(object sender, EventArgs e)
        {
            AgregarTodasLasVentas();
        }

        public void AgregarTodasLasVentas()
        {
            lvwListaVentas.Items.Clear();
            foreach (KeyValuePair<int, Venta> item in Sistema.listaVentasEfectuadas)
            {
                LogicaForms.AgregarFilaAListView(lvwListaVentas, item.Key.ToString(), item.Value.FechaVenta.ToString());
            }
        }
    }
}
