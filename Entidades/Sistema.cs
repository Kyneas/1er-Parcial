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
            listaEmpleados.Add(34, new Persona("Roberto", "Gomez Bolaños", "gf457gfh4", false));
            listaEmpleados.Add(34576, new Persona("David", "Bisbal", "gf845htr764", true));
            listaEmpleados.Add(45674, new Persona("Pedro", "El Escamoso", "gfgh56hfgf4", false));
        }

        private static void CargarPosicionesHardcodeadas()
        {
            for (int i = 1; i <= 15; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Mesa));
                LlenarMesaConListaAlimentos(listaPosiciones, i);
            }
            for (int i = 16; i <= 20; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Barra));
                LlenarMesaConListaAlimentos(listaPosiciones, i);
            }

        }

        private static void LlenarMesaConListaAlimentos(Dictionary<int,Posicion> listaLugar, int posicion)
        {
            Dictionary<int, Alimento> listaNueva = new Dictionary<int, Alimento>();

            foreach (KeyValuePair<int,Alimento> item in Sistema.listaAlimentos)
            {
                if (item.Value is Comida &&
                    listaLugar[posicion].Lugar == Posicion.Donde.Mesa)
                    listaNueva.Add(item.Key, new Comida(item.Value.Nombre, item.Value.Precio, item.Value.Cantidad, item.Value.Stock, ((Comida)item.Value).Vegano));
                if (item.Value is Bebida)
                    listaNueva.Add(item.Key, new Bebida(item.Value.Nombre, item.Value.Precio, item.Value.Cantidad, item.Value.Stock, ((Bebida)item.Value).Presentacion));
            }

            listaLugar[posicion].ListaComidaPedida = listaNueva;
        }

        private static void CargarAlimentosHardcodeados()
        {
            listaAlimentos.Add(++idAlimento, new Comida("Pizza", 100, 0, 14, true));
            listaAlimentos.Add(++idAlimento, new Comida("Fideos", 70, 0, 14, true));
            listaAlimentos.Add(++idAlimento, new Comida("Milanesa", 90, 0, 14, false));
            listaAlimentos.Add(++idAlimento, new Comida("Asado", 150, 0, 14, false));
            listaAlimentos.Add(++idAlimento, new Bebida("Coca", 40,0, 14, Bebida.Tamanio.Lata_330ml));
            listaAlimentos.Add(++idAlimento, new Bebida("Agua", 25, 0, 14, Bebida.Tamanio.Botella_1500ml));
            listaAlimentos.Add(++idAlimento, new Bebida("Vino", 50, 0, 14, Bebida.Tamanio.Botella_710ml));
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

        public static bool ExisteMesa(string mesaABuscarString, out int mesaInt) 
        {
            if (!string.IsNullOrEmpty(mesaABuscarString) &&
                int.TryParse(mesaABuscarString, out int mesa) &&
                listaPosiciones.ContainsKey(mesa)) 
            {
                mesaInt = mesa;
                return true;
            }
            mesaInt = 0;
            return false;
        }

        public static bool VerificarLogin(Persona usuario, string clave)
        {
            if (usuario.VerificarClaveCorrecta(clave))
                return true;
            return false;
        }
    }
}
