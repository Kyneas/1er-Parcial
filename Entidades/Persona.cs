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
    }
}
