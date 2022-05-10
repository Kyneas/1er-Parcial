using System;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string clave;
        private bool esAdmin;

        public Persona(string nombre, string apellido, string clave, bool esAdmin)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.esAdmin = esAdmin;
        }

        public string Nombre
        {
            get { return nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { this.apellido = value; }
        }

        public string NombreCompleto 
        {
            get { return GenerarNombreCompleto(); }
        }

        private string GenerarNombreCompleto() 
        {
            string nombreCompleto = this.nombre;
            nombreCompleto += " ";
            nombreCompleto += this.apellido;
            return nombreCompleto;
        }

        public bool EsAdmin
        {
            get { return this.esAdmin; }
            set { this.esAdmin = value; }
        }

        public bool VerificarClaveCorrecta(string clave)
        {
            if (clave == this.clave)
            {
                return true;
            }
            return false;
        }

        public static bool ValidarNombreOApellido(string nombreOApellido)
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

        public static bool ValidarClave(string clave) 
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
    }
}
