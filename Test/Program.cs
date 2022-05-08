using System;
using System.Collections.Generic;
using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Persona> listaEmpleados = new Dictionary<int, Persona>();


            listaEmpleados.Add(123,new Persona("Matias","Ferreira", "1", true));
            listaEmpleados.Add(345,new Persona("ASD","asd", "3", false));
            listaEmpleados.Add(567,new Persona("asdafdsfdsd", "dffffff","5", false));



            
            Console.WriteLine(MostrarEmpleado(listaEmpleados[123]));
            //Console.WriteLine(MostrarEmpleado(listaEmpleados[2]));
            //Console.WriteLine(MostrarEmpleado(listaEmpleados[3]));


            //foreach (KeyValuePair<int,Persona> item in listaEmpleados)
            //{

            //}
        }

        public static string MostrarEmpleado(Persona persona)
        {
            return $"Nombre: {persona.Nombre} Apellido: {persona.Apellido} Es Admin: {persona.EsAdmin}";
        }
    }
}
