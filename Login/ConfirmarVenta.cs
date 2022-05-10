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
    public partial class ConfirmarVenta : Form
    {
        int idMesa;
        Posicion posicion;
        List<Alimento> comidaPedida;
        public ConfirmarVenta()
        {
            InitializeComponent();
        }

        public ConfirmarVenta(int idMesa, Posicion posicion) : this()
        {
            this.idMesa = idMesa;
            this.posicion = posicion;
            this.comidaPedida = new List<Alimento>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void AgregarLaComidaQueSePidioALaListaDelFormulario()
        {
            foreach (Alimento item in posicion.ListaComidaPedida.Values)
            {
                if (item.Cantidad > 0)
                {
                    comidaPedida.Add(item);
                }
            }
        }

        private void AgregarTodasLasComidasPedidasAListView()
        {
            foreach (Alimento item in comidaPedida)
            {
                LogicaForms.AgregarFilaAListView(lvwAlimentosPedidos, item.Cantidad.ToString(), item.NombreCompleto, item.Cantidad.ToString());
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {
            AgregarLaComidaQueSePidioALaListaDelFormulario();
            AgregarTodasLasComidasPedidasAListView();
            this.lblSaldoParaCerrar.Text = posicion.Saldo.ToString();

        }

        private void btnConfirmarCerrar_Click(object sender, EventArgs e)
        {
            Venta ventaEfectuada = new Venta(this.idMesa, this.posicion.Saldo,this.comidaPedida,chbPagaCredito.Checked, chbUsaEstacionamiento.Checked);
            MessageBox.Show(ventaEfectuada.ToString());
            Sistema.listaPosiciones[this.idMesa].VaciarMesa();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }
    }
}
