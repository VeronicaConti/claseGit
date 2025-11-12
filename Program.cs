using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingresar Nombre 
            Console.WriteLine("Por favor, ingrese su nombre completo:");
            string nombre = Console.ReadLine();

            // Morstrar Nombre y Fecha
            string fechaHoy = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Fecha de hoy: " + fechaHoy);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Ingrese el primer número:");
            string entrada1 = Console.ReadLine();
            int numero1 = int.Parse(entrada1);

            Console.WriteLine("Ingrese el segundo número:");
            string entrada2 = Console.ReadLine();
            int numero2 = int.Parse(entrada2);

            // Muestra suma para segundo commit
            int suma = numero1 + numero2;
            Console.WriteLine("La suma de los dos números es: " + suma);
        }
    }
}