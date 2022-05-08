using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Sistema
    {
        public static Dictionary<int, Persona> listaEmpleados;
        public static Dictionary<int, Posicion> listaPosiciones;
        public static Dictionary<int, Alimento> listaAlimentos;
        public static Dictionary<int, Venta> listaVentasEfectuadas;
        static int idAlimento;

        static Sistema()
        {
            listaEmpleados = new Dictionary<int, Persona>();
            listaPosiciones = new Dictionary<int, Posicion>();
            listaAlimentos = new Dictionary<int, Alimento>();
            listaVentasEfectuadas = new Dictionary<int, Venta>();
            idAlimento = 0;
            CargarUsuariosHardcodeados();
            CargarAlimentosHardcodeados();
            CargarPosicionesHardcodeadas();
        }

        private static void CargarUsuariosHardcodeados()
        {
            listaEmpleados.Add(12, new Persona("Matias", "Ferreira", "asd123", true));
            listaEmpleados.Add(34, new Persona("Roberto", "Bolaños", "gf4", false));
        }

        private static void CargarPosicionesHardcodeadas()
        {
            for (int i = 1; i <= 15; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Mesa, false));
                LlenarMesaConListaAlimentos(listaPosiciones, i);
            }
            for (int i = 16; i <= 20; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Barra, false));
                LlenarMesaConListaAlimentos(listaPosiciones, i);
            }

        }
        /*
         private void MostrarAlimentos(string id, string nombreComida, string precio, string cantidad)
        {
            String[] fila = { id, nombreComida, precio, cantidad };
            ListViewItem item = new ListViewItem(fila);
            this.lvwListaAlimentos.Items.Add(item);
        }

        public void AgregarTodasLosAlimentos()
        {
            foreach (KeyValuePair<int, Alimento> item in lugar.ListaComidaPedida)
            {
                MostrarAlimentos(item.Key.ToString(), item.Value.Nombre, item.Value.Precio.ToString(), item.Value.Cantidad.ToString());
            }
        }*/

        //private static void PasarDeDiccionarioAListView(ListView sdfsdf)
        //{

        //}

        private static void LlenarMesaConListaAlimentos(Dictionary<int,Posicion> listaLugar, int posicion)
        {
            Dictionary<int, Alimento> listaNueva = new Dictionary<int, Alimento>();

            foreach (KeyValuePair<int,Alimento> item in Sistema.listaAlimentos)
            {
                listaNueva.Add(item.Key, new Alimento(item.Value.Nombre, item.Value.Precio, item.Value.Cantidad, item.Value.EsBebida, item.Value.Stock));
            }

            listaLugar[posicion].ListaComidaPedida = listaNueva;
        }

        private static void CargarAlimentosHardcodeados()
        {
            listaAlimentos.Add(++idAlimento, new Alimento("Pizza", 100, 0, false, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Fideos", 70, 0, false, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Milanesa", 90, 0, false, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Asado", 150, 0, false, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Gaseosa", 40,0, true, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Agua", 25, 0, true, 5));
            listaAlimentos.Add(++idAlimento, new Alimento("Vino", 50, 0, true, 5));
        }

        public static bool CrearNuevoUsuario(string dniString, string nombre, string apellido, string clave, bool esAdmin)
        {
            if (!int.TryParse(dniString, out int dni) ||
                listaEmpleados.ContainsKey(dni))
            {
                return false;
            }
            listaEmpleados.Add(dni, new Persona(nombre, apellido, clave, esAdmin));
            return true;
        }

        

        public static bool VerificarUsuarioNuevo(string nombre, string apellido, string clave)
        {
            if (string.IsNullOrEmpty(nombre.Trim()) || 
                string.IsNullOrEmpty(apellido.Trim()) ||
                string.IsNullOrEmpty(clave.Trim()))
            {
                return false;
            }
            return true;
        }

        public static Persona ExisteUsuario(string dniString)
        {
            if (String.Empty != dniString && listaEmpleados.ContainsKey(int.Parse(dniString)))
                return listaEmpleados[int.Parse(dniString)];
                return null;
            
        }

        public static bool VerificarLogin(Persona usuario, string clave)
        {
            if (usuario.VerificarClaveCorrecta(clave))
                return true;
            return false;
        }
    }
}
