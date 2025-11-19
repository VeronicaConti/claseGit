using System;
using System.Collections.Generic;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Por favor, ingrese su nombre completo:");
            string nombre = Console.ReadLine();

            string fechaHoy = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Fecha de hoy: " + fechaHoy);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Ingrese el primer número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            int suma = numero1 + numero2;
            Console.WriteLine("La suma de los dos números es: " + suma);
            Console.WriteLine("----------------------------------");

            string[] frutasArray = new string[3];
            frutasArray[0] = "Manzana";
            frutasArray[1] = "Banana";
            frutasArray[2] = "Naranja";

            for (int i = 0; i < frutasArray.Length; i++)
            {
                Console.WriteLine("Fruta " + (i + 1) + ": " + frutasArray[i]);
            }

            foreach (string fruta in frutasArray)
            {
                Console.WriteLine("Arreglo: " + fruta);
            }
            Console.WriteLine("----------------------------------");

            List<string> frutasLista = new List<string>();
            frutasLista.Add("Manzana");
            frutasLista.Add("Banana");
            frutasLista.Add("Naranja");

            foreach (string fruta in frutasLista)
            {
                Console.WriteLine("Fruta: " + fruta);
            }
            Console.WriteLine("----------------------------------");

            Dictionary<int, string> frutasDiccNum = new Dictionary<int, string>();
            frutasDiccNum.Add(1, "Kiwi");
            frutasDiccNum.Add(2, "Sandia");
            frutasDiccNum.Add(3, "Frutilla");

            foreach (KeyValuePair<int, string> fruta in frutasDiccNum)
            {
                Console.WriteLine("Clave: " + fruta.Key + " - Fruta: " + fruta.Value);
            }
            Console.WriteLine("----------------------------------");

            Dictionary<string, int> frutasDiccTexto = new Dictionary<string, int>();
            frutasDiccTexto.Add("Kiwi", 10);
            frutasDiccTexto.Add("Sandia", 99);
            frutasDiccTexto.Add("Frutilla", 100);

            foreach (KeyValuePair<string, int> fruta in frutasDiccTexto)
            {
                Console.WriteLine("Fruta: " + fruta.Key + " - Cantidad: " + fruta.Value);
            }
            Console.WriteLine("----------------------------------");
            

            Funciones funciones = new Funciones();

            int resultado = funciones.Cuadrado(5);
            Console.WriteLine("El cuadrado de 5 es: " + resultado);
            Console.WriteLine("----------------------------------");

            int a = 10;
            int b = 20;

            Console.WriteLine("Antes del intercambio:");
            funciones.Imprimir(a, b);

            funciones.Intercambio(ref a, ref b);

            Console.WriteLine("Después del intercambio:");
            funciones.Imprimir(a, b);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int mayor = funciones.Mayor(num1, num2);
            Console.WriteLine("El mayor entre " + num1 + " y " + num2 + " es: " + mayor);
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Ingrese su sueldo:");
            double sueldo = double.Parse(Console.ReadLine());

            funciones.AumentarDiezPorCiento(ref sueldo);
            Console.WriteLine("Su sueldo con aumento del 10% es: " + sueldo);
            Console.WriteLine("----------------------------------"); 

            Producto producto = new Producto("Notebook Lenovo", 450000, 15);
            producto.MostrarInfo();
            Producto producto2 = new Producto("Celular Samsung ", 300000, 19);
            producto2.MostrarInfo(); 

            // Lista de productos
            List<Producto> productos = new List<Producto>
            {
                new Producto("Notebook RCA", 666000, 5),
                new Producto("Mouse Genius", 9000, 50),
                new Producto("Monitor LCD Philip", 200000, 19)
            };

            // Mostrar los productos con foreach
            Console.WriteLine("Lista de productos:");
            foreach (Producto p in productos)
            {
                p.MostrarInfo();
            }

            Console.WriteLine("-----------------------------------");

            // Actualizo el stock de 2 productos
            productos[0].ActualizarStock(-1); // Vendimos 1 note
            productos[1].ActualizarStock(90); // Recibimos 90 mousses

            Console.WriteLine("Se actualizo el Stock:");
            foreach (Producto p in productos)
            {
                p.MostrarInfo();
            }

            Console.WriteLine("-----------------------------------");

            // Cliente
            Cliente cliente = new Cliente("Lionel Messi", "el10@email.com", "2494-123456");
            cliente.MostrarInfo();

            Console.WriteLine("-----------------------------------");

            // Empleado y Bono
            Empleado empleado = new Empleado("Gianluca Prestiani", "Desarrollador", 990000);
            double bono = empleado.CalcularBono(10);
            Console.WriteLine($"Empleado: {empleado.Nombre}, Cargo: {empleado.Cargo}, Sueldo: {empleado.Sueldo}, Bono 10%: {bono}");
        */

            CuentaBancaria cuenta = new CuentaBancaria("Veronica Conti", 30);

            Console.WriteLine("Titular de la cuenta: " + cuenta.ObtenerTitular());
            Console.WriteLine("Saldo: $" + cuenta.ObtenerSaldo());
            Console.WriteLine("-----------------------------------");

            // 1 deposito
            cuenta.Depositar(50);
            Console.WriteLine("Se depositaron $50");
            Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());

            // Segundo depósito
            cuenta.Depositar(20);
            Console.WriteLine("Se depositaron $20");
            Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());
            Console.WriteLine("-----------------------------------");

            // Primer retiro
            bool retiro1 = cuenta.Retirar(40);
            Console.WriteLine(retiro1 ? "Se retiraron $40" : "Retiro de $40 fallido");
            Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());

            // Segundo retiro
            bool retiro2 = cuenta.Retirar(100);
            Console.WriteLine(retiro2 ? "Se retiraron $100" : "Retiro de $100 fallido");
            Console.WriteLine("Saldo actual: $" + cuenta.ObtenerSaldo());
            Console.WriteLine("-----------------------------------");

            // Saldo final
            Console.WriteLine("Saldo final: $" + cuenta.ObtenerSaldo());
        }
    }
}
