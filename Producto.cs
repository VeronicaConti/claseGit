using System;

namespace MiPrimerPrograma
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, decimal precio, int stock)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Producto: " + Nombre + ", Precio: " + Precio + ", Stock: " + Stock);
        }

        public void ActualizarStock(int cantidad)
        {
            Stock += cantidad;
        }
    }
}
