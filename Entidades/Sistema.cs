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
        static int idVenta;

        static Sistema()
        {
            listaEmpleados = new Dictionary<int, Persona>();
            listaPosiciones = new Dictionary<int, Posicion>();
            listaAlimentos = new Dictionary<int, Alimento>();
            listaVentasEfectuadas = new Dictionary<int, Venta>();
            idAlimento = 0;
            idVenta = 0;
            CargarUsuariosHardcodeados();
            CargarAlimentosHardcodeados();
            CargarPosicionesHardcodeadas();
        }

        private static void CargarUsuariosHardcodeados()
        {
            listaEmpleados.Add(12, new Persona("Matias", "Ferreira", "asd123", true));
            listaEmpleados.Add(14, new Persona("Roberto", "Gomez Bolaños", "gf457gfh4", false));
            listaEmpleados.Add(15, new Persona("Juan", "Lopez", "gf845htr764", true));
            listaEmpleados.Add(16, new Persona("Pedro", "Perez", "gfgh56hfgf4", false));
        }

        private static void CargarPosicionesHardcodeadas()
        {
            for (int i = 1; i <= 15; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Mesa));
            }
            for (int i = 16; i <= 20; i++)
            {
                listaPosiciones.Add(i, new Posicion(Posicion.Donde.Barra));
            }
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

        public static void AgregarVenta(Venta venta) 
        {
            listaVentasEfectuadas.Add(++idVenta, venta);
        }

        public static Alimento CrearAlimento(string nombre, string precioString, string stockString, bool esVegano) 
        {
            if (float.TryParse(precioString, out float precio) &&
                int.TryParse(stockString, out int stock))
                return new Comida(nombre, precio, 0, stock, esVegano);
            return null;
        }

        public static bool HaySoloUnAdministrador() 
        {
            int contador = 0;
            foreach (Persona persona in listaEmpleados.Values)
            {
                if (persona.EsAdmin)
                    contador++;
            }
            if (contador == 1)
                return true;
            return false;
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

        public static bool EsNombreOApellidoValido(string nombreOApellido)
        {
            if (string.IsNullOrWhiteSpace(nombreOApellido) || nombreOApellido.Length == 1)
                return false;

            foreach (char letra in nombreOApellido)
            {
                if (char.IsDigit(letra))
                    return false;
            }

            return true;
        }

        public static bool EsDNIValido(string stringDni, out int dni) 
        {
            if (int.TryParse(stringDni, out dni) && dni > 0 && dni < 45000000)
                return true;
            return false;
        }

        public static bool EsPrecioValido(string stringPrecio, out float precio) 
        {
            if (float.TryParse(stringPrecio, out precio) && precio > 0)
                return true;
            return false;
        }

        public static bool EsStockValido(string stringStock, out int stock) 
        {
            if (int.TryParse(stringStock, out stock) && stock >= 0)
                return true;
            return false;
        }

        public static bool EsClaveValida(string clave)
        {
            int contadorMinusculas = 0;
            int contadorMayusculas = 0;
            int contadorNumeros = 0;

            if (string.IsNullOrWhiteSpace(clave) || clave.Length < 8)
                return false;

            foreach (char letra in clave)
            {
                if (char.IsLower(letra))
                    contadorMinusculas++;
                if (char.IsUpper(letra))
                    contadorMayusculas++;
                if (char.IsNumber(letra))
                    contadorNumeros++;
            }
            if (contadorMayusculas >= 1 && contadorMinusculas >= 1 && contadorNumeros >= 1)
                return true;

            return false;
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

        public static bool ElAlimentoYaEstaEnLaLista(Alimento alimento) 
        {
           if (alimento is Comida)
            {
                foreach (Alimento item in Sistema.listaAlimentos.Values)
                {
                    if (item is Comida && (Comida)item == (Comida)alimento)
                        return true;
                }
            }

            else
            {
                foreach (Alimento item in Sistema.listaAlimentos.Values)
                {
                    if (item is Bebida && (Bebida)item == (Bebida)alimento)
                        return true;
                }
            }
            return false;
        }

        //public static bool LaBebidaYaEstaEnLaLista(Bebida alimento)
        //{
        //    foreach (Alimento item in listaAlimentos.Values)
        //    {
        //        if (item is Bebida && (Bebida)item == alimento)
        //            return true;
        //    }
        //    return false;
        //}

        public static void AgregarAlimento(Alimento alimento) 
        {
            listaAlimentos.Add(++idAlimento, alimento);
        }

        public static bool VerificarLogin(Persona usuario, string clave)
        {
            if (usuario.VerificarClaveCorrecta(clave))
                return true;
            return false;
        }
    }
}
