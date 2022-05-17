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
    public static class LogicaForms
    {
        /// <summary>
        /// Agrega un fila con 2 columnas a la ListView
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="item1"></param>
        /// <param name="item2"></param>
        /// <returns></returns>
        public static ListViewItem AgregarFilaAListView(ListView lista, string item1, string item2)
        {
            String[] fila = { item1, item2};
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
            return item;
        }
        public static ListViewItem AgregarFilaAListView(ListView lista, string item1, string item2, string item3)
        {
            String[] fila = { item1, item2, item3 };
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
            return item;
        }

        public static ListViewItem AgregarFilaAListView(ListView lista, string item1, string item2, string item3, string item4)
        {
            String[] fila = { item1, item2, item3, item4 };
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
            return item;
        }

        public static ListViewItem AgregarFilaAListView(ListView lista, string item1, string item2, string item3, string item4, string item5, string item6)
        {
            String[] fila = { item1, item2, item3, item4, item5, item6};
            ListViewItem item = new ListViewItem(fila);
            lista.Items.Add(item);
            return item;
        }
        /// <summary>
        /// Cierra cualquier formualario que este dentro del panel
        /// </summary>
        /// <param name="panel"></param>
        public static void CerrarFormulariosDelPanel(Panel panel) 
        {
            foreach (Form item in panel.Controls)
            {
                if (item is Form)
                    item.Dispose();
            }
        }

        public static void CambiarColores(Form formulario) 
        {
            formulario.BackColor = Color.FromArgb(17, 17, 17);

            foreach (var item in formulario.Controls)
            {
                if (item is Button boton)
                {
                    boton.BackColor = Color.FromArgb(238, 154, 73);
                    boton.FlatStyle = FlatStyle.Flat;
                    boton.FlatAppearance.BorderColor = Color.FromArgb(238, 154, 73);
                    boton.FlatAppearance.BorderSize = 0;
                    boton.Font = new Font("Calibri", 12, FontStyle.Bold);
                    boton.ForeColor = Color.FromArgb(41, 36, 33);

                    if (boton.Tag is not null && boton.Tag.ToString() == "conImagen") 
                    {
                        boton.FlatAppearance.MouseOverBackColor = Color.FromArgb(221, 169, 120);
                        boton.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 105, 36);
                    }
                }
                if (item is Label label) 
                {
                    label.Font = new Font("Calibri", 12, FontStyle.Bold);
                    label.ForeColor = Color.FromArgb(242, 242, 242);
                    if (label.Tag is not null && label.Tag.ToString() == "Error")
                    {
                        label.Font = new Font("Calibri", 16, FontStyle.Bold);
                        label.ForeColor = Color.FromArgb(255, 163, 163);
                    }
                        
                }

                if (item is ListView listView)
                {
                    listView.BackColor = Color.FromArgb(40, 40, 40);
                    listView.Font = new Font("Calibri", 13, FontStyle.Bold);
                    listView.ForeColor = Color.FromArgb(242, 242, 242);
                    if (listView.Tag is not null && listView.Tag.ToString() == "usacolor")
                    {
                        listView.ForeColor = Color.Black;
                    }
                }

                if (item is CheckBox checkBox) 
                {
                    checkBox.Font = new Font("Calibri", 13, FontStyle.Bold);
                    checkBox.ForeColor = Color.FromArgb(242, 242, 242);
                }

                if (item is ComboBox cbo) 
                {
                    cbo.Font = new Font("Calibri", 13, FontStyle.Bold);
                    cbo.BackColor = Color.FromArgb(40, 40, 40);
                    cbo.ForeColor = Color.FromArgb(242, 242, 242);
                }

                if (item is GroupBox gpo)
                {
                    gpo.Font = new Font("Calibri", 11, FontStyle.Regular);
                    gpo.ForeColor = Color.FromArgb(242, 242, 242);
                }

                if (item is RadioButton rdo)
                {
                    rdo.Font = new Font("Calibri", 9, FontStyle.Regular);
                    rdo.ForeColor = Color.FromArgb(242, 242, 242);
                }
            }
        }

}
}
