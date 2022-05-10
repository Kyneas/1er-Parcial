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

    }
}
