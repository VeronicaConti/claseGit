using System;

namespace MiPrimerPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Ingresar Nombre 
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
            Console.WriteLine("La suma de los dos números es: " + suma); */

            //Arreglo estatico de tamaño fijo
            /*
            string[] frutas = new string[3];
            frutas[0] = "Manzana";
            frutas[1] = "Banana";
            frutas[2] = "Naranja"; */

            //Una forma de recorrer el array
            /* for (int i = 0; i < frutas.Length; i++)
             {
                 Console.WriteLine("Fruta " + (i + 1) + ": " + frutas[i]);
             } */

            //Otra forma de recorrer el array
            /*
            foreach (string fruta in frutas)
            {
                Console.WriteLine("Arreglo: " + fruta);
            }

            //Lista de tamaño dinamico
            List<string> frutas = new List<string>();
            frutas.Add("Manzana");
            frutas.Add("Banana");
            frutas.Add("Naranja");

            foreach (string fruta in frutas)
            {
                Console.WriteLine("Fruta: " + fruta);

            } 

            //Diccionario mas rapido que la Lista
            Dictionary<int, string> frutasDicc = new Dictionary<int, string>();

            frutasDicc.Add(1, "Kiwi");
            frutasDicc.Add(2, "Sandia");
            frutasDicc.Add(3, "Frutilla"); */

            Dictionary<string, int> frutasDicc = new Dictionary<String, int>();

            frutasDicc.Add("Kiwi", 10);
            frutasDicc.Add("Sandia", 99);
            frutasDicc.Add("Frutilla", 100);

            foreach (KeyValuePair<string, int> fruta in frutasDicc)
            {
                Console.WriteLine("Clave: " + fruta.Key + " - Fruta: " + fruta.Value);
            }


        }
    }
}