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
            LogicaForms.CambiarColores(this);
            AgregarTodasLasVentas();
        }

        public void AgregarTodasLasVentas()
        {
            lvwListaVentas.Items.Clear();
            foreach (KeyValuePair<int, Venta> item in Sistema.listaVentasEfectuadas)
            {
                LogicaForms.AgregarFilaAListView(lvwListaVentas, item.Key.ToString(), item.Value.FechaVenta.ToString("MM/dd/yyyy h:mm tt"), item.Value.SaldoParcial.ToString(), item.Value.SaldoTotal.ToString(), $"{(item.Value.UsoCredito? "✔" : String.Empty)}", $"{(item.Value.UsoEstacionamiento ? "✔" : String.Empty)}");
            }
        }

        private void lvwListaVentas_Click(object sender, EventArgs e)
        {
            int idVenta = int.Parse(lvwListaVentas.SelectedItems[0].Text);
            MessageBox.Show(Sistema.listaVentasEfectuadas[idVenta].ToString());
        }

        private void lvwListaVentas_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lvwListaVentas.Columns[e.ColumnIndex].Width;
        }
    }
}
