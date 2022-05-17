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
        float saldo;
        public ConfirmarVenta()
        {
            InitializeComponent();
        }

        public ConfirmarVenta(int idMesa, Posicion posicion) : this()
        {
            this.idMesa = idMesa;
            this.posicion = posicion;
            this.comidaPedida = new List<Alimento>();
            this.saldo = posicion.Saldo;
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
            this.lblSaldoParaCerrar.Text = $"Total: {this.saldo}"; 
            LogicaForms.CambiarColores(this);
            this.lblSaldoParaCerrar.Font = new Font("Calibri", 20, FontStyle.Bold);
        }

        private void btnConfirmarCerrar_Click(object sender, EventArgs e)
        {
            Venta ventaEfectuada = new Venta(this.idMesa, this.posicion.Saldo,this.comidaPedida,chbPagaCredito.Checked, chbUsaEstacionamiento.Checked);
            Sistema.AgregarVenta(ventaEfectuada);
            MessageBox.Show(ventaEfectuada.ToString());
            Sistema.listaPosiciones[this.idMesa].ListaComidaPedida.Clear();
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void chbUsaEstacionamiento_MouseClick(object sender, MouseEventArgs e)
        {
            ActualizarSaldoMostrado();
        }

        private void chbPagaCredito_MouseClick(object sender, MouseEventArgs e)
        {
            ActualizarSaldoMostrado();
        }

        private void ActualizarSaldoMostrado() 
        {
            float saldoAMostrar = saldo;
            if (chbPagaCredito.Checked)
                saldoAMostrar *= Venta.RecargoCredito;
            if (chbUsaEstacionamiento.Checked)
                saldoAMostrar += Venta.RecargoEstacionamiento;
            this.lblSaldoParaCerrar.Text = $"Total: {this.saldo}";
        }
    }
}
