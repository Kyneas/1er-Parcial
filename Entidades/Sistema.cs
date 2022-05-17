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
        /// <summary>
        /// Clona un Diccionario de int/Alimento generando nuevas direcciones de memoria para la informacion
        /// </summary>
        /// <param name="diccionarioOrigen"></param>
        /// <param name="diccionarioDestino"></param>
        public static void ClonarLista(Dictionary<int, Alimento> diccionarioOrigen, Dictionary<int, Alimento> diccionarioDestino) 
        {
            Dictionary<int, Alimento> copiaDeDiccionario = new Dictionary<int, Alimento>();

            foreach (KeyValuePair<int, Alimento> item in diccionarioOrigen)
            {
                if (item.Value is Comida)
                {
                    diccionarioDestino.Add(item.Key, new Comida(diccionarioOrigen[item.Key].Nombre,
                    diccionarioOrigen[item.Key].Precio, diccionarioOrigen[item.Key].Cantidad, diccionarioOrigen[item.Key].Stock,
                    ((Comida)diccionarioOrigen[item.Key]).Vegano));
                }
                else
                {
                    diccionarioDestino.Add(item.Key, new Bebida(diccionarioOrigen[item.Key].Nombre,
                    diccionarioOrigen[item.Key].Precio, diccionarioOrigen[item.Key].Cantidad, diccionarioOrigen[item.Key].Stock,
                    ((Bebida)diccionarioOrigen[item.Key]).Presentacion));
                }
            }
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
        /// <summary>
        /// Agrega un nuevo usuario al sistema luego de verificar que el DNI no este ingresado previamente
        /// </summary>
        /// <param name="dniString"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="clave"></param>
        /// <param name="esAdmin"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Agrega la venta al sistema y aumenta el contador el 1
        /// </summary>
        /// <param name="venta"></param>
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
        /// <summary>
        /// Indica si en el sistema hay un administrador o mas
        /// </summary>
        /// <returns>True si hay 1 solo, False si hay 2 o mas</returns>
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
        /// <summary>
        /// Verifica que string brindado sea un nombre valido , sin permitir el ingreso de numeros
        /// </summary>
        /// <param name="nombreOApellido"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Verifica que el DNI ingresado sea un numero valido y este dentro del rango permitido
        /// </summary>
        /// <param name="stringDni"></param>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static bool EsDNIValido(string stringDni, out int dni) 
        {
            if (int.TryParse(stringDni, out dni) && dni > 0 && dni < 45000000)
                return true;
            return false;
        }
        /// <summary>
        /// Valida que el precio ingresado sea valido y no sea negativo.
        /// </summary>
        /// <param name="stringPrecio"></param>
        /// <param name="precio"></param>
        /// <returns>True en caso de ser valido y retorna el valor por out, False caso contrario y un cero por out</returns>
        public static bool EsPrecioValido(string stringPrecio, out float precio) 
        {
            if (float.TryParse(stringPrecio, out precio) && precio > 0)
                return true;
            return false;
        }
        /// <summary>
        /// Valida que el stock ingresado sea valido y no sea negativo
        /// </summary>
        /// <param name="stringStock"></param>
        /// <param name="stock"></param>
        /// <returns>True en caso de ser valido y retorna el valor por out, False caso contrario y un cero por out</returns>
        public static bool EsStockValido(string stringStock, out int stock) 
        {
            if (int.TryParse(stringStock, out stock) && stock >= 0)
                return true;
            return false;
        }
        /// <summary>
        /// Valida que el string ingresado sea un clave valida (Mas de 8 caracteres y al menos 1 minuscula, 1 mayuscula y un numero)
        /// </summary>
        /// <param name="clave"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Verifica si existe un usuario con el DNI brindado en el sistema
        /// </summary>
        /// <param name="dniString"></param>
        /// <returns>El usuario en caso de existir, null caso contrario</returns>
        public static Persona ExisteUsuario(string dniString)
        {
            if (String.Empty != dniString && listaEmpleados.ContainsKey(int.Parse(dniString)))
                return listaEmpleados[int.Parse(dniString)];
                return null;
        }
        /// <summary>
        /// Indica si existe la mesa en el sistema
        /// </summary>
        /// <param name="mesaABuscarString"></param>
        /// <param name="mesaInt"></param>
        /// <returns>True de existir y el valor en int por out, false caso contrario y un cero por out</returns>
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
        /// <summary>
        /// Indica si ya existe un Alimento similar en el sistema
        /// </summary>
        /// <param name="alimento"></param>
        /// <returns></returns>
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
        /// <summary>
        /// Agrega el Alimento al sistema y aumenta el contador en 1
        /// </summary>
        /// <param name="alimento"></param>
        public static void AgregarAlimento(Alimento alimento) 
        {
            listaAlimentos.Add(++idAlimento, alimento);
        }
        /// <summary>
        /// Valida que la clave ingresada sea la correcta para el usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static bool VerificarLogin(Persona usuario, string clave)
        {
            if (usuario.VerificarClaveCorrecta(clave))
                return true;
            return false;
        }
    }
}
