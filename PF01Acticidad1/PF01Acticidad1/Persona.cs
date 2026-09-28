using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PF01Acticidad1
{
    public class Persona
    {
        private string _nombre;
        private int _edad;

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: " + _nombre);
            Console.WriteLine("Edad: " + _edad);
        }
    }
}
