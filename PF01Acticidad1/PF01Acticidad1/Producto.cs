using System;
using System.Collections.Generic;
using System.Text;

namespace PF01Acticidad1
{
    public class Producto
    {
        private string _nombre { get; set; }
        private decimal _precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {_nombre}, Precio: {_precio:C}");
        }
    }
}
